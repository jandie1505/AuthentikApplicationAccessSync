# PatchedSAMLSourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** | Source&#39;s display Name. | [optional]
**slug** | **string** | Internal source name, used in URLs. | [optional]
**enabled** | **bool** |  | [optional]
**promoted** | **bool** | When enabled, this source will be displayed as a prominent button on the login page, instead of a small icon. | [optional]
**authentication_flow** | **string** | Flow to use when authenticating existing users. | [optional]
**enrollment_flow** | **string** | Flow to use when enrolling new users. | [optional]
**user_property_mappings** | **string[]** |  | [optional]
**group_property_mappings** | **string[]** |  | [optional]
**policy_engine_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyEngineMode**](PolicyEngineMode.md) |  | [optional]
**user_matching_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserMatchingModeEnum**](UserMatchingModeEnum.md) | How the source determines if an existing user should be authenticated or a new user enrolled. | [optional]
**user_path_template** | **string** |  | [optional]
**icon** | **string** |  | [optional]
**group_matching_mode** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupMatchingModeEnum**](GroupMatchingModeEnum.md) | How the source determines if an existing group should be used or a new group created. | [optional]
**pre_authentication_flow** | **string** | Flow used before authentication. | [optional]
**issuer** | **string** | Also known as Entity ID. Defaults the Metadata URL. | [optional]
**sso_url** | **string** | URL that the initial Login request is sent to. | [optional]
**slo_url** | **string** | Optional URL if your IDP supports Single-Logout. | [optional]
**allow_idp_initiated** | **bool** | Allows authentication flows initiated by the IdP. This can be a security risk, as no validation of the request ID is done. | [optional]
**name_id_policy** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLNameIDPolicyEnum**](SAMLNameIDPolicyEnum.md) | NameID Policy sent to the IdP. Can be unset, in which case no Policy is sent. | [optional]
**binding_type** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BindingTypeEnum**](BindingTypeEnum.md) |  | [optional]
**verification_kp** | **string** | When selected, incoming assertion&#39;s Signatures will be validated against this certificate. To allow unsigned Requests, leave on default. | [optional]
**signing_kp** | **string** | Keypair used to sign outgoing Responses going to the Identity Provider. | [optional]
**digest_algorithm** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DigestAlgorithmEnum**](DigestAlgorithmEnum.md) |  | [optional]
**signature_algorithm** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SignatureAlgorithmEnum**](SignatureAlgorithmEnum.md) |  | [optional]
**temporary_user_delete_after** | **string** | Time offset when temporary users should be deleted. This only applies if your IDP uses the NameID Format &#39;transient&#39;, and the user doesn&#39;t log out manually. (Format: hours&#x3D;1;minutes&#x3D;2;seconds&#x3D;3). | [optional]
**encryption_kp** | **string** | When selected, incoming assertions are encrypted by the IdP using the public key of the encryption keypair. The assertion is decrypted by the SP using the the private key. | [optional]
**signed_assertion** | **bool** |  | [optional]
**signed_response** | **bool** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
