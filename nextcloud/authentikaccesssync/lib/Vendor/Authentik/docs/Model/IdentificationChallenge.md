# IdentificationChallenge

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**flow_info** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ContextualFlowInfo**](ContextualFlowInfo.md) |  | [optional]
**component** | **string** |  | [optional] [default to 'ak-stage-identification']
**response_errors** | **array<string,\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ErrorDetail[]>** |  | [optional]
**user_fields** | **string[]** |  |
**pending_user_identifier** | **string** |  | [optional]
**password_fields** | **bool** |  |
**allow_show_password** | **bool** |  | [optional] [default to false]
**application_pre** | **string** |  | [optional]
**application_pre_launch** | **string** |  | [optional]
**flow_designation** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowDesignationEnum**](FlowDesignationEnum.md) |  |
**captcha_stage** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CaptchaChallenge**](CaptchaChallenge.md) |  | [optional]
**enroll_url** | **string** |  | [optional]
**recovery_url** | **string** |  | [optional]
**passwordless_url** | **string** |  | [optional]
**primary_action** | **string** |  |
**sources** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LoginSource[]**](LoginSource.md) |  | [optional]
**show_source_labels** | **bool** |  |
**enable_remember_me** | **bool** |  | [optional] [default to true]
**passkey_challenge** | **array<string,mixed>** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
