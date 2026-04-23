# PatchedAuthenticatorSMSStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**configure_flow** | **string** | Flow used by an authenticated user to configure this Stage. If empty, user will not be able to configure this stage. | [optional]
**friendly_name** | **string** |  | [optional]
**provider** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProviderEnum**](ProviderEnum.md) |  | [optional]
**from_number** | **string** |  | [optional]
**account_sid** | **string** |  | [optional]
**auth** | **string** |  | [optional]
**auth_password** | **string** |  | [optional]
**auth_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthTypeEnum**](AuthTypeEnum.md) |  | [optional]
**verify_only** | **bool** | When enabled, the Phone number is only used during enrollment to verify the users authenticity. Only a hash of the phone number is saved to ensure it is not reused in the future. | [optional]
**mapping** | **string** | Optionally modify the payload being sent to custom providers. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
