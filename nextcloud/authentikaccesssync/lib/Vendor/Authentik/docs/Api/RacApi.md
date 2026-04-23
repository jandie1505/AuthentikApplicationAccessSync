# OCA\AuthentikAccessSync\Vendor\Authentik\RacApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**racConnectionTokensDestroy()**](RacApi.md#racConnectionTokensDestroy) | **DELETE** /rac/connection_tokens/{connection_token_uuid}/ |  |
| [**racConnectionTokensList()**](RacApi.md#racConnectionTokensList) | **GET** /rac/connection_tokens/ |  |
| [**racConnectionTokensPartialUpdate()**](RacApi.md#racConnectionTokensPartialUpdate) | **PATCH** /rac/connection_tokens/{connection_token_uuid}/ |  |
| [**racConnectionTokensRetrieve()**](RacApi.md#racConnectionTokensRetrieve) | **GET** /rac/connection_tokens/{connection_token_uuid}/ |  |
| [**racConnectionTokensUpdate()**](RacApi.md#racConnectionTokensUpdate) | **PUT** /rac/connection_tokens/{connection_token_uuid}/ |  |
| [**racConnectionTokensUsedByList()**](RacApi.md#racConnectionTokensUsedByList) | **GET** /rac/connection_tokens/{connection_token_uuid}/used_by/ |  |
| [**racEndpointsCreate()**](RacApi.md#racEndpointsCreate) | **POST** /rac/endpoints/ |  |
| [**racEndpointsDestroy()**](RacApi.md#racEndpointsDestroy) | **DELETE** /rac/endpoints/{pbm_uuid}/ |  |
| [**racEndpointsList()**](RacApi.md#racEndpointsList) | **GET** /rac/endpoints/ |  |
| [**racEndpointsPartialUpdate()**](RacApi.md#racEndpointsPartialUpdate) | **PATCH** /rac/endpoints/{pbm_uuid}/ |  |
| [**racEndpointsRetrieve()**](RacApi.md#racEndpointsRetrieve) | **GET** /rac/endpoints/{pbm_uuid}/ |  |
| [**racEndpointsUpdate()**](RacApi.md#racEndpointsUpdate) | **PUT** /rac/endpoints/{pbm_uuid}/ |  |
| [**racEndpointsUsedByList()**](RacApi.md#racEndpointsUsedByList) | **GET** /rac/endpoints/{pbm_uuid}/used_by/ |  |


## `racConnectionTokensDestroy()`

```php
racConnectionTokensDestroy($connection_token_uuid)
```



ConnectionToken Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connection_token_uuid = 'connection_token_uuid_example'; // string | A UUID string identifying this RAC Connection token.

try {
    $apiInstance->racConnectionTokensDestroy($connection_token_uuid);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racConnectionTokensDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connection_token_uuid** | **string**| A UUID string identifying this RAC Connection token. | |

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

## `racConnectionTokensList()`

```php
racConnectionTokensList($endpoint, $ordering, $page, $page_size, $provider, $search, $session__user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedConnectionTokenList
```



ConnectionToken Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$endpoint = 'endpoint_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider = 56; // int
$search = 'search_example'; // string | A search term.
$session__user = 56; // int

try {
    $result = $apiInstance->racConnectionTokensList($endpoint, $ordering, $page, $page_size, $provider, $search, $session__user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racConnectionTokensList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **endpoint** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **session__user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedConnectionTokenList**](../Model/PaginatedConnectionTokenList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racConnectionTokensPartialUpdate()`

```php
racConnectionTokensPartialUpdate($connection_token_uuid, $patched_connection_token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionToken
```



ConnectionToken Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connection_token_uuid = 'connection_token_uuid_example'; // string | A UUID string identifying this RAC Connection token.
$patched_connection_token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedConnectionTokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedConnectionTokenRequest

try {
    $result = $apiInstance->racConnectionTokensPartialUpdate($connection_token_uuid, $patched_connection_token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racConnectionTokensPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connection_token_uuid** | **string**| A UUID string identifying this RAC Connection token. | |
| **patched_connection_token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedConnectionTokenRequest**](../Model/PatchedConnectionTokenRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionToken**](../Model/ConnectionToken.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racConnectionTokensRetrieve()`

```php
racConnectionTokensRetrieve($connection_token_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionToken
```



ConnectionToken Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connection_token_uuid = 'connection_token_uuid_example'; // string | A UUID string identifying this RAC Connection token.

try {
    $result = $apiInstance->racConnectionTokensRetrieve($connection_token_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racConnectionTokensRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connection_token_uuid** | **string**| A UUID string identifying this RAC Connection token. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionToken**](../Model/ConnectionToken.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racConnectionTokensUpdate()`

```php
racConnectionTokensUpdate($connection_token_uuid, $connection_token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionToken
```



ConnectionToken Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connection_token_uuid = 'connection_token_uuid_example'; // string | A UUID string identifying this RAC Connection token.
$connection_token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionTokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionTokenRequest

try {
    $result = $apiInstance->racConnectionTokensUpdate($connection_token_uuid, $connection_token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racConnectionTokensUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connection_token_uuid** | **string**| A UUID string identifying this RAC Connection token. | |
| **connection_token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionTokenRequest**](../Model/ConnectionTokenRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ConnectionToken**](../Model/ConnectionToken.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racConnectionTokensUsedByList()`

```php
racConnectionTokensUsedByList($connection_token_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connection_token_uuid = 'connection_token_uuid_example'; // string | A UUID string identifying this RAC Connection token.

try {
    $result = $apiInstance->racConnectionTokensUsedByList($connection_token_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racConnectionTokensUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connection_token_uuid** | **string**| A UUID string identifying this RAC Connection token. | |

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

## `racEndpointsCreate()`

```php
racEndpointsCreate($endpoint_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint
```



Endpoint Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$endpoint_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointRequest

try {
    $result = $apiInstance->racEndpointsCreate($endpoint_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racEndpointsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **endpoint_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointRequest**](../Model/EndpointRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint**](../Model/Endpoint.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racEndpointsDestroy()`

```php
racEndpointsDestroy($pbm_uuid)
```



Endpoint Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this RAC Endpoint.

try {
    $apiInstance->racEndpointsDestroy($pbm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racEndpointsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this RAC Endpoint. | |

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

## `racEndpointsList()`

```php
racEndpointsList($name, $ordering, $page, $page_size, $provider, $search, $superuser_full_list): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEndpointList
```



List accessible endpoints

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider = 56; // int
$search = 'search_example'; // string | A search term.
$superuser_full_list = True; // bool

try {
    $result = $apiInstance->racEndpointsList($name, $ordering, $page, $page_size, $provider, $search, $superuser_full_list);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racEndpointsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **superuser_full_list** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEndpointList**](../Model/PaginatedEndpointList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racEndpointsPartialUpdate()`

```php
racEndpointsPartialUpdate($pbm_uuid, $patched_endpoint_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint
```



Endpoint Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this RAC Endpoint.
$patched_endpoint_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointRequest

try {
    $result = $apiInstance->racEndpointsPartialUpdate($pbm_uuid, $patched_endpoint_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racEndpointsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this RAC Endpoint. | |
| **patched_endpoint_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointRequest**](../Model/PatchedEndpointRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint**](../Model/Endpoint.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racEndpointsRetrieve()`

```php
racEndpointsRetrieve($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint
```



Endpoint Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this RAC Endpoint.

try {
    $result = $apiInstance->racEndpointsRetrieve($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racEndpointsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this RAC Endpoint. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint**](../Model/Endpoint.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racEndpointsUpdate()`

```php
racEndpointsUpdate($pbm_uuid, $endpoint_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint
```



Endpoint Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this RAC Endpoint.
$endpoint_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointRequest

try {
    $result = $apiInstance->racEndpointsUpdate($pbm_uuid, $endpoint_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racEndpointsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this RAC Endpoint. | |
| **endpoint_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointRequest**](../Model/EndpointRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Endpoint**](../Model/Endpoint.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `racEndpointsUsedByList()`

```php
racEndpointsUsedByList($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this RAC Endpoint.

try {
    $result = $apiInstance->racEndpointsUsedByList($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RacApi->racEndpointsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this RAC Endpoint. | |

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
