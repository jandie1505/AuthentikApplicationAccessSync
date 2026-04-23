# LifecycleRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** |  | [readonly]
**name** | **string** |  |
**content_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ContentTypeEnum**](ContentTypeEnum.md) |  |
**object_id** | **string** |  | [optional]
**interval** | **string** |  | [optional]
**grace_period** | **string** |  | [optional]
**reviewer_groups** | **string[]** |  | [optional]
**reviewer_groups_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReviewerGroup[]**](ReviewerGroup.md) |  | [readonly]
**min_reviewers** | **int** |  | [optional]
**min_reviewers_is_per_group** | **bool** |  | [optional]
**reviewers** | **string[]** |  |
**reviewers_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReviewerUser[]**](ReviewerUser.md) |  | [readonly]
**notification_transports** | **string[]** | Select which transports should be used to notify the reviewers. If none are selected, the notification will only be shown in the authentik UI. | [optional]
**target_verbose** | **string** |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
