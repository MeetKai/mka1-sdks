# Usage

## Overview

### Available Operations

* [Sandbox](#sandbox) - Get Sandbox Usage
* [Costs](#costs) - Aggregate cost by dimension

## Sandbox

Aggregate sandbox usage (session lifecycle, execution, and workspace operations) over a time range, bucketed and optionally grouped. Buckets are calendar-aligned in UTC: `start_time` is snapped down and `end_time` snapped up to the nearest bucket-width boundary, so the first and last buckets may extend slightly beyond the requested range. Org-scoped: callers see their own usage, org admins their team's; cluster admins may pass `all_orgs` or `org_ids`. Cost and spend reporting lives in the budgeting API (`/api/v1/budgeting/usage/costs`).

### Example Usage

<!-- UsageSnippet language="go" operationID="getSandboxUsage" method="get" path="/api/v1/sandbox/usage" -->
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

    res, err := s.Usage.Sandbox(ctx, operations.GetSandboxUsageRequest{
        StartTime: 311532,
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.SandboxUsagePage != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `request`                                                                              | [operations.GetSandboxUsageRequest](../../models/operations/getsandboxusagerequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.GetSandboxUsageResponse](../../models/operations/getsandboxusageresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Costs

Sums stored per-entry cost over [start_time, end_time), grouped by any of service, task_type, model, api_key_id, team_id, user_id, external_user_id, org_id. Point-in-time correct for chargeback/showback.

### Example Usage

<!-- UsageSnippet language="go" operationID="getCosts" method="get" path="/api/v1/budgeting/usage/costs" -->
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

    res, err := s.Usage.Costs(ctx, 624757, 189930, mka1.Pointer(""), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `startTime`                                              | `int64`                                                  | :heavy_check_mark:                                       | N/A                                                      |
| `endTime`                                                | `int64`                                                  | :heavy_check_mark:                                       | N/A                                                      |
| `groupBy`                                                | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetCostsResponse](../../models/operations/getcostsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |