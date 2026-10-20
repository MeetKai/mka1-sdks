# Analytics.Events

## Overview

List individual events with their properties, newest first.

### Available Operations

* [Search](#search) - Search events in a time range

## Search

List individual events in a time range, newest first, with their properties. Optionally filter by event name, event properties, or one visitor's distinct_id. The range includes from and excludes to, and duplicate event IDs are returned once, so a search over a chart bucket's range with the same filters lists exactly the events that bucket counted. A page holds up to 100 events; pass next_cursor as cursor for the following page until it is null. The first page takes a snapshot from ClickHouse's clock before reading its rows and its cursor carries it, so every page of the sequence, the first included, reads only deliveries received at or before that snapshot and ages events out of retention as of it: no event repeats or is skipped, and events received after the snapshot, including a redelivery that revises a listed event, appear only when paging restarts without a cursor. One window blurs that boundary: ClickHouse stamps a receipt at whole seconds when an insert starts and commits its rows when it finishes, so a delivery stamped in or before the snapshot's second that commits after the first page was read is inside the sequence but missing from the first page; it joins from the next page, where an unlisted event it adds or moves ahead of the cursor is skipped and a listed event that a lower-hash redelivery moves behind the cursor repeats at its revised position. A cursor that does not decode, or one from another list, returns 400. A page whose events exceed the response size limit returns 413; request a smaller limit.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_events_search" method="post" path="/api/v1/analytics/projects/{id}/events/search" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/types"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Analytics.Events.Search(ctx, "<id>", components.AnalyticsEventSearchRequest{
        From: types.MustTimeFromString("2026-09-17T07:00:00Z"),
        To: types.MustTimeFromString("2026-09-17T08:00:00Z"),
        EventName: mka1.Pointer("page_view"),
        Filters: []components.AnalyticsEventSearchRequestFilter{
            components.AnalyticsEventSearchRequestFilter{
                Property: "plan",
                Op: components.AnalyticsEventSearchRequestOpEq,
                Value: optionalnullable.From(mka1.Pointer(components.CreateAnalyticsEventSearchRequestValueStr(
                    "pro",
                ))),
            },
        },
        DistinctID: mka1.Pointer("visitor-123"),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsEventSearchResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `id`                                                                                             | `string`                                                                                         | :heavy_check_mark:                                                                               | ID of the analytics project.                                                                     |
| `body`                                                                                           | [components.AnalyticsEventSearchRequest](../../models/components/analyticseventsearchrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.AnalyticsEventsSearchResponse](../../models/operations/analyticseventssearchresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |