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
* [ListPermissions](#listpermissions) - List vector store permissions
* [CreatePermission](#createpermission) - Grant a vector store permission
* [GetPermission](#getpermission) - Retrieve a vector store permission
* [DeletePermission](#deletepermission) - Remove a vector store permission

## Create

Creates a new vector store for storing and searching through document embeddings.

### Example Usage

<!-- UsageSnippet language="go" operationID="createVectorStore" method="post" path="/api/v1/llm/vector_stores" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Create(ctx, components.CreateVectorStoreRequest{
        Name: mka1.Pointer("Product Documentation"),
        Description: mka1.Pointer("Vector store for product manuals and documentation"),
        FileIds: []string{
            "file-abc123",
        },
        ExpiresAfter: &components.CreateVectorStoreRequestExpiresAfter{
            Days: 30,
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStore != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                              | Type                                                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                                                            | Example                                                                                                                                                                                                                                                                                                |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                                                                                                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                     | The context to use for the request.                                                                                                                                                                                                                                                                    |                                                                                                                                                                                                                                                                                                        |
| `body`                                                                                                                                                                                                                                                                                                 | [components.CreateVectorStoreRequest](../../models/components/createvectorstorerequest.md)                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                                                    | **Example 1:** {<br/>"name": "Product Documentation",<br/>"description": "Vector store for product manuals and documentation",<br/>"expires_after": {<br/>"anchor": "last_active_at",<br/>"days": 30<br/>}<br/>}<br/>**Example 2:** {<br/>"name": "Compact Embeddings Store",<br/>"embedding_model": "auto",<br/>"embedding_dimensions": 256<br/>} |
| `xOnBehalfOf`                                                                                                                                                                                                                                                                                          | `*string`                                                                                                                                                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                                                                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                    |                                                                                                                                                                                                                                                                                                        |
| `opts`                                                                                                                                                                                                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                     | The options for this request.                                                                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                                        |

### Response

**[*operations.CreateVectorStoreResponse](../../models/operations/createvectorstoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Retrieves a paginated list of all vector stores for the authenticated user.

### Example Usage

<!-- UsageSnippet language="go" operationID="listVectorStores" method="get" path="/api/v1/llm/vector_stores" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.List(ctx, operations.ListVectorStoresRequest{
        After: mka1.Pointer("vs_abc123"),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `request`                                                                                | [operations.ListVectorStoresRequest](../../models/operations/listvectorstoresrequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.ListVectorStoresResponse](../../models/operations/listvectorstoresresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Retrieves a vector store by its ID. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStore" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Get(ctx, "vs_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStore != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetVectorStoreResponse](../../models/operations/getvectorstoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Updates the properties of an existing vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="modifyVectorStore" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Update(ctx, "vs_abc123", components.ModifyVectorStoreRequest{
        Name: optionalnullable.From(mka1.Pointer("Updated Product Documentation")),
        ExpiresAfter: optionalnullable.From(&components.ModifyVectorStoreRequestExpiresAfter{
            Days: 60,
        }),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStore != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            | Example                                                                                                |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |                                                                                                        |
| `vectorStoreID`                                                                                        | `string`                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    | vs_abc123                                                                                              |
| `body`                                                                                                 | [components.ModifyVectorStoreRequest](../../models/components/modifyvectorstorerequest.md)             | :heavy_check_mark:                                                                                     | N/A                                                                                                    | {<br/>"name": "Updated Documentation Store",<br/>"expires_after": {<br/>"anchor": "last_active_at",<br/>"days": 60<br/>}<br/>} |
| `xOnBehalfOf`                                                                                          | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |                                                                                                        |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |                                                                                                        |

### Response

**[*operations.ModifyVectorStoreResponse](../../models/operations/modifyvectorstoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Permanently deletes a vector store and its associated embeddings.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteVectorStore" method="delete" path="/api/v1/llm/vector_stores/{vector_store_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Delete(ctx, "vs_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreDeletionStatus != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteVectorStoreResponse](../../models/operations/deletevectorstoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Search

Performs semantic search within a vector store to find the most relevant document chunks for a query. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="searchVectorStore" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/search" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.Search(ctx, "vs_abc123", components.SearchVectorStoreRequest{
        Query: components.CreateQueryStr(
            "How do I reset my password?",
        ),
        MaxNumResults: mka1.Pointer[int64](5),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreSearchResults != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |                                                                                            |
| `vectorStoreID`                                                                            | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | vs_abc123                                                                                  |
| `body`                                                                                     | [components.SearchVectorStoreRequest](../../models/components/searchvectorstorerequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        | {<br/>"query": "How do I reset my password?",<br/>"max_num_results": 5<br/>}               |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |                                                                                            |

### Response

**[*operations.SearchVectorStoreResponse](../../models/operations/searchvectorstoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateFile

Adds a file to a vector store for semantic search indexing. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="createVectorStoreFile" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/files" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.CreateFile(ctx, "vs_abc123", components.CreateVectorStoreFileRequest{
        FileID: "file-abc123",
        Attributes: map[string]components.CreateVectorStoreFileRequestAttributes{
            "category": components.CreateCreateVectorStoreFileRequestAttributesStr(
                "manual",
            ),
            "version": components.CreateCreateVectorStoreFileRequestAttributesStr(
                "2.0",
            ),
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFile != nil {
        switch res.VectorStoreFile.ChunkingStrategy.Type {
            case components.ChunkingStrategyTypeAuto:
                // res.VectorStoreFile.ChunkingStrategy.AutoChunkingStrategy is populated
            case components.ChunkingStrategyTypeStatic:
                // res.VectorStoreFile.ChunkingStrategy.StaticChunkingStrategy is populated
            case components.ChunkingStrategyTypeOther:
                // res.VectorStoreFile.ChunkingStrategy.OtherChunkingStrategy is populated
            default:
                // Unknown type - use res.VectorStoreFile.ChunkingStrategy.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |                                                                                                    |
| `vectorStoreID`                                                                                    | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                | vs_abc123                                                                                          |
| `body`                                                                                             | [components.CreateVectorStoreFileRequest](../../models/components/createvectorstorefilerequest.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                | {<br/>"file_id": "file-abc123",<br/>"attributes": {<br/>"category": "manual",<br/>"version": "2.0"<br/>}<br/>} |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |                                                                                                    |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |                                                                                                    |

### Response

**[*operations.CreateVectorStoreFileResponse](../../models/operations/createvectorstorefileresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListFiles

Retrieves a paginated list of all files in a specific vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="listVectorStoreFiles" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.ListFiles(ctx, operations.ListVectorStoreFilesRequest{
        VectorStoreID: "vs_abc123",
        After: mka1.Pointer("file-abc123"),
        Filter: operations.ListVectorStoreFilesFilterCompleted.ToPointer(),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFileList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `request`                                                                                        | [operations.ListVectorStoreFilesRequest](../../models/operations/listvectorstorefilesrequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.ListVectorStoreFilesResponse](../../models/operations/listvectorstorefilesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetFile

Retrieves detailed information about a specific file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStoreFile" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.GetFile(ctx, "vs_abc123", "file-abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFile != nil {
        switch res.VectorStoreFile.ChunkingStrategy.Type {
            case components.ChunkingStrategyTypeAuto:
                // res.VectorStoreFile.ChunkingStrategy.AutoChunkingStrategy is populated
            case components.ChunkingStrategyTypeStatic:
                // res.VectorStoreFile.ChunkingStrategy.StaticChunkingStrategy is populated
            case components.ChunkingStrategyTypeOther:
                // res.VectorStoreFile.ChunkingStrategy.OtherChunkingStrategy is populated
            default:
                // Unknown type - use res.VectorStoreFile.ChunkingStrategy.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `fileID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetVectorStoreFileResponse](../../models/operations/getvectorstorefileresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateFile

Updates the metadata attributes attached to a file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateVectorStoreFileAttributes" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.UpdateFile(ctx, "vs_abc123", "file-abc123", components.UpdateVectorStoreFileAttributesRequest{
        Attributes: map[string]components.UpdateVectorStoreFileAttributesRequestAttributes{
            "category": components.CreateUpdateVectorStoreFileAttributesRequestAttributesStr(
                "manual",
            ),
            "version": components.CreateUpdateVectorStoreFileAttributesRequestAttributesStr(
                "3.0",
            ),
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFile != nil {
        switch res.VectorStoreFile.ChunkingStrategy.Type {
            case components.ChunkingStrategyTypeAuto:
                // res.VectorStoreFile.ChunkingStrategy.AutoChunkingStrategy is populated
            case components.ChunkingStrategyTypeStatic:
                // res.VectorStoreFile.ChunkingStrategy.StaticChunkingStrategy is populated
            case components.ChunkingStrategyTypeOther:
                // res.VectorStoreFile.ChunkingStrategy.OtherChunkingStrategy is populated
            default:
                // Unknown type - use res.VectorStoreFile.ChunkingStrategy.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            | Example                                                                                                                |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                  | :heavy_check_mark:                                                                                                     | The context to use for the request.                                                                                    |                                                                                                                        |
| `vectorStoreID`                                                                                                        | `string`                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    | vs_abc123                                                                                                              |
| `fileID`                                                                                                               | `string`                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    | file-abc123                                                                                                            |
| `body`                                                                                                                 | [components.UpdateVectorStoreFileAttributesRequest](../../models/components/updatevectorstorefileattributesrequest.md) | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |                                                                                                                        |
| `xOnBehalfOf`                                                                                                          | `*string`                                                                                                              | :heavy_minus_sign:                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                    |                                                                                                                        |
| `opts`                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                               | :heavy_minus_sign:                                                                                                     | The options for this request.                                                                                          |                                                                                                                        |

### Response

**[*operations.UpdateVectorStoreFileAttributesResponse](../../models/operations/updatevectorstorefileattributesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteFile

Removes a file from a vector store and deletes its associated embeddings. If the file is no longer attached but the vector store still holds embeddings for it (for example, left behind by an earlier file deletion), those embeddings are deleted and the request succeeds, provided the file was deleted or you can read it; otherwise, and when there is nothing to remove, returns 404. Returns 409 if the file keeps being added back to the vector store while it is being removed; retrying completes the removal. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteVectorStoreFile" method="delete" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.DeleteFile(ctx, "vs_abc123", "file-abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFileDeletionStatus != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `fileID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteVectorStoreFileResponse](../../models/operations/deletevectorstorefileresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetFileContent

Retrieves the complete parsed contents of a file within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStoreFileContent" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/files/{file_id}/content" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.GetFileContent(ctx, "vs_abc123", "file-abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFileContent != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `fileID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetVectorStoreFileContentResponse](../../models/operations/getvectorstorefilecontentresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateFileBatch

Adds multiple files to a vector store in a single batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="createVectorStoreFileBatch" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.CreateFileBatch(ctx, "vs_abc123", components.CreateVectorStoreFileBatchRequest{
        FileIds: []string{
            "file-abc123",
            "file-def456",
            "file-ghi789",
        },
        Attributes: map[string]components.CreateVectorStoreFileBatchRequestAttributes{
            "batch_id": components.CreateCreateVectorStoreFileBatchRequestAttributesStr(
                "import-2024-01",
            ),
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFileBatch != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     | Example                                                                                                         |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                           | [context.Context](https://pkg.go.dev/context#Context)                                                           | :heavy_check_mark:                                                                                              | The context to use for the request.                                                                             |                                                                                                                 |
| `vectorStoreID`                                                                                                 | `string`                                                                                                        | :heavy_check_mark:                                                                                              | N/A                                                                                                             | vs_abc123                                                                                                       |
| `body`                                                                                                          | [components.CreateVectorStoreFileBatchRequest](../../models/components/createvectorstorefilebatchrequest.md)    | :heavy_check_mark:                                                                                              | N/A                                                                                                             | {<br/>"file_ids": [<br/>"file-abc123",<br/>"file-def456",<br/>"file-ghi789"<br/>],<br/>"attributes": {<br/>"batch_id": "import-2024-01"<br/>}<br/>} |
| `xOnBehalfOf`                                                                                                   | `*string`                                                                                                       | :heavy_minus_sign:                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                             |                                                                                                                 |
| `opts`                                                                                                          | [][operations.Option](../../models/operations/option.md)                                                        | :heavy_minus_sign:                                                                                              | The options for this request.                                                                                   |                                                                                                                 |

### Response

**[*operations.CreateVectorStoreFileBatchResponse](../../models/operations/createvectorstorefilebatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetFileBatch

Retrieves the status of a specific file batch operation within a vector store. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStoreFileBatch" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.GetFileBatch(ctx, "vs_abc123", "vsfb_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFileBatch != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `batchID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vsfb_abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetVectorStoreFileBatchResponse](../../models/operations/getvectorstorefilebatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CancelFileBatch

Cancels an in-progress file batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="cancelVectorStoreFileBatch" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}/cancel" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.CancelFileBatch(ctx, "vs_abc123", "vsfb_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFileBatch != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `batchID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vsfb_abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.CancelVectorStoreFileBatchResponse](../../models/operations/cancelvectorstorefilebatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListFilesInBatch

Retrieves a paginated list of all files within a specific batch operation. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="listVectorStoreFilesInBatch" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/file_batches/{batch_id}/files" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.ListFilesInBatch(ctx, operations.ListVectorStoreFilesInBatchRequest{
        VectorStoreID: "vs_abc123",
        BatchID: "vsfb_abc123",
        After: mka1.Pointer("file-abc123"),
        Filter: operations.ListVectorStoreFilesInBatchFilterCompleted.ToPointer(),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreFileList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                                          | :heavy_check_mark:                                                                                             | The context to use for the request.                                                                            |
| `request`                                                                                                      | [operations.ListVectorStoreFilesInBatchRequest](../../models/operations/listvectorstorefilesinbatchrequest.md) | :heavy_check_mark:                                                                                             | The request object to use for the request.                                                                     |
| `opts`                                                                                                         | [][operations.Option](../../models/operations/option.md)                                                       | :heavy_minus_sign:                                                                                             | The options for this request.                                                                                  |

### Response

**[*operations.ListVectorStoreFilesInBatchResponse](../../models/operations/listvectorstorefilesinbatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListPermissions

Lists who holds a role on the vector store: its owner, then its team when that permission is set, then individual principals. Anyone who can read the store can list its permissions. Organization admins of the store's team can always read it and are not listed. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="listVectorStorePermissions" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/permissions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.ListPermissions(ctx, "vs_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStorePermissionList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ListVectorStorePermissionsResponse](../../models/operations/listvectorstorepermissionsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreatePermission

Grants `reader` or `writer` on the vector store to one principal, or to every member of the store's team (`grantee_type: team`), replacing any role that principal already held. Only the store's owner or an organization admin of its team can grant (403 otherwise). The owner's role is fixed at creation and cannot be granted or changed. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="createVectorStorePermission" method="post" path="/api/v1/llm/vector_stores/{vector_store_id}/permissions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.CreatePermission(ctx, "vs_abc123", components.CreateCreateVectorStorePermissionRequestUnionUser(
        components.CreateVectorStorePermissionRequest1{
            UserID: "<id>",
            Role: components.GrantableVectorStorePermissionRoleWriter,
        },
    ), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStorePermission != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              | Example                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                                    | :heavy_check_mark:                                                                                                       | The context to use for the request.                                                                                      |                                                                                                                          |
| `vectorStoreID`                                                                                                          | `string`                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      | vs_abc123                                                                                                                |
| `body`                                                                                                                   | [components.CreateVectorStorePermissionRequestUnion](../../models/components/createvectorstorepermissionrequestunion.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |                                                                                                                          |
| `xOnBehalfOf`                                                                                                            | `*string`                                                                                                                | :heavy_minus_sign:                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                      |                                                                                                                          |
| `opts`                                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                                 | :heavy_minus_sign:                                                                                                       | The options for this request.                                                                                            |                                                                                                                          |

### Response

**[*operations.CreateVectorStorePermissionResponse](../../models/operations/createvectorstorepermissionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetPermission

Returns the role a principal effectively holds on the vector store and where it comes from: `owner`, a permission granted to it (`grant`), the store's `team` permission, or `none`. A principal with `none` can still reach the store as an organization admin of its team; that is decided per request from the caller's role. Anyone who can read the store can call this. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStorePermission" method="get" path="/api/v1/llm/vector_stores/{vector_store_id}/permissions/{user_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.GetPermission(ctx, "vs_abc123", "user_8f2c1", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStoreEffectivePermission != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `userID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | user_8f2c1                                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetVectorStorePermissionResponse](../../models/operations/getvectorstorepermissionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeletePermission

Removes every role the principal holds on the vector store, or the `team` permission. Only the store's owner or an organization admin of its team can remove permissions (403 otherwise); the owner's own permission cannot be removed. 404 when the principal holds no permission. Returns 410 once the vector store has expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteVectorStorePermission" method="delete" path="/api/v1/llm/vector_stores/{vector_store_id}/permissions/{user_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.VectorStores.DeletePermission(ctx, "vs_abc123", "user_8f2c1", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.VectorStorePermissionDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `vectorStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | vs_abc123                                                           |
| `userID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | user_8f2c1                                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteVectorStorePermissionResponse](../../models/operations/deletevectorstorepermissionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |