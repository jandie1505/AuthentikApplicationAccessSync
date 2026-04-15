import authentik_client
import psycopg2

import authentik.client
from authentik.client import SubClaimType
from authentik_client import CoreApi, PolicyTestResult, PaginatedApplicationList


def get_oauth_users(dsn: str) -> list[dict[str, str]]:
    """Get all Immich users that have an oauthId set (i.e. linked via OIDC)."""
    with psycopg2.connect(dsn) as conn:
        with conn.cursor() as cur:
            cur.execute(
                'SELECT id, "oauthId" FROM "user" WHERE "oauthId" != \'\''
            )
            return [{"id": row[0], "oauthId": row[1]} for row in cur.fetchall()]


def delete_sessions(dsn: str, user_id: str) -> int:
    """Delete all sessions for a user. Returns number of deleted rows."""
    with psycopg2.connect(dsn) as conn:
        with conn.cursor() as cur:
            cur.execute('DELETE FROM "session" WHERE "userId" = %s', (user_id,))
            conn.commit()
            return cur.rowcount


def delete_api_keys(dsn: str, user_id: str) -> int:
    """Delete all API keys for a user. Returns number of deleted rows."""
    with psycopg2.connect(dsn) as conn:
        with conn.cursor() as cur:
            cur.execute('DELETE FROM "api_key" WHERE "userId" = %s', (user_id,))
            conn.commit()
            return cur.rowcount


def sync(dsn: str, api: CoreApi, slug: str, sub_claim_type: SubClaimType) -> None:
    """Main sync: check each Immich OIDC user against Authentik and revoke access if inactive."""
    users: list[dict[str, str]] = get_oauth_users(dsn)
    print(users)

    for user in users:
        user_id: str = user["id"]
        oauth_id: str = user["oauthId"]

        print(user_id, oauth_id)
        sync_user(dsn, user_id, oauth_id, api, slug, sub_claim_type)


def sync_user(dsn: str, user_id: str, oauth_id: str, api: CoreApi, slug: str, sub_claim_type: SubClaimType) -> None:
    ak_user: authentik_client.User | None = authentik.client.get_user(api=api, sub_claim_type=sub_claim_type, sub=oauth_id)
    if not isinstance(ak_user, authentik_client.User):
        print(f"User {user_id} with oauthId {oauth_id} not found in authentik, skipping")
        return

    is_active: bool | None = ak_user.is_active
    if is_active is None:
        print(f"Invalid is_active state for user {user_id} (sub={oauth_id}), skipping")
        return

    has_access: bool = False
    app_list: PaginatedApplicationList = api.core_applications_list(for_user=ak_user.pk, slug=slug)
    for app in app_list.results:
        if app.slug == slug:
            has_access = True
            break

    if is_active and has_access:
        return

    print(f"Revoking access for {user_id} (sub={oauth_id}) (is_active={is_active}, has_access={has_access})")
    sessions_deleted: int = delete_sessions(dsn, user_id)
    keys_deleted: int = delete_api_keys(dsn, user_id)
    print(f"  Deleted {sessions_deleted} session(s) and {keys_deleted} API key(s)")
