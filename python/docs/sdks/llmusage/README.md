# Llm.Usage

## Overview

### Available Operations

* [completions](#completions) - Get completions usage
* [responses](#responses) - Get responses usage
* [conversations](#conversations) - Get conversations usage
* [embeddings](#embeddings) - Get embeddings usage
* [extract](#extract) - Get extract usage
* [classify](#classify) - Get classify usage
* [vector_stores](#vector_stores) - Get vector stores usage
* [files](#files) - Get files usage
* [costs](#costs) - Get cost by model

## completions

Retrieve usage metrics for chat completions, aggregated from the ChatCompletion table.

### Example Usage

<!-- UsageSnippet language="python" operationID="getCompletionsUsage" method="get" path="/api/v1/llm/usage/completions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.completions(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "model",
    ], models=[
        "meetkai:functionary-urdu-mini-pak",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           | Example                                                               |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `start_time`                                                          | *int*                                                                 | :heavy_check_mark:                                                    | N/A                                                                   | 1704067200                                                            |
| `end_time`                                                            | *Optional[int]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   | 1704153600                                                            |
| `bucket_width`                                                        | [Optional[models.BucketWidth]](../../models/bucketwidth.md)           | :heavy_minus_sign:                                                    | N/A                                                                   | 1d                                                                    |
| `limit`                                                               | *Optional[int]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   | 30                                                                    |
| `page`                                                                | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   | cursor_abc123                                                         |
| `user_ids`                                                            | List[*str*]                                                           | :heavy_minus_sign:                                                    | N/A                                                                   | [<br/>"user_123",<br/>"user_456"<br/>]                                |
| `external_user_ids`                                                   | List[*str*]                                                           | :heavy_minus_sign:                                                    | N/A                                                                   | [<br/>"sub_123"<br/>]                                                 |
| `all_orgs`                                                            | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | N/A                                                                   |                                                                       |
| `org_ids`                                                             | List[*str*]                                                           | :heavy_minus_sign:                                                    | N/A                                                                   | [<br/>"org_123"<br/>]                                                 |
| `group_by`                                                            | List[[models.CompletionsGroupBy](../../models/completionsgroupby.md)] | :heavy_minus_sign:                                                    | N/A                                                                   | [<br/>"model"<br/>]                                                   |
| `models`                                                              | List[*str*]                                                           | :heavy_minus_sign:                                                    | N/A                                                                   | [<br/>"meetkai:functionary-urdu-mini-pak"<br/>]                       |
| `x_on_behalf_of`                                                      | *Optional[str]*                                                       | :heavy_minus_sign:                                                    | Optional external end-user identifier forwarded by the API gateway.   |                                                                       |
| `retries`                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)      | :heavy_minus_sign:                                                    | Configuration to override the default retry behavior of the client.   |                                                                       |

### Response

**[models.GetCompletionsUsageResponse](../../models/getcompletionsusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## responses

Retrieve usage metrics for agent responses, aggregated from the Response table.

### Example Usage

<!-- UsageSnippet language="python" operationID="getResponsesUsage" method="get" path="/api/v1/llm/usage/responses" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.responses(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "model",
        "background",
    ], models=[
        "meetkai:functionary-urdu-mini-pak",
    ], background=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `start_time`                                                        | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1704067200                                                          |
| `end_time`                                                          | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 1704153600                                                          |
| `bucket_width`                                                      | [Optional[models.BucketWidth]](../../models/bucketwidth.md)         | :heavy_minus_sign:                                                  | N/A                                                                 | 1d                                                                  |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 30                                                                  |
| `page`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | cursor_abc123                                                       |
| `user_ids`                                                          | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"user_123",<br/>"user_456"<br/>]                              |
| `external_user_ids`                                                 | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"sub_123"<br/>]                                               |
| `all_orgs`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `org_ids`                                                           | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"org_123"<br/>]                                               |
| `group_by`                                                          | List[[models.ResponsesGroupBy](../../models/responsesgroupby.md)]   | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"model",<br/>"background"<br/>]                               |
| `models`                                                            | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"meetkai:functionary-urdu-mini-pak"<br/>]                     |
| `background`                                                        | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 | false                                                               |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetResponsesUsageResponse](../../models/getresponsesusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## conversations

Retrieve usage metrics for conversation operations.

### Example Usage

<!-- UsageSnippet language="python" operationID="getConversationsUsage" method="get" path="/api/v1/llm/usage/conversations" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.conversations(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "user_id",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `start_time`                                                              | *int*                                                                     | :heavy_check_mark:                                                        | N/A                                                                       | 1704067200                                                                |
| `end_time`                                                                | *Optional[int]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       | 1704153600                                                                |
| `bucket_width`                                                            | [Optional[models.BucketWidth]](../../models/bucketwidth.md)               | :heavy_minus_sign:                                                        | N/A                                                                       | 1d                                                                        |
| `limit`                                                                   | *Optional[int]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       | 30                                                                        |
| `page`                                                                    | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       | cursor_abc123                                                             |
| `user_ids`                                                                | List[*str*]                                                               | :heavy_minus_sign:                                                        | N/A                                                                       | [<br/>"user_123",<br/>"user_456"<br/>]                                    |
| `external_user_ids`                                                       | List[*str*]                                                               | :heavy_minus_sign:                                                        | N/A                                                                       | [<br/>"sub_123"<br/>]                                                     |
| `all_orgs`                                                                | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       |                                                                           |
| `org_ids`                                                                 | List[*str*]                                                               | :heavy_minus_sign:                                                        | N/A                                                                       | [<br/>"org_123"<br/>]                                                     |
| `group_by`                                                                | List[[models.ConversationsGroupBy](../../models/conversationsgroupby.md)] | :heavy_minus_sign:                                                        | N/A                                                                       | [<br/>"user_id"<br/>]                                                     |
| `x_on_behalf_of`                                                          | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | Optional external end-user identifier forwarded by the API gateway.       |                                                                           |
| `retries`                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)          | :heavy_minus_sign:                                                        | Configuration to override the default retry behavior of the client.       |                                                                           |

### Response

**[models.GetConversationsUsageResponse](../../models/getconversationsusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## embeddings

Retrieve usage metrics for embedding operations.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEmbeddingsUsage" method="get" path="/api/v1/llm/usage/embeddings" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.embeddings(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "model",
    ], models=[
        "auto",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `start_time`                                                        | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1704067200                                                          |
| `end_time`                                                          | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 1704153600                                                          |
| `bucket_width`                                                      | [Optional[models.BucketWidth]](../../models/bucketwidth.md)         | :heavy_minus_sign:                                                  | N/A                                                                 | 1d                                                                  |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 30                                                                  |
| `page`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | cursor_abc123                                                       |
| `user_ids`                                                          | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"user_123",<br/>"user_456"<br/>]                              |
| `external_user_ids`                                                 | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"sub_123"<br/>]                                               |
| `all_orgs`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `org_ids`                                                           | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"org_123"<br/>]                                               |
| `group_by`                                                          | List[[models.EmbeddingsGroupBy](../../models/embeddingsgroupby.md)] | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"model"<br/>]                                                 |
| `models`                                                            | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"auto"<br/>]                                                  |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetEmbeddingsUsageResponse](../../models/getembeddingsusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## extract

Retrieve usage metrics for extract operations.

### Example Usage

<!-- UsageSnippet language="python" operationID="getExtractUsage" method="get" path="/api/v1/llm/usage/extract" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.extract(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "model",
    ], models=[
        "meetkai:functionary-urdu-mini-pak",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `start_time`                                                        | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1704067200                                                          |
| `end_time`                                                          | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 1704153600                                                          |
| `bucket_width`                                                      | [Optional[models.BucketWidth]](../../models/bucketwidth.md)         | :heavy_minus_sign:                                                  | N/A                                                                 | 1d                                                                  |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 30                                                                  |
| `page`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | cursor_abc123                                                       |
| `user_ids`                                                          | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"user_123",<br/>"user_456"<br/>]                              |
| `external_user_ids`                                                 | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"sub_123"<br/>]                                               |
| `all_orgs`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `org_ids`                                                           | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"org_123"<br/>]                                               |
| `group_by`                                                          | List[[models.ExtractGroupBy](../../models/extractgroupby.md)]       | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"model"<br/>]                                                 |
| `models`                                                            | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"meetkai:functionary-urdu-mini-pak"<br/>]                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetExtractUsageResponse](../../models/getextractusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## classify

Retrieve usage metrics for classify operations.

### Example Usage

<!-- UsageSnippet language="python" operationID="getClassifyUsage" method="get" path="/api/v1/llm/usage/classify" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.classify(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "model",
    ], models=[
        "meetkai:functionary-urdu-mini-pak",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `start_time`                                                        | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1704067200                                                          |
| `end_time`                                                          | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 1704153600                                                          |
| `bucket_width`                                                      | [Optional[models.BucketWidth]](../../models/bucketwidth.md)         | :heavy_minus_sign:                                                  | N/A                                                                 | 1d                                                                  |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 30                                                                  |
| `page`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | cursor_abc123                                                       |
| `user_ids`                                                          | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"user_123",<br/>"user_456"<br/>]                              |
| `external_user_ids`                                                 | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"sub_123"<br/>]                                               |
| `all_orgs`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `org_ids`                                                           | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"org_123"<br/>]                                               |
| `group_by`                                                          | List[[models.ClassifyGroupBy](../../models/classifygroupby.md)]     | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"model"<br/>]                                                 |
| `models`                                                            | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"meetkai:functionary-urdu-mini-pak"<br/>]                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetClassifyUsageResponse](../../models/getclassifyusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## vector_stores

Retrieve usage metrics for vector storage operations.

### Example Usage

<!-- UsageSnippet language="python" operationID="getVectorStoresUsage" method="get" path="/api/v1/llm/usage/vector_stores" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.vector_stores(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "user_id",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `start_time`                                                            | *int*                                                                   | :heavy_check_mark:                                                      | N/A                                                                     | 1704067200                                                              |
| `end_time`                                                              | *Optional[int]*                                                         | :heavy_minus_sign:                                                      | N/A                                                                     | 1704153600                                                              |
| `bucket_width`                                                          | [Optional[models.BucketWidth]](../../models/bucketwidth.md)             | :heavy_minus_sign:                                                      | N/A                                                                     | 1d                                                                      |
| `limit`                                                                 | *Optional[int]*                                                         | :heavy_minus_sign:                                                      | N/A                                                                     | 30                                                                      |
| `page`                                                                  | *Optional[str]*                                                         | :heavy_minus_sign:                                                      | N/A                                                                     | cursor_abc123                                                           |
| `user_ids`                                                              | List[*str*]                                                             | :heavy_minus_sign:                                                      | N/A                                                                     | [<br/>"user_123",<br/>"user_456"<br/>]                                  |
| `external_user_ids`                                                     | List[*str*]                                                             | :heavy_minus_sign:                                                      | N/A                                                                     | [<br/>"sub_123"<br/>]                                                   |
| `all_orgs`                                                              | *Optional[str]*                                                         | :heavy_minus_sign:                                                      | N/A                                                                     |                                                                         |
| `org_ids`                                                               | List[*str*]                                                             | :heavy_minus_sign:                                                      | N/A                                                                     | [<br/>"org_123"<br/>]                                                   |
| `group_by`                                                              | List[[models.VectorStoresGroupBy](../../models/vectorstoresgroupby.md)] | :heavy_minus_sign:                                                      | N/A                                                                     | [<br/>"user_id"<br/>]                                                   |
| `x_on_behalf_of`                                                        | *Optional[str]*                                                         | :heavy_minus_sign:                                                      | Optional external end-user identifier forwarded by the API gateway.     |                                                                         |
| `retries`                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)        | :heavy_minus_sign:                                                      | Configuration to override the default retry behavior of the client.     |                                                                         |

### Response

**[models.GetVectorStoresUsageResponse](../../models/getvectorstoresusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## files

Retrieve bytes of files created per period from durable file creation events. This does not reflect current retained storage, buckets remain counted after file deletion, and grouped results collapse by requested output dimensions rather than one row per UserContext.

### Example Usage

<!-- UsageSnippet language="python" operationID="getFilesUsage" method="get" path="/api/v1/llm/usage/files" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.files(start_time=1704067200, end_time=1704153600, bucket_width="1d", limit=30, page="cursor_abc123", user_ids=[
        "user_123",
        "user_456",
    ], external_user_ids=[
        "sub_123",
    ], org_ids=[
        "org_123",
    ], group_by=[
        "user_id",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `start_time`                                                        | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1704067200                                                          |
| `end_time`                                                          | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 1704153600                                                          |
| `bucket_width`                                                      | [Optional[models.BucketWidth]](../../models/bucketwidth.md)         | :heavy_minus_sign:                                                  | N/A                                                                 | 1d                                                                  |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 30                                                                  |
| `page`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | cursor_abc123                                                       |
| `user_ids`                                                          | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"user_123",<br/>"user_456"<br/>]                              |
| `external_user_ids`                                                 | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"sub_123"<br/>]                                               |
| `all_orgs`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `org_ids`                                                           | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"org_123"<br/>]                                               |
| `group_by`                                                          | List[[models.FilesGroupBy](../../models/filesgroupby.md)]           | :heavy_minus_sign:                                                  | N/A                                                                 | [<br/>"user_id"<br/>]                                               |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetFilesUsageResponse](../../models/getfilesusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## costs

Aggregates spend by model over a time range, priced in the cluster currency from the model price book. Org-scoped: org admins see their org; cluster admins may pass `org_id`. Includes billable work with no usage row of its own (store=false responses, agent tool calls), so totals cover all LLM spend. Platform-wide, cross-service cost reporting lives in the budgeting API (/api/v1/budgeting/usage/costs).

### Example Usage

<!-- UsageSnippet language="python" operationID="getCostsUsage" method="get" path="/api/v1/llm/usage/costs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.usage.costs(start_time=612474, end_time=211313)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                        | Type                                                                                                                                                                             | Required                                                                                                                                                                         | Description                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `start_time`                                                                                                                                                                     | *int*                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                               | N/A                                                                                                                                                                              |
| `end_time`                                                                                                                                                                       | *int*                                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                               | N/A                                                                                                                                                                              |
| `org_id`                                                                                                                                                                         | *Optional[str]*                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                               | N/A                                                                                                                                                                              |
| `group_by`                                                                                                                                                                       | [Optional[models.GroupBy]](../../models/groupby.md)                                                                                                                              | :heavy_minus_sign:                                                                                                                                                               | Group cost by model / api_key_id (tenant key) / team_id (sub-tenant within an org) / external_user_id (caller-supplied end user, X-On-Behalf-Of, for resale chargeback) / org_id |
| `x_on_behalf_of`                                                                                                                                                                 | *Optional[str]*                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                                                                              |
| `retries`                                                                                                                                                                        | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                 | :heavy_minus_sign:                                                                                                                                                               | Configuration to override the default retry behavior of the client.                                                                                                              |

### Response

**[models.UsageCostsResponse](../../models/usagecostsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |