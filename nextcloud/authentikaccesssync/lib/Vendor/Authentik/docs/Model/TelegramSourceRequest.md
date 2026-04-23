# TelegramSourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** | Source&#39;s display Name. |
**slug** | **string** | Internal source name, used in URLs. |
**enabled** | **bool** |  | [optional]
**promoted** | **bool** | When enabled, this source will be displayed as a prominent button on the login page, instead of a small icon. | [optional]
**authentication_flow** | **string** | Flow to use when authenticating existing users. | [optional]
**enrollment_flow** | **string** | Flow to use when enrolling new users. | [optional]
**user_property_mappings** | **string[]** |  | [optional]
**group_property_mappings** | **string[]** |  | [optional]
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**user_matching_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserMatchingModeEnum**](UserMatchingModeEnum.md) | How the source determines if an existing user should be authenticated or a new user enrolled. | [optional]
**user_path_template** | **string** |  | [optional]
**icon** | **string** |  | [optional]
**bot_username** | **string** | Telegram bot username |
**bot_token** | **string** | Telegram bot token |
**request_message_access** | **bool** | Request access to send messages from your bot. | [optional]
**pre_authentication_flow** | **string** | Flow used before authentication. |

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
