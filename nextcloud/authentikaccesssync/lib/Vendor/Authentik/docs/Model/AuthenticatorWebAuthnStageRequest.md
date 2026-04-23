# AuthenticatorWebAuthnStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  |
**configure_flow** | **string** | Flow used by an authenticated user to configure this Stage. If empty, user will not be able to configure this stage. | [optional]
**friendly_name** | **string** |  | [optional]
**user_verification** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserVerificationEnum**](UserVerificationEnum.md) |  | [optional]
**authenticator_attachment** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorAttachmentEnum**](AuthenticatorAttachmentEnum.md) |  | [optional]
**resident_key_requirement** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ResidentKeyRequirementEnum**](ResidentKeyRequirementEnum.md) |  | [optional]
**device_type_restrictions** | **string[]** |  | [optional]
**max_attempts** | **int** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
