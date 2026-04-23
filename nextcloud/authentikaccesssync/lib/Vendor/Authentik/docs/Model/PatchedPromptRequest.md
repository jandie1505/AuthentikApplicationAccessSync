# PatchedPromptRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**field_key** | **string** | Name of the form field, also used to store the value | [optional]
**label** | **string** |  | [optional]
**type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PromptTypeEnum**](PromptTypeEnum.md) |  | [optional]
**required** | **bool** |  | [optional]
**placeholder** | **string** | Optionally provide a short hint that describes the expected input value. When creating a fixed choice field, enable interpreting as expression and return a list to return multiple choices. | [optional]
**initial_value** | **string** | Optionally pre-fill the input with an initial value. When creating a fixed choice field, enable interpreting as expression and return a list to return multiple default choices. | [optional]
**order** | **int** |  | [optional]
**sub_text** | **string** |  | [optional]
**placeholder_expression** | **bool** |  | [optional]
**initial_value_expression** | **bool** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
