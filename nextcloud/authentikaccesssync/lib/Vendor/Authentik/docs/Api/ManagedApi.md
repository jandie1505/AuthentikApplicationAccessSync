# OCA\AuthentikAccessSync\Vendor\Authentik\ManagedApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**managedBlueprintsApplyCreate()**](ManagedApi.md#managedBlueprintsApplyCreate) | **POST** /managed/blueprints/{instance_uuid}/apply/ |  |
| [**managedBlueprintsAvailableList()**](ManagedApi.md#managedBlueprintsAvailableList) | **GET** /managed/blueprints/available/ |  |
| [**managedBlueprintsCreate()**](ManagedApi.md#managedBlueprintsCreate) | **POST** /managed/blueprints/ |  |
| [**managedBlueprintsDestroy()**](ManagedApi.md#managedBlueprintsDestroy) | **DELETE** /managed/blueprints/{instance_uuid}/ |  |
| [**managedBlueprintsList()**](ManagedApi.md#managedBlueprintsList) | **GET** /managed/blueprints/ |  |
| [**managedBlueprintsPartialUpdate()**](ManagedApi.md#managedBlueprintsPartialUpdate) | **PATCH** /managed/blueprints/{instance_uuid}/ |  |
| [**managedBlueprintsRetrieve()**](ManagedApi.md#managedBlueprintsRetrieve) | **GET** /managed/blueprints/{instance_uuid}/ |  |
| [**managedBlueprintsUpdate()**](ManagedApi.md#managedBlueprintsUpdate) | **PUT** /managed/blueprints/{instance_uuid}/ |  |
| [**managedBlueprintsUsedByList()**](ManagedApi.md#managedBlueprintsUsedByList) | **GET** /managed/blueprints/{instance_uuid}/used_by/ |  |


## `managedBlueprintsApplyCreate()`

```php
managedBlueprintsApplyCreate($instance_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance
```



Apply a blueprint

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$instance_uuid = 'instance_uuid_example'; // string | A UUID string identifying this Blueprint Instance.

try {
    $result = $apiInstance->managedBlueprintsApplyCreate($instance_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsApplyCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **instance_uuid** | **string**| A UUID string identifying this Blueprint Instance. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance**](../Model/BlueprintInstance.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `managedBlueprintsAvailableList()`

```php
managedBlueprintsAvailableList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintFile[]
```



Get blueprints

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->managedBlueprintsAvailableList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsAvailableList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintFile[]**](../Model/BlueprintFile.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `managedBlueprintsCreate()`

```php
managedBlueprintsCreate($blueprint_instance_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance
```



Blueprint instances

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$blueprint_instance_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstanceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstanceRequest

try {
    $result = $apiInstance->managedBlueprintsCreate($blueprint_instance_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **blueprint_instance_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstanceRequest**](../Model/BlueprintInstanceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance**](../Model/BlueprintInstance.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `managedBlueprintsDestroy()`

```php
managedBlueprintsDestroy($instance_uuid)
```



Blueprint instances

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$instance_uuid = 'instance_uuid_example'; // string | A UUID string identifying this Blueprint Instance.

try {
    $apiInstance->managedBlueprintsDestroy($instance_uuid);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **instance_uuid** | **string**| A UUID string identifying this Blueprint Instance. | |

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

## `managedBlueprintsList()`

```php
managedBlueprintsList($name, $ordering, $page, $page_size, $path, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedBlueprintInstanceList
```



Blueprint instances

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$path = 'path_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->managedBlueprintsList($name, $ordering, $page, $page_size, $path, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **path** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedBlueprintInstanceList**](../Model/PaginatedBlueprintInstanceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `managedBlueprintsPartialUpdate()`

```php
managedBlueprintsPartialUpdate($instance_uuid, $patched_blueprint_instance_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance
```



Blueprint instances

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$instance_uuid = 'instance_uuid_example'; // string | A UUID string identifying this Blueprint Instance.
$patched_blueprint_instance_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedBlueprintInstanceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedBlueprintInstanceRequest

try {
    $result = $apiInstance->managedBlueprintsPartialUpdate($instance_uuid, $patched_blueprint_instance_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **instance_uuid** | **string**| A UUID string identifying this Blueprint Instance. | |
| **patched_blueprint_instance_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedBlueprintInstanceRequest**](../Model/PatchedBlueprintInstanceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance**](../Model/BlueprintInstance.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `managedBlueprintsRetrieve()`

```php
managedBlueprintsRetrieve($instance_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance
```



Blueprint instances

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$instance_uuid = 'instance_uuid_example'; // string | A UUID string identifying this Blueprint Instance.

try {
    $result = $apiInstance->managedBlueprintsRetrieve($instance_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **instance_uuid** | **string**| A UUID string identifying this Blueprint Instance. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance**](../Model/BlueprintInstance.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `managedBlueprintsUpdate()`

```php
managedBlueprintsUpdate($instance_uuid, $blueprint_instance_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance
```



Blueprint instances

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$instance_uuid = 'instance_uuid_example'; // string | A UUID string identifying this Blueprint Instance.
$blueprint_instance_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstanceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstanceRequest

try {
    $result = $apiInstance->managedBlueprintsUpdate($instance_uuid, $blueprint_instance_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **instance_uuid** | **string**| A UUID string identifying this Blueprint Instance. | |
| **blueprint_instance_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstanceRequest**](../Model/BlueprintInstanceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\BlueprintInstance**](../Model/BlueprintInstance.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `managedBlueprintsUsedByList()`

```php
managedBlueprintsUsedByList($instance_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\ManagedApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$instance_uuid = 'instance_uuid_example'; // string | A UUID string identifying this Blueprint Instance.

try {
    $result = $apiInstance->managedBlueprintsUsedByList($instance_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ManagedApi->managedBlueprintsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **instance_uuid** | **string**| A UUID string identifying this Blueprint Instance. | |

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
