# KerberosSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** | Source&#39;s display Name. |
**slug** | **string** | Internal source name, used in URLs. |
**enabled** | **bool** |  | [optional]
**promoted** | **bool** | When enabled, this source will be displayed as a prominent button on the login page, instead of a small icon. | [optional]
**authentication_flow** | **string** | Flow to use when authenticating existing users. | [optional]
**enrollment_flow** | **string** | Flow to use when enrolling new users. | [optional]
**user_property_mappings** | **string[]** |  | [optional]
**group_property_mappings** | **string[]** |  | [optional]
**component** | **string** | Get object component so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**user_matching_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserMatchingModeEnum**](UserMatchingModeEnum.md) | How the source determines if an existing user should be authenticated or a new user enrolled. | [optional]
**managed** | **string** | Objects that are managed by authentik. These objects are created and updated automatically. This flag only indicates that an object can be overwritten by migrations. You can still modify the objects via the API, but expect changes to be overwritten in a later update. | [readonly]
**user_path_template** | **string** |  | [optional]
**icon** | **string** |  | [optional]
**icon_url** | **string** |  | [readonly]
**icon_themed_urls** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ThemedUrls**](ThemedUrls.md) |  | [readonly]
**group_matching_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupMatchingModeEnum**](GroupMatchingModeEnum.md) | How the source determines if an existing group should be used or a new group created. | [optional]
**realm** | **string** | Kerberos realm |
**krb5_conf** | **string** | Custom krb5.conf to use. Uses the system one by default | [optional]
**kadmin_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KadminTypeEnum**](KadminTypeEnum.md) | KAdmin server type | [optional]
**sync_users** | **bool** | Sync users from Kerberos into authentik | [optional]
**sync_users_password** | **bool** | When a user changes their password, sync it back to Kerberos | [optional]
**sync_principal** | **string** | Principal to authenticate to kadmin for sync. | [optional]
**sync_ccache** | **string** | Credentials cache to authenticate to kadmin for sync. Must be in the form TYPE:residual | [optional]
**connectivity** | **array<string,string>** | Get cached source connectivity | [readonly]
**spnego_server_name** | **string** | Force the use of a specific server name for SPNEGO. Must be in the form HTTP@hostname | [optional]
**spnego_ccache** | **string** | Credential cache to use for SPNEGO in form type:residual | [optional]
**password_login_update_internal_password** | **bool** | If enabled, the authentik-stored password will be updated upon login with the Kerberos password backend | [optional]
**sync_outgoing_trigger_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncOutgoingTriggerModeEnum**](SyncOutgoingTriggerModeEnum.md) | When to trigger sync for outgoing providers | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
