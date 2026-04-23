# Invitation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**expires** | **\DateTime** |  | [optional]
**fixed_data** | **array<string,mixed>** |  | [optional]
**created_by** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PartialUser**](PartialUser.md) |  | [readonly]
**single_use** | **bool** | When enabled, the invitation will be deleted after usage. | [optional]
**flow** | **string** | When set, only the configured flow can use this invitation. | [optional]
**flow_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow**](Flow.md) |  | [readonly]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
