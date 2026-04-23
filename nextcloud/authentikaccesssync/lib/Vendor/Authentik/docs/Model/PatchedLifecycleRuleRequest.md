# PatchedLifecycleRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**content_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ContentTypeEnum**](ContentTypeEnum.md) |  | [optional]
**object_id** | **string** |  | [optional]
**interval** | **string** |  | [optional]
**grace_period** | **string** |  | [optional]
**reviewer_groups** | **string[]** |  | [optional]
**min_reviewers** | **int** |  | [optional]
**min_reviewers_is_per_group** | **bool** |  | [optional]
**reviewers** | **string[]** |  | [optional]
**notification_transports** | **string[]** | Select which transports should be used to notify the reviewers. If none are selected, the notification will only be shown in the authentik UI. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
