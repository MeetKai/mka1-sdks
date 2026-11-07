# Audit.Metrics

## Overview

### Available Operations

* [Inference](#inference) - Get inference metrics

## Inference

Per-model latency, time to first token, output tokens per second and error rate for the organization's model calls. Each provider attempt counts once. Latency covers successful attempts and time to first token covers streaming ones.

### Example Usage

<!-- UsageSnippet language="go" operationID="getInferenceMetrics" method="get" path="/api/v1/audit/metrics/inference" -->
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

    res, err := s.Audit.Metrics.Inference(ctx, nil, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.InferenceMetricsReport != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `ctx`                                                                               | [context.Context](https://pkg.go.dev/context#Context)                               | :heavy_check_mark:                                                                  | The context to use for the request.                                                 |
| `from`                                                                              | [*time.Time](https://pkg.go.dev/time#Time)                                          | :heavy_minus_sign:                                                                  | Start of the window. Defaults to 24 hours before to.                                |
| `to`                                                                                | [*time.Time](https://pkg.go.dev/time#Time)                                          | :heavy_minus_sign:                                                                  | End of the window, exclusive. Defaults to now. The window may span at most 31 days. |
| `xOnBehalfOf`                                                                       | `*string`                                                                           | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `opts`                                                                              | [][operations.Option](../../models/operations/option.md)                            | :heavy_minus_sign:                                                                  | The options for this request.                                                       |

### Response

**[*operations.GetInferenceMetricsResponse](../../models/operations/getinferencemetricsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.AuditAPIError | 400, 401, 403           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |