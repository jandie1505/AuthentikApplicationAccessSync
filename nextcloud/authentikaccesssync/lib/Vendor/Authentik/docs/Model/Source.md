# Source

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
**icon_url** | **string** | Get the URL to the source icon | [readonly]
**icon_themed_urls** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ThemedUrls**](ThemedUrls.md) |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
