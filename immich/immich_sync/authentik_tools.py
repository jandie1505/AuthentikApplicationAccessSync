import json
from enum import Enum
from uuid import UUID

from authentik_client import User, CoreApi, PaginatedUserList


class SubClaimType(Enum):
    NUMERIC_ID = 1
    UUID = 2
    USERNAME = 3
    EMAIL = 4


def get_sub_claim_type_from_string(sub_claim_type: str) -> SubClaimType | None:
    match sub_claim_type:
        case "numeric_id", "pk":
            return SubClaimType.NUMERIC_ID
        case "uuid":
            return SubClaimType.UUID
        case "username":
            return SubClaimType.USERNAME
        case "email":
            return SubClaimType.EMAIL
    return None


def get_user(api: CoreApi, sub_claim_type: SubClaimType, sub: str) -> User | None:
    match sub_claim_type:
        case SubClaimType.NUMERIC_ID:
            return api.core_users_retrieve(pk=int(sub))
        case SubClaimType.UUID:
            return _get_user_from_uuid(api, UUID(sub))
        case SubClaimType.USERNAME:
            return _get_user_from_username(api, sub)
        case SubClaimType.EMAIL:
            return _get_user_from_email(api, sub)


def _get_user_from_id(api: CoreApi, user_id: str) -> User | None:
    return api.core_users_retrieve(pk=int(user_id))


def _get_user_from_uuid(api: CoreApi, uuid: UUID) -> User | None:
    users: PaginatedUserList = api.core_users_list(uuid=uuid)
    if len(users.results) != 1:
        return None
    return users.results[0]


def _get_user_from_username(api: CoreApi, username: str) -> User | None:
    users: PaginatedUserList = api.core_users_list(username=username)
    if len(users.results) != 1:
        return None
    return users.results[0]


def _get_user_from_email(api: CoreApi, email: str) -> User | None:
    users: PaginatedUserList = api.core_users_list(email=email)
    if len(users.results) != 1:
        return None
    return users.results[0]

