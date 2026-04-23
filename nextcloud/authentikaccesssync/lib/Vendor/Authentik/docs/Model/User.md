# User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**username** | **string** |  |
**name** | **string** | User&#39;s display name. |
**is_active** | **bool** | Designates whether this user should be treated as active. Unselect this instead of deleting accounts. | [optional]
**last_login** | **\DateTime** |  | [optional]
**date_joined** | **\DateTime** |  | [readonly]
**is_superuser** | **bool** |  | [readonly]
**groups** | **string[]** |  | [optional]
**groups_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PartialGroup[]**](PartialGroup.md) |  | [readonly]
**roles** | **string[]** |  | [optional]
**roles_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role[]**](Role.md) |  | [readonly]
**email** | **string** |  | [optional]
**avatar** | **string** | User&#39;s avatar, either a http/https URL or a data URI | [readonly]
**attributes** | **array<string,mixed>** |  | [optional]
**uid** | **string** |  | [readonly]
**path** | **string** |  | [optional]
**type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserTypeEnum**](UserTypeEnum.md) |  | [optional]
**uuid** | **string** |  | [readonly]
**password_change_date** | **\DateTime** |  | [readonly]
**last_updated** | **\DateTime** |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
