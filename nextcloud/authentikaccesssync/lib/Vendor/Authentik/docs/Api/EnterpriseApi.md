# OCA\AuthentikAccessSync\Vendor\Authentik\EnterpriseApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**enterpriseLicenseCreate()**](EnterpriseApi.md#enterpriseLicenseCreate) | **POST** /enterprise/license/ |  |
| [**enterpriseLicenseDestroy()**](EnterpriseApi.md#enterpriseLicenseDestroy) | **DELETE** /enterprise/license/{license_uuid}/ |  |
| [**enterpriseLicenseForecastRetrieve()**](EnterpriseApi.md#enterpriseLicenseForecastRetrieve) | **GET** /enterprise/license/forecast/ |  |
| [**enterpriseLicenseInstallIdRetrieve()**](EnterpriseApi.md#enterpriseLicenseInstallIdRetrieve) | **GET** /enterprise/license/install_id/ |  |
| [**enterpriseLicenseList()**](EnterpriseApi.md#enterpriseLicenseList) | **GET** /enterprise/license/ |  |
| [**enterpriseLicensePartialUpdate()**](EnterpriseApi.md#enterpriseLicensePartialUpdate) | **PATCH** /enterprise/license/{license_uuid}/ |  |
| [**enterpriseLicenseRetrieve()**](EnterpriseApi.md#enterpriseLicenseRetrieve) | **GET** /enterprise/license/{license_uuid}/ |  |
| [**enterpriseLicenseSummaryRetrieve()**](EnterpriseApi.md#enterpriseLicenseSummaryRetrieve) | **GET** /enterprise/license/summary/ |  |
| [**enterpriseLicenseUpdate()**](EnterpriseApi.md#enterpriseLicenseUpdate) | **PUT** /enterprise/license/{license_uuid}/ |  |
| [**enterpriseLicenseUsedByList()**](EnterpriseApi.md#enterpriseLicenseUsedByList) | **GET** /enterprise/license/{license_uuid}/used_by/ |  |


## `enterpriseLicenseCreate()`

```php
enterpriseLicenseCreate($license_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\License
```



License Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$license_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseRequest

try {
    $result = $apiInstance->enterpriseLicenseCreate($license_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **license_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseRequest**](../Model/LicenseRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\License**](../Model/License.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicenseDestroy()`

```php
enterpriseLicenseDestroy($license_uuid)
```



License Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$license_uuid = 'license_uuid_example'; // string | A UUID string identifying this License.

try {
    $apiInstance->enterpriseLicenseDestroy($license_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **license_uuid** | **string**| A UUID string identifying this License. | |

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

## `enterpriseLicenseForecastRetrieve()`

```php
enterpriseLicenseForecastRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseForecast
```



Forecast how many users will be required in a year

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->enterpriseLicenseForecastRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseForecastRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseForecast**](../Model/LicenseForecast.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicenseInstallIdRetrieve()`

```php
enterpriseLicenseInstallIdRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InstallID
```



Get install_id

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->enterpriseLicenseInstallIdRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseInstallIdRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InstallID**](../Model/InstallID.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicenseList()`

```php
enterpriseLicenseList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLicenseList
```



License Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
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
    $result = $apiInstance->enterpriseLicenseList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLicenseList**](../Model/PaginatedLicenseList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicensePartialUpdate()`

```php
enterpriseLicensePartialUpdate($license_uuid, $patched_license_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\License
```



License Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$license_uuid = 'license_uuid_example'; // string | A UUID string identifying this License.
$patched_license_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLicenseRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLicenseRequest

try {
    $result = $apiInstance->enterpriseLicensePartialUpdate($license_uuid, $patched_license_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicensePartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **license_uuid** | **string**| A UUID string identifying this License. | |
| **patched_license_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLicenseRequest**](../Model/PatchedLicenseRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\License**](../Model/License.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicenseRetrieve()`

```php
enterpriseLicenseRetrieve($license_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\License
```



License Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$license_uuid = 'license_uuid_example'; // string | A UUID string identifying this License.

try {
    $result = $apiInstance->enterpriseLicenseRetrieve($license_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **license_uuid** | **string**| A UUID string identifying this License. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\License**](../Model/License.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicenseSummaryRetrieve()`

```php
enterpriseLicenseSummaryRetrieve($cached): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseSummary
```



Get the total license status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$cached = true; // bool

try {
    $result = $apiInstance->enterpriseLicenseSummaryRetrieve($cached);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseSummaryRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **cached** | **bool**|  | [optional] [default to true] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseSummary**](../Model/LicenseSummary.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicenseUpdate()`

```php
enterpriseLicenseUpdate($license_uuid, $license_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\License
```



License Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$license_uuid = 'license_uuid_example'; // string | A UUID string identifying this License.
$license_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseRequest

try {
    $result = $apiInstance->enterpriseLicenseUpdate($license_uuid, $license_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **license_uuid** | **string**| A UUID string identifying this License. | |
| **license_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LicenseRequest**](../Model/LicenseRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\License**](../Model/License.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `enterpriseLicenseUsedByList()`

```php
enterpriseLicenseUsedByList($license_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EnterpriseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$license_uuid = 'license_uuid_example'; // string | A UUID string identifying this License.

try {
    $result = $apiInstance->enterpriseLicenseUsedByList($license_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->enterpriseLicenseUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **license_uuid** | **string**| A UUID string identifying this License. | |

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
