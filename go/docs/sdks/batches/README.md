# Llm.Batches

## Overview

### Available Operations

* [Create](#create) - Create a batch
* [List](#list) - List batches
* [Get](#get) - Get a batch
* [Cancel](#cancel) - Cancel a batch

## Create

Creates and executes a batch from an uploaded JSONL file of requests. Each line must have custom_id, method, url, and body fields. Text batches also require write:responses.

### Example Usage

<!-- UsageSnippet language="go" operationID="createBatch" method="post" path="/api/v1/llm/batches" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Batches.Create(ctx, components.CreateBatchRequest{
        InputFileID: "file_abc123",
        Endpoint: components.BatchEndpointRootV1ChatCompletions,
        Metadata: optionalnullable.From(mka1.Pointer(map[string]string{
            "description": "evaluation job",
        })),
        MaxConcurrency: mka1.Pointer[int64](4),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.BatchObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `body`                                                                         | [components.CreateBatchRequest](../../models/components/createbatchrequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `xOnBehalfOf`                                                                  | `*string`                                                                      | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.CreateBatchResponse](../../models/operations/createbatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Returns a paginated list of batches owned by the authenticated user.

### Example Usage

<!-- UsageSnippet language="go" operationID="listBatches" method="get" path="/api/v1/llm/batches" -->
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

    res, err := s.Llm.Batches.List(ctx, nil, mka1.Pointer[int64](20), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ListBatchesResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `after`                                                             | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListBatchesResponse](../../models/operations/listbatchesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Retrieves a batch by its ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="getBatch" method="get" path="/api/v1/llm/batches/{batch_id}" -->
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

    res, err := s.Llm.Batches.Get(ctx, "batch_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.BatchObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `batchID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | batch_aa87e2b1112a455b8deabed784372198                              |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetBatchResponse](../../models/operations/getbatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Cancel

Cancels an in-progress batch. The batch status changes to cancelling, and remaining requests will not be processed.

### Example Usage

<!-- UsageSnippet language="go" operationID="cancelBatch" method="post" path="/api/v1/llm/batches/{batch_id}/cancel" -->
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

    res, err := s.Llm.Batches.Cancel(ctx, "batch_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.BatchObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `batchID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | batch_aa87e2b1112a455b8deabed784372198                              |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.CancelBatchResponse](../../models/operations/cancelbatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |