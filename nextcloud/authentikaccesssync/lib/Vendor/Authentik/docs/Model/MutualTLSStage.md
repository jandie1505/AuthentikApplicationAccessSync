# MutualTLSStage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**component** | **string** | Get object type so that we know how to edit the object | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**flow_set** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowSet[]**](FlowSet.md) |  | [readonly]
**mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StageModeEnum**](StageModeEnum.md) |  |
**certificate_authorities** | **string[]** | Configure certificate authorities to validate the certificate against. This option has a higher priority than the &#x60;client_certificate&#x60; option on &#x60;Brand&#x60;. | [optional]
**cert_attribute** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertAttributeEnum**](CertAttributeEnum.md) |  |
**user_attribute** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAttributeEnum**](UserAttributeEnum.md) |  |

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
