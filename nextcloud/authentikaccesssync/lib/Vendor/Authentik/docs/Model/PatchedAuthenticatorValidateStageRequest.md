# PatchedAuthenticatorValidateStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**not_configured_action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotConfiguredActionEnum**](NotConfiguredActionEnum.md) |  | [optional]
**device_classes** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceClassesEnum[]**](DeviceClassesEnum.md) | Device classes which can be used to authenticate | [optional]
**configuration_stages** | **string[]** | Stages used to configure Authenticator when user doesn&#39;t have any compatible devices. After this configuration Stage passes, the user is not prompted again. | [optional]
**last_auth_threshold** | **string** | If any of the user&#39;s device has been used within this threshold, this stage will be skipped | [optional]
**webauthn_user_verification** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserVerificationEnum**](UserVerificationEnum.md) | Enforce user verification for WebAuthn devices. | [optional]
**webauthn_allowed_device_types** | **string[]** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
