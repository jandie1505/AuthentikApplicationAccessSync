# SCIMProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**name** | **string** |  |
**property_mappings** | **string[]** |  | [optional]
**property_mappings_group** | **string[]** | Property mappings used for group creation/updating. | [optional]
**component** | **string** | Get object component so that we know how to edit the object | [readonly]
**assigned_backchannel_application_slug** | **string** | Internal application name, used in URLs. | [readonly]
**assigned_backchannel_application_name** | **string** | Application&#39;s display Name. | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**url** | **string** | Base URL to SCIM requests, usually ends in /v2 |
**verify_certificates** | **bool** |  | [optional]
**token** | **string** | Authentication token | [optional]
**auth_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMAuthenticationModeEnum**](SCIMAuthenticationModeEnum.md) |  | [optional]
**auth_oauth** | **string** | OAuth Source used for authentication | [optional]
**auth_oauth_params** | **array<string,mixed>** | Additional OAuth parameters, such as grant_type | [optional]
**compatibility_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CompatibilityModeEnum**](CompatibilityModeEnum.md) | Alter authentik behavior for vendor-specific SCIM implementations. | [optional]
**service_provider_config_cache_timeout** | **string** | Cache duration for ServiceProviderConfig responses. Set minutes&#x3D;0 to disable. | [optional]
**exclude_users_service_account** | **bool** |  | [optional]
**sync_page_size** | **int** | Controls the number of objects synced in a single task | [optional]
**sync_page_timeout** | **string** | Timeout for synchronization of a single page | [optional]
**group_filters** | **string[]** | Group filters used to define sync-scope for groups. | [optional]
**dry_run** | **bool** | When enabled, provider will not modify or create objects in the remote system. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
