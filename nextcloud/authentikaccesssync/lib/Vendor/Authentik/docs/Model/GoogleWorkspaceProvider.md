# GoogleWorkspaceProvider

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
**delegated_subject** | **string** |  |
**credentials** | **array<string,mixed>** |  |
**scopes** | **string** |  | [optional]
**exclude_users_service_account** | **bool** |  | [optional]
**filter_group** | **string** |  | [optional]
**user_delete_action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutgoingSyncDeleteAction**](OutgoingSyncDeleteAction.md) |  | [optional]
**group_delete_action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutgoingSyncDeleteAction**](OutgoingSyncDeleteAction.md) |  | [optional]
**default_group_email_domain** | **string** |  |
**sync_page_size** | **int** | Controls the number of objects synced in a single task | [optional]
**sync_page_timeout** | **string** | Timeout for synchronization of a single page | [optional]
**dry_run** | **bool** | When enabled, provider will not modify or create objects in the remote system. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
