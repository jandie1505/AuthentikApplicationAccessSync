# FlowSet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**policybindingmodel_ptr_id** | **string** |  | [readonly]
**name** | **string** |  |
**slug** | **string** | Visible in the URL. |
**title** | **string** | Shown as the Title in Flow pages. |
**designation** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowDesignationEnum**](FlowDesignationEnum.md) | Decides what this Flow is used for. For example, the Authentication flow is redirect to when an un-authenticated user visits authentik. |
**background_url** | **string** | Get the URL to the background image | [readonly]
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**compatibility_mode** | **bool** | Enable compatibility mode, increases compatibility with password managers on mobile devices. | [optional]
**export_url** | **string** | Get export URL for flow | [readonly]
**layout** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowLayoutEnum**](FlowLayoutEnum.md) |  | [optional]
**denied_action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeniedActionEnum**](DeniedActionEnum.md) | Configure what should happen when a flow denies access to a user. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
