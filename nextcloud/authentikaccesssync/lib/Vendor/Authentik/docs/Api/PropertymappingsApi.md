# OCA\AuthentikAccessSync\Vendor\Authentik\PropertymappingsApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**propertymappingsAllDestroy()**](PropertymappingsApi.md#propertymappingsAllDestroy) | **DELETE** /propertymappings/all/{pm_uuid}/ |  |
| [**propertymappingsAllList()**](PropertymappingsApi.md#propertymappingsAllList) | **GET** /propertymappings/all/ |  |
| [**propertymappingsAllRetrieve()**](PropertymappingsApi.md#propertymappingsAllRetrieve) | **GET** /propertymappings/all/{pm_uuid}/ |  |
| [**propertymappingsAllTestCreate()**](PropertymappingsApi.md#propertymappingsAllTestCreate) | **POST** /propertymappings/all/{pm_uuid}/test/ |  |
| [**propertymappingsAllTypesList()**](PropertymappingsApi.md#propertymappingsAllTypesList) | **GET** /propertymappings/all/types/ |  |
| [**propertymappingsAllUsedByList()**](PropertymappingsApi.md#propertymappingsAllUsedByList) | **GET** /propertymappings/all/{pm_uuid}/used_by/ |  |
| [**propertymappingsNotificationCreate()**](PropertymappingsApi.md#propertymappingsNotificationCreate) | **POST** /propertymappings/notification/ |  |
| [**propertymappingsNotificationDestroy()**](PropertymappingsApi.md#propertymappingsNotificationDestroy) | **DELETE** /propertymappings/notification/{pm_uuid}/ |  |
| [**propertymappingsNotificationList()**](PropertymappingsApi.md#propertymappingsNotificationList) | **GET** /propertymappings/notification/ |  |
| [**propertymappingsNotificationPartialUpdate()**](PropertymappingsApi.md#propertymappingsNotificationPartialUpdate) | **PATCH** /propertymappings/notification/{pm_uuid}/ |  |
| [**propertymappingsNotificationRetrieve()**](PropertymappingsApi.md#propertymappingsNotificationRetrieve) | **GET** /propertymappings/notification/{pm_uuid}/ |  |
| [**propertymappingsNotificationUpdate()**](PropertymappingsApi.md#propertymappingsNotificationUpdate) | **PUT** /propertymappings/notification/{pm_uuid}/ |  |
| [**propertymappingsNotificationUsedByList()**](PropertymappingsApi.md#propertymappingsNotificationUsedByList) | **GET** /propertymappings/notification/{pm_uuid}/used_by/ |  |
| [**propertymappingsProviderGoogleWorkspaceCreate()**](PropertymappingsApi.md#propertymappingsProviderGoogleWorkspaceCreate) | **POST** /propertymappings/provider/google_workspace/ |  |
| [**propertymappingsProviderGoogleWorkspaceDestroy()**](PropertymappingsApi.md#propertymappingsProviderGoogleWorkspaceDestroy) | **DELETE** /propertymappings/provider/google_workspace/{pm_uuid}/ |  |
| [**propertymappingsProviderGoogleWorkspaceList()**](PropertymappingsApi.md#propertymappingsProviderGoogleWorkspaceList) | **GET** /propertymappings/provider/google_workspace/ |  |
| [**propertymappingsProviderGoogleWorkspacePartialUpdate()**](PropertymappingsApi.md#propertymappingsProviderGoogleWorkspacePartialUpdate) | **PATCH** /propertymappings/provider/google_workspace/{pm_uuid}/ |  |
| [**propertymappingsProviderGoogleWorkspaceRetrieve()**](PropertymappingsApi.md#propertymappingsProviderGoogleWorkspaceRetrieve) | **GET** /propertymappings/provider/google_workspace/{pm_uuid}/ |  |
| [**propertymappingsProviderGoogleWorkspaceUpdate()**](PropertymappingsApi.md#propertymappingsProviderGoogleWorkspaceUpdate) | **PUT** /propertymappings/provider/google_workspace/{pm_uuid}/ |  |
| [**propertymappingsProviderGoogleWorkspaceUsedByList()**](PropertymappingsApi.md#propertymappingsProviderGoogleWorkspaceUsedByList) | **GET** /propertymappings/provider/google_workspace/{pm_uuid}/used_by/ |  |
| [**propertymappingsProviderMicrosoftEntraCreate()**](PropertymappingsApi.md#propertymappingsProviderMicrosoftEntraCreate) | **POST** /propertymappings/provider/microsoft_entra/ |  |
| [**propertymappingsProviderMicrosoftEntraDestroy()**](PropertymappingsApi.md#propertymappingsProviderMicrosoftEntraDestroy) | **DELETE** /propertymappings/provider/microsoft_entra/{pm_uuid}/ |  |
| [**propertymappingsProviderMicrosoftEntraList()**](PropertymappingsApi.md#propertymappingsProviderMicrosoftEntraList) | **GET** /propertymappings/provider/microsoft_entra/ |  |
| [**propertymappingsProviderMicrosoftEntraPartialUpdate()**](PropertymappingsApi.md#propertymappingsProviderMicrosoftEntraPartialUpdate) | **PATCH** /propertymappings/provider/microsoft_entra/{pm_uuid}/ |  |
| [**propertymappingsProviderMicrosoftEntraRetrieve()**](PropertymappingsApi.md#propertymappingsProviderMicrosoftEntraRetrieve) | **GET** /propertymappings/provider/microsoft_entra/{pm_uuid}/ |  |
| [**propertymappingsProviderMicrosoftEntraUpdate()**](PropertymappingsApi.md#propertymappingsProviderMicrosoftEntraUpdate) | **PUT** /propertymappings/provider/microsoft_entra/{pm_uuid}/ |  |
| [**propertymappingsProviderMicrosoftEntraUsedByList()**](PropertymappingsApi.md#propertymappingsProviderMicrosoftEntraUsedByList) | **GET** /propertymappings/provider/microsoft_entra/{pm_uuid}/used_by/ |  |
| [**propertymappingsProviderRacCreate()**](PropertymappingsApi.md#propertymappingsProviderRacCreate) | **POST** /propertymappings/provider/rac/ |  |
| [**propertymappingsProviderRacDestroy()**](PropertymappingsApi.md#propertymappingsProviderRacDestroy) | **DELETE** /propertymappings/provider/rac/{pm_uuid}/ |  |
| [**propertymappingsProviderRacList()**](PropertymappingsApi.md#propertymappingsProviderRacList) | **GET** /propertymappings/provider/rac/ |  |
| [**propertymappingsProviderRacPartialUpdate()**](PropertymappingsApi.md#propertymappingsProviderRacPartialUpdate) | **PATCH** /propertymappings/provider/rac/{pm_uuid}/ |  |
| [**propertymappingsProviderRacRetrieve()**](PropertymappingsApi.md#propertymappingsProviderRacRetrieve) | **GET** /propertymappings/provider/rac/{pm_uuid}/ |  |
| [**propertymappingsProviderRacUpdate()**](PropertymappingsApi.md#propertymappingsProviderRacUpdate) | **PUT** /propertymappings/provider/rac/{pm_uuid}/ |  |
| [**propertymappingsProviderRacUsedByList()**](PropertymappingsApi.md#propertymappingsProviderRacUsedByList) | **GET** /propertymappings/provider/rac/{pm_uuid}/used_by/ |  |
| [**propertymappingsProviderRadiusCreate()**](PropertymappingsApi.md#propertymappingsProviderRadiusCreate) | **POST** /propertymappings/provider/radius/ |  |
| [**propertymappingsProviderRadiusDestroy()**](PropertymappingsApi.md#propertymappingsProviderRadiusDestroy) | **DELETE** /propertymappings/provider/radius/{pm_uuid}/ |  |
| [**propertymappingsProviderRadiusList()**](PropertymappingsApi.md#propertymappingsProviderRadiusList) | **GET** /propertymappings/provider/radius/ |  |
| [**propertymappingsProviderRadiusPartialUpdate()**](PropertymappingsApi.md#propertymappingsProviderRadiusPartialUpdate) | **PATCH** /propertymappings/provider/radius/{pm_uuid}/ |  |
| [**propertymappingsProviderRadiusRetrieve()**](PropertymappingsApi.md#propertymappingsProviderRadiusRetrieve) | **GET** /propertymappings/provider/radius/{pm_uuid}/ |  |
| [**propertymappingsProviderRadiusUpdate()**](PropertymappingsApi.md#propertymappingsProviderRadiusUpdate) | **PUT** /propertymappings/provider/radius/{pm_uuid}/ |  |
| [**propertymappingsProviderRadiusUsedByList()**](PropertymappingsApi.md#propertymappingsProviderRadiusUsedByList) | **GET** /propertymappings/provider/radius/{pm_uuid}/used_by/ |  |
| [**propertymappingsProviderSamlCreate()**](PropertymappingsApi.md#propertymappingsProviderSamlCreate) | **POST** /propertymappings/provider/saml/ |  |
| [**propertymappingsProviderSamlDestroy()**](PropertymappingsApi.md#propertymappingsProviderSamlDestroy) | **DELETE** /propertymappings/provider/saml/{pm_uuid}/ |  |
| [**propertymappingsProviderSamlList()**](PropertymappingsApi.md#propertymappingsProviderSamlList) | **GET** /propertymappings/provider/saml/ |  |
| [**propertymappingsProviderSamlPartialUpdate()**](PropertymappingsApi.md#propertymappingsProviderSamlPartialUpdate) | **PATCH** /propertymappings/provider/saml/{pm_uuid}/ |  |
| [**propertymappingsProviderSamlRetrieve()**](PropertymappingsApi.md#propertymappingsProviderSamlRetrieve) | **GET** /propertymappings/provider/saml/{pm_uuid}/ |  |
| [**propertymappingsProviderSamlUpdate()**](PropertymappingsApi.md#propertymappingsProviderSamlUpdate) | **PUT** /propertymappings/provider/saml/{pm_uuid}/ |  |
| [**propertymappingsProviderSamlUsedByList()**](PropertymappingsApi.md#propertymappingsProviderSamlUsedByList) | **GET** /propertymappings/provider/saml/{pm_uuid}/used_by/ |  |
| [**propertymappingsProviderScimCreate()**](PropertymappingsApi.md#propertymappingsProviderScimCreate) | **POST** /propertymappings/provider/scim/ |  |
| [**propertymappingsProviderScimDestroy()**](PropertymappingsApi.md#propertymappingsProviderScimDestroy) | **DELETE** /propertymappings/provider/scim/{pm_uuid}/ |  |
| [**propertymappingsProviderScimList()**](PropertymappingsApi.md#propertymappingsProviderScimList) | **GET** /propertymappings/provider/scim/ |  |
| [**propertymappingsProviderScimPartialUpdate()**](PropertymappingsApi.md#propertymappingsProviderScimPartialUpdate) | **PATCH** /propertymappings/provider/scim/{pm_uuid}/ |  |
| [**propertymappingsProviderScimRetrieve()**](PropertymappingsApi.md#propertymappingsProviderScimRetrieve) | **GET** /propertymappings/provider/scim/{pm_uuid}/ |  |
| [**propertymappingsProviderScimUpdate()**](PropertymappingsApi.md#propertymappingsProviderScimUpdate) | **PUT** /propertymappings/provider/scim/{pm_uuid}/ |  |
| [**propertymappingsProviderScimUsedByList()**](PropertymappingsApi.md#propertymappingsProviderScimUsedByList) | **GET** /propertymappings/provider/scim/{pm_uuid}/used_by/ |  |
| [**propertymappingsProviderScopeCreate()**](PropertymappingsApi.md#propertymappingsProviderScopeCreate) | **POST** /propertymappings/provider/scope/ |  |
| [**propertymappingsProviderScopeDestroy()**](PropertymappingsApi.md#propertymappingsProviderScopeDestroy) | **DELETE** /propertymappings/provider/scope/{pm_uuid}/ |  |
| [**propertymappingsProviderScopeList()**](PropertymappingsApi.md#propertymappingsProviderScopeList) | **GET** /propertymappings/provider/scope/ |  |
| [**propertymappingsProviderScopePartialUpdate()**](PropertymappingsApi.md#propertymappingsProviderScopePartialUpdate) | **PATCH** /propertymappings/provider/scope/{pm_uuid}/ |  |
| [**propertymappingsProviderScopeRetrieve()**](PropertymappingsApi.md#propertymappingsProviderScopeRetrieve) | **GET** /propertymappings/provider/scope/{pm_uuid}/ |  |
| [**propertymappingsProviderScopeUpdate()**](PropertymappingsApi.md#propertymappingsProviderScopeUpdate) | **PUT** /propertymappings/provider/scope/{pm_uuid}/ |  |
| [**propertymappingsProviderScopeUsedByList()**](PropertymappingsApi.md#propertymappingsProviderScopeUsedByList) | **GET** /propertymappings/provider/scope/{pm_uuid}/used_by/ |  |
| [**propertymappingsSourceKerberosCreate()**](PropertymappingsApi.md#propertymappingsSourceKerberosCreate) | **POST** /propertymappings/source/kerberos/ |  |
| [**propertymappingsSourceKerberosDestroy()**](PropertymappingsApi.md#propertymappingsSourceKerberosDestroy) | **DELETE** /propertymappings/source/kerberos/{pm_uuid}/ |  |
| [**propertymappingsSourceKerberosList()**](PropertymappingsApi.md#propertymappingsSourceKerberosList) | **GET** /propertymappings/source/kerberos/ |  |
| [**propertymappingsSourceKerberosPartialUpdate()**](PropertymappingsApi.md#propertymappingsSourceKerberosPartialUpdate) | **PATCH** /propertymappings/source/kerberos/{pm_uuid}/ |  |
| [**propertymappingsSourceKerberosRetrieve()**](PropertymappingsApi.md#propertymappingsSourceKerberosRetrieve) | **GET** /propertymappings/source/kerberos/{pm_uuid}/ |  |
| [**propertymappingsSourceKerberosUpdate()**](PropertymappingsApi.md#propertymappingsSourceKerberosUpdate) | **PUT** /propertymappings/source/kerberos/{pm_uuid}/ |  |
| [**propertymappingsSourceKerberosUsedByList()**](PropertymappingsApi.md#propertymappingsSourceKerberosUsedByList) | **GET** /propertymappings/source/kerberos/{pm_uuid}/used_by/ |  |
| [**propertymappingsSourceLdapCreate()**](PropertymappingsApi.md#propertymappingsSourceLdapCreate) | **POST** /propertymappings/source/ldap/ |  |
| [**propertymappingsSourceLdapDestroy()**](PropertymappingsApi.md#propertymappingsSourceLdapDestroy) | **DELETE** /propertymappings/source/ldap/{pm_uuid}/ |  |
| [**propertymappingsSourceLdapList()**](PropertymappingsApi.md#propertymappingsSourceLdapList) | **GET** /propertymappings/source/ldap/ |  |
| [**propertymappingsSourceLdapPartialUpdate()**](PropertymappingsApi.md#propertymappingsSourceLdapPartialUpdate) | **PATCH** /propertymappings/source/ldap/{pm_uuid}/ |  |
| [**propertymappingsSourceLdapRetrieve()**](PropertymappingsApi.md#propertymappingsSourceLdapRetrieve) | **GET** /propertymappings/source/ldap/{pm_uuid}/ |  |
| [**propertymappingsSourceLdapUpdate()**](PropertymappingsApi.md#propertymappingsSourceLdapUpdate) | **PUT** /propertymappings/source/ldap/{pm_uuid}/ |  |
| [**propertymappingsSourceLdapUsedByList()**](PropertymappingsApi.md#propertymappingsSourceLdapUsedByList) | **GET** /propertymappings/source/ldap/{pm_uuid}/used_by/ |  |
| [**propertymappingsSourceOauthCreate()**](PropertymappingsApi.md#propertymappingsSourceOauthCreate) | **POST** /propertymappings/source/oauth/ |  |
| [**propertymappingsSourceOauthDestroy()**](PropertymappingsApi.md#propertymappingsSourceOauthDestroy) | **DELETE** /propertymappings/source/oauth/{pm_uuid}/ |  |
| [**propertymappingsSourceOauthList()**](PropertymappingsApi.md#propertymappingsSourceOauthList) | **GET** /propertymappings/source/oauth/ |  |
| [**propertymappingsSourceOauthPartialUpdate()**](PropertymappingsApi.md#propertymappingsSourceOauthPartialUpdate) | **PATCH** /propertymappings/source/oauth/{pm_uuid}/ |  |
| [**propertymappingsSourceOauthRetrieve()**](PropertymappingsApi.md#propertymappingsSourceOauthRetrieve) | **GET** /propertymappings/source/oauth/{pm_uuid}/ |  |
| [**propertymappingsSourceOauthUpdate()**](PropertymappingsApi.md#propertymappingsSourceOauthUpdate) | **PUT** /propertymappings/source/oauth/{pm_uuid}/ |  |
| [**propertymappingsSourceOauthUsedByList()**](PropertymappingsApi.md#propertymappingsSourceOauthUsedByList) | **GET** /propertymappings/source/oauth/{pm_uuid}/used_by/ |  |
| [**propertymappingsSourcePlexCreate()**](PropertymappingsApi.md#propertymappingsSourcePlexCreate) | **POST** /propertymappings/source/plex/ |  |
| [**propertymappingsSourcePlexDestroy()**](PropertymappingsApi.md#propertymappingsSourcePlexDestroy) | **DELETE** /propertymappings/source/plex/{pm_uuid}/ |  |
| [**propertymappingsSourcePlexList()**](PropertymappingsApi.md#propertymappingsSourcePlexList) | **GET** /propertymappings/source/plex/ |  |
| [**propertymappingsSourcePlexPartialUpdate()**](PropertymappingsApi.md#propertymappingsSourcePlexPartialUpdate) | **PATCH** /propertymappings/source/plex/{pm_uuid}/ |  |
| [**propertymappingsSourcePlexRetrieve()**](PropertymappingsApi.md#propertymappingsSourcePlexRetrieve) | **GET** /propertymappings/source/plex/{pm_uuid}/ |  |
| [**propertymappingsSourcePlexUpdate()**](PropertymappingsApi.md#propertymappingsSourcePlexUpdate) | **PUT** /propertymappings/source/plex/{pm_uuid}/ |  |
| [**propertymappingsSourcePlexUsedByList()**](PropertymappingsApi.md#propertymappingsSourcePlexUsedByList) | **GET** /propertymappings/source/plex/{pm_uuid}/used_by/ |  |
| [**propertymappingsSourceSamlCreate()**](PropertymappingsApi.md#propertymappingsSourceSamlCreate) | **POST** /propertymappings/source/saml/ |  |
| [**propertymappingsSourceSamlDestroy()**](PropertymappingsApi.md#propertymappingsSourceSamlDestroy) | **DELETE** /propertymappings/source/saml/{pm_uuid}/ |  |
| [**propertymappingsSourceSamlList()**](PropertymappingsApi.md#propertymappingsSourceSamlList) | **GET** /propertymappings/source/saml/ |  |
| [**propertymappingsSourceSamlPartialUpdate()**](PropertymappingsApi.md#propertymappingsSourceSamlPartialUpdate) | **PATCH** /propertymappings/source/saml/{pm_uuid}/ |  |
| [**propertymappingsSourceSamlRetrieve()**](PropertymappingsApi.md#propertymappingsSourceSamlRetrieve) | **GET** /propertymappings/source/saml/{pm_uuid}/ |  |
| [**propertymappingsSourceSamlUpdate()**](PropertymappingsApi.md#propertymappingsSourceSamlUpdate) | **PUT** /propertymappings/source/saml/{pm_uuid}/ |  |
| [**propertymappingsSourceSamlUsedByList()**](PropertymappingsApi.md#propertymappingsSourceSamlUsedByList) | **GET** /propertymappings/source/saml/{pm_uuid}/used_by/ |  |
| [**propertymappingsSourceScimCreate()**](PropertymappingsApi.md#propertymappingsSourceScimCreate) | **POST** /propertymappings/source/scim/ |  |
| [**propertymappingsSourceScimDestroy()**](PropertymappingsApi.md#propertymappingsSourceScimDestroy) | **DELETE** /propertymappings/source/scim/{pm_uuid}/ |  |
| [**propertymappingsSourceScimList()**](PropertymappingsApi.md#propertymappingsSourceScimList) | **GET** /propertymappings/source/scim/ |  |
| [**propertymappingsSourceScimPartialUpdate()**](PropertymappingsApi.md#propertymappingsSourceScimPartialUpdate) | **PATCH** /propertymappings/source/scim/{pm_uuid}/ |  |
| [**propertymappingsSourceScimRetrieve()**](PropertymappingsApi.md#propertymappingsSourceScimRetrieve) | **GET** /propertymappings/source/scim/{pm_uuid}/ |  |
| [**propertymappingsSourceScimUpdate()**](PropertymappingsApi.md#propertymappingsSourceScimUpdate) | **PUT** /propertymappings/source/scim/{pm_uuid}/ |  |
| [**propertymappingsSourceScimUsedByList()**](PropertymappingsApi.md#propertymappingsSourceScimUsedByList) | **GET** /propertymappings/source/scim/{pm_uuid}/used_by/ |  |
| [**propertymappingsSourceTelegramCreate()**](PropertymappingsApi.md#propertymappingsSourceTelegramCreate) | **POST** /propertymappings/source/telegram/ |  |
| [**propertymappingsSourceTelegramDestroy()**](PropertymappingsApi.md#propertymappingsSourceTelegramDestroy) | **DELETE** /propertymappings/source/telegram/{pm_uuid}/ |  |
| [**propertymappingsSourceTelegramList()**](PropertymappingsApi.md#propertymappingsSourceTelegramList) | **GET** /propertymappings/source/telegram/ |  |
| [**propertymappingsSourceTelegramPartialUpdate()**](PropertymappingsApi.md#propertymappingsSourceTelegramPartialUpdate) | **PATCH** /propertymappings/source/telegram/{pm_uuid}/ |  |
| [**propertymappingsSourceTelegramRetrieve()**](PropertymappingsApi.md#propertymappingsSourceTelegramRetrieve) | **GET** /propertymappings/source/telegram/{pm_uuid}/ |  |
| [**propertymappingsSourceTelegramUpdate()**](PropertymappingsApi.md#propertymappingsSourceTelegramUpdate) | **PUT** /propertymappings/source/telegram/{pm_uuid}/ |  |
| [**propertymappingsSourceTelegramUsedByList()**](PropertymappingsApi.md#propertymappingsSourceTelegramUsedByList) | **GET** /propertymappings/source/telegram/{pm_uuid}/used_by/ |  |


## `propertymappingsAllDestroy()`

```php
propertymappingsAllDestroy($pm_uuid)
```



PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Property Mapping.

try {
    $apiInstance->propertymappingsAllDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsAllDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsAllList()`

```php
propertymappingsAllList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPropertyMappingList
```



PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsAllList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsAllList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPropertyMappingList**](../Model/PaginatedPropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsAllRetrieve()`

```php
propertymappingsAllRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMapping
```



PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Property Mapping.

try {
    $result = $apiInstance->propertymappingsAllRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsAllRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMapping**](../Model/PropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsAllTestCreate()`

```php
propertymappingsAllTestCreate($pm_uuid, $format_result, $property_mapping_test_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingTestResult
```



Test Property Mapping

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Property Mapping.
$format_result = True; // bool
$property_mapping_test_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingTestRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingTestRequest

try {
    $result = $apiInstance->propertymappingsAllTestCreate($pm_uuid, $format_result, $property_mapping_test_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsAllTestCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Property Mapping. | |
| **format_result** | **bool**|  | [optional] |
| **property_mapping_test_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingTestRequest**](../Model/PropertyMappingTestRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingTestResult**](../Model/PropertyMappingTestResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsAllTypesList()`

```php
propertymappingsAllTypesList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all creatable types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->propertymappingsAllTypesList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsAllTypesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]**](../Model/TypeCreate.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsAllUsedByList()`

```php
propertymappingsAllUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Property Mapping.

try {
    $result = $apiInstance->propertymappingsAllUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsAllUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsNotificationCreate()`

```php
propertymappingsNotificationCreate($notification_webhook_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping
```



NotificationWebhookMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$notification_webhook_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMappingRequest

try {
    $result = $apiInstance->propertymappingsNotificationCreate($notification_webhook_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsNotificationCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **notification_webhook_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMappingRequest**](../Model/NotificationWebhookMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping**](../Model/NotificationWebhookMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsNotificationDestroy()`

```php
propertymappingsNotificationDestroy($pm_uuid)
```



NotificationWebhookMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Webhook Mapping.

try {
    $apiInstance->propertymappingsNotificationDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsNotificationDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Webhook Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsNotificationList()`

```php
propertymappingsNotificationList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationWebhookMappingList
```



NotificationWebhookMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsNotificationList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsNotificationList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationWebhookMappingList**](../Model/PaginatedNotificationWebhookMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsNotificationPartialUpdate()`

```php
propertymappingsNotificationPartialUpdate($pm_uuid, $patched_notification_webhook_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping
```



NotificationWebhookMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Webhook Mapping.
$patched_notification_webhook_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationWebhookMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationWebhookMappingRequest

try {
    $result = $apiInstance->propertymappingsNotificationPartialUpdate($pm_uuid, $patched_notification_webhook_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsNotificationPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Webhook Mapping. | |
| **patched_notification_webhook_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationWebhookMappingRequest**](../Model/PatchedNotificationWebhookMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping**](../Model/NotificationWebhookMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsNotificationRetrieve()`

```php
propertymappingsNotificationRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping
```



NotificationWebhookMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Webhook Mapping.

try {
    $result = $apiInstance->propertymappingsNotificationRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsNotificationRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Webhook Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping**](../Model/NotificationWebhookMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsNotificationUpdate()`

```php
propertymappingsNotificationUpdate($pm_uuid, $notification_webhook_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping
```



NotificationWebhookMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Webhook Mapping.
$notification_webhook_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMappingRequest

try {
    $result = $apiInstance->propertymappingsNotificationUpdate($pm_uuid, $notification_webhook_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsNotificationUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Webhook Mapping. | |
| **notification_webhook_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMappingRequest**](../Model/NotificationWebhookMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationWebhookMapping**](../Model/NotificationWebhookMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsNotificationUsedByList()`

```php
propertymappingsNotificationUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Webhook Mapping.

try {
    $result = $apiInstance->propertymappingsNotificationUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsNotificationUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Webhook Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderGoogleWorkspaceCreate()`

```php
propertymappingsProviderGoogleWorkspaceCreate($google_workspace_provider_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping
```



GoogleWorkspaceProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$google_workspace_provider_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderGoogleWorkspaceCreate($google_workspace_provider_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderGoogleWorkspaceCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **google_workspace_provider_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMappingRequest**](../Model/GoogleWorkspaceProviderMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping**](../Model/GoogleWorkspaceProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderGoogleWorkspaceDestroy()`

```php
propertymappingsProviderGoogleWorkspaceDestroy($pm_uuid)
```



GoogleWorkspaceProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Google Workspace Provider Mapping.

try {
    $apiInstance->propertymappingsProviderGoogleWorkspaceDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderGoogleWorkspaceDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Google Workspace Provider Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderGoogleWorkspaceList()`

```php
propertymappingsProviderGoogleWorkspaceList($expression, $managed, $name, $ordering, $page, $page_size, $pm_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderMappingList
```



GoogleWorkspaceProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$expression = 'expression_example'; // string
$managed = array('managed_example'); // string[]
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$pm_uuid = 'pm_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsProviderGoogleWorkspaceList($expression, $managed, $name, $ordering, $page, $page_size, $pm_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderGoogleWorkspaceList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **expression** | **string**|  | [optional] |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **pm_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderMappingList**](../Model/PaginatedGoogleWorkspaceProviderMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderGoogleWorkspacePartialUpdate()`

```php
propertymappingsProviderGoogleWorkspacePartialUpdate($pm_uuid, $patched_google_workspace_provider_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping
```



GoogleWorkspaceProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Google Workspace Provider Mapping.
$patched_google_workspace_provider_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleWorkspaceProviderMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleWorkspaceProviderMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderGoogleWorkspacePartialUpdate($pm_uuid, $patched_google_workspace_provider_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderGoogleWorkspacePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Google Workspace Provider Mapping. | |
| **patched_google_workspace_provider_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleWorkspaceProviderMappingRequest**](../Model/PatchedGoogleWorkspaceProviderMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping**](../Model/GoogleWorkspaceProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderGoogleWorkspaceRetrieve()`

```php
propertymappingsProviderGoogleWorkspaceRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping
```



GoogleWorkspaceProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Google Workspace Provider Mapping.

try {
    $result = $apiInstance->propertymappingsProviderGoogleWorkspaceRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderGoogleWorkspaceRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Google Workspace Provider Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping**](../Model/GoogleWorkspaceProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderGoogleWorkspaceUpdate()`

```php
propertymappingsProviderGoogleWorkspaceUpdate($pm_uuid, $google_workspace_provider_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping
```



GoogleWorkspaceProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Google Workspace Provider Mapping.
$google_workspace_provider_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderGoogleWorkspaceUpdate($pm_uuid, $google_workspace_provider_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderGoogleWorkspaceUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Google Workspace Provider Mapping. | |
| **google_workspace_provider_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMappingRequest**](../Model/GoogleWorkspaceProviderMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderMapping**](../Model/GoogleWorkspaceProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderGoogleWorkspaceUsedByList()`

```php
propertymappingsProviderGoogleWorkspaceUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Google Workspace Provider Mapping.

try {
    $result = $apiInstance->propertymappingsProviderGoogleWorkspaceUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderGoogleWorkspaceUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Google Workspace Provider Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderMicrosoftEntraCreate()`

```php
propertymappingsProviderMicrosoftEntraCreate($microsoft_entra_provider_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping
```



MicrosoftEntraProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$microsoft_entra_provider_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderMicrosoftEntraCreate($microsoft_entra_provider_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderMicrosoftEntraCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **microsoft_entra_provider_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMappingRequest**](../Model/MicrosoftEntraProviderMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping**](../Model/MicrosoftEntraProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderMicrosoftEntraDestroy()`

```php
propertymappingsProviderMicrosoftEntraDestroy($pm_uuid)
```



MicrosoftEntraProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Microsoft Entra Provider Mapping.

try {
    $apiInstance->propertymappingsProviderMicrosoftEntraDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderMicrosoftEntraDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Microsoft Entra Provider Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderMicrosoftEntraList()`

```php
propertymappingsProviderMicrosoftEntraList($expression, $managed, $name, $ordering, $page, $page_size, $pm_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderMappingList
```



MicrosoftEntraProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$expression = 'expression_example'; // string
$managed = array('managed_example'); // string[]
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$pm_uuid = 'pm_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsProviderMicrosoftEntraList($expression, $managed, $name, $ordering, $page, $page_size, $pm_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderMicrosoftEntraList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **expression** | **string**|  | [optional] |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **pm_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderMappingList**](../Model/PaginatedMicrosoftEntraProviderMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderMicrosoftEntraPartialUpdate()`

```php
propertymappingsProviderMicrosoftEntraPartialUpdate($pm_uuid, $patched_microsoft_entra_provider_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping
```



MicrosoftEntraProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Microsoft Entra Provider Mapping.
$patched_microsoft_entra_provider_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMicrosoftEntraProviderMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMicrosoftEntraProviderMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderMicrosoftEntraPartialUpdate($pm_uuid, $patched_microsoft_entra_provider_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderMicrosoftEntraPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Microsoft Entra Provider Mapping. | |
| **patched_microsoft_entra_provider_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMicrosoftEntraProviderMappingRequest**](../Model/PatchedMicrosoftEntraProviderMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping**](../Model/MicrosoftEntraProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderMicrosoftEntraRetrieve()`

```php
propertymappingsProviderMicrosoftEntraRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping
```



MicrosoftEntraProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Microsoft Entra Provider Mapping.

try {
    $result = $apiInstance->propertymappingsProviderMicrosoftEntraRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderMicrosoftEntraRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Microsoft Entra Provider Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping**](../Model/MicrosoftEntraProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderMicrosoftEntraUpdate()`

```php
propertymappingsProviderMicrosoftEntraUpdate($pm_uuid, $microsoft_entra_provider_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping
```



MicrosoftEntraProviderMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Microsoft Entra Provider Mapping.
$microsoft_entra_provider_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderMicrosoftEntraUpdate($pm_uuid, $microsoft_entra_provider_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderMicrosoftEntraUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Microsoft Entra Provider Mapping. | |
| **microsoft_entra_provider_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMappingRequest**](../Model/MicrosoftEntraProviderMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderMapping**](../Model/MicrosoftEntraProviderMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderMicrosoftEntraUsedByList()`

```php
propertymappingsProviderMicrosoftEntraUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Microsoft Entra Provider Mapping.

try {
    $result = $apiInstance->propertymappingsProviderMicrosoftEntraUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderMicrosoftEntraUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Microsoft Entra Provider Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRacCreate()`

```php
propertymappingsProviderRacCreate($rac_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping
```



RACPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$rac_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderRacCreate($rac_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRacCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **rac_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMappingRequest**](../Model/RACPropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping**](../Model/RACPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRacDestroy()`

```php
propertymappingsProviderRacDestroy($pm_uuid)
```



RACPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this RAC Provider Property Mapping.

try {
    $apiInstance->propertymappingsProviderRacDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRacDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this RAC Provider Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRacList()`

```php
propertymappingsProviderRacList($managed, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRACPropertyMappingList
```



RACPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsProviderRacList($managed, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRacList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRACPropertyMappingList**](../Model/PaginatedRACPropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRacPartialUpdate()`

```php
propertymappingsProviderRacPartialUpdate($pm_uuid, $patched_rac_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping
```



RACPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this RAC Provider Property Mapping.
$patched_rac_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRACPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRACPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderRacPartialUpdate($pm_uuid, $patched_rac_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRacPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this RAC Provider Property Mapping. | |
| **patched_rac_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRACPropertyMappingRequest**](../Model/PatchedRACPropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping**](../Model/RACPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRacRetrieve()`

```php
propertymappingsProviderRacRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping
```



RACPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this RAC Provider Property Mapping.

try {
    $result = $apiInstance->propertymappingsProviderRacRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRacRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this RAC Provider Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping**](../Model/RACPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRacUpdate()`

```php
propertymappingsProviderRacUpdate($pm_uuid, $rac_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping
```



RACPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this RAC Provider Property Mapping.
$rac_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderRacUpdate($pm_uuid, $rac_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRacUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this RAC Provider Property Mapping. | |
| **rac_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMappingRequest**](../Model/RACPropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACPropertyMapping**](../Model/RACPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRacUsedByList()`

```php
propertymappingsProviderRacUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this RAC Provider Property Mapping.

try {
    $result = $apiInstance->propertymappingsProviderRacUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRacUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this RAC Provider Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRadiusCreate()`

```php
propertymappingsProviderRadiusCreate($radius_provider_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping
```



RadiusProviderPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$radius_provider_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderRadiusCreate($radius_provider_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRadiusCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **radius_provider_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMappingRequest**](../Model/RadiusProviderPropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping**](../Model/RadiusProviderPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRadiusDestroy()`

```php
propertymappingsProviderRadiusDestroy($pm_uuid)
```



RadiusProviderPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Radius Provider Property Mapping.

try {
    $apiInstance->propertymappingsProviderRadiusDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRadiusDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Radius Provider Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRadiusList()`

```php
propertymappingsProviderRadiusList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRadiusProviderPropertyMappingList
```



RadiusProviderPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsProviderRadiusList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRadiusList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRadiusProviderPropertyMappingList**](../Model/PaginatedRadiusProviderPropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRadiusPartialUpdate()`

```php
propertymappingsProviderRadiusPartialUpdate($pm_uuid, $patched_radius_provider_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping
```



RadiusProviderPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Radius Provider Property Mapping.
$patched_radius_provider_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRadiusProviderPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRadiusProviderPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderRadiusPartialUpdate($pm_uuid, $patched_radius_provider_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRadiusPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Radius Provider Property Mapping. | |
| **patched_radius_provider_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRadiusProviderPropertyMappingRequest**](../Model/PatchedRadiusProviderPropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping**](../Model/RadiusProviderPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRadiusRetrieve()`

```php
propertymappingsProviderRadiusRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping
```



RadiusProviderPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Radius Provider Property Mapping.

try {
    $result = $apiInstance->propertymappingsProviderRadiusRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRadiusRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Radius Provider Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping**](../Model/RadiusProviderPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRadiusUpdate()`

```php
propertymappingsProviderRadiusUpdate($pm_uuid, $radius_provider_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping
```



RadiusProviderPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Radius Provider Property Mapping.
$radius_provider_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderRadiusUpdate($pm_uuid, $radius_provider_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRadiusUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Radius Provider Property Mapping. | |
| **radius_provider_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMappingRequest**](../Model/RadiusProviderPropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderPropertyMapping**](../Model/RadiusProviderPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderRadiusUsedByList()`

```php
propertymappingsProviderRadiusUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Radius Provider Property Mapping.

try {
    $result = $apiInstance->propertymappingsProviderRadiusUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderRadiusUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Radius Provider Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderSamlCreate()`

```php
propertymappingsProviderSamlCreate($saml_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping
```



SAMLPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$saml_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderSamlCreate($saml_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderSamlCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **saml_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMappingRequest**](../Model/SAMLPropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping**](../Model/SAMLPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderSamlDestroy()`

```php
propertymappingsProviderSamlDestroy($pm_uuid)
```



SAMLPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Provider Property Mapping.

try {
    $apiInstance->propertymappingsProviderSamlDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderSamlDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Provider Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderSamlList()`

```php
propertymappingsProviderSamlList($friendly_name, $managed, $managed__isnull, $name, $ordering, $page, $page_size, $saml_name, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSAMLPropertyMappingList
```



SAMLPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$friendly_name = 'friendly_name_example'; // string
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$saml_name = 'saml_name_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsProviderSamlList($friendly_name, $managed, $managed__isnull, $name, $ordering, $page, $page_size, $saml_name, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderSamlList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **friendly_name** | **string**|  | [optional] |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **saml_name** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSAMLPropertyMappingList**](../Model/PaginatedSAMLPropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderSamlPartialUpdate()`

```php
propertymappingsProviderSamlPartialUpdate($pm_uuid, $patched_saml_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping
```



SAMLPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Provider Property Mapping.
$patched_saml_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderSamlPartialUpdate($pm_uuid, $patched_saml_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderSamlPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Provider Property Mapping. | |
| **patched_saml_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLPropertyMappingRequest**](../Model/PatchedSAMLPropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping**](../Model/SAMLPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderSamlRetrieve()`

```php
propertymappingsProviderSamlRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping
```



SAMLPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Provider Property Mapping.

try {
    $result = $apiInstance->propertymappingsProviderSamlRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderSamlRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Provider Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping**](../Model/SAMLPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderSamlUpdate()`

```php
propertymappingsProviderSamlUpdate($pm_uuid, $saml_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping
```



SAMLPropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Provider Property Mapping.
$saml_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderSamlUpdate($pm_uuid, $saml_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderSamlUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Provider Property Mapping. | |
| **saml_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMappingRequest**](../Model/SAMLPropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLPropertyMapping**](../Model/SAMLPropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderSamlUsedByList()`

```php
propertymappingsProviderSamlUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Provider Property Mapping.

try {
    $result = $apiInstance->propertymappingsProviderSamlUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderSamlUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Provider Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScimCreate()`

```php
propertymappingsProviderScimCreate($scim_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping
```



SCIMMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scim_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderScimCreate($scim_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScimCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **scim_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMappingRequest**](../Model/SCIMMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping**](../Model/SCIMMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScimDestroy()`

```php
propertymappingsProviderScimDestroy($pm_uuid)
```



SCIMMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Provider Mapping.

try {
    $apiInstance->propertymappingsProviderScimDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScimDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Provider Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScimList()`

```php
propertymappingsProviderScimList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMMappingList
```



SCIMMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsProviderScimList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScimList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMMappingList**](../Model/PaginatedSCIMMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScimPartialUpdate()`

```php
propertymappingsProviderScimPartialUpdate($pm_uuid, $patched_scim_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping
```



SCIMMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Provider Mapping.
$patched_scim_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderScimPartialUpdate($pm_uuid, $patched_scim_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScimPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Provider Mapping. | |
| **patched_scim_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMMappingRequest**](../Model/PatchedSCIMMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping**](../Model/SCIMMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScimRetrieve()`

```php
propertymappingsProviderScimRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping
```



SCIMMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Provider Mapping.

try {
    $result = $apiInstance->propertymappingsProviderScimRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScimRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Provider Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping**](../Model/SCIMMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScimUpdate()`

```php
propertymappingsProviderScimUpdate($pm_uuid, $scim_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping
```



SCIMMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Provider Mapping.
$scim_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderScimUpdate($pm_uuid, $scim_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScimUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Provider Mapping. | |
| **scim_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMappingRequest**](../Model/SCIMMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMMapping**](../Model/SCIMMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScimUsedByList()`

```php
propertymappingsProviderScimUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Provider Mapping.

try {
    $result = $apiInstance->propertymappingsProviderScimUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScimUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Provider Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScopeCreate()`

```php
propertymappingsProviderScopeCreate($scope_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping
```



ScopeMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scope_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderScopeCreate($scope_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScopeCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **scope_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMappingRequest**](../Model/ScopeMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping**](../Model/ScopeMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScopeDestroy()`

```php
propertymappingsProviderScopeDestroy($pm_uuid)
```



ScopeMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Scope Mapping.

try {
    $apiInstance->propertymappingsProviderScopeDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScopeDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Scope Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScopeList()`

```php
propertymappingsProviderScopeList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $scope_name, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedScopeMappingList
```



ScopeMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$scope_name = 'scope_name_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsProviderScopeList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $scope_name, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScopeList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **scope_name** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedScopeMappingList**](../Model/PaginatedScopeMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScopePartialUpdate()`

```php
propertymappingsProviderScopePartialUpdate($pm_uuid, $patched_scope_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping
```



ScopeMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Scope Mapping.
$patched_scope_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedScopeMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedScopeMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderScopePartialUpdate($pm_uuid, $patched_scope_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScopePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Scope Mapping. | |
| **patched_scope_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedScopeMappingRequest**](../Model/PatchedScopeMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping**](../Model/ScopeMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScopeRetrieve()`

```php
propertymappingsProviderScopeRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping
```



ScopeMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Scope Mapping.

try {
    $result = $apiInstance->propertymappingsProviderScopeRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScopeRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Scope Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping**](../Model/ScopeMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScopeUpdate()`

```php
propertymappingsProviderScopeUpdate($pm_uuid, $scope_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping
```



ScopeMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Scope Mapping.
$scope_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMappingRequest

try {
    $result = $apiInstance->propertymappingsProviderScopeUpdate($pm_uuid, $scope_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScopeUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Scope Mapping. | |
| **scope_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMappingRequest**](../Model/ScopeMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScopeMapping**](../Model/ScopeMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsProviderScopeUsedByList()`

```php
propertymappingsProviderScopeUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Scope Mapping.

try {
    $result = $apiInstance->propertymappingsProviderScopeUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsProviderScopeUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Scope Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceKerberosCreate()`

```php
propertymappingsSourceKerberosCreate($kerberos_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping
```



KerberosSource PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kerberos_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceKerberosCreate($kerberos_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceKerberosCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kerberos_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMappingRequest**](../Model/KerberosSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping**](../Model/KerberosSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceKerberosDestroy()`

```php
propertymappingsSourceKerberosDestroy($pm_uuid)
```



KerberosSource PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Kerberos Source Property Mapping.

try {
    $apiInstance->propertymappingsSourceKerberosDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceKerberosDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Kerberos Source Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceKerberosList()`

```php
propertymappingsSourceKerberosList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedKerberosSourcePropertyMappingList
```



KerberosSource PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsSourceKerberosList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceKerberosList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedKerberosSourcePropertyMappingList**](../Model/PaginatedKerberosSourcePropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceKerberosPartialUpdate()`

```php
propertymappingsSourceKerberosPartialUpdate($pm_uuid, $patched_kerberos_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping
```



KerberosSource PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Kerberos Source Property Mapping.
$patched_kerberos_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedKerberosSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedKerberosSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceKerberosPartialUpdate($pm_uuid, $patched_kerberos_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceKerberosPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Kerberos Source Property Mapping. | |
| **patched_kerberos_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedKerberosSourcePropertyMappingRequest**](../Model/PatchedKerberosSourcePropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping**](../Model/KerberosSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceKerberosRetrieve()`

```php
propertymappingsSourceKerberosRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping
```



KerberosSource PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Kerberos Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceKerberosRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceKerberosRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Kerberos Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping**](../Model/KerberosSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceKerberosUpdate()`

```php
propertymappingsSourceKerberosUpdate($pm_uuid, $kerberos_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping
```



KerberosSource PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Kerberos Source Property Mapping.
$kerberos_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceKerberosUpdate($pm_uuid, $kerberos_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceKerberosUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Kerberos Source Property Mapping. | |
| **kerberos_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMappingRequest**](../Model/KerberosSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KerberosSourcePropertyMapping**](../Model/KerberosSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceKerberosUsedByList()`

```php
propertymappingsSourceKerberosUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Kerberos Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceKerberosUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceKerberosUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Kerberos Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceLdapCreate()`

```php
propertymappingsSourceLdapCreate($ldap_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping
```



LDAP PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ldap_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceLdapCreate($ldap_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceLdapCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ldap_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMappingRequest**](../Model/LDAPSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping**](../Model/LDAPSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceLdapDestroy()`

```php
propertymappingsSourceLdapDestroy($pm_uuid)
```



LDAP PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this LDAP Source Property Mapping.

try {
    $apiInstance->propertymappingsSourceLdapDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceLdapDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this LDAP Source Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceLdapList()`

```php
propertymappingsSourceLdapList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLDAPSourcePropertyMappingList
```



LDAP PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsSourceLdapList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceLdapList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLDAPSourcePropertyMappingList**](../Model/PaginatedLDAPSourcePropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceLdapPartialUpdate()`

```php
propertymappingsSourceLdapPartialUpdate($pm_uuid, $patched_ldap_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping
```



LDAP PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this LDAP Source Property Mapping.
$patched_ldap_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLDAPSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLDAPSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceLdapPartialUpdate($pm_uuid, $patched_ldap_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceLdapPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this LDAP Source Property Mapping. | |
| **patched_ldap_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLDAPSourcePropertyMappingRequest**](../Model/PatchedLDAPSourcePropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping**](../Model/LDAPSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceLdapRetrieve()`

```php
propertymappingsSourceLdapRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping
```



LDAP PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this LDAP Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceLdapRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceLdapRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this LDAP Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping**](../Model/LDAPSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceLdapUpdate()`

```php
propertymappingsSourceLdapUpdate($pm_uuid, $ldap_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping
```



LDAP PropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this LDAP Source Property Mapping.
$ldap_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceLdapUpdate($pm_uuid, $ldap_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceLdapUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this LDAP Source Property Mapping. | |
| **ldap_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMappingRequest**](../Model/LDAPSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPSourcePropertyMapping**](../Model/LDAPSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceLdapUsedByList()`

```php
propertymappingsSourceLdapUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this LDAP Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceLdapUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceLdapUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this LDAP Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceOauthCreate()`

```php
propertymappingsSourceOauthCreate($o_auth_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping
```



OAuthSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$o_auth_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceOauthCreate($o_auth_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceOauthCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **o_auth_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMappingRequest**](../Model/OAuthSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping**](../Model/OAuthSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceOauthDestroy()`

```php
propertymappingsSourceOauthDestroy($pm_uuid)
```



OAuthSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this OAuth Source Property Mapping.

try {
    $apiInstance->propertymappingsSourceOauthDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceOauthDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this OAuth Source Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceOauthList()`

```php
propertymappingsSourceOauthList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedOAuthSourcePropertyMappingList
```



OAuthSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsSourceOauthList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceOauthList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedOAuthSourcePropertyMappingList**](../Model/PaginatedOAuthSourcePropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceOauthPartialUpdate()`

```php
propertymappingsSourceOauthPartialUpdate($pm_uuid, $patched_o_auth_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping
```



OAuthSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this OAuth Source Property Mapping.
$patched_o_auth_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOAuthSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOAuthSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceOauthPartialUpdate($pm_uuid, $patched_o_auth_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceOauthPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this OAuth Source Property Mapping. | |
| **patched_o_auth_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOAuthSourcePropertyMappingRequest**](../Model/PatchedOAuthSourcePropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping**](../Model/OAuthSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceOauthRetrieve()`

```php
propertymappingsSourceOauthRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping
```



OAuthSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this OAuth Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceOauthRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceOauthRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this OAuth Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping**](../Model/OAuthSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceOauthUpdate()`

```php
propertymappingsSourceOauthUpdate($pm_uuid, $o_auth_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping
```



OAuthSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this OAuth Source Property Mapping.
$o_auth_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceOauthUpdate($pm_uuid, $o_auth_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceOauthUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this OAuth Source Property Mapping. | |
| **o_auth_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMappingRequest**](../Model/OAuthSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuthSourcePropertyMapping**](../Model/OAuthSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceOauthUsedByList()`

```php
propertymappingsSourceOauthUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this OAuth Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceOauthUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceOauthUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this OAuth Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourcePlexCreate()`

```php
propertymappingsSourcePlexCreate($plex_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping
```



PlexSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$plex_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourcePlexCreate($plex_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourcePlexCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **plex_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMappingRequest**](../Model/PlexSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping**](../Model/PlexSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourcePlexDestroy()`

```php
propertymappingsSourcePlexDestroy($pm_uuid)
```



PlexSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Plex Source Property Mapping.

try {
    $apiInstance->propertymappingsSourcePlexDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourcePlexDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Plex Source Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourcePlexList()`

```php
propertymappingsSourcePlexList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPlexSourcePropertyMappingList
```



PlexSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsSourcePlexList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourcePlexList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPlexSourcePropertyMappingList**](../Model/PaginatedPlexSourcePropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourcePlexPartialUpdate()`

```php
propertymappingsSourcePlexPartialUpdate($pm_uuid, $patched_plex_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping
```



PlexSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Plex Source Property Mapping.
$patched_plex_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPlexSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPlexSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourcePlexPartialUpdate($pm_uuid, $patched_plex_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourcePlexPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Plex Source Property Mapping. | |
| **patched_plex_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPlexSourcePropertyMappingRequest**](../Model/PatchedPlexSourcePropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping**](../Model/PlexSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourcePlexRetrieve()`

```php
propertymappingsSourcePlexRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping
```



PlexSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Plex Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourcePlexRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourcePlexRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Plex Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping**](../Model/PlexSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourcePlexUpdate()`

```php
propertymappingsSourcePlexUpdate($pm_uuid, $plex_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping
```



PlexSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Plex Source Property Mapping.
$plex_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourcePlexUpdate($pm_uuid, $plex_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourcePlexUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Plex Source Property Mapping. | |
| **plex_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMappingRequest**](../Model/PlexSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PlexSourcePropertyMapping**](../Model/PlexSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourcePlexUsedByList()`

```php
propertymappingsSourcePlexUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Plex Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourcePlexUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourcePlexUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Plex Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceSamlCreate()`

```php
propertymappingsSourceSamlCreate($saml_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping
```



SAMLSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$saml_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceSamlCreate($saml_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceSamlCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **saml_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMappingRequest**](../Model/SAMLSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping**](../Model/SAMLSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceSamlDestroy()`

```php
propertymappingsSourceSamlDestroy($pm_uuid)
```



SAMLSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Source Property Mapping.

try {
    $apiInstance->propertymappingsSourceSamlDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceSamlDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Source Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceSamlList()`

```php
propertymappingsSourceSamlList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSAMLSourcePropertyMappingList
```



SAMLSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsSourceSamlList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceSamlList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSAMLSourcePropertyMappingList**](../Model/PaginatedSAMLSourcePropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceSamlPartialUpdate()`

```php
propertymappingsSourceSamlPartialUpdate($pm_uuid, $patched_saml_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping
```



SAMLSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Source Property Mapping.
$patched_saml_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceSamlPartialUpdate($pm_uuid, $patched_saml_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceSamlPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Source Property Mapping. | |
| **patched_saml_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLSourcePropertyMappingRequest**](../Model/PatchedSAMLSourcePropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping**](../Model/SAMLSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceSamlRetrieve()`

```php
propertymappingsSourceSamlRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping
```



SAMLSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceSamlRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceSamlRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping**](../Model/SAMLSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceSamlUpdate()`

```php
propertymappingsSourceSamlUpdate($pm_uuid, $saml_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping
```



SAMLSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Source Property Mapping.
$saml_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceSamlUpdate($pm_uuid, $saml_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceSamlUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Source Property Mapping. | |
| **saml_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMappingRequest**](../Model/SAMLSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLSourcePropertyMapping**](../Model/SAMLSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceSamlUsedByList()`

```php
propertymappingsSourceSamlUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SAML Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceSamlUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceSamlUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SAML Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceScimCreate()`

```php
propertymappingsSourceScimCreate($scim_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping
```



SCIMSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scim_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceScimCreate($scim_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceScimCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **scim_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMappingRequest**](../Model/SCIMSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping**](../Model/SCIMSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceScimDestroy()`

```php
propertymappingsSourceScimDestroy($pm_uuid)
```



SCIMSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Source Property Mapping.

try {
    $apiInstance->propertymappingsSourceScimDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceScimDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Source Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceScimList()`

```php
propertymappingsSourceScimList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMSourcePropertyMappingList
```



SCIMSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsSourceScimList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceScimList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMSourcePropertyMappingList**](../Model/PaginatedSCIMSourcePropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceScimPartialUpdate()`

```php
propertymappingsSourceScimPartialUpdate($pm_uuid, $patched_scim_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping
```



SCIMSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Source Property Mapping.
$patched_scim_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceScimPartialUpdate($pm_uuid, $patched_scim_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceScimPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Source Property Mapping. | |
| **patched_scim_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMSourcePropertyMappingRequest**](../Model/PatchedSCIMSourcePropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping**](../Model/SCIMSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceScimRetrieve()`

```php
propertymappingsSourceScimRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping
```



SCIMSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceScimRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceScimRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping**](../Model/SCIMSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceScimUpdate()`

```php
propertymappingsSourceScimUpdate($pm_uuid, $scim_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping
```



SCIMSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Source Property Mapping.
$scim_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceScimUpdate($pm_uuid, $scim_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceScimUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Source Property Mapping. | |
| **scim_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMappingRequest**](../Model/SCIMSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMSourcePropertyMapping**](../Model/SCIMSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceScimUsedByList()`

```php
propertymappingsSourceScimUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this SCIM Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceScimUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceScimUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this SCIM Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceTelegramCreate()`

```php
propertymappingsSourceTelegramCreate($telegram_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping
```



TelegramSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$telegram_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceTelegramCreate($telegram_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceTelegramCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **telegram_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMappingRequest**](../Model/TelegramSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping**](../Model/TelegramSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceTelegramDestroy()`

```php
propertymappingsSourceTelegramDestroy($pm_uuid)
```



TelegramSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Telegram Source Property Mapping.

try {
    $apiInstance->propertymappingsSourceTelegramDestroy($pm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceTelegramDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Telegram Source Property Mapping. | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceTelegramList()`

```php
propertymappingsSourceTelegramList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTelegramSourcePropertyMappingList
```



TelegramSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->propertymappingsSourceTelegramList($managed, $managed__isnull, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceTelegramList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTelegramSourcePropertyMappingList**](../Model/PaginatedTelegramSourcePropertyMappingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceTelegramPartialUpdate()`

```php
propertymappingsSourceTelegramPartialUpdate($pm_uuid, $patched_telegram_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping
```



TelegramSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Telegram Source Property Mapping.
$patched_telegram_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTelegramSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTelegramSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceTelegramPartialUpdate($pm_uuid, $patched_telegram_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceTelegramPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Telegram Source Property Mapping. | |
| **patched_telegram_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTelegramSourcePropertyMappingRequest**](../Model/PatchedTelegramSourcePropertyMappingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping**](../Model/TelegramSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceTelegramRetrieve()`

```php
propertymappingsSourceTelegramRetrieve($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping
```



TelegramSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Telegram Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceTelegramRetrieve($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceTelegramRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Telegram Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping**](../Model/TelegramSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceTelegramUpdate()`

```php
propertymappingsSourceTelegramUpdate($pm_uuid, $telegram_source_property_mapping_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping
```



TelegramSourcePropertyMapping Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Telegram Source Property Mapping.
$telegram_source_property_mapping_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMappingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMappingRequest

try {
    $result = $apiInstance->propertymappingsSourceTelegramUpdate($pm_uuid, $telegram_source_property_mapping_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceTelegramUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Telegram Source Property Mapping. | |
| **telegram_source_property_mapping_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMappingRequest**](../Model/TelegramSourcePropertyMappingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TelegramSourcePropertyMapping**](../Model/TelegramSourcePropertyMapping.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `propertymappingsSourceTelegramUsedByList()`

```php
propertymappingsSourceTelegramUsedByList($pm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PropertymappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pm_uuid = 'pm_uuid_example'; // string | A UUID string identifying this Telegram Source Property Mapping.

try {
    $result = $apiInstance->propertymappingsSourceTelegramUsedByList($pm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PropertymappingsApi->propertymappingsSourceTelegramUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pm_uuid** | **string**| A UUID string identifying this Telegram Source Property Mapping. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]**](../Model/UsedBy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
