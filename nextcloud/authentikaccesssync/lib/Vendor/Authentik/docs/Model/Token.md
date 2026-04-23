# Token

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**managed** | **string** | Objects that are managed by authentik. These objects are created and updated automatically. This flag only indicates that an object can be overwritten by migrations. You can still modify the objects via the API, but expect changes to be overwritten in a later update. | [optional]
**identifier** | **string** |  |
**intent** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\IntentEnum**](IntentEnum.md) |  | [optional]
**user** | **int** |  | [optional]
**user_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\User**](User.md) |  | [readonly]
**description** | **string** |  | [optional]
**expires** | **\DateTime** |  | [optional]
**expiring** | **bool** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
