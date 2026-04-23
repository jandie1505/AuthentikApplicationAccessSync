# OCA\AuthentikAccessSync\Vendor\Authentik\OutpostsApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**outpostsInstancesCreate()**](OutpostsApi.md#outpostsInstancesCreate) | **POST** /outposts/instances/ |  |
| [**outpostsInstancesDefaultSettingsRetrieve()**](OutpostsApi.md#outpostsInstancesDefaultSettingsRetrieve) | **GET** /outposts/instances/default_settings/ |  |
| [**outpostsInstancesDestroy()**](OutpostsApi.md#outpostsInstancesDestroy) | **DELETE** /outposts/instances/{uuid}/ |  |
| [**outpostsInstancesHealthList()**](OutpostsApi.md#outpostsInstancesHealthList) | **GET** /outposts/instances/{uuid}/health/ |  |
| [**outpostsInstancesList()**](OutpostsApi.md#outpostsInstancesList) | **GET** /outposts/instances/ |  |
| [**outpostsInstancesPartialUpdate()**](OutpostsApi.md#outpostsInstancesPartialUpdate) | **PATCH** /outposts/instances/{uuid}/ |  |
| [**outpostsInstancesRetrieve()**](OutpostsApi.md#outpostsInstancesRetrieve) | **GET** /outposts/instances/{uuid}/ |  |
| [**outpostsInstancesUpdate()**](OutpostsApi.md#outpostsInstancesUpdate) | **PUT** /outposts/instances/{uuid}/ |  |
| [**outpostsInstancesUsedByList()**](OutpostsApi.md#outpostsInstancesUsedByList) | **GET** /outposts/instances/{uuid}/used_by/ |  |
| [**outpostsLdapAccessCheck()**](OutpostsApi.md#outpostsLdapAccessCheck) | **GET** /outposts/ldap/{id}/check_access/ |  |
| [**outpostsLdapList()**](OutpostsApi.md#outpostsLdapList) | **GET** /outposts/ldap/ |  |
| [**outpostsProxyList()**](OutpostsApi.md#outpostsProxyList) | **GET** /outposts/proxy/ |  |
| [**outpostsRadiusAccessCheck()**](OutpostsApi.md#outpostsRadiusAccessCheck) | **GET** /outposts/radius/{id}/check_access/ |  |
| [**outpostsRadiusList()**](OutpostsApi.md#outpostsRadiusList) | **GET** /outposts/radius/ |  |
| [**outpostsServiceConnectionsAllDestroy()**](OutpostsApi.md#outpostsServiceConnectionsAllDestroy) | **DELETE** /outposts/service_connections/all/{uuid}/ |  |
| [**outpostsServiceConnectionsAllList()**](OutpostsApi.md#outpostsServiceConnectionsAllList) | **GET** /outposts/service_connections/all/ |  |
| [**outpostsServiceConnectionsAllRetrieve()**](OutpostsApi.md#outpostsServiceConnectionsAllRetrieve) | **GET** /outposts/service_connections/all/{uuid}/ |  |
| [**outpostsServiceConnectionsAllStateRetrieve()**](OutpostsApi.md#outpostsServiceConnectionsAllStateRetrieve) | **GET** /outposts/service_connections/all/{uuid}/state/ |  |
| [**outpostsServiceConnectionsAllTypesList()**](OutpostsApi.md#outpostsServiceConnectionsAllTypesList) | **GET** /outposts/service_connections/all/types/ |  |
| [**outpostsServiceConnectionsAllUsedByList()**](OutpostsApi.md#outpostsServiceConnectionsAllUsedByList) | **GET** /outposts/service_connections/all/{uuid}/used_by/ |  |
| [**outpostsServiceConnectionsDockerCreate()**](OutpostsApi.md#outpostsServiceConnectionsDockerCreate) | **POST** /outposts/service_connections/docker/ |  |
| [**outpostsServiceConnectionsDockerDestroy()**](OutpostsApi.md#outpostsServiceConnectionsDockerDestroy) | **DELETE** /outposts/service_connections/docker/{uuid}/ |  |
| [**outpostsServiceConnectionsDockerList()**](OutpostsApi.md#outpostsServiceConnectionsDockerList) | **GET** /outposts/service_connections/docker/ |  |
| [**outpostsServiceConnectionsDockerPartialUpdate()**](OutpostsApi.md#outpostsServiceConnectionsDockerPartialUpdate) | **PATCH** /outposts/service_connections/docker/{uuid}/ |  |
| [**outpostsServiceConnectionsDockerRetrieve()**](OutpostsApi.md#outpostsServiceConnectionsDockerRetrieve) | **GET** /outposts/service_connections/docker/{uuid}/ |  |
| [**outpostsServiceConnectionsDockerUpdate()**](OutpostsApi.md#outpostsServiceConnectionsDockerUpdate) | **PUT** /outposts/service_connections/docker/{uuid}/ |  |
| [**outpostsServiceConnectionsDockerUsedByList()**](OutpostsApi.md#outpostsServiceConnectionsDockerUsedByList) | **GET** /outposts/service_connections/docker/{uuid}/used_by/ |  |
| [**outpostsServiceConnectionsKubernetesCreate()**](OutpostsApi.md#outpostsServiceConnectionsKubernetesCreate) | **POST** /outposts/service_connections/kubernetes/ |  |
| [**outpostsServiceConnectionsKubernetesDestroy()**](OutpostsApi.md#outpostsServiceConnectionsKubernetesDestroy) | **DELETE** /outposts/service_connections/kubernetes/{uuid}/ |  |
| [**outpostsServiceConnectionsKubernetesList()**](OutpostsApi.md#outpostsServiceConnectionsKubernetesList) | **GET** /outposts/service_connections/kubernetes/ |  |
| [**outpostsServiceConnectionsKubernetesPartialUpdate()**](OutpostsApi.md#outpostsServiceConnectionsKubernetesPartialUpdate) | **PATCH** /outposts/service_connections/kubernetes/{uuid}/ |  |
| [**outpostsServiceConnectionsKubernetesRetrieve()**](OutpostsApi.md#outpostsServiceConnectionsKubernetesRetrieve) | **GET** /outposts/service_connections/kubernetes/{uuid}/ |  |
| [**outpostsServiceConnectionsKubernetesUpdate()**](OutpostsApi.md#outpostsServiceConnectionsKubernetesUpdate) | **PUT** /outposts/service_connections/kubernetes/{uuid}/ |  |
| [**outpostsServiceConnectionsKubernetesUsedByList()**](OutpostsApi.md#outpostsServiceConnectionsKubernetesUsedByList) | **GET** /outposts/service_connections/kubernetes/{uuid}/used_by/ |  |


## `outpostsInstancesCreate()`

```php
outpostsInstancesCreate($outpost_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost
```



Outpost Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$outpost_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostRequest

try {
    $result = $apiInstance->outpostsInstancesCreate($outpost_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **outpost_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostRequest**](../Model/OutpostRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost**](../Model/Outpost.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsInstancesDefaultSettingsRetrieve()`

```php
outpostsInstancesDefaultSettingsRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostDefaultConfig
```



Global default outpost config

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->outpostsInstancesDefaultSettingsRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesDefaultSettingsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostDefaultConfig**](../Model/OutpostDefaultConfig.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsInstancesDestroy()`

```php
outpostsInstancesDestroy($uuid)
```



Outpost Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost.

try {
    $apiInstance->outpostsInstancesDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost. | |

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

## `outpostsInstancesHealthList()`

```php
outpostsInstancesHealthList($uuid, $managed__icontains, $managed__iexact, $name__icontains, $name__iexact, $ordering, $providers__isnull, $providers_by_pk, $search, $service_connection__name__icontains, $service_connection__name__iexact): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostHealth[]
```



Get outposts current health

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost.
$managed__icontains = 'managed__icontains_example'; // string
$managed__iexact = 'managed__iexact_example'; // string
$name__icontains = 'name__icontains_example'; // string
$name__iexact = 'name__iexact_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$providers__isnull = True; // bool
$providers_by_pk = array(56); // int[]
$search = 'search_example'; // string | A search term.
$service_connection__name__icontains = 'service_connection__name__icontains_example'; // string
$service_connection__name__iexact = 'service_connection__name__iexact_example'; // string

try {
    $result = $apiInstance->outpostsInstancesHealthList($uuid, $managed__icontains, $managed__iexact, $name__icontains, $name__iexact, $ordering, $providers__isnull, $providers_by_pk, $search, $service_connection__name__icontains, $service_connection__name__iexact);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesHealthList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost. | |
| **managed__icontains** | **string**|  | [optional] |
| **managed__iexact** | **string**|  | [optional] |
| **name__icontains** | **string**|  | [optional] |
| **name__iexact** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **providers__isnull** | **bool**|  | [optional] |
| **providers_by_pk** | [**int[]**](../Model/int.md)|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **service_connection__name__icontains** | **string**|  | [optional] |
| **service_connection__name__iexact** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostHealth[]**](../Model/OutpostHealth.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsInstancesList()`

```php
outpostsInstancesList($managed__icontains, $managed__iexact, $name__icontains, $name__iexact, $ordering, $page, $page_size, $providers__isnull, $providers_by_pk, $search, $service_connection__name__icontains, $service_connection__name__iexact): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedOutpostList
```



Outpost Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$managed__icontains = 'managed__icontains_example'; // string
$managed__iexact = 'managed__iexact_example'; // string
$name__icontains = 'name__icontains_example'; // string
$name__iexact = 'name__iexact_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$providers__isnull = True; // bool
$providers_by_pk = array(56); // int[]
$search = 'search_example'; // string | A search term.
$service_connection__name__icontains = 'service_connection__name__icontains_example'; // string
$service_connection__name__iexact = 'service_connection__name__iexact_example'; // string

try {
    $result = $apiInstance->outpostsInstancesList($managed__icontains, $managed__iexact, $name__icontains, $name__iexact, $ordering, $page, $page_size, $providers__isnull, $providers_by_pk, $search, $service_connection__name__icontains, $service_connection__name__iexact);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **managed__icontains** | **string**|  | [optional] |
| **managed__iexact** | **string**|  | [optional] |
| **name__icontains** | **string**|  | [optional] |
| **name__iexact** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **providers__isnull** | **bool**|  | [optional] |
| **providers_by_pk** | [**int[]**](../Model/int.md)|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **service_connection__name__icontains** | **string**|  | [optional] |
| **service_connection__name__iexact** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedOutpostList**](../Model/PaginatedOutpostList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsInstancesPartialUpdate()`

```php
outpostsInstancesPartialUpdate($uuid, $patched_outpost_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost
```



Outpost Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost.
$patched_outpost_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOutpostRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOutpostRequest

try {
    $result = $apiInstance->outpostsInstancesPartialUpdate($uuid, $patched_outpost_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost. | |
| **patched_outpost_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedOutpostRequest**](../Model/PatchedOutpostRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost**](../Model/Outpost.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsInstancesRetrieve()`

```php
outpostsInstancesRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost
```



Outpost Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost.

try {
    $result = $apiInstance->outpostsInstancesRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost**](../Model/Outpost.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsInstancesUpdate()`

```php
outpostsInstancesUpdate($uuid, $outpost_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost
```



Outpost Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost.
$outpost_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostRequest

try {
    $result = $apiInstance->outpostsInstancesUpdate($uuid, $outpost_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost. | |
| **outpost_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\OutpostRequest**](../Model/OutpostRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Outpost**](../Model/Outpost.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsInstancesUsedByList()`

```php
outpostsInstancesUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost.

try {
    $result = $apiInstance->outpostsInstancesUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsInstancesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost. | |

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

## `outpostsLdapAccessCheck()`

```php
outpostsLdapAccessCheck($id, $app_slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPCheckAccess
```



Check access to a single application by slug

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this LDAP Provider.
$app_slug = 'app_slug_example'; // string

try {
    $result = $apiInstance->outpostsLdapAccessCheck($id, $app_slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsLdapAccessCheck: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this LDAP Provider. | |
| **app_slug** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LDAPCheckAccess**](../Model/LDAPCheckAccess.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsLdapList()`

```php
outpostsLdapList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLDAPOutpostConfigList
```



LDAPProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
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
    $result = $apiInstance->outpostsLdapList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsLdapList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLDAPOutpostConfigList**](../Model/PaginatedLDAPOutpostConfigList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsProxyList()`

```php
outpostsProxyList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedProxyOutpostConfigList
```



ProxyProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
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
    $result = $apiInstance->outpostsProxyList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsProxyList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedProxyOutpostConfigList**](../Model/PaginatedProxyOutpostConfigList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsRadiusAccessCheck()`

```php
outpostsRadiusAccessCheck($id, $app_slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusCheckAccess
```



Check access to a single application by slug

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Radius Provider.
$app_slug = 'app_slug_example'; // string

try {
    $result = $apiInstance->outpostsRadiusAccessCheck($id, $app_slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsRadiusAccessCheck: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Radius Provider. | |
| **app_slug** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RadiusCheckAccess**](../Model/RadiusCheckAccess.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsRadiusList()`

```php
outpostsRadiusList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRadiusOutpostConfigList
```



RadiusProvider Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
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
    $result = $apiInstance->outpostsRadiusList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsRadiusList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRadiusOutpostConfigList**](../Model/PaginatedRadiusOutpostConfigList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsAllDestroy()`

```php
outpostsServiceConnectionsAllDestroy($uuid)
```



ServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost Service-Connection.

try {
    $apiInstance->outpostsServiceConnectionsAllDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsAllDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost Service-Connection. | |

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

## `outpostsServiceConnectionsAllList()`

```php
outpostsServiceConnectionsAllList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedServiceConnectionList
```



ServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
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
    $result = $apiInstance->outpostsServiceConnectionsAllList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsAllList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedServiceConnectionList**](../Model/PaginatedServiceConnectionList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsAllRetrieve()`

```php
outpostsServiceConnectionsAllRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ServiceConnection
```



ServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost Service-Connection.

try {
    $result = $apiInstance->outpostsServiceConnectionsAllRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsAllRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost Service-Connection. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ServiceConnection**](../Model/ServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsAllStateRetrieve()`

```php
outpostsServiceConnectionsAllStateRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ServiceConnectionState
```



Get the service connection's state

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost Service-Connection.

try {
    $result = $apiInstance->outpostsServiceConnectionsAllStateRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsAllStateRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost Service-Connection. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ServiceConnectionState**](../Model/ServiceConnectionState.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsAllTypesList()`

```php
outpostsServiceConnectionsAllTypesList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all creatable types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->outpostsServiceConnectionsAllTypesList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsAllTypesList: ', $e->getMessage(), PHP_EOL;
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

## `outpostsServiceConnectionsAllUsedByList()`

```php
outpostsServiceConnectionsAllUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Outpost Service-Connection.

try {
    $result = $apiInstance->outpostsServiceConnectionsAllUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsAllUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Outpost Service-Connection. | |

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

## `outpostsServiceConnectionsDockerCreate()`

```php
outpostsServiceConnectionsDockerCreate($docker_service_connection_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection
```



DockerServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$docker_service_connection_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnectionRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnectionRequest

try {
    $result = $apiInstance->outpostsServiceConnectionsDockerCreate($docker_service_connection_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsDockerCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **docker_service_connection_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnectionRequest**](../Model/DockerServiceConnectionRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection**](../Model/DockerServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsDockerDestroy()`

```php
outpostsServiceConnectionsDockerDestroy($uuid)
```



DockerServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Docker Service-Connection.

try {
    $apiInstance->outpostsServiceConnectionsDockerDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsDockerDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Docker Service-Connection. | |

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

## `outpostsServiceConnectionsDockerList()`

```php
outpostsServiceConnectionsDockerList($local, $name, $ordering, $page, $page_size, $search, $tls_authentication, $tls_verification, $url): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDockerServiceConnectionList
```



DockerServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$local = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$tls_authentication = 'tls_authentication_example'; // string
$tls_verification = 'tls_verification_example'; // string
$url = 'url_example'; // string

try {
    $result = $apiInstance->outpostsServiceConnectionsDockerList($local, $name, $ordering, $page, $page_size, $search, $tls_authentication, $tls_verification, $url);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsDockerList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **local** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **tls_authentication** | **string**|  | [optional] |
| **tls_verification** | **string**|  | [optional] |
| **url** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDockerServiceConnectionList**](../Model/PaginatedDockerServiceConnectionList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsDockerPartialUpdate()`

```php
outpostsServiceConnectionsDockerPartialUpdate($uuid, $patched_docker_service_connection_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection
```



DockerServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Docker Service-Connection.
$patched_docker_service_connection_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDockerServiceConnectionRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDockerServiceConnectionRequest

try {
    $result = $apiInstance->outpostsServiceConnectionsDockerPartialUpdate($uuid, $patched_docker_service_connection_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsDockerPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Docker Service-Connection. | |
| **patched_docker_service_connection_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDockerServiceConnectionRequest**](../Model/PatchedDockerServiceConnectionRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection**](../Model/DockerServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsDockerRetrieve()`

```php
outpostsServiceConnectionsDockerRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection
```



DockerServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Docker Service-Connection.

try {
    $result = $apiInstance->outpostsServiceConnectionsDockerRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsDockerRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Docker Service-Connection. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection**](../Model/DockerServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsDockerUpdate()`

```php
outpostsServiceConnectionsDockerUpdate($uuid, $docker_service_connection_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection
```



DockerServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Docker Service-Connection.
$docker_service_connection_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnectionRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnectionRequest

try {
    $result = $apiInstance->outpostsServiceConnectionsDockerUpdate($uuid, $docker_service_connection_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsDockerUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Docker Service-Connection. | |
| **docker_service_connection_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnectionRequest**](../Model/DockerServiceConnectionRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DockerServiceConnection**](../Model/DockerServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsDockerUsedByList()`

```php
outpostsServiceConnectionsDockerUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Docker Service-Connection.

try {
    $result = $apiInstance->outpostsServiceConnectionsDockerUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsDockerUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Docker Service-Connection. | |

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

## `outpostsServiceConnectionsKubernetesCreate()`

```php
outpostsServiceConnectionsKubernetesCreate($kubernetes_service_connection_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection
```



KubernetesServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kubernetes_service_connection_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnectionRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnectionRequest

try {
    $result = $apiInstance->outpostsServiceConnectionsKubernetesCreate($kubernetes_service_connection_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsKubernetesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kubernetes_service_connection_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnectionRequest**](../Model/KubernetesServiceConnectionRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection**](../Model/KubernetesServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsKubernetesDestroy()`

```php
outpostsServiceConnectionsKubernetesDestroy($uuid)
```



KubernetesServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Kubernetes Service-Connection.

try {
    $apiInstance->outpostsServiceConnectionsKubernetesDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsKubernetesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Kubernetes Service-Connection. | |

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

## `outpostsServiceConnectionsKubernetesList()`

```php
outpostsServiceConnectionsKubernetesList($local, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedKubernetesServiceConnectionList
```



KubernetesServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$local = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->outpostsServiceConnectionsKubernetesList($local, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsKubernetesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **local** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedKubernetesServiceConnectionList**](../Model/PaginatedKubernetesServiceConnectionList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsKubernetesPartialUpdate()`

```php
outpostsServiceConnectionsKubernetesPartialUpdate($uuid, $patched_kubernetes_service_connection_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection
```



KubernetesServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Kubernetes Service-Connection.
$patched_kubernetes_service_connection_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedKubernetesServiceConnectionRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedKubernetesServiceConnectionRequest

try {
    $result = $apiInstance->outpostsServiceConnectionsKubernetesPartialUpdate($uuid, $patched_kubernetes_service_connection_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsKubernetesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Kubernetes Service-Connection. | |
| **patched_kubernetes_service_connection_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedKubernetesServiceConnectionRequest**](../Model/PatchedKubernetesServiceConnectionRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection**](../Model/KubernetesServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsKubernetesRetrieve()`

```php
outpostsServiceConnectionsKubernetesRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection
```



KubernetesServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Kubernetes Service-Connection.

try {
    $result = $apiInstance->outpostsServiceConnectionsKubernetesRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsKubernetesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Kubernetes Service-Connection. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection**](../Model/KubernetesServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsKubernetesUpdate()`

```php
outpostsServiceConnectionsKubernetesUpdate($uuid, $kubernetes_service_connection_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection
```



KubernetesServiceConnection Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Kubernetes Service-Connection.
$kubernetes_service_connection_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnectionRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnectionRequest

try {
    $result = $apiInstance->outpostsServiceConnectionsKubernetesUpdate($uuid, $kubernetes_service_connection_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsKubernetesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Kubernetes Service-Connection. | |
| **kubernetes_service_connection_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnectionRequest**](../Model/KubernetesServiceConnectionRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\KubernetesServiceConnection**](../Model/KubernetesServiceConnection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `outpostsServiceConnectionsKubernetesUsedByList()`

```php
outpostsServiceConnectionsKubernetesUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\OutpostsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Kubernetes Service-Connection.

try {
    $result = $apiInstance->outpostsServiceConnectionsKubernetesUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OutpostsApi->outpostsServiceConnectionsKubernetesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Kubernetes Service-Connection. | |

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
