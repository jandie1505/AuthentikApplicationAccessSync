# ScopeMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**managed** | **string** | Objects that are managed by authentik. These objects are created and updated automatically. This flag only indicates that an object can be overwritten by migrations. You can still modify the objects via the API, but expect changes to be overwritten in a later update. | [optional]
**name** | **string** |  |
**expression** | **string** |  |
**component** | **string** | Get object&#39;s component so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**scope_name** | **string** | Scope name requested by the client |
**description** | **string** | Description shown to the user when consenting. If left empty, the user won&#39;t be informed. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
