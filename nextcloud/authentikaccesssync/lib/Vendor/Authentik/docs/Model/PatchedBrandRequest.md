# PatchedBrandRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**domain** | **string** | Domain that activates this brand. Can be a superset, i.e. &#x60;a.b&#x60; for &#x60;aa.b&#x60; and &#x60;ba.b&#x60; | [optional]
**default** | **bool** |  | [optional]
**branding_title** | **string** |  | [optional]
**branding_logo** | **string** |  | [optional]
**branding_favicon** | **string** |  | [optional]
**branding_custom_css** | **string** |  | [optional]
**branding_default_flow_background** | **string** |  | [optional]
**flow_authentication** | **string** |  | [optional]
**flow_invalidation** | **string** |  | [optional]
**flow_recovery** | **string** |  | [optional]
**flow_unenrollment** | **string** |  | [optional]
**flow_user_settings** | **string** |  | [optional]
**flow_device_code** | **string** |  | [optional]
**default_application** | **string** | When set, external users will be redirected to this application after authenticating. | [optional]
**web_certificate** | **string** | Web Certificate used by the authentik Core webserver. | [optional]
**client_certificates** | **string[]** | Certificates used for client authentication. | [optional]
**attributes** | **array<string,mixed>** |  | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
