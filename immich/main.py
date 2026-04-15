import os
import time

from authentik_client import Configuration, ApiClient, CoreApi

import authentik.client
from authentik.client import SubClaimType
from immich.sync import sync


def main() -> None:

    authentik_config = Configuration(
        host=os.environ["AUTHENTIK_URL"],
        access_token=os.environ["AUTHENTIK_TOKEN"]
    )

    application_slug: str = os.environ["AUTHENTIK_APPLICATION_SLUG"]

    sub_claim: SubClaimType = authentik.client.get_sub_claim_type_from_string(os.environ.get("AUTHENTIK_SUB_CLAIM"))
    if not isinstance(sub_claim, SubClaimType):
        raise TypeError(f"sub_claim must be of type {SubClaimType}")

    immich_db_dsn: str = os.environ["IMMICH_DB_DSN"]

    run(authentik_config, application_slug, sub_claim, immich_db_dsn)


def run(authentik_config: Configuration, application_slug: str, sub_claim: SubClaimType, dsn: str) -> None:
    with ApiClient(authentik_config) as client:
        api = CoreApi(client)
        try:
            sync(dsn=dsn, api=api, slug=application_slug, sub_claim_type=sub_claim)
        except Exception as e:
            print(f"Sync failed: {e}")
        print("Sync complete.")


if __name__ == "__main__":
    main()