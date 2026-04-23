# UserWriteStage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**component** | **string** | Get object type so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**flow_set** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowSet[]**](FlowSet.md) |  | [readonly]
**user_creation_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserCreationModeEnum**](UserCreationModeEnum.md) |  | [optional]
**create_users_as_inactive** | **bool** | When set, newly created users are inactive and cannot login. | [optional]
**create_users_group** | **string** | Optionally add newly created users to this group. | [optional]
**user_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserTypeEnum**](UserTypeEnum.md) |  | [optional]
**user_path_template** | **string** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
