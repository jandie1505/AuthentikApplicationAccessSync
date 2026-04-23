# OAuthSourceRequest

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
**group_matching_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupMatchingModeEnum**](GroupMatchingModeEnum.md) | How the source determines if an existing group should be used or a new group created. | [optional]
**provider_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProviderTypeEnum**](ProviderTypeEnum.md) |  |
**request_token_url** | **string** | URL used to request the initial token. This URL is only required for OAuth 1. | [optional]
**authorization_url** | **string** | URL the user is redirect to to conest the flow. | [optional]
**access_token_url** | **string** | URL used by authentik to retrieve tokens. | [optional]
**profile_url** | **string** | URL used by authentik to get user information. | [optional]
**pkce** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PKCEMethodEnum**](PKCEMethodEnum.md) |  | [optional]
**consumer_key** | **string** |  |
**consumer_secret** | **string** |  |
**additional_scopes** | **string** |  | [optional]
**oidc_well_known_url** | **string** |  | [optional]
**oidc_jwks_url** | **string** |  | [optional]
**oidc_jwks** | **array<string,mixed>** |  | [optional]
**authorization_code_auth_method** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthorizationCodeAuthMethodEnum**](AuthorizationCodeAuthMethodEnum.md) | How to perform authentication during an authorization_code token request flow | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
