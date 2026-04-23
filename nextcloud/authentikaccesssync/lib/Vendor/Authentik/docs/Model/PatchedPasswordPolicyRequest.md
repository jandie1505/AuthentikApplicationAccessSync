# PatchedPasswordPolicyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**execution_logging** | **bool** | When this option is enabled, all executions of this policy will be logged. By default, only execution errors are logged. | [optional]
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
