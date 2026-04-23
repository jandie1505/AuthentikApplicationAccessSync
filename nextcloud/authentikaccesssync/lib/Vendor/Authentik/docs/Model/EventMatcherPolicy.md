# EventMatcherPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**execution_logging** | **bool** | When this option is enabled, all executions of this policy will be logged. By default, only execution errors are logged. | [optional]
**component** | **string** | Get object component so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**bound_to** | **int** | Return objects policy is bound to | [readonly]
**action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventActions**](EventActions.md) | Match created events with this action type. When left empty, all action types will be matched. | [optional]
**client_ip** | **string** | Matches Event&#39;s Client IP (strict matching, for network matching use an Expression Policy) | [optional]
**app** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AppEnum**](AppEnum.md) | Match events created by selected application. When left empty, all applications are matched. | [optional]
**model** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ModelEnum**](ModelEnum.md) | Match events created by selected model. When left empty, all models are matched. When an app is selected, all the application&#39;s models are matched. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
