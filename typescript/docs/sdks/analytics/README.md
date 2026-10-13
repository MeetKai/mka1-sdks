# Analytics

## Overview

Send events and query event counts or unique visitors.

### Available Operations

* [capture](#capture) - Durably accept a batch of events
* [query](#query) - Query event counts or unique visitors

## capture

Send a batch of events using the project's X-Analytics-Key header. A 202 response confirms the batch is stored; events become available to queries after background processing. Retry with the same idempotency_key and unchanged events if you do not receive a response.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="analytics_capture" method="post" path="/api/v1/analytics/capture" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.analytics.capture({
    analyticsCaptureKey: "<YOUR_API_KEY_HERE>",
  }, {
    analyticsCaptureRequest: {
      idempotencyKey: "batch-2026-09-01-001",
      events: [
        {
          eventId: "14fb0864-445b-4ed6-8d67-02c93538d668",
          eventName: "page_view",
          timestamp: new Date("2026-09-01T12:30:00Z"),
          distinctId: "visitor-123",
          properties: {
            "pathname": "/pricing",
            "plan": "pro",
          },
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
import { analyticsCapture } from "@meetkai/mka1/funcs/analyticsCapture.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore();

async function run() {
  const res = await analyticsCapture(sdk, {
    analyticsCaptureKey: "<YOUR_API_KEY_HERE>",
  }, {
    analyticsCaptureRequest: {
      idempotencyKey: "batch-2026-09-01-001",
      events: [
        {
          eventId: "14fb0864-445b-4ed6-8d67-02c93538d668",
          eventName: "page_view",
          timestamp: new Date("2026-09-01T12:30:00Z"),
          distinctId: "visitor-123",
          properties: {
            "pathname": "/pricing",
            "plan": "pro",
          },
        },
      ],
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("analyticsCapture failed:", res.error);
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
  useAnalyticsCaptureMutation
} from "@meetkai/mka1/react-query/analyticsCapture.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.AnalyticsCaptureRequest](../../models/operations/analyticscapturerequest.md)                                                                                       | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `security`                                                                                                                                                                     | [operations.AnalyticsCaptureSecurity](../../models/operations/analyticscapturesecurity.md)                                                                                     | :heavy_check_mark:                                                                                                                                                             | The security requirements to use for the request.                                                                                                                              |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AnalyticsCaptureResponse](../../models/components/analyticscaptureresponse.md)\>**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.APIError                        | 4XX, 5XX                               | \*/\*                                  |

## query

Count events or unique visitors in a time range. Optionally filter by event name or properties, group by one property, and split results into hour, day, or week buckets that start on the clock of an IANA time zone, UTC by default. Each bucket is returned as the UTC instant at which it starts. The range includes from and excludes to. Duplicate event IDs are counted once. An unknown time zone returns 400.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="analytics_query" method="post" path="/api/v1/analytics/projects/{id}/query" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.analytics.query({
    id: "<id>",
    analyticsQueryRequest: {
      metric: "unique_visitors",
      from: new Date("2026-09-01T00:00:00Z"),
      to: new Date("2026-09-02T00:00:00Z"),
      eventName: "page_view",
      bucket: "hour",
      timezone: "America/Los_Angeles",
      groupBy: "pathname",
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
import { analyticsQuery } from "@meetkai/mka1/funcs/analyticsQuery.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await analyticsQuery(sdk, {
    id: "<id>",
    analyticsQueryRequest: {
      metric: "unique_visitors",
      from: new Date("2026-09-01T00:00:00Z"),
      to: new Date("2026-09-02T00:00:00Z"),
      eventName: "page_view",
      bucket: "hour",
      timezone: "America/Los_Angeles",
      groupBy: "pathname",
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
    console.log("analyticsQuery failed:", res.error);
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
  useAnalyticsQueryMutation
} from "@meetkai/mka1/react-query/analyticsQuery.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.AnalyticsQueryRequest](../../models/operations/analyticsqueryrequest.md)                                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AnalyticsQueryResponse](../../models/components/analyticsqueryresponse.md)\>**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.APIError                        | 4XX, 5XX                               | \*/\*                                  |