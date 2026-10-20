# Analytics

## Overview

Send events and query event counts or unique visitors.

### Available Operations

* [Capture](#capture) - Durably accept a batch of events
* [Query](#query) - Query event counts or unique visitors

## Capture

Send a batch of events using the project's X-Analytics-Key header. A 202 response confirms the batch is stored; events become available to queries after background processing. Retry with the same idempotency_key and unchanged events if you do not receive a response.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_capture" method="post" path="/api/v1/analytics/capture" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"github.com/MeetKai/mka1-sdks/go/types"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Analytics.Capture(ctx, operations.AnalyticsCaptureSecurity{
        AnalyticsCaptureKey: "<YOUR_API_KEY_HERE>",
    }, components.AnalyticsCaptureRequest{
        IdempotencyKey: "batch-2026-09-01-001",
        Events: []components.AnalyticsEvent{
            components.AnalyticsEvent{
                EventID: "14fb0864-445b-4ed6-8d67-02c93538d668",
                EventName: "page_view",
                Timestamp: types.MustTimeFromString("2026-09-01T12:30:00Z"),
                DistinctID: "visitor-123",
                Properties: map[string]*components.Properties{
                    "pathname": mka1.Pointer(components.CreatePropertiesStr(
                        "/pricing",
                    )),
                    "plan": mka1.Pointer(components.CreatePropertiesStr(
                        "pro",
                    )),
                },
            },
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsCaptureResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `security`                                                                                 | [operations.AnalyticsCaptureSecurity](../../models/operations/analyticscapturesecurity.md) | :heavy_check_mark:                                                                         | The security requirements to use for the request.                                          |
| `body`                                                                                     | [components.AnalyticsCaptureRequest](../../models/components/analyticscapturerequest.md)   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.AnalyticsCaptureResponse](../../models/operations/analyticscaptureresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |

## Query

Count events or unique visitors in a time range. Optionally filter by event name or properties, group by one property, and split results into hour, day, or week buckets that start on the clock of an IANA time zone, UTC by default. Each bucket is returned as the UTC instant at which it starts. The range includes from and excludes to. Duplicate event IDs are counted once. An unknown time zone returns 400.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_query" method="post" path="/api/v1/analytics/projects/{id}/query" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/types"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Analytics.Query(ctx, "<id>", components.AnalyticsQueryRequest{
        Metric: components.AnalyticsQueryRequestMetricUniqueVisitors,
        From: types.MustTimeFromString("2026-09-01T00:00:00Z"),
        To: types.MustTimeFromString("2026-09-02T00:00:00Z"),
        EventName: mka1.Pointer("page_view"),
        Bucket: components.BucketHour.ToPointer(),
        Timezone: mka1.Pointer("America/Los_Angeles"),
        GroupBy: mka1.Pointer("pathname"),
        Filters: []components.AnalyticsQueryRequestFilter{
            components.AnalyticsQueryRequestFilter{
                Property: "plan",
                Op: components.AnalyticsQueryRequestOpEq,
                Value: optionalnullable.From(mka1.Pointer(components.CreateAnalyticsQueryRequestValueStr(
                    "pro",
                ))),
            },
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsQueryResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                              | Type                                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                                            | Example                                                                                                                                                                                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                                                                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                     | The context to use for the request.                                                                                                                                                                                                                                                    |                                                                                                                                                                                                                                                                                        |
| `id`                                                                                                                                                                                                                                                                                   | `string`                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                     | ID of the analytics project.                                                                                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                        |
| `body`                                                                                                                                                                                                                                                                                 | [components.AnalyticsQueryRequest](../../models/components/analyticsqueryrequest.md)                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                                    | {<br/>"metric": "unique_visitors",<br/>"from": "2026-09-01T00:00:00Z",<br/>"to": "2026-09-02T00:00:00Z",<br/>"event_name": "page_view",<br/>"bucket": "hour",<br/>"timezone": "America/Los_Angeles",<br/>"group_by": "pathname",<br/>"filters": [<br/>{<br/>"property": "plan",<br/>"op": "eq",<br/>"value": "pro"<br/>}<br/>],<br/>"limit": 100<br/>} |
| `opts`                                                                                                                                                                                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                     | The options for this request.                                                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                        |

### Response

**[*operations.AnalyticsQueryResponse](../../models/operations/analyticsqueryresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |