# NativeLogoutChallenge

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**flow_info** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ContextualFlowInfo**](ContextualFlowInfo.md) |  | [optional]
**component** | **string** |  | [optional] [default to 'ak-provider-saml-native-logout']
**response_errors** | **array<string,\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ErrorDetail[]>** |  | [optional]
**post_url** | **string** |  | [optional]
**saml_request** | **string** |  | [optional]
**relay_state** | **string** |  | [optional]
**provider_name** | **string** |  | [optional]
**binding** | **string** |  | [optional]
**redirect_url** | **string** |  | [optional]
**is_complete** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
