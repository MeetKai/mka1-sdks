# Llm.Usage

## Overview

### Available Operations

* [Completions](#completions) - Get completions usage
* [Responses](#responses) - Get responses usage
* [Conversations](#conversations) - Get conversations usage
* [Embeddings](#embeddings) - Get embeddings usage
* [Extract](#extract) - Get extract usage
* [Classify](#classify) - Get classify usage
* [VectorStores](#vectorstores) - Get vector stores usage
* [Files](#files) - Get files usage
* [Costs](#costs) - Get cost by model

## Completions

Retrieve usage metrics for chat completions, aggregated from the ChatCompletion table.

### Example Usage

<!-- UsageSnippet language="go" operationID="getCompletionsUsage" method="get" path="/api/v1/llm/usage/completions" -->
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

    res, err := s.Llm.Usage.Completions(ctx, operations.GetCompletionsUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.CompletionsGroupBy{
            components.CompletionsGroupByModel,
        },
        Models: []string{
            "meetkai:functionary-urdu-mini-pak",
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `request`                                                                                      | [operations.GetCompletionsUsageRequest](../../models/operations/getcompletionsusagerequest.md) | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.GetCompletionsUsageResponse](../../models/operations/getcompletionsusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Responses

Retrieve usage metrics for agent responses, aggregated from the Response table.

### Example Usage

<!-- UsageSnippet language="go" operationID="getResponsesUsage" method="get" path="/api/v1/llm/usage/responses" -->
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

    res, err := s.Llm.Usage.Responses(ctx, operations.GetResponsesUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.ResponsesGroupBy{
            components.ResponsesGroupByModel,
            components.ResponsesGroupByBackground,
        },
        Models: []string{
            "meetkai:functionary-urdu-mini-pak",
        },
        Background: mka1.Pointer(false),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.GetResponsesUsageRequest](../../models/operations/getresponsesusagerequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.GetResponsesUsageResponse](../../models/operations/getresponsesusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Conversations

Retrieve usage metrics for conversation operations.

### Example Usage

<!-- UsageSnippet language="go" operationID="getConversationsUsage" method="get" path="/api/v1/llm/usage/conversations" -->
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

    res, err := s.Llm.Usage.Conversations(ctx, operations.GetConversationsUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.ConversationsGroupBy{
            components.ConversationsGroupByUserID,
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `request`                                                                                          | [operations.GetConversationsUsageRequest](../../models/operations/getconversationsusagerequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.GetConversationsUsageResponse](../../models/operations/getconversationsusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Embeddings

Retrieve usage metrics for embedding operations.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEmbeddingsUsage" method="get" path="/api/v1/llm/usage/embeddings" -->
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

    res, err := s.Llm.Usage.Embeddings(ctx, operations.GetEmbeddingsUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.EmbeddingsGroupBy{
            components.EmbeddingsGroupByModel,
        },
        Models: []string{
            "auto",
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |
| `request`                                                                                    | [operations.GetEmbeddingsUsageRequest](../../models/operations/getembeddingsusagerequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |

### Response

**[*operations.GetEmbeddingsUsageResponse](../../models/operations/getembeddingsusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Extract

Retrieve usage metrics for extract operations.

### Example Usage

<!-- UsageSnippet language="go" operationID="getExtractUsage" method="get" path="/api/v1/llm/usage/extract" -->
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

    res, err := s.Llm.Usage.Extract(ctx, operations.GetExtractUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.ExtractGroupBy{
            components.ExtractGroupByModel,
        },
        Models: []string{
            "meetkai:functionary-urdu-mini-pak",
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `request`                                                                              | [operations.GetExtractUsageRequest](../../models/operations/getextractusagerequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.GetExtractUsageResponse](../../models/operations/getextractusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Classify

Retrieve usage metrics for classify operations.

### Example Usage

<!-- UsageSnippet language="go" operationID="getClassifyUsage" method="get" path="/api/v1/llm/usage/classify" -->
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

    res, err := s.Llm.Usage.Classify(ctx, operations.GetClassifyUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.ClassifyGroupBy{
            components.ClassifyGroupByModel,
        },
        Models: []string{
            "meetkai:functionary-urdu-mini-pak",
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `request`                                                                                | [operations.GetClassifyUsageRequest](../../models/operations/getclassifyusagerequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.GetClassifyUsageResponse](../../models/operations/getclassifyusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## VectorStores

Retrieve usage metrics for vector storage operations.

### Example Usage

<!-- UsageSnippet language="go" operationID="getVectorStoresUsage" method="get" path="/api/v1/llm/usage/vector_stores" -->
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

    res, err := s.Llm.Usage.VectorStores(ctx, operations.GetVectorStoresUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.VectorStoresGroupBy{
            components.VectorStoresGroupByUserID,
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `request`                                                                                        | [operations.GetVectorStoresUsageRequest](../../models/operations/getvectorstoresusagerequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.GetVectorStoresUsageResponse](../../models/operations/getvectorstoresusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Files

Retrieve bytes of files created per period from durable file creation events. This does not reflect current retained storage, buckets remain counted after file deletion, and grouped results collapse by requested output dimensions rather than one row per UserContext.

### Example Usage

<!-- UsageSnippet language="go" operationID="getFilesUsage" method="get" path="/api/v1/llm/usage/files" -->
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

    res, err := s.Llm.Usage.Files(ctx, operations.GetFilesUsageRequest{
        StartTime: 1704067200,
        EndTime: mka1.Pointer[int64](1704153600),
        Limit: mka1.Pointer[int64](30),
        Page: mka1.Pointer("cursor_abc123"),
        UserIds: []string{
            "user_123",
            "user_456",
        },
        ExternalUserIds: []string{
            "sub_123",
        },
        OrgIds: []string{
            "org_123",
        },
        GroupBy: []components.FilesGroupBy{
            components.FilesGroupByUserID,
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `request`                                                                          | [operations.GetFilesUsageRequest](../../models/operations/getfilesusagerequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.GetFilesUsageResponse](../../models/operations/getfilesusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Costs

Aggregates spend by model over a time range, priced in the cluster currency from the model price book. Org-scoped: org admins see their org; cluster admins may pass `org_id`. Includes billable work with no usage row of its own (store=false responses, agent tool calls), so totals cover all LLM spend. Platform-wide, cross-service cost reporting lives in the budgeting API (/api/v1/budgeting/usage/costs).

### Example Usage

<!-- UsageSnippet language="go" operationID="getCostsUsage" method="get" path="/api/v1/llm/usage/costs" -->
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

    res, err := s.Llm.Usage.Costs(ctx, operations.GetCostsUsageRequest{
        StartTime: 612474,
        EndTime: 211313,
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.UsageCostsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `request`                                                                          | [operations.GetCostsUsageRequest](../../models/operations/getcostsusagerequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.GetCostsUsageResponse](../../models/operations/getcostsusageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |