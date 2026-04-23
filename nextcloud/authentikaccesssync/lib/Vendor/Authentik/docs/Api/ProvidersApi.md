# OCA\AuthentikAccessSync\Vendor\Authentik\ProvidersApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**providersAllDestroy()**](ProvidersApi.md#providersAllDestroy) | **DELETE** /providers/all/{id}/ |  |
| [**providersAllList()**](ProvidersApi.md#providersAllList) | **GET** /providers/all/ |  |
| [**providersAllRetrieve()**](ProvidersApi.md#providersAllRetrieve) | **GET** /providers/all/{id}/ |  |
| [**providersAllTypesList()**](ProvidersApi.md#providersAllTypesList) | **GET** /providers/all/types/ |  |
| [**providersAllUsedByList()**](ProvidersApi.md#providersAllUsedByList) | **GET** /providers/all/{id}/used_by/ |  |
| [**providersGoogleWorkspaceCreate()**](ProvidersApi.md#providersGoogleWorkspaceCreate) | **POST** /providers/google_workspace/ |  |
| [**providersGoogleWorkspaceDestroy()**](ProvidersApi.md#providersGoogleWorkspaceDestroy) | **DELETE** /providers/google_workspace/{id}/ |  |
| [**providersGoogleWorkspaceGroupsCreate()**](ProvidersApi.md#providersGoogleWorkspaceGroupsCreate) | **POST** /providers/google_workspace_groups/ |  |
| [**providersGoogleWorkspaceGroupsDestroy()**](ProvidersApi.md#providersGoogleWorkspaceGroupsDestroy) | **DELETE** /providers/google_workspace_groups/{id}/ |  |
| [**providersGoogleWorkspaceGroupsList()**](ProvidersApi.md#providersGoogleWorkspaceGroupsList) | **GET** /providers/google_workspace_groups/ |  |
| [**providersGoogleWorkspaceGroupsRetrieve()**](ProvidersApi.md#providersGoogleWorkspaceGroupsRetrieve) | **GET** /providers/google_workspace_groups/{id}/ |  |
| [**providersGoogleWorkspaceGroupsUsedByList()**](ProvidersApi.md#providersGoogleWorkspaceGroupsUsedByList) | **GET** /providers/google_workspace_groups/{id}/used_by/ |  |
| [**providersGoogleWorkspaceList()**](ProvidersApi.md#providersGoogleWorkspaceList) | **GET** /providers/google_workspace/ |  |
| [**providersGoogleWorkspacePartialUpdate()**](ProvidersApi.md#providersGoogleWorkspacePartialUpdate) | **PATCH** /providers/google_workspace/{id}/ |  |
| [**providersGoogleWorkspaceRetrieve()**](ProvidersApi.md#providersGoogleWorkspaceRetrieve) | **GET** /providers/google_workspace/{id}/ |  |
| [**providersGoogleWorkspaceSyncObjectCreate()**](ProvidersApi.md#providersGoogleWorkspaceSyncObjectCreate) | **POST** /providers/google_workspace/{id}/sync/object/ |  |
| [**providersGoogleWorkspaceSyncStatusRetrieve()**](ProvidersApi.md#providersGoogleWorkspaceSyncStatusRetrieve) | **GET** /providers/google_workspace/{id}/sync/status/ |  |
| [**providersGoogleWorkspaceUpdate()**](ProvidersApi.md#providersGoogleWorkspaceUpdate) | **PUT** /providers/google_workspace/{id}/ |  |
| [**providersGoogleWorkspaceUsedByList()**](ProvidersApi.md#providersGoogleWorkspaceUsedByList) | **GET** /providers/google_workspace/{id}/used_by/ |  |
| [**providersGoogleWorkspaceUsersCreate()**](ProvidersApi.md#providersGoogleWorkspaceUsersCreate) | **POST** /providers/google_workspace_users/ |  |
| [**providersGoogleWorkspaceUsersDestroy()**](ProvidersApi.md#providersGoogleWorkspaceUsersDestroy) | **DELETE** /providers/google_workspace_users/{id}/ |  |
| [**providersGoogleWorkspaceUsersList()**](ProvidersApi.md#providersGoogleWorkspaceUsersList) | **GET** /providers/google_workspace_users/ |  |
| [**providersGoogleWorkspaceUsersRetrieve()**](ProvidersApi.md#providersGoogleWorkspaceUsersRetrieve) | **GET** /providers/google_workspace_users/{id}/ |  |
| [**providersGoogleWorkspaceUsersUsedByList()**](ProvidersApi.md#providersGoogleWorkspaceUsersUsedByList) | **GET** /providers/google_workspace_users/{id}/used_by/ |  |
| [**providersLdapCreate()**](ProvidersApi.md#providersLdapCreate) | **POST** /providers/ldap/ |  |
| [**providersLdapDestroy()**](ProvidersApi.md#providersLdapDestroy) | **DELETE** /providers/ldap/{id}/ |  |
| [**providersLdapList()**](ProvidersApi.md#providersLdapList) | **GET** /providers/ldap/ |  |
| [**providersLdapPartialUpdate()**](ProvidersApi.md#providersLdapPartialUpdate) | **PATCH** /providers/ldap/{id}/ |  |
| [**providersLdapRetrieve()**](ProvidersApi.md#providersLdapRetrieve) | **GET** /providers/ldap/{id}/ |  |
| [**providersLdapUpdate()**](ProvidersApi.md#providersLdapUpdate) | **PUT** /providers/ldap/{id}/ |  |
| [**providersLdapUsedByList()**](ProvidersApi.md#providersLdapUsedByList) | **GET** /providers/ldap/{id}/used_by/ |  |
| [**providersMicrosoftEntraCreate()**](ProvidersApi.md#providersMicrosoftEntraCreate) | **POST** /providers/microsoft_entra/ |  |
| [**providersMicrosoftEntraDestroy()**](ProvidersApi.md#providersMicrosoftEntraDestroy) | **DELETE** /providers/microsoft_entra/{id}/ |  |
| [**providersMicrosoftEntraGroupsCreate()**](ProvidersApi.md#providersMicrosoftEntraGroupsCreate) | **POST** /providers/microsoft_entra_groups/ |  |
| [**providersMicrosoftEntraGroupsDestroy()**](ProvidersApi.md#providersMicrosoftEntraGroupsDestroy) | **DELETE** /providers/microsoft_entra_groups/{id}/ |  |
| [**providersMicrosoftEntraGroupsList()**](ProvidersApi.md#providersMicrosoftEntraGroupsList) | **GET** /providers/microsoft_entra_groups/ |  |
| [**providersMicrosoftEntraGroupsRetrieve()**](ProvidersApi.md#providersMicrosoftEntraGroupsRetrieve) | **GET** /providers/microsoft_entra_groups/{id}/ |  |
| [**providersMicrosoftEntraGroupsUsedByList()**](ProvidersApi.md#providersMicrosoftEntraGroupsUsedByList) | **GET** /providers/microsoft_entra_groups/{id}/used_by/ |  |
| [**providersMicrosoftEntraList()**](ProvidersApi.md#providersMicrosoftEntraList) | **GET** /providers/microsoft_entra/ |  |
| [**providersMicrosoftEntraPartialUpdate()**](ProvidersApi.md#providersMicrosoftEntraPartialUpdate) | **PATCH** /providers/microsoft_entra/{id}/ |  |
| [**providersMicrosoftEntraRetrieve()**](ProvidersApi.md#providersMicrosoftEntraRetrieve) | **GET** /providers/microsoft_entra/{id}/ |  |
| [**providersMicrosoftEntraSyncObjectCreate()**](ProvidersApi.md#providersMicrosoftEntraSyncObjectCreate) | **POST** /providers/microsoft_entra/{id}/sync/object/ |  |
| [**providersMicrosoftEntraSyncStatusRetrieve()**](ProvidersApi.md#providersMicrosoftEntraSyncStatusRetrieve) | **GET** /providers/microsoft_entra/{id}/sync/status/ |  |
| [**providersMicrosoftEntraUpdate()**](ProvidersApi.md#providersMicrosoftEntraUpdate) | **PUT** /providers/microsoft_entra/{id}/ |  |
| [**providersMicrosoftEntraUsedByList()**](ProvidersApi.md#providersMicrosoftEntraUsedByList) | **GET** /providers/microsoft_entra/{id}/used_by/ |  |
| [**providersMicrosoftEntraUsersCreate()**](ProvidersApi.md#providersMicrosoftEntraUsersCreate) | **POST** /providers/microsoft_entra_users/ |  |
| [**providersMicrosoftEntraUsersDestroy()**](ProvidersApi.md#providersMicrosoftEntraUsersDestroy) | **DELETE** /providers/microsoft_entra_users/{id}/ |  |
| [**providersMicrosoftEntraUsersList()**](ProvidersApi.md#providersMicrosoftEntraUsersList) | **GET** /providers/microsoft_entra_users/ |  |
| [**providersMicrosoftEntraUsersRetrieve()**](ProvidersApi.md#providersMicrosoftEntraUsersRetrieve) | **GET** /providers/microsoft_entra_users/{id}/ |  |
| [**providersMicrosoftEntraUsersUsedByList()**](ProvidersApi.md#providersMicrosoftEntraUsersUsedByList) | **GET** /providers/microsoft_entra_users/{id}/used_by/ |  |
| [**providersOauth2Create()**](ProvidersApi.md#providersOauth2Create) | **POST** /providers/oauth2/ |  |
| [**providersOauth2Destroy()**](ProvidersApi.md#providersOauth2Destroy) | **DELETE** /providers/oauth2/{id}/ |  |
| [**providersOauth2List()**](ProvidersApi.md#providersOauth2List) | **GET** /providers/oauth2/ |  |
| [**providersOauth2PartialUpdate()**](ProvidersApi.md#providersOauth2PartialUpdate) | **PATCH** /providers/oauth2/{id}/ |  |
| [**providersOauth2PreviewUserRetrieve()**](ProvidersApi.md#providersOauth2PreviewUserRetrieve) | **GET** /providers/oauth2/{id}/preview_user/ |  |
| [**providersOauth2Retrieve()**](ProvidersApi.md#providersOauth2Retrieve) | **GET** /providers/oauth2/{id}/ |  |
| [**providersOauth2SetupUrlsRetrieve()**](ProvidersApi.md#providersOauth2SetupUrlsRetrieve) | **GET** /providers/oauth2/{id}/setup_urls/ |  |
| [**providersOauth2Update()**](ProvidersApi.md#providersOauth2Update) | **PUT** /providers/oauth2/{id}/ |  |
| [**providersOauth2UsedByList()**](ProvidersApi.md#providersOauth2UsedByList) | **GET** /providers/oauth2/{id}/used_by/ |  |
| [**providersProxyCreate()**](ProvidersApi.md#providersProxyCreate) | **POST** /providers/proxy/ |  |
| [**providersProxyDestroy()**](ProvidersApi.md#providersProxyDestroy) | **DELETE** /providers/proxy/{id}/ |  |
| [**providersProxyList()**](ProvidersApi.md#providersProxyList) | **GET** /providers/proxy/ |  |
| [**providersProxyPartialUpdate()**](ProvidersApi.md#providersProxyPartialUpdate) | **PATCH** /providers/proxy/{id}/ |  |
| [**providersProxyRetrieve()**](ProvidersApi.md#providersProxyRetrieve) | **GET** /providers/proxy/{id}/ |  |
| [**providersProxyUpdate()**](ProvidersApi.md#providersProxyUpdate) | **PUT** /providers/proxy/{id}/ |  |
| [**providersProxyUsedByList()**](ProvidersApi.md#providersProxyUsedByList) | **GET** /providers/proxy/{id}/used_by/ |  |
| [**providersRacCreate()**](ProvidersApi.md#providersRacCreate) | **POST** /providers/rac/ |  |
| [**providersRacDestroy()**](ProvidersApi.md#providersRacDestroy) | **DELETE** /providers/rac/{id}/ |  |
| [**providersRacList()**](ProvidersApi.md#providersRacList) | **GET** /providers/rac/ |  |
| [**providersRacPartialUpdate()**](ProvidersApi.md#providersRacPartialUpdate) | **PATCH** /providers/rac/{id}/ |  |
| [**providersRacRetrieve()**](ProvidersApi.md#providersRacRetrieve) | **GET** /providers/rac/{id}/ |  |
| [**providersRacUpdate()**](ProvidersApi.md#providersRacUpdate) | **PUT** /providers/rac/{id}/ |  |
| [**providersRacUsedByList()**](ProvidersApi.md#providersRacUsedByList) | **GET** /providers/rac/{id}/used_by/ |  |
| [**providersRadiusCreate()**](ProvidersApi.md#providersRadiusCreate) | **POST** /providers/radius/ |  |
| [**providersRadiusDestroy()**](ProvidersApi.md#providersRadiusDestroy) | **DELETE** /providers/radius/{id}/ |  |
| [**providersRadiusList()**](ProvidersApi.md#providersRadiusList) | **GET** /providers/radius/ |  |
| [**providersRadiusPartialUpdate()**](ProvidersApi.md#providersRadiusPartialUpdate) | **PATCH** /providers/radius/{id}/ |  |
| [**providersRadiusRetrieve()**](ProvidersApi.md#providersRadiusRetrieve) | **GET** /providers/radius/{id}/ |  |
| [**providersRadiusUpdate()**](ProvidersApi.md#providersRadiusUpdate) | **PUT** /providers/radius/{id}/ |  |
| [**providersRadiusUsedByList()**](ProvidersApi.md#providersRadiusUsedByList) | **GET** /providers/radius/{id}/used_by/ |  |
| [**providersSamlCreate()**](ProvidersApi.md#providersSamlCreate) | **POST** /providers/saml/ |  |
| [**providersSamlDestroy()**](ProvidersApi.md#providersSamlDestroy) | **DELETE** /providers/saml/{id}/ |  |
| [**providersSamlImportMetadataCreate()**](ProvidersApi.md#providersSamlImportMetadataCreate) | **POST** /providers/saml/import_metadata/ |  |
| [**providersSamlList()**](ProvidersApi.md#providersSamlList) | **GET** /providers/saml/ |  |
| [**providersSamlMetadataRetrieve()**](ProvidersApi.md#providersSamlMetadataRetrieve) | **GET** /providers/saml/{id}/metadata/ |  |
| [**providersSamlPartialUpdate()**](ProvidersApi.md#providersSamlPartialUpdate) | **PATCH** /providers/saml/{id}/ |  |
| [**providersSamlPreviewUserRetrieve()**](ProvidersApi.md#providersSamlPreviewUserRetrieve) | **GET** /providers/saml/{id}/preview_user/ |  |
| [**providersSamlRetrieve()**](ProvidersApi.md#providersSamlRetrieve) | **GET** /providers/saml/{id}/ |  |
| [**providersSamlUpdate()**](ProvidersApi.md#providersSamlUpdate) | **PUT** /providers/saml/{id}/ |  |
| [**providersSamlUsedByList()**](ProvidersApi.md#providersSamlUsedByList) | **GET** /providers/saml/{id}/used_by/ |  |
| [**providersScimCreate()**](ProvidersApi.md#providersScimCreate) | **POST** /providers/scim/ |  |
| [**providersScimDestroy()**](ProvidersApi.md#providersScimDestroy) | **DELETE** /providers/scim/{id}/ |  |
| [**providersScimGroupsCreate()**](ProvidersApi.md#providersScimGroupsCreate) | **POST** /providers/scim_groups/ |  |
| [**providersScimGroupsDestroy()**](ProvidersApi.md#providersScimGroupsDestroy) | **DELETE** /providers/scim_groups/{id}/ |  |
| [**providersScimGroupsList()**](ProvidersApi.md#providersScimGroupsList) | **GET** /providers/scim_groups/ |  |
| [**providersScimGroupsRetrieve()**](ProvidersApi.md#providersScimGroupsRetrieve) | **GET** /providers/scim_groups/{id}/ |  |
| [**providersScimGroupsUsedByList()**](ProvidersApi.md#providersScimGroupsUsedByList) | **GET** /providers/scim_groups/{id}/used_by/ |  |
| [**providersScimList()**](ProvidersApi.md#providersScimList) | **GET** /providers/scim/ |  |
| [**providersScimPartialUpdate()**](ProvidersApi.md#providersScimPartialUpdate) | **PATCH** /providers/scim/{id}/ |  |
| [**providersScimRetrieve()**](ProvidersApi.md#providersScimRetrieve) | **GET** /providers/scim/{id}/ |  |
| [**providersScimSyncObjectCreate()**](ProvidersApi.md#providersScimSyncObjectCreate) | **POST** /providers/scim/{id}/sync/object/ |  |
| [**providersScimSyncStatusRetrieve()**](ProvidersApi.md#providersScimSyncStatusRetrieve) | **GET** /providers/scim/{id}/sync/status/ |  |
| [**providersScimUpdate()**](ProvidersApi.md#providersScimUpdate) | **PUT** /providers/scim/{id}/ |  |
| [**providersScimUsedByList()**](ProvidersApi.md#providersScimUsedByList) | **GET** /providers/scim/{id}/used_by/ |  |
| [**providersScimUsersCreate()**](ProvidersApi.md#providersScimUsersCreate) | **POST** /providers/scim_users/ |  |
| [**providersScimUsersDestroy()**](ProvidersApi.md#providersScimUsersDestroy) | **DELETE** /providers/scim_users/{id}/ |  |
| [**providersScimUsersList()**](ProvidersApi.md#providersScimUsersList) | **GET** /providers/scim_users/ |  |
| [**providersScimUsersRetrieve()**](ProvidersApi.md#providersScimUsersRetrieve) | **GET** /providers/scim_users/{id}/ |  |
| [**providersScimUsersUsedByList()**](ProvidersApi.md#providersScimUsersUsedByList) | **GET** /providers/scim_users/{id}/used_by/ |  |
| [**providersSsfCreate()**](ProvidersApi.md#providersSsfCreate) | **POST** /providers/ssf/ |  |
| [**providersSsfDestroy()**](ProvidersApi.md#providersSsfDestroy) | **DELETE** /providers/ssf/{id}/ |  |
| [**providersSsfList()**](ProvidersApi.md#providersSsfList) | **GET** /providers/ssf/ |  |
| [**providersSsfPartialUpdate()**](ProvidersApi.md#providersSsfPartialUpdate) | **PATCH** /providers/ssf/{id}/ |  |
| [**providersSsfRetrieve()**](ProvidersApi.md#providersSsfRetrieve) | **GET** /providers/ssf/{id}/ |  |
| [**providersSsfUpdate()**](ProvidersApi.md#providersSsfUpdate) | **PUT** /providers/ssf/{id}/ |  |
| [**providersSsfUsedByList()**](ProvidersApi.md#providersSsfUsedByList) | **GET** /providers/ssf/{id}/used_by/ |  |
| [**providersWsfedCreate()**](ProvidersApi.md#providersWsfedCreate) | **POST** /providers/wsfed/ |  |
| [**providersWsfedDestroy()**](ProvidersApi.md#providersWsfedDestroy) | **DELETE** /providers/wsfed/{id}/ |  |
| [**providersWsfedList()**](ProvidersApi.md#providersWsfedList) | **GET** /providers/wsfed/ |  |
| [**providersWsfedMetadataRetrieve()**](ProvidersApi.md#providersWsfedMetadataRetrieve) | **GET** /providers/wsfed/{id}/metadata/ |  |
| [**providersWsfedPartialUpdate()**](ProvidersApi.md#providersWsfedPartialUpdate) | **PATCH** /providers/wsfed/{id}/ |  |
| [**providersWsfedPreviewUserRetrieve()**](ProvidersApi.md#providersWsfedPreviewUserRetrieve) | **GET** /providers/wsfed/{id}/preview_user/ |  |
| [**providersWsfedRetrieve()**](ProvidersApi.md#providersWsfedRetrieve) | **GET** /providers/wsfed/{id}/ |  |
| [**providersWsfedUpdate()**](ProvidersApi.md#providersWsfedUpdate) | **PUT** /providers/wsfed/{id}/ |  |
| [**providersWsfedUsedByList()**](ProvidersApi.md#providersWsfedUsedByList) | **GET** /providers/wsfed/{id}/used_by/ |  |


## `providersAllDestroy()`

```php
providersAllDestroy($id)
```



Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this provider.

try {
    $apiInstance->providersAllDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersAllDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this provider. | |

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

## `providersAllList()`

```php
providersAllList($application__isnull, $backchannel, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedProviderList
```



Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application__isnull = True; // bool
$backchannel = True; // bool | When not set all providers are returned. When set to true, only backchannel providers are returned. When set to false, backchannel providers are excluded
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersAllList($application__isnull, $backchannel, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersAllList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application__isnull** | **bool**|  | [optional] |
| **backchannel** | **bool**| When not set all providers are returned. When set to true, only backchannel providers are returned. When set to false, backchannel providers are excluded | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedProviderList**](../Model/PaginatedProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersAllRetrieve()`

```php
providersAllRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Provider
```



Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this provider.

try {
    $result = $apiInstance->providersAllRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersAllRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Provider**](../Model/Provider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersAllTypesList()`

```php
providersAllTypesList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all creatable types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->providersAllTypesList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersAllTypesList: ', $e->getMessage(), PHP_EOL;
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

## `providersAllUsedByList()`

```php
providersAllUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this provider.

try {
    $result = $apiInstance->providersAllUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersAllUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this provider. | |

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

## `providersGoogleWorkspaceCreate()`

```php
providersGoogleWorkspaceCreate($google_workspace_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider
```



GoogleWorkspaceProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$google_workspace_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderRequest

try {
    $result = $apiInstance->providersGoogleWorkspaceCreate($google_workspace_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **google_workspace_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderRequest**](../Model/GoogleWorkspaceProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider**](../Model/GoogleWorkspaceProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceDestroy()`

```php
providersGoogleWorkspaceDestroy($id)
```



GoogleWorkspaceProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Google Workspace Provider.

try {
    $apiInstance->providersGoogleWorkspaceDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Google Workspace Provider. | |

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

## `providersGoogleWorkspaceGroupsCreate()`

```php
providersGoogleWorkspaceGroupsCreate($google_workspace_provider_group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderGroup
```



GoogleWorkspaceProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$google_workspace_provider_group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderGroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderGroupRequest

try {
    $result = $apiInstance->providersGoogleWorkspaceGroupsCreate($google_workspace_provider_group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceGroupsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **google_workspace_provider_group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderGroupRequest**](../Model/GoogleWorkspaceProviderGroupRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderGroup**](../Model/GoogleWorkspaceProviderGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceGroupsDestroy()`

```php
providersGoogleWorkspaceGroupsDestroy($id)
```



GoogleWorkspaceProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Google Workspace Provider Group.

try {
    $apiInstance->providersGoogleWorkspaceGroupsDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceGroupsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Google Workspace Provider Group. | |

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

## `providersGoogleWorkspaceGroupsList()`

```php
providersGoogleWorkspaceGroupsList($group__group_uuid, $group__name, $ordering, $page, $page_size, $provider__id, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderGroupList
```



GoogleWorkspaceProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group__group_uuid = 'group__group_uuid_example'; // string
$group__name = 'group__name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider__id = 56; // int
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersGoogleWorkspaceGroupsList($group__group_uuid, $group__name, $ordering, $page, $page_size, $provider__id, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceGroupsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group__group_uuid** | **string**|  | [optional] |
| **group__name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider__id** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderGroupList**](../Model/PaginatedGoogleWorkspaceProviderGroupList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceGroupsRetrieve()`

```php
providersGoogleWorkspaceGroupsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderGroup
```



GoogleWorkspaceProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Google Workspace Provider Group.

try {
    $result = $apiInstance->providersGoogleWorkspaceGroupsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceGroupsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Google Workspace Provider Group. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderGroup**](../Model/GoogleWorkspaceProviderGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceGroupsUsedByList()`

```php
providersGoogleWorkspaceGroupsUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Google Workspace Provider Group.

try {
    $result = $apiInstance->providersGoogleWorkspaceGroupsUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceGroupsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Google Workspace Provider Group. | |

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

## `providersGoogleWorkspaceList()`

```php
providersGoogleWorkspaceList($delegated_subject, $exclude_users_service_account, $filter_group, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderList
```



GoogleWorkspaceProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$delegated_subject = 'delegated_subject_example'; // string
$exclude_users_service_account = True; // bool
$filter_group = 'filter_group_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersGoogleWorkspaceList($delegated_subject, $exclude_users_service_account, $filter_group, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **delegated_subject** | **string**|  | [optional] |
| **exclude_users_service_account** | **bool**|  | [optional] |
| **filter_group** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderList**](../Model/PaginatedGoogleWorkspaceProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspacePartialUpdate()`

```php
providersGoogleWorkspacePartialUpdate($id, $patched_google_workspace_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider
```



GoogleWorkspaceProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Google Workspace Provider.
$patched_google_workspace_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleWorkspaceProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleWorkspaceProviderRequest

try {
    $result = $apiInstance->providersGoogleWorkspacePartialUpdate($id, $patched_google_workspace_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspacePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Google Workspace Provider. | |
| **patched_google_workspace_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleWorkspaceProviderRequest**](../Model/PatchedGoogleWorkspaceProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider**](../Model/GoogleWorkspaceProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceRetrieve()`

```php
providersGoogleWorkspaceRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider
```



GoogleWorkspaceProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Google Workspace Provider.

try {
    $result = $apiInstance->providersGoogleWorkspaceRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Google Workspace Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider**](../Model/GoogleWorkspaceProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceSyncObjectCreate()`

```php
providersGoogleWorkspaceSyncObjectCreate($id, $sync_object_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectResult
```



Sync/Re-sync a single user/group object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Google Workspace Provider.
$sync_object_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest

try {
    $result = $apiInstance->providersGoogleWorkspaceSyncObjectCreate($id, $sync_object_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceSyncObjectCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Google Workspace Provider. | |
| **sync_object_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest**](../Model/SyncObjectRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectResult**](../Model/SyncObjectResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceSyncStatusRetrieve()`

```php
providersGoogleWorkspaceSyncStatusRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncStatus
```



Get provider's sync status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Google Workspace Provider.

try {
    $result = $apiInstance->providersGoogleWorkspaceSyncStatusRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceSyncStatusRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Google Workspace Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncStatus**](../Model/SyncStatus.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceUpdate()`

```php
providersGoogleWorkspaceUpdate($id, $google_workspace_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider
```



GoogleWorkspaceProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Google Workspace Provider.
$google_workspace_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderRequest

try {
    $result = $apiInstance->providersGoogleWorkspaceUpdate($id, $google_workspace_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Google Workspace Provider. | |
| **google_workspace_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderRequest**](../Model/GoogleWorkspaceProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProvider**](../Model/GoogleWorkspaceProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceUsedByList()`

```php
providersGoogleWorkspaceUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Google Workspace Provider.

try {
    $result = $apiInstance->providersGoogleWorkspaceUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Google Workspace Provider. | |

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

## `providersGoogleWorkspaceUsersCreate()`

```php
providersGoogleWorkspaceUsersCreate($google_workspace_provider_user_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderUser
```



GoogleWorkspaceProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$google_workspace_provider_user_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderUserRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderUserRequest

try {
    $result = $apiInstance->providersGoogleWorkspaceUsersCreate($google_workspace_provider_user_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceUsersCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **google_workspace_provider_user_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderUserRequest**](../Model/GoogleWorkspaceProviderUserRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderUser**](../Model/GoogleWorkspaceProviderUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceUsersDestroy()`

```php
providersGoogleWorkspaceUsersDestroy($id)
```



GoogleWorkspaceProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Google Workspace Provider User.

try {
    $apiInstance->providersGoogleWorkspaceUsersDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceUsersDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Google Workspace Provider User. | |

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

## `providersGoogleWorkspaceUsersList()`

```php
providersGoogleWorkspaceUsersList($ordering, $page, $page_size, $provider__id, $search, $user__id, $user__username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderUserList
```



GoogleWorkspaceProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider__id = 56; // int
$search = 'search_example'; // string | A search term.
$user__id = 56; // int
$user__username = 'user__username_example'; // string

try {
    $result = $apiInstance->providersGoogleWorkspaceUsersList($ordering, $page, $page_size, $provider__id, $search, $user__id, $user__username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceUsersList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider__id** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **user__id** | **int**|  | [optional] |
| **user__username** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleWorkspaceProviderUserList**](../Model/PaginatedGoogleWorkspaceProviderUserList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceUsersRetrieve()`

```php
providersGoogleWorkspaceUsersRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderUser
```



GoogleWorkspaceProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Google Workspace Provider User.

try {
    $result = $apiInstance->providersGoogleWorkspaceUsersRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceUsersRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Google Workspace Provider User. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleWorkspaceProviderUser**](../Model/GoogleWorkspaceProviderUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersGoogleWorkspaceUsersUsedByList()`

```php
providersGoogleWorkspaceUsersUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Google Workspace Provider User.

try {
    $result = $apiInstance->providersGoogleWorkspaceUsersUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersGoogleWorkspaceUsersUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Google Workspace Provider User. | |

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

## `providersLdapCreate()`

```php
providersLdapCreate($ldap_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider
```



LDAPProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ldap_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProviderRequest

try {
    $result = $apiInstance->providersLdapCreate($ldap_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersLdapCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ldap_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProviderRequest**](../Model/LDAPProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider**](../Model/LDAPProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersLdapDestroy()`

```php
providersLdapDestroy($id)
```



LDAPProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this LDAP Provider.

try {
    $apiInstance->providersLdapDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersLdapDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this LDAP Provider. | |

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

## `providersLdapList()`

```php
providersLdapList($application__isnull, $authorization_flow__slug__iexact, $base_dn__iexact, $certificate__kp_uuid__iexact, $certificate__name__iexact, $gid_start_number__iexact, $name__iexact, $ordering, $page, $page_size, $search, $tls_server_name__iexact, $uid_start_number__iexact): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLDAPProviderList
```



LDAPProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application__isnull = True; // bool
$authorization_flow__slug__iexact = 'authorization_flow__slug__iexact_example'; // string
$base_dn__iexact = 'base_dn__iexact_example'; // string
$certificate__kp_uuid__iexact = 'certificate__kp_uuid__iexact_example'; // string
$certificate__name__iexact = 'certificate__name__iexact_example'; // string
$gid_start_number__iexact = 56; // int
$name__iexact = 'name__iexact_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$tls_server_name__iexact = 'tls_server_name__iexact_example'; // string
$uid_start_number__iexact = 56; // int

try {
    $result = $apiInstance->providersLdapList($application__isnull, $authorization_flow__slug__iexact, $base_dn__iexact, $certificate__kp_uuid__iexact, $certificate__name__iexact, $gid_start_number__iexact, $name__iexact, $ordering, $page, $page_size, $search, $tls_server_name__iexact, $uid_start_number__iexact);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersLdapList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application__isnull** | **bool**|  | [optional] |
| **authorization_flow__slug__iexact** | **string**|  | [optional] |
| **base_dn__iexact** | **string**|  | [optional] |
| **certificate__kp_uuid__iexact** | **string**|  | [optional] |
| **certificate__name__iexact** | **string**|  | [optional] |
| **gid_start_number__iexact** | **int**|  | [optional] |
| **name__iexact** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **tls_server_name__iexact** | **string**|  | [optional] |
| **uid_start_number__iexact** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLDAPProviderList**](../Model/PaginatedLDAPProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersLdapPartialUpdate()`

```php
providersLdapPartialUpdate($id, $patched_ldap_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider
```



LDAPProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this LDAP Provider.
$patched_ldap_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLDAPProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLDAPProviderRequest

try {
    $result = $apiInstance->providersLdapPartialUpdate($id, $patched_ldap_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersLdapPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this LDAP Provider. | |
| **patched_ldap_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLDAPProviderRequest**](../Model/PatchedLDAPProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider**](../Model/LDAPProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersLdapRetrieve()`

```php
providersLdapRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider
```



LDAPProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this LDAP Provider.

try {
    $result = $apiInstance->providersLdapRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersLdapRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this LDAP Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider**](../Model/LDAPProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersLdapUpdate()`

```php
providersLdapUpdate($id, $ldap_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider
```



LDAPProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this LDAP Provider.
$ldap_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProviderRequest

try {
    $result = $apiInstance->providersLdapUpdate($id, $ldap_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersLdapUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this LDAP Provider. | |
| **ldap_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProviderRequest**](../Model/LDAPProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPProvider**](../Model/LDAPProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersLdapUsedByList()`

```php
providersLdapUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this LDAP Provider.

try {
    $result = $apiInstance->providersLdapUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersLdapUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this LDAP Provider. | |

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

## `providersMicrosoftEntraCreate()`

```php
providersMicrosoftEntraCreate($microsoft_entra_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider
```



MicrosoftEntraProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$microsoft_entra_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderRequest

try {
    $result = $apiInstance->providersMicrosoftEntraCreate($microsoft_entra_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **microsoft_entra_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderRequest**](../Model/MicrosoftEntraProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider**](../Model/MicrosoftEntraProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraDestroy()`

```php
providersMicrosoftEntraDestroy($id)
```



MicrosoftEntraProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Microsoft Entra Provider.

try {
    $apiInstance->providersMicrosoftEntraDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Microsoft Entra Provider. | |

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

## `providersMicrosoftEntraGroupsCreate()`

```php
providersMicrosoftEntraGroupsCreate($microsoft_entra_provider_group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderGroup
```



MicrosoftEntraProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$microsoft_entra_provider_group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderGroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderGroupRequest

try {
    $result = $apiInstance->providersMicrosoftEntraGroupsCreate($microsoft_entra_provider_group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraGroupsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **microsoft_entra_provider_group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderGroupRequest**](../Model/MicrosoftEntraProviderGroupRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderGroup**](../Model/MicrosoftEntraProviderGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraGroupsDestroy()`

```php
providersMicrosoftEntraGroupsDestroy($id)
```



MicrosoftEntraProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Microsoft Entra Provider Group.

try {
    $apiInstance->providersMicrosoftEntraGroupsDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraGroupsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Microsoft Entra Provider Group. | |

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

## `providersMicrosoftEntraGroupsList()`

```php
providersMicrosoftEntraGroupsList($group__group_uuid, $group__name, $ordering, $page, $page_size, $provider__id, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderGroupList
```



MicrosoftEntraProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group__group_uuid = 'group__group_uuid_example'; // string
$group__name = 'group__name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider__id = 56; // int
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersMicrosoftEntraGroupsList($group__group_uuid, $group__name, $ordering, $page, $page_size, $provider__id, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraGroupsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group__group_uuid** | **string**|  | [optional] |
| **group__name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider__id** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderGroupList**](../Model/PaginatedMicrosoftEntraProviderGroupList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraGroupsRetrieve()`

```php
providersMicrosoftEntraGroupsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderGroup
```



MicrosoftEntraProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Microsoft Entra Provider Group.

try {
    $result = $apiInstance->providersMicrosoftEntraGroupsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraGroupsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Microsoft Entra Provider Group. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderGroup**](../Model/MicrosoftEntraProviderGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraGroupsUsedByList()`

```php
providersMicrosoftEntraGroupsUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Microsoft Entra Provider Group.

try {
    $result = $apiInstance->providersMicrosoftEntraGroupsUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraGroupsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Microsoft Entra Provider Group. | |

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

## `providersMicrosoftEntraList()`

```php
providersMicrosoftEntraList($exclude_users_service_account, $filter_group, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderList
```



MicrosoftEntraProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$exclude_users_service_account = True; // bool
$filter_group = 'filter_group_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersMicrosoftEntraList($exclude_users_service_account, $filter_group, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **exclude_users_service_account** | **bool**|  | [optional] |
| **filter_group** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderList**](../Model/PaginatedMicrosoftEntraProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraPartialUpdate()`

```php
providersMicrosoftEntraPartialUpdate($id, $patched_microsoft_entra_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider
```



MicrosoftEntraProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Microsoft Entra Provider.
$patched_microsoft_entra_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMicrosoftEntraProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMicrosoftEntraProviderRequest

try {
    $result = $apiInstance->providersMicrosoftEntraPartialUpdate($id, $patched_microsoft_entra_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Microsoft Entra Provider. | |
| **patched_microsoft_entra_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedMicrosoftEntraProviderRequest**](../Model/PatchedMicrosoftEntraProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider**](../Model/MicrosoftEntraProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraRetrieve()`

```php
providersMicrosoftEntraRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider
```



MicrosoftEntraProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Microsoft Entra Provider.

try {
    $result = $apiInstance->providersMicrosoftEntraRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Microsoft Entra Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider**](../Model/MicrosoftEntraProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraSyncObjectCreate()`

```php
providersMicrosoftEntraSyncObjectCreate($id, $sync_object_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectResult
```



Sync/Re-sync a single user/group object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Microsoft Entra Provider.
$sync_object_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest

try {
    $result = $apiInstance->providersMicrosoftEntraSyncObjectCreate($id, $sync_object_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraSyncObjectCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Microsoft Entra Provider. | |
| **sync_object_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest**](../Model/SyncObjectRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectResult**](../Model/SyncObjectResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraSyncStatusRetrieve()`

```php
providersMicrosoftEntraSyncStatusRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncStatus
```



Get provider's sync status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Microsoft Entra Provider.

try {
    $result = $apiInstance->providersMicrosoftEntraSyncStatusRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraSyncStatusRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Microsoft Entra Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncStatus**](../Model/SyncStatus.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraUpdate()`

```php
providersMicrosoftEntraUpdate($id, $microsoft_entra_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider
```



MicrosoftEntraProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Microsoft Entra Provider.
$microsoft_entra_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderRequest

try {
    $result = $apiInstance->providersMicrosoftEntraUpdate($id, $microsoft_entra_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Microsoft Entra Provider. | |
| **microsoft_entra_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderRequest**](../Model/MicrosoftEntraProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProvider**](../Model/MicrosoftEntraProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraUsedByList()`

```php
providersMicrosoftEntraUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Microsoft Entra Provider.

try {
    $result = $apiInstance->providersMicrosoftEntraUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Microsoft Entra Provider. | |

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

## `providersMicrosoftEntraUsersCreate()`

```php
providersMicrosoftEntraUsersCreate($microsoft_entra_provider_user_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderUser
```



MicrosoftEntraProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$microsoft_entra_provider_user_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderUserRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderUserRequest

try {
    $result = $apiInstance->providersMicrosoftEntraUsersCreate($microsoft_entra_provider_user_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraUsersCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **microsoft_entra_provider_user_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderUserRequest**](../Model/MicrosoftEntraProviderUserRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderUser**](../Model/MicrosoftEntraProviderUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraUsersDestroy()`

```php
providersMicrosoftEntraUsersDestroy($id)
```



MicrosoftEntraProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Microsoft Entra Provider User.

try {
    $apiInstance->providersMicrosoftEntraUsersDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraUsersDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Microsoft Entra Provider User. | |

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

## `providersMicrosoftEntraUsersList()`

```php
providersMicrosoftEntraUsersList($ordering, $page, $page_size, $provider__id, $search, $user__id, $user__username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderUserList
```



MicrosoftEntraProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider__id = 56; // int
$search = 'search_example'; // string | A search term.
$user__id = 56; // int
$user__username = 'user__username_example'; // string

try {
    $result = $apiInstance->providersMicrosoftEntraUsersList($ordering, $page, $page_size, $provider__id, $search, $user__id, $user__username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraUsersList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider__id** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **user__id** | **int**|  | [optional] |
| **user__username** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedMicrosoftEntraProviderUserList**](../Model/PaginatedMicrosoftEntraProviderUserList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraUsersRetrieve()`

```php
providersMicrosoftEntraUsersRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderUser
```



MicrosoftEntraProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Microsoft Entra Provider User.

try {
    $result = $apiInstance->providersMicrosoftEntraUsersRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraUsersRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Microsoft Entra Provider User. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MicrosoftEntraProviderUser**](../Model/MicrosoftEntraProviderUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersMicrosoftEntraUsersUsedByList()`

```php
providersMicrosoftEntraUsersUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Microsoft Entra Provider User.

try {
    $result = $apiInstance->providersMicrosoftEntraUsersUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersMicrosoftEntraUsersUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Microsoft Entra Provider User. | |

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

## `providersOauth2Create()`

```php
providersOauth2Create($o_auth2_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider
```



OAuth2Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$o_auth2_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderRequest

try {
    $result = $apiInstance->providersOauth2Create($o_auth2_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2Create: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **o_auth2_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderRequest**](../Model/OAuth2ProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider**](../Model/OAuth2Provider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersOauth2Destroy()`

```php
providersOauth2Destroy($id)
```



OAuth2Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this OAuth2/OpenID Provider.

try {
    $apiInstance->providersOauth2Destroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2Destroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this OAuth2/OpenID Provider. | |

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

## `providersOauth2List()`

```php
providersOauth2List($access_code_validity, $access_token_validity, $application, $authorization_flow, $client_id, $client_type, $include_claims_in_id_token, $issuer_mode, $name, $ordering, $page, $page_size, $property_mappings, $refresh_token_validity, $search, $signing_key, $sub_mode): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedOAuth2ProviderList
```



OAuth2Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$access_code_validity = 'access_code_validity_example'; // string
$access_token_validity = 'access_token_validity_example'; // string
$application = 'application_example'; // string
$authorization_flow = 'authorization_flow_example'; // string
$client_id = 'client_id_example'; // string
$client_type = 'client_type_example'; // string | Confidential clients are capable of maintaining the confidentiality of their credentials. Public clients are incapable
$include_claims_in_id_token = True; // bool
$issuer_mode = 'issuer_mode_example'; // string | Configure how the issuer field of the ID Token should be filled.
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$property_mappings = array('property_mappings_example'); // string[]
$refresh_token_validity = 'refresh_token_validity_example'; // string
$search = 'search_example'; // string | A search term.
$signing_key = 'signing_key_example'; // string
$sub_mode = 'sub_mode_example'; // string | Configure what data should be used as unique User Identifier. For most cases, the default should be fine.

try {
    $result = $apiInstance->providersOauth2List($access_code_validity, $access_token_validity, $application, $authorization_flow, $client_id, $client_type, $include_claims_in_id_token, $issuer_mode, $name, $ordering, $page, $page_size, $property_mappings, $refresh_token_validity, $search, $signing_key, $sub_mode);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2List: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **access_code_validity** | **string**|  | [optional] |
| **access_token_validity** | **string**|  | [optional] |
| **application** | **string**|  | [optional] |
| **authorization_flow** | **string**|  | [optional] |
| **client_id** | **string**|  | [optional] |
| **client_type** | **string**| Confidential clients are capable of maintaining the confidentiality of their credentials. Public clients are incapable | [optional] |
| **include_claims_in_id_token** | **bool**|  | [optional] |
| **issuer_mode** | **string**| Configure how the issuer field of the ID Token should be filled. | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **property_mappings** | [**string[]**](../Model/string.md)|  | [optional] |
| **refresh_token_validity** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **signing_key** | **string**|  | [optional] |
| **sub_mode** | **string**| Configure what data should be used as unique User Identifier. For most cases, the default should be fine. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedOAuth2ProviderList**](../Model/PaginatedOAuth2ProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersOauth2PartialUpdate()`

```php
providersOauth2PartialUpdate($id, $patched_o_auth2_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider
```



OAuth2Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this OAuth2/OpenID Provider.
$patched_o_auth2_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOAuth2ProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOAuth2ProviderRequest

try {
    $result = $apiInstance->providersOauth2PartialUpdate($id, $patched_o_auth2_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2PartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this OAuth2/OpenID Provider. | |
| **patched_o_auth2_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOAuth2ProviderRequest**](../Model/PatchedOAuth2ProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider**](../Model/OAuth2Provider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersOauth2PreviewUserRetrieve()`

```php
providersOauth2PreviewUserRetrieve($id, $for_user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingPreview
```



Preview user data for provider

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this OAuth2/OpenID Provider.
$for_user = 56; // int

try {
    $result = $apiInstance->providersOauth2PreviewUserRetrieve($id, $for_user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2PreviewUserRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this OAuth2/OpenID Provider. | |
| **for_user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingPreview**](../Model/PropertyMappingPreview.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersOauth2Retrieve()`

```php
providersOauth2Retrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider
```



OAuth2Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this OAuth2/OpenID Provider.

try {
    $result = $apiInstance->providersOauth2Retrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2Retrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this OAuth2/OpenID Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider**](../Model/OAuth2Provider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersOauth2SetupUrlsRetrieve()`

```php
providersOauth2SetupUrlsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderSetupURLs
```



Get Providers setup URLs

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this OAuth2/OpenID Provider.

try {
    $result = $apiInstance->providersOauth2SetupUrlsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2SetupUrlsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this OAuth2/OpenID Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderSetupURLs**](../Model/OAuth2ProviderSetupURLs.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersOauth2Update()`

```php
providersOauth2Update($id, $o_auth2_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider
```



OAuth2Provider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this OAuth2/OpenID Provider.
$o_auth2_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderRequest

try {
    $result = $apiInstance->providersOauth2Update($id, $o_auth2_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2Update: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this OAuth2/OpenID Provider. | |
| **o_auth2_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2ProviderRequest**](../Model/OAuth2ProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OAuth2Provider**](../Model/OAuth2Provider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersOauth2UsedByList()`

```php
providersOauth2UsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this OAuth2/OpenID Provider.

try {
    $result = $apiInstance->providersOauth2UsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersOauth2UsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this OAuth2/OpenID Provider. | |

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

## `providersProxyCreate()`

```php
providersProxyCreate($proxy_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider
```



ProxyProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$proxy_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProviderRequest

try {
    $result = $apiInstance->providersProxyCreate($proxy_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersProxyCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **proxy_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProviderRequest**](../Model/ProxyProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider**](../Model/ProxyProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersProxyDestroy()`

```php
providersProxyDestroy($id)
```



ProxyProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Proxy Provider.

try {
    $apiInstance->providersProxyDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersProxyDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Proxy Provider. | |

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

## `providersProxyList()`

```php
providersProxyList($application__isnull, $authorization_flow__slug__iexact, $basic_auth_enabled__iexact, $basic_auth_password_attribute__iexact, $basic_auth_user_attribute__iexact, $certificate__kp_uuid__iexact, $certificate__name__iexact, $cookie_domain__iexact, $external_host__iexact, $internal_host__iexact, $internal_host_ssl_validation__iexact, $mode__iexact, $name__iexact, $ordering, $page, $page_size, $property_mappings__iexact, $search, $skip_path_regex__iexact): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedProxyProviderList
```



ProxyProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application__isnull = True; // bool
$authorization_flow__slug__iexact = 'authorization_flow__slug__iexact_example'; // string
$basic_auth_enabled__iexact = True; // bool
$basic_auth_password_attribute__iexact = 'basic_auth_password_attribute__iexact_example'; // string
$basic_auth_user_attribute__iexact = 'basic_auth_user_attribute__iexact_example'; // string
$certificate__kp_uuid__iexact = 'certificate__kp_uuid__iexact_example'; // string
$certificate__name__iexact = 'certificate__name__iexact_example'; // string
$cookie_domain__iexact = 'cookie_domain__iexact_example'; // string
$external_host__iexact = 'external_host__iexact_example'; // string
$internal_host__iexact = 'internal_host__iexact_example'; // string
$internal_host_ssl_validation__iexact = True; // bool
$mode__iexact = 'mode__iexact_example'; // string
$name__iexact = 'name__iexact_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$property_mappings__iexact = array('property_mappings__iexact_example'); // string[]
$search = 'search_example'; // string | A search term.
$skip_path_regex__iexact = 'skip_path_regex__iexact_example'; // string

try {
    $result = $apiInstance->providersProxyList($application__isnull, $authorization_flow__slug__iexact, $basic_auth_enabled__iexact, $basic_auth_password_attribute__iexact, $basic_auth_user_attribute__iexact, $certificate__kp_uuid__iexact, $certificate__name__iexact, $cookie_domain__iexact, $external_host__iexact, $internal_host__iexact, $internal_host_ssl_validation__iexact, $mode__iexact, $name__iexact, $ordering, $page, $page_size, $property_mappings__iexact, $search, $skip_path_regex__iexact);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersProxyList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application__isnull** | **bool**|  | [optional] |
| **authorization_flow__slug__iexact** | **string**|  | [optional] |
| **basic_auth_enabled__iexact** | **bool**|  | [optional] |
| **basic_auth_password_attribute__iexact** | **string**|  | [optional] |
| **basic_auth_user_attribute__iexact** | **string**|  | [optional] |
| **certificate__kp_uuid__iexact** | **string**|  | [optional] |
| **certificate__name__iexact** | **string**|  | [optional] |
| **cookie_domain__iexact** | **string**|  | [optional] |
| **external_host__iexact** | **string**|  | [optional] |
| **internal_host__iexact** | **string**|  | [optional] |
| **internal_host_ssl_validation__iexact** | **bool**|  | [optional] |
| **mode__iexact** | **string**|  | [optional] |
| **name__iexact** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **property_mappings__iexact** | [**string[]**](../Model/string.md)|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **skip_path_regex__iexact** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedProxyProviderList**](../Model/PaginatedProxyProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersProxyPartialUpdate()`

```php
providersProxyPartialUpdate($id, $patched_proxy_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider
```



ProxyProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Proxy Provider.
$patched_proxy_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedProxyProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedProxyProviderRequest

try {
    $result = $apiInstance->providersProxyPartialUpdate($id, $patched_proxy_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersProxyPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Proxy Provider. | |
| **patched_proxy_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedProxyProviderRequest**](../Model/PatchedProxyProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider**](../Model/ProxyProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersProxyRetrieve()`

```php
providersProxyRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider
```



ProxyProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Proxy Provider.

try {
    $result = $apiInstance->providersProxyRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersProxyRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Proxy Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider**](../Model/ProxyProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersProxyUpdate()`

```php
providersProxyUpdate($id, $proxy_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider
```



ProxyProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Proxy Provider.
$proxy_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProviderRequest

try {
    $result = $apiInstance->providersProxyUpdate($id, $proxy_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersProxyUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Proxy Provider. | |
| **proxy_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProviderRequest**](../Model/ProxyProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ProxyProvider**](../Model/ProxyProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersProxyUsedByList()`

```php
providersProxyUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Proxy Provider.

try {
    $result = $apiInstance->providersProxyUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersProxyUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Proxy Provider. | |

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

## `providersRacCreate()`

```php
providersRacCreate($rac_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider
```



RACProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$rac_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProviderRequest

try {
    $result = $apiInstance->providersRacCreate($rac_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRacCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **rac_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProviderRequest**](../Model/RACProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider**](../Model/RACProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRacDestroy()`

```php
providersRacDestroy($id)
```



RACProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this RAC Provider.

try {
    $apiInstance->providersRacDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRacDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this RAC Provider. | |

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

## `providersRacList()`

```php
providersRacList($application__isnull, $name__iexact, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRACProviderList
```



RACProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application__isnull = True; // bool
$name__iexact = 'name__iexact_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersRacList($application__isnull, $name__iexact, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRacList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application__isnull** | **bool**|  | [optional] |
| **name__iexact** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRACProviderList**](../Model/PaginatedRACProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRacPartialUpdate()`

```php
providersRacPartialUpdate($id, $patched_rac_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider
```



RACProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this RAC Provider.
$patched_rac_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRACProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRACProviderRequest

try {
    $result = $apiInstance->providersRacPartialUpdate($id, $patched_rac_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRacPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this RAC Provider. | |
| **patched_rac_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRACProviderRequest**](../Model/PatchedRACProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider**](../Model/RACProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRacRetrieve()`

```php
providersRacRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider
```



RACProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this RAC Provider.

try {
    $result = $apiInstance->providersRacRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRacRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this RAC Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider**](../Model/RACProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRacUpdate()`

```php
providersRacUpdate($id, $rac_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider
```



RACProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this RAC Provider.
$rac_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProviderRequest

try {
    $result = $apiInstance->providersRacUpdate($id, $rac_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRacUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this RAC Provider. | |
| **rac_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProviderRequest**](../Model/RACProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RACProvider**](../Model/RACProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRacUsedByList()`

```php
providersRacUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this RAC Provider.

try {
    $result = $apiInstance->providersRacUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRacUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this RAC Provider. | |

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

## `providersRadiusCreate()`

```php
providersRadiusCreate($radius_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider
```



RadiusProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$radius_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderRequest

try {
    $result = $apiInstance->providersRadiusCreate($radius_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRadiusCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **radius_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderRequest**](../Model/RadiusProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider**](../Model/RadiusProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRadiusDestroy()`

```php
providersRadiusDestroy($id)
```



RadiusProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Radius Provider.

try {
    $apiInstance->providersRadiusDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRadiusDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Radius Provider. | |

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

## `providersRadiusList()`

```php
providersRadiusList($application__isnull, $authorization_flow__slug__iexact, $client_networks__iexact, $name__iexact, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRadiusProviderList
```



RadiusProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application__isnull = True; // bool
$authorization_flow__slug__iexact = 'authorization_flow__slug__iexact_example'; // string
$client_networks__iexact = 'client_networks__iexact_example'; // string
$name__iexact = 'name__iexact_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersRadiusList($application__isnull, $authorization_flow__slug__iexact, $client_networks__iexact, $name__iexact, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRadiusList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application__isnull** | **bool**|  | [optional] |
| **authorization_flow__slug__iexact** | **string**|  | [optional] |
| **client_networks__iexact** | **string**|  | [optional] |
| **name__iexact** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRadiusProviderList**](../Model/PaginatedRadiusProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRadiusPartialUpdate()`

```php
providersRadiusPartialUpdate($id, $patched_radius_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider
```



RadiusProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Radius Provider.
$patched_radius_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRadiusProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRadiusProviderRequest

try {
    $result = $apiInstance->providersRadiusPartialUpdate($id, $patched_radius_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRadiusPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Radius Provider. | |
| **patched_radius_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRadiusProviderRequest**](../Model/PatchedRadiusProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider**](../Model/RadiusProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRadiusRetrieve()`

```php
providersRadiusRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider
```



RadiusProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Radius Provider.

try {
    $result = $apiInstance->providersRadiusRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRadiusRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Radius Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider**](../Model/RadiusProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRadiusUpdate()`

```php
providersRadiusUpdate($id, $radius_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider
```



RadiusProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Radius Provider.
$radius_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderRequest

try {
    $result = $apiInstance->providersRadiusUpdate($id, $radius_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRadiusUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Radius Provider. | |
| **radius_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProviderRequest**](../Model/RadiusProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusProvider**](../Model/RadiusProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersRadiusUsedByList()`

```php
providersRadiusUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Radius Provider.

try {
    $result = $apiInstance->providersRadiusUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersRadiusUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Radius Provider. | |

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

## `providersSamlCreate()`

```php
providersSamlCreate($saml_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider
```



SAMLProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$saml_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProviderRequest

try {
    $result = $apiInstance->providersSamlCreate($saml_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **saml_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProviderRequest**](../Model/SAMLProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider**](../Model/SAMLProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlDestroy()`

```php
providersSamlDestroy($id)
```



SAMLProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SAML Provider.

try {
    $apiInstance->providersSamlDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SAML Provider. | |

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

## `providersSamlImportMetadataCreate()`

```php
providersSamlImportMetadataCreate($name, $authorization_flow, $invalidation_flow, $file): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider
```



Create provider from SAML Metadata

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$authorization_flow = 'authorization_flow_example'; // string
$invalidation_flow = 'invalidation_flow_example'; // string
$file = '/path/to/file.txt'; // \SplFileObject

try {
    $result = $apiInstance->providersSamlImportMetadataCreate($name, $authorization_flow, $invalidation_flow, $file);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlImportMetadataCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | |
| **authorization_flow** | **string**|  | |
| **invalidation_flow** | **string**|  | |
| **file** | **\SplFileObject****\SplFileObject**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider**](../Model/SAMLProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `multipart/form-data`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlList()`

```php
providersSamlList($acs_url, $assertion_valid_not_before, $assertion_valid_not_on_or_after, $audience, $authentication_flow, $authn_context_class_ref_mapping, $authorization_flow, $backchannel_application, $default_name_id_policy, $default_relay_state, $digest_algorithm, $encryption_kp, $invalidation_flow, $is_backchannel, $issuer, $logout_method, $name, $name_id_mapping, $ordering, $page, $page_size, $property_mappings, $search, $session_valid_not_on_or_after, $sign_assertion, $sign_logout_request, $sign_response, $signature_algorithm, $signing_kp, $sls_binding, $sls_url, $sp_binding, $verification_kp): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSAMLProviderList
```



SAMLProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$acs_url = 'acs_url_example'; // string
$assertion_valid_not_before = 'assertion_valid_not_before_example'; // string
$assertion_valid_not_on_or_after = 'assertion_valid_not_on_or_after_example'; // string
$audience = 'audience_example'; // string
$authentication_flow = 'authentication_flow_example'; // string
$authn_context_class_ref_mapping = 'authn_context_class_ref_mapping_example'; // string
$authorization_flow = 'authorization_flow_example'; // string
$backchannel_application = 'backchannel_application_example'; // string
$default_name_id_policy = 'default_name_id_policy_example'; // string
$default_relay_state = 'default_relay_state_example'; // string
$digest_algorithm = 'digest_algorithm_example'; // string
$encryption_kp = 'encryption_kp_example'; // string
$invalidation_flow = 'invalidation_flow_example'; // string
$is_backchannel = True; // bool
$issuer = 'issuer_example'; // string
$logout_method = 'logout_method_example'; // string | Method to use for logout. Front-channel iframe loads all logout URLs simultaneously in hidden iframes. Front-channel native uses your active browser tab to send post requests and redirect to providers. Back-channel sends logout requests directly from the server without user interaction (requires POST SLS binding).
$name = 'name_example'; // string
$name_id_mapping = 'name_id_mapping_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$property_mappings = array('property_mappings_example'); // string[]
$search = 'search_example'; // string | A search term.
$session_valid_not_on_or_after = 'session_valid_not_on_or_after_example'; // string
$sign_assertion = True; // bool
$sign_logout_request = True; // bool
$sign_response = True; // bool
$signature_algorithm = 'signature_algorithm_example'; // string
$signing_kp = 'signing_kp_example'; // string
$sls_binding = 'sls_binding_example'; // string | This determines how authentik sends the logout response back to the Service Provider.
$sls_url = 'sls_url_example'; // string
$sp_binding = 'sp_binding_example'; // string | This determines how authentik sends the response back to the Service Provider.
$verification_kp = 'verification_kp_example'; // string

try {
    $result = $apiInstance->providersSamlList($acs_url, $assertion_valid_not_before, $assertion_valid_not_on_or_after, $audience, $authentication_flow, $authn_context_class_ref_mapping, $authorization_flow, $backchannel_application, $default_name_id_policy, $default_relay_state, $digest_algorithm, $encryption_kp, $invalidation_flow, $is_backchannel, $issuer, $logout_method, $name, $name_id_mapping, $ordering, $page, $page_size, $property_mappings, $search, $session_valid_not_on_or_after, $sign_assertion, $sign_logout_request, $sign_response, $signature_algorithm, $signing_kp, $sls_binding, $sls_url, $sp_binding, $verification_kp);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **acs_url** | **string**|  | [optional] |
| **assertion_valid_not_before** | **string**|  | [optional] |
| **assertion_valid_not_on_or_after** | **string**|  | [optional] |
| **audience** | **string**|  | [optional] |
| **authentication_flow** | **string**|  | [optional] |
| **authn_context_class_ref_mapping** | **string**|  | [optional] |
| **authorization_flow** | **string**|  | [optional] |
| **backchannel_application** | **string**|  | [optional] |
| **default_name_id_policy** | **string**|  | [optional] |
| **default_relay_state** | **string**|  | [optional] |
| **digest_algorithm** | **string**|  | [optional] |
| **encryption_kp** | **string**|  | [optional] |
| **invalidation_flow** | **string**|  | [optional] |
| **is_backchannel** | **bool**|  | [optional] |
| **issuer** | **string**|  | [optional] |
| **logout_method** | **string**| Method to use for logout. Front-channel iframe loads all logout URLs simultaneously in hidden iframes. Front-channel native uses your active browser tab to send post requests and redirect to providers. Back-channel sends logout requests directly from the server without user interaction (requires POST SLS binding). | [optional] |
| **name** | **string**|  | [optional] |
| **name_id_mapping** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **property_mappings** | [**string[]**](../Model/string.md)|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **session_valid_not_on_or_after** | **string**|  | [optional] |
| **sign_assertion** | **bool**|  | [optional] |
| **sign_logout_request** | **bool**|  | [optional] |
| **sign_response** | **bool**|  | [optional] |
| **signature_algorithm** | **string**|  | [optional] |
| **signing_kp** | **string**|  | [optional] |
| **sls_binding** | **string**| This determines how authentik sends the logout response back to the Service Provider. | [optional] |
| **sls_url** | **string**|  | [optional] |
| **sp_binding** | **string**| This determines how authentik sends the response back to the Service Provider. | [optional] |
| **verification_kp** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSAMLProviderList**](../Model/PaginatedSAMLProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlMetadataRetrieve()`

```php
providersSamlMetadataRetrieve($id, $download, $force_binding): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLMetadata
```



Return metadata as XML string

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SAML Provider.
$download = True; // bool
$force_binding = 'force_binding_example'; // string | Optionally force the metadata to only include one binding.

try {
    $result = $apiInstance->providersSamlMetadataRetrieve($id, $download, $force_binding);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlMetadataRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SAML Provider. | |
| **download** | **bool**|  | [optional] |
| **force_binding** | **string**| Optionally force the metadata to only include one binding. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLMetadata**](../Model/SAMLMetadata.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`, `application/xml`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlPartialUpdate()`

```php
providersSamlPartialUpdate($id, $patched_saml_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider
```



SAMLProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SAML Provider.
$patched_saml_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLProviderRequest

try {
    $result = $apiInstance->providersSamlPartialUpdate($id, $patched_saml_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SAML Provider. | |
| **patched_saml_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSAMLProviderRequest**](../Model/PatchedSAMLProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider**](../Model/SAMLProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlPreviewUserRetrieve()`

```php
providersSamlPreviewUserRetrieve($id, $for_user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingPreview
```



Preview user data for provider

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SAML Provider.
$for_user = 56; // int

try {
    $result = $apiInstance->providersSamlPreviewUserRetrieve($id, $for_user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlPreviewUserRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SAML Provider. | |
| **for_user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingPreview**](../Model/PropertyMappingPreview.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlRetrieve()`

```php
providersSamlRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider
```



SAMLProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SAML Provider.

try {
    $result = $apiInstance->providersSamlRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SAML Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider**](../Model/SAMLProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlUpdate()`

```php
providersSamlUpdate($id, $saml_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider
```



SAMLProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SAML Provider.
$saml_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProviderRequest

try {
    $result = $apiInstance->providersSamlUpdate($id, $saml_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SAML Provider. | |
| **saml_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProviderRequest**](../Model/SAMLProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLProvider**](../Model/SAMLProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSamlUsedByList()`

```php
providersSamlUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SAML Provider.

try {
    $result = $apiInstance->providersSamlUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSamlUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SAML Provider. | |

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

## `providersScimCreate()`

```php
providersScimCreate($scim_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider
```



SCIMProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scim_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderRequest

try {
    $result = $apiInstance->providersScimCreate($scim_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **scim_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderRequest**](../Model/SCIMProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider**](../Model/SCIMProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimDestroy()`

```php
providersScimDestroy($id)
```



SCIMProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SCIM Provider.

try {
    $apiInstance->providersScimDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SCIM Provider. | |

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

## `providersScimGroupsCreate()`

```php
providersScimGroupsCreate($scim_provider_group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderGroup
```



SCIMProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scim_provider_group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderGroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderGroupRequest

try {
    $result = $apiInstance->providersScimGroupsCreate($scim_provider_group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimGroupsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **scim_provider_group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderGroupRequest**](../Model/SCIMProviderGroupRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderGroup**](../Model/SCIMProviderGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimGroupsDestroy()`

```php
providersScimGroupsDestroy($id)
```



SCIMProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this scim provider group.

try {
    $apiInstance->providersScimGroupsDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimGroupsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this scim provider group. | |

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

## `providersScimGroupsList()`

```php
providersScimGroupsList($group__group_uuid, $group__name, $ordering, $page, $page_size, $provider__id, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMProviderGroupList
```



SCIMProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group__group_uuid = 'group__group_uuid_example'; // string
$group__name = 'group__name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider__id = 56; // int
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersScimGroupsList($group__group_uuid, $group__name, $ordering, $page, $page_size, $provider__id, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimGroupsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group__group_uuid** | **string**|  | [optional] |
| **group__name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider__id** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMProviderGroupList**](../Model/PaginatedSCIMProviderGroupList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimGroupsRetrieve()`

```php
providersScimGroupsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderGroup
```



SCIMProviderGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this scim provider group.

try {
    $result = $apiInstance->providersScimGroupsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimGroupsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this scim provider group. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderGroup**](../Model/SCIMProviderGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimGroupsUsedByList()`

```php
providersScimGroupsUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this scim provider group.

try {
    $result = $apiInstance->providersScimGroupsUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimGroupsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this scim provider group. | |

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

## `providersScimList()`

```php
providersScimList($exclude_users_service_account, $group_filters, $name, $ordering, $page, $page_size, $search, $url): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMProviderList
```



SCIMProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$exclude_users_service_account = True; // bool
$group_filters = array('group_filters_example'); // string[]
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$url = 'url_example'; // string

try {
    $result = $apiInstance->providersScimList($exclude_users_service_account, $group_filters, $name, $ordering, $page, $page_size, $search, $url);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **exclude_users_service_account** | **bool**|  | [optional] |
| **group_filters** | [**string[]**](../Model/string.md)|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **url** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMProviderList**](../Model/PaginatedSCIMProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimPartialUpdate()`

```php
providersScimPartialUpdate($id, $patched_scim_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider
```



SCIMProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SCIM Provider.
$patched_scim_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMProviderRequest

try {
    $result = $apiInstance->providersScimPartialUpdate($id, $patched_scim_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SCIM Provider. | |
| **patched_scim_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSCIMProviderRequest**](../Model/PatchedSCIMProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider**](../Model/SCIMProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimRetrieve()`

```php
providersScimRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider
```



SCIMProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SCIM Provider.

try {
    $result = $apiInstance->providersScimRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SCIM Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider**](../Model/SCIMProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimSyncObjectCreate()`

```php
providersScimSyncObjectCreate($id, $sync_object_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectResult
```



Sync/Re-sync a single user/group object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SCIM Provider.
$sync_object_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest

try {
    $result = $apiInstance->providersScimSyncObjectCreate($id, $sync_object_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimSyncObjectCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SCIM Provider. | |
| **sync_object_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectRequest**](../Model/SyncObjectRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncObjectResult**](../Model/SyncObjectResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimSyncStatusRetrieve()`

```php
providersScimSyncStatusRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncStatus
```



Get provider's sync status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SCIM Provider.

try {
    $result = $apiInstance->providersScimSyncStatusRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimSyncStatusRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SCIM Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SyncStatus**](../Model/SyncStatus.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimUpdate()`

```php
providersScimUpdate($id, $scim_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider
```



SCIMProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SCIM Provider.
$scim_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderRequest

try {
    $result = $apiInstance->providersScimUpdate($id, $scim_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SCIM Provider. | |
| **scim_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderRequest**](../Model/SCIMProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProvider**](../Model/SCIMProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimUsedByList()`

```php
providersScimUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SCIM Provider.

try {
    $result = $apiInstance->providersScimUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SCIM Provider. | |

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

## `providersScimUsersCreate()`

```php
providersScimUsersCreate($scim_provider_user_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderUser
```



SCIMProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scim_provider_user_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderUserRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderUserRequest

try {
    $result = $apiInstance->providersScimUsersCreate($scim_provider_user_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimUsersCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **scim_provider_user_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderUserRequest**](../Model/SCIMProviderUserRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderUser**](../Model/SCIMProviderUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimUsersDestroy()`

```php
providersScimUsersDestroy($id)
```



SCIMProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this scim provider user.

try {
    $apiInstance->providersScimUsersDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimUsersDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this scim provider user. | |

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

## `providersScimUsersList()`

```php
providersScimUsersList($ordering, $page, $page_size, $provider__id, $search, $user__id, $user__username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMProviderUserList
```



SCIMProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider__id = 56; // int
$search = 'search_example'; // string | A search term.
$user__id = 56; // int
$user__username = 'user__username_example'; // string

try {
    $result = $apiInstance->providersScimUsersList($ordering, $page, $page_size, $provider__id, $search, $user__id, $user__username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimUsersList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider__id** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **user__id** | **int**|  | [optional] |
| **user__username** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSCIMProviderUserList**](../Model/PaginatedSCIMProviderUserList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimUsersRetrieve()`

```php
providersScimUsersRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderUser
```



SCIMProviderUser Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this scim provider user.

try {
    $result = $apiInstance->providersScimUsersRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimUsersRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this scim provider user. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SCIMProviderUser**](../Model/SCIMProviderUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersScimUsersUsedByList()`

```php
providersScimUsersUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this scim provider user.

try {
    $result = $apiInstance->providersScimUsersUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersScimUsersUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this scim provider user. | |

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

## `providersSsfCreate()`

```php
providersSsfCreate($ssf_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider
```



SSFProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ssf_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProviderRequest

try {
    $result = $apiInstance->providersSsfCreate($ssf_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSsfCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ssf_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProviderRequest**](../Model/SSFProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider**](../Model/SSFProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSsfDestroy()`

```php
providersSsfDestroy($id)
```



SSFProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Shared Signals Framework Provider.

try {
    $apiInstance->providersSsfDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSsfDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Shared Signals Framework Provider. | |

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

## `providersSsfList()`

```php
providersSsfList($application__isnull, $name__iexact, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSSFProviderList
```



SSFProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application__isnull = True; // bool
$name__iexact = 'name__iexact_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->providersSsfList($application__isnull, $name__iexact, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSsfList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application__isnull** | **bool**|  | [optional] |
| **name__iexact** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSSFProviderList**](../Model/PaginatedSSFProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSsfPartialUpdate()`

```php
providersSsfPartialUpdate($id, $patched_ssf_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider
```



SSFProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Shared Signals Framework Provider.
$patched_ssf_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSSFProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSSFProviderRequest

try {
    $result = $apiInstance->providersSsfPartialUpdate($id, $patched_ssf_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSsfPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Shared Signals Framework Provider. | |
| **patched_ssf_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSSFProviderRequest**](../Model/PatchedSSFProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider**](../Model/SSFProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSsfRetrieve()`

```php
providersSsfRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider
```



SSFProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Shared Signals Framework Provider.

try {
    $result = $apiInstance->providersSsfRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSsfRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Shared Signals Framework Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider**](../Model/SSFProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSsfUpdate()`

```php
providersSsfUpdate($id, $ssf_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider
```



SSFProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Shared Signals Framework Provider.
$ssf_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProviderRequest

try {
    $result = $apiInstance->providersSsfUpdate($id, $ssf_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSsfUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Shared Signals Framework Provider. | |
| **ssf_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProviderRequest**](../Model/SSFProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFProvider**](../Model/SSFProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersSsfUsedByList()`

```php
providersSsfUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Shared Signals Framework Provider.

try {
    $result = $apiInstance->providersSsfUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersSsfUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Shared Signals Framework Provider. | |

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

## `providersWsfedCreate()`

```php
providersWsfedCreate($ws_federation_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider
```



WSFederationProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ws_federation_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProviderRequest

try {
    $result = $apiInstance->providersWsfedCreate($ws_federation_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ws_federation_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProviderRequest**](../Model/WSFederationProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider**](../Model/WSFederationProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersWsfedDestroy()`

```php
providersWsfedDestroy($id)
```



WSFederationProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WS-Federation Provider.

try {
    $apiInstance->providersWsfedDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WS-Federation Provider. | |

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

## `providersWsfedList()`

```php
providersWsfedList($acs_url, $assertion_valid_not_before, $assertion_valid_not_on_or_after, $audience, $authentication_flow, $authn_context_class_ref_mapping, $authorization_flow, $backchannel_application, $default_name_id_policy, $default_relay_state, $digest_algorithm, $encryption_kp, $invalidation_flow, $is_backchannel, $issuer, $logout_method, $name, $name_id_mapping, $ordering, $page, $page_size, $property_mappings, $search, $session_valid_not_on_or_after, $sign_assertion, $sign_logout_request, $sign_response, $signature_algorithm, $signing_kp, $sls_binding, $sls_url, $sp_binding, $verification_kp): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWSFederationProviderList
```



WSFederationProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$acs_url = 'acs_url_example'; // string
$assertion_valid_not_before = 'assertion_valid_not_before_example'; // string
$assertion_valid_not_on_or_after = 'assertion_valid_not_on_or_after_example'; // string
$audience = 'audience_example'; // string
$authentication_flow = 'authentication_flow_example'; // string
$authn_context_class_ref_mapping = 'authn_context_class_ref_mapping_example'; // string
$authorization_flow = 'authorization_flow_example'; // string
$backchannel_application = 'backchannel_application_example'; // string
$default_name_id_policy = 'default_name_id_policy_example'; // string
$default_relay_state = 'default_relay_state_example'; // string
$digest_algorithm = 'digest_algorithm_example'; // string
$encryption_kp = 'encryption_kp_example'; // string
$invalidation_flow = 'invalidation_flow_example'; // string
$is_backchannel = True; // bool
$issuer = 'issuer_example'; // string
$logout_method = 'logout_method_example'; // string | Method to use for logout. Front-channel iframe loads all logout URLs simultaneously in hidden iframes. Front-channel native uses your active browser tab to send post requests and redirect to providers. Back-channel sends logout requests directly from the server without user interaction (requires POST SLS binding).
$name = 'name_example'; // string
$name_id_mapping = 'name_id_mapping_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$property_mappings = array('property_mappings_example'); // string[]
$search = 'search_example'; // string | A search term.
$session_valid_not_on_or_after = 'session_valid_not_on_or_after_example'; // string
$sign_assertion = True; // bool
$sign_logout_request = True; // bool
$sign_response = True; // bool
$signature_algorithm = 'signature_algorithm_example'; // string
$signing_kp = 'signing_kp_example'; // string
$sls_binding = 'sls_binding_example'; // string | This determines how authentik sends the logout response back to the Service Provider.
$sls_url = 'sls_url_example'; // string
$sp_binding = 'sp_binding_example'; // string | This determines how authentik sends the response back to the Service Provider.
$verification_kp = 'verification_kp_example'; // string

try {
    $result = $apiInstance->providersWsfedList($acs_url, $assertion_valid_not_before, $assertion_valid_not_on_or_after, $audience, $authentication_flow, $authn_context_class_ref_mapping, $authorization_flow, $backchannel_application, $default_name_id_policy, $default_relay_state, $digest_algorithm, $encryption_kp, $invalidation_flow, $is_backchannel, $issuer, $logout_method, $name, $name_id_mapping, $ordering, $page, $page_size, $property_mappings, $search, $session_valid_not_on_or_after, $sign_assertion, $sign_logout_request, $sign_response, $signature_algorithm, $signing_kp, $sls_binding, $sls_url, $sp_binding, $verification_kp);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **acs_url** | **string**|  | [optional] |
| **assertion_valid_not_before** | **string**|  | [optional] |
| **assertion_valid_not_on_or_after** | **string**|  | [optional] |
| **audience** | **string**|  | [optional] |
| **authentication_flow** | **string**|  | [optional] |
| **authn_context_class_ref_mapping** | **string**|  | [optional] |
| **authorization_flow** | **string**|  | [optional] |
| **backchannel_application** | **string**|  | [optional] |
| **default_name_id_policy** | **string**|  | [optional] |
| **default_relay_state** | **string**|  | [optional] |
| **digest_algorithm** | **string**|  | [optional] |
| **encryption_kp** | **string**|  | [optional] |
| **invalidation_flow** | **string**|  | [optional] |
| **is_backchannel** | **bool**|  | [optional] |
| **issuer** | **string**|  | [optional] |
| **logout_method** | **string**| Method to use for logout. Front-channel iframe loads all logout URLs simultaneously in hidden iframes. Front-channel native uses your active browser tab to send post requests and redirect to providers. Back-channel sends logout requests directly from the server without user interaction (requires POST SLS binding). | [optional] |
| **name** | **string**|  | [optional] |
| **name_id_mapping** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **property_mappings** | [**string[]**](../Model/string.md)|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **session_valid_not_on_or_after** | **string**|  | [optional] |
| **sign_assertion** | **bool**|  | [optional] |
| **sign_logout_request** | **bool**|  | [optional] |
| **sign_response** | **bool**|  | [optional] |
| **signature_algorithm** | **string**|  | [optional] |
| **signing_kp** | **string**|  | [optional] |
| **sls_binding** | **string**| This determines how authentik sends the logout response back to the Service Provider. | [optional] |
| **sls_url** | **string**|  | [optional] |
| **sp_binding** | **string**| This determines how authentik sends the response back to the Service Provider. | [optional] |
| **verification_kp** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWSFederationProviderList**](../Model/PaginatedWSFederationProviderList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersWsfedMetadataRetrieve()`

```php
providersWsfedMetadataRetrieve($id, $download, $force_binding): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLMetadata
```



Return metadata as XML string

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WS-Federation Provider.
$download = True; // bool
$force_binding = 'force_binding_example'; // string | Optionally force the metadata to only include one binding.

try {
    $result = $apiInstance->providersWsfedMetadataRetrieve($id, $download, $force_binding);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedMetadataRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WS-Federation Provider. | |
| **download** | **bool**|  | [optional] |
| **force_binding** | **string**| Optionally force the metadata to only include one binding. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SAMLMetadata**](../Model/SAMLMetadata.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`, `application/xml`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersWsfedPartialUpdate()`

```php
providersWsfedPartialUpdate($id, $patched_ws_federation_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider
```



WSFederationProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WS-Federation Provider.
$patched_ws_federation_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWSFederationProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWSFederationProviderRequest

try {
    $result = $apiInstance->providersWsfedPartialUpdate($id, $patched_ws_federation_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WS-Federation Provider. | |
| **patched_ws_federation_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWSFederationProviderRequest**](../Model/PatchedWSFederationProviderRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider**](../Model/WSFederationProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersWsfedPreviewUserRetrieve()`

```php
providersWsfedPreviewUserRetrieve($id, $for_user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingPreview
```



Preview user data for provider

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WS-Federation Provider.
$for_user = 56; // int

try {
    $result = $apiInstance->providersWsfedPreviewUserRetrieve($id, $for_user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedPreviewUserRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WS-Federation Provider. | |
| **for_user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PropertyMappingPreview**](../Model/PropertyMappingPreview.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersWsfedRetrieve()`

```php
providersWsfedRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider
```



WSFederationProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WS-Federation Provider.

try {
    $result = $apiInstance->providersWsfedRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WS-Federation Provider. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider**](../Model/WSFederationProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersWsfedUpdate()`

```php
providersWsfedUpdate($id, $ws_federation_provider_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider
```



WSFederationProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WS-Federation Provider.
$ws_federation_provider_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProviderRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProviderRequest

try {
    $result = $apiInstance->providersWsfedUpdate($id, $ws_federation_provider_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WS-Federation Provider. | |
| **ws_federation_provider_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProviderRequest**](../Model/WSFederationProviderRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WSFederationProvider**](../Model/WSFederationProvider.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `providersWsfedUsedByList()`

```php
providersWsfedUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ProvidersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WS-Federation Provider.

try {
    $result = $apiInstance->providersWsfedUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProvidersApi->providersWsfedUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WS-Federation Provider. | |

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
