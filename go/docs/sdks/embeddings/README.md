# Llm.Embeddings

## Overview

### Available Operations

* [ListModels](#listmodels) - List available embedding models
* [Embed](#embed) - Create text embeddings

## ListModels

Returns a list of available embedding models with their limits. Use this endpoint to discover which models are available and their constraints (batch size, input length) before making embedding requests.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEmbeddingModels" method="get" path="/api/v1/llm/embeddings/models" -->
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

    res, err := s.Llm.Embeddings.ListModels(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EmbeddingModelListResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListEmbeddingModelsResponse](../../models/operations/listembeddingmodelsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Embed

Generates vector embeddings for single or multiple text inputs. Returns floating-point vectors along with token usage statistics.

### Example Usage

<!-- UsageSnippet language="go" operationID="embed" method="post" path="/api/v1/llm/embeddings" -->
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

    res, err := s.Llm.Embeddings.Embed(ctx, components.EmbeddingsRequest{
        Input: components.CreateEmbeddingsRequestInputStr(
            "The quick brown fox jumps over the lazy dog.",
        ),
        Model: "auto",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EmbeddingsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `ctx`                                                                        | [context.Context](https://pkg.go.dev/context#Context)                        | :heavy_check_mark:                                                           | The context to use for the request.                                          |                                                                              |
| `body`                                                                       | [components.EmbeddingsRequest](../../models/components/embeddingsrequest.md) | :heavy_check_mark:                                                           | N/A                                                                          | {<br/>"model": "auto",<br/>"input": "The quick brown fox jumps over the lazy dog."<br/>} |
| `xOnBehalfOf`                                                                | `*string`                                                                    | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |                                                                              |
| `opts`                                                                       | [][operations.Option](../../models/operations/option.md)                     | :heavy_minus_sign:                                                           | The options for this request.                                                |                                                                              |

### Response

**[*operations.EmbedResponse](../../models/operations/embedresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |