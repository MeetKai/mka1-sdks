# Analytics.Visitors

## Overview

List visitors by their latest activity, with first and last seen times.

### Available Operations

* [Search](#search) - Search visitors in a time range

## Search

List visitors with matching events in a time range, most recently active first. Each visitor is one distinct_id with the timestamps of its first and last matching event and its event count over the whole range, so for a range that receives no further events the number of visitors across all pages equals the unique_visitors query for the same range and filters. The range includes from and excludes to, and duplicate event IDs are counted once. A page holds up to 100 visitors; pass next_cursor as cursor for the following page until it is null. The first page takes a snapshot from ClickHouse's clock before reading its rows and its cursor carries it, so every page of the sequence, the first included, reads only deliveries received at or before that snapshot and ages events out of retention as of it: a visitor keeps the position, first_seen, last_seen and event_count the sequence started with, no visitor repeats or is skipped, and activity received after the snapshot appears only when paging restarts without a cursor. One window blurs that boundary: ClickHouse stamps a receipt at whole seconds when an insert starts and commits its rows when it finishes, so a delivery stamped in or before the snapshot's second that commits after the first page was read is inside the sequence but missing from the first page; it joins from the next page, where an unlisted visitor it adds or moves ahead of the cursor is skipped and a listed visitor whose winning delivery a lower-hash redelivery moves behind the cursor repeats with revised totals; a listed visitor's totals otherwise stay as listed. A cursor that does not decode, or one from another list, returns 400.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_visitors_search" method="post" path="/api/v1/analytics/projects/{id}/visitors/search" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Visitors.SearchAsync(
    id: "<id>",
    body: new AnalyticsVisitorSearchRequest() {
        From = System.DateTime.Parse("2026-09-17T07:00:00Z").ToUniversalTime(),
        To = System.DateTime.Parse("2026-09-18T07:00:00Z").ToUniversalTime(),
        EventName = "page_view",
        Filters = new List<AnalyticsVisitorSearchRequestFilter>() {
            new AnalyticsVisitorSearchRequestFilter() {
                Property = "plan",
                Op = AnalyticsVisitorSearchRequestOp.Eq,
                Value = AnalyticsVisitorSearchRequestValue.CreateStr(
                    "pro"
                ),
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the analytics project.                                                             |
| `Body`                                                                                   | [AnalyticsVisitorSearchRequest](../../Types/Components/AnalyticsVisitorSearchRequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |

### Response

**[AnalyticsVisitorsSearchResponse](../../Types/Requests/AnalyticsVisitorsSearchResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |