# ComputeJobs

## Overview

### Available Operations

* [list_jobs](#list_jobs) - List jobs
* [create_job](#create_job) - Create a job
* [get_job](#get_job) - Get a job
* [list_job_events](#list_job_events) - List job events
* [list_job_instances](#list_job_instances) - List observed job instances
* [list_job_logs](#list_job_logs) - List job logs
* [terminate_job](#terminate_job) - Terminate a job

## list_jobs

List jobs

### Example Usage

<!-- UsageSnippet language="python" operationID="listJobs" method="get" path="/api/v1/compute/jobs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_jobs.list_jobs(limit=50)

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

**[models.ListJobsResponse](../../models/listjobsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_job

Create a job

### Example Usage

<!-- UsageSnippet language="python" operationID="createJob" method="post" path="/api/v1/compute/jobs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_jobs.create_job(idempotency_key="<value>", compute={
        "accelerator": "<value>",
        "ephemeral_disk_gb": 166801,
        "gpu_count": 580753,
    }, container={
        "image": "https://picsum.photos/seed/vABc84qaab/2231/967",
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
| `volumes`                                                                                 | List[[models.ComputeStandaloneVolumeMount](../../models/computestandalonevolumemount.md)] | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `retries`                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                          | :heavy_minus_sign:                                                                        | Configuration to override the default retry behavior of the client.                       |

### Response

**[models.CreateJobResponse](../../models/createjobresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_job

Get a job

### Example Usage

<!-- UsageSnippet language="python" operationID="getJob" method="get" path="/api/v1/compute/jobs/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_jobs.get_job(id="<id>")

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

**[models.GetJobResponse](../../models/getjobresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_job_events

List job events

### Example Usage

<!-- UsageSnippet language="python" operationID="listJobEvents" method="get" path="/api/v1/compute/jobs/{id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_jobs.list_job_events(id="<id>", limit=50, order="asc")

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

**[models.ListJobEventsResponse](../../models/listjobeventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_job_instances

List observed job instances

### Example Usage

<!-- UsageSnippet language="python" operationID="listJobInstances" method="get" path="/api/v1/compute/jobs/{id}/instances" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_jobs.list_job_instances(id="<id>", limit=50, order="asc")

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
| `x_on_behalf_of`                                                                                                                | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                             |
| `retries`                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                | :heavy_minus_sign:                                                                                                              | Configuration to override the default retry behavior of the client.                                                             |

### Response

**[models.ListJobInstancesResponse](../../models/listjobinstancesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_job_logs

List job logs

### Example Usage

<!-- UsageSnippet language="python" operationID="listJobLogs" method="get" path="/api/v1/compute/jobs/{id}/logs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_jobs.list_job_logs(id="<id>", limit=50, order="asc")

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

**[models.ListJobLogsResponse](../../models/listjoblogsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## terminate_job

Terminate a job

### Example Usage

<!-- UsageSnippet language="python" operationID="terminateJob" method="post" path="/api/v1/compute/jobs/{id}/terminate" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_jobs.terminate_job(id="<id>")

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

**[models.TerminateJobResponse](../../models/terminatejobresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |