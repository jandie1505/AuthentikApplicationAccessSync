# OCA\AuthentikAccessSync\Vendor\Authentik\SsfApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**ssfStreamsList()**](SsfApi.md#ssfStreamsList) | **GET** /ssf/streams/ |  |
| [**ssfStreamsRetrieve()**](SsfApi.md#ssfStreamsRetrieve) | **GET** /ssf/streams/{uuid}/ |  |


## `ssfStreamsList()`

```php
ssfStreamsList($delivery_method, $endpoint_url, $ordering, $page, $page_size, $provider, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSSFStreamList
```



SSFStream Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\SsfApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$delivery_method = 'delivery_method_example'; // string
$endpoint_url = 'endpoint_url_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$provider = 56; // int
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->ssfStreamsList($delivery_method, $endpoint_url, $ordering, $page, $page_size, $provider, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SsfApi->ssfStreamsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **delivery_method** | **string**|  | [optional] |
| **endpoint_url** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **provider** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSSFStreamList**](../Model/PaginatedSSFStreamList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `ssfStreamsRetrieve()`

```php
ssfStreamsRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFStream
```



SSFStream Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\SsfApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this SSF Stream.

try {
    $result = $apiInstance->ssfStreamsRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SsfApi->ssfStreamsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this SSF Stream. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SSFStream**](../Model/SSFStream.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
