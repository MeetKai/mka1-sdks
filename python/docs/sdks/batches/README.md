# Llm.Batches

## Overview

### Available Operations

* [create](#create) - Create a batch
* [list](#list) - List batches
* [get](#get) - Get a batch
* [cancel](#cancel) - Cancel a batch

## create

Creates and executes a batch from an uploaded JSONL file of requests. Each line must have custom_id, method, url, and body fields. Text batches also require write:responses.

### Example Usage

<!-- UsageSnippet language="python" operationID="createBatch" method="post" path="/api/v1/llm/batches" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.batches.create(input_file_id="file_abc123", endpoint="/v1/chat/completions", metadata={
        "description": "evaluation job",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `input_file_id`                                                     | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `endpoint`                                                          | [models.BatchEndpoint](../../models/batchendpoint.md)               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `metadata`                                                          | Dict[str, *str*]                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.BatchObject](../../models/batchobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list

Returns a paginated list of batches owned by the authenticated user.

### Example Usage

<!-- UsageSnippet language="python" operationID="listBatches" method="get" path="/api/v1/llm/batches" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.batches.list(limit=20)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `after`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListBatchesResponse](../../models/listbatchesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Retrieves a batch by its ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="getBatch" method="get" path="/api/v1/llm/batches/{batch_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.batches.get(batch_id="batch_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `batch_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | batch_aa87e2b1112a455b8deabed784372198                              |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.BatchObject](../../models/batchobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## cancel

Cancels an in-progress batch. The batch status changes to cancelling, and remaining requests will not be processed.

### Example Usage

<!-- UsageSnippet language="python" operationID="cancelBatch" method="post" path="/api/v1/llm/batches/{batch_id}/cancel" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.batches.cancel(batch_id="batch_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `batch_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | batch_aa87e2b1112a455b8deabed784372198                              |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.BatchObject](../../models/batchobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |