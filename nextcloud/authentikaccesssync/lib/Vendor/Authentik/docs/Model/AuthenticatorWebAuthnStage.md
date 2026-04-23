# AuthenticatorWebAuthnStage

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
**user_verification** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserVerificationEnum**](UserVerificationEnum.md) |  | [optional]
**authenticator_attachment** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatorAttachmentEnum**](AuthenticatorAttachmentEnum.md) |  | [optional]
**resident_key_requirement** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ResidentKeyRequirementEnum**](ResidentKeyRequirementEnum.md) |  | [optional]
**device_type_restrictions** | **string[]** |  | [optional]
**device_type_restrictions_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceType[]**](WebAuthnDeviceType.md) |  | [readonly]
**max_attempts** | **int** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
