# AuthenticatorEmailStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  |
**configure_flow** | **string** | Flow used by an authenticated user to configure this Stage. If empty, user will not be able to configure this stage. | [optional]
**friendly_name** | **string** |  | [optional]
**use_global_settings** | **bool** | When enabled, global Email connection settings will be used and connection settings below will be ignored. | [optional]
**host** | **string** |  | [optional]
**port** | **int** |  | [optional]
**username** | **string** |  | [optional]
**password** | **string** |  | [optional]
**use_tls** | **bool** |  | [optional]
**use_ssl** | **bool** |  | [optional]
**timeout** | **int** |  | [optional]
**from_address** | **string** |  | [optional]
**subject** | **string** |  | [optional]
**token_expiry** | **string** | Time the token sent is valid (Format: hours&#x3D;3,minutes&#x3D;17,seconds&#x3D;300). | [optional]
**template** | **string** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
