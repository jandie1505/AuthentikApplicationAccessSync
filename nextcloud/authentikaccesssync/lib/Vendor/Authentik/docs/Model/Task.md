# Task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**message_id** | **string** |  | [optional]
**queue_name** | **string** | Queue name | [optional]
**actor_name** | **string** | Dramatiq actor name |
**state** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TaskStateEnum**](TaskStateEnum.md) | Task status | [optional]
**mtime** | **\DateTime** | Task last modified time | [optional]
**retries** | **int** | Number of retries | [optional]
**eta** | **\DateTime** | Planned execution time | [optional]
**rel_obj_app_label** | **string** |  | [readonly]
**rel_obj_model** | **string** |  | [readonly]
**rel_obj_id** | **string** |  | [optional]
**uid** | **string** |  | [readonly]
**logs** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LogEvent[]**](LogEvent.md) |  | [readonly]
**previous_logs** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LogEvent[]**](LogEvent.md) |  | [readonly]
**aggregated_status** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TaskAggregatedStatusEnum**](TaskAggregatedStatusEnum.md) |  |
**description** | **string** |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
