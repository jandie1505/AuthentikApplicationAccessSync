# OCA\AuthentikAccessSync\Vendor\Authentik\AuthenticatorsApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**authenticatorsAdminAllList()**](AuthenticatorsApi.md#authenticatorsAdminAllList) | **GET** /authenticators/admin/all/ |  |
| [**authenticatorsAdminDuoCreate()**](AuthenticatorsApi.md#authenticatorsAdminDuoCreate) | **POST** /authenticators/admin/duo/ |  |
| [**authenticatorsAdminDuoDestroy()**](AuthenticatorsApi.md#authenticatorsAdminDuoDestroy) | **DELETE** /authenticators/admin/duo/{id}/ |  |
| [**authenticatorsAdminDuoList()**](AuthenticatorsApi.md#authenticatorsAdminDuoList) | **GET** /authenticators/admin/duo/ |  |
| [**authenticatorsAdminDuoPartialUpdate()**](AuthenticatorsApi.md#authenticatorsAdminDuoPartialUpdate) | **PATCH** /authenticators/admin/duo/{id}/ |  |
| [**authenticatorsAdminDuoRetrieve()**](AuthenticatorsApi.md#authenticatorsAdminDuoRetrieve) | **GET** /authenticators/admin/duo/{id}/ |  |
| [**authenticatorsAdminDuoUpdate()**](AuthenticatorsApi.md#authenticatorsAdminDuoUpdate) | **PUT** /authenticators/admin/duo/{id}/ |  |
| [**authenticatorsAdminEmailCreate()**](AuthenticatorsApi.md#authenticatorsAdminEmailCreate) | **POST** /authenticators/admin/email/ |  |
| [**authenticatorsAdminEmailDestroy()**](AuthenticatorsApi.md#authenticatorsAdminEmailDestroy) | **DELETE** /authenticators/admin/email/{id}/ |  |
| [**authenticatorsAdminEmailList()**](AuthenticatorsApi.md#authenticatorsAdminEmailList) | **GET** /authenticators/admin/email/ |  |
| [**authenticatorsAdminEmailPartialUpdate()**](AuthenticatorsApi.md#authenticatorsAdminEmailPartialUpdate) | **PATCH** /authenticators/admin/email/{id}/ |  |
| [**authenticatorsAdminEmailRetrieve()**](AuthenticatorsApi.md#authenticatorsAdminEmailRetrieve) | **GET** /authenticators/admin/email/{id}/ |  |
| [**authenticatorsAdminEmailUpdate()**](AuthenticatorsApi.md#authenticatorsAdminEmailUpdate) | **PUT** /authenticators/admin/email/{id}/ |  |
| [**authenticatorsAdminEndpointCreate()**](AuthenticatorsApi.md#authenticatorsAdminEndpointCreate) | **POST** /authenticators/admin/endpoint/ |  |
| [**authenticatorsAdminEndpointDestroy()**](AuthenticatorsApi.md#authenticatorsAdminEndpointDestroy) | **DELETE** /authenticators/admin/endpoint/{uuid}/ |  |
| [**authenticatorsAdminEndpointList()**](AuthenticatorsApi.md#authenticatorsAdminEndpointList) | **GET** /authenticators/admin/endpoint/ |  |
| [**authenticatorsAdminEndpointPartialUpdate()**](AuthenticatorsApi.md#authenticatorsAdminEndpointPartialUpdate) | **PATCH** /authenticators/admin/endpoint/{uuid}/ |  |
| [**authenticatorsAdminEndpointRetrieve()**](AuthenticatorsApi.md#authenticatorsAdminEndpointRetrieve) | **GET** /authenticators/admin/endpoint/{uuid}/ |  |
| [**authenticatorsAdminEndpointUpdate()**](AuthenticatorsApi.md#authenticatorsAdminEndpointUpdate) | **PUT** /authenticators/admin/endpoint/{uuid}/ |  |
| [**authenticatorsAdminSmsCreate()**](AuthenticatorsApi.md#authenticatorsAdminSmsCreate) | **POST** /authenticators/admin/sms/ |  |
| [**authenticatorsAdminSmsDestroy()**](AuthenticatorsApi.md#authenticatorsAdminSmsDestroy) | **DELETE** /authenticators/admin/sms/{id}/ |  |
| [**authenticatorsAdminSmsList()**](AuthenticatorsApi.md#authenticatorsAdminSmsList) | **GET** /authenticators/admin/sms/ |  |
| [**authenticatorsAdminSmsPartialUpdate()**](AuthenticatorsApi.md#authenticatorsAdminSmsPartialUpdate) | **PATCH** /authenticators/admin/sms/{id}/ |  |
| [**authenticatorsAdminSmsRetrieve()**](AuthenticatorsApi.md#authenticatorsAdminSmsRetrieve) | **GET** /authenticators/admin/sms/{id}/ |  |
| [**authenticatorsAdminSmsUpdate()**](AuthenticatorsApi.md#authenticatorsAdminSmsUpdate) | **PUT** /authenticators/admin/sms/{id}/ |  |
| [**authenticatorsAdminStaticCreate()**](AuthenticatorsApi.md#authenticatorsAdminStaticCreate) | **POST** /authenticators/admin/static/ |  |
| [**authenticatorsAdminStaticDestroy()**](AuthenticatorsApi.md#authenticatorsAdminStaticDestroy) | **DELETE** /authenticators/admin/static/{id}/ |  |
| [**authenticatorsAdminStaticList()**](AuthenticatorsApi.md#authenticatorsAdminStaticList) | **GET** /authenticators/admin/static/ |  |
| [**authenticatorsAdminStaticPartialUpdate()**](AuthenticatorsApi.md#authenticatorsAdminStaticPartialUpdate) | **PATCH** /authenticators/admin/static/{id}/ |  |
| [**authenticatorsAdminStaticRetrieve()**](AuthenticatorsApi.md#authenticatorsAdminStaticRetrieve) | **GET** /authenticators/admin/static/{id}/ |  |
| [**authenticatorsAdminStaticUpdate()**](AuthenticatorsApi.md#authenticatorsAdminStaticUpdate) | **PUT** /authenticators/admin/static/{id}/ |  |
| [**authenticatorsAdminTotpCreate()**](AuthenticatorsApi.md#authenticatorsAdminTotpCreate) | **POST** /authenticators/admin/totp/ |  |
| [**authenticatorsAdminTotpDestroy()**](AuthenticatorsApi.md#authenticatorsAdminTotpDestroy) | **DELETE** /authenticators/admin/totp/{id}/ |  |
| [**authenticatorsAdminTotpList()**](AuthenticatorsApi.md#authenticatorsAdminTotpList) | **GET** /authenticators/admin/totp/ |  |
| [**authenticatorsAdminTotpPartialUpdate()**](AuthenticatorsApi.md#authenticatorsAdminTotpPartialUpdate) | **PATCH** /authenticators/admin/totp/{id}/ |  |
| [**authenticatorsAdminTotpRetrieve()**](AuthenticatorsApi.md#authenticatorsAdminTotpRetrieve) | **GET** /authenticators/admin/totp/{id}/ |  |
| [**authenticatorsAdminTotpUpdate()**](AuthenticatorsApi.md#authenticatorsAdminTotpUpdate) | **PUT** /authenticators/admin/totp/{id}/ |  |
| [**authenticatorsAdminWebauthnCreate()**](AuthenticatorsApi.md#authenticatorsAdminWebauthnCreate) | **POST** /authenticators/admin/webauthn/ |  |
| [**authenticatorsAdminWebauthnDestroy()**](AuthenticatorsApi.md#authenticatorsAdminWebauthnDestroy) | **DELETE** /authenticators/admin/webauthn/{id}/ |  |
| [**authenticatorsAdminWebauthnList()**](AuthenticatorsApi.md#authenticatorsAdminWebauthnList) | **GET** /authenticators/admin/webauthn/ |  |
| [**authenticatorsAdminWebauthnPartialUpdate()**](AuthenticatorsApi.md#authenticatorsAdminWebauthnPartialUpdate) | **PATCH** /authenticators/admin/webauthn/{id}/ |  |
| [**authenticatorsAdminWebauthnRetrieve()**](AuthenticatorsApi.md#authenticatorsAdminWebauthnRetrieve) | **GET** /authenticators/admin/webauthn/{id}/ |  |
| [**authenticatorsAdminWebauthnUpdate()**](AuthenticatorsApi.md#authenticatorsAdminWebauthnUpdate) | **PUT** /authenticators/admin/webauthn/{id}/ |  |
| [**authenticatorsAllList()**](AuthenticatorsApi.md#authenticatorsAllList) | **GET** /authenticators/all/ |  |
| [**authenticatorsDuoDestroy()**](AuthenticatorsApi.md#authenticatorsDuoDestroy) | **DELETE** /authenticators/duo/{id}/ |  |
| [**authenticatorsDuoList()**](AuthenticatorsApi.md#authenticatorsDuoList) | **GET** /authenticators/duo/ |  |
| [**authenticatorsDuoPartialUpdate()**](AuthenticatorsApi.md#authenticatorsDuoPartialUpdate) | **PATCH** /authenticators/duo/{id}/ |  |
| [**authenticatorsDuoRetrieve()**](AuthenticatorsApi.md#authenticatorsDuoRetrieve) | **GET** /authenticators/duo/{id}/ |  |
| [**authenticatorsDuoUpdate()**](AuthenticatorsApi.md#authenticatorsDuoUpdate) | **PUT** /authenticators/duo/{id}/ |  |
| [**authenticatorsDuoUsedByList()**](AuthenticatorsApi.md#authenticatorsDuoUsedByList) | **GET** /authenticators/duo/{id}/used_by/ |  |
| [**authenticatorsEmailDestroy()**](AuthenticatorsApi.md#authenticatorsEmailDestroy) | **DELETE** /authenticators/email/{id}/ |  |
| [**authenticatorsEmailList()**](AuthenticatorsApi.md#authenticatorsEmailList) | **GET** /authenticators/email/ |  |
| [**authenticatorsEmailPartialUpdate()**](AuthenticatorsApi.md#authenticatorsEmailPartialUpdate) | **PATCH** /authenticators/email/{id}/ |  |
| [**authenticatorsEmailRetrieve()**](AuthenticatorsApi.md#authenticatorsEmailRetrieve) | **GET** /authenticators/email/{id}/ |  |
| [**authenticatorsEmailUpdate()**](AuthenticatorsApi.md#authenticatorsEmailUpdate) | **PUT** /authenticators/email/{id}/ |  |
| [**authenticatorsEmailUsedByList()**](AuthenticatorsApi.md#authenticatorsEmailUsedByList) | **GET** /authenticators/email/{id}/used_by/ |  |
| [**authenticatorsEndpointList()**](AuthenticatorsApi.md#authenticatorsEndpointList) | **GET** /authenticators/endpoint/ |  |
| [**authenticatorsEndpointRetrieve()**](AuthenticatorsApi.md#authenticatorsEndpointRetrieve) | **GET** /authenticators/endpoint/{uuid}/ |  |
| [**authenticatorsEndpointUsedByList()**](AuthenticatorsApi.md#authenticatorsEndpointUsedByList) | **GET** /authenticators/endpoint/{uuid}/used_by/ |  |
| [**authenticatorsSmsDestroy()**](AuthenticatorsApi.md#authenticatorsSmsDestroy) | **DELETE** /authenticators/sms/{id}/ |  |
| [**authenticatorsSmsList()**](AuthenticatorsApi.md#authenticatorsSmsList) | **GET** /authenticators/sms/ |  |
| [**authenticatorsSmsPartialUpdate()**](AuthenticatorsApi.md#authenticatorsSmsPartialUpdate) | **PATCH** /authenticators/sms/{id}/ |  |
| [**authenticatorsSmsRetrieve()**](AuthenticatorsApi.md#authenticatorsSmsRetrieve) | **GET** /authenticators/sms/{id}/ |  |
| [**authenticatorsSmsUpdate()**](AuthenticatorsApi.md#authenticatorsSmsUpdate) | **PUT** /authenticators/sms/{id}/ |  |
| [**authenticatorsSmsUsedByList()**](AuthenticatorsApi.md#authenticatorsSmsUsedByList) | **GET** /authenticators/sms/{id}/used_by/ |  |
| [**authenticatorsStaticDestroy()**](AuthenticatorsApi.md#authenticatorsStaticDestroy) | **DELETE** /authenticators/static/{id}/ |  |
| [**authenticatorsStaticList()**](AuthenticatorsApi.md#authenticatorsStaticList) | **GET** /authenticators/static/ |  |
| [**authenticatorsStaticPartialUpdate()**](AuthenticatorsApi.md#authenticatorsStaticPartialUpdate) | **PATCH** /authenticators/static/{id}/ |  |
| [**authenticatorsStaticRetrieve()**](AuthenticatorsApi.md#authenticatorsStaticRetrieve) | **GET** /authenticators/static/{id}/ |  |
| [**authenticatorsStaticUpdate()**](AuthenticatorsApi.md#authenticatorsStaticUpdate) | **PUT** /authenticators/static/{id}/ |  |
| [**authenticatorsStaticUsedByList()**](AuthenticatorsApi.md#authenticatorsStaticUsedByList) | **GET** /authenticators/static/{id}/used_by/ |  |
| [**authenticatorsTotpDestroy()**](AuthenticatorsApi.md#authenticatorsTotpDestroy) | **DELETE** /authenticators/totp/{id}/ |  |
| [**authenticatorsTotpList()**](AuthenticatorsApi.md#authenticatorsTotpList) | **GET** /authenticators/totp/ |  |
| [**authenticatorsTotpPartialUpdate()**](AuthenticatorsApi.md#authenticatorsTotpPartialUpdate) | **PATCH** /authenticators/totp/{id}/ |  |
| [**authenticatorsTotpRetrieve()**](AuthenticatorsApi.md#authenticatorsTotpRetrieve) | **GET** /authenticators/totp/{id}/ |  |
| [**authenticatorsTotpUpdate()**](AuthenticatorsApi.md#authenticatorsTotpUpdate) | **PUT** /authenticators/totp/{id}/ |  |
| [**authenticatorsTotpUsedByList()**](AuthenticatorsApi.md#authenticatorsTotpUsedByList) | **GET** /authenticators/totp/{id}/used_by/ |  |
| [**authenticatorsWebauthnDestroy()**](AuthenticatorsApi.md#authenticatorsWebauthnDestroy) | **DELETE** /authenticators/webauthn/{id}/ |  |
| [**authenticatorsWebauthnList()**](AuthenticatorsApi.md#authenticatorsWebauthnList) | **GET** /authenticators/webauthn/ |  |
| [**authenticatorsWebauthnPartialUpdate()**](AuthenticatorsApi.md#authenticatorsWebauthnPartialUpdate) | **PATCH** /authenticators/webauthn/{id}/ |  |
| [**authenticatorsWebauthnRetrieve()**](AuthenticatorsApi.md#authenticatorsWebauthnRetrieve) | **GET** /authenticators/webauthn/{id}/ |  |
| [**authenticatorsWebauthnUpdate()**](AuthenticatorsApi.md#authenticatorsWebauthnUpdate) | **PUT** /authenticators/webauthn/{id}/ |  |
| [**authenticatorsWebauthnUsedByList()**](AuthenticatorsApi.md#authenticatorsWebauthnUsedByList) | **GET** /authenticators/webauthn/{id}/used_by/ |  |


## `authenticatorsAdminAllList()`

```php
authenticatorsAdminAllList($user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Device[]
```



Get all devices for current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user = 56; // int

try {
    $result = $apiInstance->authenticatorsAdminAllList($user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminAllList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Device[]**](../Model/Device.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminDuoCreate()`

```php
authenticatorsAdminDuoCreate($duo_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice
```



Viewset for Duo authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$duo_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminDuoCreate($duo_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminDuoCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **duo_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest**](../Model/DuoDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice**](../Model/DuoDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminDuoDestroy()`

```php
authenticatorsAdminDuoDestroy($id)
```



Viewset for Duo authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.

try {
    $apiInstance->authenticatorsAdminDuoDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminDuoDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |

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

## `authenticatorsAdminDuoList()`

```php
authenticatorsAdminDuoList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDuoDeviceList
```



Viewset for Duo authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsAdminDuoList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminDuoList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDuoDeviceList**](../Model/PaginatedDuoDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminDuoPartialUpdate()`

```php
authenticatorsAdminDuoPartialUpdate($id, $patched_duo_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice
```



Viewset for Duo authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.
$patched_duo_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDuoDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDuoDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminDuoPartialUpdate($id, $patched_duo_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminDuoPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |
| **patched_duo_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDuoDeviceRequest**](../Model/PatchedDuoDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice**](../Model/DuoDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminDuoRetrieve()`

```php
authenticatorsAdminDuoRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice
```



Viewset for Duo authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.

try {
    $result = $apiInstance->authenticatorsAdminDuoRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminDuoRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice**](../Model/DuoDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminDuoUpdate()`

```php
authenticatorsAdminDuoUpdate($id, $duo_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice
```



Viewset for Duo authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.
$duo_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminDuoUpdate($id, $duo_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminDuoUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |
| **duo_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest**](../Model/DuoDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice**](../Model/DuoDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEmailCreate()`

```php
authenticatorsAdminEmailCreate($email_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice
```



Viewset for email authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$email_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminEmailCreate($email_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEmailCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **email_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest**](../Model/EmailDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice**](../Model/EmailDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEmailDestroy()`

```php
authenticatorsAdminEmailDestroy($id)
```



Viewset for email authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.

try {
    $apiInstance->authenticatorsAdminEmailDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEmailDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |

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

## `authenticatorsAdminEmailList()`

```php
authenticatorsAdminEmailList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEmailDeviceList
```



Viewset for email authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsAdminEmailList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEmailList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEmailDeviceList**](../Model/PaginatedEmailDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEmailPartialUpdate()`

```php
authenticatorsAdminEmailPartialUpdate($id, $patched_email_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice
```



Viewset for email authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.
$patched_email_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminEmailPartialUpdate($id, $patched_email_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEmailPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |
| **patched_email_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailDeviceRequest**](../Model/PatchedEmailDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice**](../Model/EmailDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEmailRetrieve()`

```php
authenticatorsAdminEmailRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice
```



Viewset for email authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.

try {
    $result = $apiInstance->authenticatorsAdminEmailRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEmailRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice**](../Model/EmailDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEmailUpdate()`

```php
authenticatorsAdminEmailUpdate($id, $email_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice
```



Viewset for email authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.
$email_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminEmailUpdate($id, $email_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEmailUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |
| **email_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest**](../Model/EmailDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice**](../Model/EmailDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEndpointCreate()`

```php
authenticatorsAdminEndpointCreate($google_endpoint_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice
```



Viewset for Endpoint authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$google_endpoint_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminEndpointCreate($google_endpoint_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEndpointCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **google_endpoint_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDeviceRequest**](../Model/GoogleEndpointDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice**](../Model/GoogleEndpointDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEndpointDestroy()`

```php
authenticatorsAdminEndpointDestroy($uuid)
```



Viewset for Endpoint authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Endpoint Device.

try {
    $apiInstance->authenticatorsAdminEndpointDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEndpointDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Endpoint Device. | |

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

## `authenticatorsAdminEndpointList()`

```php
authenticatorsAdminEndpointList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleEndpointDeviceList
```



Viewset for Endpoint authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsAdminEndpointList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEndpointList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleEndpointDeviceList**](../Model/PaginatedGoogleEndpointDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEndpointPartialUpdate()`

```php
authenticatorsAdminEndpointPartialUpdate($uuid, $patched_google_endpoint_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice
```



Viewset for Endpoint authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Endpoint Device.
$patched_google_endpoint_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleEndpointDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleEndpointDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminEndpointPartialUpdate($uuid, $patched_google_endpoint_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEndpointPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Endpoint Device. | |
| **patched_google_endpoint_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGoogleEndpointDeviceRequest**](../Model/PatchedGoogleEndpointDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice**](../Model/GoogleEndpointDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEndpointRetrieve()`

```php
authenticatorsAdminEndpointRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice
```



Viewset for Endpoint authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Endpoint Device.

try {
    $result = $apiInstance->authenticatorsAdminEndpointRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEndpointRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Endpoint Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice**](../Model/GoogleEndpointDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminEndpointUpdate()`

```php
authenticatorsAdminEndpointUpdate($uuid, $google_endpoint_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice
```



Viewset for Endpoint authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Endpoint Device.
$google_endpoint_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminEndpointUpdate($uuid, $google_endpoint_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminEndpointUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Endpoint Device. | |
| **google_endpoint_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDeviceRequest**](../Model/GoogleEndpointDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice**](../Model/GoogleEndpointDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminSmsCreate()`

```php
authenticatorsAdminSmsCreate($sms_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice
```



Viewset for sms authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$sms_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminSmsCreate($sms_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminSmsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **sms_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest**](../Model/SMSDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice**](../Model/SMSDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminSmsDestroy()`

```php
authenticatorsAdminSmsDestroy($id)
```



Viewset for sms authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.

try {
    $apiInstance->authenticatorsAdminSmsDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminSmsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |

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

## `authenticatorsAdminSmsList()`

```php
authenticatorsAdminSmsList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSMSDeviceList
```



Viewset for sms authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsAdminSmsList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminSmsList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSMSDeviceList**](../Model/PaginatedSMSDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminSmsPartialUpdate()`

```php
authenticatorsAdminSmsPartialUpdate($id, $patched_sms_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice
```



Viewset for sms authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.
$patched_sms_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSMSDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSMSDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminSmsPartialUpdate($id, $patched_sms_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminSmsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |
| **patched_sms_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSMSDeviceRequest**](../Model/PatchedSMSDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice**](../Model/SMSDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminSmsRetrieve()`

```php
authenticatorsAdminSmsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice
```



Viewset for sms authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.

try {
    $result = $apiInstance->authenticatorsAdminSmsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminSmsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice**](../Model/SMSDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminSmsUpdate()`

```php
authenticatorsAdminSmsUpdate($id, $sms_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice
```



Viewset for sms authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.
$sms_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminSmsUpdate($id, $sms_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminSmsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |
| **sms_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest**](../Model/SMSDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice**](../Model/SMSDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminStaticCreate()`

```php
authenticatorsAdminStaticCreate($static_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice
```



Viewset for static authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$static_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminStaticCreate($static_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminStaticCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **static_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest**](../Model/StaticDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice**](../Model/StaticDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminStaticDestroy()`

```php
authenticatorsAdminStaticDestroy($id)
```



Viewset for static authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.

try {
    $apiInstance->authenticatorsAdminStaticDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminStaticDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |

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

## `authenticatorsAdminStaticList()`

```php
authenticatorsAdminStaticList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedStaticDeviceList
```



Viewset for static authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsAdminStaticList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminStaticList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedStaticDeviceList**](../Model/PaginatedStaticDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminStaticPartialUpdate()`

```php
authenticatorsAdminStaticPartialUpdate($id, $patched_static_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice
```



Viewset for static authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.
$patched_static_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedStaticDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedStaticDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminStaticPartialUpdate($id, $patched_static_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminStaticPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |
| **patched_static_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedStaticDeviceRequest**](../Model/PatchedStaticDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice**](../Model/StaticDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminStaticRetrieve()`

```php
authenticatorsAdminStaticRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice
```



Viewset for static authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.

try {
    $result = $apiInstance->authenticatorsAdminStaticRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminStaticRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice**](../Model/StaticDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminStaticUpdate()`

```php
authenticatorsAdminStaticUpdate($id, $static_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice
```



Viewset for static authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.
$static_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminStaticUpdate($id, $static_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminStaticUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |
| **static_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest**](../Model/StaticDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice**](../Model/StaticDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminTotpCreate()`

```php
authenticatorsAdminTotpCreate($totp_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice
```



Viewset for totp authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$totp_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminTotpCreate($totp_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminTotpCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **totp_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest**](../Model/TOTPDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice**](../Model/TOTPDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminTotpDestroy()`

```php
authenticatorsAdminTotpDestroy($id)
```



Viewset for totp authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.

try {
    $apiInstance->authenticatorsAdminTotpDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminTotpDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |

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

## `authenticatorsAdminTotpList()`

```php
authenticatorsAdminTotpList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTOTPDeviceList
```



Viewset for totp authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsAdminTotpList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminTotpList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTOTPDeviceList**](../Model/PaginatedTOTPDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminTotpPartialUpdate()`

```php
authenticatorsAdminTotpPartialUpdate($id, $patched_totp_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice
```



Viewset for totp authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.
$patched_totp_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTOTPDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTOTPDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminTotpPartialUpdate($id, $patched_totp_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminTotpPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |
| **patched_totp_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTOTPDeviceRequest**](../Model/PatchedTOTPDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice**](../Model/TOTPDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminTotpRetrieve()`

```php
authenticatorsAdminTotpRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice
```



Viewset for totp authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.

try {
    $result = $apiInstance->authenticatorsAdminTotpRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminTotpRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice**](../Model/TOTPDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminTotpUpdate()`

```php
authenticatorsAdminTotpUpdate($id, $totp_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice
```



Viewset for totp authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.
$totp_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminTotpUpdate($id, $totp_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminTotpUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |
| **totp_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest**](../Model/TOTPDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice**](../Model/TOTPDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminWebauthnCreate()`

```php
authenticatorsAdminWebauthnCreate($web_authn_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice
```



Viewset for WebAuthn authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$web_authn_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminWebauthnCreate($web_authn_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminWebauthnCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **web_authn_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest**](../Model/WebAuthnDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice**](../Model/WebAuthnDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminWebauthnDestroy()`

```php
authenticatorsAdminWebauthnDestroy($id)
```



Viewset for WebAuthn authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.

try {
    $apiInstance->authenticatorsAdminWebauthnDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminWebauthnDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |

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

## `authenticatorsAdminWebauthnList()`

```php
authenticatorsAdminWebauthnList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWebAuthnDeviceList
```



Viewset for WebAuthn authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsAdminWebauthnList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminWebauthnList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWebAuthnDeviceList**](../Model/PaginatedWebAuthnDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminWebauthnPartialUpdate()`

```php
authenticatorsAdminWebauthnPartialUpdate($id, $patched_web_authn_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice
```



Viewset for WebAuthn authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.
$patched_web_authn_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWebAuthnDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWebAuthnDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminWebauthnPartialUpdate($id, $patched_web_authn_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminWebauthnPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |
| **patched_web_authn_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWebAuthnDeviceRequest**](../Model/PatchedWebAuthnDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice**](../Model/WebAuthnDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminWebauthnRetrieve()`

```php
authenticatorsAdminWebauthnRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice
```



Viewset for WebAuthn authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.

try {
    $result = $apiInstance->authenticatorsAdminWebauthnRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminWebauthnRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice**](../Model/WebAuthnDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAdminWebauthnUpdate()`

```php
authenticatorsAdminWebauthnUpdate($id, $web_authn_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice
```



Viewset for WebAuthn authenticator devices (for admins)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.
$web_authn_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest

try {
    $result = $apiInstance->authenticatorsAdminWebauthnUpdate($id, $web_authn_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAdminWebauthnUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |
| **web_authn_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest**](../Model/WebAuthnDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice**](../Model/WebAuthnDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsAllList()`

```php
authenticatorsAllList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Device[]
```



Get all devices for current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->authenticatorsAllList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsAllList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Device[]**](../Model/Device.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsDuoDestroy()`

```php
authenticatorsDuoDestroy($id)
```



Viewset for Duo authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.

try {
    $apiInstance->authenticatorsDuoDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsDuoDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |

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

## `authenticatorsDuoList()`

```php
authenticatorsDuoList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDuoDeviceList
```



Viewset for Duo authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsDuoList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsDuoList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDuoDeviceList**](../Model/PaginatedDuoDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsDuoPartialUpdate()`

```php
authenticatorsDuoPartialUpdate($id, $patched_duo_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice
```



Viewset for Duo authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.
$patched_duo_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDuoDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDuoDeviceRequest

try {
    $result = $apiInstance->authenticatorsDuoPartialUpdate($id, $patched_duo_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsDuoPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |
| **patched_duo_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDuoDeviceRequest**](../Model/PatchedDuoDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice**](../Model/DuoDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsDuoRetrieve()`

```php
authenticatorsDuoRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice
```



Viewset for Duo authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.

try {
    $result = $apiInstance->authenticatorsDuoRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsDuoRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice**](../Model/DuoDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsDuoUpdate()`

```php
authenticatorsDuoUpdate($id, $duo_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice
```



Viewset for Duo authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.
$duo_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest

try {
    $result = $apiInstance->authenticatorsDuoUpdate($id, $duo_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsDuoUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |
| **duo_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDeviceRequest**](../Model/DuoDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DuoDevice**](../Model/DuoDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsDuoUsedByList()`

```php
authenticatorsDuoUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Duo Device.

try {
    $result = $apiInstance->authenticatorsDuoUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsDuoUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Duo Device. | |

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

## `authenticatorsEmailDestroy()`

```php
authenticatorsEmailDestroy($id)
```



Viewset for email authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.

try {
    $apiInstance->authenticatorsEmailDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEmailDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |

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

## `authenticatorsEmailList()`

```php
authenticatorsEmailList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEmailDeviceList
```



Viewset for email authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsEmailList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEmailList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEmailDeviceList**](../Model/PaginatedEmailDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsEmailPartialUpdate()`

```php
authenticatorsEmailPartialUpdate($id, $patched_email_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice
```



Viewset for email authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.
$patched_email_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailDeviceRequest

try {
    $result = $apiInstance->authenticatorsEmailPartialUpdate($id, $patched_email_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEmailPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |
| **patched_email_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEmailDeviceRequest**](../Model/PatchedEmailDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice**](../Model/EmailDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsEmailRetrieve()`

```php
authenticatorsEmailRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice
```



Viewset for email authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.

try {
    $result = $apiInstance->authenticatorsEmailRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEmailRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice**](../Model/EmailDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsEmailUpdate()`

```php
authenticatorsEmailUpdate($id, $email_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice
```



Viewset for email authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.
$email_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest

try {
    $result = $apiInstance->authenticatorsEmailUpdate($id, $email_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEmailUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |
| **email_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDeviceRequest**](../Model/EmailDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EmailDevice**](../Model/EmailDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsEmailUsedByList()`

```php
authenticatorsEmailUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Email Device.

try {
    $result = $apiInstance->authenticatorsEmailUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEmailUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Email Device. | |

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

## `authenticatorsEndpointList()`

```php
authenticatorsEndpointList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleEndpointDeviceList
```



Viewset for Endpoint authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsEndpointList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEndpointList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGoogleEndpointDeviceList**](../Model/PaginatedGoogleEndpointDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsEndpointRetrieve()`

```php
authenticatorsEndpointRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice
```



Viewset for Endpoint authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Endpoint Device.

try {
    $result = $apiInstance->authenticatorsEndpointRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEndpointRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Endpoint Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GoogleEndpointDevice**](../Model/GoogleEndpointDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsEndpointUsedByList()`

```php
authenticatorsEndpointUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Endpoint Device.

try {
    $result = $apiInstance->authenticatorsEndpointUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsEndpointUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Endpoint Device. | |

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

## `authenticatorsSmsDestroy()`

```php
authenticatorsSmsDestroy($id)
```



Viewset for sms authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.

try {
    $apiInstance->authenticatorsSmsDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsSmsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |

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

## `authenticatorsSmsList()`

```php
authenticatorsSmsList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSMSDeviceList
```



Viewset for sms authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsSmsList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsSmsList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedSMSDeviceList**](../Model/PaginatedSMSDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsSmsPartialUpdate()`

```php
authenticatorsSmsPartialUpdate($id, $patched_sms_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice
```



Viewset for sms authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.
$patched_sms_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSMSDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSMSDeviceRequest

try {
    $result = $apiInstance->authenticatorsSmsPartialUpdate($id, $patched_sms_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsSmsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |
| **patched_sms_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedSMSDeviceRequest**](../Model/PatchedSMSDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice**](../Model/SMSDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsSmsRetrieve()`

```php
authenticatorsSmsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice
```



Viewset for sms authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.

try {
    $result = $apiInstance->authenticatorsSmsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsSmsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice**](../Model/SMSDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsSmsUpdate()`

```php
authenticatorsSmsUpdate($id, $sms_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice
```



Viewset for sms authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.
$sms_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest

try {
    $result = $apiInstance->authenticatorsSmsUpdate($id, $sms_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsSmsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |
| **sms_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDeviceRequest**](../Model/SMSDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\SMSDevice**](../Model/SMSDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsSmsUsedByList()`

```php
authenticatorsSmsUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this SMS Device.

try {
    $result = $apiInstance->authenticatorsSmsUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsSmsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this SMS Device. | |

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

## `authenticatorsStaticDestroy()`

```php
authenticatorsStaticDestroy($id)
```



Viewset for static authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.

try {
    $apiInstance->authenticatorsStaticDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsStaticDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |

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

## `authenticatorsStaticList()`

```php
authenticatorsStaticList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedStaticDeviceList
```



Viewset for static authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsStaticList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsStaticList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedStaticDeviceList**](../Model/PaginatedStaticDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsStaticPartialUpdate()`

```php
authenticatorsStaticPartialUpdate($id, $patched_static_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice
```



Viewset for static authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.
$patched_static_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedStaticDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedStaticDeviceRequest

try {
    $result = $apiInstance->authenticatorsStaticPartialUpdate($id, $patched_static_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsStaticPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |
| **patched_static_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedStaticDeviceRequest**](../Model/PatchedStaticDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice**](../Model/StaticDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsStaticRetrieve()`

```php
authenticatorsStaticRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice
```



Viewset for static authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.

try {
    $result = $apiInstance->authenticatorsStaticRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsStaticRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice**](../Model/StaticDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsStaticUpdate()`

```php
authenticatorsStaticUpdate($id, $static_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice
```



Viewset for static authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.
$static_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest

try {
    $result = $apiInstance->authenticatorsStaticUpdate($id, $static_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsStaticUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |
| **static_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDeviceRequest**](../Model/StaticDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\StaticDevice**](../Model/StaticDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsStaticUsedByList()`

```php
authenticatorsStaticUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Static Device.

try {
    $result = $apiInstance->authenticatorsStaticUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsStaticUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Static Device. | |

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

## `authenticatorsTotpDestroy()`

```php
authenticatorsTotpDestroy($id)
```



Viewset for totp authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.

try {
    $apiInstance->authenticatorsTotpDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsTotpDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |

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

## `authenticatorsTotpList()`

```php
authenticatorsTotpList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTOTPDeviceList
```



Viewset for totp authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsTotpList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsTotpList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTOTPDeviceList**](../Model/PaginatedTOTPDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsTotpPartialUpdate()`

```php
authenticatorsTotpPartialUpdate($id, $patched_totp_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice
```



Viewset for totp authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.
$patched_totp_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTOTPDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTOTPDeviceRequest

try {
    $result = $apiInstance->authenticatorsTotpPartialUpdate($id, $patched_totp_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsTotpPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |
| **patched_totp_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedTOTPDeviceRequest**](../Model/PatchedTOTPDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice**](../Model/TOTPDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsTotpRetrieve()`

```php
authenticatorsTotpRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice
```



Viewset for totp authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.

try {
    $result = $apiInstance->authenticatorsTotpRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsTotpRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice**](../Model/TOTPDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsTotpUpdate()`

```php
authenticatorsTotpUpdate($id, $totp_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice
```



Viewset for totp authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.
$totp_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest

try {
    $result = $apiInstance->authenticatorsTotpUpdate($id, $totp_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsTotpUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |
| **totp_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDeviceRequest**](../Model/TOTPDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TOTPDevice**](../Model/TOTPDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsTotpUsedByList()`

```php
authenticatorsTotpUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this TOTP Device.

try {
    $result = $apiInstance->authenticatorsTotpUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsTotpUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this TOTP Device. | |

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

## `authenticatorsWebauthnDestroy()`

```php
authenticatorsWebauthnDestroy($id)
```



Viewset for WebAuthn authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.

try {
    $apiInstance->authenticatorsWebauthnDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsWebauthnDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |

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

## `authenticatorsWebauthnList()`

```php
authenticatorsWebauthnList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWebAuthnDeviceList
```



Viewset for WebAuthn authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
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
    $result = $apiInstance->authenticatorsWebauthnList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsWebauthnList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedWebAuthnDeviceList**](../Model/PaginatedWebAuthnDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsWebauthnPartialUpdate()`

```php
authenticatorsWebauthnPartialUpdate($id, $patched_web_authn_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice
```



Viewset for WebAuthn authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.
$patched_web_authn_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWebAuthnDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWebAuthnDeviceRequest

try {
    $result = $apiInstance->authenticatorsWebauthnPartialUpdate($id, $patched_web_authn_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsWebauthnPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |
| **patched_web_authn_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedWebAuthnDeviceRequest**](../Model/PatchedWebAuthnDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice**](../Model/WebAuthnDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsWebauthnRetrieve()`

```php
authenticatorsWebauthnRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice
```



Viewset for WebAuthn authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.

try {
    $result = $apiInstance->authenticatorsWebauthnRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsWebauthnRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice**](../Model/WebAuthnDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsWebauthnUpdate()`

```php
authenticatorsWebauthnUpdate($id, $web_authn_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice
```



Viewset for WebAuthn authenticator devices

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.
$web_authn_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest

try {
    $result = $apiInstance->authenticatorsWebauthnUpdate($id, $web_authn_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsWebauthnUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |
| **web_authn_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDeviceRequest**](../Model/WebAuthnDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\WebAuthnDevice**](../Model/WebAuthnDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `authenticatorsWebauthnUsedByList()`

```php
authenticatorsWebauthnUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\AuthenticatorsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this WebAuthn Device.

try {
    $result = $apiInstance->authenticatorsWebauthnUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AuthenticatorsApi->authenticatorsWebauthnUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this WebAuthn Device. | |

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
