# PatchedDockerServiceConnectionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** |  | [optional]
**local** | **bool** | If enabled, use the local connection. Required Docker socket/Kubernetes Integration | [optional]
**url** | **string** | Can be in the format of &#39;unix://&lt;path&gt;&#39; when connecting to a local docker daemon, or &#39;https://&lt;hostname&gt;:2376&#39; when connecting to a remote system. | [optional]
**tls_verification** | **string** | CA which the endpoint&#39;s Certificate is verified against. Can be left empty for no validation. | [optional]
**tls_authentication** | **string** | Certificate/Key used for authentication. Can be left empty for no authentication. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
