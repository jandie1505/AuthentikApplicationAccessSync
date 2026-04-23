# PatchedPasswordStageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**backends** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BackendsEnum[]**](BackendsEnum.md) | Selection of backends to test the password against. | [optional]
**configure_flow** | **string** | Flow used by an authenticated user to configure this Stage. If empty, user will not be able to configure this stage. | [optional]
**failed_attempts_before_cancel** | **int** | How many attempts a user has before the flow is canceled. To lock the user out, use a reputation policy and a user_write stage. | [optional]
**allow_show_password** | **bool** | When enabled, provides a &#39;show password&#39; button with the password input field. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
