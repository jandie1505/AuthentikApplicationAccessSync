# OCA\AuthentikAccessSync\Vendor\Authentik\FlowsApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**flowsBindingsCreate()**](FlowsApi.md#flowsBindingsCreate) | **POST** /flows/bindings/ |  |
| [**flowsBindingsDestroy()**](FlowsApi.md#flowsBindingsDestroy) | **DELETE** /flows/bindings/{fsb_uuid}/ |  |
| [**flowsBindingsList()**](FlowsApi.md#flowsBindingsList) | **GET** /flows/bindings/ |  |
| [**flowsBindingsPartialUpdate()**](FlowsApi.md#flowsBindingsPartialUpdate) | **PATCH** /flows/bindings/{fsb_uuid}/ |  |
| [**flowsBindingsRetrieve()**](FlowsApi.md#flowsBindingsRetrieve) | **GET** /flows/bindings/{fsb_uuid}/ |  |
| [**flowsBindingsUpdate()**](FlowsApi.md#flowsBindingsUpdate) | **PUT** /flows/bindings/{fsb_uuid}/ |  |
| [**flowsBindingsUsedByList()**](FlowsApi.md#flowsBindingsUsedByList) | **GET** /flows/bindings/{fsb_uuid}/used_by/ |  |
| [**flowsExecutorGet()**](FlowsApi.md#flowsExecutorGet) | **GET** /flows/executor/{flow_slug}/ |  |
| [**flowsExecutorSolve()**](FlowsApi.md#flowsExecutorSolve) | **POST** /flows/executor/{flow_slug}/ |  |
| [**flowsInspectorGet()**](FlowsApi.md#flowsInspectorGet) | **GET** /flows/inspector/{flow_slug}/ |  |
| [**flowsInstancesCacheClearCreate()**](FlowsApi.md#flowsInstancesCacheClearCreate) | **POST** /flows/instances/cache_clear/ |  |
| [**flowsInstancesCacheInfoRetrieve()**](FlowsApi.md#flowsInstancesCacheInfoRetrieve) | **GET** /flows/instances/cache_info/ |  |
| [**flowsInstancesCreate()**](FlowsApi.md#flowsInstancesCreate) | **POST** /flows/instances/ |  |
| [**flowsInstancesDestroy()**](FlowsApi.md#flowsInstancesDestroy) | **DELETE** /flows/instances/{slug}/ |  |
| [**flowsInstancesDiagramRetrieve()**](FlowsApi.md#flowsInstancesDiagramRetrieve) | **GET** /flows/instances/{slug}/diagram/ |  |
| [**flowsInstancesExecuteRetrieve()**](FlowsApi.md#flowsInstancesExecuteRetrieve) | **GET** /flows/instances/{slug}/execute/ |  |
| [**flowsInstancesExportRetrieve()**](FlowsApi.md#flowsInstancesExportRetrieve) | **GET** /flows/instances/{slug}/export/ |  |
| [**flowsInstancesImportCreate()**](FlowsApi.md#flowsInstancesImportCreate) | **POST** /flows/instances/import/ |  |
| [**flowsInstancesList()**](FlowsApi.md#flowsInstancesList) | **GET** /flows/instances/ |  |
| [**flowsInstancesPartialUpdate()**](FlowsApi.md#flowsInstancesPartialUpdate) | **PATCH** /flows/instances/{slug}/ |  |
| [**flowsInstancesRetrieve()**](FlowsApi.md#flowsInstancesRetrieve) | **GET** /flows/instances/{slug}/ |  |
| [**flowsInstancesUpdate()**](FlowsApi.md#flowsInstancesUpdate) | **PUT** /flows/instances/{slug}/ |  |
| [**flowsInstancesUsedByList()**](FlowsApi.md#flowsInstancesUsedByList) | **GET** /flows/instances/{slug}/used_by/ |  |


## `flowsBindingsCreate()`

```php
flowsBindingsCreate($flow_stage_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding
```



FlowStageBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$flow_stage_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBindingRequest

try {
    $result = $apiInstance->flowsBindingsCreate($flow_stage_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsBindingsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **flow_stage_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBindingRequest**](../Model/FlowStageBindingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding**](../Model/FlowStageBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsBindingsDestroy()`

```php
flowsBindingsDestroy($fsb_uuid)
```



FlowStageBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fsb_uuid = 'fsb_uuid_example'; // string | A UUID string identifying this Flow Stage Binding.

try {
    $apiInstance->flowsBindingsDestroy($fsb_uuid);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsBindingsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fsb_uuid** | **string**| A UUID string identifying this Flow Stage Binding. | |

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

## `flowsBindingsList()`

```php
flowsBindingsList($evaluate_on_plan, $fsb_uuid, $invalid_response_action, $order, $ordering, $page, $page_size, $pbm_uuid, $policies, $policy_engine_mode, $re_evaluate_policies, $search, $stage, $target): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedFlowStageBindingList
```



FlowStageBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$evaluate_on_plan = True; // bool
$fsb_uuid = 'fsb_uuid_example'; // string
$invalid_response_action = 'invalid_response_action_example'; // string | Configure how the flow executor should handle an invalid response to a challenge. RETRY returns the error message and a similar challenge to the executor. RESTART restarts the flow from the beginning, and RESTART_WITH_CONTEXT restarts the flow while keeping the current context.
$order = 56; // int
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$pbm_uuid = 'pbm_uuid_example'; // string
$policies = array('policies_example'); // string[]
$policy_engine_mode = 'policy_engine_mode_example'; // string
$re_evaluate_policies = True; // bool
$search = 'search_example'; // string | A search term.
$stage = 'stage_example'; // string
$target = 'target_example'; // string

try {
    $result = $apiInstance->flowsBindingsList($evaluate_on_plan, $fsb_uuid, $invalid_response_action, $order, $ordering, $page, $page_size, $pbm_uuid, $policies, $policy_engine_mode, $re_evaluate_policies, $search, $stage, $target);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsBindingsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **evaluate_on_plan** | **bool**|  | [optional] |
| **fsb_uuid** | **string**|  | [optional] |
| **invalid_response_action** | **string**| Configure how the flow executor should handle an invalid response to a challenge. RETRY returns the error message and a similar challenge to the executor. RESTART restarts the flow from the beginning, and RESTART_WITH_CONTEXT restarts the flow while keeping the current context. | [optional] |
| **order** | **int**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **pbm_uuid** | **string**|  | [optional] |
| **policies** | [**string[]**](../Model/string.md)|  | [optional] |
| **policy_engine_mode** | **string**|  | [optional] |
| **re_evaluate_policies** | **bool**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **stage** | **string**|  | [optional] |
| **target** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedFlowStageBindingList**](../Model/PaginatedFlowStageBindingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsBindingsPartialUpdate()`

```php
flowsBindingsPartialUpdate($fsb_uuid, $patched_flow_stage_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding
```



FlowStageBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fsb_uuid = 'fsb_uuid_example'; // string | A UUID string identifying this Flow Stage Binding.
$patched_flow_stage_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFlowStageBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFlowStageBindingRequest

try {
    $result = $apiInstance->flowsBindingsPartialUpdate($fsb_uuid, $patched_flow_stage_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsBindingsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fsb_uuid** | **string**| A UUID string identifying this Flow Stage Binding. | |
| **patched_flow_stage_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFlowStageBindingRequest**](../Model/PatchedFlowStageBindingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding**](../Model/FlowStageBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsBindingsRetrieve()`

```php
flowsBindingsRetrieve($fsb_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding
```



FlowStageBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fsb_uuid = 'fsb_uuid_example'; // string | A UUID string identifying this Flow Stage Binding.

try {
    $result = $apiInstance->flowsBindingsRetrieve($fsb_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsBindingsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fsb_uuid** | **string**| A UUID string identifying this Flow Stage Binding. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding**](../Model/FlowStageBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsBindingsUpdate()`

```php
flowsBindingsUpdate($fsb_uuid, $flow_stage_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding
```



FlowStageBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fsb_uuid = 'fsb_uuid_example'; // string | A UUID string identifying this Flow Stage Binding.
$flow_stage_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBindingRequest

try {
    $result = $apiInstance->flowsBindingsUpdate($fsb_uuid, $flow_stage_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsBindingsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fsb_uuid** | **string**| A UUID string identifying this Flow Stage Binding. | |
| **flow_stage_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBindingRequest**](../Model/FlowStageBindingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowStageBinding**](../Model/FlowStageBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsBindingsUsedByList()`

```php
flowsBindingsUsedByList($fsb_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fsb_uuid = 'fsb_uuid_example'; // string | A UUID string identifying this Flow Stage Binding.

try {
    $result = $apiInstance->flowsBindingsUsedByList($fsb_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsBindingsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fsb_uuid** | **string**| A UUID string identifying this Flow Stage Binding. | |

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

## `flowsExecutorGet()`

```php
flowsExecutorGet($flow_slug, $query): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ChallengeTypes
```



Get the next pending challenge from the currently active flow.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$flow_slug = 'flow_slug_example'; // string
$query = 'query_example'; // string | Querystring as received

try {
    $result = $apiInstance->flowsExecutorGet($flow_slug, $query);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsExecutorGet: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **flow_slug** | **string**|  | |
| **query** | **string**| Querystring as received | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ChallengeTypes**](../Model/ChallengeTypes.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsExecutorSolve()`

```php
flowsExecutorSolve($flow_slug, $query, $flow_challenge_response_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ChallengeTypes
```



Solve the previously retrieved challenge and advanced to the next stage.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$flow_slug = 'flow_slug_example'; // string
$query = 'query_example'; // string | Querystring as received
$flow_challenge_response_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowChallengeResponseRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowChallengeResponseRequest

try {
    $result = $apiInstance->flowsExecutorSolve($flow_slug, $query, $flow_challenge_response_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsExecutorSolve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **flow_slug** | **string**|  | |
| **query** | **string**| Querystring as received | |
| **flow_challenge_response_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowChallengeResponseRequest**](../Model/FlowChallengeResponseRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ChallengeTypes**](../Model/ChallengeTypes.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInspectorGet()`

```php
flowsInspectorGet($flow_slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowInspection
```



Get current flow state and record it

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$flow_slug = 'flow_slug_example'; // string

try {
    $result = $apiInstance->flowsInspectorGet($flow_slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInspectorGet: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **flow_slug** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowInspection**](../Model/FlowInspection.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesCacheClearCreate()`

```php
flowsInstancesCacheClearCreate()
```



Clear flow cache

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->flowsInstancesCacheClearCreate();
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesCacheClearCreate: ', $e->getMessage(), PHP_EOL;
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

## `flowsInstancesCacheInfoRetrieve()`

```php
flowsInstancesCacheInfoRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Cache
```



Info about cached flows

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->flowsInstancesCacheInfoRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesCacheInfoRetrieve: ', $e->getMessage(), PHP_EOL;
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

## `flowsInstancesCreate()`

```php
flowsInstancesCreate($flow_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow
```



Flow Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$flow_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowRequest

try {
    $result = $apiInstance->flowsInstancesCreate($flow_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **flow_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowRequest**](../Model/FlowRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow**](../Model/Flow.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesDestroy()`

```php
flowsInstancesDestroy($slug)
```



Flow Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $apiInstance->flowsInstancesDestroy($slug);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

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

## `flowsInstancesDiagramRetrieve()`

```php
flowsInstancesDiagramRetrieve($slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowDiagram
```



Return diagram for flow with slug `slug`, in the format used by flowchart.js

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->flowsInstancesDiagramRetrieve($slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesDiagramRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowDiagram**](../Model/FlowDiagram.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesExecuteRetrieve()`

```php
flowsInstancesExecuteRetrieve($slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Link
```



Execute flow for current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->flowsInstancesExecuteRetrieve($slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesExecuteRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Link**](../Model/Link.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesExportRetrieve()`

```php
flowsInstancesExportRetrieve($slug): \SplFileObject
```



Export flow to .yaml file

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->flowsInstancesExportRetrieve($slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesExportRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

### Return type

**\SplFileObject**

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesImportCreate()`

```php
flowsInstancesImportCreate($file, $clear): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowImportResult
```



Import flow from .yaml file

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$file = '/path/to/file.txt'; // \SplFileObject
$clear = false; // bool

try {
    $result = $apiInstance->flowsInstancesImportCreate($file, $clear);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesImportCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **file** | **\SplFileObject****\SplFileObject**|  | [optional] |
| **clear** | **bool**|  | [optional] [default to false] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowImportResult**](../Model/FlowImportResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `multipart/form-data`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesList()`

```php
flowsInstancesList($denied_action, $designation, $flow_uuid, $name, $ordering, $page, $page_size, $search, $slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedFlowList
```



Flow Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$denied_action = 'denied_action_example'; // string | Configure what should happen when a flow denies access to a user.
$designation = 'designation_example'; // string | Decides what this Flow is used for. For example, the Authentication flow is redirect to when an un-authenticated user visits authentik.
$flow_uuid = 'flow_uuid_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->flowsInstancesList($denied_action, $designation, $flow_uuid, $name, $ordering, $page, $page_size, $search, $slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **denied_action** | **string**| Configure what should happen when a flow denies access to a user. | [optional] |
| **designation** | **string**| Decides what this Flow is used for. For example, the Authentication flow is redirect to when an un-authenticated user visits authentik. | [optional] |
| **flow_uuid** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **slug** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedFlowList**](../Model/PaginatedFlowList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesPartialUpdate()`

```php
flowsInstancesPartialUpdate($slug, $patched_flow_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow
```



Flow Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string
$patched_flow_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFlowRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFlowRequest

try {
    $result = $apiInstance->flowsInstancesPartialUpdate($slug, $patched_flow_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |
| **patched_flow_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFlowRequest**](../Model/PatchedFlowRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow**](../Model/Flow.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesRetrieve()`

```php
flowsInstancesRetrieve($slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow
```



Flow Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->flowsInstancesRetrieve($slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow**](../Model/Flow.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesUpdate()`

```php
flowsInstancesUpdate($slug, $flow_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow
```



Flow Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string
$flow_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowRequest

try {
    $result = $apiInstance->flowsInstancesUpdate($slug, $flow_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |
| **flow_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FlowRequest**](../Model/FlowRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Flow**](../Model/Flow.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `flowsInstancesUsedByList()`

```php
flowsInstancesUsedByList($slug): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\FlowsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$slug = 'slug_example'; // string

try {
    $result = $apiInstance->flowsInstancesUsedByList($slug);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlowsApi->flowsInstancesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **slug** | **string**|  | |

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
