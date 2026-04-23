# UserLoginStage

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
**session_duration** | **string** | Determines how long a session lasts. Default of 0 means that the sessions lasts until the browser is closed. (Format: hours&#x3D;-1;minutes&#x3D;-2;seconds&#x3D;-3) | [optional]
**terminate_other_sessions** | **bool** | Terminate all other sessions of the user logging in. | [optional]
**remember_me_offset** | **string** | Offset the session will be extended by when the user picks the remember me option. Default of 0 means that the remember me option will not be shown. (Format: hours&#x3D;-1;minutes&#x3D;-2;seconds&#x3D;-3) | [optional]
**network_binding** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NetworkBindingEnum**](NetworkBindingEnum.md) | Bind sessions created by this stage to the configured network | [optional]
**geoip_binding** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoipBindingEnum**](GeoipBindingEnum.md) | Bind sessions created by this stage to the configured GeoIP location | [optional]
**remember_device** | **string** | When set to a non-zero value, authentik will save a cookie with a longer expiry,to remember the device the user is logging in from. (Format: hours&#x3D;-1;minutes&#x3D;-2;seconds&#x3D;-3) | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
