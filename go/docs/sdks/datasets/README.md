# Datasets

## Overview

### Available Operations

* [ListGenerators](#listgenerators) - List Generators
* [GetGenerator](#getgenerator) - Get Generator
* [QuoteGenerator](#quotegenerator) - Quote Generator
* [ListGenerations](#listgenerations) - List Generations
* [CreateGeneration](#creategeneration) - Create Generation
* [GetGeneration](#getgeneration) - Get Generation
* [GetGenerationLogs](#getgenerationlogs) - Get Logs
* [GetGenerationEvents](#getgenerationevents) - Get Events
* [CancelGeneration](#cancelgeneration) - Cancel Generation
* [ListFormats](#listformats) - List Formats
* [GetFormat](#getformat) - Get Format

## ListGenerators

List Generators

### Example Usage

<!-- UsageSnippet language="go" operationID="list_generators_api_v1_datasets_generators_get" method="get" path="/api/v1/datasets/generators" -->
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

    res, err := s.Datasets.ListGenerators(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GeneratorList != nil {
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

**[*operations.ListGeneratorsAPIV1DatasetsGeneratorsGetResponse](../../models/operations/listgeneratorsapiv1datasetsgeneratorsgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetGenerator

Get Generator

### Example Usage

<!-- UsageSnippet language="go" operationID="get_generator_api_v1_datasets_generators__generator_id__get" method="get" path="/api/v1/datasets/generators/{generator_id}" -->
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

    res, err := s.Datasets.GetGenerator(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GeneratorDetail != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `generatorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetGeneratorAPIV1DatasetsGeneratorsGeneratorIDGetResponse](../../models/operations/getgeneratorapiv1datasetsgeneratorsgeneratoridgetresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## QuoteGenerator

Quote Generator

### Example Usage

<!-- UsageSnippet language="go" operationID="quote_generator_api_v1_datasets_generators__generator_id__quote_post" method="post" path="/api/v1/datasets/generators/{generator_id}/quote" -->
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

    res, err := s.Datasets.QuoteGenerator(ctx, "<id>", components.QuoteRequest{
        Params: map[string]any{
            "key": "<value>",
            "key1": "<value>",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.QuoteResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `generatorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `body`                                                              | [components.QuoteRequest](../../models/components/quoterequest.md)  | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.QuoteGeneratorAPIV1DatasetsGeneratorsGeneratorIDQuotePostResponse](../../models/operations/quotegeneratorapiv1datasetsgeneratorsgeneratoridquotepostresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## ListGenerations

List Generations

### Example Usage

<!-- UsageSnippet language="go" operationID="list_generations_api_v1_datasets_generations_get" method="get" path="/api/v1/datasets/generations" -->
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

    res, err := s.Datasets.ListGenerations(ctx, operations.ListGenerationsAPIV1DatasetsGenerationsGetRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.PageGeneration != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                    | Type                                                                                                                                         | Required                                                                                                                                     | Description                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                                                        | :heavy_check_mark:                                                                                                                           | The context to use for the request.                                                                                                          |
| `request`                                                                                                                                    | [operations.ListGenerationsAPIV1DatasetsGenerationsGetRequest](../../models/operations/listgenerationsapiv1datasetsgenerationsgetrequest.md) | :heavy_check_mark:                                                                                                                           | The request object to use for the request.                                                                                                   |
| `opts`                                                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                                                     | :heavy_minus_sign:                                                                                                                           | The options for this request.                                                                                                                |

### Response

**[*operations.ListGenerationsAPIV1DatasetsGenerationsGetResponse](../../models/operations/listgenerationsapiv1datasetsgenerationsgetresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## CreateGeneration

The components.md §6 D.1 sequence, in its order: the run credential is minted before
anything is spent, nothing is written before the digest is pinned, and the workflow starts
only after the row is committed.

### Example Usage

<!-- UsageSnippet language="go" operationID="create_generation_api_v1_datasets_generations_post" method="post" path="/api/v1/datasets/generations" -->
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

    res, err := s.Datasets.CreateGeneration(ctx, "<value>", components.CreateGeneration{
        GeneratorID: "<id>",
        Params: map[string]any{
            "key": "<value>",
            "key1": "<value>",
        },
        Output: components.OutputSpec{
            Repo: "<value>",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GenerationCreated != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `ctx`                                                                      | [context.Context](https://pkg.go.dev/context#Context)                      | :heavy_check_mark:                                                         | The context to use for the request.                                        |
| `idempotencyKey`                                                           | `string`                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `body`                                                                     | [components.CreateGeneration](../../models/components/creategeneration.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `xOnBehalfOf`                                                              | `*string`                                                                  | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |
| `opts`                                                                     | [][operations.Option](../../models/operations/option.md)                   | :heavy_minus_sign:                                                         | The options for this request.                                              |

### Response

**[*operations.CreateGenerationAPIV1DatasetsGenerationsPostResponse](../../models/operations/creategenerationapiv1datasetsgenerationspostresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## GetGeneration

Get Generation

### Example Usage

<!-- UsageSnippet language="go" operationID="get_generation_api_v1_datasets_generations__generation_id__get" method="get" path="/api/v1/datasets/generations/{generation_id}" -->
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

    res, err := s.Datasets.GetGeneration(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Generation != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `generationID`                                                      | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetGenerationAPIV1DatasetsGenerationsGenerationIDGetResponse](../../models/operations/getgenerationapiv1datasetsgenerationsgenerationidgetresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## GetGenerationLogs

Get Logs

### Example Usage

<!-- UsageSnippet language="go" operationID="get_logs_api_v1_datasets_generations__generation_id__logs_get" method="get" path="/api/v1/datasets/generations/{generation_id}/logs" -->
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

    res, err := s.Datasets.GetGenerationLogs(ctx, operations.GetLogsAPIV1DatasetsGenerationsGenerationIDLogsGetRequest{
        GenerationID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.PageLogLine != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                    | Type                                                                                                                                                         | Required                                                                                                                                                     | Description                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                                                                        | :heavy_check_mark:                                                                                                                                           | The context to use for the request.                                                                                                                          |
| `request`                                                                                                                                                    | [operations.GetLogsAPIV1DatasetsGenerationsGenerationIDLogsGetRequest](../../models/operations/getlogsapiv1datasetsgenerationsgenerationidlogsgetrequest.md) | :heavy_check_mark:                                                                                                                                           | The request object to use for the request.                                                                                                                   |
| `opts`                                                                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                                                                     | :heavy_minus_sign:                                                                                                                                           | The options for this request.                                                                                                                                |

### Response

**[*operations.GetLogsAPIV1DatasetsGenerationsGenerationIDLogsGetResponse](../../models/operations/getlogsapiv1datasetsgenerationsgenerationidlogsgetresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## GetGenerationEvents

Get Events

### Example Usage

<!-- UsageSnippet language="go" operationID="get_events_api_v1_datasets_generations__generation_id__events_get" method="get" path="/api/v1/datasets/generations/{generation_id}/events" -->
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

    res, err := s.Datasets.GetGenerationEvents(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EventList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `generationID`                                                      | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetEventsAPIV1DatasetsGenerationsGenerationIDEventsGetResponse](../../models/operations/geteventsapiv1datasetsgenerationsgenerationideventsgetresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## CancelGeneration

api.md §3: `cancelling` is written here, then the signal; a `cancelling` row whose
signal was lost (the retry case) is signalled again.

### Example Usage

<!-- UsageSnippet language="go" operationID="cancel_generation_api_v1_datasets_generations__generation_id__cancel_post" method="post" path="/api/v1/datasets/generations/{generation_id}/cancel" -->
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

    res, err := s.Datasets.CancelGeneration(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Generation != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `generationID`                                                      | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.CancelGenerationAPIV1DatasetsGenerationsGenerationIDCancelPostResponse](../../models/operations/cancelgenerationapiv1datasetsgenerationsgenerationidcancelpostresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## ListFormats

List Formats

### Example Usage

<!-- UsageSnippet language="go" operationID="list_formats_api_v1_datasets_formats_get" method="get" path="/api/v1/datasets/formats" -->
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

    res, err := s.Datasets.ListFormats(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FormatList != nil {
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

**[*operations.ListFormatsAPIV1DatasetsFormatsGetResponse](../../models/operations/listformatsapiv1datasetsformatsgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetFormat

Get Format

### Example Usage

<!-- UsageSnippet language="go" operationID="get_format_api_v1_datasets_formats__format_id__get" method="get" path="/api/v1/datasets/formats/{format_id}" -->
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

    res, err := s.Datasets.GetFormat(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FormatDetail != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `formatID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetFormatAPIV1DatasetsFormatsFormatIDGetResponse](../../models/operations/getformatapiv1datasetsformatsformatidgetresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |