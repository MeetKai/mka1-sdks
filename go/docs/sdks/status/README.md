# Status

## Overview

### Available Operations

* [Get](#get) - Get the service status

## Get

Each service's current status and the active incidents. Any authenticated caller may read it.

### Example Usage

<!-- UsageSnippet language="go" operationID="getServiceStatus" method="get" path="/api/v1/status" -->
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

    res, err := s.Status.Get(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.StatusSummary != nil {
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

**[*operations.GetServiceStatusResponse](../../models/operations/getservicestatusresponse.md), error**

### Errors

| Error Type                | Status Code               | Content Type              |
| ------------------------- | ------------------------- | ------------------------- |
| apierrors.SupportAPIError | 401                       | application/json          |
| apierrors.APIError        | 4XX, 5XX                  | \*/\*                     |