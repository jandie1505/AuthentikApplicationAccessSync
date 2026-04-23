# ProxyOutpostConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**name** | **string** |  |
**internal_host** | **string** |  | [optional]
**external_host** | **string** |  |
**internal_host_ssl_validation** | **bool** | Validate SSL Certificates of upstream servers | [optional]
**client_id** | **string** |  | [optional]
**client_secret** | **string** |  | [optional]
**oidc_configuration** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OpenIDConnectConfiguration**](OpenIDConnectConfiguration.md) |  | [readonly]
**cookie_secret** | **string** |  | [optional]
**certificate** | **string** |  | [optional]
**skip_path_regex** | **string** | Regular expressions for which authentication is not required. Each new line is interpreted as a new Regular Expression. | [optional]
**basic_auth_enabled** | **bool** | Set a custom HTTP-Basic Authentication header based on values from authentik. | [optional]
**basic_auth_password_attribute** | **string** | User/Group Attribute used for the password part of the HTTP-Basic Header. | [optional]
**basic_auth_user_attribute** | **string** | User/Group Attribute used for the user part of the HTTP-Basic Header. If not set, the user&#39;s Email address is used. | [optional]
**mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyMode**](ProxyMode.md) | Enable support for forwardAuth in traefik and nginx auth_request. Exclusive with internal_host. | [optional]
**cookie_domain** | **string** |  | [optional]
**access_token_validity** | **float** | Get token validity as second count | [readonly]
**intercept_header_auth** | **bool** | When enabled, this provider will intercept the authorization header and authenticate requests based on its value. | [optional]
**scopes_to_request** | **string[]** | Get all the scope names the outpost should request, including custom-defined ones | [readonly]
**assigned_application_slug** | **string** | Internal application name, used in URLs. | [readonly]
**assigned_application_name** | **string** | Application&#39;s display Name. | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
