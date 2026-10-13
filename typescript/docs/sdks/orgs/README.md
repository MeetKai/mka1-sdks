# Auth.Orgs

## Overview

### Available Operations

* [getById](#getbyid) - Get basic organization details
* [update](#update) - Patch organization metadata (cluster-admin)
* [getQuota](#getquota) - Get an org's usage quota
* [updateQuota](#updatequota) - Set an org's usage quota (cluster-admin)
* [getRateLimit](#getratelimit) - Get an org's rate limit
* [updateRateLimit](#updateratelimit) - Set an org's rate limit (cluster-admin)

## getById

Returns basic fields and the full metadata object to a member of the organization or a cluster admin. It never includes member identities, invitations, or API-key details.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getOrgById" method="get" path="/api/v1/authentication/orgs/{orgId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.auth.orgs.getById({
    bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
  }, {
    orgId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authOrgsGetById } from "@meetkai/mka1/funcs/authOrgsGetById.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore();

async function run() {
  const res = await authOrgsGetById(sdk, {
    bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
  }, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authOrgsGetById failed:", res.error);
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
  useAuthOrgsGetById,
  useAuthOrgsGetByIdSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthOrgsGetById,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthOrgsGetById,
  invalidateAllAuthOrgsGetById,
} from "@meetkai/mka1/react-query/authOrgsGetById.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetOrgByIdRequest](../../models/operations/getorgbyidrequest.md)                                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `security`                                                                                                                                                                     | [operations.GetOrgByIdSecurity](../../models/operations/getorgbyidsecurity.md)                                                                                                 | :heavy_check_mark:                                                                                                                                                             | The security requirements to use for the request.                                                                                                                              |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.BasicOrganization](../../models/components/basicorganization.md)\>**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| errors.GetOrgByIdResponseBody                    | 400                                              | application/json                                 |
| errors.GetOrgByIdAuthOrgsResponseBody            | 401                                              | application/json                                 |
| errors.GetOrgByIdAuthOrgsResponseResponseBody    | 403                                              | application/json                                 |
| errors.GetOrgByIdAuthOrgsResponse404ResponseBody | 404                                              | application/json                                 |
| errors.GetOrgByIdAuthOrgsResponse409ResponseBody | 409                                              | application/json                                 |
| errors.GetOrgByIdAuthOrgsResponse410ResponseBody | 410                                              | application/json                                 |
| errors.GetOrgByIdAuthOrgsResponse429ResponseBody | 429                                              | application/json                                 |
| errors.GetOrgByIdAuthOrgsResponse500ResponseBody | 500                                              | application/json                                 |
| errors.APIError                                  | 4XX, 5XX                                         | \*/\*                                            |

## update

Merges supplied top-level metadata keys while preserving omitted siblings. metadata.codeConfig accepts one releaseManifestUrl; codeConfig:null removes that override.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateOrganization" method="patch" path="/api/v1/authentication/orgs/{orgId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.auth.orgs.update({
    bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
  }, {
    orgId: "<id>",
    updateOrganizationBody: {
      metadata: {},
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
import { authOrgsUpdate } from "@meetkai/mka1/funcs/authOrgsUpdate.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore();

async function run() {
  const res = await authOrgsUpdate(sdk, {
    bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
  }, {
    orgId: "<id>",
    updateOrganizationBody: {
      metadata: {},
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authOrgsUpdate failed:", res.error);
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
  useAuthOrgsUpdateMutation
} from "@meetkai/mka1/react-query/authOrgsUpdate.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateOrganizationRequest](../../models/operations/updateorganizationrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `security`                                                                                                                                                                     | [operations.UpdateOrganizationSecurity](../../models/operations/updateorganizationsecurity.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The security requirements to use for the request.                                                                                                                              |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.BasicOrganization](../../models/components/basicorganization.md)\>**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| errors.UpdateOrganizationResponseBody                    | 400                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponseBody            | 401                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponseResponseBody    | 403                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponse404ResponseBody | 404                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponse409ResponseBody | 409                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponse410ResponseBody | 410                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponse413ResponseBody | 413                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponse429ResponseBody | 429                                                      | application/json                                         |
| errors.UpdateOrganizationAuthOrgsResponse500ResponseBody | 500                                                      | application/json                                         |
| errors.APIError                                          | 4XX, 5XX                                                 | \*/\*                                                    |

## getQuota

Get an org's usage quota

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getOrgQuota" method="get" path="/api/v1/authentication/orgs/{orgId}/quota" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.orgs.getQuota({
    orgId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authOrgsGetQuota } from "@meetkai/mka1/funcs/authOrgsGetQuota.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authOrgsGetQuota(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authOrgsGetQuota failed:", res.error);
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
  useAuthOrgsGetQuota,
  useAuthOrgsGetQuotaSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthOrgsGetQuota,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthOrgsGetQuota,
  invalidateAllAuthOrgsGetQuota,
} from "@meetkai/mka1/react-query/authOrgsGetQuota.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetOrgQuotaRequest](../../models/operations/getorgquotarequest.md)                                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetOrgQuotaResponseBody](../../models/operations/getorgquotaresponsebody.md)\>**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| errors.GetOrgQuotaResponseBody                    | 400                                               | application/json                                  |
| errors.GetOrgQuotaAuthOrgsResponseBody            | 401                                               | application/json                                  |
| errors.GetOrgQuotaAuthOrgsResponseResponseBody    | 403                                               | application/json                                  |
| errors.GetOrgQuotaAuthOrgsResponse404ResponseBody | 404                                               | application/json                                  |
| errors.GetOrgQuotaAuthOrgsResponse409ResponseBody | 409                                               | application/json                                  |
| errors.GetOrgQuotaAuthOrgsResponse410ResponseBody | 410                                               | application/json                                  |
| errors.GetOrgQuotaAuthOrgsResponse429ResponseBody | 429                                               | application/json                                  |
| errors.APIError                                   | 4XX, 5XX                                          | \*/\*                                             |

## updateQuota

Set an org's usage quota (cluster-admin)

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateOrgQuota" method="patch" path="/api/v1/authentication/orgs/{orgId}/quota" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.orgs.updateQuota({
    orgId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authOrgsUpdateQuota } from "@meetkai/mka1/funcs/authOrgsUpdateQuota.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authOrgsUpdateQuota(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authOrgsUpdateQuota failed:", res.error);
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
  useAuthOrgsUpdateQuotaMutation
} from "@meetkai/mka1/react-query/authOrgsUpdateQuota.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateOrgQuotaRequest](../../models/operations/updateorgquotarequest.md)                                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UpdateOrgQuotaResponseBody](../../models/operations/updateorgquotaresponsebody.md)\>**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| errors.UpdateOrgQuotaResponseBody                    | 400                                                  | application/json                                     |
| errors.UpdateOrgQuotaAuthOrgsResponseBody            | 401                                                  | application/json                                     |
| errors.UpdateOrgQuotaAuthOrgsResponseResponseBody    | 403                                                  | application/json                                     |
| errors.UpdateOrgQuotaAuthOrgsResponse404ResponseBody | 404                                                  | application/json                                     |
| errors.UpdateOrgQuotaAuthOrgsResponse409ResponseBody | 409                                                  | application/json                                     |
| errors.UpdateOrgQuotaAuthOrgsResponse410ResponseBody | 410                                                  | application/json                                     |
| errors.UpdateOrgQuotaAuthOrgsResponse429ResponseBody | 429                                                  | application/json                                     |
| errors.APIError                                      | 4XX, 5XX                                             | \*/\*                                                |

## getRateLimit

Get an org's rate limit

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getOrgRateLimit" method="get" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.orgs.getRateLimit({
    orgId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authOrgsGetRateLimit } from "@meetkai/mka1/funcs/authOrgsGetRateLimit.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authOrgsGetRateLimit(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authOrgsGetRateLimit failed:", res.error);
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
  useAuthOrgsGetRateLimit,
  useAuthOrgsGetRateLimitSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthOrgsGetRateLimit,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthOrgsGetRateLimit,
  invalidateAllAuthOrgsGetRateLimit,
} from "@meetkai/mka1/react-query/authOrgsGetRateLimit.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetOrgRateLimitRequest](../../models/operations/getorgratelimitrequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetOrgRateLimitResponseBody](../../models/operations/getorgratelimitresponsebody.md)\>**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| errors.GetOrgRateLimitResponseBody                    | 400                                                   | application/json                                      |
| errors.GetOrgRateLimitAuthOrgsResponseBody            | 401                                                   | application/json                                      |
| errors.GetOrgRateLimitAuthOrgsResponseResponseBody    | 403                                                   | application/json                                      |
| errors.GetOrgRateLimitAuthOrgsResponse404ResponseBody | 404                                                   | application/json                                      |
| errors.GetOrgRateLimitAuthOrgsResponse409ResponseBody | 409                                                   | application/json                                      |
| errors.GetOrgRateLimitAuthOrgsResponse410ResponseBody | 410                                                   | application/json                                      |
| errors.GetOrgRateLimitAuthOrgsResponse429ResponseBody | 429                                                   | application/json                                      |
| errors.APIError                                       | 4XX, 5XX                                              | \*/\*                                                 |

## updateRateLimit

Set an org's rate limit (cluster-admin)

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateOrgRateLimit" method="patch" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.orgs.updateRateLimit({
    orgId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authOrgsUpdateRateLimit } from "@meetkai/mka1/funcs/authOrgsUpdateRateLimit.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authOrgsUpdateRateLimit(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authOrgsUpdateRateLimit failed:", res.error);
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
  useAuthOrgsUpdateRateLimitMutation
} from "@meetkai/mka1/react-query/authOrgsUpdateRateLimit.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateOrgRateLimitRequest](../../models/operations/updateorgratelimitrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UpdateOrgRateLimitResponseBody](../../models/operations/updateorgratelimitresponsebody.md)\>**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| errors.UpdateOrgRateLimitResponseBody                    | 400                                                      | application/json                                         |
| errors.UpdateOrgRateLimitAuthOrgsResponseBody            | 401                                                      | application/json                                         |
| errors.UpdateOrgRateLimitAuthOrgsResponseResponseBody    | 403                                                      | application/json                                         |
| errors.UpdateOrgRateLimitAuthOrgsResponse404ResponseBody | 404                                                      | application/json                                         |
| errors.UpdateOrgRateLimitAuthOrgsResponse409ResponseBody | 409                                                      | application/json                                         |
| errors.UpdateOrgRateLimitAuthOrgsResponse410ResponseBody | 410                                                      | application/json                                         |
| errors.UpdateOrgRateLimitAuthOrgsResponse429ResponseBody | 429                                                      | application/json                                         |
| errors.APIError                                          | 4XX, 5XX                                                 | \*/\*                                                    |