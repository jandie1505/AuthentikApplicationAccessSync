# RACProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**name** | **string** |  |
**authentication_flow** | **string** | Flow used for authentication when the associated application is accessed by an un-authenticated user. | [optional]
**authorization_flow** | **string** | Flow used when authorizing this provider. |
**property_mappings** | **string[]** |  | [optional]
**component** | **string** | Get object component so that we know how to edit the object | [readonly]
**assigned_application_slug** | **string** | Internal application name, used in URLs. | [readonly]
**assigned_application_name** | **string** | Application&#39;s display Name. | [readonly]
**assigned_backchannel_application_slug** | **string** | Internal application name, used in URLs. | [readonly]
**assigned_backchannel_application_name** | **string** | Application&#39;s display Name. | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**settings** | **array<string,mixed>** |  | [optional]
**outpost_set** | **string[]** |  | [readonly]
**connection_expiry** | **string** | Determines how long a session lasts. Default of 0 means that the sessions lasts until the browser is closed. (Format: hours&#x3D;-1;minutes&#x3D;-2;seconds&#x3D;-3) | [optional]
**delete_token_on_disconnect** | **bool** | When set to true, connection tokens will be deleted upon disconnect. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
