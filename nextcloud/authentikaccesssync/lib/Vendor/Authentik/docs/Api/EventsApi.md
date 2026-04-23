# OCA\AuthentikAccessSync\Vendor\Authentik\EventsApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**eventsEventsActionsList()**](EventsApi.md#eventsEventsActionsList) | **GET** /events/events/actions/ |  |
| [**eventsEventsCreate()**](EventsApi.md#eventsEventsCreate) | **POST** /events/events/ |  |
| [**eventsEventsDestroy()**](EventsApi.md#eventsEventsDestroy) | **DELETE** /events/events/{event_uuid}/ |  |
| [**eventsEventsExportCreate()**](EventsApi.md#eventsEventsExportCreate) | **POST** /events/events/export/ |  |
| [**eventsEventsList()**](EventsApi.md#eventsEventsList) | **GET** /events/events/ |  |
| [**eventsEventsPartialUpdate()**](EventsApi.md#eventsEventsPartialUpdate) | **PATCH** /events/events/{event_uuid}/ |  |
| [**eventsEventsRetrieve()**](EventsApi.md#eventsEventsRetrieve) | **GET** /events/events/{event_uuid}/ |  |
| [**eventsEventsTopPerUserList()**](EventsApi.md#eventsEventsTopPerUserList) | **GET** /events/events/top_per_user/ |  |
| [**eventsEventsUpdate()**](EventsApi.md#eventsEventsUpdate) | **PUT** /events/events/{event_uuid}/ |  |
| [**eventsEventsVolumeList()**](EventsApi.md#eventsEventsVolumeList) | **GET** /events/events/volume/ |  |
| [**eventsNotificationsDestroy()**](EventsApi.md#eventsNotificationsDestroy) | **DELETE** /events/notifications/{uuid}/ |  |
| [**eventsNotificationsList()**](EventsApi.md#eventsNotificationsList) | **GET** /events/notifications/ |  |
| [**eventsNotificationsMarkAllSeenCreate()**](EventsApi.md#eventsNotificationsMarkAllSeenCreate) | **POST** /events/notifications/mark_all_seen/ |  |
| [**eventsNotificationsPartialUpdate()**](EventsApi.md#eventsNotificationsPartialUpdate) | **PATCH** /events/notifications/{uuid}/ |  |
| [**eventsNotificationsRetrieve()**](EventsApi.md#eventsNotificationsRetrieve) | **GET** /events/notifications/{uuid}/ |  |
| [**eventsNotificationsUpdate()**](EventsApi.md#eventsNotificationsUpdate) | **PUT** /events/notifications/{uuid}/ |  |
| [**eventsNotificationsUsedByList()**](EventsApi.md#eventsNotificationsUsedByList) | **GET** /events/notifications/{uuid}/used_by/ |  |
| [**eventsRulesCreate()**](EventsApi.md#eventsRulesCreate) | **POST** /events/rules/ |  |
| [**eventsRulesDestroy()**](EventsApi.md#eventsRulesDestroy) | **DELETE** /events/rules/{pbm_uuid}/ |  |
| [**eventsRulesList()**](EventsApi.md#eventsRulesList) | **GET** /events/rules/ |  |
| [**eventsRulesPartialUpdate()**](EventsApi.md#eventsRulesPartialUpdate) | **PATCH** /events/rules/{pbm_uuid}/ |  |
| [**eventsRulesRetrieve()**](EventsApi.md#eventsRulesRetrieve) | **GET** /events/rules/{pbm_uuid}/ |  |
| [**eventsRulesUpdate()**](EventsApi.md#eventsRulesUpdate) | **PUT** /events/rules/{pbm_uuid}/ |  |
| [**eventsRulesUsedByList()**](EventsApi.md#eventsRulesUsedByList) | **GET** /events/rules/{pbm_uuid}/used_by/ |  |
| [**eventsTransportsCreate()**](EventsApi.md#eventsTransportsCreate) | **POST** /events/transports/ |  |
| [**eventsTransportsDestroy()**](EventsApi.md#eventsTransportsDestroy) | **DELETE** /events/transports/{uuid}/ |  |
| [**eventsTransportsList()**](EventsApi.md#eventsTransportsList) | **GET** /events/transports/ |  |
| [**eventsTransportsPartialUpdate()**](EventsApi.md#eventsTransportsPartialUpdate) | **PATCH** /events/transports/{uuid}/ |  |
| [**eventsTransportsRetrieve()**](EventsApi.md#eventsTransportsRetrieve) | **GET** /events/transports/{uuid}/ |  |
| [**eventsTransportsTestCreate()**](EventsApi.md#eventsTransportsTestCreate) | **POST** /events/transports/{uuid}/test/ |  |
| [**eventsTransportsUpdate()**](EventsApi.md#eventsTransportsUpdate) | **PUT** /events/transports/{uuid}/ |  |
| [**eventsTransportsUsedByList()**](EventsApi.md#eventsTransportsUsedByList) | **GET** /events/transports/{uuid}/used_by/ |  |


## `eventsEventsActionsList()`

```php
eventsEventsActionsList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all actions

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->eventsEventsActionsList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsActionsList: ', $e->getMessage(), PHP_EOL;
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

## `eventsEventsCreate()`

```php
eventsEventsCreate($event_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event
```



Event Read-Only Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$event_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventRequest

try {
    $result = $apiInstance->eventsEventsCreate($event_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **event_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventRequest**](../Model/EventRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event**](../Model/Event.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsEventsDestroy()`

```php
eventsEventsDestroy($event_uuid)
```



Event Read-Only Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$event_uuid = 'event_uuid_example'; // string | A UUID string identifying this Event.

try {
    $apiInstance->eventsEventsDestroy($event_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **event_uuid** | **string**| A UUID string identifying this Event. | |

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

## `eventsEventsExportCreate()`

```php
eventsEventsExportCreate($action, $actions, $brand_name, $client_ip, $context_authorized_app, $context_model_app, $context_model_name, $context_model_pk, $ordering, $search, $username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DataExport
```



Create a data export for this data type. Note that the export is generated asynchronously: this method returns a `DataExport` object that will initially have `completed=false` as well as the permanent URL to that object in the `Location` header. You can poll that URL until `completed=true`, at which point the `file_url` property will contain a URL to download

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$action = 'action_example'; // string
$actions = array('actions_example'); // string[]
$brand_name = 'brand_name_example'; // string | Brand name
$client_ip = 'client_ip_example'; // string
$context_authorized_app = 'context_authorized_app_example'; // string | Context Authorized application
$context_model_app = 'context_model_app_example'; // string | Context Model App
$context_model_name = 'context_model_name_example'; // string | Context Model Name
$context_model_pk = 'context_model_pk_example'; // string | Context Model Primary Key
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$search = 'search_example'; // string | A search term.
$username = 'username_example'; // string | Username

try {
    $result = $apiInstance->eventsEventsExportCreate($action, $actions, $brand_name, $client_ip, $context_authorized_app, $context_model_app, $context_model_name, $context_model_pk, $ordering, $search, $username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsExportCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **action** | **string**|  | [optional] |
| **actions** | [**string[]**](../Model/string.md)|  | [optional] |
| **brand_name** | **string**| Brand name | [optional] |
| **client_ip** | **string**|  | [optional] |
| **context_authorized_app** | **string**| Context Authorized application | [optional] |
| **context_model_app** | **string**| Context Model App | [optional] |
| **context_model_name** | **string**| Context Model Name | [optional] |
| **context_model_pk** | **string**| Context Model Primary Key | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **username** | **string**| Username | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DataExport**](../Model/DataExport.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsEventsList()`

```php
eventsEventsList($action, $actions, $brand_name, $client_ip, $context_authorized_app, $context_model_app, $context_model_name, $context_model_pk, $ordering, $page, $page_size, $search, $username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEventList
```



Event Read-Only Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$action = 'action_example'; // string
$actions = array('actions_example'); // string[]
$brand_name = 'brand_name_example'; // string | Brand name
$client_ip = 'client_ip_example'; // string
$context_authorized_app = 'context_authorized_app_example'; // string | Context Authorized application
$context_model_app = 'context_model_app_example'; // string | Context Model App
$context_model_name = 'context_model_name_example'; // string | Context Model Name
$context_model_pk = 'context_model_pk_example'; // string | Context Model Primary Key
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$username = 'username_example'; // string | Username

try {
    $result = $apiInstance->eventsEventsList($action, $actions, $brand_name, $client_ip, $context_authorized_app, $context_model_app, $context_model_name, $context_model_pk, $ordering, $page, $page_size, $search, $username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **action** | **string**|  | [optional] |
| **actions** | [**string[]**](../Model/string.md)|  | [optional] |
| **brand_name** | **string**| Brand name | [optional] |
| **client_ip** | **string**|  | [optional] |
| **context_authorized_app** | **string**| Context Authorized application | [optional] |
| **context_model_app** | **string**| Context Model App | [optional] |
| **context_model_name** | **string**| Context Model Name | [optional] |
| **context_model_pk** | **string**| Context Model Primary Key | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **username** | **string**| Username | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEventList**](../Model/PaginatedEventList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsEventsPartialUpdate()`

```php
eventsEventsPartialUpdate($event_uuid, $patched_event_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event
```



Event Read-Only Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$event_uuid = 'event_uuid_example'; // string | A UUID string identifying this Event.
$patched_event_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEventRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEventRequest

try {
    $result = $apiInstance->eventsEventsPartialUpdate($event_uuid, $patched_event_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **event_uuid** | **string**| A UUID string identifying this Event. | |
| **patched_event_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEventRequest**](../Model/PatchedEventRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event**](../Model/Event.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsEventsRetrieve()`

```php
eventsEventsRetrieve($event_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event
```



Event Read-Only Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$event_uuid = 'event_uuid_example'; // string | A UUID string identifying this Event.

try {
    $result = $apiInstance->eventsEventsRetrieve($event_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **event_uuid** | **string**| A UUID string identifying this Event. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event**](../Model/Event.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsEventsTopPerUserList()`

```php
eventsEventsTopPerUserList($action, $top_n): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventTopPerUser[]
```



Get the top_n events grouped by user count

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$action = 'action_example'; // string
$top_n = 56; // int

try {
    $result = $apiInstance->eventsEventsTopPerUserList($action, $top_n);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsTopPerUserList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **action** | **string**|  | [optional] |
| **top_n** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventTopPerUser[]**](../Model/EventTopPerUser.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsEventsUpdate()`

```php
eventsEventsUpdate($event_uuid, $event_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event
```



Event Read-Only Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$event_uuid = 'event_uuid_example'; // string | A UUID string identifying this Event.
$event_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventRequest

try {
    $result = $apiInstance->eventsEventsUpdate($event_uuid, $event_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **event_uuid** | **string**| A UUID string identifying this Event. | |
| **event_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventRequest**](../Model/EventRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Event**](../Model/Event.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsEventsVolumeList()`

```php
eventsEventsVolumeList($action, $actions, $brand_name, $client_ip, $context_authorized_app, $context_model_app, $context_model_name, $context_model_pk, $history_days, $ordering, $search, $username): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventVolume[]
```



Get event volume for specified filters and timeframe

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$action = 'action_example'; // string
$actions = array('actions_example'); // string[]
$brand_name = 'brand_name_example'; // string | Brand name
$client_ip = 'client_ip_example'; // string
$context_authorized_app = 'context_authorized_app_example'; // string | Context Authorized application
$context_model_app = 'context_model_app_example'; // string | Context Model App
$context_model_name = 'context_model_name_example'; // string | Context Model Name
$context_model_pk = 'context_model_pk_example'; // string | Context Model Primary Key
$history_days = 7; // float
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$search = 'search_example'; // string | A search term.
$username = 'username_example'; // string | Username

try {
    $result = $apiInstance->eventsEventsVolumeList($action, $actions, $brand_name, $client_ip, $context_authorized_app, $context_model_app, $context_model_name, $context_model_pk, $history_days, $ordering, $search, $username);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsEventsVolumeList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **action** | **string**|  | [optional] |
| **actions** | [**string[]**](../Model/string.md)|  | [optional] |
| **brand_name** | **string**| Brand name | [optional] |
| **client_ip** | **string**|  | [optional] |
| **context_authorized_app** | **string**| Context Authorized application | [optional] |
| **context_model_app** | **string**| Context Model App | [optional] |
| **context_model_name** | **string**| Context Model Name | [optional] |
| **context_model_pk** | **string**| Context Model Primary Key | [optional] |
| **history_days** | **float**|  | [optional] [default to 7] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **username** | **string**| Username | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EventVolume[]**](../Model/EventVolume.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsNotificationsDestroy()`

```php
eventsNotificationsDestroy($uuid)
```



Notification Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification.

try {
    $apiInstance->eventsNotificationsDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsNotificationsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification. | |

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

## `eventsNotificationsList()`

```php
eventsNotificationsList($body, $created, $event, $ordering, $page, $page_size, $search, $seen, $severity, $user): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationList
```



Notification Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = 'body_example'; // string
$created = new \DateTime('2013-10-20T19:20:30+01:00'); // \DateTime
$event = 'event_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$seen = True; // bool
$severity = 'severity_example'; // string
$user = 56; // int

try {
    $result = $apiInstance->eventsNotificationsList($body, $created, $event, $ordering, $page, $page_size, $search, $seen, $severity, $user);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsNotificationsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **body** | **string**|  | [optional] |
| **created** | **\DateTime**|  | [optional] |
| **event** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **seen** | **bool**|  | [optional] |
| **severity** | **string**|  | [optional] |
| **user** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationList**](../Model/PaginatedNotificationList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsNotificationsMarkAllSeenCreate()`

```php
eventsNotificationsMarkAllSeenCreate()
```



Mark all the user's notifications as seen

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->eventsNotificationsMarkAllSeenCreate();
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsNotificationsMarkAllSeenCreate: ', $e->getMessage(), PHP_EOL;
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

## `eventsNotificationsPartialUpdate()`

```php
eventsNotificationsPartialUpdate($uuid, $patched_notification_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Notification
```



Notification Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification.
$patched_notification_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationRequest

try {
    $result = $apiInstance->eventsNotificationsPartialUpdate($uuid, $patched_notification_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsNotificationsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification. | |
| **patched_notification_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationRequest**](../Model/PatchedNotificationRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Notification**](../Model/Notification.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsNotificationsRetrieve()`

```php
eventsNotificationsRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Notification
```



Notification Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification.

try {
    $result = $apiInstance->eventsNotificationsRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsNotificationsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Notification**](../Model/Notification.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsNotificationsUpdate()`

```php
eventsNotificationsUpdate($uuid, $notification_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Notification
```



Notification Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification.
$notification_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRequest

try {
    $result = $apiInstance->eventsNotificationsUpdate($uuid, $notification_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsNotificationsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification. | |
| **notification_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRequest**](../Model/NotificationRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Notification**](../Model/Notification.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsNotificationsUsedByList()`

```php
eventsNotificationsUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification.

try {
    $result = $apiInstance->eventsNotificationsUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsNotificationsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification. | |

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

## `eventsRulesCreate()`

```php
eventsRulesCreate($notification_rule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule
```



NotificationRule Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$notification_rule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRuleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRuleRequest

try {
    $result = $apiInstance->eventsRulesCreate($notification_rule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsRulesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **notification_rule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRuleRequest**](../Model/NotificationRuleRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule**](../Model/NotificationRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsRulesDestroy()`

```php
eventsRulesDestroy($pbm_uuid)
```



NotificationRule Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Notification Rule.

try {
    $apiInstance->eventsRulesDestroy($pbm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsRulesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Notification Rule. | |

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

## `eventsRulesList()`

```php
eventsRulesList($destination_group__name, $name, $ordering, $page, $page_size, $search, $severity): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationRuleList
```



NotificationRule Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$destination_group__name = 'destination_group__name_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$severity = 'severity_example'; // string | Controls which severity level the created notifications will have.

try {
    $result = $apiInstance->eventsRulesList($destination_group__name, $name, $ordering, $page, $page_size, $search, $severity);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsRulesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **destination_group__name** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **severity** | **string**| Controls which severity level the created notifications will have. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationRuleList**](../Model/PaginatedNotificationRuleList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsRulesPartialUpdate()`

```php
eventsRulesPartialUpdate($pbm_uuid, $patched_notification_rule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule
```



NotificationRule Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Notification Rule.
$patched_notification_rule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationRuleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationRuleRequest

try {
    $result = $apiInstance->eventsRulesPartialUpdate($pbm_uuid, $patched_notification_rule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsRulesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Notification Rule. | |
| **patched_notification_rule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationRuleRequest**](../Model/PatchedNotificationRuleRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule**](../Model/NotificationRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsRulesRetrieve()`

```php
eventsRulesRetrieve($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule
```



NotificationRule Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Notification Rule.

try {
    $result = $apiInstance->eventsRulesRetrieve($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsRulesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Notification Rule. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule**](../Model/NotificationRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsRulesUpdate()`

```php
eventsRulesUpdate($pbm_uuid, $notification_rule_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule
```



NotificationRule Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Notification Rule.
$notification_rule_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRuleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRuleRequest

try {
    $result = $apiInstance->eventsRulesUpdate($pbm_uuid, $notification_rule_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsRulesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Notification Rule. | |
| **notification_rule_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRuleRequest**](../Model/NotificationRuleRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationRule**](../Model/NotificationRule.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsRulesUsedByList()`

```php
eventsRulesUsedByList($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Notification Rule.

try {
    $result = $apiInstance->eventsRulesUsedByList($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsRulesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Notification Rule. | |

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

## `eventsTransportsCreate()`

```php
eventsTransportsCreate($notification_transport_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport
```



NotificationTransport Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$notification_transport_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportRequest

try {
    $result = $apiInstance->eventsTransportsCreate($notification_transport_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **notification_transport_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportRequest**](../Model/NotificationTransportRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport**](../Model/NotificationTransport.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsTransportsDestroy()`

```php
eventsTransportsDestroy($uuid)
```



NotificationTransport Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification Transport.

try {
    $apiInstance->eventsTransportsDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification Transport. | |

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

## `eventsTransportsList()`

```php
eventsTransportsList($mode, $name, $ordering, $page, $page_size, $search, $send_once, $webhook_url): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationTransportList
```



NotificationTransport Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$mode = 'mode_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$send_once = True; // bool
$webhook_url = 'webhook_url_example'; // string

try {
    $result = $apiInstance->eventsTransportsList($mode, $name, $ordering, $page, $page_size, $search, $send_once, $webhook_url);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **mode** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **send_once** | **bool**|  | [optional] |
| **webhook_url** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedNotificationTransportList**](../Model/PaginatedNotificationTransportList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsTransportsPartialUpdate()`

```php
eventsTransportsPartialUpdate($uuid, $patched_notification_transport_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport
```



NotificationTransport Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification Transport.
$patched_notification_transport_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationTransportRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationTransportRequest

try {
    $result = $apiInstance->eventsTransportsPartialUpdate($uuid, $patched_notification_transport_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification Transport. | |
| **patched_notification_transport_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedNotificationTransportRequest**](../Model/PatchedNotificationTransportRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport**](../Model/NotificationTransport.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsTransportsRetrieve()`

```php
eventsTransportsRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport
```



NotificationTransport Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification Transport.

try {
    $result = $apiInstance->eventsTransportsRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification Transport. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport**](../Model/NotificationTransport.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsTransportsTestCreate()`

```php
eventsTransportsTestCreate($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportTest
```



Send example notification using selected transport. Requires Modify permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification Transport.

try {
    $result = $apiInstance->eventsTransportsTestCreate($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsTestCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification Transport. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportTest**](../Model/NotificationTransportTest.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsTransportsUpdate()`

```php
eventsTransportsUpdate($uuid, $notification_transport_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport
```



NotificationTransport Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification Transport.
$notification_transport_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportRequest

try {
    $result = $apiInstance->eventsTransportsUpdate($uuid, $notification_transport_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification Transport. | |
| **notification_transport_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransportRequest**](../Model/NotificationTransportRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\NotificationTransport**](../Model/NotificationTransport.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `eventsTransportsUsedByList()`

```php
eventsTransportsUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Notification Transport.

try {
    $result = $apiInstance->eventsTransportsUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsTransportsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Notification Transport. | |

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
