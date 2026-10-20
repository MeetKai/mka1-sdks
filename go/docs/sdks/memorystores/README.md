# Llm.MemoryStores

## Overview

### Available Operations

* [Create](#create) - Create memory store
* [List](#list) - List memory stores
* [Get](#get) - Retrieve memory store
* [Update](#update) - Update memory store
* [Delete](#delete) - Delete memory store
* [CreateEntry](#createentry) - Create memory entry
* [ListEntries](#listentries) - List memory entries
* [GetEntry](#getentry) - Retrieve memory entry
* [UpdateEntry](#updateentry) - Update memory entry
* [DeleteEntry](#deleteentry) - Delete memory entry

## Create

Creates a memory store for persistent agent notes. Stores are private by default and can be shared across the workspace.

### Example Usage

<!-- UsageSnippet language="go" operationID="createMemoryStore" method="post" path="/api/v1/llm/memory_stores" -->
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

    res, err := s.Llm.MemoryStores.Create(ctx, components.CreateMemoryStoreRequest{
        Name: "Bug Reports",
        Description: optionalnullable.From(mka1.Pointer("Persistent bug reports seen by the triage agent.")),
        Instructions: optionalnullable.From(mka1.Pointer("Store every confirmed bug report here using one markdown file per product area.")),
        Visibility: components.MemoryStoreVisibilityWorkspace.ToPointer(),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryStore != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `body`                                                                                     | [components.CreateMemoryStoreRequest](../../models/components/creatememorystorerequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.CreateMemoryStoreResponse](../../models/operations/creatememorystoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

List memory stores

### Example Usage

<!-- UsageSnippet language="go" operationID="listMemoryStores" method="get" path="/api/v1/llm/memory_stores" -->
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

    res, err := s.Llm.MemoryStores.List(ctx, mka1.Pointer[int64](20), operations.ListMemoryStoresOrderDesc.ToPointer(), nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryStoreList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ctx`                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                 | :heavy_check_mark:                                                                    | The context to use for the request.                                                   |
| `limit`                                                                               | `*int64`                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `order`                                                                               | [*operations.ListMemoryStoresOrder](../../models/operations/listmemorystoresorder.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `after`                                                                               | `*string`                                                                             | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `xOnBehalfOf`                                                                         | `*string`                                                                             | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `opts`                                                                                | [][operations.Option](../../models/operations/option.md)                              | :heavy_minus_sign:                                                                    | The options for this request.                                                         |

### Response

**[*operations.ListMemoryStoresResponse](../../models/operations/listmemorystoresresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Retrieve memory store

### Example Usage

<!-- UsageSnippet language="go" operationID="getMemoryStore" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
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

    res, err := s.Llm.MemoryStores.Get(ctx, "mem_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryStore != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `memoryStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetMemoryStoreResponse](../../models/operations/getmemorystoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Update memory store

### Example Usage

<!-- UsageSnippet language="go" operationID="updateMemoryStore" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
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

    res, err := s.Llm.MemoryStores.Update(ctx, "mem_aa87e2b1112a455b8deabed784372198", components.UpdateMemoryStoreRequest{
        Description: optionalnullable.From(mka1.Pointer("Persistent bug reports seen by the triage agent and support team.")),
        Visibility: components.MemoryStoreVisibilityWorkspace.ToPointer(),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryStore != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |                                                                                            |
| `memoryStoreID`                                                                            | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_aa87e2b1112a455b8deabed784372198                                                       |
| `body`                                                                                     | [components.UpdateMemoryStoreRequest](../../models/components/updatememorystorerequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |                                                                                            |

### Response

**[*operations.UpdateMemoryStoreResponse](../../models/operations/updatememorystoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Delete memory store

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteMemoryStore" method="delete" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
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

    res, err := s.Llm.MemoryStores.Delete(ctx, "mem_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryStoreDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `memoryStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteMemoryStoreResponse](../../models/operations/deletememorystoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateEntry

Create memory entry

### Example Usage

<!-- UsageSnippet language="go" operationID="createMemoryEntry" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}/entries" -->
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

    res, err := s.Llm.MemoryStores.CreateEntry(ctx, "mem_aa87e2b1112a455b8deabed784372198", components.CreateMemoryEntryRequest{
        Path: "reports/login-rate-limit.md",
        Content: "# Login rate limit\n\nReported by Acme on 2026-05-05.",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryEntry != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |                                                                                            |
| `memoryStoreID`                                                                            | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_aa87e2b1112a455b8deabed784372198                                                       |
| `body`                                                                                     | [components.CreateMemoryEntryRequest](../../models/components/creatememoryentryrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |                                                                                            |

### Response

**[*operations.CreateMemoryEntryResponse](../../models/operations/creatememoryentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListEntries

List memory entries

### Example Usage

<!-- UsageSnippet language="go" operationID="listMemoryEntries" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}/entries" -->
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

    res, err := s.Llm.MemoryStores.ListEntries(ctx, operations.ListMemoryEntriesRequest{
        MemoryStoreID: "mem_aa87e2b1112a455b8deabed784372198",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryEntryList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ListMemoryEntriesRequest](../../models/operations/listmemoryentriesrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ListMemoryEntriesResponse](../../models/operations/listmemoryentriesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetEntry

Retrieve memory entry

### Example Usage

<!-- UsageSnippet language="go" operationID="getMemoryEntry" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
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

    res, err := s.Llm.MemoryStores.GetEntry(ctx, "mem_aa87e2b1112a455b8deabed784372198", "mem_entry_bb98f3c2223b566c9dfbcef895483209", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryEntry != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `memoryStoreID`                                                     | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `entryID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_entry_bb98f3c2223b566c9dfbcef895483209                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetMemoryEntryResponse](../../models/operations/getmemoryentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateEntry

Update memory entry

### Example Usage

<!-- UsageSnippet language="go" operationID="updateMemoryEntry" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
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

    res, err := s.Llm.MemoryStores.UpdateEntry(ctx, "mem_aa87e2b1112a455b8deabed784372198", "mem_entry_bb98f3c2223b566c9dfbcef895483209", components.UpdateMemoryEntryRequest{
        Content: "# Login rate limit\n\nReported by Acme and Globex.",
        IfMatch: mka1.Pointer("c378790c771dbb9651bae4c156f88a6b684d5b520a588e5b33d641aa96103680"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryEntry != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |                                                                                            |
| `memoryStoreID`                                                                            | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_aa87e2b1112a455b8deabed784372198                                                       |
| `entryID`                                                                                  | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_entry_bb98f3c2223b566c9dfbcef895483209                                                 |
| `body`                                                                                     | [components.UpdateMemoryEntryRequest](../../models/components/updatememoryentryrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |                                                                                            |

### Response

**[*operations.UpdateMemoryEntryResponse](../../models/operations/updatememoryentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteEntry

Delete memory entry

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteMemoryEntry" method="delete" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.MemoryStores.DeleteEntry(ctx, operations.DeleteMemoryEntryRequest{
        MemoryStoreID: "mem_aa87e2b1112a455b8deabed784372198",
        EntryID: "mem_entry_bb98f3c2223b566c9dfbcef895483209",
        Body: &components.DeleteMemoryEntryRequest{
            IfMatch: mka1.Pointer("c378790c771dbb9651bae4c156f88a6b684d5b520a588e5b33d641aa96103680"),
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.MemoryEntryDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.DeleteMemoryEntryRequest](../../models/operations/deletememoryentryrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.DeleteMemoryEntryResponse](../../models/operations/deletememoryentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |