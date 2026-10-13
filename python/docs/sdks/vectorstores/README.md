# Llm.VectorStores

## Overview

### Available Operations

* [create](#create) - Create a vector store
* [list](#list) - List vector stores
* [get](#get) - Retrieve a vector store
* [update](#update) - Modify a vector store
* [delete](#delete) - Delete a vector store
* [search](#search) - Search a vector store
* [create_file](#create_file) - Add a file to a vector store
* [list_files](#list_files) - List files in a vector store
* [get_file](#get_file) - Retrieve a vector store file
* [update_file](#update_file) - Update file attributes
* [delete_file](#delete_file) - Remove file from vector store
* [get_file_content](#get_file_content) - Retrieve parsed file content
* [create_file_batch](#create_file_batch) - Batch add multiple files to vector store
* [get_file_batch](#get_file_batch) - Retrieve file batch status
* [cancel_file_batch](#cancel_file_batch) - Cancel batch file processing
* [list_files_in_batch](#list_files_in_batch) - List files in a batch

## create

Creates a new vector store for storing and searching through document embeddings.

### Example Usage

<!-- UsageSnippet language="python" operationID="createVectorStore" method="post" path="/api/v1/llm/vector_stores" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.create(name="Product Documentation", description="Vector store for product manuals and documentation", file_ids=[
        "file-abc123",
    ], expires_after={
        "anchor": "last_active_at",
        "days": 30,
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                | *Optional[str]*                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                             |
| `name`                                                                                                                                                                                                                                                                          | *Optional[str]*                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | The name of the vector store.                                                                                                                                                                                                                                                   |
| `description`                                                                                                                                                                                                                                                                   | *Optional[str]*                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | A description for the vector store. Can be used to describe the vector store's purpose.                                                                                                                                                                                         |
| `file_ids`                                                                                                                                                                                                                                                                      | List[*str*]                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                              | A list of File IDs that the vector store should use. Useful for tools like file_search that can access files. At most 500 per request.                                                                                                                                          |
| `expires_after`                                                                                                                                                                                                                                                                 | [Optional[models.CreateVectorStoreRequestExpiresAfter]](../../models/createvectorstorerequestexpiresafter.md)                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                                              | The expiration policy for a vector store.                                                                                                                                                                                                                                       |
| `chunking_strategy`                                                                                                                                                                                                                                                             | [Optional[models.CreateVectorStoreRequestChunkingStrategy]](../../models/createvectorstorerequestchunkingstrategy.md)                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                              | The chunking strategy used to chunk the file(s). If not set, will use the auto strategy. Only applicable if file_ids is non-empty.                                                                                                                                              |
| `metadata`                                                                                                                                                                                                                                                                      | Dict[str, *str*]                                                                                                                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                                                                              | Set of 16 key-value pairs that can be attached to an object. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters.                                                                                               |
| `embedding_model`                                                                                                                                                                                                                                                               | *Optional[str]*                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | The embedding model to use. Defaults to the auto-configured model if not specified.                                                                                                                                                                                             |
| `embedding_dimensions`                                                                                                                                                                                                                                                          | *Optional[int]*                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | The number of dimensions for the embedding vectors. Only supported for models with flexible dimensions. If not specified, uses the model's default dimensions.                                                                                                                  |
| `retrieval_mode`                                                                                                                                                                                                                                                                | [Optional[models.CreateVectorStoreRequestRetrievalMode]](../../models/createvectorstorerequestretrievalmode.md)                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | Retrieval mode, frozen at creation (cannot be changed later). 'vector' (default): standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted from every chunk at ingest (metered against your usage) and search traverses the knowledge graph. |
| `extraction_model`                                                                                                                                                                                                                                                              | *Optional[str]*                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | Model used for entity/relation extraction on graph stores (ingest-time triplet extraction and query-entity extraction). Defaults to the auto-configured model, resolved at creation time — same contract as embedding_model. Only valid when retrieval_mode is 'graph'.         |
| `max_hops`                                                                                                                                                                                                                                                                      | *Optional[int]*                                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                              | Graph expansion depth for graph-mode queries (1-4, engine default 2). Only valid for graph stores.                                                                                                                                                                              |
| `retries`                                                                                                                                                                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                                                                              | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                             |

### Response

**[models.VectorStore](../../models/vectorstore.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list

Retrieves a paginated list of all vector stores for the authenticated user.

### Example Usage

<!-- UsageSnippet language="python" operationID="listVectorStores" method="get" path="/api/v1/llm/vector_stores" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.list(limit=20, order="desc", after="vs_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `limit`                                                                                                           | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               | 20                                                                                                                |
| `order`                                                                                                           | [Optional[models.ListVectorStoresOrder]](../../models/listvectorstoresorder.md)                                   | :heavy_minus_sign:                                                                                                | Sort order by the created_at timestamp of the objects. 'asc' for ascending order and 'desc' for descending order. | desc                                                                                                              |
| `after`                                                                                                           | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               | vs_abc123                                                                                                         |
| `before`                                                                                                          | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `x_on_behalf_of`                                                                                                  | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |
| `retries`                                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                  | :heavy_minus_sign:                                                                                                | Configuration to override the default retry behavior of the client.                                               |                                                                                                                   |

### Response

**[models.VectorStoreList](../../models/vectorstorelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Retrieves a vector store by its ID. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="getVectorStore" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.get(vector_store_id="vs_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vector_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.VectorStore](../../models/vectorstore.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update

Updates the properties of an existing vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="modifyVectorStore" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.update(vector_store_id="vs_abc123", name="Updated Product Documentation", expires_after={
        "anchor": "last_active_at",
        "days": 60,
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                         | Type                                                                                                                                                                              | Required                                                                                                                                                                          | Description                                                                                                                                                                       | Example                                                                                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `vector_store_id`                                                                                                                                                                 | *str*                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                | N/A                                                                                                                                                                               | vs_abc123                                                                                                                                                                         |
| `x_on_behalf_of`                                                                                                                                                                  | *Optional[str]*                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                                                                                               |                                                                                                                                                                                   |
| `name`                                                                                                                                                                            | *OptionalNullable[str]*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                | The name of the vector store.                                                                                                                                                     |                                                                                                                                                                                   |
| `expires_after`                                                                                                                                                                   | [OptionalNullable[models.ModifyVectorStoreRequestExpiresAfter]](../../models/modifyvectorstorerequestexpiresafter.md)                                                             | :heavy_minus_sign:                                                                                                                                                                | The expiration policy for a vector store.                                                                                                                                         |                                                                                                                                                                                   |
| `metadata`                                                                                                                                                                        | Dict[str, *str*]                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                | Set of 16 key-value pairs that can be attached to an object. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters. |                                                                                                                                                                                   |
| `retries`                                                                                                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                | Configuration to override the default retry behavior of the client.                                                                                                               |                                                                                                                                                                                   |

### Response

**[models.VectorStore](../../models/vectorstore.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

Permanently deletes a vector store and its associated embeddings.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteVectorStore" method="delete" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.delete(vector_store_id="vs_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vector_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.VectorStoreDeletionStatus](../../models/vectorstoredeletionstatus.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## search

Performs semantic search within a vector store to find the most relevant document chunks for a query. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="searchVectorStore" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/search" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.search(vector_store_id="vs_abc123", query="How do I reset my password?", max_num_results=5, rewrite_query=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `vector_store_id`                                                                                                 | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               | vs_abc123                                                                                                         |
| `query`                                                                                                           | [models.Query](../../models/query.md)                                                                             | :heavy_check_mark:                                                                                                | A query string for a search, or an array of query strings.                                                        |                                                                                                                   |
| `x_on_behalf_of`                                                                                                  | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |
| `filters`                                                                                                         | [Optional[models.FilterUnion]](../../models/filterunion.md)                                                       | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `max_num_results`                                                                                                 | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | The maximum number of results to return. This number should be between 1 and 50 inclusive.                        |                                                                                                                   |
| `ranking_options`                                                                                                 | [Optional[models.SearchVectorStoreRequestRankingOptions]](../../models/searchvectorstorerequestrankingoptions.md) | :heavy_minus_sign:                                                                                                | Ranking options for search.                                                                                       |                                                                                                                   |
| `rewrite_query`                                                                                                   | *Optional[bool]*                                                                                                  | :heavy_minus_sign:                                                                                                | Whether to rewrite the natural language query for vector search.                                                  |                                                                                                                   |
| `retries`                                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                  | :heavy_minus_sign:                                                                                                | Configuration to override the default retry behavior of the client.                                               |                                                                                                                   |

### Response

**[models.VectorStoreSearchResults](../../models/vectorstoresearchresults.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_file

Adds a file to a vector store for semantic search indexing. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="createVectorStoreFile" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/files" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.create_file(vector_store_id="vs_abc123", file_id="file-abc123", attributes={
        "category": "manual",
        "version": "2.0",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                               | Type                                                                                                                                                                                                    | Required                                                                                                                                                                                                | Description                                                                                                                                                                                             | Example                                                                                                                                                                                                 |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `vector_store_id`                                                                                                                                                                                       | *str*                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                      | N/A                                                                                                                                                                                                     | vs_abc123                                                                                                                                                                                               |
| `file_id`                                                                                                                                                                                               | *str*                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                      | A File ID that the vector store should use. Useful for tools like file_search that can access files.                                                                                                    |                                                                                                                                                                                                         |
| `x_on_behalf_of`                                                                                                                                                                                        | *Optional[str]*                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                     |                                                                                                                                                                                                         |
| `attributes`                                                                                                                                                                                            | Dict[str, [models.CreateVectorStoreFileRequestAttributes](../../models/createvectorstorefilerequestattributes.md)]                                                                                      | :heavy_minus_sign:                                                                                                                                                                                      | Set of 16 key-value pairs that can be attached to an object. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters, booleans, or numbers. |                                                                                                                                                                                                         |
| `chunking_strategy`                                                                                                                                                                                     | [Optional[models.CreateVectorStoreFileRequestChunkingStrategy]](../../models/createvectorstorefilerequestchunkingstrategy.md)                                                                           | :heavy_minus_sign:                                                                                                                                                                                      | The chunking strategy used to chunk the file(s). If not set, will use the auto strategy.                                                                                                                |                                                                                                                                                                                                         |
| `retries`                                                                                                                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                      | Configuration to override the default retry behavior of the client.                                                                                                                                     |                                                                                                                                                                                                         |

### Response

**[models.VectorStoreFile](../../models/vectorstorefile.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_files

Retrieves a paginated list of all files in a specific vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="listVectorStoreFiles" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.list_files(vector_store_id="vs_abc123", limit=20, order="desc", after="file-abc123", filter_="completed")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `vector_store_id`                                                                                                 | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               | vs_abc123                                                                                                         |
| `limit`                                                                                                           | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               | 20                                                                                                                |
| `order`                                                                                                           | [Optional[models.ListVectorStoreFilesOrder]](../../models/listvectorstorefilesorder.md)                           | :heavy_minus_sign:                                                                                                | Sort order by the created_at timestamp of the objects. 'asc' for ascending order and 'desc' for descending order. | desc                                                                                                              |
| `after`                                                                                                           | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               | file-abc123                                                                                                       |
| `before`                                                                                                          | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `filter_`                                                                                                         | [Optional[models.ListVectorStoreFilesFilter]](../../models/listvectorstorefilesfilter.md)                         | :heavy_minus_sign:                                                                                                | Filter by file status. One of in_progress, completed, failed, cancelled.                                          | completed                                                                                                         |
| `x_on_behalf_of`                                                                                                  | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |
| `retries`                                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                  | :heavy_minus_sign:                                                                                                | Configuration to override the default retry behavior of the client.                                               |                                                                                                                   |

### Response

**[models.VectorStoreFileList](../../models/vectorstorefilelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_file

Retrieves detailed information about a specific file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="getVectorStoreFile" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.get_file(vector_store_id="vs_abc123", file_id="file-abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vector_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `file_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.VectorStoreFile](../../models/vectorstorefile.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_file

Updates the metadata attributes attached to a file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateVectorStoreFileAttributes" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.update_file(vector_store_id="vs_abc123", file_id="file-abc123", attributes={
        "category": "manual",
        "version": "3.0",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                               | Type                                                                                                                                                                                                    | Required                                                                                                                                                                                                | Description                                                                                                                                                                                             | Example                                                                                                                                                                                                 |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `vector_store_id`                                                                                                                                                                                       | *str*                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                      | N/A                                                                                                                                                                                                     | vs_abc123                                                                                                                                                                                               |
| `file_id`                                                                                                                                                                                               | *str*                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                      | N/A                                                                                                                                                                                                     | file-abc123                                                                                                                                                                                             |
| `attributes`                                                                                                                                                                                            | Dict[str, [models.UpdateVectorStoreFileAttributesRequestAttributes](../../models/updatevectorstorefileattributesrequestattributes.md)]                                                                  | :heavy_check_mark:                                                                                                                                                                                      | Set of 16 key-value pairs that can be attached to an object. Keys are strings with a maximum length of 64 characters. Values are strings with a maximum length of 512 characters, booleans, or numbers. |                                                                                                                                                                                                         |
| `x_on_behalf_of`                                                                                                                                                                                        | *Optional[str]*                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                     |                                                                                                                                                                                                         |
| `retries`                                                                                                                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                      | Configuration to override the default retry behavior of the client.                                                                                                                                     |                                                                                                                                                                                                         |

### Response

**[models.VectorStoreFile](../../models/vectorstorefile.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_file

Removes a file from a vector store and deletes its associated embeddings. If the file is no longer attached but the vector store still holds embeddings for it (for example, left behind by an earlier file deletion), those embeddings are deleted and the request succeeds, provided the file was deleted or you can read it; otherwise, and when there is nothing to remove, returns 404. Returns 409 if the file keeps being added back to the vector store while it is being removed; retrying completes the removal. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteVectorStoreFile" method="delete" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.delete_file(vector_store_id="vs_abc123", file_id="file-abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vector_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `file_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.VectorStoreFileDeletionStatus](../../models/vectorstorefiledeletionstatus.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_file_content

Retrieves the complete parsed contents of a file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="getVectorStoreFileContent" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}/content" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.get_file_content(vector_store_id="vs_abc123", file_id="file-abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vector_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `file_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.VectorStoreFileContent](../../models/vectorstorefilecontent.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_file_batch

Adds multiple files to a vector store in a single batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="createVectorStoreFileBatch" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.create_file_batch(vector_store_id="vs_abc123", file_ids=[
        "file-abc123",
        "file-def456",
        "file-ghi789",
    ], attributes={
        "batch_id": "import-2024-01",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                | Type                                                                                                                                                                                                                                                                                                                     | Required                                                                                                                                                                                                                                                                                                                 | Description                                                                                                                                                                                                                                                                                                              | Example                                                                                                                                                                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `vector_store_id`                                                                                                                                                                                                                                                                                                        | *str*                                                                                                                                                                                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                                                                                                                       | N/A                                                                                                                                                                                                                                                                                                                      | vs_abc123                                                                                                                                                                                                                                                                                                                |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                                                         | *Optional[str]*                                                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                                                                                          |
| `file_ids`                                                                                                                                                                                                                                                                                                               | List[*str*]                                                                                                                                                                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                       | A list of File IDs that the vector store should use. If attributes or chunking_strategy are provided at the root level, they will be applied to all files in the batch. Mutually exclusive with 'files'. At most 500 per batch.                                                                                          |                                                                                                                                                                                                                                                                                                                          |
| `files`                                                                                                                                                                                                                                                                                                                  | List[[models.FileWithMetadata](../../models/filewithmetadata.md)]                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                       | A list of objects that each include a file_id plus optional attributes or chunking_strategy. Use this when you need to override metadata for specific files. Entries without their own attributes or chunking_strategy fall back to the request-level values. Mutually exclusive with 'file_ids'. At most 500 per batch. |                                                                                                                                                                                                                                                                                                                          |
| `attributes`                                                                                                                                                                                                                                                                                                             | Dict[str, [models.CreateVectorStoreFileBatchRequestAttributes](../../models/createvectorstorefilebatchrequestattributes.md)]                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                       | Batch-wide default attributes, applied to every file that does not carry its own (a 'files' entry's attributes override this).                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                                                          |
| `chunking_strategy`                                                                                                                                                                                                                                                                                                      | [Optional[models.CreateVectorStoreFileBatchRequestChunkingStrategy]](../../models/createvectorstorefilebatchrequestchunkingstrategy.md)                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                       | Batch-wide default chunking strategy, applied to every file that does not carry its own (a 'files' entry's chunking_strategy overrides this).                                                                                                                                                                            |                                                                                                                                                                                                                                                                                                                          |
| `retries`                                                                                                                                                                                                                                                                                                                | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                       | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                                                                                          |

### Response

**[models.VectorStoreFileBatch](../../models/vectorstorefilebatch.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_file_batch

Retrieves the status of a specific file batch operation within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="getVectorStoreFileBatch" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.get_file_batch(vector_store_id="vs_abc123", batch_id="vsfb_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vector_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `batch_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vsfb_abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.VectorStoreFileBatch](../../models/vectorstorefilebatch.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## cancel_file_batch

Cancels an in-progress file batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="cancelVectorStoreFileBatch" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}/cancel" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.cancel_file_batch(vector_store_id="vs_abc123", batch_id="vsfb_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vector_store_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `batch_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | vsfb_abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.VectorStoreFileBatch](../../models/vectorstorefilebatch.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_files_in_batch

Retrieves a paginated list of all files within a specific batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="python" operationID="listVectorStoreFilesInBatch" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}/files" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.vector_stores.list_files_in_batch(vector_store_id="vs_abc123", batch_id="vsfb_abc123", limit=20, order="desc", after="file-abc123", filter_="completed")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `vector_store_id`                                                                                                 | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               | vs_abc123                                                                                                         |
| `batch_id`                                                                                                        | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               | vsfb_abc123                                                                                                       |
| `limit`                                                                                                           | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               | 20                                                                                                                |
| `order`                                                                                                           | [Optional[models.ListVectorStoreFilesInBatchOrder]](../../models/listvectorstorefilesinbatchorder.md)             | :heavy_minus_sign:                                                                                                | Sort order by the created_at timestamp of the objects. 'asc' for ascending order and 'desc' for descending order. | desc                                                                                                              |
| `after`                                                                                                           | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               | file-abc123                                                                                                       |
| `before`                                                                                                          | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `filter_`                                                                                                         | [Optional[models.ListVectorStoreFilesInBatchFilter]](../../models/listvectorstorefilesinbatchfilter.md)           | :heavy_minus_sign:                                                                                                | Filter by file status. One of in_progress, completed, failed, cancelled.                                          | completed                                                                                                         |
| `x_on_behalf_of`                                                                                                  | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |
| `retries`                                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                  | :heavy_minus_sign:                                                                                                | Configuration to override the default retry behavior of the client.                                               |                                                                                                                   |

### Response

**[models.VectorStoreFileList](../../models/vectorstorefilelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |