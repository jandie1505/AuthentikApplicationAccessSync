# OCA\AuthentikAccessSync\Vendor\Authentik\CoreApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**coreApplicationEntitlementsCreate()**](CoreApi.md#coreApplicationEntitlementsCreate) | **POST** /core/application_entitlements/ |  |
| [**coreApplicationEntitlementsDestroy()**](CoreApi.md#coreApplicationEntitlementsDestroy) | **DELETE** /core/application_entitlements/{pbm_uuid}/ |  |
| [**coreApplicationEntitlementsList()**](CoreApi.md#coreApplicationEntitlementsList) | **GET** /core/application_entitlements/ |  |
| [**coreApplicationEntitlementsPartialUpdate()**](CoreApi.md#coreApplicationEntitlementsPartialUpdate) | **PATCH** /core/application_entitlements/{pbm_uuid}/ |  |
| [**coreApplicationEntitlementsRetrieve()**](CoreApi.md#coreApplicationEntitlementsRetrieve) | **GET** /core/application_entitlements/{pbm_uuid}/ |  |
| [**coreApplicationEntitlementsUpdate()**](CoreApi.md#coreApplicationEntitlementsUpdate) | **PUT** /core/application_entitlements/{pbm_uuid}/ |  |
| [**coreApplicationEntitlementsUsedByList()**](CoreApi.md#coreApplicationEntitlementsUsedByList) | **GET** /core/application_entitlements/{pbm_uuid}/used_by/ |  |
| [**coreApplicationsCheckAccessRetrieve()**](CoreApi.md#coreApplicationsCheckAccessRetrieve) | **GET** /core/applications/{slug}/check_access/ |  |
| [**coreApplicationsCreate()**](CoreApi.md#coreApplicationsCreate) | **POST** /core/applications/ |  |
| [**coreApplicationsDestroy()**](CoreApi.md#coreApplicationsDestroy) | **DELETE** /core/applications/{slug}/ |  |
| [**coreApplicationsList()**](CoreApi.md#coreApplicationsList) | **GET** /core/applications/ |  |
| [**coreApplicationsPartialUpdate()**](CoreApi.md#coreApplicationsPartialUpdate) | **PATCH** /core/applications/{slug}/ |  |
| [**coreApplicationsRetrieve()**](CoreApi.md#coreApplicationsRetrieve) | **GET** /core/applications/{slug}/ |  |
| [**coreApplicationsUpdate()**](CoreApi.md#coreApplicationsUpdate) | **PUT** /core/applications/{slug}/ |  |
| [**coreApplicationsUsedByList()**](CoreApi.md#coreApplicationsUsedByList) | **GET** /core/applications/{slug}/used_by/ |  |
| [**coreAuthenticatedSessionsBulkDeleteDestroy()**](CoreApi.md#coreAuthenticatedSessionsBulkDeleteDestroy) | **DELETE** /core/authenticated_sessions/bulk_delete/ |  |
| [**coreAuthenticatedSessionsDestroy()**](CoreApi.md#coreAuthenticatedSessionsDestroy) | **DELETE** /core/authenticated_sessions/{uuid}/ |  |
| [**coreAuthenticatedSessionsList()**](CoreApi.md#coreAuthenticatedSessionsList) | **GET** /core/authenticated_sessions/ |  |
| [**coreAuthenticatedSessionsRetrieve()**](CoreApi.md#coreAuthenticatedSessionsRetrieve) | **GET** /core/authenticated_sessions/{uuid}/ |  |
| [**coreAuthenticatedSessionsUsedByList()**](CoreApi.md#coreAuthenticatedSessionsUsedByList) | **GET** /core/authenticated_sessions/{uuid}/used_by/ |  |
| [**coreBrandsCreate()**](CoreApi.md#coreBrandsCreate) | **POST** /core/brands/ |  |
| [**coreBrandsCurrentRetrieve()**](CoreApi.md#coreBrandsCurrentRetrieve) | **GET** /core/brands/current/ |  |
| [**coreBrandsDestroy()**](CoreApi.md#coreBrandsDestroy) | **DELETE** /core/brands/{brand_uuid}/ |  |
| [**coreBrandsList()**](CoreApi.md#coreBrandsList) | **GET** /core/brands/ |  |
| [**coreBrandsPartialUpdate()**](CoreApi.md#coreBrandsPartialUpdate) | **PATCH** /core/brands/{brand_uuid}/ |  |
| [**coreBrandsRetrieve()**](CoreApi.md#coreBrandsRetrieve) | **GET** /core/brands/{brand_uuid}/ |  |
| [**coreBrandsUpdate()**](CoreApi.md#coreBrandsUpdate) | **PUT** /core/brands/{brand_uuid}/ |  |
| [**coreBrandsUsedByList()**](CoreApi.md#coreBrandsUsedByList) | **GET** /core/brands/{brand_uuid}/used_by/ |  |
| [**coreGroupsAddUserCreate()**](CoreApi.md#coreGroupsAddUserCreate) | **POST** /core/groups/{group_uuid}/add_user/ |  |
| [**coreGroupsCreate()**](CoreApi.md#coreGroupsCreate) | **POST** /core/groups/ |  |
| [**coreGroupsDestroy()**](CoreApi.md#coreGroupsDestroy) | **DELETE** /core/groups/{group_uuid}/ |  |
| [**coreGroupsList()**](CoreApi.md#coreGroupsList) | **GET** /core/groups/ |  |
| [**coreGroupsPartialUpdate()**](CoreApi.md#coreGroupsPartialUpdate) | **PATCH** /core/groups/{group_uuid}/ |  |
| [**coreGroupsRemoveUserCreate()**](CoreApi.md#coreGroupsRemoveUserCreate) | **POST** /core/groups/{group_uuid}/remove_user/ |  |
| [**coreGroupsRetrieve()**](CoreApi.md#coreGroupsRetrieve) | **GET** /core/groups/{group_uuid}/ |  |
| [**coreGroupsUpdate()**](CoreApi.md#coreGroupsUpdate) | **PUT** /core/groups/{group_uuid}/ |  |
| [**coreGroupsUsedByList()**](CoreApi.md#coreGroupsUsedByList) | **GET** /core/groups/{group_uuid}/used_by/ |  |
| [**coreTokensCreate()**](CoreApi.md#coreTokensCreate) | **POST** /core/tokens/ |  |
| [**coreTokensDestroy()**](CoreApi.md#coreTokensDestroy) | **DELETE** /core/tokens/{identifier}/ |  |
| [**coreTokensList()**](CoreApi.md#coreTokensList) | **GET** /core/tokens/ |  |
| [**coreTokensPartialUpdate()**](CoreApi.md#coreTokensPartialUpdate) | **PATCH** /core/tokens/{identifier}/ |  |
| [**coreTokensRetrieve()**](CoreApi.md#coreTokensRetrieve) | **GET** /core/tokens/{identifier}/ |  |
| [**coreTokensSetKeyCreate()**](CoreApi.md#coreTokensSetKeyCreate) | **POST** /core/tokens/{identifier}/set_key/ |  |
| [**coreTokensUpdate()**](CoreApi.md#coreTokensUpdate) | **PUT** /core/tokens/{identifier}/ |  |
| [**coreTokensUsedByList()**](CoreApi.md#coreTokensUsedByList) | **GET** /core/tokens/{identifier}/used_by/ |  |
| [**coreTokensViewKeyRetrieve()**](CoreApi.md#coreTokensViewKeyRetrieve) | **GET** /core/tokens/{identifier}/view_key/ |  |
| [**coreTransactionalApplicationsUpdate()**](CoreApi.md#coreTransactionalApplicationsUpdate) | **PUT** /core/transactional/applications/ |  |
| [**coreUserConsentDestroy()**](CoreApi.md#coreUserConsentDestroy) | **DELETE** /core/user_consent/{id}/ |  |
| [**coreUserConsentList()**](CoreApi.md#coreUserConsentList) | **GET** /core/user_consent/ |  |
| [**coreUserConsentRetrieve()**](CoreApi.md#coreUserConsentRetrieve) | **GET** /core/user_consent/{id}/ |  |
| [**coreUserConsentUsedByList()**](CoreApi.md#coreUserConsentUsedByList) | **GET** /core/user_consent/{id}/used_by/ |  |
| [**coreUsersCreate()**](CoreApi.md#coreUsersCreate) | **POST** /core/users/ |  |
| [**coreUsersDestroy()**](CoreApi.md#coreUsersDestroy) | **DELETE** /core/users/{id}/ |  |
| [**coreUsersExportCreate()**](CoreApi.md#coreUsersExportCreate) | **POST** /core/users/export/ |  |
| [**coreUsersImpersonateCreate()**](CoreApi.md#coreUsersImpersonateCreate) | **POST** /core/users/{id}/impersonate/ |  |
| [**coreUsersImpersonateEndRetrieve()**](CoreApi.md#coreUsersImpersonateEndRetrieve) | **GET** /core/users/impersonate_end/ |  |
| [**coreUsersList()**](CoreApi.md#coreUsersList) | **GET** /core/users/ |  |
| [**coreUsersMeRetrieve()**](CoreApi.md#coreUsersMeRetrieve) | **GET** /core/users/me/ |  |
| [**coreUsersPartialUpdate()**](CoreApi.md#coreUsersPartialUpdate) | **PATCH** /core/users/{id}/ |  |
| [**coreUsersPathsRetrieve()**](CoreApi.md#coreUsersPathsRetrieve) | **GET** /core/users/paths/ |  |
| [**coreUsersRecoveryCreate()**](CoreApi.md#coreUsersRecoveryCreate) | **POST** /core/users/{id}/recovery/ |  |
| [**coreUsersRecoveryEmailCreate()**](CoreApi.md#coreUsersRecoveryEmailCreate) | **POST** /core/users/{id}/recovery_email/ |  |
| [**coreUsersRetrieve()**](CoreApi.md#coreUsersRetrieve) | **GET** /core/users/{id}/ |  |
| [**coreUsersServiceAccountCreate()**](CoreApi.md#coreUsersServiceAccountCreate) | **POST** /core/users/service_account/ |  |
| [**coreUsersSetPasswordCreate()**](CoreApi.md#coreUsersSetPasswordCreate) | **POST** /core/users/{id}/set_password/ |  |
| [**coreUsersUpdate()**](CoreApi.md#coreUsersUpdate) | **PUT** /core/users/{id}/ |  |
| [**coreUsersUsedByList()**](CoreApi.md#coreUsersUsedByList) | **GET** /core/users/{id}/used_by/ |  |


## `coreApplicationEntitlementsCreate()`

```php
coreApplicationEntitlementsCreate($application_entitlement_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement
```



ApplicationEntitlement Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application_entitlement_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlementRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlementRequest

try {
    $result = $apiInstance->coreApplicationEntitlementsCreate($application_entitlement_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationEntitlementsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application_entitlement_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlementRequest**](../Model/ApplicationEntitlementRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement**](../Model/ApplicationEntitlement.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationEntitlementsDestroy()`

```php
coreApplicationEntitlementsDestroy($pbm_uuid)
```



ApplicationEntitlement Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Application Entitlement.

try {
    $apiInstance->coreApplicationEntitlementsDestroy($pbm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationEntitlementsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Application Entitlement. | |

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

## `coreApplicationEntitlementsList()`

```php
coreApplicationEntitlementsList($app, $name, $ordering, $page, $page_size, $pbm_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedApplicationEntitlementList
```



ApplicationEntitlement Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$app = 'app_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$pbm_uuid = 'pbm_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->coreApplicationEntitlementsList($app, $name, $ordering, $page, $page_size, $pbm_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationEntitlementsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **app** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **pbm_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedApplicationEntitlementList**](../Model/PaginatedApplicationEntitlementList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationEntitlementsPartialUpdate()`

```php
coreApplicationEntitlementsPartialUpdate($pbm_uuid, $patched_application_entitlement_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement
```



ApplicationEntitlement Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Application Entitlement.
$patched_application_entitlement_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedApplicationEntitlementRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedApplicationEntitlementRequest

try {
    $result = $apiInstance->coreApplicationEntitlementsPartialUpdate($pbm_uuid, $patched_application_entitlement_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationEntitlementsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Application Entitlement. | |
| **patched_application_entitlement_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedApplicationEntitlementRequest**](../Model/PatchedApplicationEntitlementRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement**](../Model/ApplicationEntitlement.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationEntitlementsRetrieve()`

```php
coreApplicationEntitlementsRetrieve($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement
```



ApplicationEntitlement Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Application Entitlement.

try {
    $result = $apiInstance->coreApplicationEntitlementsRetrieve($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationEntitlementsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Application Entitlement. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement**](../Model/ApplicationEntitlement.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationEntitlementsUpdate()`

```php
coreApplicationEntitlementsUpdate($pbm_uuid, $application_entitlement_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement
```



ApplicationEntitlement Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Application Entitlement.
$application_entitlement_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlementRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlementRequest

try {
    $result = $apiInstance->coreApplicationEntitlementsUpdate($pbm_uuid, $application_entitlement_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationEntitlementsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Application Entitlement. | |
| **application_entitlement_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlementRequest**](../Model/ApplicationEntitlementRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationEntitlement**](../Model/ApplicationEntitlement.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationEntitlementsUsedByList()`

```php
coreApplicationEntitlementsUsedByList($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Application Entitlement.

try {
    $result = $apiInstance->coreApplicationEntitlementsUsedByList($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationEntitlementsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Application Entitlement. | |

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

## `coreApplicationsCheckAccessRetrieve()`

```php
coreApplicationsCheckAccessRetrieve($slug, $for_user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyTestResult
```



Check access to a single application by slug

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string
$for_user = 56; // int

try {
    $result = $apiInstance->coreApplicationsCheckAccessRetrieve($slug, $for_user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsCheckAccessRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |
| **for_user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyTestResult**](../Model/PolicyTestResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationsCreate()`

```php
coreApplicationsCreate($application_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application
```



Application Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationRequest

try {
    $result = $apiInstance->coreApplicationsCreate($application_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationRequest**](../Model/ApplicationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application**](../Model/Application.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationsDestroy()`

```php
coreApplicationsDestroy($slug)
```



Application Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $apiInstance->coreApplicationsDestroy($slug);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

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

## `coreApplicationsList()`

```php
coreApplicationsList($for_user, $group, $meta_description, $meta_launch_url, $meta_publisher, $name, $only_with_launch_url, $ordering, $page, $page_size, $search, $slug, $superuser_full_list): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedApplicationList
```



Custom list method that checks Policy based access instead of guardian

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$for_user = 56; // int
$group = 'group_example'; // string
$meta_description = 'meta_description_example'; // string
$meta_launch_url = 'meta_launch_url_example'; // string
$meta_publisher = 'meta_publisher_example'; // string
$name = 'name_example'; // string
$only_with_launch_url = True; // bool
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$slug = 'slug_example'; // string
$superuser_full_list = True; // bool

try {
    $result = $apiInstance->coreApplicationsList($for_user, $group, $meta_description, $meta_launch_url, $meta_publisher, $name, $only_with_launch_url, $ordering, $page, $page_size, $search, $slug, $superuser_full_list);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **for_user** | **int**|  | [optional] |
| **group** | **string**|  | [optional] |
| **meta_description** | **string**|  | [optional] |
| **meta_launch_url** | **string**|  | [optional] |
| **meta_publisher** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **only_with_launch_url** | **bool**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **slug** | **string**|  | [optional] |
| **superuser_full_list** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedApplicationList**](../Model/PaginatedApplicationList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationsPartialUpdate()`

```php
coreApplicationsPartialUpdate($slug, $patched_application_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application
```



Application Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string
$patched_application_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedApplicationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedApplicationRequest

try {
    $result = $apiInstance->coreApplicationsPartialUpdate($slug, $patched_application_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |
| **patched_application_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedApplicationRequest**](../Model/PatchedApplicationRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application**](../Model/Application.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationsRetrieve()`

```php
coreApplicationsRetrieve($slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application
```



Application Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->coreApplicationsRetrieve($slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application**](../Model/Application.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationsUpdate()`

```php
coreApplicationsUpdate($slug, $application_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application
```



Application Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string
$application_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationRequest

try {
    $result = $apiInstance->coreApplicationsUpdate($slug, $application_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |
| **application_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ApplicationRequest**](../Model/ApplicationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Application**](../Model/Application.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreApplicationsUsedByList()`

```php
coreApplicationsUsedByList($slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->coreApplicationsUsedByList($slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreApplicationsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

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

## `coreAuthenticatedSessionsBulkDeleteDestroy()`

```php
coreAuthenticatedSessionsBulkDeleteDestroy($user_pks): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BulkDeleteSessionResponse
```



Bulk revoke all sessions for multiple users

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user_pks = array(56); // int[] | List of user IDs to revoke all sessions for

try {
    $result = $apiInstance->coreAuthenticatedSessionsBulkDeleteDestroy($user_pks);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreAuthenticatedSessionsBulkDeleteDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user_pks** | [**int[]**](../Model/int.md)| List of user IDs to revoke all sessions for | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BulkDeleteSessionResponse**](../Model/BulkDeleteSessionResponse.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreAuthenticatedSessionsDestroy()`

```php
coreAuthenticatedSessionsDestroy($uuid)
```



AuthenticatedSession Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string

try {
    $apiInstance->coreAuthenticatedSessionsDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreAuthenticatedSessionsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**|  | |

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

## `coreAuthenticatedSessionsList()`

```php
coreAuthenticatedSessionsList($ordering, $page, $page_size, $search, $session__last_ip, $session__last_user_agent, $user__username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatedSessionList
```



AuthenticatedSession Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$session__last_ip = 'session__last_ip_example'; // string
$session__last_user_agent = 'session__last_user_agent_example'; // string
$user__username = 'user__username_example'; // string

try {
    $result = $apiInstance->coreAuthenticatedSessionsList($ordering, $page, $page_size, $search, $session__last_ip, $session__last_user_agent, $user__username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreAuthenticatedSessionsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **session__last_ip** | **string**|  | [optional] |
| **session__last_user_agent** | **string**|  | [optional] |
| **user__username** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAuthenticatedSessionList**](../Model/PaginatedAuthenticatedSessionList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreAuthenticatedSessionsRetrieve()`

```php
coreAuthenticatedSessionsRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatedSession
```



AuthenticatedSession Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string

try {
    $result = $apiInstance->coreAuthenticatedSessionsRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreAuthenticatedSessionsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AuthenticatedSession**](../Model/AuthenticatedSession.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreAuthenticatedSessionsUsedByList()`

```php
coreAuthenticatedSessionsUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string

try {
    $result = $apiInstance->coreAuthenticatedSessionsUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreAuthenticatedSessionsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**|  | |

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

## `coreBrandsCreate()`

```php
coreBrandsCreate($brand_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand
```



Brand Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$brand_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BrandRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BrandRequest

try {
    $result = $apiInstance->coreBrandsCreate($brand_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **brand_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BrandRequest**](../Model/BrandRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand**](../Model/Brand.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreBrandsCurrentRetrieve()`

```php
coreBrandsCurrentRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CurrentBrand
```



Get current brand

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->coreBrandsCurrentRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsCurrentRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CurrentBrand**](../Model/CurrentBrand.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreBrandsDestroy()`

```php
coreBrandsDestroy($brand_uuid)
```



Brand Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$brand_uuid = 'brand_uuid_example'; // string | A UUID string identifying this Brand.

try {
    $apiInstance->coreBrandsDestroy($brand_uuid);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **brand_uuid** | **string**| A UUID string identifying this Brand. | |

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

## `coreBrandsList()`

```php
coreBrandsList($brand_uuid, $branding_default_flow_background, $branding_favicon, $branding_logo, $branding_title, $client_certificates, $default, $domain, $flow_authentication, $flow_device_code, $flow_invalidation, $flow_recovery, $flow_unenrollment, $flow_user_settings, $ordering, $page, $page_size, $search, $web_certificate): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedBrandList
```



Brand Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$brand_uuid = 'brand_uuid_example'; // string
$branding_default_flow_background = 'branding_default_flow_background_example'; // string
$branding_favicon = 'branding_favicon_example'; // string
$branding_logo = 'branding_logo_example'; // string
$branding_title = 'branding_title_example'; // string
$client_certificates = array('client_certificates_example'); // string[]
$default = True; // bool
$domain = 'domain_example'; // string
$flow_authentication = 'flow_authentication_example'; // string
$flow_device_code = 'flow_device_code_example'; // string
$flow_invalidation = 'flow_invalidation_example'; // string
$flow_recovery = 'flow_recovery_example'; // string
$flow_unenrollment = 'flow_unenrollment_example'; // string
$flow_user_settings = 'flow_user_settings_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$web_certificate = 'web_certificate_example'; // string

try {
    $result = $apiInstance->coreBrandsList($brand_uuid, $branding_default_flow_background, $branding_favicon, $branding_logo, $branding_title, $client_certificates, $default, $domain, $flow_authentication, $flow_device_code, $flow_invalidation, $flow_recovery, $flow_unenrollment, $flow_user_settings, $ordering, $page, $page_size, $search, $web_certificate);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **brand_uuid** | **string**|  | [optional] |
| **branding_default_flow_background** | **string**|  | [optional] |
| **branding_favicon** | **string**|  | [optional] |
| **branding_logo** | **string**|  | [optional] |
| **branding_title** | **string**|  | [optional] |
| **client_certificates** | [**string[]**](../Model/string.md)|  | [optional] |
| **default** | **bool**|  | [optional] |
| **domain** | **string**|  | [optional] |
| **flow_authentication** | **string**|  | [optional] |
| **flow_device_code** | **string**|  | [optional] |
| **flow_invalidation** | **string**|  | [optional] |
| **flow_recovery** | **string**|  | [optional] |
| **flow_unenrollment** | **string**|  | [optional] |
| **flow_user_settings** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **web_certificate** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedBrandList**](../Model/PaginatedBrandList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreBrandsPartialUpdate()`

```php
coreBrandsPartialUpdate($brand_uuid, $patched_brand_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand
```



Brand Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$brand_uuid = 'brand_uuid_example'; // string | A UUID string identifying this Brand.
$patched_brand_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedBrandRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedBrandRequest

try {
    $result = $apiInstance->coreBrandsPartialUpdate($brand_uuid, $patched_brand_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **brand_uuid** | **string**| A UUID string identifying this Brand. | |
| **patched_brand_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedBrandRequest**](../Model/PatchedBrandRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand**](../Model/Brand.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreBrandsRetrieve()`

```php
coreBrandsRetrieve($brand_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand
```



Brand Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$brand_uuid = 'brand_uuid_example'; // string | A UUID string identifying this Brand.

try {
    $result = $apiInstance->coreBrandsRetrieve($brand_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **brand_uuid** | **string**| A UUID string identifying this Brand. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand**](../Model/Brand.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreBrandsUpdate()`

```php
coreBrandsUpdate($brand_uuid, $brand_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand
```



Brand Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$brand_uuid = 'brand_uuid_example'; // string | A UUID string identifying this Brand.
$brand_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BrandRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BrandRequest

try {
    $result = $apiInstance->coreBrandsUpdate($brand_uuid, $brand_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **brand_uuid** | **string**| A UUID string identifying this Brand. | |
| **brand_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BrandRequest**](../Model/BrandRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Brand**](../Model/Brand.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreBrandsUsedByList()`

```php
coreBrandsUsedByList($brand_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$brand_uuid = 'brand_uuid_example'; // string | A UUID string identifying this Brand.

try {
    $result = $apiInstance->coreBrandsUsedByList($brand_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreBrandsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **brand_uuid** | **string**| A UUID string identifying this Brand. | |

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

## `coreGroupsAddUserCreate()`

```php
coreGroupsAddUserCreate($group_uuid, $user_account_request)
```



Add user to group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_uuid = 'group_uuid_example'; // string | A UUID string identifying this Group.
$user_account_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountRequest

try {
    $apiInstance->coreGroupsAddUserCreate($group_uuid, $user_account_request);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsAddUserCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_uuid** | **string**| A UUID string identifying this Group. | |
| **user_account_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountRequest**](../Model/UserAccountRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreGroupsCreate()`

```php
coreGroupsCreate($group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group
```



Group Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupRequest

try {
    $result = $apiInstance->coreGroupsCreate($group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupRequest**](../Model/GroupRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group**](../Model/Group.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreGroupsDestroy()`

```php
coreGroupsDestroy($group_uuid)
```



Group Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_uuid = 'group_uuid_example'; // string | A UUID string identifying this Group.

try {
    $apiInstance->coreGroupsDestroy($group_uuid);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_uuid** | **string**| A UUID string identifying this Group. | |

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

## `coreGroupsList()`

```php
coreGroupsList($attributes, $include_children, $include_inherited_roles, $include_parents, $include_users, $is_superuser, $members_by_pk, $members_by_username, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGroupList
```



Group Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$attributes = 'attributes_example'; // string | Attributes
$include_children = false; // bool
$include_inherited_roles = false; // bool
$include_parents = false; // bool
$include_users = true; // bool
$is_superuser = True; // bool
$members_by_pk = array(56); // int[]
$members_by_username = array('members_by_username_example'); // string[] | Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->coreGroupsList($attributes, $include_children, $include_inherited_roles, $include_parents, $include_users, $is_superuser, $members_by_pk, $members_by_username, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **attributes** | **string**| Attributes | [optional] |
| **include_children** | **bool**|  | [optional] [default to false] |
| **include_inherited_roles** | **bool**|  | [optional] [default to false] |
| **include_parents** | **bool**|  | [optional] [default to false] |
| **include_users** | **bool**|  | [optional] [default to true] |
| **is_superuser** | **bool**|  | [optional] |
| **members_by_pk** | [**int[]**](../Model/int.md)|  | [optional] |
| **members_by_username** | [**string[]**](../Model/string.md)| Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only. | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGroupList**](../Model/PaginatedGroupList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreGroupsPartialUpdate()`

```php
coreGroupsPartialUpdate($group_uuid, $patched_group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group
```



Group Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_uuid = 'group_uuid_example'; // string | A UUID string identifying this Group.
$patched_group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGroupRequest

try {
    $result = $apiInstance->coreGroupsPartialUpdate($group_uuid, $patched_group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_uuid** | **string**| A UUID string identifying this Group. | |
| **patched_group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGroupRequest**](../Model/PatchedGroupRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group**](../Model/Group.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreGroupsRemoveUserCreate()`

```php
coreGroupsRemoveUserCreate($group_uuid, $user_account_request)
```



Remove user from group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_uuid = 'group_uuid_example'; // string | A UUID string identifying this Group.
$user_account_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountRequest

try {
    $apiInstance->coreGroupsRemoveUserCreate($group_uuid, $user_account_request);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsRemoveUserCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_uuid** | **string**| A UUID string identifying this Group. | |
| **user_account_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountRequest**](../Model/UserAccountRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreGroupsRetrieve()`

```php
coreGroupsRetrieve($group_uuid, $include_children, $include_inherited_roles, $include_parents, $include_users): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group
```



Group Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_uuid = 'group_uuid_example'; // string | A UUID string identifying this Group.
$include_children = false; // bool
$include_inherited_roles = false; // bool
$include_parents = false; // bool
$include_users = true; // bool

try {
    $result = $apiInstance->coreGroupsRetrieve($group_uuid, $include_children, $include_inherited_roles, $include_parents, $include_users);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_uuid** | **string**| A UUID string identifying this Group. | |
| **include_children** | **bool**|  | [optional] [default to false] |
| **include_inherited_roles** | **bool**|  | [optional] [default to false] |
| **include_parents** | **bool**|  | [optional] [default to false] |
| **include_users** | **bool**|  | [optional] [default to true] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group**](../Model/Group.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreGroupsUpdate()`

```php
coreGroupsUpdate($group_uuid, $group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group
```



Group Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_uuid = 'group_uuid_example'; // string | A UUID string identifying this Group.
$group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupRequest

try {
    $result = $apiInstance->coreGroupsUpdate($group_uuid, $group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_uuid** | **string**| A UUID string identifying this Group. | |
| **group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GroupRequest**](../Model/GroupRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Group**](../Model/Group.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreGroupsUsedByList()`

```php
coreGroupsUsedByList($group_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group_uuid = 'group_uuid_example'; // string | A UUID string identifying this Group.

try {
    $result = $apiInstance->coreGroupsUsedByList($group_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreGroupsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **group_uuid** | **string**| A UUID string identifying this Group. | |

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

## `coreTokensCreate()`

```php
coreTokensCreate($token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token
```



Token Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenRequest

try {
    $result = $apiInstance->coreTokensCreate($token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenRequest**](../Model/TokenRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token**](../Model/Token.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreTokensDestroy()`

```php
coreTokensDestroy($identifier)
```



Token Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string

try {
    $apiInstance->coreTokensDestroy($identifier);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | |

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

## `coreTokensList()`

```php
coreTokensList($description, $expires, $expiring, $identifier, $intent, $managed, $ordering, $page, $page_size, $search, $user__username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTokenList
```



Token Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$description = 'description_example'; // string
$expires = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$expiring = True; // bool
$identifier = 'identifier_example'; // string
$intent = 'intent_example'; // string
$managed = 'managed_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$user__username = 'user__username_example'; // string

try {
    $result = $apiInstance->coreTokensList($description, $expires, $expiring, $identifier, $intent, $managed, $ordering, $page, $page_size, $search, $user__username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **description** | **string**|  | [optional] |
| **expires** | **\DateTime**|  | [optional] |
| **expiring** | **bool**|  | [optional] |
| **identifier** | **string**|  | [optional] |
| **intent** | **string**|  | [optional] |
| **managed** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **user__username** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTokenList**](../Model/PaginatedTokenList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreTokensPartialUpdate()`

```php
coreTokensPartialUpdate($identifier, $patched_token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token
```



Token Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string
$patched_token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTokenRequest

try {
    $result = $apiInstance->coreTokensPartialUpdate($identifier, $patched_token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | |
| **patched_token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTokenRequest**](../Model/PatchedTokenRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token**](../Model/Token.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreTokensRetrieve()`

```php
coreTokensRetrieve($identifier): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token
```



Token Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string

try {
    $result = $apiInstance->coreTokensRetrieve($identifier);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token**](../Model/Token.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreTokensSetKeyCreate()`

```php
coreTokensSetKeyCreate($identifier, $token_set_key_request)
```



Set token key. Action is logged as event. `authentik_core.set_token_key` permission is required.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string
$token_set_key_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenSetKeyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenSetKeyRequest

try {
    $apiInstance->coreTokensSetKeyCreate($identifier, $token_set_key_request);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensSetKeyCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | |
| **token_set_key_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenSetKeyRequest**](../Model/TokenSetKeyRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreTokensUpdate()`

```php
coreTokensUpdate($identifier, $token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token
```



Token Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string
$token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenRequest

try {
    $result = $apiInstance->coreTokensUpdate($identifier, $token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | |
| **token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenRequest**](../Model/TokenRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Token**](../Model/Token.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreTokensUsedByList()`

```php
coreTokensUsedByList($identifier): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string

try {
    $result = $apiInstance->coreTokensUsedByList($identifier);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | |

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

## `coreTokensViewKeyRetrieve()`

```php
coreTokensViewKeyRetrieve($identifier): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenView
```



Return token key and log access

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string

try {
    $result = $apiInstance->coreTokensViewKeyRetrieve($identifier);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTokensViewKeyRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenView**](../Model/TokenView.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreTransactionalApplicationsUpdate()`

```php
coreTransactionalApplicationsUpdate($transaction_application_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TransactionApplicationResponse
```



Convert data into a blueprint, validate it and apply it

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$transaction_application_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TransactionApplicationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TransactionApplicationRequest

try {
    $result = $apiInstance->coreTransactionalApplicationsUpdate($transaction_application_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreTransactionalApplicationsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **transaction_application_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TransactionApplicationRequest**](../Model/TransactionApplicationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TransactionApplicationResponse**](../Model/TransactionApplicationResponse.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUserConsentDestroy()`

```php
coreUserConsentDestroy($id)
```



UserConsent Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User Consent.

try {
    $apiInstance->coreUserConsentDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUserConsentDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User Consent. | |

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

## `coreUserConsentList()`

```php
coreUserConsentList($application, $ordering, $page, $page_size, $search, $user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserConsentList
```



UserConsent Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$application = 'application_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$user = 56; // int

try {
    $result = $apiInstance->coreUserConsentList($application, $ordering, $page, $page_size, $search, $user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUserConsentList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **application** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserConsentList**](../Model/PaginatedUserConsentList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUserConsentRetrieve()`

```php
coreUserConsentRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserConsent
```



UserConsent Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User Consent.

try {
    $result = $apiInstance->coreUserConsentRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUserConsentRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User Consent. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserConsent**](../Model/UserConsent.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUserConsentUsedByList()`

```php
coreUserConsentUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User Consent.

try {
    $result = $apiInstance->coreUserConsentUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUserConsentUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User Consent. | |

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

## `coreUsersCreate()`

```php
coreUsersCreate($user_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\User
```



User Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRequest

try {
    $result = $apiInstance->coreUsersCreate($user_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRequest**](../Model/UserRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\User**](../Model/User.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersDestroy()`

```php
coreUsersDestroy($id)
```



User Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.

try {
    $apiInstance->coreUsersDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |

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

## `coreUsersExportCreate()`

```php
coreUsersExportCreate($attributes, $date_joined, $date_joined__gt, $date_joined__lt, $email, $groups_by_name, $groups_by_pk, $is_active, $is_superuser, $last_login, $last_login__gt, $last_login__isnull, $last_login__lt, $last_updated, $last_updated__gt, $last_updated__lt, $name, $ordering, $path, $path_startswith, $roles_by_name, $roles_by_pk, $search, $type, $username, $uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DataExport
```



Create a data export for this data type. Note that the export is generated asynchronously: this method returns a `DataExport` object that will initially have `completed=false` as well as the permanent URL to that object in the `Location` header. You can poll that URL until `completed=true`, at which point the `file_url` property will contain a URL to download

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$attributes = 'attributes_example'; // string | Attributes
$date_joined = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$date_joined__gt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$date_joined__lt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$email = 'email_example'; // string
$groups_by_name = array('groups_by_name_example'); // string[]
$groups_by_pk = array('groups_by_pk_example'); // string[]
$is_active = True; // bool
$is_superuser = True; // bool
$last_login = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_login__gt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_login__isnull = True; // bool
$last_login__lt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_updated__gt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_updated__lt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$path = 'path_example'; // string
$path_startswith = 'path_startswith_example'; // string
$roles_by_name = array('roles_by_name_example'); // string[]
$roles_by_pk = array('roles_by_pk_example'); // string[]
$search = 'search_example'; // string | A search term.
$type = array('type_example'); // string[]
$username = 'username_example'; // string
$uuid = 'uuid_example'; // string

try {
    $result = $apiInstance->coreUsersExportCreate($attributes, $date_joined, $date_joined__gt, $date_joined__lt, $email, $groups_by_name, $groups_by_pk, $is_active, $is_superuser, $last_login, $last_login__gt, $last_login__isnull, $last_login__lt, $last_updated, $last_updated__gt, $last_updated__lt, $name, $ordering, $path, $path_startswith, $roles_by_name, $roles_by_pk, $search, $type, $username, $uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersExportCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **attributes** | **string**| Attributes | [optional] |
| **date_joined** | **\DateTime**|  | [optional] |
| **date_joined__gt** | **\DateTime**|  | [optional] |
| **date_joined__lt** | **\DateTime**|  | [optional] |
| **email** | **string**|  | [optional] |
| **groups_by_name** | [**string[]**](../Model/string.md)|  | [optional] |
| **groups_by_pk** | [**string[]**](../Model/string.md)|  | [optional] |
| **is_active** | **bool**|  | [optional] |
| **is_superuser** | **bool**|  | [optional] |
| **last_login** | **\DateTime**|  | [optional] |
| **last_login__gt** | **\DateTime**|  | [optional] |
| **last_login__isnull** | **bool**|  | [optional] |
| **last_login__lt** | **\DateTime**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **last_updated__gt** | **\DateTime**|  | [optional] |
| **last_updated__lt** | **\DateTime**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **path** | **string**|  | [optional] |
| **path_startswith** | **string**|  | [optional] |
| **roles_by_name** | [**string[]**](../Model/string.md)|  | [optional] |
| **roles_by_pk** | [**string[]**](../Model/string.md)|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **type** | [**string[]**](../Model/string.md)|  | [optional] |
| **username** | **string**|  | [optional] |
| **uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DataExport**](../Model/DataExport.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersImpersonateCreate()`

```php
coreUsersImpersonateCreate($id, $impersonation_request)
```



Impersonate a user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.
$impersonation_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ImpersonationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ImpersonationRequest

try {
    $apiInstance->coreUsersImpersonateCreate($id, $impersonation_request);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersImpersonateCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |
| **impersonation_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ImpersonationRequest**](../Model/ImpersonationRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersImpersonateEndRetrieve()`

```php
coreUsersImpersonateEndRetrieve()
```



End Impersonation a user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->coreUsersImpersonateEndRetrieve();
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersImpersonateEndRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

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

## `coreUsersList()`

```php
coreUsersList($attributes, $date_joined, $date_joined__gt, $date_joined__lt, $email, $groups_by_name, $groups_by_pk, $include_groups, $include_roles, $is_active, $is_superuser, $last_login, $last_login__gt, $last_login__isnull, $last_login__lt, $last_updated, $last_updated__gt, $last_updated__lt, $name, $ordering, $page, $page_size, $path, $path_startswith, $roles_by_name, $roles_by_pk, $search, $type, $username, $uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserList
```



User Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$attributes = 'attributes_example'; // string | Attributes
$date_joined = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$date_joined__gt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$date_joined__lt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$email = 'email_example'; // string
$groups_by_name = array('groups_by_name_example'); // string[]
$groups_by_pk = array('groups_by_pk_example'); // string[]
$include_groups = true; // bool
$include_roles = true; // bool
$is_active = True; // bool
$is_superuser = True; // bool
$last_login = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_login__gt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_login__isnull = True; // bool
$last_login__lt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_updated__gt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$last_updated__lt = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$path = 'path_example'; // string
$path_startswith = 'path_startswith_example'; // string
$roles_by_name = array('roles_by_name_example'); // string[]
$roles_by_pk = array('roles_by_pk_example'); // string[]
$search = 'search_example'; // string | A search term.
$type = array('type_example'); // string[]
$username = 'username_example'; // string
$uuid = 'uuid_example'; // string

try {
    $result = $apiInstance->coreUsersList($attributes, $date_joined, $date_joined__gt, $date_joined__lt, $email, $groups_by_name, $groups_by_pk, $include_groups, $include_roles, $is_active, $is_superuser, $last_login, $last_login__gt, $last_login__isnull, $last_login__lt, $last_updated, $last_updated__gt, $last_updated__lt, $name, $ordering, $page, $page_size, $path, $path_startswith, $roles_by_name, $roles_by_pk, $search, $type, $username, $uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **attributes** | **string**| Attributes | [optional] |
| **date_joined** | **\DateTime**|  | [optional] |
| **date_joined__gt** | **\DateTime**|  | [optional] |
| **date_joined__lt** | **\DateTime**|  | [optional] |
| **email** | **string**|  | [optional] |
| **groups_by_name** | [**string[]**](../Model/string.md)|  | [optional] |
| **groups_by_pk** | [**string[]**](../Model/string.md)|  | [optional] |
| **include_groups** | **bool**|  | [optional] [default to true] |
| **include_roles** | **bool**|  | [optional] [default to true] |
| **is_active** | **bool**|  | [optional] |
| **is_superuser** | **bool**|  | [optional] |
| **last_login** | **\DateTime**|  | [optional] |
| **last_login__gt** | **\DateTime**|  | [optional] |
| **last_login__isnull** | **bool**|  | [optional] |
| **last_login__lt** | **\DateTime**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **last_updated__gt** | **\DateTime**|  | [optional] |
| **last_updated__lt** | **\DateTime**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **path** | **string**|  | [optional] |
| **path_startswith** | **string**|  | [optional] |
| **roles_by_name** | [**string[]**](../Model/string.md)|  | [optional] |
| **roles_by_pk** | [**string[]**](../Model/string.md)|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **type** | [**string[]**](../Model/string.md)|  | [optional] |
| **username** | **string**|  | [optional] |
| **uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUserList**](../Model/PaginatedUserList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersMeRetrieve()`

```php
coreUsersMeRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SessionUser
```



Get information about current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->coreUsersMeRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersMeRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SessionUser**](../Model/SessionUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersPartialUpdate()`

```php
coreUsersPartialUpdate($id, $patched_user_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\User
```



User Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.
$patched_user_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserRequest

try {
    $result = $apiInstance->coreUsersPartialUpdate($id, $patched_user_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |
| **patched_user_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUserRequest**](../Model/PatchedUserRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\User**](../Model/User.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersPathsRetrieve()`

```php
coreUsersPathsRetrieve($search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserPath
```



Get all user paths

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->coreUsersPathsRetrieve($search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersPathsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserPath**](../Model/UserPath.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersRecoveryCreate()`

```php
coreUsersRecoveryCreate($id, $user_recovery_link_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Link
```



Create a temporary link that a user can use to recover their account

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.
$user_recovery_link_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRecoveryLinkRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRecoveryLinkRequest

try {
    $result = $apiInstance->coreUsersRecoveryCreate($id, $user_recovery_link_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersRecoveryCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |
| **user_recovery_link_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRecoveryLinkRequest**](../Model/UserRecoveryLinkRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Link**](../Model/Link.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersRecoveryEmailCreate()`

```php
coreUsersRecoveryEmailCreate($id, $user_recovery_email_request)
```



Send an email with a temporary link that a user can use to recover their account

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.
$user_recovery_email_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRecoveryEmailRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRecoveryEmailRequest

try {
    $apiInstance->coreUsersRecoveryEmailCreate($id, $user_recovery_email_request);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersRecoveryEmailCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |
| **user_recovery_email_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRecoveryEmailRequest**](../Model/UserRecoveryEmailRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersRetrieve()`

```php
coreUsersRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\User
```



User Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.

try {
    $result = $apiInstance->coreUsersRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\User**](../Model/User.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersServiceAccountCreate()`

```php
coreUsersServiceAccountCreate($user_service_account_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserServiceAccountResponse
```



Create a new user account that is marked as a service account

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user_service_account_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserServiceAccountRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserServiceAccountRequest

try {
    $result = $apiInstance->coreUsersServiceAccountCreate($user_service_account_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersServiceAccountCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user_service_account_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserServiceAccountRequest**](../Model/UserServiceAccountRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserServiceAccountResponse**](../Model/UserServiceAccountResponse.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersSetPasswordCreate()`

```php
coreUsersSetPasswordCreate($id, $user_password_set_request)
```



Set password for user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.
$user_password_set_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserPasswordSetRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserPasswordSetRequest

try {
    $apiInstance->coreUsersSetPasswordCreate($id, $user_password_set_request);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersSetPasswordCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |
| **user_password_set_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserPasswordSetRequest**](../Model/UserPasswordSetRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersUpdate()`

```php
coreUsersUpdate($id, $user_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\User
```



User Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.
$user_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRequest

try {
    $result = $apiInstance->coreUsersUpdate($id, $user_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |
| **user_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserRequest**](../Model/UserRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\User**](../Model/User.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `coreUsersUsedByList()`

```php
coreUsersUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CoreApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this User.

try {
    $result = $apiInstance->coreUsersUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CoreApi->coreUsersUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this User. | |

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
