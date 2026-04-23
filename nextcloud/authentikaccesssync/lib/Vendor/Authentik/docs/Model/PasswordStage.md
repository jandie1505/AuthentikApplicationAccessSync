# PasswordStage

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
**backends** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BackendsEnum[]**](BackendsEnum.md) | Selection of backends to test the password against. |
**configure_flow** | **string** | Flow used by an authenticated user to configure this Stage. If empty, user will not be able to configure this stage. | [optional]
**failed_attempts_before_cancel** | **int** | How many attempts a user has before the flow is canceled. To lock the user out, use a reputation policy and a user_write stage. | [optional]
**allow_show_password** | **bool** | When enabled, provides a &#39;show password&#39; button with the password input field. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
