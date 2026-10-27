# Flags.Audit

## Overview

### Available Operations

* [List](#list) - List audit entries, newest first

## List

List audit entries, newest first

### Example Usage

<!-- UsageSnippet language="go" operationID="listFeatureFlagAuditEntries" method="get" path="/api/v1/flags/audit" -->
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

    res, err := s.Flags.Audit.List(ctx, mka1.Pointer[int64](50), nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagAuditPage != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `before`                                                            | `*int64`                                                            | :heavy_minus_sign:                                                  | Return entries with an id lower than this (from next_before).       |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListFeatureFlagAuditEntriesResponse](../../models/operations/listfeatureflagauditentriesresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |