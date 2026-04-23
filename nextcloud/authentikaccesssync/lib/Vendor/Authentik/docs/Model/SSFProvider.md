# SSFProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**name** | **string** |  |
**component** | **string** | Get object component so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**signing_key** | **string** | Key used to sign the SSF Events. |
**token_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token**](Token.md) |  | [readonly]
**oidc_auth_providers** | **int[]** |  | [optional]
**ssf_url** | **string** |  | [readonly]
**event_retention** | **string** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
