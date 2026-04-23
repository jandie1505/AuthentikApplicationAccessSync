# OCA\AuthentikAccessSync\Vendor\Authentik\LifecycleApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**lifecycleIterationsCreate()**](LifecycleApi.md#lifecycleIterationsCreate) | **POST** /lifecycle/iterations/ |  |
| [**lifecycleIterationsLatestRetrieve()**](LifecycleApi.md#lifecycleIterationsLatestRetrieve) | **GET** /lifecycle/iterations/latest/{content_type}/{object_id}/ |  |
| [**lifecycleIterationsListOpen()**](LifecycleApi.md#lifecycleIterationsListOpen) | **GET** /lifecycle/iterations/open/ |  |
| [**lifecycleReviewsCreate()**](LifecycleApi.md#lifecycleReviewsCreate) | **POST** /lifecycle/reviews/ |  |
| [**lifecycleRulesCreate()**](LifecycleApi.md#lifecycleRulesCreate) | **POST** /lifecycle/rules/ |  |
| [**lifecycleRulesDestroy()**](LifecycleApi.md#lifecycleRulesDestroy) | **DELETE** /lifecycle/rules/{id}/ |  |
| [**lifecycleRulesList()**](LifecycleApi.md#lifecycleRulesList) | **GET** /lifecycle/rules/ |  |
| [**lifecycleRulesPartialUpdate()**](LifecycleApi.md#lifecycleRulesPartialUpdate) | **PATCH** /lifecycle/rules/{id}/ |  |
| [**lifecycleRulesRetrieve()**](LifecycleApi.md#lifecycleRulesRetrieve) | **GET** /lifecycle/rules/{id}/ |  |
| [**lifecycleRulesUpdate()**](LifecycleApi.md#lifecycleRulesUpdate) | **PUT** /lifecycle/rules/{id}/ |  |


## `lifecycleIterationsCreate()`

```php
lifecycleIterationsCreate($lifecycle_iteration_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIteration
```



Mixin to validate that a valid enterprise license exists before allowing to save the object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$lifecycle_iteration_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIterationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIterationRequest

try {
    $result = $apiInstance->lifecycleIterationsCreate($lifecycle_iteration_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleIterationsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **lifecycle_iteration_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIterationRequest**](../Model/LifecycleIterationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIteration**](../Model/LifecycleIteration.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleIterationsLatestRetrieve()`

```php
lifecycleIterationsLatestRetrieve($content_type, $object_id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIteration
```



Mixin to validate that a valid enterprise license exists before allowing to save the object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$content_type = 'content_type_example'; // string
$object_id = 'object_id_example'; // string

try {
    $result = $apiInstance->lifecycleIterationsLatestRetrieve($content_type, $object_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleIterationsLatestRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **content_type** | **string**|  | |
| **object_id** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleIteration**](../Model/LifecycleIteration.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleIterationsListOpen()`

```php
lifecycleIterationsListOpen($ordering, $page, $page_size, $search, $user_is_reviewer): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLifecycleIterationList
```



Mixin to validate that a valid enterprise license exists before allowing to save the object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$user_is_reviewer = True; // bool

try {
    $result = $apiInstance->lifecycleIterationsListOpen($ordering, $page, $page_size, $search, $user_is_reviewer);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleIterationsListOpen: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **user_is_reviewer** | **bool**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLifecycleIterationList**](../Model/PaginatedLifecycleIterationList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleReviewsCreate()`

```php
lifecycleReviewsCreate($review_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Review
```



Mixin to validate that a valid enterprise license exists before allowing to save the object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$review_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReviewRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReviewRequest

try {
    $result = $apiInstance->lifecycleReviewsCreate($review_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleReviewsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **review_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ReviewRequest**](../Model/ReviewRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Review**](../Model/Review.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleRulesCreate()`

```php
lifecycleRulesCreate($lifecycle_rule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$lifecycle_rule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRuleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRuleRequest

try {
    $result = $apiInstance->lifecycleRulesCreate($lifecycle_rule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleRulesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **lifecycle_rule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRuleRequest**](../Model/LifecycleRuleRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule**](../Model/LifecycleRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleRulesDestroy()`

```php
lifecycleRulesDestroy($id)
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this lifecycle rule.

try {
    $apiInstance->lifecycleRulesDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleRulesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this lifecycle rule. | |

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

## `lifecycleRulesList()`

```php
lifecycleRulesList($content_type__model, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLifecycleRuleList
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$content_type__model = 'content_type__model_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->lifecycleRulesList($content_type__model, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleRulesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **content_type__model** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedLifecycleRuleList**](../Model/PaginatedLifecycleRuleList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleRulesPartialUpdate()`

```php
lifecycleRulesPartialUpdate($id, $patched_lifecycle_rule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this lifecycle rule.
$patched_lifecycle_rule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLifecycleRuleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLifecycleRuleRequest

try {
    $result = $apiInstance->lifecycleRulesPartialUpdate($id, $patched_lifecycle_rule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleRulesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this lifecycle rule. | |
| **patched_lifecycle_rule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedLifecycleRuleRequest**](../Model/PatchedLifecycleRuleRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule**](../Model/LifecycleRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleRulesRetrieve()`

```php
lifecycleRulesRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this lifecycle rule.

try {
    $result = $apiInstance->lifecycleRulesRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleRulesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this lifecycle rule. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule**](../Model/LifecycleRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `lifecycleRulesUpdate()`

```php
lifecycleRulesUpdate($id, $lifecycle_rule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\LifecycleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this lifecycle rule.
$lifecycle_rule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRuleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRuleRequest

try {
    $result = $apiInstance->lifecycleRulesUpdate($id, $lifecycle_rule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling LifecycleApi->lifecycleRulesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this lifecycle rule. | |
| **lifecycle_rule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRuleRequest**](../Model/LifecycleRuleRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\LifecycleRule**](../Model/LifecycleRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
