# Tracking.Runs

## Overview

### Available Operations

* [Create](#create) - Create
* [Get](#get) - Get
* [Search](#search) - Search
* [Update](#update) - Update
* [Delete](#delete) - Delete
* [Restore](#restore) - Restore
* [LogMetric](#logmetric) - LogMetric
* [LogParameter](#logparameter) - LogParameter
* [SetTag](#settag) - SetTag
* [DeleteTag](#deletetag) - DeleteTag
* [LogBatch](#logbatch) - LogBatch
* [LogInputs](#loginputs) - LogInputs
* [GetMetricHistory](#getmetrichistory) - GetMetricHistory

## Create

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsCreate" method="post" path="/api/2.0/mlflow/runs/create" -->
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

    res, err := s.Tracking.Runs.Create(ctx, operations.TrackingRunsCreateRequestBody{
        ExperimentID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `body`                                                                                               | [operations.TrackingRunsCreateRequestBody](../../models/operations/trackingrunscreaterequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.TrackingRunsCreateResponse](../../models/operations/trackingrunscreateresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsGet" method="get" path="/api/2.0/mlflow/runs/get" -->
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

    res, err := s.Tracking.Runs.Get(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.TrackingRunsGetResponse](../../models/operations/trackingrunsgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Search

Explicit experiment IDs are required; every experiment must belong to the caller. Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsSearch" method="post" path="/api/2.0/mlflow/runs/search" -->
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

    res, err := s.Tracking.Runs.Search(ctx, operations.TrackingRunsSearchRequestBody{
        ExperimentIds: []string{
            "<value 1>",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `body`                                                                                               | [operations.TrackingRunsSearchRequestBody](../../models/operations/trackingrunssearchrequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.TrackingRunsSearchResponse](../../models/operations/trackingrunssearchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsUpdate" method="post" path="/api/2.0/mlflow/runs/update" -->
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

    res, err := s.Tracking.Runs.Update(ctx, operations.TrackingRunsUpdateRequestBody{
        RunID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `body`                                                                                               | [operations.TrackingRunsUpdateRequestBody](../../models/operations/trackingrunsupdaterequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.TrackingRunsUpdateResponse](../../models/operations/trackingrunsupdateresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsDelete" method="post" path="/api/2.0/mlflow/runs/delete" -->
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

    res, err := s.Tracking.Runs.Delete(ctx, operations.TrackingRunsDeleteRequestBody{
        RunID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `body`                                                                                               | [operations.TrackingRunsDeleteRequestBody](../../models/operations/trackingrunsdeleterequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.TrackingRunsDeleteResponse](../../models/operations/trackingrunsdeleteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Restore

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsRestore" method="post" path="/api/2.0/mlflow/runs/restore" -->
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

    res, err := s.Tracking.Runs.Restore(ctx, operations.TrackingRunsRestoreRequestBody{
        RunID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `body`                                                                                                 | [operations.TrackingRunsRestoreRequestBody](../../models/operations/trackingrunsrestorerequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `xOnBehalfOf`                                                                                          | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.TrackingRunsRestoreResponse](../../models/operations/trackingrunsrestoreresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## LogMetric

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsLogMetric" method="post" path="/api/2.0/mlflow/runs/log-metric" -->
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

    res, err := s.Tracking.Runs.LogMetric(ctx, operations.TrackingRunsLogMetricRequestBody{
        RunID: "<id>",
        Key: "<key>",
        Value: 1403.55,
        Timestamp: 778356,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                                      | :heavy_check_mark:                                                                                         | The context to use for the request.                                                                        |
| `body`                                                                                                     | [operations.TrackingRunsLogMetricRequestBody](../../models/operations/trackingrunslogmetricrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `xOnBehalfOf`                                                                                              | `*string`                                                                                                  | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `opts`                                                                                                     | [][operations.Option](../../models/operations/option.md)                                                   | :heavy_minus_sign:                                                                                         | The options for this request.                                                                              |

### Response

**[*operations.TrackingRunsLogMetricResponse](../../models/operations/trackingrunslogmetricresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## LogParameter

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsLogParameter" method="post" path="/api/2.0/mlflow/runs/log-parameter" -->
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

    res, err := s.Tracking.Runs.LogParameter(ctx, operations.TrackingRunsLogParameterRequestBody{
        RunID: "<id>",
        Key: "<key>",
        Value: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |
| `body`                                                                                                           | [operations.TrackingRunsLogParameterRequestBody](../../models/operations/trackingrunslogparameterrequestbody.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `xOnBehalfOf`                                                                                                    | `*string`                                                                                                        | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |

### Response

**[*operations.TrackingRunsLogParameterResponse](../../models/operations/trackingrunslogparameterresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetTag

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsSetTag" method="post" path="/api/2.0/mlflow/runs/set-tag" -->
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

    res, err := s.Tracking.Runs.SetTag(ctx, operations.TrackingRunsSetTagRequestBody{
        RunID: "<id>",
        Key: "<key>",
        Value: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `body`                                                                                               | [operations.TrackingRunsSetTagRequestBody](../../models/operations/trackingrunssettagrequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.TrackingRunsSetTagResponse](../../models/operations/trackingrunssettagresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteTag

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsDeleteTag" method="post" path="/api/2.0/mlflow/runs/delete-tag" -->
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

    res, err := s.Tracking.Runs.DeleteTag(ctx, operations.TrackingRunsDeleteTagRequestBody{
        RunID: "<id>",
        Key: "<key>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                                      | :heavy_check_mark:                                                                                         | The context to use for the request.                                                                        |
| `body`                                                                                                     | [operations.TrackingRunsDeleteTagRequestBody](../../models/operations/trackingrunsdeletetagrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `xOnBehalfOf`                                                                                              | `*string`                                                                                                  | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `opts`                                                                                                     | [][operations.Option](../../models/operations/option.md)                                                   | :heavy_minus_sign:                                                                                         | The options for this request.                                                                              |

### Response

**[*operations.TrackingRunsDeleteTagResponse](../../models/operations/trackingrunsdeletetagresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## LogBatch

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsLogBatch" method="post" path="/api/2.0/mlflow/runs/log-batch" -->
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

    res, err := s.Tracking.Runs.LogBatch(ctx, operations.TrackingRunsLogBatchRequestBody{
        RunID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `body`                                                                                                   | [operations.TrackingRunsLogBatchRequestBody](../../models/operations/trackingrunslogbatchrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.TrackingRunsLogBatchResponse](../../models/operations/trackingrunslogbatchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## LogInputs

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsLogInputs" method="post" path="/api/2.0/mlflow/runs/log-inputs" -->
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

    res, err := s.Tracking.Runs.LogInputs(ctx, operations.TrackingRunsLogInputsRequestBody{
        RunID: "<id>",
        Datasets: []components.DatasetInput{
            components.DatasetInput{
                Dataset: components.Dataset{
                    Name: "<value>",
                    Digest: "<value>",
                    SourceType: "<value>",
                    Source: "<value>",
                },
            },
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                                      | :heavy_check_mark:                                                                                         | The context to use for the request.                                                                        |
| `body`                                                                                                     | [operations.TrackingRunsLogInputsRequestBody](../../models/operations/trackingrunsloginputsrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `xOnBehalfOf`                                                                                              | `*string`                                                                                                  | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `opts`                                                                                                     | [][operations.Option](../../models/operations/option.md)                                                   | :heavy_minus_sign:                                                                                         | The options for this request.                                                                              |

### Response

**[*operations.TrackingRunsLogInputsResponse](../../models/operations/trackingrunsloginputsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetMetricHistory

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingRunsGetMetricHistory" method="get" path="/api/2.0/mlflow/metrics/get-history" -->
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

    res, err := s.Tracking.Runs.GetMetricHistory(ctx, operations.TrackingRunsGetMetricHistoryRequest{
        RunID: "<id>",
        MetricKey: "<value>",
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

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |
| `request`                                                                                                        | [operations.TrackingRunsGetMetricHistoryRequest](../../models/operations/trackingrunsgetmetrichistoryrequest.md) | :heavy_check_mark:                                                                                               | The request object to use for the request.                                                                       |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |

### Response

**[*operations.TrackingRunsGetMetricHistoryResponse](../../models/operations/trackingrunsgetmetrichistoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |