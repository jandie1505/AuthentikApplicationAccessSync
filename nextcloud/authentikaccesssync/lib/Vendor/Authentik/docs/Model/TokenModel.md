# TokenModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**provider** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider**](OAuth2Provider.md) |  |
**user** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\User**](User.md) |  |
**is_expired** | **bool** | Check if token is expired yet. | [readonly]
**expires** | **\DateTime** |  | [optional]
**scope** | **string[]** |  |
**id_token** | **string** | Get the token&#39;s id_token as JSON String | [readonly]
**revoked** | **bool** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
