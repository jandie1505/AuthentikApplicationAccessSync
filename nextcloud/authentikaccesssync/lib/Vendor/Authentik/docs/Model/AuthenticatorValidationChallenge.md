# AuthenticatorValidationChallenge

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**flow_info** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ContextualFlowInfo**](ContextualFlowInfo.md) |  | [optional]
**component** | **string** |  | [optional] [default to 'ak-stage-authenticator-validate']
**response_errors** | **array<string,\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ErrorDetail[]>** |  | [optional]
**pending_user** | **string** |  |
**pending_user_avatar** | **string** |  |
**device_challenges** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceChallenge[]**](DeviceChallenge.md) |  |
**configuration_stages** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SelectableStage[]**](SelectableStage.md) |  |

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
