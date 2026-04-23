# PatchedSettingsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**avatars** | **string** | Configure how authentik should show avatars for users. | [optional]
**default_user_change_name** | **bool** | Enable the ability for users to change their name. | [optional]
**default_user_change_email** | **bool** | Enable the ability for users to change their email address. | [optional]
**default_user_change_username** | **bool** | Enable the ability for users to change their username. | [optional]
**event_retention** | **string** | Events will be deleted after this duration.(Format: weeks&#x3D;3;days&#x3D;2;hours&#x3D;3,seconds&#x3D;2). | [optional]
**reputation_lower_limit** | **int** | Reputation cannot decrease lower than this value. Zero or negative. | [optional]
**reputation_upper_limit** | **int** | Reputation cannot increase higher than this value. Zero or positive. | [optional]
**footer_links** | **mixed** |  | [optional]
**gdpr_compliance** | **bool** | When enabled, all the events caused by a user will be deleted upon the user&#39;s deletion. | [optional]
**impersonation** | **bool** | Globally enable/disable impersonation. | [optional]
**impersonation_require_reason** | **bool** | Require administrators to provide a reason for impersonating a user. | [optional]
**default_token_duration** | **string** | Default token duration | [optional]
**default_token_length** | **int** | Default token length | [optional]
**pagination_default_page_size** | **int** | Default page size for API responses, if no size was requested. | [optional]
**pagination_max_page_size** | **int** | Maximum page size | [optional]
**flags** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSettingsRequestFlags**](PatchedSettingsRequestFlags.md) |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
