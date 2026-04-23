# Group

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**num_pk** | **int** |  | [readonly]
**name** | **string** |  |
**is_superuser** | **bool** | Users added to this group will be superusers. | [optional]
**parents** | **string[]** |  | [optional]
**parents_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RelatedGroup[]**](RelatedGroup.md) |  | [readonly]
**users** | **int[]** |  | [optional]
**users_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PartialUser[]**](PartialUser.md) |  | [readonly]
**attributes** | **array<string,mixed>** |  | [optional]
**roles** | **string[]** |  | [optional]
**roles_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role[]**](Role.md) |  | [readonly]
**inherited_roles_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role[]**](Role.md) |  | [readonly]
**children** | **string[]** |  | [readonly]
**children_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RelatedGroup[]**](RelatedGroup.md) |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
