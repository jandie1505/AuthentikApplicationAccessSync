# PatchedMutualTLSStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StageModeEnum**](StageModeEnum.md) |  | [optional]
**certificate_authorities** | **string[]** | Configure certificate authorities to validate the certificate against. This option has a higher priority than the &#x60;client_certificate&#x60; option on &#x60;Brand&#x60;. | [optional]
**cert_attribute** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertAttributeEnum**](CertAttributeEnum.md) |  | [optional]
**user_attribute** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAttributeEnum**](UserAttributeEnum.md) |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
