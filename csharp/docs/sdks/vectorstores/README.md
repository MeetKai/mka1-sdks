# Llm.VectorStores

## Overview

### Available Operations

* [Create](#create) - Create a vector store
* [List](#list) - List vector stores
* [Get](#get) - Retrieve a vector store
* [Update](#update) - Modify a vector store
* [Delete](#delete) - Delete a vector store
* [Search](#search) - Search a vector store
* [CreateFile](#createfile) - Add a file to a vector store
* [ListFiles](#listfiles) - List files in a vector store
* [GetFile](#getfile) - Retrieve a vector store file
* [UpdateFile](#updatefile) - Update file attributes
* [DeleteFile](#deletefile) - Remove file from vector store
* [GetFileContent](#getfilecontent) - Retrieve parsed file content
* [CreateFileBatch](#createfilebatch) - Batch add multiple files to vector store
* [GetFileBatch](#getfilebatch) - Retrieve file batch status
* [CancelFileBatch](#cancelfilebatch) - Cancel batch file processing
* [ListFilesInBatch](#listfilesinbatch) - List files in a batch

## Create

Creates a new vector store for storing and searching through document embeddings.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createVectorStore" method="post" path="/api/v1/llm/vector_stores" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.CreateAsync(body: new MeetKai.MKA1.Types.Components.CreateVectorStoreRequest() {
    Name = "Product Documentation",
    Description = "Vector store for product manuals and documentation",
    FileIds = new List<string>() {
        "file-abc123",
    },
    ExpiresAfter = new CreateVectorStoreRequestExpiresAfter() {
        Days = 30,
    },
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                              | Type                                                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                                                            | Example                                                                                                                                                                                                                                                                                                |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Body`                                                                                                                                                                                                                                                                                                 | [Types.Components.CreateVectorStoreRequest](../../Types/Components/CreateVectorStoreRequest.md)                                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                                                    | **Example 1:** {<br/>"name": "Product Documentation",<br/>"description": "Vector store for product manuals and documentation",<br/>"expires_after": {<br/>"anchor": "last_active_at",<br/>"days": 30<br/>}<br/>}<br/>**Example 2:** {<br/>"name": "Compact Embeddings Store",<br/>"embedding_model": "auto",<br/>"embedding_dimensions": 256<br/>} |
| `XOnBehalfOf`                                                                                                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                    |                                                                                                                                                                                                                                                                                                        |

### Response

**[CreateVectorStoreResponse](../../Types/Requests/CreateVectorStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

Retrieves a paginated list of all vector stores for the authenticated user.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listVectorStores" method="get" path="/api/v1/llm/vector_stores" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListVectorStoresRequest req = new ListVectorStoresRequest() {
    After = "vs_abc123",
};

var res = await sdk.Llm.VectorStores.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [ListVectorStoresRequest](../../Types/Requests/ListVectorStoresRequest.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |

### Response

**[ListVectorStoresResponse](../../Types/Requests/ListVectorStoresResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Retrieves a vector store by its ID. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVectorStore" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.GetAsync(vectorStoreId: "vs_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `VectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetVectorStoreResponse](../../Types/Requests/GetVectorStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Update

Updates the properties of an existing vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="modifyVectorStore" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.UpdateAsync(
    vectorStoreId: "vs_abc123",
    body: new MeetKai.MKA1.Types.Components.ModifyVectorStoreRequest() {
        Name = "Updated Product Documentation",
        ExpiresAfter = new ModifyVectorStoreRequestExpiresAfter() {
            Days = 60,
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            | Example                                                                                                |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `VectorStoreId`                                                                                        | *string*                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    | vs_abc123                                                                                              |
| `Body`                                                                                                 | [Types.Components.ModifyVectorStoreRequest](../../Types/Components/ModifyVectorStoreRequest.md)        | :heavy_check_mark:                                                                                     | N/A                                                                                                    | {<br/>"name": "Updated Documentation Store",<br/>"expires_after": {<br/>"anchor": "last_active_at",<br/>"days": 60<br/>}<br/>} |
| `XOnBehalfOf`                                                                                          | *string*                                                                                               | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |                                                                                                        |

### Response

**[ModifyVectorStoreResponse](../../Types/Requests/ModifyVectorStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Permanently deletes a vector store and its associated embeddings.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteVectorStore" method="delete" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.DeleteAsync(vectorStoreId: "vs_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `VectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteVectorStoreResponse](../../Types/Requests/DeleteVectorStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Search

Performs semantic search within a vector store to find the most relevant document chunks for a query. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="searchVectorStore" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/search" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.SearchAsync(
    vectorStoreId: "vs_abc123",
    body: new MeetKai.MKA1.Types.Components.SearchVectorStoreRequest() {
        Query = Query.CreateStr(
            "How do I reset my password?"
        ),
        MaxNumResults = 5,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `VectorStoreId`                                                                                 | *string*                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | vs_abc123                                                                                       |
| `Body`                                                                                          | [Types.Components.SearchVectorStoreRequest](../../Types/Components/SearchVectorStoreRequest.md) | :heavy_check_mark:                                                                              | N/A                                                                                             | {<br/>"query": "How do I reset my password?",<br/>"max_num_results": 5<br/>}                    |
| `XOnBehalfOf`                                                                                   | *string*                                                                                        | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |                                                                                                 |

### Response

**[SearchVectorStoreResponse](../../Types/Requests/SearchVectorStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateFile

Adds a file to a vector store for semantic search indexing. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createVectorStoreFile" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/files" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.CreateFileAsync(
    vectorStoreId: "vs_abc123",
    body: new MeetKai.MKA1.Types.Components.CreateVectorStoreFileRequest() {
        FileId = "file-abc123",
        Attributes = new Dictionary<string, CreateVectorStoreFileRequestAttributes>() {
            { "category", CreateVectorStoreFileRequestAttributes.CreateStr(
                "manual"
            ) },
            { "version", CreateVectorStoreFileRequestAttributes.CreateStr(
                "2.0"
            ) },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             | Example                                                                                                 |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `VectorStoreId`                                                                                         | *string*                                                                                                | :heavy_check_mark:                                                                                      | N/A                                                                                                     | vs_abc123                                                                                               |
| `Body`                                                                                                  | [Types.Components.CreateVectorStoreFileRequest](../../Types/Components/CreateVectorStoreFileRequest.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     | {<br/>"file_id": "file-abc123",<br/>"attributes": {<br/>"category": "manual",<br/>"version": "2.0"<br/>}<br/>} |
| `XOnBehalfOf`                                                                                           | *string*                                                                                                | :heavy_minus_sign:                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                     |                                                                                                         |

### Response

**[CreateVectorStoreFileResponse](../../Types/Requests/CreateVectorStoreFileResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListFiles

Retrieves a paginated list of all files in a specific vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listVectorStoreFiles" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListVectorStoreFilesRequest req = new ListVectorStoreFilesRequest() {
    VectorStoreId = "vs_abc123",
    After = "file-abc123",
    Filter = ListVectorStoreFilesFilter.Completed,
};

var res = await sdk.Llm.VectorStores.ListFilesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `request`                                                                          | [ListVectorStoreFilesRequest](../../Types/Requests/ListVectorStoreFilesRequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |

### Response

**[ListVectorStoreFilesResponse](../../Types/Requests/ListVectorStoreFilesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetFile

Retrieves detailed information about a specific file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVectorStoreFile" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.GetFileAsync(
    vectorStoreId: "vs_abc123",
    fileId: "file-abc123"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `VectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `FileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetVectorStoreFileResponse](../../Types/Requests/GetVectorStoreFileResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateFile

Updates the metadata attributes attached to a file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateVectorStoreFileAttributes" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.UpdateFileAsync(
    vectorStoreId: "vs_abc123",
    fileId: "file-abc123",
    body: new MeetKai.MKA1.Types.Components.UpdateVectorStoreFileAttributesRequest() {
        Attributes = new Dictionary<string, UpdateVectorStoreFileAttributesRequestAttributes>() {
            { "category", UpdateVectorStoreFileAttributesRequestAttributes.CreateStr(
                "manual"
            ) },
            { "version", UpdateVectorStoreFileAttributesRequestAttributes.CreateStr(
                "3.0"
            ) },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 | Example                                                                                                                     |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `VectorStoreId`                                                                                                             | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         | vs_abc123                                                                                                                   |
| `FileId`                                                                                                                    | *string*                                                                                                                    | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         | file-abc123                                                                                                                 |
| `Body`                                                                                                                      | [Types.Components.UpdateVectorStoreFileAttributesRequest](../../Types/Components/UpdateVectorStoreFileAttributesRequest.md) | :heavy_check_mark:                                                                                                          | N/A                                                                                                                         |                                                                                                                             |
| `XOnBehalfOf`                                                                                                               | *string*                                                                                                                    | :heavy_minus_sign:                                                                                                          | Optional external end-user identifier forwarded by the API gateway.                                                         |                                                                                                                             |

### Response

**[UpdateVectorStoreFileAttributesResponse](../../Types/Requests/UpdateVectorStoreFileAttributesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteFile

Removes a file from a vector store and deletes its associated embeddings. If the file is no longer attached but the vector store still holds embeddings for it (for example, left behind by an earlier file deletion), those embeddings are deleted and the request succeeds, provided the file was deleted or you can read it; otherwise, and when there is nothing to remove, returns 404. Returns 409 if the file keeps being added back to the vector store while it is being removed; retrying completes the removal. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteVectorStoreFile" method="delete" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.DeleteFileAsync(
    vectorStoreId: "vs_abc123",
    fileId: "file-abc123"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `VectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `FileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteVectorStoreFileResponse](../../Types/Requests/DeleteVectorStoreFileResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetFileContent

Retrieves the complete parsed contents of a file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVectorStoreFileContent" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}/content" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.GetFileContentAsync(
    vectorStoreId: "vs_abc123",
    fileId: "file-abc123"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `VectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `FileId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetVectorStoreFileContentResponse](../../Types/Requests/GetVectorStoreFileContentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateFileBatch

Adds multiple files to a vector store in a single batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createVectorStoreFileBatch" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.CreateFileBatchAsync(
    vectorStoreId: "vs_abc123",
    body: new MeetKai.MKA1.Types.Components.CreateVectorStoreFileBatchRequest() {
        FileIds = new List<string>() {
            "file-abc123",
            "file-def456",
            "file-ghi789",
        },
        Attributes = new Dictionary<string, CreateVectorStoreFileBatchRequestAttributes>() {
            { "batch_id", CreateVectorStoreFileBatchRequestAttributes.CreateStr(
                "import-2024-01"
            ) },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `VectorStoreId`                                                                                                   | *string*                                                                                                          | :heavy_check_mark:                                                                                                | N/A                                                                                                               | vs_abc123                                                                                                         |
| `Body`                                                                                                            | [Types.Components.CreateVectorStoreFileBatchRequest](../../Types/Components/CreateVectorStoreFileBatchRequest.md) | :heavy_check_mark:                                                                                                | N/A                                                                                                               | {<br/>"file_ids": [<br/>"file-abc123",<br/>"file-def456",<br/>"file-ghi789"<br/>],<br/>"attributes": {<br/>"batch_id": "import-2024-01"<br/>}<br/>} |
| `XOnBehalfOf`                                                                                                     | *string*                                                                                                          | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |

### Response

**[CreateVectorStoreFileBatchResponse](../../Types/Requests/CreateVectorStoreFileBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetFileBatch

Retrieves the status of a specific file batch operation within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVectorStoreFileBatch" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.GetFileBatchAsync(
    vectorStoreId: "vs_abc123",
    batchId: "vsfb_abc123"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `VectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `BatchId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vsfb_abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetVectorStoreFileBatchResponse](../../Types/Requests/GetVectorStoreFileBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CancelFileBatch

Cancels an in-progress file batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelVectorStoreFileBatch" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}/cancel" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.VectorStores.CancelFileBatchAsync(
    vectorStoreId: "vs_abc123",
    batchId: "vsfb_abc123"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `VectorStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `BatchId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vsfb_abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[CancelVectorStoreFileBatchResponse](../../Types/Requests/CancelVectorStoreFileBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListFilesInBatch

Retrieves a paginated list of all files within a specific batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listVectorStoreFilesInBatch" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}/files" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListVectorStoreFilesInBatchRequest req = new ListVectorStoreFilesInBatchRequest() {
    VectorStoreId = "vs_abc123",
    BatchId = "vsfb_abc123",
    After = "file-abc123",
    Filter = ListVectorStoreFilesInBatchFilter.Completed,
};

var res = await sdk.Llm.VectorStores.ListFilesInBatchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `request`                                                                                        | [ListVectorStoreFilesInBatchRequest](../../Types/Requests/ListVectorStoreFilesInBatchRequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |

### Response

**[ListVectorStoreFilesInBatchResponse](../../Types/Requests/ListVectorStoreFilesInBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |