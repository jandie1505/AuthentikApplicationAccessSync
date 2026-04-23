# IdentificationStage

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
**user_fields** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserFieldsEnum[]**](UserFieldsEnum.md) | Fields of the user object to match against. (Hold shift to select multiple options) | [optional]
**password_stage** | **string** | When set, shows a password field, instead of showing the password field as separate step. | [optional]
**captcha_stage** | **string** | When set, adds functionality exactly like a Captcha stage, but baked into the Identification stage. | [optional]
**case_insensitive_matching** | **bool** | When enabled, user fields are matched regardless of their casing. | [optional]
**show_matched_user** | **bool** | When a valid username/email has been entered, and this option is enabled, the user&#39;s username and avatar will be shown. Otherwise, the text that the user entered will be shown | [optional]
**enrollment_flow** | **string** | Optional enrollment flow, which is linked at the bottom of the page. | [optional]
**recovery_flow** | **string** | Optional recovery flow, which is linked at the bottom of the page. | [optional]
**passwordless_flow** | **string** | Optional passwordless flow, which is linked at the bottom of the page. | [optional]
**sources** | **string[]** | Specify which sources should be shown. | [optional]
**show_source_labels** | **bool** |  | [optional]
**pretend_user_exists** | **bool** | When enabled, the stage will succeed and continue even when incorrect user info is entered. | [optional]
**enable_remember_me** | **bool** | Show the user the &#39;Remember me on this device&#39; toggle, allowing repeat users to skip straight to entering their password. | [optional]
**webauthn_stage** | **string** | When set, and conditional WebAuthn is available, allow the user to use their passkey as a first factor. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
