from uuid import UUID

import authentik_client
from authentik_client import Configuration, ApiClient, PaginatedUserList, User
from authentik_client.api import core_api

import authentik
from authentik.client import SubClaimType


def main() -> None:
    config: Configuration = Configuration(
        host="https://auth.jandie1505.net/api/v3",
        access_token="pBKVp4van7pEdC4t1cOyehmyig1A4xVPFWjJaB15gy7mksWso4JPFK1JUSkd"
    )

    with authentik_client.ApiClient(config) as ak:
        coreapi = core_api.CoreApi(ak)

        users: PaginatedUserList = coreapi.core_users_list(uuid=UUID("92402ef7-0092-4b3d-8d77-6d8853556035"))
        if len(users.results) != 1:
            return

        user: User = users.results[0]

        print(user.pk, user.uuid, user.username, user.name, user.email, user.is_active)


if __name__ == "__main__":
    main()
