import os

from authentik_client import Configuration, ApiClient, CoreApi

from immich_sync.authentik_tools import SubClaimType, get_sub_claim_type_from_string
from immich_sync.database_client import DatabaseClient
from immich_sync.sync_client import SyncClient


def main() -> None:

    authentik_config = Configuration(
        host=os.environ["AUTHENTIK_URL"],
        access_token=os.environ["AUTHENTIK_TOKEN"]
    )

    application_slug: str = os.environ["AUTHENTIK_APPLICATION_SLUG"]

    sub_claim: SubClaimType = get_sub_claim_type_from_string(os.environ.get("AUTHENTIK_SUB_CLAIM"))
    if not isinstance(sub_claim, SubClaimType):
        raise TypeError(f"sub_claim must be of type {SubClaimType}")

    database_client: DatabaseClient = DatabaseClient(os.environ["IMMICH_DB_DSN"])

    sync_client: SyncClient = SyncClient(database_client, authentik_config, application_slug, sub_claim)
    sync_client.sync()


if __name__ == "__main__":
    main()