# Flow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**policybindingmodel_ptr_id** | **string** |  | [readonly]
**name** | **string** |  |
**slug** | **string** | Visible in the URL. |
**title** | **string** | Shown as the Title in Flow pages. |
**designation** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowDesignationEnum**](FlowDesignationEnum.md) | Decides what this Flow is used for. For example, the Authentication flow is redirect to when an un-authenticated user visits authentik. |
**background** | **string** | Background shown during execution | [optional]
**background_url** | **string** | Get the URL to the background image | [readonly]
**background_themed_urls** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ThemedUrls**](ThemedUrls.md) |  | [readonly]
**stages** | **string[]** |  | [readonly]
**policies** | **string[]** |  | [readonly]
**cache_count** | **int** | Get count of cached flows | [readonly]
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**compatibility_mode** | **bool** | Enable compatibility mode, increases compatibility with password managers on mobile devices. | [optional]
**export_url** | **string** | Get export URL for flow | [readonly]
**layout** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowLayoutEnum**](FlowLayoutEnum.md) |  | [optional]
**denied_action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeniedActionEnum**](DeniedActionEnum.md) | Configure what should happen when a flow denies access to a user. | [optional]
**authentication** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticationEnum**](AuthenticationEnum.md) | Required level of authentication and authorization to access a flow. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
