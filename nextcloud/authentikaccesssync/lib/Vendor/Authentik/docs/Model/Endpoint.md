# Endpoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**provider** | **int** |  |
**provider_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider**](RACProvider.md) |  | [readonly]
**protocol** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProtocolEnum**](ProtocolEnum.md) |  |
**host** | **string** |  |
**settings** | **array<string,mixed>** |  | [optional]
**property_mappings** | **string[]** |  | [optional]
**auth_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointAuthModeEnum**](EndpointAuthModeEnum.md) |  |
**launch_url** | **string** | Build actual launch URL (the provider itself does not have one, just individual endpoints) | [readonly]
**maximum_connections** | **int** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
