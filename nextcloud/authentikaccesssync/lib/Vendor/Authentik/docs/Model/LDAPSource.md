# LDAPSource

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
**server_uri** | **string** |  |
**peer_certificate** | **string** | Optionally verify the LDAP Server&#39;s Certificate against the CA Chain in this keypair. | [optional]
**client_certificate** | **string** | Client certificate to authenticate against the LDAP Server&#39;s Certificate. | [optional]
**bind_cn** | **string** |  | [optional]
**start_tls** | **bool** |  | [optional]
**sni** | **bool** |  | [optional]
**base_dn** | **string** |  |
**additional_user_dn** | **string** | Prepended to Base DN for User-queries. | [optional]
**additional_group_dn** | **string** | Prepended to Base DN for Group-queries. | [optional]
**user_object_filter** | **string** | Consider Objects matching this filter to be Users. | [optional]
**group_object_filter** | **string** | Consider Objects matching this filter to be Groups. | [optional]
**group_membership_field** | **string** | Field which contains members of a group. | [optional]
**user_membership_attribute** | **string** | Attribute which matches the value of &#x60;group_membership_field&#x60;. | [optional]
**object_uniqueness_field** | **string** | Field which contains a unique Identifier. | [optional]
**password_login_update_internal_password** | **bool** | Update internal authentik password when login succeeds with LDAP | [optional]
**sync_users** | **bool** |  | [optional]
**sync_users_password** | **bool** | When a user changes their password, sync it back to LDAP. This can only be enabled on a single LDAP source. | [optional]
**sync_groups** | **bool** |  | [optional]
**sync_parent_group** | **string** |  | [optional]
**connectivity** | **array<string,array<string,string>>** | Get cached source connectivity | [readonly]
**lookup_groups_from_user** | **bool** | Lookup group membership based on a user attribute instead of a group attribute. This allows nested group resolution on systems like FreeIPA and Active Directory | [optional]
**delete_not_found_objects** | **bool** | Delete authentik users and groups which were previously supplied by this source, but are now missing from it. | [optional]
**sync_outgoing_trigger_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncOutgoingTriggerModeEnum**](SyncOutgoingTriggerModeEnum.md) | When to trigger sync for outgoing providers | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
