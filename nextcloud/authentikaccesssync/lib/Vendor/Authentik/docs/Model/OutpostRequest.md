# OutpostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  |
**type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostTypeEnum**](OutpostTypeEnum.md) |  |
**providers** | **int[]** |  |
**service_connection** | **string** | Select Service-Connection authentik should use to manage this outpost. Leave empty if authentik should not handle the deployment. | [optional]
**config** | **array<string,mixed>** |  |
**managed** | **string** | Objects that are managed by authentik. These objects are created and updated automatically. This flag only indicates that an object can be overwritten by migrations. You can still modify the objects via the API, but expect changes to be overwritten in a later update. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
