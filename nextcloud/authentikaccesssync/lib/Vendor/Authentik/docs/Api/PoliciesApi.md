# OCA\AuthentikAccessSync\Vendor\Authentik\PoliciesApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**policiesAllCacheClearCreate()**](PoliciesApi.md#policiesAllCacheClearCreate) | **POST** /policies/all/cache_clear/ |  |
| [**policiesAllCacheInfoRetrieve()**](PoliciesApi.md#policiesAllCacheInfoRetrieve) | **GET** /policies/all/cache_info/ |  |
| [**policiesAllDestroy()**](PoliciesApi.md#policiesAllDestroy) | **DELETE** /policies/all/{policy_uuid}/ |  |
| [**policiesAllList()**](PoliciesApi.md#policiesAllList) | **GET** /policies/all/ |  |
| [**policiesAllRetrieve()**](PoliciesApi.md#policiesAllRetrieve) | **GET** /policies/all/{policy_uuid}/ |  |
| [**policiesAllTestCreate()**](PoliciesApi.md#policiesAllTestCreate) | **POST** /policies/all/{policy_uuid}/test/ |  |
| [**policiesAllTypesList()**](PoliciesApi.md#policiesAllTypesList) | **GET** /policies/all/types/ |  |
| [**policiesAllUsedByList()**](PoliciesApi.md#policiesAllUsedByList) | **GET** /policies/all/{policy_uuid}/used_by/ |  |
| [**policiesBindingsCreate()**](PoliciesApi.md#policiesBindingsCreate) | **POST** /policies/bindings/ |  |
| [**policiesBindingsDestroy()**](PoliciesApi.md#policiesBindingsDestroy) | **DELETE** /policies/bindings/{policy_binding_uuid}/ |  |
| [**policiesBindingsList()**](PoliciesApi.md#policiesBindingsList) | **GET** /policies/bindings/ |  |
| [**policiesBindingsPartialUpdate()**](PoliciesApi.md#policiesBindingsPartialUpdate) | **PATCH** /policies/bindings/{policy_binding_uuid}/ |  |
| [**policiesBindingsRetrieve()**](PoliciesApi.md#policiesBindingsRetrieve) | **GET** /policies/bindings/{policy_binding_uuid}/ |  |
| [**policiesBindingsUpdate()**](PoliciesApi.md#policiesBindingsUpdate) | **PUT** /policies/bindings/{policy_binding_uuid}/ |  |
| [**policiesBindingsUsedByList()**](PoliciesApi.md#policiesBindingsUsedByList) | **GET** /policies/bindings/{policy_binding_uuid}/used_by/ |  |
| [**policiesDummyCreate()**](PoliciesApi.md#policiesDummyCreate) | **POST** /policies/dummy/ |  |
| [**policiesDummyDestroy()**](PoliciesApi.md#policiesDummyDestroy) | **DELETE** /policies/dummy/{policy_uuid}/ |  |
| [**policiesDummyList()**](PoliciesApi.md#policiesDummyList) | **GET** /policies/dummy/ |  |
| [**policiesDummyPartialUpdate()**](PoliciesApi.md#policiesDummyPartialUpdate) | **PATCH** /policies/dummy/{policy_uuid}/ |  |
| [**policiesDummyRetrieve()**](PoliciesApi.md#policiesDummyRetrieve) | **GET** /policies/dummy/{policy_uuid}/ |  |
| [**policiesDummyUpdate()**](PoliciesApi.md#policiesDummyUpdate) | **PUT** /policies/dummy/{policy_uuid}/ |  |
| [**policiesDummyUsedByList()**](PoliciesApi.md#policiesDummyUsedByList) | **GET** /policies/dummy/{policy_uuid}/used_by/ |  |
| [**policiesEventMatcherCreate()**](PoliciesApi.md#policiesEventMatcherCreate) | **POST** /policies/event_matcher/ |  |
| [**policiesEventMatcherDestroy()**](PoliciesApi.md#policiesEventMatcherDestroy) | **DELETE** /policies/event_matcher/{policy_uuid}/ |  |
| [**policiesEventMatcherList()**](PoliciesApi.md#policiesEventMatcherList) | **GET** /policies/event_matcher/ |  |
| [**policiesEventMatcherPartialUpdate()**](PoliciesApi.md#policiesEventMatcherPartialUpdate) | **PATCH** /policies/event_matcher/{policy_uuid}/ |  |
| [**policiesEventMatcherRetrieve()**](PoliciesApi.md#policiesEventMatcherRetrieve) | **GET** /policies/event_matcher/{policy_uuid}/ |  |
| [**policiesEventMatcherUpdate()**](PoliciesApi.md#policiesEventMatcherUpdate) | **PUT** /policies/event_matcher/{policy_uuid}/ |  |
| [**policiesEventMatcherUsedByList()**](PoliciesApi.md#policiesEventMatcherUsedByList) | **GET** /policies/event_matcher/{policy_uuid}/used_by/ |  |
| [**policiesExpressionCreate()**](PoliciesApi.md#policiesExpressionCreate) | **POST** /policies/expression/ |  |
| [**policiesExpressionDestroy()**](PoliciesApi.md#policiesExpressionDestroy) | **DELETE** /policies/expression/{policy_uuid}/ |  |
| [**policiesExpressionList()**](PoliciesApi.md#policiesExpressionList) | **GET** /policies/expression/ |  |
| [**policiesExpressionPartialUpdate()**](PoliciesApi.md#policiesExpressionPartialUpdate) | **PATCH** /policies/expression/{policy_uuid}/ |  |
| [**policiesExpressionRetrieve()**](PoliciesApi.md#policiesExpressionRetrieve) | **GET** /policies/expression/{policy_uuid}/ |  |
| [**policiesExpressionUpdate()**](PoliciesApi.md#policiesExpressionUpdate) | **PUT** /policies/expression/{policy_uuid}/ |  |
| [**policiesExpressionUsedByList()**](PoliciesApi.md#policiesExpressionUsedByList) | **GET** /policies/expression/{policy_uuid}/used_by/ |  |
| [**policiesGeoipCreate()**](PoliciesApi.md#policiesGeoipCreate) | **POST** /policies/geoip/ |  |
| [**policiesGeoipDestroy()**](PoliciesApi.md#policiesGeoipDestroy) | **DELETE** /policies/geoip/{policy_uuid}/ |  |
| [**policiesGeoipIso3166List()**](PoliciesApi.md#policiesGeoipIso3166List) | **GET** /policies/geoip_iso3166/ |  |
| [**policiesGeoipList()**](PoliciesApi.md#policiesGeoipList) | **GET** /policies/geoip/ |  |
| [**policiesGeoipPartialUpdate()**](PoliciesApi.md#policiesGeoipPartialUpdate) | **PATCH** /policies/geoip/{policy_uuid}/ |  |
| [**policiesGeoipRetrieve()**](PoliciesApi.md#policiesGeoipRetrieve) | **GET** /policies/geoip/{policy_uuid}/ |  |
| [**policiesGeoipUpdate()**](PoliciesApi.md#policiesGeoipUpdate) | **PUT** /policies/geoip/{policy_uuid}/ |  |
| [**policiesGeoipUsedByList()**](PoliciesApi.md#policiesGeoipUsedByList) | **GET** /policies/geoip/{policy_uuid}/used_by/ |  |
| [**policiesPasswordCreate()**](PoliciesApi.md#policiesPasswordCreate) | **POST** /policies/password/ |  |
| [**policiesPasswordDestroy()**](PoliciesApi.md#policiesPasswordDestroy) | **DELETE** /policies/password/{policy_uuid}/ |  |
| [**policiesPasswordExpiryCreate()**](PoliciesApi.md#policiesPasswordExpiryCreate) | **POST** /policies/password_expiry/ |  |
| [**policiesPasswordExpiryDestroy()**](PoliciesApi.md#policiesPasswordExpiryDestroy) | **DELETE** /policies/password_expiry/{policy_uuid}/ |  |
| [**policiesPasswordExpiryList()**](PoliciesApi.md#policiesPasswordExpiryList) | **GET** /policies/password_expiry/ |  |
| [**policiesPasswordExpiryPartialUpdate()**](PoliciesApi.md#policiesPasswordExpiryPartialUpdate) | **PATCH** /policies/password_expiry/{policy_uuid}/ |  |
| [**policiesPasswordExpiryRetrieve()**](PoliciesApi.md#policiesPasswordExpiryRetrieve) | **GET** /policies/password_expiry/{policy_uuid}/ |  |
| [**policiesPasswordExpiryUpdate()**](PoliciesApi.md#policiesPasswordExpiryUpdate) | **PUT** /policies/password_expiry/{policy_uuid}/ |  |
| [**policiesPasswordExpiryUsedByList()**](PoliciesApi.md#policiesPasswordExpiryUsedByList) | **GET** /policies/password_expiry/{policy_uuid}/used_by/ |  |
| [**policiesPasswordList()**](PoliciesApi.md#policiesPasswordList) | **GET** /policies/password/ |  |
| [**policiesPasswordPartialUpdate()**](PoliciesApi.md#policiesPasswordPartialUpdate) | **PATCH** /policies/password/{policy_uuid}/ |  |
| [**policiesPasswordRetrieve()**](PoliciesApi.md#policiesPasswordRetrieve) | **GET** /policies/password/{policy_uuid}/ |  |
| [**policiesPasswordUpdate()**](PoliciesApi.md#policiesPasswordUpdate) | **PUT** /policies/password/{policy_uuid}/ |  |
| [**policiesPasswordUsedByList()**](PoliciesApi.md#policiesPasswordUsedByList) | **GET** /policies/password/{policy_uuid}/used_by/ |  |
| [**policiesReputationCreate()**](PoliciesApi.md#policiesReputationCreate) | **POST** /policies/reputation/ |  |
| [**policiesReputationDestroy()**](PoliciesApi.md#policiesReputationDestroy) | **DELETE** /policies/reputation/{policy_uuid}/ |  |
| [**policiesReputationList()**](PoliciesApi.md#policiesReputationList) | **GET** /policies/reputation/ |  |
| [**policiesReputationPartialUpdate()**](PoliciesApi.md#policiesReputationPartialUpdate) | **PATCH** /policies/reputation/{policy_uuid}/ |  |
| [**policiesReputationRetrieve()**](PoliciesApi.md#policiesReputationRetrieve) | **GET** /policies/reputation/{policy_uuid}/ |  |
| [**policiesReputationScoresDestroy()**](PoliciesApi.md#policiesReputationScoresDestroy) | **DELETE** /policies/reputation/scores/{reputation_uuid}/ |  |
| [**policiesReputationScoresList()**](PoliciesApi.md#policiesReputationScoresList) | **GET** /policies/reputation/scores/ |  |
| [**policiesReputationScoresRetrieve()**](PoliciesApi.md#policiesReputationScoresRetrieve) | **GET** /policies/reputation/scores/{reputation_uuid}/ |  |
| [**policiesReputationScoresUsedByList()**](PoliciesApi.md#policiesReputationScoresUsedByList) | **GET** /policies/reputation/scores/{reputation_uuid}/used_by/ |  |
| [**policiesReputationUpdate()**](PoliciesApi.md#policiesReputationUpdate) | **PUT** /policies/reputation/{policy_uuid}/ |  |
| [**policiesReputationUsedByList()**](PoliciesApi.md#policiesReputationUsedByList) | **GET** /policies/reputation/{policy_uuid}/used_by/ |  |
| [**policiesUniquePasswordCreate()**](PoliciesApi.md#policiesUniquePasswordCreate) | **POST** /policies/unique_password/ |  |
| [**policiesUniquePasswordDestroy()**](PoliciesApi.md#policiesUniquePasswordDestroy) | **DELETE** /policies/unique_password/{policy_uuid}/ |  |
| [**policiesUniquePasswordList()**](PoliciesApi.md#policiesUniquePasswordList) | **GET** /policies/unique_password/ |  |
| [**policiesUniquePasswordPartialUpdate()**](PoliciesApi.md#policiesUniquePasswordPartialUpdate) | **PATCH** /policies/unique_password/{policy_uuid}/ |  |
| [**policiesUniquePasswordRetrieve()**](PoliciesApi.md#policiesUniquePasswordRetrieve) | **GET** /policies/unique_password/{policy_uuid}/ |  |
| [**policiesUniquePasswordUpdate()**](PoliciesApi.md#policiesUniquePasswordUpdate) | **PUT** /policies/unique_password/{policy_uuid}/ |  |
| [**policiesUniquePasswordUsedByList()**](PoliciesApi.md#policiesUniquePasswordUsedByList) | **GET** /policies/unique_password/{policy_uuid}/used_by/ |  |


## `policiesAllCacheClearCreate()`

```php
policiesAllCacheClearCreate()
```



Clear policy cache

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->policiesAllCacheClearCreate();
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllCacheClearCreate: ', $e->getMessage(), PHP_EOL;
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

## `policiesAllCacheInfoRetrieve()`

```php
policiesAllCacheInfoRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Cache
```



Info about cached policies

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->policiesAllCacheInfoRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllCacheInfoRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Cache**](../Model/Cache.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesAllDestroy()`

```php
policiesAllDestroy($policy_uuid)
```



Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Policy.

try {
    $apiInstance->policiesAllDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Policy. | |

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

## `policiesAllList()`

```php
policiesAllList($bindings__isnull, $ordering, $page, $page_size, $promptstage__isnull, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPolicyList
```



Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$bindings__isnull = True; // bool
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$promptstage__isnull = True; // bool
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->policiesAllList($bindings__isnull, $ordering, $page, $page_size, $promptstage__isnull, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **bindings__isnull** | **bool**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **promptstage__isnull** | **bool**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPolicyList**](../Model/PaginatedPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesAllRetrieve()`

```php
policiesAllRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Policy
```



Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Policy.

try {
    $result = $apiInstance->policiesAllRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Policy**](../Model/Policy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesAllTestCreate()`

```php
policiesAllTestCreate($policy_uuid, $policy_test_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyTestResult
```



Test policy

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Policy.
$policy_test_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyTestRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyTestRequest

try {
    $result = $apiInstance->policiesAllTestCreate($policy_uuid, $policy_test_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllTestCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Policy. | |
| **policy_test_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyTestRequest**](../Model/PolicyTestRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyTestResult**](../Model/PolicyTestResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesAllTypesList()`

```php
policiesAllTypesList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all creatable types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->policiesAllTypesList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllTypesList: ', $e->getMessage(), PHP_EOL;
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

## `policiesAllUsedByList()`

```php
policiesAllUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Policy.

try {
    $result = $apiInstance->policiesAllUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesAllUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Policy. | |

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

## `policiesBindingsCreate()`

```php
policiesBindingsCreate($policy_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBindingRequest

try {
    $result = $apiInstance->policiesBindingsCreate($policy_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesBindingsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBindingRequest**](../Model/PolicyBindingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding**](../Model/PolicyBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesBindingsDestroy()`

```php
policiesBindingsDestroy($policy_binding_uuid)
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Policy Binding.

try {
    $apiInstance->policiesBindingsDestroy($policy_binding_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesBindingsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Policy Binding. | |

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

## `policiesBindingsList()`

```php
policiesBindingsList($enabled, $order, $ordering, $page, $page_size, $policy, $policy__isnull, $search, $target, $target_in, $timeout): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPolicyBindingList
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$enabled = True; // bool
$order = 56; // int
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$policy = 'policy_example'; // string
$policy__isnull = True; // bool
$search = 'search_example'; // string | A search term.
$target = 'target_example'; // string
$target_in = array('target_in_example'); // string[]
$timeout = 56; // int

try {
    $result = $apiInstance->policiesBindingsList($enabled, $order, $ordering, $page, $page_size, $policy, $policy__isnull, $search, $target, $target_in, $timeout);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesBindingsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **enabled** | **bool**|  | [optional] |
| **order** | **int**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **policy** | **string**|  | [optional] |
| **policy__isnull** | **bool**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **target** | **string**|  | [optional] |
| **target_in** | [**string[]**](../Model/string.md)|  | [optional] |
| **timeout** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPolicyBindingList**](../Model/PaginatedPolicyBindingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesBindingsPartialUpdate()`

```php
policiesBindingsPartialUpdate($policy_binding_uuid, $patched_policy_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Policy Binding.
$patched_policy_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPolicyBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPolicyBindingRequest

try {
    $result = $apiInstance->policiesBindingsPartialUpdate($policy_binding_uuid, $patched_policy_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesBindingsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Policy Binding. | |
| **patched_policy_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPolicyBindingRequest**](../Model/PatchedPolicyBindingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding**](../Model/PolicyBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesBindingsRetrieve()`

```php
policiesBindingsRetrieve($policy_binding_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Policy Binding.

try {
    $result = $apiInstance->policiesBindingsRetrieve($policy_binding_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesBindingsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Policy Binding. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding**](../Model/PolicyBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesBindingsUpdate()`

```php
policiesBindingsUpdate($policy_binding_uuid, $policy_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Policy Binding.
$policy_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBindingRequest

try {
    $result = $apiInstance->policiesBindingsUpdate($policy_binding_uuid, $policy_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesBindingsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Policy Binding. | |
| **policy_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBindingRequest**](../Model/PolicyBindingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PolicyBinding**](../Model/PolicyBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesBindingsUsedByList()`

```php
policiesBindingsUsedByList($policy_binding_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Policy Binding.

try {
    $result = $apiInstance->policiesBindingsUsedByList($policy_binding_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesBindingsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Policy Binding. | |

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

## `policiesDummyCreate()`

```php
policiesDummyCreate($dummy_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy
```



Dummy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$dummy_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicyRequest

try {
    $result = $apiInstance->policiesDummyCreate($dummy_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesDummyCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **dummy_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicyRequest**](../Model/DummyPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy**](../Model/DummyPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesDummyDestroy()`

```php
policiesDummyDestroy($policy_uuid)
```



Dummy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Dummy Policy.

try {
    $apiInstance->policiesDummyDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesDummyDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Dummy Policy. | |

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

## `policiesDummyList()`

```php
policiesDummyList($created, $execution_logging, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $result, $search, $wait_max, $wait_min): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDummyPolicyList
```



Dummy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$execution_logging = True; // bool
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$policy_uuid = 'policy_uuid_example'; // string
$result = True; // bool
$search = 'search_example'; // string | A search term.
$wait_max = 56; // int
$wait_min = 56; // int

try {
    $result = $apiInstance->policiesDummyList($created, $execution_logging, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $result, $search, $wait_max, $wait_min);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesDummyList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **created** | **\DateTime**|  | [optional] |
| **execution_logging** | **bool**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **policy_uuid** | **string**|  | [optional] |
| **result** | **bool**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **wait_max** | **int**|  | [optional] |
| **wait_min** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDummyPolicyList**](../Model/PaginatedDummyPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesDummyPartialUpdate()`

```php
policiesDummyPartialUpdate($policy_uuid, $patched_dummy_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy
```



Dummy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Dummy Policy.
$patched_dummy_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDummyPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDummyPolicyRequest

try {
    $result = $apiInstance->policiesDummyPartialUpdate($policy_uuid, $patched_dummy_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesDummyPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Dummy Policy. | |
| **patched_dummy_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDummyPolicyRequest**](../Model/PatchedDummyPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy**](../Model/DummyPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesDummyRetrieve()`

```php
policiesDummyRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy
```



Dummy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Dummy Policy.

try {
    $result = $apiInstance->policiesDummyRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesDummyRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Dummy Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy**](../Model/DummyPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesDummyUpdate()`

```php
policiesDummyUpdate($policy_uuid, $dummy_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy
```



Dummy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Dummy Policy.
$dummy_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicyRequest

try {
    $result = $apiInstance->policiesDummyUpdate($policy_uuid, $dummy_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesDummyUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Dummy Policy. | |
| **dummy_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicyRequest**](../Model/DummyPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DummyPolicy**](../Model/DummyPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesDummyUsedByList()`

```php
policiesDummyUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Dummy Policy.

try {
    $result = $apiInstance->policiesDummyUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesDummyUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Dummy Policy. | |

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

## `policiesEventMatcherCreate()`

```php
policiesEventMatcherCreate($event_matcher_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy
```



Event Matcher Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$event_matcher_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicyRequest

try {
    $result = $apiInstance->policiesEventMatcherCreate($event_matcher_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesEventMatcherCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **event_matcher_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicyRequest**](../Model/EventMatcherPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy**](../Model/EventMatcherPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesEventMatcherDestroy()`

```php
policiesEventMatcherDestroy($policy_uuid)
```



Event Matcher Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Event Matcher Policy.

try {
    $apiInstance->policiesEventMatcherDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesEventMatcherDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Event Matcher Policy. | |

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

## `policiesEventMatcherList()`

```php
policiesEventMatcherList($action, $app, $client_ip, $created, $execution_logging, $last_updated, $model, $name, $ordering, $page, $page_size, $policy_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEventMatcherPolicyList
```



Event Matcher Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$action = 'action_example'; // string | Match created events with this action type. When left empty, all action types will be matched.
$app = 'app_example'; // string
$client_ip = 'client_ip_example'; // string
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$execution_logging = True; // bool
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$model = 'model_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$policy_uuid = 'policy_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->policiesEventMatcherList($action, $app, $client_ip, $created, $execution_logging, $last_updated, $model, $name, $ordering, $page, $page_size, $policy_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesEventMatcherList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **action** | **string**| Match created events with this action type. When left empty, all action types will be matched. | [optional] |
| **app** | **string**|  | [optional] |
| **client_ip** | **string**|  | [optional] |
| **created** | **\DateTime**|  | [optional] |
| **execution_logging** | **bool**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **model** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **policy_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEventMatcherPolicyList**](../Model/PaginatedEventMatcherPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesEventMatcherPartialUpdate()`

```php
policiesEventMatcherPartialUpdate($policy_uuid, $patched_event_matcher_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy
```



Event Matcher Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Event Matcher Policy.
$patched_event_matcher_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEventMatcherPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEventMatcherPolicyRequest

try {
    $result = $apiInstance->policiesEventMatcherPartialUpdate($policy_uuid, $patched_event_matcher_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesEventMatcherPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Event Matcher Policy. | |
| **patched_event_matcher_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEventMatcherPolicyRequest**](../Model/PatchedEventMatcherPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy**](../Model/EventMatcherPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesEventMatcherRetrieve()`

```php
policiesEventMatcherRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy
```



Event Matcher Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Event Matcher Policy.

try {
    $result = $apiInstance->policiesEventMatcherRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesEventMatcherRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Event Matcher Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy**](../Model/EventMatcherPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesEventMatcherUpdate()`

```php
policiesEventMatcherUpdate($policy_uuid, $event_matcher_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy
```



Event Matcher Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Event Matcher Policy.
$event_matcher_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicyRequest

try {
    $result = $apiInstance->policiesEventMatcherUpdate($policy_uuid, $event_matcher_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesEventMatcherUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Event Matcher Policy. | |
| **event_matcher_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicyRequest**](../Model/EventMatcherPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventMatcherPolicy**](../Model/EventMatcherPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesEventMatcherUsedByList()`

```php
policiesEventMatcherUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Event Matcher Policy.

try {
    $result = $apiInstance->policiesEventMatcherUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesEventMatcherUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Event Matcher Policy. | |

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

## `policiesExpressionCreate()`

```php
policiesExpressionCreate($expression_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy
```



Source Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$expression_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicyRequest

try {
    $result = $apiInstance->policiesExpressionCreate($expression_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesExpressionCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **expression_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicyRequest**](../Model/ExpressionPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy**](../Model/ExpressionPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesExpressionDestroy()`

```php
policiesExpressionDestroy($policy_uuid)
```



Source Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Expression Policy.

try {
    $apiInstance->policiesExpressionDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesExpressionDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Expression Policy. | |

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

## `policiesExpressionList()`

```php
policiesExpressionList($created, $execution_logging, $expression, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedExpressionPolicyList
```



Source Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$execution_logging = True; // bool
$expression = 'expression_example'; // string
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$policy_uuid = 'policy_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->policiesExpressionList($created, $execution_logging, $expression, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesExpressionList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **created** | **\DateTime**|  | [optional] |
| **execution_logging** | **bool**|  | [optional] |
| **expression** | **string**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **policy_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedExpressionPolicyList**](../Model/PaginatedExpressionPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesExpressionPartialUpdate()`

```php
policiesExpressionPartialUpdate($policy_uuid, $patched_expression_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy
```



Source Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Expression Policy.
$patched_expression_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedExpressionPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedExpressionPolicyRequest

try {
    $result = $apiInstance->policiesExpressionPartialUpdate($policy_uuid, $patched_expression_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesExpressionPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Expression Policy. | |
| **patched_expression_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedExpressionPolicyRequest**](../Model/PatchedExpressionPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy**](../Model/ExpressionPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesExpressionRetrieve()`

```php
policiesExpressionRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy
```



Source Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Expression Policy.

try {
    $result = $apiInstance->policiesExpressionRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesExpressionRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Expression Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy**](../Model/ExpressionPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesExpressionUpdate()`

```php
policiesExpressionUpdate($policy_uuid, $expression_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy
```



Source Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Expression Policy.
$expression_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicyRequest

try {
    $result = $apiInstance->policiesExpressionUpdate($policy_uuid, $expression_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesExpressionUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Expression Policy. | |
| **expression_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicyRequest**](../Model/ExpressionPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ExpressionPolicy**](../Model/ExpressionPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesExpressionUsedByList()`

```php
policiesExpressionUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Expression Policy.

try {
    $result = $apiInstance->policiesExpressionUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesExpressionUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Expression Policy. | |

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

## `policiesGeoipCreate()`

```php
policiesGeoipCreate($geo_ip_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy
```



GeoIP Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$geo_ip_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicyRequest

try {
    $result = $apiInstance->policiesGeoipCreate($geo_ip_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **geo_ip_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicyRequest**](../Model/GeoIPPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy**](../Model/GeoIPPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesGeoipDestroy()`

```php
policiesGeoipDestroy($policy_uuid)
```



GeoIP Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this GeoIP Policy.

try {
    $apiInstance->policiesGeoipDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this GeoIP Policy. | |

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

## `policiesGeoipIso3166List()`

```php
policiesGeoipIso3166List(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DetailedCountry[]
```



Get all countries in ISO-3166-1

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->policiesGeoipIso3166List();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipIso3166List: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DetailedCountry[]**](../Model/DetailedCountry.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesGeoipList()`

```php
policiesGeoipList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGeoIPPolicyList
```



GeoIP Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
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
    $result = $apiInstance->policiesGeoipList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedGeoIPPolicyList**](../Model/PaginatedGeoIPPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesGeoipPartialUpdate()`

```php
policiesGeoipPartialUpdate($policy_uuid, $patched_geo_ip_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy
```



GeoIP Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this GeoIP Policy.
$patched_geo_ip_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGeoIPPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGeoIPPolicyRequest

try {
    $result = $apiInstance->policiesGeoipPartialUpdate($policy_uuid, $patched_geo_ip_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this GeoIP Policy. | |
| **patched_geo_ip_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedGeoIPPolicyRequest**](../Model/PatchedGeoIPPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy**](../Model/GeoIPPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesGeoipRetrieve()`

```php
policiesGeoipRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy
```



GeoIP Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this GeoIP Policy.

try {
    $result = $apiInstance->policiesGeoipRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this GeoIP Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy**](../Model/GeoIPPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesGeoipUpdate()`

```php
policiesGeoipUpdate($policy_uuid, $geo_ip_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy
```



GeoIP Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this GeoIP Policy.
$geo_ip_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicyRequest

try {
    $result = $apiInstance->policiesGeoipUpdate($policy_uuid, $geo_ip_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this GeoIP Policy. | |
| **geo_ip_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicyRequest**](../Model/GeoIPPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GeoIPPolicy**](../Model/GeoIPPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesGeoipUsedByList()`

```php
policiesGeoipUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this GeoIP Policy.

try {
    $result = $apiInstance->policiesGeoipUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesGeoipUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this GeoIP Policy. | |

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

## `policiesPasswordCreate()`

```php
policiesPasswordCreate($password_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy
```



Password Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$password_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicyRequest

try {
    $result = $apiInstance->policiesPasswordCreate($password_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **password_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicyRequest**](../Model/PasswordPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy**](../Model/PasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordDestroy()`

```php
policiesPasswordDestroy($policy_uuid)
```



Password Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Policy.

try {
    $apiInstance->policiesPasswordDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Policy. | |

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

## `policiesPasswordExpiryCreate()`

```php
policiesPasswordExpiryCreate($password_expiry_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy
```



Password Expiry Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$password_expiry_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicyRequest

try {
    $result = $apiInstance->policiesPasswordExpiryCreate($password_expiry_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordExpiryCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **password_expiry_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicyRequest**](../Model/PasswordExpiryPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy**](../Model/PasswordExpiryPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordExpiryDestroy()`

```php
policiesPasswordExpiryDestroy($policy_uuid)
```



Password Expiry Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Expiry Policy.

try {
    $apiInstance->policiesPasswordExpiryDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordExpiryDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Expiry Policy. | |

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

## `policiesPasswordExpiryList()`

```php
policiesPasswordExpiryList($created, $days, $deny_only, $execution_logging, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPasswordExpiryPolicyList
```



Password Expiry Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$days = 56; // int
$deny_only = True; // bool
$execution_logging = True; // bool
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$policy_uuid = 'policy_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->policiesPasswordExpiryList($created, $days, $deny_only, $execution_logging, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordExpiryList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **created** | **\DateTime**|  | [optional] |
| **days** | **int**|  | [optional] |
| **deny_only** | **bool**|  | [optional] |
| **execution_logging** | **bool**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **policy_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPasswordExpiryPolicyList**](../Model/PaginatedPasswordExpiryPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordExpiryPartialUpdate()`

```php
policiesPasswordExpiryPartialUpdate($policy_uuid, $patched_password_expiry_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy
```



Password Expiry Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Expiry Policy.
$patched_password_expiry_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordExpiryPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordExpiryPolicyRequest

try {
    $result = $apiInstance->policiesPasswordExpiryPartialUpdate($policy_uuid, $patched_password_expiry_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordExpiryPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Expiry Policy. | |
| **patched_password_expiry_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordExpiryPolicyRequest**](../Model/PatchedPasswordExpiryPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy**](../Model/PasswordExpiryPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordExpiryRetrieve()`

```php
policiesPasswordExpiryRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy
```



Password Expiry Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Expiry Policy.

try {
    $result = $apiInstance->policiesPasswordExpiryRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordExpiryRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Expiry Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy**](../Model/PasswordExpiryPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordExpiryUpdate()`

```php
policiesPasswordExpiryUpdate($policy_uuid, $password_expiry_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy
```



Password Expiry Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Expiry Policy.
$password_expiry_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicyRequest

try {
    $result = $apiInstance->policiesPasswordExpiryUpdate($policy_uuid, $password_expiry_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordExpiryUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Expiry Policy. | |
| **password_expiry_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicyRequest**](../Model/PasswordExpiryPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordExpiryPolicy**](../Model/PasswordExpiryPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordExpiryUsedByList()`

```php
policiesPasswordExpiryUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Expiry Policy.

try {
    $result = $apiInstance->policiesPasswordExpiryUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordExpiryUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Expiry Policy. | |

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

## `policiesPasswordList()`

```php
policiesPasswordList($amount_digits, $amount_lowercase, $amount_symbols, $amount_uppercase, $check_have_i_been_pwned, $check_static_rules, $check_zxcvbn, $created, $error_message, $execution_logging, $hibp_allowed_count, $last_updated, $length_min, $name, $ordering, $page, $page_size, $password_field, $policy_uuid, $search, $symbol_charset, $zxcvbn_score_threshold): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPasswordPolicyList
```



Password Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$amount_digits = 56; // int
$amount_lowercase = 56; // int
$amount_symbols = 56; // int
$amount_uppercase = 56; // int
$check_have_i_been_pwned = True; // bool
$check_static_rules = True; // bool
$check_zxcvbn = True; // bool
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$error_message = 'error_message_example'; // string
$execution_logging = True; // bool
$hibp_allowed_count = 56; // int
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$length_min = 56; // int
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$password_field = 'password_field_example'; // string
$policy_uuid = 'policy_uuid_example'; // string
$search = 'search_example'; // string | A search term.
$symbol_charset = 'symbol_charset_example'; // string
$zxcvbn_score_threshold = 56; // int

try {
    $result = $apiInstance->policiesPasswordList($amount_digits, $amount_lowercase, $amount_symbols, $amount_uppercase, $check_have_i_been_pwned, $check_static_rules, $check_zxcvbn, $created, $error_message, $execution_logging, $hibp_allowed_count, $last_updated, $length_min, $name, $ordering, $page, $page_size, $password_field, $policy_uuid, $search, $symbol_charset, $zxcvbn_score_threshold);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **amount_digits** | **int**|  | [optional] |
| **amount_lowercase** | **int**|  | [optional] |
| **amount_symbols** | **int**|  | [optional] |
| **amount_uppercase** | **int**|  | [optional] |
| **check_have_i_been_pwned** | **bool**|  | [optional] |
| **check_static_rules** | **bool**|  | [optional] |
| **check_zxcvbn** | **bool**|  | [optional] |
| **created** | **\DateTime**|  | [optional] |
| **error_message** | **string**|  | [optional] |
| **execution_logging** | **bool**|  | [optional] |
| **hibp_allowed_count** | **int**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **length_min** | **int**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **password_field** | **string**|  | [optional] |
| **policy_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **symbol_charset** | **string**|  | [optional] |
| **zxcvbn_score_threshold** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPasswordPolicyList**](../Model/PaginatedPasswordPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordPartialUpdate()`

```php
policiesPasswordPartialUpdate($policy_uuid, $patched_password_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy
```



Password Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Policy.
$patched_password_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordPolicyRequest

try {
    $result = $apiInstance->policiesPasswordPartialUpdate($policy_uuid, $patched_password_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Policy. | |
| **patched_password_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPasswordPolicyRequest**](../Model/PatchedPasswordPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy**](../Model/PasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordRetrieve()`

```php
policiesPasswordRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy
```



Password Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Policy.

try {
    $result = $apiInstance->policiesPasswordRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy**](../Model/PasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordUpdate()`

```php
policiesPasswordUpdate($policy_uuid, $password_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy
```



Password Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Policy.
$password_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicyRequest

try {
    $result = $apiInstance->policiesPasswordUpdate($policy_uuid, $password_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Policy. | |
| **password_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicyRequest**](../Model/PasswordPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PasswordPolicy**](../Model/PasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesPasswordUsedByList()`

```php
policiesPasswordUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Policy.

try {
    $result = $apiInstance->policiesPasswordUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesPasswordUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Policy. | |

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

## `policiesReputationCreate()`

```php
policiesReputationCreate($reputation_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy
```



Reputation Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$reputation_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicyRequest

try {
    $result = $apiInstance->policiesReputationCreate($reputation_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **reputation_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicyRequest**](../Model/ReputationPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy**](../Model/ReputationPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesReputationDestroy()`

```php
policiesReputationDestroy($policy_uuid)
```



Reputation Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Reputation Policy.

try {
    $apiInstance->policiesReputationDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Reputation Policy. | |

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

## `policiesReputationList()`

```php
policiesReputationList($check_ip, $check_username, $created, $execution_logging, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $search, $threshold): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedReputationPolicyList
```



Reputation Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$check_ip = True; // bool
$check_username = True; // bool
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$execution_logging = True; // bool
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$policy_uuid = 'policy_uuid_example'; // string
$search = 'search_example'; // string | A search term.
$threshold = 56; // int

try {
    $result = $apiInstance->policiesReputationList($check_ip, $check_username, $created, $execution_logging, $last_updated, $name, $ordering, $page, $page_size, $policy_uuid, $search, $threshold);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **check_ip** | **bool**|  | [optional] |
| **check_username** | **bool**|  | [optional] |
| **created** | **\DateTime**|  | [optional] |
| **execution_logging** | **bool**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **policy_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **threshold** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedReputationPolicyList**](../Model/PaginatedReputationPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesReputationPartialUpdate()`

```php
policiesReputationPartialUpdate($policy_uuid, $patched_reputation_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy
```



Reputation Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Reputation Policy.
$patched_reputation_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedReputationPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedReputationPolicyRequest

try {
    $result = $apiInstance->policiesReputationPartialUpdate($policy_uuid, $patched_reputation_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Reputation Policy. | |
| **patched_reputation_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedReputationPolicyRequest**](../Model/PatchedReputationPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy**](../Model/ReputationPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesReputationRetrieve()`

```php
policiesReputationRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy
```



Reputation Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Reputation Policy.

try {
    $result = $apiInstance->policiesReputationRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Reputation Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy**](../Model/ReputationPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesReputationScoresDestroy()`

```php
policiesReputationScoresDestroy($reputation_uuid)
```



Reputation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$reputation_uuid = 'reputation_uuid_example'; // string | A UUID string identifying this Reputation Score.

try {
    $apiInstance->policiesReputationScoresDestroy($reputation_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationScoresDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **reputation_uuid** | **string**| A UUID string identifying this Reputation Score. | |

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

## `policiesReputationScoresList()`

```php
policiesReputationScoresList($identifier, $identifier_in, $ip, $ordering, $page, $page_size, $score, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedReputationList
```



Reputation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string
$identifier_in = array('identifier_in_example'); // string[] | Multiple values may be separated by commas.
$ip = 'ip_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$score = 56; // int
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->policiesReputationScoresList($identifier, $identifier_in, $ip, $ordering, $page, $page_size, $score, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationScoresList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | [optional] |
| **identifier_in** | [**string[]**](../Model/string.md)| Multiple values may be separated by commas. | [optional] |
| **ip** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **score** | **int**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedReputationList**](../Model/PaginatedReputationList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesReputationScoresRetrieve()`

```php
policiesReputationScoresRetrieve($reputation_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Reputation
```



Reputation Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$reputation_uuid = 'reputation_uuid_example'; // string | A UUID string identifying this Reputation Score.

try {
    $result = $apiInstance->policiesReputationScoresRetrieve($reputation_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationScoresRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **reputation_uuid** | **string**| A UUID string identifying this Reputation Score. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Reputation**](../Model/Reputation.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesReputationScoresUsedByList()`

```php
policiesReputationScoresUsedByList($reputation_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$reputation_uuid = 'reputation_uuid_example'; // string | A UUID string identifying this Reputation Score.

try {
    $result = $apiInstance->policiesReputationScoresUsedByList($reputation_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationScoresUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **reputation_uuid** | **string**| A UUID string identifying this Reputation Score. | |

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

## `policiesReputationUpdate()`

```php
policiesReputationUpdate($policy_uuid, $reputation_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy
```



Reputation Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Reputation Policy.
$reputation_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicyRequest

try {
    $result = $apiInstance->policiesReputationUpdate($policy_uuid, $reputation_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Reputation Policy. | |
| **reputation_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicyRequest**](../Model/ReputationPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReputationPolicy**](../Model/ReputationPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesReputationUsedByList()`

```php
policiesReputationUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Reputation Policy.

try {
    $result = $apiInstance->policiesReputationUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesReputationUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Reputation Policy. | |

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

## `policiesUniquePasswordCreate()`

```php
policiesUniquePasswordCreate($unique_password_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy
```



Password Uniqueness Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unique_password_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicyRequest

try {
    $result = $apiInstance->policiesUniquePasswordCreate($unique_password_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesUniquePasswordCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **unique_password_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicyRequest**](../Model/UniquePasswordPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy**](../Model/UniquePasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesUniquePasswordDestroy()`

```php
policiesUniquePasswordDestroy($policy_uuid)
```



Password Uniqueness Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Uniqueness Policy.

try {
    $apiInstance->policiesUniquePasswordDestroy($policy_uuid);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesUniquePasswordDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Uniqueness Policy. | |

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

## `policiesUniquePasswordList()`

```php
policiesUniquePasswordList($created, $execution_logging, $last_updated, $name, $num_historical_passwords, $ordering, $page, $page_size, $password_field, $policy_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUniquePasswordPolicyList
```



Password Uniqueness Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$execution_logging = True; // bool
$last_updated = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$name = 'name_example'; // string
$num_historical_passwords = 56; // int
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$password_field = 'password_field_example'; // string
$policy_uuid = 'policy_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->policiesUniquePasswordList($created, $execution_logging, $last_updated, $name, $num_historical_passwords, $ordering, $page, $page_size, $password_field, $policy_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesUniquePasswordList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **created** | **\DateTime**|  | [optional] |
| **execution_logging** | **bool**|  | [optional] |
| **last_updated** | **\DateTime**|  | [optional] |
| **name** | **string**|  | [optional] |
| **num_historical_passwords** | **int**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **password_field** | **string**|  | [optional] |
| **policy_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedUniquePasswordPolicyList**](../Model/PaginatedUniquePasswordPolicyList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesUniquePasswordPartialUpdate()`

```php
policiesUniquePasswordPartialUpdate($policy_uuid, $patched_unique_password_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy
```



Password Uniqueness Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Uniqueness Policy.
$patched_unique_password_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUniquePasswordPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUniquePasswordPolicyRequest

try {
    $result = $apiInstance->policiesUniquePasswordPartialUpdate($policy_uuid, $patched_unique_password_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesUniquePasswordPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Uniqueness Policy. | |
| **patched_unique_password_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedUniquePasswordPolicyRequest**](../Model/PatchedUniquePasswordPolicyRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy**](../Model/UniquePasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesUniquePasswordRetrieve()`

```php
policiesUniquePasswordRetrieve($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy
```



Password Uniqueness Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Uniqueness Policy.

try {
    $result = $apiInstance->policiesUniquePasswordRetrieve($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesUniquePasswordRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Uniqueness Policy. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy**](../Model/UniquePasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesUniquePasswordUpdate()`

```php
policiesUniquePasswordUpdate($policy_uuid, $unique_password_policy_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy
```



Password Uniqueness Policy Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Uniqueness Policy.
$unique_password_policy_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicyRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicyRequest

try {
    $result = $apiInstance->policiesUniquePasswordUpdate($policy_uuid, $unique_password_policy_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesUniquePasswordUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Uniqueness Policy. | |
| **unique_password_policy_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicyRequest**](../Model/UniquePasswordPolicyRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UniquePasswordPolicy**](../Model/UniquePasswordPolicy.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `policiesUniquePasswordUsedByList()`

```php
policiesUniquePasswordUsedByList($policy_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\PoliciesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_uuid = 'policy_uuid_example'; // string | A UUID string identifying this Password Uniqueness Policy.

try {
    $result = $apiInstance->policiesUniquePasswordUsedByList($policy_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PoliciesApi->policiesUniquePasswordUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_uuid** | **string**| A UUID string identifying this Password Uniqueness Policy. | |

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
