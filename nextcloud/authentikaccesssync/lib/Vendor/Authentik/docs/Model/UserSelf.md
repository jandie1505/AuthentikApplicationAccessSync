# UserSelf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**username** | **string** | Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only. |
**name** | **string** | User&#39;s display name. |
**is_active** | **bool** | Designates whether this user should be treated as active. Unselect this instead of deleting accounts. | [readonly]
**is_superuser** | **bool** |  | [readonly]
**groups** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserSelfGroups[]**](UserSelfGroups.md) |  | [readonly]
**roles** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserSelfRoles[]**](UserSelfRoles.md) |  | [readonly]
**email** | **string** |  | [optional]
**avatar** | **string** | User&#39;s avatar, either a http/https URL or a data URI | [readonly]
**uid** | **string** |  | [readonly]
**settings** | **array<string,mixed>** | Get user settings with brand and group settings applied | [readonly]
**type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserTypeEnum**](UserTypeEnum.md) |  | [optional]
**system_permissions** | **string[]** | Get all system permissions assigned to the user | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
