# WSFederationProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **int** |  | [readonly]
**name** | **string** |  |
**authentication_flow** | **string** | Flow used for authentication when the associated application is accessed by an un-authenticated user. | [optional]
**authorization_flow** | **string** | Flow used when authorizing this provider. |
**invalidation_flow** | **string** | Flow used ending the session from a provider. |
**property_mappings** | **string[]** |  | [optional]
**component** | **string** | Get object component so that we know how to edit the object | [readonly]
**assigned_application_slug** | **string** | Internal application name, used in URLs. | [readonly]
**assigned_application_name** | **string** | Application&#39;s display Name. | [readonly]
**assigned_backchannel_application_slug** | **string** | Internal application name, used in URLs. | [readonly]
**assigned_backchannel_application_name** | **string** | Application&#39;s display Name. | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**reply_url** | **string** |  |
**wtrealm** | **string** |  |
**assertion_valid_not_before** | **string** | Assertion valid not before current time + this value (Format: hours&#x3D;-1;minutes&#x3D;-2;seconds&#x3D;-3). | [optional]
**assertion_valid_not_on_or_after** | **string** | Assertion not valid on or after current time + this value (Format: hours&#x3D;1;minutes&#x3D;2;seconds&#x3D;3). | [optional]
**session_valid_not_on_or_after** | **string** | Session not valid on or after current time + this value (Format: hours&#x3D;1;minutes&#x3D;2;seconds&#x3D;3). | [optional]
**name_id_mapping** | **string** | Configure how the NameID value will be created. When left empty, the NameIDPolicy of the incoming request will be considered | [optional]
**authn_context_class_ref_mapping** | **string** | Configure how the AuthnContextClassRef value will be created. When left empty, the AuthnContextClassRef will be set based on which authentication methods the user used to authenticate. | [optional]
**digest_algorithm** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DigestAlgorithmEnum**](DigestAlgorithmEnum.md) |  | [optional]
**signature_algorithm** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SignatureAlgorithmEnum**](SignatureAlgorithmEnum.md) |  | [optional]
**signing_kp** | **string** | Keypair used to sign outgoing Responses going to the Service Provider. | [optional]
**encryption_kp** | **string** | When selected, incoming assertions are encrypted by the IdP using the public key of the encryption keypair. The assertion is decrypted by the SP using the the private key. | [optional]
**sign_assertion** | **bool** |  | [optional]
**sign_logout_request** | **bool** |  | [optional]
**default_name_id_policy** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLNameIDPolicyEnum**](SAMLNameIDPolicyEnum.md) |  | [optional]
**url_download_metadata** | **string** | Get metadata download URL | [readonly]
**url_wsfed** | **string** | Get WS-Fed url | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
