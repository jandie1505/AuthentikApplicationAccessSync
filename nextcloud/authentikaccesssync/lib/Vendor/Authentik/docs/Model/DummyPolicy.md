# DummyPolicy

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
**result** | **bool** |  | [optional]
**wait_min** | **int** |  | [optional]
**wait_max** | **int** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
