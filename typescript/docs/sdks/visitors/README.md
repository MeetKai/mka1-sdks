# Analytics.Visitors

## Overview

List visitors by their latest activity, with first and last seen times.

### Available Operations

* [search](#search) - Search visitors in a time range

## search

List visitors with matching events in a time range, most recently active first. Each visitor is one distinct_id with the timestamps of its first and last matching event and its event count over the whole range, so for a range that receives no further events the number of visitors across all pages equals the unique_visitors query for the same range and filters. The range includes from and excludes to, and duplicate event IDs are counted once. A page holds up to 100 visitors; pass next_cursor as cursor for the following page until it is null. The first page takes a snapshot from ClickHouse's clock before reading its rows and its cursor carries it, so every page of the sequence, the first included, reads only deliveries received at or before that snapshot and ages events out of retention as of it: a visitor keeps the position, first_seen, last_seen and event_count the sequence started with, no visitor repeats or is skipped, and activity received after the snapshot appears only when paging restarts without a cursor. One window blurs that boundary: ClickHouse stamps a receipt at whole seconds when an insert starts and commits its rows when it finishes, so a delivery stamped in or before the snapshot's second that commits after the first page was read is inside the sequence but missing from the first page; it joins from the next page, where an unlisted visitor it adds or moves ahead of the cursor is skipped and a listed visitor whose winning delivery a lower-hash redelivery moves behind the cursor repeats with revised totals; a listed visitor's totals otherwise stay as listed. A cursor that does not decode, or one from another list, returns 400.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="analytics_visitors_search" method="post" path="/api/v1/analytics/projects/{id}/visitors/search" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.analytics.visitors.search({
    id: "<id>",
    analyticsVisitorSearchRequest: {
      from: new Date("2026-09-17T07:00:00Z"),
      to: new Date("2026-09-18T07:00:00Z"),
      eventName: "page_view",
      filters: [
        {
          property: "plan",
          op: "eq",
          value: "pro",
        },
      ],
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
import { analyticsVisitorsSearch } from "@meetkai/mka1/funcs/analyticsVisitorsSearch.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await analyticsVisitorsSearch(sdk, {
    id: "<id>",
    analyticsVisitorSearchRequest: {
      from: new Date("2026-09-17T07:00:00Z"),
      to: new Date("2026-09-18T07:00:00Z"),
      eventName: "page_view",
      filters: [
        {
          property: "plan",
          op: "eq",
          value: "pro",
        },
      ],
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("analyticsVisitorsSearch failed:", res.error);
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
  useAnalyticsVisitorsSearchMutation
} from "@meetkai/mka1/react-query/analyticsVisitorsSearch.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.AnalyticsVisitorsSearchRequest](../../models/operations/analyticsvisitorssearchrequest.md)                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AnalyticsVisitorSearchResponse](../../models/components/analyticsvisitorsearchresponse.md)\>**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.APIError                        | 4XX, 5XX                               | \*/\*                                  |