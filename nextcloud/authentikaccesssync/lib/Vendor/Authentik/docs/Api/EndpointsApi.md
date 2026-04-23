# OCA\AuthentikAccessSync\Vendor\Authentik\EndpointsApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**endpointsAgentsConnectorsAgentConfigRetrieve()**](EndpointsApi.md#endpointsAgentsConnectorsAgentConfigRetrieve) | **GET** /endpoints/agents/connectors/agent_config/ |  |
| [**endpointsAgentsConnectorsAuthFedCreate()**](EndpointsApi.md#endpointsAgentsConnectorsAuthFedCreate) | **POST** /endpoints/agents/connectors/auth_fed/ |  |
| [**endpointsAgentsConnectorsAuthIaCreate()**](EndpointsApi.md#endpointsAgentsConnectorsAuthIaCreate) | **POST** /endpoints/agents/connectors/auth_ia/ |  |
| [**endpointsAgentsConnectorsCheckInCreate()**](EndpointsApi.md#endpointsAgentsConnectorsCheckInCreate) | **POST** /endpoints/agents/connectors/check_in/ |  |
| [**endpointsAgentsConnectorsCreate()**](EndpointsApi.md#endpointsAgentsConnectorsCreate) | **POST** /endpoints/agents/connectors/ |  |
| [**endpointsAgentsConnectorsDestroy()**](EndpointsApi.md#endpointsAgentsConnectorsDestroy) | **DELETE** /endpoints/agents/connectors/{connector_uuid}/ |  |
| [**endpointsAgentsConnectorsEnrollCreate()**](EndpointsApi.md#endpointsAgentsConnectorsEnrollCreate) | **POST** /endpoints/agents/connectors/enroll/ |  |
| [**endpointsAgentsConnectorsList()**](EndpointsApi.md#endpointsAgentsConnectorsList) | **GET** /endpoints/agents/connectors/ |  |
| [**endpointsAgentsConnectorsMdmConfigCreate()**](EndpointsApi.md#endpointsAgentsConnectorsMdmConfigCreate) | **POST** /endpoints/agents/connectors/{connector_uuid}/mdm_config/ |  |
| [**endpointsAgentsConnectorsPartialUpdate()**](EndpointsApi.md#endpointsAgentsConnectorsPartialUpdate) | **PATCH** /endpoints/agents/connectors/{connector_uuid}/ |  |
| [**endpointsAgentsConnectorsRetrieve()**](EndpointsApi.md#endpointsAgentsConnectorsRetrieve) | **GET** /endpoints/agents/connectors/{connector_uuid}/ |  |
| [**endpointsAgentsConnectorsUpdate()**](EndpointsApi.md#endpointsAgentsConnectorsUpdate) | **PUT** /endpoints/agents/connectors/{connector_uuid}/ |  |
| [**endpointsAgentsConnectorsUsedByList()**](EndpointsApi.md#endpointsAgentsConnectorsUsedByList) | **GET** /endpoints/agents/connectors/{connector_uuid}/used_by/ |  |
| [**endpointsAgentsEnrollmentTokensCreate()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensCreate) | **POST** /endpoints/agents/enrollment_tokens/ |  |
| [**endpointsAgentsEnrollmentTokensDestroy()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensDestroy) | **DELETE** /endpoints/agents/enrollment_tokens/{token_uuid}/ |  |
| [**endpointsAgentsEnrollmentTokensList()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensList) | **GET** /endpoints/agents/enrollment_tokens/ |  |
| [**endpointsAgentsEnrollmentTokensPartialUpdate()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensPartialUpdate) | **PATCH** /endpoints/agents/enrollment_tokens/{token_uuid}/ |  |
| [**endpointsAgentsEnrollmentTokensRetrieve()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensRetrieve) | **GET** /endpoints/agents/enrollment_tokens/{token_uuid}/ |  |
| [**endpointsAgentsEnrollmentTokensUpdate()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensUpdate) | **PUT** /endpoints/agents/enrollment_tokens/{token_uuid}/ |  |
| [**endpointsAgentsEnrollmentTokensUsedByList()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensUsedByList) | **GET** /endpoints/agents/enrollment_tokens/{token_uuid}/used_by/ |  |
| [**endpointsAgentsEnrollmentTokensViewKeyRetrieve()**](EndpointsApi.md#endpointsAgentsEnrollmentTokensViewKeyRetrieve) | **GET** /endpoints/agents/enrollment_tokens/{token_uuid}/view_key/ |  |
| [**endpointsAgentsPssoRegisterDeviceCreate()**](EndpointsApi.md#endpointsAgentsPssoRegisterDeviceCreate) | **POST** /endpoints/agents/psso/register/device/ |  |
| [**endpointsAgentsPssoRegisterUserCreate()**](EndpointsApi.md#endpointsAgentsPssoRegisterUserCreate) | **POST** /endpoints/agents/psso/register/user/ |  |
| [**endpointsConnectorsDestroy()**](EndpointsApi.md#endpointsConnectorsDestroy) | **DELETE** /endpoints/connectors/{connector_uuid}/ |  |
| [**endpointsConnectorsList()**](EndpointsApi.md#endpointsConnectorsList) | **GET** /endpoints/connectors/ |  |
| [**endpointsConnectorsRetrieve()**](EndpointsApi.md#endpointsConnectorsRetrieve) | **GET** /endpoints/connectors/{connector_uuid}/ |  |
| [**endpointsConnectorsTypesList()**](EndpointsApi.md#endpointsConnectorsTypesList) | **GET** /endpoints/connectors/types/ |  |
| [**endpointsConnectorsUsedByList()**](EndpointsApi.md#endpointsConnectorsUsedByList) | **GET** /endpoints/connectors/{connector_uuid}/used_by/ |  |
| [**endpointsDeviceAccessGroupsCreate()**](EndpointsApi.md#endpointsDeviceAccessGroupsCreate) | **POST** /endpoints/device_access_groups/ |  |
| [**endpointsDeviceAccessGroupsDestroy()**](EndpointsApi.md#endpointsDeviceAccessGroupsDestroy) | **DELETE** /endpoints/device_access_groups/{pbm_uuid}/ |  |
| [**endpointsDeviceAccessGroupsList()**](EndpointsApi.md#endpointsDeviceAccessGroupsList) | **GET** /endpoints/device_access_groups/ |  |
| [**endpointsDeviceAccessGroupsPartialUpdate()**](EndpointsApi.md#endpointsDeviceAccessGroupsPartialUpdate) | **PATCH** /endpoints/device_access_groups/{pbm_uuid}/ |  |
| [**endpointsDeviceAccessGroupsRetrieve()**](EndpointsApi.md#endpointsDeviceAccessGroupsRetrieve) | **GET** /endpoints/device_access_groups/{pbm_uuid}/ |  |
| [**endpointsDeviceAccessGroupsUpdate()**](EndpointsApi.md#endpointsDeviceAccessGroupsUpdate) | **PUT** /endpoints/device_access_groups/{pbm_uuid}/ |  |
| [**endpointsDeviceAccessGroupsUsedByList()**](EndpointsApi.md#endpointsDeviceAccessGroupsUsedByList) | **GET** /endpoints/device_access_groups/{pbm_uuid}/used_by/ |  |
| [**endpointsDeviceBindingsCreate()**](EndpointsApi.md#endpointsDeviceBindingsCreate) | **POST** /endpoints/device_bindings/ |  |
| [**endpointsDeviceBindingsDestroy()**](EndpointsApi.md#endpointsDeviceBindingsDestroy) | **DELETE** /endpoints/device_bindings/{policy_binding_uuid}/ |  |
| [**endpointsDeviceBindingsList()**](EndpointsApi.md#endpointsDeviceBindingsList) | **GET** /endpoints/device_bindings/ |  |
| [**endpointsDeviceBindingsPartialUpdate()**](EndpointsApi.md#endpointsDeviceBindingsPartialUpdate) | **PATCH** /endpoints/device_bindings/{policy_binding_uuid}/ |  |
| [**endpointsDeviceBindingsRetrieve()**](EndpointsApi.md#endpointsDeviceBindingsRetrieve) | **GET** /endpoints/device_bindings/{policy_binding_uuid}/ |  |
| [**endpointsDeviceBindingsUpdate()**](EndpointsApi.md#endpointsDeviceBindingsUpdate) | **PUT** /endpoints/device_bindings/{policy_binding_uuid}/ |  |
| [**endpointsDeviceBindingsUsedByList()**](EndpointsApi.md#endpointsDeviceBindingsUsedByList) | **GET** /endpoints/device_bindings/{policy_binding_uuid}/used_by/ |  |
| [**endpointsDevicesDestroy()**](EndpointsApi.md#endpointsDevicesDestroy) | **DELETE** /endpoints/devices/{device_uuid}/ |  |
| [**endpointsDevicesList()**](EndpointsApi.md#endpointsDevicesList) | **GET** /endpoints/devices/ |  |
| [**endpointsDevicesPartialUpdate()**](EndpointsApi.md#endpointsDevicesPartialUpdate) | **PATCH** /endpoints/devices/{device_uuid}/ |  |
| [**endpointsDevicesRetrieve()**](EndpointsApi.md#endpointsDevicesRetrieve) | **GET** /endpoints/devices/{device_uuid}/ |  |
| [**endpointsDevicesSummaryRetrieve()**](EndpointsApi.md#endpointsDevicesSummaryRetrieve) | **GET** /endpoints/devices/summary/ |  |
| [**endpointsDevicesUpdate()**](EndpointsApi.md#endpointsDevicesUpdate) | **PUT** /endpoints/devices/{device_uuid}/ |  |
| [**endpointsDevicesUsedByList()**](EndpointsApi.md#endpointsDevicesUsedByList) | **GET** /endpoints/devices/{device_uuid}/used_by/ |  |
| [**endpointsFleetConnectorsCreate()**](EndpointsApi.md#endpointsFleetConnectorsCreate) | **POST** /endpoints/fleet/connectors/ |  |
| [**endpointsFleetConnectorsDestroy()**](EndpointsApi.md#endpointsFleetConnectorsDestroy) | **DELETE** /endpoints/fleet/connectors/{connector_uuid}/ |  |
| [**endpointsFleetConnectorsList()**](EndpointsApi.md#endpointsFleetConnectorsList) | **GET** /endpoints/fleet/connectors/ |  |
| [**endpointsFleetConnectorsPartialUpdate()**](EndpointsApi.md#endpointsFleetConnectorsPartialUpdate) | **PATCH** /endpoints/fleet/connectors/{connector_uuid}/ |  |
| [**endpointsFleetConnectorsRetrieve()**](EndpointsApi.md#endpointsFleetConnectorsRetrieve) | **GET** /endpoints/fleet/connectors/{connector_uuid}/ |  |
| [**endpointsFleetConnectorsUpdate()**](EndpointsApi.md#endpointsFleetConnectorsUpdate) | **PUT** /endpoints/fleet/connectors/{connector_uuid}/ |  |
| [**endpointsFleetConnectorsUsedByList()**](EndpointsApi.md#endpointsFleetConnectorsUsedByList) | **GET** /endpoints/fleet/connectors/{connector_uuid}/used_by/ |  |


## `endpointsAgentsConnectorsAgentConfigRetrieve()`

```php
endpointsAgentsConnectorsAgentConfigRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConfig
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $result = $apiInstance->endpointsAgentsConnectorsAgentConfigRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsAgentConfigRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConfig**](../Model/AgentConfig.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsAuthFedCreate()`

```php
endpointsAgentsConnectorsAuthFedCreate($device): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentTokenResponse
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$device = 'device_example'; // string

try {
    $result = $apiInstance->endpointsAgentsConnectorsAuthFedCreate($device);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsAuthFedCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device** | **string**|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentTokenResponse**](../Model/AgentTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsAuthIaCreate()`

```php
endpointsAgentsConnectorsAuthIaCreate(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentAuthenticationResponse
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $result = $apiInstance->endpointsAgentsConnectorsAuthIaCreate();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsAuthIaCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentAuthenticationResponse**](../Model/AgentAuthenticationResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsCheckInCreate()`

```php
endpointsAgentsConnectorsCheckInCreate($device_facts_request)
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$device_facts_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceFactsRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceFactsRequest

try {
    $apiInstance->endpointsAgentsConnectorsCheckInCreate($device_facts_request);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsCheckInCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_facts_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceFactsRequest**](../Model/DeviceFactsRequest.md)|  | [optional] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsCreate()`

```php
endpointsAgentsConnectorsCreate($agent_connector_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$agent_connector_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnectorRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnectorRequest

try {
    $result = $apiInstance->endpointsAgentsConnectorsCreate($agent_connector_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **agent_connector_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnectorRequest**](../Model/AgentConnectorRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector**](../Model/AgentConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsDestroy()`

```php
endpointsAgentsConnectorsDestroy($connector_uuid)
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Agent Connector.

try {
    $apiInstance->endpointsAgentsConnectorsDestroy($connector_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Agent Connector. | |

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

## `endpointsAgentsConnectorsEnrollCreate()`

```php
endpointsAgentsConnectorsEnrollCreate($enroll_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentTokenResponse
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$enroll_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollRequest

try {
    $result = $apiInstance->endpointsAgentsConnectorsEnrollCreate($enroll_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsEnrollCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **enroll_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollRequest**](../Model/EnrollRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentTokenResponse**](../Model/AgentTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsList()`

```php
endpointsAgentsConnectorsList($enabled, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAgentConnectorList
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$enabled = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->endpointsAgentsConnectorsList($enabled, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **enabled** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedAgentConnectorList**](../Model/PaginatedAgentConnectorList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsMdmConfigCreate()`

```php
endpointsAgentsConnectorsMdmConfigCreate($connector_uuid, $mdm_config_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MDMConfigResponse
```



Generate configuration for MDM systems to deploy authentik Agent

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Agent Connector.
$mdm_config_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MDMConfigRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\MDMConfigRequest

try {
    $result = $apiInstance->endpointsAgentsConnectorsMdmConfigCreate($connector_uuid, $mdm_config_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsMdmConfigCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Agent Connector. | |
| **mdm_config_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MDMConfigRequest**](../Model/MDMConfigRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\MDMConfigResponse**](../Model/MDMConfigResponse.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsPartialUpdate()`

```php
endpointsAgentsConnectorsPartialUpdate($connector_uuid, $patched_agent_connector_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Agent Connector.
$patched_agent_connector_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAgentConnectorRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAgentConnectorRequest

try {
    $result = $apiInstance->endpointsAgentsConnectorsPartialUpdate($connector_uuid, $patched_agent_connector_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Agent Connector. | |
| **patched_agent_connector_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedAgentConnectorRequest**](../Model/PatchedAgentConnectorRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector**](../Model/AgentConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsRetrieve()`

```php
endpointsAgentsConnectorsRetrieve($connector_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Agent Connector.

try {
    $result = $apiInstance->endpointsAgentsConnectorsRetrieve($connector_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Agent Connector. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector**](../Model/AgentConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsUpdate()`

```php
endpointsAgentsConnectorsUpdate($connector_uuid, $agent_connector_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Agent Connector.
$agent_connector_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnectorRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnectorRequest

try {
    $result = $apiInstance->endpointsAgentsConnectorsUpdate($connector_uuid, $agent_connector_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Agent Connector. | |
| **agent_connector_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnectorRequest**](../Model/AgentConnectorRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentConnector**](../Model/AgentConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsConnectorsUsedByList()`

```php
endpointsAgentsConnectorsUsedByList($connector_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Agent Connector.

try {
    $result = $apiInstance->endpointsAgentsConnectorsUsedByList($connector_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsConnectorsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Agent Connector. | |

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

## `endpointsAgentsEnrollmentTokensCreate()`

```php
endpointsAgentsEnrollmentTokensCreate($enrollment_token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$enrollment_token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentTokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentTokenRequest

try {
    $result = $apiInstance->endpointsAgentsEnrollmentTokensCreate($enrollment_token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **enrollment_token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentTokenRequest**](../Model/EnrollmentTokenRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken**](../Model/EnrollmentToken.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsEnrollmentTokensDestroy()`

```php
endpointsAgentsEnrollmentTokensDestroy($token_uuid)
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$token_uuid = 'token_uuid_example'; // string | A UUID string identifying this Enrollment Token.

try {
    $apiInstance->endpointsAgentsEnrollmentTokensDestroy($token_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **token_uuid** | **string**| A UUID string identifying this Enrollment Token. | |

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

## `endpointsAgentsEnrollmentTokensList()`

```php
endpointsAgentsEnrollmentTokensList($connector, $ordering, $page, $page_size, $search, $token_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEnrollmentTokenList
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector = 'connector_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$token_uuid = 'token_uuid_example'; // string

try {
    $result = $apiInstance->endpointsAgentsEnrollmentTokensList($connector, $ordering, $page, $page_size, $search, $token_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **token_uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEnrollmentTokenList**](../Model/PaginatedEnrollmentTokenList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsEnrollmentTokensPartialUpdate()`

```php
endpointsAgentsEnrollmentTokensPartialUpdate($token_uuid, $patched_enrollment_token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$token_uuid = 'token_uuid_example'; // string | A UUID string identifying this Enrollment Token.
$patched_enrollment_token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEnrollmentTokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEnrollmentTokenRequest

try {
    $result = $apiInstance->endpointsAgentsEnrollmentTokensPartialUpdate($token_uuid, $patched_enrollment_token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **token_uuid** | **string**| A UUID string identifying this Enrollment Token. | |
| **patched_enrollment_token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEnrollmentTokenRequest**](../Model/PatchedEnrollmentTokenRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken**](../Model/EnrollmentToken.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsEnrollmentTokensRetrieve()`

```php
endpointsAgentsEnrollmentTokensRetrieve($token_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$token_uuid = 'token_uuid_example'; // string | A UUID string identifying this Enrollment Token.

try {
    $result = $apiInstance->endpointsAgentsEnrollmentTokensRetrieve($token_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **token_uuid** | **string**| A UUID string identifying this Enrollment Token. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken**](../Model/EnrollmentToken.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsEnrollmentTokensUpdate()`

```php
endpointsAgentsEnrollmentTokensUpdate($token_uuid, $enrollment_token_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$token_uuid = 'token_uuid_example'; // string | A UUID string identifying this Enrollment Token.
$enrollment_token_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentTokenRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentTokenRequest

try {
    $result = $apiInstance->endpointsAgentsEnrollmentTokensUpdate($token_uuid, $enrollment_token_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **token_uuid** | **string**| A UUID string identifying this Enrollment Token. | |
| **enrollment_token_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentTokenRequest**](../Model/EnrollmentTokenRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EnrollmentToken**](../Model/EnrollmentToken.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsEnrollmentTokensUsedByList()`

```php
endpointsAgentsEnrollmentTokensUsedByList($token_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$token_uuid = 'token_uuid_example'; // string | A UUID string identifying this Enrollment Token.

try {
    $result = $apiInstance->endpointsAgentsEnrollmentTokensUsedByList($token_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **token_uuid** | **string**| A UUID string identifying this Enrollment Token. | |

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

## `endpointsAgentsEnrollmentTokensViewKeyRetrieve()`

```php
endpointsAgentsEnrollmentTokensViewKeyRetrieve($token_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenView
```



Return token key and log access

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$token_uuid = 'token_uuid_example'; // string | A UUID string identifying this Enrollment Token.

try {
    $result = $apiInstance->endpointsAgentsEnrollmentTokensViewKeyRetrieve($token_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsEnrollmentTokensViewKeyRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **token_uuid** | **string**| A UUID string identifying this Enrollment Token. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\TokenView**](../Model/TokenView.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsPssoRegisterDeviceCreate()`

```php
endpointsAgentsPssoRegisterDeviceCreate($agent_psso_device_registration_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSODeviceRegistrationResponse
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$agent_psso_device_registration_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSODeviceRegistrationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSODeviceRegistrationRequest

try {
    $result = $apiInstance->endpointsAgentsPssoRegisterDeviceCreate($agent_psso_device_registration_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsPssoRegisterDeviceCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **agent_psso_device_registration_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSODeviceRegistrationRequest**](../Model/AgentPSSODeviceRegistrationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSODeviceRegistrationResponse**](../Model/AgentPSSODeviceRegistrationResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsAgentsPssoRegisterUserCreate()`

```php
endpointsAgentsPssoRegisterUserCreate($agent_psso_user_registration_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserSelf
```



### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$agent_psso_user_registration_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSOUserRegistrationRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSOUserRegistrationRequest

try {
    $result = $apiInstance->endpointsAgentsPssoRegisterUserCreate($agent_psso_user_registration_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsAgentsPssoRegisterUserCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **agent_psso_user_registration_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\AgentPSSOUserRegistrationRequest**](../Model/AgentPSSOUserRegistrationRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserSelf**](../Model/UserSelf.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsConnectorsDestroy()`

```php
endpointsConnectorsDestroy($connector_uuid)
```



Connector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this connector.

try {
    $apiInstance->endpointsConnectorsDestroy($connector_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsConnectorsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this connector. | |

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

## `endpointsConnectorsList()`

```php
endpointsConnectorsList($ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedConnectorList
```



Connector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->endpointsConnectorsList($ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsConnectorsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedConnectorList**](../Model/PaginatedConnectorList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsConnectorsRetrieve()`

```php
endpointsConnectorsRetrieve($connector_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Connector
```



Connector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this connector.

try {
    $result = $apiInstance->endpointsConnectorsRetrieve($connector_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsConnectorsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this connector. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Connector**](../Model/Connector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsConnectorsTypesList()`

```php
endpointsConnectorsTypesList(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\TypeCreate[]
```



Get all creatable types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->endpointsConnectorsTypesList();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsConnectorsTypesList: ', $e->getMessage(), PHP_EOL;
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

## `endpointsConnectorsUsedByList()`

```php
endpointsConnectorsUsedByList($connector_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this connector.

try {
    $result = $apiInstance->endpointsConnectorsUsedByList($connector_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsConnectorsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this connector. | |

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

## `endpointsDeviceAccessGroupsCreate()`

```php
endpointsDeviceAccessGroupsCreate($device_access_group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup
```



DeviceAccessGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$device_access_group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroupRequest

try {
    $result = $apiInstance->endpointsDeviceAccessGroupsCreate($device_access_group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceAccessGroupsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_access_group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroupRequest**](../Model/DeviceAccessGroupRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup**](../Model/DeviceAccessGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceAccessGroupsDestroy()`

```php
endpointsDeviceAccessGroupsDestroy($pbm_uuid)
```



DeviceAccessGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Device access group.

try {
    $apiInstance->endpointsDeviceAccessGroupsDestroy($pbm_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceAccessGroupsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Device access group. | |

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

## `endpointsDeviceAccessGroupsList()`

```php
endpointsDeviceAccessGroupsList($name, $ordering, $page, $page_size, $pbm_uuid, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDeviceAccessGroupList
```



DeviceAccessGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$pbm_uuid = 'pbm_uuid_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->endpointsDeviceAccessGroupsList($name, $ordering, $page, $page_size, $pbm_uuid, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceAccessGroupsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **pbm_uuid** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDeviceAccessGroupList**](../Model/PaginatedDeviceAccessGroupList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceAccessGroupsPartialUpdate()`

```php
endpointsDeviceAccessGroupsPartialUpdate($pbm_uuid, $patched_device_access_group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup
```



DeviceAccessGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Device access group.
$patched_device_access_group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDeviceAccessGroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDeviceAccessGroupRequest

try {
    $result = $apiInstance->endpointsDeviceAccessGroupsPartialUpdate($pbm_uuid, $patched_device_access_group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceAccessGroupsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Device access group. | |
| **patched_device_access_group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDeviceAccessGroupRequest**](../Model/PatchedDeviceAccessGroupRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup**](../Model/DeviceAccessGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceAccessGroupsRetrieve()`

```php
endpointsDeviceAccessGroupsRetrieve($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup
```



DeviceAccessGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Device access group.

try {
    $result = $apiInstance->endpointsDeviceAccessGroupsRetrieve($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceAccessGroupsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Device access group. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup**](../Model/DeviceAccessGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceAccessGroupsUpdate()`

```php
endpointsDeviceAccessGroupsUpdate($pbm_uuid, $device_access_group_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup
```



DeviceAccessGroup Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Device access group.
$device_access_group_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroupRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroupRequest

try {
    $result = $apiInstance->endpointsDeviceAccessGroupsUpdate($pbm_uuid, $device_access_group_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceAccessGroupsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Device access group. | |
| **device_access_group_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroupRequest**](../Model/DeviceAccessGroupRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceAccessGroup**](../Model/DeviceAccessGroup.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceAccessGroupsUsedByList()`

```php
endpointsDeviceAccessGroupsUsedByList($pbm_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pbm_uuid = 'pbm_uuid_example'; // string | A UUID string identifying this Device access group.

try {
    $result = $apiInstance->endpointsDeviceAccessGroupsUsedByList($pbm_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceAccessGroupsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **pbm_uuid** | **string**| A UUID string identifying this Device access group. | |

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

## `endpointsDeviceBindingsCreate()`

```php
endpointsDeviceBindingsCreate($device_user_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$device_user_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBindingRequest

try {
    $result = $apiInstance->endpointsDeviceBindingsCreate($device_user_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceBindingsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_user_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBindingRequest**](../Model/DeviceUserBindingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding**](../Model/DeviceUserBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceBindingsDestroy()`

```php
endpointsDeviceBindingsDestroy($policy_binding_uuid)
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Device User binding.

try {
    $apiInstance->endpointsDeviceBindingsDestroy($policy_binding_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceBindingsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Device User binding. | |

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

## `endpointsDeviceBindingsList()`

```php
endpointsDeviceBindingsList($enabled, $order, $ordering, $page, $page_size, $policy, $policy__isnull, $search, $target, $target_in, $timeout): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDeviceUserBindingList
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
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
    $result = $apiInstance->endpointsDeviceBindingsList($enabled, $order, $ordering, $page, $page_size, $policy, $policy__isnull, $search, $target, $target_in, $timeout);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceBindingsList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedDeviceUserBindingList**](../Model/PaginatedDeviceUserBindingList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceBindingsPartialUpdate()`

```php
endpointsDeviceBindingsPartialUpdate($policy_binding_uuid, $patched_device_user_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Device User binding.
$patched_device_user_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDeviceUserBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDeviceUserBindingRequest

try {
    $result = $apiInstance->endpointsDeviceBindingsPartialUpdate($policy_binding_uuid, $patched_device_user_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceBindingsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Device User binding. | |
| **patched_device_user_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedDeviceUserBindingRequest**](../Model/PatchedDeviceUserBindingRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding**](../Model/DeviceUserBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceBindingsRetrieve()`

```php
endpointsDeviceBindingsRetrieve($policy_binding_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Device User binding.

try {
    $result = $apiInstance->endpointsDeviceBindingsRetrieve($policy_binding_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceBindingsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Device User binding. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding**](../Model/DeviceUserBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceBindingsUpdate()`

```php
endpointsDeviceBindingsUpdate($policy_binding_uuid, $device_user_binding_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding
```



PolicyBinding Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Device User binding.
$device_user_binding_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBindingRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBindingRequest

try {
    $result = $apiInstance->endpointsDeviceBindingsUpdate($policy_binding_uuid, $device_user_binding_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceBindingsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Device User binding. | |
| **device_user_binding_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBindingRequest**](../Model/DeviceUserBindingRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceUserBinding**](../Model/DeviceUserBinding.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDeviceBindingsUsedByList()`

```php
endpointsDeviceBindingsUsedByList($policy_binding_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$policy_binding_uuid = 'policy_binding_uuid_example'; // string | A UUID string identifying this Device User binding.

try {
    $result = $apiInstance->endpointsDeviceBindingsUsedByList($policy_binding_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDeviceBindingsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **policy_binding_uuid** | **string**| A UUID string identifying this Device User binding. | |

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

## `endpointsDevicesDestroy()`

```php
endpointsDevicesDestroy($device_uuid)
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$device_uuid = 'device_uuid_example'; // string | A UUID string identifying this Device.

try {
    $apiInstance->endpointsDevicesDestroy($device_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDevicesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_uuid** | **string**| A UUID string identifying this Device. | |

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

## `endpointsDevicesList()`

```php
endpointsDevicesList($identifier, $name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEndpointDeviceList
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$identifier = 'identifier_example'; // string
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->endpointsDevicesList($identifier, $name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDevicesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **identifier** | **string**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedEndpointDeviceList**](../Model/PaginatedEndpointDeviceList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDevicesPartialUpdate()`

```php
endpointsDevicesPartialUpdate($device_uuid, $patched_endpoint_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDevice
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$device_uuid = 'device_uuid_example'; // string | A UUID string identifying this Device.
$patched_endpoint_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointDeviceRequest

try {
    $result = $apiInstance->endpointsDevicesPartialUpdate($device_uuid, $patched_endpoint_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDevicesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_uuid** | **string**| A UUID string identifying this Device. | |
| **patched_endpoint_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedEndpointDeviceRequest**](../Model/PatchedEndpointDeviceRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDevice**](../Model/EndpointDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDevicesRetrieve()`

```php
endpointsDevicesRetrieve($device_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDeviceDetails
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$device_uuid = 'device_uuid_example'; // string | A UUID string identifying this Device.

try {
    $result = $apiInstance->endpointsDevicesRetrieve($device_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDevicesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_uuid** | **string**| A UUID string identifying this Device. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDeviceDetails**](../Model/EndpointDeviceDetails.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDevicesSummaryRetrieve()`

```php
endpointsDevicesSummaryRetrieve(): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceSummary
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->endpointsDevicesSummaryRetrieve();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDevicesSummaryRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\DeviceSummary**](../Model/DeviceSummary.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDevicesUpdate()`

```php
endpointsDevicesUpdate($device_uuid, $endpoint_device_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDevice
```



Mixin to add a used_by endpoint to return a list of all objects using this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$device_uuid = 'device_uuid_example'; // string | A UUID string identifying this Device.
$endpoint_device_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDeviceRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDeviceRequest

try {
    $result = $apiInstance->endpointsDevicesUpdate($device_uuid, $endpoint_device_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDevicesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_uuid** | **string**| A UUID string identifying this Device. | |
| **endpoint_device_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDeviceRequest**](../Model/EndpointDeviceRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\EndpointDevice**](../Model/EndpointDevice.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsDevicesUsedByList()`

```php
endpointsDevicesUsedByList($device_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$device_uuid = 'device_uuid_example'; // string | A UUID string identifying this Device.

try {
    $result = $apiInstance->endpointsDevicesUsedByList($device_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsDevicesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **device_uuid** | **string**| A UUID string identifying this Device. | |

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

## `endpointsFleetConnectorsCreate()`

```php
endpointsFleetConnectorsCreate($fleet_connector_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector
```



FleetConnector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fleet_connector_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnectorRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnectorRequest

try {
    $result = $apiInstance->endpointsFleetConnectorsCreate($fleet_connector_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsFleetConnectorsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fleet_connector_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnectorRequest**](../Model/FleetConnectorRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector**](../Model/FleetConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsFleetConnectorsDestroy()`

```php
endpointsFleetConnectorsDestroy($connector_uuid)
```



FleetConnector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Fleet Connector.

try {
    $apiInstance->endpointsFleetConnectorsDestroy($connector_uuid);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsFleetConnectorsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Fleet Connector. | |

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

## `endpointsFleetConnectorsList()`

```php
endpointsFleetConnectorsList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedFleetConnectorList
```



FleetConnector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
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
    $result = $apiInstance->endpointsFleetConnectorsList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsFleetConnectorsList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedFleetConnectorList**](../Model/PaginatedFleetConnectorList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsFleetConnectorsPartialUpdate()`

```php
endpointsFleetConnectorsPartialUpdate($connector_uuid, $patched_fleet_connector_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector
```



FleetConnector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Fleet Connector.
$patched_fleet_connector_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFleetConnectorRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFleetConnectorRequest

try {
    $result = $apiInstance->endpointsFleetConnectorsPartialUpdate($connector_uuid, $patched_fleet_connector_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsFleetConnectorsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Fleet Connector. | |
| **patched_fleet_connector_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedFleetConnectorRequest**](../Model/PatchedFleetConnectorRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector**](../Model/FleetConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsFleetConnectorsRetrieve()`

```php
endpointsFleetConnectorsRetrieve($connector_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector
```



FleetConnector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Fleet Connector.

try {
    $result = $apiInstance->endpointsFleetConnectorsRetrieve($connector_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsFleetConnectorsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Fleet Connector. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector**](../Model/FleetConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsFleetConnectorsUpdate()`

```php
endpointsFleetConnectorsUpdate($connector_uuid, $fleet_connector_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector
```



FleetConnector Viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Fleet Connector.
$fleet_connector_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnectorRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnectorRequest

try {
    $result = $apiInstance->endpointsFleetConnectorsUpdate($connector_uuid, $fleet_connector_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsFleetConnectorsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Fleet Connector. | |
| **fleet_connector_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnectorRequest**](../Model/FleetConnectorRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\FleetConnector**](../Model/FleetConnector.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `endpointsFleetConnectorsUsedByList()`

```php
endpointsFleetConnectorsUsedByList($connector_uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\EndpointsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connector_uuid = 'connector_uuid_example'; // string | A UUID string identifying this Fleet Connector.

try {
    $result = $apiInstance->endpointsFleetConnectorsUsedByList($connector_uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EndpointsApi->endpointsFleetConnectorsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connector_uuid** | **string**| A UUID string identifying this Fleet Connector. | |

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
