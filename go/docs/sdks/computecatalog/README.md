# ComputeCatalog

## Overview

### Available Operations

* [ListAccelerators](#listaccelerators) - List accelerators
* [GetAccelerator](#getaccelerator) - Get an accelerator
* [ListComputeOffers](#listcomputeoffers) - List provider offers
* [ListComputeProviders](#listcomputeproviders) - List provider health
* [CreateComputeQuote](#createcomputequote) - Create a quote

## ListAccelerators

List accelerators

### Example Usage

<!-- UsageSnippet language="go" operationID="listAccelerators" method="get" path="/api/v1/compute/catalog/accelerators" -->
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

    res, err := s.ComputeCatalog.ListAccelerators(ctx, nil, nil, mka1.Pointer[int64](50), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeAcceleratorList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `vendor`                                                            | [*operations.Vendor](../../models/operations/vendor.md)             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `cursor`                                                            | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListAcceleratorsResponse](../../models/operations/listacceleratorsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetAccelerator

Get an accelerator

### Example Usage

<!-- UsageSnippet language="go" operationID="getAccelerator" method="get" path="/api/v1/compute/catalog/accelerators/{name}" -->
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

    res, err := s.ComputeCatalog.GetAccelerator(ctx, "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeAccelerator != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `name`                                                              | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetAcceleratorResponse](../../models/operations/getacceleratorresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListComputeOffers

Cluster administrators may always read this route. Organization administrators may read it only when provider anonymity is disabled.

### Example Usage

<!-- UsageSnippet language="go" operationID="listComputeOffers" method="get" path="/api/v1/compute/catalog/offers" -->
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

    res, err := s.ComputeCatalog.ListComputeOffers(ctx, operations.ListComputeOffersRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeOfferList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ListComputeOffersRequest](../../models/operations/listcomputeoffersrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ListComputeOffersResponse](../../models/operations/listcomputeoffersresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListComputeProviders

Cluster administrators may always read this route. Organization administrators may read it only when provider anonymity is disabled.

### Example Usage

<!-- UsageSnippet language="go" operationID="listComputeProviders" method="get" path="/api/v1/compute/catalog/providers" -->
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

    res, err := s.ComputeCatalog.ListComputeProviders(ctx, nil, mka1.Pointer[int64](50), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeProviderHealthList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `cursor`                                                            | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListComputeProvidersResponse](../../models/operations/listcomputeprovidersresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateComputeQuote

Create a quote

### Example Usage

<!-- UsageSnippet language="go" operationID="createComputeQuote" method="post" path="/api/v1/compute/catalog/quotes" -->
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

    res, err := s.ComputeCatalog.CreateComputeQuote(ctx, components.ComputeQuoteRequest{
        Compute: components.ComputeRequest{
            Accelerator: "<value>",
            EphemeralDiskGb: 986693,
            GpuCount: 546670,
        },
        Container: components.ComputeQuoteRequestContainer{
            Image: "https://loremflickr.com/3170/1872?lock=3147859139793822",
        },
        ResourceType: components.ComputeResourceTypeJob,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeQuote != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |
| `body`                                                                           | [components.ComputeQuoteRequest](../../models/components/computequoterequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |

### Response

**[*operations.CreateComputeQuoteResponse](../../models/operations/createcomputequoteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |