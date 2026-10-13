# Analytics.Events

## Overview

List individual events with their properties, newest first.

### Available Operations

* [search](#search) - Search events in a time range

## search

List individual events in a time range, newest first, with their properties. Optionally filter by event name, event properties, or one visitor's distinct_id. The range includes from and excludes to, and duplicate event IDs are returned once, so a search over a chart bucket's range with the same filters lists exactly the events that bucket counted. A page holds up to 100 events; pass next_cursor as cursor for the following page until it is null. The first page takes a snapshot from ClickHouse's clock before reading its rows and its cursor carries it, so every page of the sequence, the first included, reads only deliveries received at or before that snapshot and ages events out of retention as of it: no event repeats or is skipped, and events received after the snapshot, including a redelivery that revises a listed event, appear only when paging restarts without a cursor. One window blurs that boundary: ClickHouse stamps a receipt at whole seconds when an insert starts and commits its rows when it finishes, so a delivery stamped in or before the snapshot's second that commits after the first page was read is inside the sequence but missing from the first page; it joins from the next page, where an unlisted event it adds or moves ahead of the cursor is skipped and a listed event that a lower-hash redelivery moves behind the cursor repeats at its revised position. A cursor that does not decode, or one from another list, returns 400. A page whose events exceed the response size limit returns 413; request a smaller limit.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="analytics_events_search" method="post" path="/api/v1/analytics/projects/{id}/events/search" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.analytics.events.search({
    id: "<id>",
    analyticsEventSearchRequest: {
      from: new Date("2026-09-17T07:00:00Z"),
      to: new Date("2026-09-17T08:00:00Z"),
      eventName: "page_view",
      filters: [
        {
          property: "plan",
          op: "eq",
          value: "pro",
        },
      ],
      distinctId: "visitor-123",
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { analyticsEventsSearch } from "@meetkai/mka1/funcs/analyticsEventsSearch.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await analyticsEventsSearch(sdk, {
    id: "<id>",
    analyticsEventSearchRequest: {
      from: new Date("2026-09-17T07:00:00Z"),
      to: new Date("2026-09-17T08:00:00Z"),
      eventName: "page_view",
      filters: [
        {
          property: "plan",
          op: "eq",
          value: "pro",
        },
      ],
      distinctId: "visitor-123",
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("analyticsEventsSearch failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useAnalyticsEventsSearchMutation
} from "@meetkai/mka1/react-query/analyticsEventsSearch.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.AnalyticsEventsSearchRequest](../../models/operations/analyticseventssearchrequest.md)                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AnalyticsEventSearchResponse](../../models/components/analyticseventsearchresponse.md)\>**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.APIError                        | 4XX, 5XX                               | \*/\*                                  |