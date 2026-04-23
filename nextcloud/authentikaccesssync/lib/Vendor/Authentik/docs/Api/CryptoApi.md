# OCA\AuthentikAccessSync\Vendor\Authentik\CryptoApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**cryptoCertificatekeypairsCreate()**](CryptoApi.md#cryptoCertificatekeypairsCreate) | **POST** /crypto/certificatekeypairs/ |  |
| [**cryptoCertificatekeypairsDestroy()**](CryptoApi.md#cryptoCertificatekeypairsDestroy) | **DELETE** /crypto/certificatekeypairs/{kp_uuid}/ |  |
| [**cryptoCertificatekeypairsGenerateCreate()**](CryptoApi.md#cryptoCertificatekeypairsGenerateCreate) | **POST** /crypto/certificatekeypairs/generate/ |  |
| [**cryptoCertificatekeypairsList()**](CryptoApi.md#cryptoCertificatekeypairsList) | **GET** /crypto/certificatekeypairs/ |  |
| [**cryptoCertificatekeypairsPartialUpdate()**](CryptoApi.md#cryptoCertificatekeypairsPartialUpdate) | **PATCH** /crypto/certificatekeypairs/{kp_uuid}/ |  |
| [**cryptoCertificatekeypairsRetrieve()**](CryptoApi.md#cryptoCertificatekeypairsRetrieve) | **GET** /crypto/certificatekeypairs/{kp_uuid}/ |  |
| [**cryptoCertificatekeypairsUpdate()**](CryptoApi.md#cryptoCertificatekeypairsUpdate) | **PUT** /crypto/certificatekeypairs/{kp_uuid}/ |  |
| [**cryptoCertificatekeypairsUsedByList()**](CryptoApi.md#cryptoCertificatekeypairsUsedByList) | **GET** /crypto/certificatekeypairs/{kp_uuid}/used_by/ |  |
| [**cryptoCertificatekeypairsViewCertificateRetrieve()**](CryptoApi.md#cryptoCertificatekeypairsViewCertificateRetrieve) | **GET** /crypto/certificatekeypairs/{kp_uuid}/view_certificate/ |  |
| [**cryptoCertificatekeypairsViewPrivateKeyRetrieve()**](CryptoApi.md#cryptoCertificatekeypairsViewPrivateKeyRetrieve) | **GET** /crypto/certificatekeypairs/{kp_uuid}/view_private_key/ |  |


## `cryptoCertificatekeypairsCreate()`

```php
cryptoCertificatekeypairsCreate($certificate_key_pair_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair
```



CertificateKeyPair Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$certificate_key_pair_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPairRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPairRequest

try {
    $result = $apiInstance->cryptoCertificatekeypairsCreate($certificate_key_pair_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **certificate_key_pair_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPairRequest**](../Model/CertificateKeyPairRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair**](../Model/CertificateKeyPair.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `cryptoCertificatekeypairsDestroy()`

```php
cryptoCertificatekeypairsDestroy($kp_uuid)
```



CertificateKeyPair Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kp_uuid = 'kp_uuid_example'; // string | A UUID string identifying this Certificate-Key Pair.

try {
    $apiInstance->cryptoCertificatekeypairsDestroy($kp_uuid);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kp_uuid** | **string**| A UUID string identifying this Certificate-Key Pair. | |

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

## `cryptoCertificatekeypairsGenerateCreate()`

```php
cryptoCertificatekeypairsGenerateCreate($certificate_generation_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair
```



Generate a new, self-signed certificate-key pair

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$certificate_generation_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateGenerationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateGenerationRequest

try {
    $result = $apiInstance->cryptoCertificatekeypairsGenerateCreate($certificate_generation_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsGenerateCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **certificate_generation_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateGenerationRequest**](../Model/CertificateGenerationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair**](../Model/CertificateKeyPair.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `cryptoCertificatekeypairsList()`

```php
cryptoCertificatekeypairsList($has_key, $key_type, $managed, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedCertificateKeyPairList
```



CertificateKeyPair Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$has_key = True; // bool | Only return certificate-key pairs with keys
$key_type = array('key_type_example'); // string[] | Filter by key algorithm type (RSA, EC, DSA, etc). Can be specified multiple times (e.g. '?key_type=rsa&key_type=ec')
$managed = 'managed_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->cryptoCertificatekeypairsList($has_key, $key_type, $managed, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **has_key** | **bool**| Only return certificate-key pairs with keys | [optional] |
| **key_type** | [**string[]**](../Model/string.md)| Filter by key algorithm type (RSA, EC, DSA, etc). Can be specified multiple times (e.g. &#39;?key_type&#x3D;rsa&amp;key_type&#x3D;ec&#39;) | [optional] |
| **managed** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedCertificateKeyPairList**](../Model/PaginatedCertificateKeyPairList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `cryptoCertificatekeypairsPartialUpdate()`

```php
cryptoCertificatekeypairsPartialUpdate($kp_uuid, $patched_certificate_key_pair_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair
```



CertificateKeyPair Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kp_uuid = 'kp_uuid_example'; // string | A UUID string identifying this Certificate-Key Pair.
$patched_certificate_key_pair_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedCertificateKeyPairRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedCertificateKeyPairRequest

try {
    $result = $apiInstance->cryptoCertificatekeypairsPartialUpdate($kp_uuid, $patched_certificate_key_pair_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kp_uuid** | **string**| A UUID string identifying this Certificate-Key Pair. | |
| **patched_certificate_key_pair_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedCertificateKeyPairRequest**](../Model/PatchedCertificateKeyPairRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair**](../Model/CertificateKeyPair.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `cryptoCertificatekeypairsRetrieve()`

```php
cryptoCertificatekeypairsRetrieve($kp_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair
```



CertificateKeyPair Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kp_uuid = 'kp_uuid_example'; // string | A UUID string identifying this Certificate-Key Pair.

try {
    $result = $apiInstance->cryptoCertificatekeypairsRetrieve($kp_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kp_uuid** | **string**| A UUID string identifying this Certificate-Key Pair. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair**](../Model/CertificateKeyPair.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `cryptoCertificatekeypairsUpdate()`

```php
cryptoCertificatekeypairsUpdate($kp_uuid, $certificate_key_pair_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair
```



CertificateKeyPair Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kp_uuid = 'kp_uuid_example'; // string | A UUID string identifying this Certificate-Key Pair.
$certificate_key_pair_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPairRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPairRequest

try {
    $result = $apiInstance->cryptoCertificatekeypairsUpdate($kp_uuid, $certificate_key_pair_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kp_uuid** | **string**| A UUID string identifying this Certificate-Key Pair. | |
| **certificate_key_pair_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPairRequest**](../Model/CertificateKeyPairRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateKeyPair**](../Model/CertificateKeyPair.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `cryptoCertificatekeypairsUsedByList()`

```php
cryptoCertificatekeypairsUsedByList($kp_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kp_uuid = 'kp_uuid_example'; // string | A UUID string identifying this Certificate-Key Pair.

try {
    $result = $apiInstance->cryptoCertificatekeypairsUsedByList($kp_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kp_uuid** | **string**| A UUID string identifying this Certificate-Key Pair. | |

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

## `cryptoCertificatekeypairsViewCertificateRetrieve()`

```php
cryptoCertificatekeypairsViewCertificateRetrieve($kp_uuid, $download): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateData
```



Return certificate-key pairs certificate and log access

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kp_uuid = 'kp_uuid_example'; // string | A UUID string identifying this Certificate-Key Pair.
$download = True; // bool

try {
    $result = $apiInstance->cryptoCertificatekeypairsViewCertificateRetrieve($kp_uuid, $download);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsViewCertificateRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kp_uuid** | **string**| A UUID string identifying this Certificate-Key Pair. | |
| **download** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateData**](../Model/CertificateData.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `cryptoCertificatekeypairsViewPrivateKeyRetrieve()`

```php
cryptoCertificatekeypairsViewPrivateKeyRetrieve($kp_uuid, $download): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateData
```



Return certificate-key pairs private key and log access

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\CryptoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kp_uuid = 'kp_uuid_example'; // string | A UUID string identifying this Certificate-Key Pair.
$download = True; // bool

try {
    $result = $apiInstance->cryptoCertificatekeypairsViewPrivateKeyRetrieve($kp_uuid, $download);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CryptoApi->cryptoCertificatekeypairsViewPrivateKeyRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **kp_uuid** | **string**| A UUID string identifying this Certificate-Key Pair. | |
| **download** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\CertificateData**](../Model/CertificateData.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
