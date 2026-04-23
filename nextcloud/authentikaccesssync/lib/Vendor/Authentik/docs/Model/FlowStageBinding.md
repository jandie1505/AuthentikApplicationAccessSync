# FlowStageBinding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**policybindingmodel_ptr_id** | **string** |  | [readonly]
**target** | **string** |  |
**stage** | **string** |  |
**stage_obj** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Stage**](Stage.md) |  | [readonly]
**evaluate_on_plan** | **bool** | Evaluate policies during the Flow planning process. | [optional]
**re_evaluate_policies** | **bool** | Evaluate policies when the Stage is presented to the user. | [optional]
**order** | **int** |  |
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**invalid_response_action** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InvalidResponseActionEnum**](InvalidResponseActionEnum.md) | Configure how the flow executor should handle an invalid response to a challenge. RETRY returns the error message and a similar challenge to the executor. RESTART restarts the flow from the beginning, and RESTART_WITH_CONTEXT restarts the flow while keeping the current context. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
