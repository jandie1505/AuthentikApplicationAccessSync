# CertificateKeyPair

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**fingerprint_sha256** | **string** | SHA256 fingerprint of the certificate | [readonly]
**fingerprint_sha1** | **string** | SHA1 fingerprint of the certificate | [readonly]
**cert_expiry** | **\DateTime** | Certificate expiry date | [readonly]
**cert_subject** | **string** | Certificate subject as RFC4514 string | [readonly]
**private_key_available** | **bool** | Show if this keypair has a private key configured or not | [readonly]
**key_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KeyTypeEnum**](KeyTypeEnum.md) | Key algorithm type detected from the certificate&#39;s public key | [readonly]
**certificate_download_url** | **string** | Get URL to download certificate | [readonly]
**private_key_download_url** | **string** | Get URL to download private key | [readonly]
**managed** | **string** | Objects that are managed by authentik. These objects are created and updated automatically. This flag only indicates that an object can be overwritten by migrations. You can still modify the objects via the API, but expect changes to be overwritten in a later update. | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
