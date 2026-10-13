# Usage

## Overview

### Available Operations

* [sandbox](#sandbox) - Get Sandbox Usage
* [costs](#costs) - Aggregate cost by dimension

## sandbox

Aggregate sandbox usage (session lifecycle, execution, and workspace operations) over a time range, bucketed and optionally grouped. Buckets are calendar-aligned in UTC: `start_time` is snapped down and `end_time` snapped up to the nearest bucket-width boundary, so the first and last buckets may extend slightly beyond the requested range. Org-scoped: callers see their own usage, org admins their team's; cluster admins may pass `all_orgs` or `org_ids`. Cost and spend reporting lives in the budgeting API (`/api/v1/budgeting/usage/costs`).

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getSandboxUsage" method="get" path="/api/v1/sandbox/usage" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.usage.sandbox({
    startTime: 311532,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { usageSandbox } from "@meetkai/mka1/funcs/usageSandbox.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await usageSandbox(sdk, {
    startTime: 311532,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("usageSandbox failed:", res.error);
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
  // Query hooks for fetching data.
  useUsageSandbox,
  useUsageSandboxSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchUsageSandbox,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateUsageSandbox,
  invalidateAllUsageSandbox,
} from "@meetkai/mka1/react-query/usageSandbox.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetSandboxUsageRequest](../../models/operations/getsandboxusagerequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.SandboxUsagePage](../../models/components/sandboxusagepage.md)\>**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.APIError            | 4XX, 5XX                   | \*/\*                      |

## costs

Sums stored per-entry cost over [start_time, end_time), grouped by any of service, task_type, model, api_key_id, team_id, user_id, external_user_id, org_id. Point-in-time correct for chargeback/showback.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getCosts" method="get" path="/api/v1/budgeting/usage/costs" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.usage.costs({
    startTime: 624757,
    endTime: 189930,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { usageCosts } from "@meetkai/mka1/funcs/usageCosts.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await usageCosts(sdk, {
    startTime: 624757,
    endTime: 189930,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("usageCosts failed:", res.error);
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
  // Query hooks for fetching data.
  useUsageCosts,
  useUsageCostsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchUsageCosts,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateUsageCosts,
  invalidateAllUsageCosts,
} from "@meetkai/mka1/react-query/usageCosts.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetCostsRequest](../../models/operations/getcostsrequest.md)                                                                                                       | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetCostsResponseBody](../../models/operations/getcostsresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |