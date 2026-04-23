# DeviceUserBinding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**policy** | **string** |  | [optional]
**group** | **string** |  | [optional]
**user** | **int** |  | [optional]
**policy_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Policy**](Policy.md) |  | [readonly]
**group_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PartialGroup**](PartialGroup.md) |  | [readonly]
**user_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PartialUser**](PartialUser.md) |  | [readonly]
**target** | **string** |  |
**negate** | **bool** | Negates the outcome of the policy. Messages are unaffected. | [optional]
**enabled** | **bool** |  | [optional]
**order** | **int** |  |
**timeout** | **int** | Timeout after which Policy execution is terminated. | [optional]
**failure_result** | **bool** | Result if the Policy execution fails. | [optional]
**is_primary** | **bool** |  | [optional]
**connector** | **string** |  | [readonly]
**connector_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Connector**](Connector.md) |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
