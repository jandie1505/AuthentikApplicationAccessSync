# AuthenticatorSMSStage

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
**configure_flow** | **string** | Flow used by an authenticated user to configure this Stage. If empty, user will not be able to configure this stage. | [optional]
**friendly_name** | **string** |  | [optional]
**provider** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProviderEnum**](ProviderEnum.md) |  |
**from_number** | **string** |  |
**account_sid** | **string** |  |
**auth** | **string** |  |
**auth_password** | **string** |  | [optional]
**auth_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthTypeEnum**](AuthTypeEnum.md) |  | [optional]
**verify_only** | **bool** | When enabled, the Phone number is only used during enrollment to verify the users authenticity. Only a hash of the phone number is saved to ensure it is not reused in the future. | [optional]
**mapping** | **string** | Optionally modify the payload being sent to custom providers. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
