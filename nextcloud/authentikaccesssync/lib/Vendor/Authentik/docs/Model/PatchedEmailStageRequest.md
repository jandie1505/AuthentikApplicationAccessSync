# PatchedEmailStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**use_global_settings** | **bool** | When enabled, global Email connection settings will be used and connection settings below will be ignored. | [optional]
**host** | **string** |  | [optional]
**port** | **int** |  | [optional]
**username** | **string** |  | [optional]
**password** | **string** |  | [optional]
**use_tls** | **bool** |  | [optional]
**use_ssl** | **bool** |  | [optional]
**timeout** | **int** |  | [optional]
**from_address** | **string** |  | [optional]
**token_expiry** | **string** | Time the token sent is valid (Format: hours&#x3D;3,minutes&#x3D;17,seconds&#x3D;300). | [optional]
**subject** | **string** |  | [optional]
**template** | **string** |  | [optional]
**activate_user_on_success** | **bool** | Activate users upon completion of stage. | [optional]
**recovery_max_attempts** | **int** |  | [optional]
**recovery_cache_timeout** | **string** | The time window used to count recent account recovery attempts. If the number of attempts exceed recovery_max_attempts within this period, further attempts will be rate-limited. (Format: hours&#x3D;1;minutes&#x3D;2;seconds&#x3D;3). | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
