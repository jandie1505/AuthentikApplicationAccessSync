# PatchedUserWriteStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**user_creation_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserCreationModeEnum**](UserCreationModeEnum.md) |  | [optional]
**create_users_as_inactive** | **bool** | When set, newly created users are inactive and cannot login. | [optional]
**create_users_group** | **string** | Optionally add newly created users to this group. | [optional]
**user_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserTypeEnum**](UserTypeEnum.md) |  | [optional]
**user_path_template** | **string** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
