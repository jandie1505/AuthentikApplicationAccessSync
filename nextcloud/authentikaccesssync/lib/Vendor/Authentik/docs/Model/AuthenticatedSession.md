# AuthenticatedSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uuid** | **string** |  | [optional]
**current** | **bool** | Check if session is currently active session | [readonly]
**user_agent** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatedSessionUserAgent**](AuthenticatedSessionUserAgent.md) |  |
**geo_ip** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatedSessionGeoIp**](AuthenticatedSessionGeoIp.md) |  |
**asn** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatedSessionAsn**](AuthenticatedSessionAsn.md) |  |
**user** | **int** |  |
**last_ip** | **string** |  | [readonly]
**last_user_agent** | **string** |  | [readonly]
**last_used** | **\DateTime** |  | [readonly]
**expires** | **\DateTime** |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
