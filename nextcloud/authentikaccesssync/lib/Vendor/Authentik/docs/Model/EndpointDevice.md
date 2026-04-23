# EndpointDevice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**device_uuid** | **string** |  | [optional]
**pbm_uuid** | **string** |  | [readonly]
**name** | **string** |  |
**access_group** | **string** |  | [optional]
**access_group_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup**](DeviceAccessGroup.md) |  | [optional]
**expiring** | **bool** |  | [optional]
**expires** | **\DateTime** |  | [optional]
**facts** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceFactSnapshot**](DeviceFactSnapshot.md) |  | [readonly]
**attributes** | **array<string,mixed>** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
