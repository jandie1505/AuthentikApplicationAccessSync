# KubernetesServiceConnection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pk** | **string** |  | [readonly]
**name** | **string** |  |
**local** | **bool** | If enabled, use the local connection. Required Docker socket/Kubernetes Integration | [optional]
**component** | **string** |  | [readonly]
**verbose_name** | **string** | Return object&#39;s verbose_name | [readonly]
**verbose_name_plural** | **string** | Return object&#39;s plural verbose_name | [readonly]
**meta_model_name** | **string** | Return internal model name | [readonly]
**kubeconfig** | **array<string,mixed>** | Paste your kubeconfig here. authentik will automatically use the currently selected context. | [optional]
**verify_ssl** | **bool** | Verify SSL Certificates of the Kubernetes API endpoint | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
