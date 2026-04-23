# PatchedFlowRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**slug** | **string** | Visible in the URL. | [optional]
**title** | **string** | Shown as the Title in Flow pages. | [optional]
**designation** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowDesignationEnum**](FlowDesignationEnum.md) | Decides what this Flow is used for. For example, the Authentication flow is redirect to when an un-authenticated user visits authentik. | [optional]
**background** | **string** | Background shown during execution | [optional]
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**compatibility_mode** | **bool** | Enable compatibility mode, increases compatibility with password managers on mobile devices. | [optional]
**layout** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowLayoutEnum**](FlowLayoutEnum.md) |  | [optional]
**denied_action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeniedActionEnum**](DeniedActionEnum.md) | Configure what should happen when a flow denies access to a user. | [optional]
**authentication** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticationEnum**](AuthenticationEnum.md) | Required level of authentication and authorization to access a flow. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
