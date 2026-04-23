# ChallengeTypes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**flow_info** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ContextualFlowInfo**](ContextualFlowInfo.md) |  | [optional]
**component** | **string** |  | [optional] [default to 'ak-stage-user-login']
**response_errors** | **array<string,\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ErrorDetail[]>** |  | [optional]
**pending_user** | **string** |  |
**pending_user_avatar** | **string** |  |
**error_message** | **string** |  | [optional]
**client_id** | **string** |  |
**scope** | **string** |  |
**redirect_uri** | **string** |  |
**state** | **string** |  |
**activation_barcode** | **string** |  |
**activation_code** | **string** |  |
**stage_uuid** | **string** |  |
**email** | **string** |  | [optional]
**email_required** | **bool** |  | [optional] [default to true]
**phone_number_required** | **bool** |  | [optional] [default to true]
**codes** | **string[]** |  |
**config_url** | **string** |  |
**device_challenges** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceChallenge[]**](DeviceChallenge.md) |  |
**configuration_stages** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SelectableStage[]**](SelectableStage.md) |  |
**registration** | **array<string,object>** |  |
**url** | **string** |  |
**attrs** | **array<string,string>** |  |
**title** | **string** |  | [optional]
**site_key** | **string** |  |
**js_url** | **string** |  |
**interactive** | **bool** |  |
**header_text** | **string** |  | [optional]
**permissions** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentPermission[]**](ConsentPermission.md) |  |
**additional_permissions** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConsentPermission[]**](ConsentPermission.md) |  |
**token** | **string** |  |
**challenge** | **string** |  |
**challenge_idle_timeout** | **int** |  |
**request_id** | **string** |  |
**error** | **string** |  | [optional]
**traceback** | **string** |  | [optional]
**loading_overlay** | **bool** |  | [optional] [default to false]
**loading_text** | **string** |  |
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
**passkey_challenge** | **array<string,object>** |  | [optional]
**logout_urls** | **array<string,object>[]** |  | [optional]
**post_url** | **string** |  | [optional]
**saml_request** | **string** |  | [optional]
**relay_state** | **string** |  | [optional]
**provider_name** | **string** |  | [optional]
**binding** | **string** |  | [optional]
**redirect_url** | **string** |  | [optional]
**is_complete** | **bool** |  | [optional] [default to false]
**slug** | **string** |  |
**fields** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StagePrompt[]**](StagePrompt.md) |  |
**to** | **string** |  |
**application_name** | **string** |  | [optional]
**application_launch_url** | **string** |  | [optional]
**invalidation_flow_url** | **string** |  | [optional]
**brand_name** | **string** |  |
**body** | **string** |  |
**bot_username** | **string** | Telegram bot username |
**request_message_access** | **bool** |  |

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
