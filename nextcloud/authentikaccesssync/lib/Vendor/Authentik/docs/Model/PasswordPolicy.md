# PasswordPolicy

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
**password_field** | **string** | Field key to check, field keys defined in Prompt stages are available. | [optional]
**amount_digits** | **int** |  | [optional]
**amount_uppercase** | **int** |  | [optional]
**amount_lowercase** | **int** |  | [optional]
**amount_symbols** | **int** |  | [optional]
**length_min** | **int** |  | [optional]
**symbol_charset** | **string** |  | [optional]
**error_message** | **string** |  | [optional]
**check_static_rules** | **bool** |  | [optional]
**check_have_i_been_pwned** | **bool** |  | [optional]
**check_zxcvbn** | **bool** |  | [optional]
**hibp_allowed_count** | **int** | How many times the password hash is allowed to be on haveibeenpwned | [optional]
**zxcvbn_score_threshold** | **int** | If the zxcvbn score is equal or less than this value, the policy will fail. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
