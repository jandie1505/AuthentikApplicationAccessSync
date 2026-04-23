# NotificationRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  |
**transports** | **string[]** | Select which transports should be used to notify the user. If none are selected, the notification will only be shown in the authentik UI. | [optional]
**severity** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SeverityEnum**](SeverityEnum.md) | Controls which severity level the created notifications will have. | [optional]
**destination_group** | **string** | Define which group of users this notification should be sent and shown to. If left empty, Notification won&#39;t ben sent. | [optional]
**destination_event_user** | **bool** | When enabled, notification will be sent to user the user that triggered the event.When destination_group is configured, notification is sent to both. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
