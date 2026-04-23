# NotificationTransport

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportModeEnum**](NotificationTransportModeEnum.md) |  | [optional]
**mode_verbose** | **string** | Return selected mode with a UI Label | [readonly]
**webhook_url** | **string** |  | [optional]
**webhook_mapping_body** | **string** | Customize the body of the request. Mapping should return data that is JSON-serializable. | [optional]
**webhook_mapping_headers** | **string** | Configure additional headers to be sent. Mapping should return a dictionary of key-value pairs | [optional]
**email_subject_prefix** | **string** |  | [optional]
**email_template** | **string** |  | [optional]
**send_once** | **bool** | Only send notification once, for example when sending a webhook into a chat channel. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
