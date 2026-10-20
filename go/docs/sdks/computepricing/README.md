# ComputePricing

## Overview

### Available Operations

* [GetPricing](#getpricing) - Get the latest committed storage price
* [PutPricing](#putpricing) - Create an immutable storage-price version

## GetPricing

The latest version may be scheduled for the next UTC hour. Before the first version is written this route returns pricing_not_configured.

### Example Usage

<!-- UsageSnippet language="go" operationID="getPricing" method="get" path="/api/v1/compute/pricing" -->
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

    res, err := s.ComputePricing.GetPricing(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputePricing != nil {
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

**[*operations.GetPricingResponse](../../models/operations/getpricingresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## PutPricing

Cluster administrators only. If-Match: 0 performs the explicit bootstrap. Every version activates at the next UTC-hour boundary; equivalent idempotent replay precedes version comparison.

### Example Usage

<!-- UsageSnippet language="go" operationID="putPricing" method="put" path="/api/v1/compute/pricing" -->
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

    res, err := s.ComputePricing.PutPricing(ctx, "<value>", "<value>", components.ComputePricingUpdate{
        VolumeStorageUsdPerGibHour: 6479.35,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputePricing != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `idempotencyKey`                                                                   | `string`                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `ifMatch`                                                                          | `string`                                                                           | :heavy_check_mark:                                                                 | Current pricing version. Use 0 for the first write.                                |
| `body`                                                                             | [components.ComputePricingUpdate](../../models/components/computepricingupdate.md) | :heavy_check_mark:                                                                 | N/A                                                                                |
| `xOnBehalfOf`                                                                      | `*string`                                                                          | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.PutPricingResponse](../../models/operations/putpricingresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |