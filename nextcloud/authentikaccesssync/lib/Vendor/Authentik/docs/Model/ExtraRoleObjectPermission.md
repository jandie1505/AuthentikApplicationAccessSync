# ExtraRoleObjectPermission

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **int** |  | [readonly]
**codename** | **string** |  | [readonly]
**model** | **string** |  | [readonly]
**app_label** | **string** |  | [readonly]
**object_pk** | **string** |  |
**name** | **string** |  | [readonly]
**app_label_verbose** | **string** | Get app label from permission&#39;s model | [readonly]
**model_verbose** | **string** | Get model label from permission&#39;s model | [readonly]
**object_description** | **string** | Get model description from attached model. This operation takes at least one additional query, and the description is only shown if the role has the view_ permission on the object | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
