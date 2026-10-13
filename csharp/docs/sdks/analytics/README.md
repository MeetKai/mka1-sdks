# Analytics

## Overview

Send events and query event counts or unique visitors.

### Available Operations

* [Capture](#capture) - Durably accept a batch of events
* [Query](#query) - Query event counts or unique visitors

## Capture

Send a batch of events using the project's X-Analytics-Key header. A 202 response confirms the batch is stored; events become available to queries after background processing. Retry with the same idempotency_key and unchanged events if you do not receive a response.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_capture" method="post" path="/api/v1/analytics/capture" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System;
using System.Collections.Generic;

var sdk = new SDK();

var res = await sdk.Analytics.CaptureAsync(
    security: new AnalyticsCaptureSecurity() {
        AnalyticsCaptureKey = "<YOUR_API_KEY_HERE>",
    },
    body: new MeetKai.MKA1.Types.Components.AnalyticsCaptureRequest() {
        IdempotencyKey = "batch-2026-09-01-001",
        Events = new List<AnalyticsEvent>() {
            new AnalyticsEvent() {
                EventId = "14fb0864-445b-4ed6-8d67-02c93538d668",
                EventName = "page_view",
                Timestamp = System.DateTime.Parse("2026-09-01T12:30:00Z").ToUniversalTime(),
                DistinctId = "visitor-123",
                Properties = new Dictionary<string, Properties?>() {
                    { "pathname", Properties.CreateStr(
                        "/pricing"
                    ) },
                    { "plan", Properties.CreateStr(
                        "pro"
                    ) },
                },
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [AnalyticsCaptureSecurity](../../Types/Requests/AnalyticsCaptureSecurity.md)                  | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `Body`                                                                                        | [Types.Components.AnalyticsCaptureRequest](../../Types/Components/AnalyticsCaptureRequest.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `XOnBehalfOf`                                                                                 | *string*                                                                                      | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |

### Response

**[Types.Requests.AnalyticsCaptureResponse](../../Types/Requests/AnalyticsCaptureResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |

## Query

Count events or unique visitors in a time range. Optionally filter by event name or properties, group by one property, and split results into hour, day, or week buckets that start on the clock of an IANA time zone, UTC by default. Each bucket is returned as the UTC instant at which it starts. The range includes from and excludes to. Duplicate event IDs are counted once. An unknown time zone returns 400.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_query" method="post" path="/api/v1/analytics/projects/{id}/query" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.QueryAsync(
    id: "<id>",
    body: new MeetKai.MKA1.Types.Components.AnalyticsQueryRequest() {
        Metric = AnalyticsQueryRequestMetric.UniqueVisitors,
        From = System.DateTime.Parse("2026-09-01T00:00:00Z").ToUniversalTime(),
        To = System.DateTime.Parse("2026-09-02T00:00:00Z").ToUniversalTime(),
        EventName = "page_view",
        Bucket = Bucket.Hour,
        Timezone = "America/Los_Angeles",
        GroupBy = "pathname",
        Filters = new List<AnalyticsQueryRequestFilter>() {
            new AnalyticsQueryRequestFilter() {
                Property = "plan",
                Op = AnalyticsQueryRequestOp.Eq,
                Value = AnalyticsQueryRequestValue.CreateStr(
                    "pro"
                ),
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                              | Type                                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                                            | Example                                                                                                                                                                                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Id`                                                                                                                                                                                                                                                                                   | *string*                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                     | ID of the analytics project.                                                                                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                        |
| `Body`                                                                                                                                                                                                                                                                                 | [Types.Components.AnalyticsQueryRequest](../../Types/Components/AnalyticsQueryRequest.md)                                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                                    | {<br/>"metric": "unique_visitors",<br/>"from": "2026-09-01T00:00:00Z",<br/>"to": "2026-09-02T00:00:00Z",<br/>"event_name": "page_view",<br/>"bucket": "hour",<br/>"timezone": "America/Los_Angeles",<br/>"group_by": "pathname",<br/>"filters": [<br/>{<br/>"property": "plan",<br/>"op": "eq",<br/>"value": "pro"<br/>}<br/>],<br/>"limit": 100<br/>} |

### Response

**[Types.Requests.AnalyticsQueryResponse](../../Types/Requests/AnalyticsQueryResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |