# OCA\AuthentikAccessSync\Vendor\Authentik\AdminApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**adminAppsList()**](AdminApi.md#adminAppsList) | **GET** /admin/apps/ |  |
| [**adminFileCreate()**](AdminApi.md#adminFileCreate) | **POST** /admin/file/ |  |
| [**adminFileDestroy()**](AdminApi.md#adminFileDestroy) | **DELETE** /admin/file/ |  |
| [**adminFileList()**](AdminApi.md#adminFileList) | **GET** /admin/file/ |  |
| [**adminFileUsedByList()**](AdminApi.md#adminFileUsedByList) | **GET** /admin/file/used_by/ |  |
| [**adminModelsList()**](AdminApi.md#adminModelsList) | **GET** /admin/models/ |  |
| [**adminSettingsPartialUpdate()**](AdminApi.md#adminSettingsPartialUpdate) | **PATCH** /admin/settings/ |  |
| [**adminSettingsRetrieve()**](AdminApi.md#adminSettingsRetrieve) | **GET** /admin/settings/ |  |
| [**adminSettingsUpdate()**](AdminApi.md#adminSettingsUpdate) | **PUT** /admin/settings/ |  |
| [**adminSystemCreate()**](AdminApi.md#adminSystemCreate) | **POST** /admin/system/ |  |
| [**adminSystemRetrieve()**](AdminApi.md#adminSystemRetrieve) | **GET** /admin/system/ |  |
| [**adminVersionHistoryList()**](AdminApi.md#adminVersionHistoryList) | **GET** /admin/version/history/ |  |
| [**adminVersionHistoryRetrieve()**](AdminApi.md#adminVersionHistoryRetrieve) | **GET** /admin/version/history/{id}/ |  |
| [**adminVersionRetrieve()**](AdminApi.md#adminVersionRetrieve) | **GET** /admin/version/ |  |


## `adminAppsList()`

```php
adminAppsList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\App[]
```



Read-only view list all installed apps

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->adminAppsList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminAppsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\App[]**](../Model/App.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminFileCreate()`

```php
adminFileCreate($file, $name, $usage)
```



Upload file to storage backend.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$file = '/path/to/file.txt'; // \SplFileObject
$name = 'name_example'; // string
$usage = 'media'; // string

try {
    $apiInstance->adminFileCreate($file, $name, $usage);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminFileCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **file** | **\SplFileObject****\SplFileObject**|  | |
| **name** | **string**|  | [optional] |
| **usage** | **string**|  | [optional] [default to &#39;media&#39;] |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `multipart/form-data`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminFileDestroy()`

```php
adminFileDestroy($name, $usage)
```



Delete file from storage backend.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$usage = 'media'; // string

try {
    $apiInstance->adminFileDestroy($name, $usage);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminFileDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **usage** | **string**|  | [optional] [default to &#39;media&#39;] |

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

## `adminFileList()`

```php
adminFileList($manageable_only, $search, $usage): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FileList[]
```



List files from storage backend.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$manageable_only = false; // bool
$search = 'search_example'; // string | A search term.
$usage = 'media'; // string

try {
    $result = $apiInstance->adminFileList($manageable_only, $search, $usage);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminFileList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **manageable_only** | **bool**|  | [optional] [default to false] |
| **search** | **string**| A search term. | [optional] |
| **usage** | **string**|  | [optional] [default to &#39;media&#39;] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FileList[]**](../Model/FileList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminFileUsedByList()`

```php
adminFileUsedByList($name): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string

try {
    $result = $apiInstance->adminFileUsedByList($name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminFileUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |

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

## `adminModelsList()`

```php
adminModelsList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\App[]
```



Read-only view list all installed models

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->adminModelsList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminModelsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\App[]**](../Model/App.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminSettingsPartialUpdate()`

```php
adminSettingsPartialUpdate($patched_settings_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Settings
```



Settings view

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$patched_settings_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSettingsRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSettingsRequest

try {
    $result = $apiInstance->adminSettingsPartialUpdate($patched_settings_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminSettingsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **patched_settings_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSettingsRequest**](../Model/PatchedSettingsRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Settings**](../Model/Settings.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminSettingsRetrieve()`

```php
adminSettingsRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Settings
```



Settings view

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->adminSettingsRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminSettingsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Settings**](../Model/Settings.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminSettingsUpdate()`

```php
adminSettingsUpdate($settings_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Settings
```



Settings view

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$settings_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SettingsRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SettingsRequest

try {
    $result = $apiInstance->adminSettingsUpdate($settings_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminSettingsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **settings_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SettingsRequest**](../Model/SettingsRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Settings**](../Model/Settings.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminSystemCreate()`

```php
adminSystemCreate(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SystemInfo
```



Get system information.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->adminSystemCreate();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminSystemCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SystemInfo**](../Model/SystemInfo.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminSystemRetrieve()`

```php
adminSystemRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SystemInfo
```



Get system information.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->adminSystemRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminSystemRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SystemInfo**](../Model/SystemInfo.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminVersionHistoryList()`

```php
adminVersionHistoryList($build, $ordering, $search, $version): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\VersionHistory[]
```



VersionHistory Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$build = 'build_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$search = 'search_example'; // string | A search term.
$version = 'version_example'; // string

try {
    $result = $apiInstance->adminVersionHistoryList($build, $ordering, $search, $version);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminVersionHistoryList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **build** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **version** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\VersionHistory[]**](../Model/VersionHistory.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminVersionHistoryRetrieve()`

```php
adminVersionHistoryRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\VersionHistory
```



VersionHistory Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Version history.

try {
    $result = $apiInstance->adminVersionHistoryRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminVersionHistoryRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Version history. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\VersionHistory**](../Model/VersionHistory.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `adminVersionRetrieve()`

```php
adminVersionRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Version
```



Get running and latest version.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->adminVersionRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->adminVersionRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Version**](../Model/Version.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
