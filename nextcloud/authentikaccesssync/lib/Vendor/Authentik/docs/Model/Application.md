# Application

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** | Application&#39;s display Name. |
**slug** | **string** | Internal application name, used in URLs. |
**provider** | **int** |  | [optional]
**provider_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Provider**](Provider.md) |  | [readonly]
**backchannel_providers** | **int[]** |  | [optional]
**backchannel_providers_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Provider[]**](Provider.md) |  | [readonly]
**launch_url** | **string** | Allow formatting of launch URL | [readonly]
**open_in_new_tab** | **bool** | Open launch URL in a new browser tab or window. | [optional]
**meta_launch_url** | **string** |  | [optional]
**meta_icon** | **string** |  | [optional]
**meta_icon_url** | **string** | Get the URL to the App Icon image | [readonly]
**meta_icon_themed_urls** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ThemedUrls**](ThemedUrls.md) |  | [readonly]
**meta_description** | **string** |  | [optional]
**meta_publisher** | **string** |  | [optional]
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**group** | **string** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
