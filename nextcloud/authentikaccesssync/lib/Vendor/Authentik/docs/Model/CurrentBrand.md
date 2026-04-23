# CurrentBrand

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**matched_domain** | **string** |  |
**branding_title** | **string** |  |
**branding_logo** | **string** |  |
**branding_logo_themed_urls** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ThemedUrls**](ThemedUrls.md) |  | [readonly]
**branding_favicon** | **string** |  |
**branding_favicon_themed_urls** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ThemedUrls**](ThemedUrls.md) |  | [readonly]
**branding_custom_css** | **string** |  |
**ui_footer_links** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FooterLink[]**](FooterLink.md) |  | [readonly]
**ui_theme** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UiThemeEnum**](UiThemeEnum.md) |  | [readonly] [default to UiThemeEnum::AUTOMATIC]
**flow_authentication** | **string** |  | [optional]
**flow_invalidation** | **string** |  | [optional]
**flow_recovery** | **string** |  | [optional]
**flow_unenrollment** | **string** |  | [optional]
**flow_user_settings** | **string** |  | [optional]
**flow_device_code** | **string** |  | [optional]
**default_locale** | **string** |  | [readonly]
**flags** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CurrentBrandFlags**](CurrentBrandFlags.md) |  |

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
