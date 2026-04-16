import authentik_client

import immich_sync.authentik_tools
from immich_sync.authentik_tools import SubClaimType
from authentik_client import ApiClient, CoreApi, Configuration, PaginatedApplicationList

from immich_sync.database_client import DatabaseClient


class SyncClient:

    def __init__(self, db: DatabaseClient, api_config: Configuration, slug: str, sub_claim_type: SubClaimType):
        self.db = db
        self.api_config = api_config
        self.slug = slug
        self.sub_claim_type = sub_claim_type


    def sync(self):
        with ApiClient(self.api_config) as api_client:
            try:
                api = CoreApi(api_client)
                self._sync_users(api)
            except Exception as e:
                print(f"Sync failed: {e}")
            print("Sync complete.")


    def _sync_users(self, api: CoreApi) -> None:
        """Main sync: check each Immich OIDC user against Authentik and revoke access if inactive."""
        users: list[dict[str, str]] = self.db.get_oauth_users()
        print(users)

        for user in users:
            user_id: str = user["id"]
            oauth_id: str = user["oauthId"]

            self._sync_user(api, user_id, oauth_id)


    def _sync_user(self, api: CoreApi, user_id: str, oauth_id: str) -> None:
        """Synchronizes a single user."""
        ak_user: authentik_client.User | None = immich_sync.authentik_tools.get_user(api=api, sub_claim_type=self.sub_claim_type, sub=oauth_id)
        if not isinstance(ak_user, authentik_client.User):
            self._remove_user_access(user_id, oauth_id, False, None, None)
            return

        is_active: bool | None = ak_user.is_active
        if is_active is None:
            print(f"Invalid is_active state for user {user_id} (sub={oauth_id}), skipping")
            return

        has_access: bool = False
        app_list: PaginatedApplicationList = api.core_applications_list(for_user=ak_user.pk, slug=self.slug)
        for app in app_list.results:
            if app.slug == self.slug:
                has_access = True
                break

        if is_active and has_access:
            return

        self._remove_user_access(user_id, oauth_id, True, is_active, has_access)


    def _remove_user_access(self, user_id: str, oauth_id: str, exist: bool, is_active: bool | None, has_access: bool | None) -> None:
        """Removes a single user."""
        print(f"Revoking access for {user_id} (sub={oauth_id}) (exist={exist}, is_active={is_active}, has_access={has_access})")
        sessions_deleted: int = self.db.delete_sessions(user_id)
        keys_deleted: int = self.db.delete_api_keys(user_id)
        shared_links_deleted: int = self.db.delete_shared_links(user_id)
        print(f"  Deleted {sessions_deleted} session(s), {keys_deleted} API key(s) and {shared_links_deleted} shared link(s)")
