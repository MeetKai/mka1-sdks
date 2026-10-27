# Llm.Audit

## Overview

### Available Operations

* [GetRequestTrace](#getrequesttrace) - Get a request trace

## GetRequestTrace

Returns the end-to-end trace of one API request: its timing at the API gateway, every response it created (including agents it called), and each response's model invocations and tool calls with durations. Look it up by the `X-Request-ID` returned on every response, or by the API gateway's own request ID. Org owners and admins only, scoped to their own organization. Requests audited before request IDs were recorded show their gateway timing but no responses.

### Example Usage

<!-- UsageSnippet language="go" operationID="getRequestTrace" method="get" path="/api/v1/llm/audit/requests/{request_id}/trace" -->
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

    res, err := s.Llm.Audit.GetRequestTrace(ctx, "3f6c1b2e-8d4a-4c1e-9b7f-2a5d6e8f9c01#12")
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `requestID`                                              | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | 3f6c1b2e-8d4a-4c1e-9b7f-2a5d6e8f9c01#12                  |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.GetRequestTraceResponse](../../models/operations/getrequesttraceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |