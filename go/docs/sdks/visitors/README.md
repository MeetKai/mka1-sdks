# Analytics.Visitors

## Overview

List visitors by their latest activity, with first and last seen times.

### Available Operations

* [Search](#search) - Search visitors in a time range

## Search

List visitors with matching events in a time range, most recently active first. Each visitor is one distinct_id with the timestamps of its first and last matching event and its event count over the whole range, so for a range that receives no further events the number of visitors across all pages equals the unique_visitors query for the same range and filters. The range includes from and excludes to, and duplicate event IDs are counted once. A page holds up to 100 visitors; pass next_cursor as cursor for the following page until it is null. The first page takes a snapshot from ClickHouse's clock before reading its rows and its cursor carries it, so every page of the sequence, the first included, reads only deliveries received at or before that snapshot and ages events out of retention as of it: a visitor keeps the position, first_seen, last_seen and event_count the sequence started with, no visitor repeats or is skipped, and activity received after the snapshot appears only when paging restarts without a cursor. One window blurs that boundary: ClickHouse stamps a receipt at whole seconds when an insert starts and commits its rows when it finishes, so a delivery stamped in or before the snapshot's second that commits after the first page was read is inside the sequence but missing from the first page; it joins from the next page, where an unlisted visitor it adds or moves ahead of the cursor is skipped and a listed visitor whose winning delivery a lower-hash redelivery moves behind the cursor repeats with revised totals; a listed visitor's totals otherwise stay as listed. A cursor that does not decode, or one from another list, returns 400.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_visitors_search" method="post" path="/api/v1/analytics/projects/{id}/visitors/search" -->
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

    res, err := s.Analytics.Visitors.Search(ctx, "<id>", components.AnalyticsVisitorSearchRequest{
        From: types.MustTimeFromString("2026-09-17T07:00:00Z"),
        To: types.MustTimeFromString("2026-09-18T07:00:00Z"),
        EventName: mka1.Pointer("page_view"),
        Filters: []components.AnalyticsVisitorSearchRequestFilter{
            components.AnalyticsVisitorSearchRequestFilter{
                Property: "plan",
                Op: components.AnalyticsVisitorSearchRequestOpEq,
                Value: optionalnullable.From(mka1.Pointer(components.CreateAnalyticsVisitorSearchRequestValueStr(
                    "pro",
                ))),
            },
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsVisitorSearchResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `id`                                                                                                 | `string`                                                                                             | :heavy_check_mark:                                                                                   | ID of the analytics project.                                                                         |
| `body`                                                                                               | [components.AnalyticsVisitorSearchRequest](../../models/components/analyticsvisitorsearchrequest.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.AnalyticsVisitorsSearchResponse](../../models/operations/analyticsvisitorssearchresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |