# PatchedPlexSourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** | Source&#39;s display Name. | [optional]
**slug** | **string** | Internal source name, used in URLs. | [optional]
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
**group_matching_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupMatchingModeEnum**](GroupMatchingModeEnum.md) | How the source determines if an existing group should be used or a new group created. | [optional]
**client_id** | **string** | Client identifier used to talk to Plex. | [optional]
**allowed_servers** | **string[]** | Which servers a user has to be a member of to be granted access. Empty list allows every server. | [optional]
**allow_friends** | **bool** | Allow friends to authenticate, even if you don&#39;t share a server. | [optional]
**plex_token** | **string** | Plex token used to check friends | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
