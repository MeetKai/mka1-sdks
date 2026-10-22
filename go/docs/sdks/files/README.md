# Llm.Files

## Overview

### Available Operations

* [Upload](#upload) - Upload file
* [List](#list) - List files
* [Get](#get) - Retrieve file
* [Delete](#delete) - Delete file
* [Content](#content) - Retrieve file content

## Upload

Upload a file that can be used with Assistants, Vector Stores, and other features. Files are uploaded to S3 for durable storage.

### Example Usage

<!-- UsageSnippet language="go" operationID="uploadFile" method="post" path="/api/v1/llm/files" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"os"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    example, fileErr := os.Open("example.file")
    if fileErr != nil {
        panic(fileErr)
    }

    res, err := s.Llm.Files.Upload(ctx, operations.UploadFileRequestBody{
        File: operations.UploadFileFile{
            FileName: "example.file",
            Content: example,
        },
        Purpose: operations.UploadFilePurposeAssistants,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.File != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ctx`                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                | :heavy_check_mark:                                                                   | The context to use for the request.                                                  |
| `body`                                                                               | [operations.UploadFileRequestBody](../../models/operations/uploadfilerequestbody.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `xOnBehalfOf`                                                                        | `*string`                                                                            | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `opts`                                                                               | [][operations.Option](../../models/operations/option.md)                             | :heavy_minus_sign:                                                                   | The options for this request.                                                        |

### Response

**[*operations.UploadFileResponse](../../models/operations/uploadfileresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Returns a list of files that have been uploaded.

### Example Usage

<!-- UsageSnippet language="go" operationID="listFiles" method="get" path="/api/v1/llm/files" -->
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

    res, err := s.Llm.Files.List(ctx, operations.ListFilesRequest{
        After: mka1.Pointer("file-abc123"),
        Limit: mka1.Pointer[int64](100),
        Purpose: operations.ListFilesPurposeAssistants.ToPointer(),
        Sha256: mka1.Pointer("9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08"),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.FileList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `ctx`                                                                      | [context.Context](https://pkg.go.dev/context#Context)                      | :heavy_check_mark:                                                         | The context to use for the request.                                        |
| `request`                                                                  | [operations.ListFilesRequest](../../models/operations/listfilesrequest.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |
| `opts`                                                                     | [][operations.Option](../../models/operations/option.md)                   | :heavy_minus_sign:                                                         | The options for this request.                                              |

### Response

**[*operations.ListFilesResponse](../../models/operations/listfilesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Returns information about a specific file.

### Example Usage

<!-- UsageSnippet language="go" operationID="getFile" method="get" path="/api/v1/llm/files/{file_id}" -->
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

    res, err := s.Llm.Files.Get(ctx, "file-abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.File != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `fileID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetFileResponse](../../models/operations/getfileresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Delete a file from storage. The file is first removed from every vector store it is attached to, embeddings included, so it no longer appears in vector store search or `file_search` results. If that cannot finish, the file is kept and the request fails; retrying completes the deletion. Returns 400 `feature_unavailable` when the file is attached to a vector store while the search service is unavailable, and 409 when the file was added to a vector store during the deletion.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteFile" method="delete" path="/api/v1/llm/files/{file_id}" -->
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

    res, err := s.Llm.Files.Delete(ctx, "file-abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FileDeletionStatus != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `fileID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteFileResponse](../../models/operations/deletefileresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Content

Returns the raw binary contents of the specified file with appropriate Content-Type header.

### Example Usage

<!-- UsageSnippet language="go" operationID="getFileContent" method="get" path="/api/v1/llm/files/{file_id}/content" -->
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

    res, err := s.Llm.Files.Content(ctx, "file-abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TwoHundredTextPlainResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `fileID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetFileContentResponse](../../models/operations/getfilecontentresponse.md), error**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| apierrors.GetFileContentBadRequestError     | 400                                         | application/json                            |
| apierrors.GetFileContentUnauthorizedError   | 401                                         | application/json                            |
| apierrors.GetFileContentNotFoundError       | 404                                         | application/json                            |
| apierrors.GetFileContentInternalServerError | 500                                         | application/json                            |
| apierrors.APIError                          | 4XX, 5XX                                    | \*/\*                                       |