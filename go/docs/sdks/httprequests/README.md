# Llm.HttpRequests

## Overview

### Available Operations

* [Send](#send) - Send HTTP request

## Send

Sends one HTTP request for the caller and returns the server's status and body. The request goes to public addresses only, under the team's network policy, with no redirects followed, and can authenticate with the caller's own credential from the MCP credential vault, which is only ever sent to the origin it was stored for. An organization tool policy that denies or holds `openapi` tools refuses the request. Any status the server answers with is a 200 here; an error means the request could not be made, or its answer could not be passed on.

### Example Usage

<!-- UsageSnippet language="go" operationID="sendHttpRequest" method="post" path="/api/v1/llm/http_requests" -->
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

    res, err := s.Llm.HTTPRequests.Send(ctx, components.SendHTTPRequestRequest{
        Method: components.SendHTTPRequestRequestMethodPost,
        URL: "https://api.example.com/v1/exports?format=json",
        Headers: map[string]string{
            "X-Request-Source": "workflow",
        },
        Body: mka1.Pointer("{\"since\":\"2026-11-01T00:00:00Z\"}"),
        McpServerID: mka1.Pointer("mcp_srv_aa87e2b1112a455b8deabed784372198"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.HTTPRequestResult != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `body`                                                                                 | [components.SendHTTPRequestRequest](../../models/components/sendhttprequestrequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.SendHTTPRequestResponse](../../models/operations/sendhttprequestresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |