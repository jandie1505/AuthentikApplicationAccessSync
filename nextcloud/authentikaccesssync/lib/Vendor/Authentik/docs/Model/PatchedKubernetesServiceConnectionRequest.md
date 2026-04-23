# PatchedKubernetesServiceConnectionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**local** | **bool** | If enabled, use the local connection. Required Docker socket/Kubernetes Integration | [optional]
**kubeconfig** | **array<string,mixed>** | Paste your kubeconfig here. authentik will automatically use the currently selected context. | [optional]
**verify_ssl** | **bool** | Verify SSL Certificates of the Kubernetes API endpoint | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
