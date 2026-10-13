# ComputeServices

## Overview

### Available Operations

* [list_services](#list_services) - List services
* [create_service](#create_service) - Create a service
* [get_service](#get_service) - Get a service
* [list_service_events](#list_service_events) - List service events
* [list_service_instances](#list_service_instances) - List observed service instances
* [list_service_logs](#list_service_logs) - List service logs
* [update_service_scaling](#update_service_scaling) - Replace a service scaling policy
* [terminate_service](#terminate_service) - Terminate a service

## list_services

List services

### Example Usage

<!-- UsageSnippet language="python" operationID="listServices" method="get" path="/api/v1/compute/services" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.list_services(limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `state`                                                                       | [Optional[models.ComputeResourceState]](../../models/computeresourcestate.md) | :heavy_minus_sign:                                                            | N/A                                                                           |
| `cursor`                                                                      | *Optional[str]*                                                               | :heavy_minus_sign:                                                            | N/A                                                                           |
| `limit`                                                                       | *Optional[int]*                                                               | :heavy_minus_sign:                                                            | N/A                                                                           |
| `x_on_behalf_of`                                                              | *Optional[str]*                                                               | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |
| `retries`                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)              | :heavy_minus_sign:                                                            | Configuration to override the default retry behavior of the client.           |

### Response

**[models.ListServicesResponse](../../models/listservicesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_service

Create a service

### Example Usage

<!-- UsageSnippet language="python" operationID="createService" method="post" path="/api/v1/compute/services" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.create_service(idempotency_key="<value>", compute={
        "accelerator": "<value>",
        "ephemeral_disk_gb": 709572,
        "gpu_count": 103964,
    }, container={
        "image": "https://loremflickr.com/676/3598?lock=35726374653792",
        "script_b64": "<value>",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `idempotency_key`                                                                         | *str*                                                                                     | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `compute`                                                                                 | [models.ComputeRequest](../../models/computerequest.md)                                   | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `container`                                                                               | [models.ComputeContainerCreateUnion](../../models/computecontainercreateunion.md)         | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `x_on_behalf_of`                                                                          | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | Optional external end-user identifier forwarded by the API gateway.                       |
| `access`                                                                                  | [Optional[models.ComputeAccessCreate]](../../models/computeaccesscreate.md)               | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `limits`                                                                                  | [Optional[models.ComputeLimits]](../../models/computelimits.md)                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `name`                                                                                    | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `placement`                                                                               | [Optional[models.ComputePlacement]](../../models/computeplacement.md)                     | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `service`                                                                                 | [Optional[models.ComputeServiceInput]](../../models/computeserviceinput.md)               | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `volumes`                                                                                 | List[[models.ComputeStandaloneVolumeMount](../../models/computestandalonevolumemount.md)] | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `retries`                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                          | :heavy_minus_sign:                                                                        | Configuration to override the default retry behavior of the client.                       |

### Response

**[models.CreateServiceResponse](../../models/createserviceresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_service

Get a service

### Example Usage

<!-- UsageSnippet language="python" operationID="getService" method="get" path="/api/v1/compute/services/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.get_service(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetServiceResponse](../../models/getserviceresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_service_events

List service events

### Example Usage

<!-- UsageSnippet language="python" operationID="listServiceEvents" method="get" path="/api/v1/compute/services/{id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.list_service_events(id="<id>", limit=50, order="asc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                       | Type                                                                                                                            | Required                                                                                                                        | Description                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                            | *str*                                                                                                                           | :heavy_check_mark:                                                                                                              | N/A                                                                                                                             |
| `cursor`                                                                                                                        | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `limit`                                                                                                                         | *Optional[int]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `order`                                                                                                                         | [Optional[models.ComputeOrder]](../../models/computeorder.md)                                                                   | :heavy_minus_sign:                                                                                                              | asc pages oldest-first (default); desc pages newest-first. A cursor is only valid within a traversal that keeps the same order. |
| `x_on_behalf_of`                                                                                                                | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                             |
| `retries`                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                | :heavy_minus_sign:                                                                                                              | Configuration to override the default retry behavior of the client.                                                             |

### Response

**[models.ListServiceEventsResponse](../../models/listserviceeventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_service_instances

List observed service instances

### Example Usage

<!-- UsageSnippet language="python" operationID="listServiceInstances" method="get" path="/api/v1/compute/services/{id}/instances" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.list_service_instances(id="<id>", limit=50, order="asc", history=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                       | Type                                                                                                                            | Required                                                                                                                        | Description                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                            | *str*                                                                                                                           | :heavy_check_mark:                                                                                                              | N/A                                                                                                                             |
| `state`                                                                                                                         | [Optional[models.ComputeInstanceState]](../../models/computeinstancestate.md)                                                   | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `cursor`                                                                                                                        | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `limit`                                                                                                                         | *Optional[int]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `order`                                                                                                                         | [Optional[models.ComputeOrder]](../../models/computeorder.md)                                                                   | :heavy_minus_sign:                                                                                                              | asc pages oldest-first (default); desc pages newest-first. A cursor is only valid within a traversal that keeps the same order. |
| `history`                                                                                                                       | *Optional[bool]*                                                                                                                | :heavy_minus_sign:                                                                                                              | Include retained terminal service-incarnation history. The default returns only current non-terminal incarnations.              |
| `x_on_behalf_of`                                                                                                                | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                             |
| `retries`                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                | :heavy_minus_sign:                                                                                                              | Configuration to override the default retry behavior of the client.                                                             |

### Response

**[models.ListServiceInstancesResponse](../../models/listserviceinstancesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_service_logs

List service logs

### Example Usage

<!-- UsageSnippet language="python" operationID="listServiceLogs" method="get" path="/api/v1/compute/services/{id}/logs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.list_service_logs(id="<id>", limit=50, order="asc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                       | Type                                                                                                                            | Required                                                                                                                        | Description                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                            | *str*                                                                                                                           | :heavy_check_mark:                                                                                                              | N/A                                                                                                                             |
| `source`                                                                                                                        | [Optional[models.ComputeLogSourceParameter]](../../models/computelogsourceparameter.md)                                         | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `cursor`                                                                                                                        | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `limit`                                                                                                                         | *Optional[int]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |
| `order`                                                                                                                         | [Optional[models.ComputeOrder]](../../models/computeorder.md)                                                                   | :heavy_minus_sign:                                                                                                              | asc pages oldest-first (default); desc pages newest-first. A cursor is only valid within a traversal that keeps the same order. |
| `x_on_behalf_of`                                                                                                                | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                             |
| `retries`                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                | :heavy_minus_sign:                                                                                                              | Configuration to override the default retry behavior of the client.                                                             |

### Response

**[models.ListServiceLogsResponse](../../models/listservicelogsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_service_scaling

Replace a service scaling policy

### Example Usage

<!-- UsageSnippet language="python" operationID="updateServiceScaling" method="patch" path="/api/v1/compute/services/{id}/scaling" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.update_service_scaling(id="<id>", idempotency_key="<value>", max_replicas=693036, min_replicas=178601)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                               | Required                                                                                                                                                                                                                                                                           | Description                                                                                                                                                                                                                                                                        |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                                                                                                                                                               | *str*                                                                                                                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                |
| `idempotency_key`                                                                                                                                                                                                                                                                  | *str*                                                                                                                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                |
| `max_replicas`                                                                                                                                                                                                                                                                     | *int*                                                                                                                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                |
| `min_replicas`                                                                                                                                                                                                                                                                     | *int*                                                                                                                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                |
| `if_match`                                                                                                                                                                                                                                                                         | *Optional[str]*                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                 | Optional strong entity tag containing the current desired scaling-policy generation.                                                                                                                                                                                               |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                   | *Optional[str]*                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                |
| `idle_timeout_seconds`                                                                                                                                                                                                                                                             | *Optional[int]*                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                 | How long demand must stay low before a replica is removed. Required, and at least 1, when min_replicas < max_replicas. A fixed policy (min_replicas == max_replicas) has none: one sent with it is ignored, and a fixed policy reports 0 until clients accept the field's absence. |
| `target_concurrency_per_replica`                                                                                                                                                                                                                                                   | *Optional[int]*                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                 | N/A                                                                                                                                                                                                                                                                                |
| `retries`                                                                                                                                                                                                                                                                          | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                                                 | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                |

### Response

**[models.UpdateServiceScalingResponse](../../models/updateservicescalingresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## terminate_service

Terminate a service

### Example Usage

<!-- UsageSnippet language="python" operationID="terminateService" method="post" path="/api/v1/compute/services/{id}/terminate" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_services.terminate_service(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.TerminateServiceResponse](../../models/terminateserviceresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |