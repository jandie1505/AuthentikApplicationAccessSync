# SCIMSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** | Source&#39;s display Name. |
**slug** | **string** | Internal source name, used in URLs. |
**enabled** | **bool** |  | [optional]
**user_property_mappings** | **string[]** |  | [optional]
**group_property_mappings** | **string[]** |  | [optional]
**component** | **string** | Get object component so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**managed** | **string** | Objects that are managed by authentik. These objects are created and updated automatically. This flag only indicates that an object can be overwritten by migrations. You can still modify the objects via the API, but expect changes to be overwritten in a later update. | [readonly]
**user_path_template** | **string** |  | [optional]
**root_url** | **string** | Get Root URL | [readonly]
**token_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token**](Token.md) |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
