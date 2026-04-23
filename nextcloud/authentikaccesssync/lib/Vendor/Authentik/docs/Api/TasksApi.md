# OCA\AuthentikAccessSync\Vendor\Authentik\TasksApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**tasksSchedulesList()**](TasksApi.md#tasksSchedulesList) | **GET** /tasks/schedules/ |  |
| [**tasksSchedulesPartialUpdate()**](TasksApi.md#tasksSchedulesPartialUpdate) | **PATCH** /tasks/schedules/{id}/ |  |
| [**tasksSchedulesRetrieve()**](TasksApi.md#tasksSchedulesRetrieve) | **GET** /tasks/schedules/{id}/ |  |
| [**tasksSchedulesSendCreate()**](TasksApi.md#tasksSchedulesSendCreate) | **POST** /tasks/schedules/{id}/send/ |  |
| [**tasksSchedulesUpdate()**](TasksApi.md#tasksSchedulesUpdate) | **PUT** /tasks/schedules/{id}/ |  |
| [**tasksTasksList()**](TasksApi.md#tasksTasksList) | **GET** /tasks/tasks/ |  |
| [**tasksTasksRetrieve()**](TasksApi.md#tasksTasksRetrieve) | **GET** /tasks/tasks/{message_id}/ |  |
| [**tasksTasksRetryCreate()**](TasksApi.md#tasksTasksRetryCreate) | **POST** /tasks/tasks/{message_id}/retry/ |  |
| [**tasksTasksStatusRetrieve()**](TasksApi.md#tasksTasksStatusRetrieve) | **GET** /tasks/tasks/status/ |  |
| [**tasksWorkersList()**](TasksApi.md#tasksWorkersList) | **GET** /tasks/workers |  |


## `tasksSchedulesList()`

```php
tasksSchedulesList($actor_name, $ordering, $page, $page_size, $paused, $rel_obj_content_type__app_label, $rel_obj_content_type__model, $rel_obj_id, $rel_obj_id__isnull, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedScheduleList
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$actor_name = 'actor_name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$paused = True; // bool
$rel_obj_content_type__app_label = 'rel_obj_content_type__app_label_example'; // string
$rel_obj_content_type__model = 'rel_obj_content_type__model_example'; // string
$rel_obj_id = 'rel_obj_id_example'; // string
$rel_obj_id__isnull = True; // bool
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->tasksSchedulesList($actor_name, $ordering, $page, $page_size, $paused, $rel_obj_content_type__app_label, $rel_obj_content_type__model, $rel_obj_id, $rel_obj_id__isnull, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksSchedulesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **actor_name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **paused** | **bool**|  | [optional] |
| **rel_obj_content_type__app_label** | **string**|  | [optional] |
| **rel_obj_content_type__model** | **string**|  | [optional] |
| **rel_obj_id** | **string**|  | [optional] |
| **rel_obj_id__isnull** | **bool**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedScheduleList**](../Model/PaginatedScheduleList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `tasksSchedulesPartialUpdate()`

```php
tasksSchedulesPartialUpdate($id, $patched_schedule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Schedule
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Schedule.
$patched_schedule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedScheduleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedScheduleRequest

try {
    $result = $apiInstance->tasksSchedulesPartialUpdate($id, $patched_schedule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksSchedulesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Schedule. | |
| **patched_schedule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedScheduleRequest**](../Model/PatchedScheduleRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Schedule**](../Model/Schedule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `tasksSchedulesRetrieve()`

```php
tasksSchedulesRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Schedule
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Schedule.

try {
    $result = $apiInstance->tasksSchedulesRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksSchedulesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Schedule. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Schedule**](../Model/Schedule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `tasksSchedulesSendCreate()`

```php
tasksSchedulesSendCreate($id)
```



Trigger this schedule now

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Schedule.

try {
    $apiInstance->tasksSchedulesSendCreate($id);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksSchedulesSendCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Schedule. | |

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

## `tasksSchedulesUpdate()`

```php
tasksSchedulesUpdate($id, $schedule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Schedule
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | A UUID string identifying this Schedule.
$schedule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScheduleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScheduleRequest

try {
    $result = $apiInstance->tasksSchedulesUpdate($id, $schedule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksSchedulesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| A UUID string identifying this Schedule. | |
| **schedule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\ScheduleRequest**](../Model/ScheduleRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Schedule**](../Model/Schedule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `tasksTasksList()`

```php
tasksTasksList($actor_name, $aggregated_status, $ordering, $page, $page_size, $queue_name, $rel_obj_content_type__app_label, $rel_obj_content_type__model, $rel_obj_id, $rel_obj_id__isnull, $search, $state): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTaskList
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$actor_name = 'actor_name_example'; // string
$aggregated_status = array('aggregated_status_example'); // string[]
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$queue_name = 'queue_name_example'; // string
$rel_obj_content_type__app_label = 'rel_obj_content_type__app_label_example'; // string
$rel_obj_content_type__model = 'rel_obj_content_type__model_example'; // string
$rel_obj_id = 'rel_obj_id_example'; // string
$rel_obj_id__isnull = True; // bool
$search = 'search_example'; // string | A search term.
$state = 'state_example'; // string | Task status

try {
    $result = $apiInstance->tasksTasksList($actor_name, $aggregated_status, $ordering, $page, $page_size, $queue_name, $rel_obj_content_type__app_label, $rel_obj_content_type__model, $rel_obj_id, $rel_obj_id__isnull, $search, $state);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksTasksList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **actor_name** | **string**|  | [optional] |
| **aggregated_status** | [**string[]**](../Model/string.md)|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **queue_name** | **string**|  | [optional] |
| **rel_obj_content_type__app_label** | **string**|  | [optional] |
| **rel_obj_content_type__model** | **string**|  | [optional] |
| **rel_obj_id** | **string**|  | [optional] |
| **rel_obj_id__isnull** | **bool**|  | [optional] |
| **search** | **string**| A search term. | [optional] |
| **state** | **string**| Task status | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedTaskList**](../Model/PaginatedTaskList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `tasksTasksRetrieve()`

```php
tasksTasksRetrieve($message_id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Task
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$message_id = 'message_id_example'; // string | A UUID string identifying this Task.

try {
    $result = $apiInstance->tasksTasksRetrieve($message_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksTasksRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **message_id** | **string**| A UUID string identifying this Task. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Task**](../Model/Task.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `tasksTasksRetryCreate()`

```php
tasksTasksRetryCreate($message_id)
```



Retry task

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$message_id = 'message_id_example'; // string | A UUID string identifying this Task.

try {
    $apiInstance->tasksTasksRetryCreate($message_id);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksTasksRetryCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **message_id** | **string**| A UUID string identifying this Task. | |

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

## `tasksTasksStatusRetrieve()`

```php
tasksTasksStatusRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\GlobalTaskStatus
```



Global status summary for all tasks

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->tasksTasksStatusRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksTasksStatusRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\GlobalTaskStatus**](../Model/GlobalTaskStatus.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `tasksWorkersList()`

```php
tasksWorkersList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Worker[]
```



Get currently connected worker count.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\TasksApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->tasksWorkersList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->tasksWorkersList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Worker[]**](../Model/Worker.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
