# CaptchaStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  |
**public_key** | **string** | Public key, acquired your captcha Provider. |
**private_key** | **string** | Private key, acquired your captcha Provider. |
**js_url** | **string** |  | [optional]
**api_url** | **string** |  | [optional]
**interactive** | **bool** |  | [optional]
**score_min_threshold** | **float** |  | [optional]
**score_max_threshold** | **float** |  | [optional]
**error_on_invalid_score** | **bool** | When enabled and the received captcha score is outside of the given threshold, the stage will show an error message. When not enabled, the flow will continue, but the data from the captcha will be available in the context for policy decisions | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
