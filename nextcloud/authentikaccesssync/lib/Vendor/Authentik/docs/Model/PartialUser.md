# PartialUser

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**username** | **string** | Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only. |
**name** | **string** | User&#39;s display name. |
**is_active** | **bool** | Designates whether this user should be treated as active. Unselect this instead of deleting accounts. | [optional]
**last_login** | **\DateTime** |  | [optional]
**email** | **string** |  | [optional]
**attributes** | **array<string,mixed>** |  | [optional]
**uid** | **string** |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
