# LifecycleIteration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** |  | [readonly]
**content_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ContentTypeEnum**](ContentTypeEnum.md) |  |
**object_id** | **string** |  | [readonly]
**object_verbose** | **string** |  | [readonly]
**object_admin_url** | **string** |  | [readonly]
**state** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIterationStateEnum**](LifecycleIterationStateEnum.md) |  | [readonly]
**opened_on** | **\DateTime** |  | [readonly]
**grace_period_end** | **\DateTime** |  | [readonly]
**next_review_date** | **\DateTime** |  | [readonly]
**reviews** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Review[]**](Review.md) |  | [readonly]
**user_can_review** | **bool** |  | [readonly]
**reviewer_groups** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReviewerGroup[]**](ReviewerGroup.md) |  | [readonly]
**min_reviewers** | **int** |  | [readonly]
**reviewers** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReviewerUser[]**](ReviewerUser.md) |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
