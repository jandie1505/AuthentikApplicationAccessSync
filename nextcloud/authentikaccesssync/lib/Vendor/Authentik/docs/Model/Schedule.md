# Schedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** |  | [readonly]
**identifier** | **string** | Unique schedule identifier | [readonly]
**uid** | **string** |  | [readonly]
**actor_name** | **string** | Dramatiq actor to call | [readonly]
**rel_obj_app_label** | **string** |  | [readonly]
**rel_obj_model** | **string** |  | [readonly]
**rel_obj_id** | **string** |  | [optional]
**crontab** | **string** | When to schedule tasks |
**paused** | **bool** | Pause this schedule | [optional]
**next_run** | **\DateTime** |  | [readonly]
**description** | **string** |  | [readonly]
**last_task_status** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LastTaskStatusEnum**](LastTaskStatusEnum.md) |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
