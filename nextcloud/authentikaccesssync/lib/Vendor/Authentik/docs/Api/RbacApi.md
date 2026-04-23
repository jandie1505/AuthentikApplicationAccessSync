# OCA\AuthentikAccessSync\Vendor\Authentik\RbacApi



All URIs are relative to /api/v3, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**rbacInitialPermissionsCreate()**](RbacApi.md#rbacInitialPermissionsCreate) | **POST** /rbac/initial_permissions/ |  |
| [**rbacInitialPermissionsDestroy()**](RbacApi.md#rbacInitialPermissionsDestroy) | **DELETE** /rbac/initial_permissions/{id}/ |  |
| [**rbacInitialPermissionsList()**](RbacApi.md#rbacInitialPermissionsList) | **GET** /rbac/initial_permissions/ |  |
| [**rbacInitialPermissionsPartialUpdate()**](RbacApi.md#rbacInitialPermissionsPartialUpdate) | **PATCH** /rbac/initial_permissions/{id}/ |  |
| [**rbacInitialPermissionsRetrieve()**](RbacApi.md#rbacInitialPermissionsRetrieve) | **GET** /rbac/initial_permissions/{id}/ |  |
| [**rbacInitialPermissionsUpdate()**](RbacApi.md#rbacInitialPermissionsUpdate) | **PUT** /rbac/initial_permissions/{id}/ |  |
| [**rbacInitialPermissionsUsedByList()**](RbacApi.md#rbacInitialPermissionsUsedByList) | **GET** /rbac/initial_permissions/{id}/used_by/ |  |
| [**rbacPermissionsAssignedByRolesAssign()**](RbacApi.md#rbacPermissionsAssignedByRolesAssign) | **POST** /rbac/permissions/assigned_by_roles/{uuid}/assign/ |  |
| [**rbacPermissionsAssignedByRolesList()**](RbacApi.md#rbacPermissionsAssignedByRolesList) | **GET** /rbac/permissions/assigned_by_roles/ |  |
| [**rbacPermissionsAssignedByRolesUnassignPartialUpdate()**](RbacApi.md#rbacPermissionsAssignedByRolesUnassignPartialUpdate) | **PATCH** /rbac/permissions/assigned_by_roles/{uuid}/unassign/ |  |
| [**rbacPermissionsList()**](RbacApi.md#rbacPermissionsList) | **GET** /rbac/permissions/ |  |
| [**rbacPermissionsRetrieve()**](RbacApi.md#rbacPermissionsRetrieve) | **GET** /rbac/permissions/{id}/ |  |
| [**rbacPermissionsRolesList()**](RbacApi.md#rbacPermissionsRolesList) | **GET** /rbac/permissions/roles/ |  |
| [**rbacRolesAddUserCreate()**](RbacApi.md#rbacRolesAddUserCreate) | **POST** /rbac/roles/{uuid}/add_user/ |  |
| [**rbacRolesCreate()**](RbacApi.md#rbacRolesCreate) | **POST** /rbac/roles/ |  |
| [**rbacRolesDestroy()**](RbacApi.md#rbacRolesDestroy) | **DELETE** /rbac/roles/{uuid}/ |  |
| [**rbacRolesList()**](RbacApi.md#rbacRolesList) | **GET** /rbac/roles/ |  |
| [**rbacRolesPartialUpdate()**](RbacApi.md#rbacRolesPartialUpdate) | **PATCH** /rbac/roles/{uuid}/ |  |
| [**rbacRolesRemoveUserCreate()**](RbacApi.md#rbacRolesRemoveUserCreate) | **POST** /rbac/roles/{uuid}/remove_user/ |  |
| [**rbacRolesRetrieve()**](RbacApi.md#rbacRolesRetrieve) | **GET** /rbac/roles/{uuid}/ |  |
| [**rbacRolesUpdate()**](RbacApi.md#rbacRolesUpdate) | **PUT** /rbac/roles/{uuid}/ |  |
| [**rbacRolesUsedByList()**](RbacApi.md#rbacRolesUsedByList) | **GET** /rbac/roles/{uuid}/used_by/ |  |


## `rbacInitialPermissionsCreate()`

```php
rbacInitialPermissionsCreate($initial_permissions_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions
```



InitialPermissions viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$initial_permissions_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissionsRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissionsRequest

try {
    $result = $apiInstance->rbacInitialPermissionsCreate($initial_permissions_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacInitialPermissionsCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **initial_permissions_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissionsRequest**](../Model/InitialPermissionsRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions**](../Model/InitialPermissions.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacInitialPermissionsDestroy()`

```php
rbacInitialPermissionsDestroy($id)
```



InitialPermissions viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Initial Permissions.

try {
    $apiInstance->rbacInitialPermissionsDestroy($id);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacInitialPermissionsDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Initial Permissions. | |

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

## `rbacInitialPermissionsList()`

```php
rbacInitialPermissionsList($name, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedInitialPermissionsList
```



InitialPermissions viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
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
    $result = $apiInstance->rbacInitialPermissionsList($name, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacInitialPermissionsList: ', $e->getMessage(), PHP_EOL;
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

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedInitialPermissionsList**](../Model/PaginatedInitialPermissionsList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacInitialPermissionsPartialUpdate()`

```php
rbacInitialPermissionsPartialUpdate($id, $patched_initial_permissions_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions
```



InitialPermissions viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Initial Permissions.
$patched_initial_permissions_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInitialPermissionsRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInitialPermissionsRequest

try {
    $result = $apiInstance->rbacInitialPermissionsPartialUpdate($id, $patched_initial_permissions_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacInitialPermissionsPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Initial Permissions. | |
| **patched_initial_permissions_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedInitialPermissionsRequest**](../Model/PatchedInitialPermissionsRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions**](../Model/InitialPermissions.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacInitialPermissionsRetrieve()`

```php
rbacInitialPermissionsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions
```



InitialPermissions viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Initial Permissions.

try {
    $result = $apiInstance->rbacInitialPermissionsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacInitialPermissionsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Initial Permissions. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions**](../Model/InitialPermissions.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacInitialPermissionsUpdate()`

```php
rbacInitialPermissionsUpdate($id, $initial_permissions_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions
```



InitialPermissions viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Initial Permissions.
$initial_permissions_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissionsRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissionsRequest

try {
    $result = $apiInstance->rbacInitialPermissionsUpdate($id, $initial_permissions_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacInitialPermissionsUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Initial Permissions. | |
| **initial_permissions_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissionsRequest**](../Model/InitialPermissionsRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\InitialPermissions**](../Model/InitialPermissions.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacInitialPermissionsUsedByList()`

```php
rbacInitialPermissionsUsedByList($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this Initial Permissions.

try {
    $result = $apiInstance->rbacInitialPermissionsUsedByList($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacInitialPermissionsUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this Initial Permissions. | |

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

## `rbacPermissionsAssignedByRolesAssign()`

```php
rbacPermissionsAssignedByRolesAssign($uuid, $permission_assign_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PermissionAssignResult[]
```



Assign permission(s) to role. When `object_pk` is set, the permissions are only assigned to the specific object, otherwise they are assigned globally.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.
$permission_assign_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PermissionAssignRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PermissionAssignRequest

try {
    $result = $apiInstance->rbacPermissionsAssignedByRolesAssign($uuid, $permission_assign_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacPermissionsAssignedByRolesAssign: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |
| **permission_assign_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PermissionAssignRequest**](../Model/PermissionAssignRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PermissionAssignResult[]**](../Model/PermissionAssignResult.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacPermissionsAssignedByRolesList()`

```php
rbacPermissionsAssignedByRolesList($model, $object_pk, $ordering, $page, $page_size, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRoleAssignedObjectPermissionList
```



Get assigned object permissions for a single object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$model = 'model_example'; // string
$object_pk = 'object_pk_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->rbacPermissionsAssignedByRolesList($model, $object_pk, $ordering, $page, $page_size, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacPermissionsAssignedByRolesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **model** | **string**|  | |
| **object_pk** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRoleAssignedObjectPermissionList**](../Model/PaginatedRoleAssignedObjectPermissionList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacPermissionsAssignedByRolesUnassignPartialUpdate()`

```php
rbacPermissionsAssignedByRolesUnassignPartialUpdate($uuid, $patched_permission_assign_request)
```



Unassign permission(s) to role. When `object_pk` is set, the permissions are only assigned to the specific object, otherwise they are assigned globally.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.
$patched_permission_assign_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPermissionAssignRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPermissionAssignRequest

try {
    $apiInstance->rbacPermissionsAssignedByRolesUnassignPartialUpdate($uuid, $patched_permission_assign_request);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacPermissionsAssignedByRolesUnassignPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |
| **patched_permission_assign_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedPermissionAssignRequest**](../Model/PatchedPermissionAssignRequest.md)|  | [optional] |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacPermissionsList()`

```php
rbacPermissionsList($codename, $content_type__app_label, $content_type__model, $ordering, $page, $page_size, $role, $search): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPermissionList
```



Read-only list of all permissions, filterable by model and app

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$codename = 'codename_example'; // string
$content_type__app_label = 'content_type__app_label_example'; // string
$content_type__model = 'content_type__model_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$role = 'role_example'; // string
$search = 'search_example'; // string | A search term.

try {
    $result = $apiInstance->rbacPermissionsList($codename, $content_type__app_label, $content_type__model, $ordering, $page, $page_size, $role, $search);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacPermissionsList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **codename** | **string**|  | [optional] |
| **content_type__app_label** | **string**|  | [optional] |
| **content_type__model** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **role** | **string**|  | [optional] |
| **search** | **string**| A search term. | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedPermissionList**](../Model/PaginatedPermissionList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacPermissionsRetrieve()`

```php
rbacPermissionsRetrieve($id): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Permission
```



Read-only list of all permissions, filterable by model and app

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 56; // int | A unique integer value identifying this permission.

try {
    $result = $apiInstance->rbacPermissionsRetrieve($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacPermissionsRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **int**| A unique integer value identifying this permission. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Permission**](../Model/Permission.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacPermissionsRolesList()`

```php
rbacPermissionsRolesList($ordering, $page, $page_size, $search, $uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedExtraRoleObjectPermissionList
```



Get a role's assigned object permissions

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$uuid = 'uuid_example'; // string

try {
    $result = $apiInstance->rbacPermissionsRolesList($ordering, $page, $page_size, $search, $uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacPermissionsRolesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **uuid** | **string**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedExtraRoleObjectPermissionList**](../Model/PaginatedExtraRoleObjectPermissionList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesAddUserCreate()`

```php
rbacRolesAddUserCreate($uuid, $user_account_serializer_for_role_request)
```



Add user to role

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.
$user_account_serializer_for_role_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountSerializerForRoleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountSerializerForRoleRequest

try {
    $apiInstance->rbacRolesAddUserCreate($uuid, $user_account_serializer_for_role_request);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesAddUserCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |
| **user_account_serializer_for_role_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountSerializerForRoleRequest**](../Model/UserAccountSerializerForRoleRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesCreate()`

```php
rbacRolesCreate($role_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role
```



Role viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$role_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RoleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RoleRequest

try {
    $result = $apiInstance->rbacRolesCreate($role_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **role_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RoleRequest**](../Model/RoleRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role**](../Model/Role.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesDestroy()`

```php
rbacRolesDestroy($uuid)
```



Role viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.

try {
    $apiInstance->rbacRolesDestroy($uuid);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesDestroy: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |

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

## `rbacRolesList()`

```php
rbacRolesList($groups, $inherited, $managed, $managed__isnull, $name, $ordering, $page, $page_size, $search, $users): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRoleList
```



Role viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$groups = 'groups_example'; // string
$inherited = True; // bool | Include inherited roles (requires users or groups filter)
$managed = array('managed_example'); // string[]
$managed__isnull = True; // bool
$name = 'name_example'; // string
$ordering = 'ordering_example'; // string | Which field to use when ordering the results.
$page = 56; // int | A page number within the paginated result set.
$page_size = 56; // int | Number of results to return per page.
$search = 'search_example'; // string | A search term.
$users = 56; // int

try {
    $result = $apiInstance->rbacRolesList($groups, $inherited, $managed, $managed__isnull, $name, $ordering, $page, $page_size, $search, $users);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **groups** | **string**|  | [optional] |
| **inherited** | **bool**| Include inherited roles (requires users or groups filter) | [optional] |
| **managed** | [**string[]**](../Model/string.md)|  | [optional] |
| **managed__isnull** | **bool**|  | [optional] |
| **name** | **string**|  | [optional] |
| **ordering** | **string**| Which field to use when ordering the results. | [optional] |
| **page** | **int**| A page number within the paginated result set. | [optional] |
| **page_size** | **int**| Number of results to return per page. | [optional] |
| **search** | **string**| A search term. | [optional] |
| **users** | **int**|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PaginatedRoleList**](../Model/PaginatedRoleList.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesPartialUpdate()`

```php
rbacRolesPartialUpdate($uuid, $patched_role_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role
```



Role viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.
$patched_role_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRoleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRoleRequest

try {
    $result = $apiInstance->rbacRolesPartialUpdate($uuid, $patched_role_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesPartialUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |
| **patched_role_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\PatchedRoleRequest**](../Model/PatchedRoleRequest.md)|  | [optional] |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role**](../Model/Role.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesRemoveUserCreate()`

```php
rbacRolesRemoveUserCreate($uuid, $user_account_serializer_for_role_request)
```



Remove user from role

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.
$user_account_serializer_for_role_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountSerializerForRoleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountSerializerForRoleRequest

try {
    $apiInstance->rbacRolesRemoveUserCreate($uuid, $user_account_serializer_for_role_request);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesRemoveUserCreate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |
| **user_account_serializer_for_role_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\UserAccountSerializerForRoleRequest**](../Model/UserAccountSerializerForRoleRequest.md)|  | |

### Return type

void (empty response body)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesRetrieve()`

```php
rbacRolesRetrieve($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role
```



Role viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.

try {
    $result = $apiInstance->rbacRolesRetrieve($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesRetrieve: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role**](../Model/Role.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesUpdate()`

```php
rbacRolesUpdate($uuid, $role_request): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role
```



Role viewset

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.
$role_request = new \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RoleRequest(); // \OCA\AuthentikAccessSync\Vendor\Authentik\Model\RoleRequest

try {
    $result = $apiInstance->rbacRolesUpdate($uuid, $role_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesUpdate: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |
| **role_request** | [**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\RoleRequest**](../Model/RoleRequest.md)|  | |

### Return type

[**\OCA\AuthentikAccessSync\Vendor\Authentik\Model\Role**](../Model/Role.md)

### Authorization

[authentik](../../README.md#authentik)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `rbacRolesUsedByList()`

```php
rbacRolesUsedByList($uuid): \OCA\AuthentikAccessSync\Vendor\Authentik\Model\UsedBy[]
```



Get a list of all objects that use this object

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer authorization: authentik
$config = OCA\AuthentikAccessSync\Vendor\Authentik\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OCA\AuthentikAccessSync\Vendor\Authentik\Api\RbacApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$uuid = 'uuid_example'; // string | A UUID string identifying this Role.

try {
    $result = $apiInstance->rbacRolesUsedByList($uuid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RbacApi->rbacRolesUsedByList: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **uuid** | **string**| A UUID string identifying this Role. | |

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
