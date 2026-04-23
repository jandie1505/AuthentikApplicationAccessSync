# PatchedEventMatcherPolicyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**execution_logging** | **bool** | When this option is enabled, all executions of this policy will be logged. By default, only execution errors are logged. | [optional]
**action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventActions**](EventActions.md) | Match created events with this action type. When left empty, all action types will be matched. | [optional]
**client_ip** | **string** | Matches Event&#39;s Client IP (strict matching, for network matching use an Expression Policy) | [optional]
**app** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AppEnum**](AppEnum.md) | Match events created by selected application. When left empty, all applications are matched. | [optional]
**model** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ModelEnum**](ModelEnum.md) | Match events created by selected model. When left empty, all models are matched. When an app is selected, all the application&#39;s models are matched. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
