# GeoIPPolicyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  |
**execution_logging** | **bool** | When this option is enabled, all executions of this policy will be logged. By default, only execution errors are logged. | [optional]
**asns** | **int[]** |  | [optional]
**countries** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CountryCodeEnum[]**](CountryCodeEnum.md) |  |
**check_history_distance** | **bool** |  | [optional]
**history_max_distance_km** | **int** |  | [optional]
**distance_tolerance_km** | **int** |  | [optional]
**history_login_count** | **int** |  | [optional]
**check_impossible_travel** | **bool** |  | [optional]
**impossible_tolerance_km** | **int** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
