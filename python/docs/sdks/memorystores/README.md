# Llm.MemoryStores

## Overview

### Available Operations

* [create](#create) - Create memory store
* [list](#list) - List memory stores
* [get](#get) - Retrieve memory store
* [update](#update) - Update memory store
* [delete](#delete) - Delete memory store
* [create_entry](#create_entry) - Create memory entry
* [list_entries](#list_entries) - List memory entries
* [get_entry](#get_entry) - Retrieve memory entry
* [update_entry](#update_entry) - Update memory entry
* [delete_entry](#delete_entry) - Delete memory entry

## create

Creates a memory store for persistent agent notes. Stores are private by default and can be shared across the workspace.

### Example Usage

<!-- UsageSnippet language="python" operationID="createMemoryStore" method="post" path="/api/v1/llm/memory_stores" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.create(name="Bug Reports", description="Persistent bug reports seen by the triage agent.", instructions="Store every confirmed bug report here using one markdown file per product area.", visibility="workspace")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `name`                                                                          | *str*                                                                           | :heavy_check_mark:                                                              | N/A                                                                             |
| `x_on_behalf_of`                                                                | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | Optional external end-user identifier forwarded by the API gateway.             |
| `description`                                                                   | *OptionalNullable[str]*                                                         | :heavy_minus_sign:                                                              | N/A                                                                             |
| `instructions`                                                                  | *OptionalNullable[str]*                                                         | :heavy_minus_sign:                                                              | N/A                                                                             |
| `visibility`                                                                    | [Optional[models.MemoryStoreVisibility]](../../models/memorystorevisibility.md) | :heavy_minus_sign:                                                              | N/A                                                                             |
| `metadata`                                                                      | Dict[str, *str*]                                                                | :heavy_minus_sign:                                                              | N/A                                                                             |
| `retries`                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                | :heavy_minus_sign:                                                              | Configuration to override the default retry behavior of the client.             |

### Response

**[models.MemoryStore](../../models/memorystore.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list

List memory stores

### Example Usage

<!-- UsageSnippet language="python" operationID="listMemoryStores" method="get" path="/api/v1/llm/memory_stores" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.list(limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `limit`                                                                         | *Optional[int]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |
| `order`                                                                         | [Optional[models.ListMemoryStoresOrder]](../../models/listmemorystoresorder.md) | :heavy_minus_sign:                                                              | N/A                                                                             |
| `after`                                                                         | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |
| `x_on_behalf_of`                                                                | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | Optional external end-user identifier forwarded by the API gateway.             |
| `retries`                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                | :heavy_minus_sign:                                                              | Configuration to override the default retry behavior of the client.             |

### Response

**[models.MemoryStoreList](../../models/memorystorelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Retrieve memory store

### Example Usage

<!-- UsageSnippet language="python" operationID="getMemoryStore" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.get(memory_store_id="mem_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `memory_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.MemoryStore](../../models/memorystore.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update

Update memory store

### Example Usage

<!-- UsageSnippet language="python" operationID="updateMemoryStore" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.update(memory_store_id="mem_aa87e2b1112a455b8deabed784372198", description="Persistent bug reports seen by the triage agent and support team.", visibility="workspace")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     | Example                                                                         |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `memory_store_id`                                                               | *str*                                                                           | :heavy_check_mark:                                                              | N/A                                                                             | mem_aa87e2b1112a455b8deabed784372198                                            |
| `x_on_behalf_of`                                                                | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | Optional external end-user identifier forwarded by the API gateway.             |                                                                                 |
| `name`                                                                          | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `description`                                                                   | *OptionalNullable[str]*                                                         | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `instructions`                                                                  | *OptionalNullable[str]*                                                         | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `visibility`                                                                    | [Optional[models.MemoryStoreVisibility]](../../models/memorystorevisibility.md) | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `metadata`                                                                      | Dict[str, *str*]                                                                | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `retries`                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                | :heavy_minus_sign:                                                              | Configuration to override the default retry behavior of the client.             |                                                                                 |

### Response

**[models.MemoryStore](../../models/memorystore.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

Delete memory store

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteMemoryStore" method="delete" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.delete(memory_store_id="mem_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `memory_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.MemoryStoreDeleted](../../models/memorystoredeleted.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_entry

Create memory entry

### Example Usage

<!-- UsageSnippet language="python" operationID="createMemoryEntry" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}/entries" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.create_entry(memory_store_id="mem_aa87e2b1112a455b8deabed784372198", path="reports/login-rate-limit.md", content="# Login rate limit\n\nReported by Acme on 2026-05-05.")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `memory_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `path`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `content`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `metadata`                                                          | Dict[str, *str*]                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.MemoryEntry](../../models/memoryentry.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_entries

List memory entries

### Example Usage

<!-- UsageSnippet language="python" operationID="listMemoryEntries" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}/entries" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.list_entries(memory_store_id="mem_aa87e2b1112a455b8deabed784372198", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       | Example                                                                           |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `memory_store_id`                                                                 | *str*                                                                             | :heavy_check_mark:                                                                | N/A                                                                               | mem_aa87e2b1112a455b8deabed784372198                                              |
| `limit`                                                                           | *Optional[int]*                                                                   | :heavy_minus_sign:                                                                | N/A                                                                               |                                                                                   |
| `order`                                                                           | [Optional[models.ListMemoryEntriesOrder]](../../models/listmemoryentriesorder.md) | :heavy_minus_sign:                                                                | N/A                                                                               |                                                                                   |
| `after`                                                                           | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | N/A                                                                               |                                                                                   |
| `x_on_behalf_of`                                                                  | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | Optional external end-user identifier forwarded by the API gateway.               |                                                                                   |
| `retries`                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                  | :heavy_minus_sign:                                                                | Configuration to override the default retry behavior of the client.               |                                                                                   |

### Response

**[models.MemoryEntryList](../../models/memoryentrylist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_entry

Retrieve memory entry

### Example Usage

<!-- UsageSnippet language="python" operationID="getMemoryEntry" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.get_entry(memory_store_id="mem_aa87e2b1112a455b8deabed784372198", entry_id="mem_entry_bb98f3c2223b566c9dfbcef895483209")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `memory_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `entry_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_entry_bb98f3c2223b566c9dfbcef895483209                          |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.MemoryEntry](../../models/memoryentry.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_entry

Update memory entry

### Example Usage

<!-- UsageSnippet language="python" operationID="updateMemoryEntry" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.update_entry(memory_store_id="mem_aa87e2b1112a455b8deabed784372198", entry_id="mem_entry_bb98f3c2223b566c9dfbcef895483209", content="# Login rate limit\n\nReported by Acme and Globex.", if_match="c378790c771dbb9651bae4c156f88a6b684d5b520a588e5b33d641aa96103680")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `memory_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `entry_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_entry_bb98f3c2223b566c9dfbcef895483209                          |
| `content`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `if_match`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `metadata`                                                          | Dict[str, *str*]                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.MemoryEntry](../../models/memoryentry.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_entry

Delete memory entry

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteMemoryEntry" method="delete" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.memory_stores.delete_entry(memory_store_id="mem_aa87e2b1112a455b8deabed784372198", entry_id="mem_entry_bb98f3c2223b566c9dfbcef895483209", if_match="c378790c771dbb9651bae4c156f88a6b684d5b520a588e5b33d641aa96103680")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `memory_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `entry_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mem_entry_bb98f3c2223b566c9dfbcef895483209                          |
| `if_match_param`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `if_match`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.MemoryEntryDeleted](../../models/memoryentrydeleted.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |