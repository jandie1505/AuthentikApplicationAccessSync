# EmailStage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**component** | **string** | Get object type so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**flow_set** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowSet[]**](FlowSet.md) |  | [readonly]
**use_global_settings** | **bool** | When enabled, global Email connection settings will be used and connection settings below will be ignored. | [optional]
**host** | **string** |  | [optional]
**port** | **int** |  | [optional]
**username** | **string** |  | [optional]
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
