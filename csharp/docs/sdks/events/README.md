# Analytics.Events

## Overview

List individual events with their properties, newest first.

### Available Operations

* [Search](#search) - Search events in a time range

## Search

List individual events in a time range, newest first, with their properties. Optionally filter by event name, event properties, or one visitor's distinct_id. The range includes from and excludes to, and duplicate event IDs are returned once, so a search over a chart bucket's range with the same filters lists exactly the events that bucket counted. A page holds up to 100 events; pass next_cursor as cursor for the following page until it is null. The first page takes a snapshot from ClickHouse's clock before reading its rows and its cursor carries it, so every page of the sequence, the first included, reads only deliveries received at or before that snapshot and ages events out of retention as of it: no event repeats or is skipped, and events received after the snapshot, including a redelivery that revises a listed event, appear only when paging restarts without a cursor. One window blurs that boundary: ClickHouse stamps a receipt at whole seconds when an insert starts and commits its rows when it finishes, so a delivery stamped in or before the snapshot's second that commits after the first page was read is inside the sequence but missing from the first page; it joins from the next page, where an unlisted event it adds or moves ahead of the cursor is skipped and a listed event that a lower-hash redelivery moves behind the cursor repeats at its revised position. A cursor that does not decode, or one from another list, returns 400. A page whose events exceed the response size limit returns 413; request a smaller limit.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_events_search" method="post" path="/api/v1/analytics/projects/{id}/events/search" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Events.SearchAsync(
    id: "<id>",
    body: new AnalyticsEventSearchRequest() {
        From = System.DateTime.Parse("2026-09-17T07:00:00Z").ToUniversalTime(),
        To = System.DateTime.Parse("2026-09-17T08:00:00Z").ToUniversalTime(),
        EventName = "page_view",
        Filters = new List<AnalyticsEventSearchRequestFilter>() {
            new AnalyticsEventSearchRequestFilter() {
                Property = "plan",
                Op = AnalyticsEventSearchRequestOp.Eq,
                Value = AnalyticsEventSearchRequestValue.CreateStr(
                    "pro"
                ),
            },
        },
        DistinctId = "visitor-123",
    }
);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `Id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | ID of the analytics project.                                                         |
| `Body`                                                                               | [AnalyticsEventSearchRequest](../../Types/Components/AnalyticsEventSearchRequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |

### Response

**[AnalyticsEventsSearchResponse](../../Types/Requests/AnalyticsEventsSearchResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |