# Tracking.Experiments

## Overview

### Available Operations

* [Create](#create) - Create
* [Search](#search) - Search
* [Get](#get) - Get
* [GetByName](#getbyname) - GetByName
* [Delete](#delete) - Delete

## Create

Create a namespaced experiment. Artifact locations are managed by the service. Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingExperimentsCreate" method="post" path="/api/2.0/mlflow/experiments/create" -->
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

    res, err := s.Tracking.Experiments.Create(ctx, operations.TrackingExperimentsCreateRequestBody{
        Name: "<value>",
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

| Parameter                                                                                                          | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                                              | :heavy_check_mark:                                                                                                 | The context to use for the request.                                                                                |
| `body`                                                                                                             | [operations.TrackingExperimentsCreateRequestBody](../../models/operations/trackingexperimentscreaterequestbody.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `xOnBehalfOf`                                                                                                      | `*string`                                                                                                          | :heavy_minus_sign:                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                |
| `opts`                                                                                                             | [][operations.Option](../../models/operations/option.md)                                                           | :heavy_minus_sign:                                                                                                 | The options for this request.                                                                                      |

### Response

**[*operations.TrackingExperimentsCreateResponse](../../models/operations/trackingexperimentscreateresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Search

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingExperimentsSearch" method="post" path="/api/2.0/mlflow/experiments/search" -->
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

    res, err := s.Tracking.Experiments.Search(ctx, operations.TrackingExperimentsSearchRequestBody{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                          | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                                              | :heavy_check_mark:                                                                                                 | The context to use for the request.                                                                                |
| `body`                                                                                                             | [operations.TrackingExperimentsSearchRequestBody](../../models/operations/trackingexperimentssearchrequestbody.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `xOnBehalfOf`                                                                                                      | `*string`                                                                                                          | :heavy_minus_sign:                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                |
| `opts`                                                                                                             | [][operations.Option](../../models/operations/option.md)                                                           | :heavy_minus_sign:                                                                                                 | The options for this request.                                                                                      |

### Response

**[*operations.TrackingExperimentsSearchResponse](../../models/operations/trackingexperimentssearchresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingExperimentsGet" method="get" path="/api/2.0/mlflow/experiments/get" -->
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

    res, err := s.Tracking.Experiments.Get(ctx, "<id>", nil)
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
| `experimentID`                                                      | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.TrackingExperimentsGetResponse](../../models/operations/trackingexperimentsgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetByName

 Requires `read:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingExperimentsGetByName" method="get" path="/api/2.0/mlflow/experiments/get-by-name" -->
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

    res, err := s.Tracking.Experiments.GetByName(ctx, "<value>", nil)
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
| `experimentName`                                                    | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.TrackingExperimentsGetByNameResponse](../../models/operations/trackingexperimentsgetbynameresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

 Requires `write:tracking`. Results are restricted to the API key organization and team.

### Example Usage

<!-- UsageSnippet language="go" operationID="trackingExperimentsDelete" method="post" path="/api/2.0/mlflow/experiments/delete" -->
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

    res, err := s.Tracking.Experiments.Delete(ctx, operations.TrackingExperimentsDeleteRequestBody{
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

| Parameter                                                                                                          | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                                              | :heavy_check_mark:                                                                                                 | The context to use for the request.                                                                                |
| `body`                                                                                                             | [operations.TrackingExperimentsDeleteRequestBody](../../models/operations/trackingexperimentsdeleterequestbody.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `xOnBehalfOf`                                                                                                      | `*string`                                                                                                          | :heavy_minus_sign:                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                |
| `opts`                                                                                                             | [][operations.Option](../../models/operations/option.md)                                                           | :heavy_minus_sign:                                                                                                 | The options for this request.                                                                                      |

### Response

**[*operations.TrackingExperimentsDeleteResponse](../../models/operations/trackingexperimentsdeleteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |