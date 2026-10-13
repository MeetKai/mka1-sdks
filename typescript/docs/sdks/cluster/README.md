# Auth.Cluster

## Overview

### Available Operations

* [createInvite](#createinvite) - Create a cluster invitation
* [listInvites](#listinvites) - List cluster invitations
* [updateInvite](#updateinvite) - Update a pending cluster invitation
* [revokeInvite](#revokeinvite) - Revoke a cluster invitation
* [listOrgs](#listorgs) - List all organizations
* [getOrg](#getorg) - Get an organization
* [deleteOrg](#deleteorg) - Soft-delete an organization
* [inviteOrgMembers](#inviteorgmembers) - Invite members on behalf of an organization
* [suspendOrg](#suspendorg) - Suspend an organization
* [unsuspendOrg](#unsuspendorg) - Unsuspend an organization
* [reissueOwnerKey](#reissueownerkey) - Re-issue an org owner key (recovery)
* [inviteInfo](#inviteinfo) - Read cluster-invite info (public)
* [acceptInvite](#acceptinvite) - Accept a cluster invitation (public)

## createInvite

Issue a one-shot invite that provisions a new org on acceptance. Email-bound invites can be accepted headless (passwordless + issueApiKey).

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createClusterInvite" method="post" path="/api/v1/authentication/admin/cluster/invitations" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.createInvite({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterCreateInvite } from "@meetkai/mka1/funcs/authClusterCreateInvite.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterCreateInvite(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterCreateInvite failed:", res.error);
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
  useAuthClusterCreateInviteMutation
} from "@meetkai/mka1/react-query/authClusterCreateInvite.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateClusterInviteRequest](../../models/operations/createclusterinviterequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateClusterInviteResponseBody](../../models/operations/createclusterinviteresponsebody.md)\>**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| errors.CreateClusterInviteResponseBody                       | 400                                                          | application/json                                             |
| errors.CreateClusterInviteAuthClusterResponseBody            | 401                                                          | application/json                                             |
| errors.CreateClusterInviteAuthClusterResponseResponseBody    | 403                                                          | application/json                                             |
| errors.CreateClusterInviteAuthClusterResponse404ResponseBody | 404                                                          | application/json                                             |
| errors.CreateClusterInviteAuthClusterResponse409ResponseBody | 409                                                          | application/json                                             |
| errors.CreateClusterInviteAuthClusterResponse410ResponseBody | 410                                                          | application/json                                             |
| errors.CreateClusterInviteAuthClusterResponse429ResponseBody | 429                                                          | application/json                                             |
| errors.APIError                                              | 4XX, 5XX                                                     | \*/\*                                                        |

## listInvites

List cluster invitations

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listClusterInvites" method="get" path="/api/v1/authentication/admin/cluster/invitations" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.listInvites({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterListInvites } from "@meetkai/mka1/funcs/authClusterListInvites.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterListInvites(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterListInvites failed:", res.error);
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
  useAuthClusterListInvites,
  useAuthClusterListInvitesSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthClusterListInvites,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthClusterListInvites,
  invalidateAllAuthClusterListInvites,
} from "@meetkai/mka1/react-query/authClusterListInvites.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListClusterInvitesRequest](../../models/operations/listclusterinvitesrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListClusterInvitesResponseBody](../../models/operations/listclusterinvitesresponsebody.md)\>**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| errors.ListClusterInvitesResponseBody                       | 400                                                         | application/json                                            |
| errors.ListClusterInvitesAuthClusterResponseBody            | 401                                                         | application/json                                            |
| errors.ListClusterInvitesAuthClusterResponseResponseBody    | 403                                                         | application/json                                            |
| errors.ListClusterInvitesAuthClusterResponse404ResponseBody | 404                                                         | application/json                                            |
| errors.ListClusterInvitesAuthClusterResponse409ResponseBody | 409                                                         | application/json                                            |
| errors.ListClusterInvitesAuthClusterResponse410ResponseBody | 410                                                         | application/json                                            |
| errors.ListClusterInvitesAuthClusterResponse429ResponseBody | 429                                                         | application/json                                            |
| errors.APIError                                             | 4XX, 5XX                                                    | \*/\*                                                       |

## updateInvite

Extend the expiry or atomically replace the available-model, API-quota, or compute policy of an unclaimed, unexpired invitation. Omitted top-level fields are preserved.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateClusterInvite" method="patch" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.updateInvite({
    id: "<id>",
    requestBody: {},
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterUpdateInvite } from "@meetkai/mka1/funcs/authClusterUpdateInvite.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterUpdateInvite(sdk, {
    id: "<id>",
    requestBody: {},
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterUpdateInvite failed:", res.error);
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
  useAuthClusterUpdateInviteMutation
} from "@meetkai/mka1/react-query/authClusterUpdateInvite.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateClusterInviteRequest](../../models/operations/updateclusterinviterequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UpdateClusterInviteResponseBody](../../models/operations/updateclusterinviteresponsebody.md)\>**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| errors.UpdateClusterInviteResponseBody                       | 400                                                          | application/json                                             |
| errors.UpdateClusterInviteAuthClusterResponseBody            | 401                                                          | application/json                                             |
| errors.UpdateClusterInviteAuthClusterResponseResponseBody    | 403                                                          | application/json                                             |
| errors.UpdateClusterInviteAuthClusterResponse404ResponseBody | 404                                                          | application/json                                             |
| errors.UpdateClusterInviteAuthClusterResponse409ResponseBody | 409                                                          | application/json                                             |
| errors.UpdateClusterInviteAuthClusterResponse410ResponseBody | 410                                                          | application/json                                             |
| errors.UpdateClusterInviteAuthClusterResponse429ResponseBody | 429                                                          | application/json                                             |
| errors.APIError                                              | 4XX, 5XX                                                     | \*/\*                                                        |

## revokeInvite

Revoke a cluster invitation

### Example Usage

<!-- UsageSnippet language="typescript" operationID="revokeClusterInvite" method="delete" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.revokeInvite({
    id: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterRevokeInvite } from "@meetkai/mka1/funcs/authClusterRevokeInvite.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterRevokeInvite(sdk, {
    id: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterRevokeInvite failed:", res.error);
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
  useAuthClusterRevokeInviteMutation
} from "@meetkai/mka1/react-query/authClusterRevokeInvite.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.RevokeClusterInviteRequest](../../models/operations/revokeclusterinviterequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.RevokeClusterInviteResponseBody](../../models/operations/revokeclusterinviteresponsebody.md)\>**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| errors.RevokeClusterInviteResponseBody                       | 400                                                          | application/json                                             |
| errors.RevokeClusterInviteAuthClusterResponseBody            | 401                                                          | application/json                                             |
| errors.RevokeClusterInviteAuthClusterResponseResponseBody    | 403                                                          | application/json                                             |
| errors.RevokeClusterInviteAuthClusterResponse404ResponseBody | 404                                                          | application/json                                             |
| errors.RevokeClusterInviteAuthClusterResponse409ResponseBody | 409                                                          | application/json                                             |
| errors.RevokeClusterInviteAuthClusterResponse410ResponseBody | 410                                                          | application/json                                             |
| errors.RevokeClusterInviteAuthClusterResponse429ResponseBody | 429                                                          | application/json                                             |
| errors.APIError                                              | 4XX, 5XX                                                     | \*/\*                                                        |

## listOrgs

List all organizations

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listClusterOrgs" method="get" path="/api/v1/authentication/admin/cluster/orgs" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.listOrgs({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterListOrgs } from "@meetkai/mka1/funcs/authClusterListOrgs.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterListOrgs(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterListOrgs failed:", res.error);
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
  useAuthClusterListOrgs,
  useAuthClusterListOrgsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthClusterListOrgs,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthClusterListOrgs,
  invalidateAllAuthClusterListOrgs,
} from "@meetkai/mka1/react-query/authClusterListOrgs.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListClusterOrgsRequest](../../models/operations/listclusterorgsrequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListClusterOrgsResponseBody](../../models/operations/listclusterorgsresponsebody.md)\>**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| errors.ListClusterOrgsResponseBody                       | 400                                                      | application/json                                         |
| errors.ListClusterOrgsAuthClusterResponseBody            | 401                                                      | application/json                                         |
| errors.ListClusterOrgsAuthClusterResponseResponseBody    | 403                                                      | application/json                                         |
| errors.ListClusterOrgsAuthClusterResponse404ResponseBody | 404                                                      | application/json                                         |
| errors.ListClusterOrgsAuthClusterResponse409ResponseBody | 409                                                      | application/json                                         |
| errors.ListClusterOrgsAuthClusterResponse410ResponseBody | 410                                                      | application/json                                         |
| errors.ListClusterOrgsAuthClusterResponse429ResponseBody | 429                                                      | application/json                                         |
| errors.APIError                                          | 4XX, 5XX                                                 | \*/\*                                                    |

## getOrg

Get an organization

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getClusterOrg" method="get" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.getOrg({
    id: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterGetOrg } from "@meetkai/mka1/funcs/authClusterGetOrg.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterGetOrg(sdk, {
    id: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterGetOrg failed:", res.error);
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
  useAuthClusterGetOrg,
  useAuthClusterGetOrgSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthClusterGetOrg,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthClusterGetOrg,
  invalidateAllAuthClusterGetOrg,
} from "@meetkai/mka1/react-query/authClusterGetOrg.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetClusterOrgRequest](../../models/operations/getclusterorgrequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetClusterOrgResponseBody](../../models/operations/getclusterorgresponsebody.md)\>**

### Errors

| Error Type                                             | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| errors.GetClusterOrgResponseBody                       | 400                                                    | application/json                                       |
| errors.GetClusterOrgAuthClusterResponseBody            | 401                                                    | application/json                                       |
| errors.GetClusterOrgAuthClusterResponseResponseBody    | 403                                                    | application/json                                       |
| errors.GetClusterOrgAuthClusterResponse404ResponseBody | 404                                                    | application/json                                       |
| errors.GetClusterOrgAuthClusterResponse409ResponseBody | 409                                                    | application/json                                       |
| errors.GetClusterOrgAuthClusterResponse410ResponseBody | 410                                                    | application/json                                       |
| errors.GetClusterOrgAuthClusterResponse429ResponseBody | 429                                                    | application/json                                       |
| errors.APIError                                        | 4XX, 5XX                                               | \*/\*                                                  |

## deleteOrg

Soft-delete an organization

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteClusterOrg" method="delete" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.deleteOrg({
    id: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterDeleteOrg } from "@meetkai/mka1/funcs/authClusterDeleteOrg.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterDeleteOrg(sdk, {
    id: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterDeleteOrg failed:", res.error);
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
  useAuthClusterDeleteOrgMutation
} from "@meetkai/mka1/react-query/authClusterDeleteOrg.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteClusterOrgRequest](../../models/operations/deleteclusterorgrequest.md)                                                                                       | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.DeleteClusterOrgResponseBody](../../models/operations/deleteclusterorgresponsebody.md)\>**

### Errors

| Error Type                                                | Status Code                                               | Content Type                                              |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| errors.DeleteClusterOrgResponseBody                       | 400                                                       | application/json                                          |
| errors.DeleteClusterOrgAuthClusterResponseBody            | 401                                                       | application/json                                          |
| errors.DeleteClusterOrgAuthClusterResponseResponseBody    | 403                                                       | application/json                                          |
| errors.DeleteClusterOrgAuthClusterResponse404ResponseBody | 404                                                       | application/json                                          |
| errors.DeleteClusterOrgAuthClusterResponse409ResponseBody | 409                                                       | application/json                                          |
| errors.DeleteClusterOrgAuthClusterResponse410ResponseBody | 410                                                       | application/json                                          |
| errors.DeleteClusterOrgAuthClusterResponse429ResponseBody | 429                                                       | application/json                                          |
| errors.APIError                                           | 4XX, 5XX                                                  | \*/\*                                                     |

## inviteOrgMembers

Requires a cluster-admin session with Cluster as its active organization. The target must be active and cannot be Cluster. Sends up to 20 organization invitations without switching the admin's session or joining the target organization. Each row accepts role member or admin, defaulting to member; owner and custom roles are not supported. New invitations include the target's oldest team when one exists. Results follow input order; invalid emails, duplicates, existing members, pending invitations, and delivery failures are reported per row. An existing pending invitation must match the requested role, including when resend is false. An explicit resend reuses a matching pending invitation with no team or the target's oldest team, preserving its inviter, role, and team. Invitation expiry is 48 hours; at most 100 unexpired pending invitations are allowed per organization. API keys are not supported.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="inviteClusterOrgMembers" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/invitations" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.auth.cluster.inviteOrgMembers({
    sessionCookie: "<YOUR_API_KEY_HERE>",
  }, {
    id: "<id>",
    requestBody: {
      invitations: [
        {
          email: "Aurelio1@yahoo.com",
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
import { authClusterInviteOrgMembers } from "@meetkai/mka1/funcs/authClusterInviteOrgMembers.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore();

async function run() {
  const res = await authClusterInviteOrgMembers(sdk, {
    sessionCookie: "<YOUR_API_KEY_HERE>",
  }, {
    id: "<id>",
    requestBody: {
      invitations: [
        {
          email: "Aurelio1@yahoo.com",
        },
      ],
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterInviteOrgMembers failed:", res.error);
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
  useAuthClusterInviteOrgMembersMutation
} from "@meetkai/mka1/react-query/authClusterInviteOrgMembers.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.InviteClusterOrgMembersRequest](../../models/operations/inviteclusterorgmembersrequest.md)                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `security`                                                                                                                                                                     | [operations.InviteClusterOrgMembersSecurity](../../models/operations/inviteclusterorgmemberssecurity.md)                                                                       | :heavy_check_mark:                                                                                                                                                             | The security requirements to use for the request.                                                                                                                              |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.InviteClusterOrgMembersResponseBody](../../models/operations/inviteclusterorgmembersresponsebody.md)\>**

### Errors

| Error Type                                                       | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| errors.InviteClusterOrgMembersResponseBody                       | 400                                                              | application/json                                                 |
| errors.InviteClusterOrgMembersAuthClusterResponseBody            | 401                                                              | application/json                                                 |
| errors.InviteClusterOrgMembersAuthClusterResponseResponseBody    | 403                                                              | application/json                                                 |
| errors.InviteClusterOrgMembersAuthClusterResponse404ResponseBody | 404                                                              | application/json                                                 |
| errors.InviteClusterOrgMembersAuthClusterResponse409ResponseBody | 409                                                              | application/json                                                 |
| errors.InviteClusterOrgMembersAuthClusterResponse410ResponseBody | 410                                                              | application/json                                                 |
| errors.InviteClusterOrgMembersAuthClusterResponse429ResponseBody | 429                                                              | application/json                                                 |
| errors.APIError                                                  | 4XX, 5XX                                                         | \*/\*                                                            |

## suspendOrg

Suspend an organization

### Example Usage

<!-- UsageSnippet language="typescript" operationID="suspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/suspend" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.suspendOrg({
    id: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterSuspendOrg } from "@meetkai/mka1/funcs/authClusterSuspendOrg.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterSuspendOrg(sdk, {
    id: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterSuspendOrg failed:", res.error);
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
  useAuthClusterSuspendOrgMutation
} from "@meetkai/mka1/react-query/authClusterSuspendOrg.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.SuspendClusterOrgRequest](../../models/operations/suspendclusterorgrequest.md)                                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.SuspendClusterOrgResponseBody](../../models/operations/suspendclusterorgresponsebody.md)\>**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| errors.SuspendClusterOrgResponseBody                       | 400                                                        | application/json                                           |
| errors.SuspendClusterOrgAuthClusterResponseBody            | 401                                                        | application/json                                           |
| errors.SuspendClusterOrgAuthClusterResponseResponseBody    | 403                                                        | application/json                                           |
| errors.SuspendClusterOrgAuthClusterResponse404ResponseBody | 404                                                        | application/json                                           |
| errors.SuspendClusterOrgAuthClusterResponse409ResponseBody | 409                                                        | application/json                                           |
| errors.SuspendClusterOrgAuthClusterResponse410ResponseBody | 410                                                        | application/json                                           |
| errors.SuspendClusterOrgAuthClusterResponse429ResponseBody | 429                                                        | application/json                                           |
| errors.APIError                                            | 4XX, 5XX                                                   | \*/\*                                                      |

## unsuspendOrg

Unsuspend an organization

### Example Usage

<!-- UsageSnippet language="typescript" operationID="unsuspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/unsuspend" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.unsuspendOrg({
    id: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterUnsuspendOrg } from "@meetkai/mka1/funcs/authClusterUnsuspendOrg.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterUnsuspendOrg(sdk, {
    id: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterUnsuspendOrg failed:", res.error);
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
  useAuthClusterUnsuspendOrgMutation
} from "@meetkai/mka1/react-query/authClusterUnsuspendOrg.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UnsuspendClusterOrgRequest](../../models/operations/unsuspendclusterorgrequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UnsuspendClusterOrgResponseBody](../../models/operations/unsuspendclusterorgresponsebody.md)\>**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| errors.UnsuspendClusterOrgResponseBody                       | 400                                                          | application/json                                             |
| errors.UnsuspendClusterOrgAuthClusterResponseBody            | 401                                                          | application/json                                             |
| errors.UnsuspendClusterOrgAuthClusterResponseResponseBody    | 403                                                          | application/json                                             |
| errors.UnsuspendClusterOrgAuthClusterResponse404ResponseBody | 404                                                          | application/json                                             |
| errors.UnsuspendClusterOrgAuthClusterResponse409ResponseBody | 409                                                          | application/json                                             |
| errors.UnsuspendClusterOrgAuthClusterResponse410ResponseBody | 410                                                          | application/json                                             |
| errors.UnsuspendClusterOrgAuthClusterResponse429ResponseBody | 429                                                          | application/json                                             |
| errors.APIError                                              | 4XX, 5XX                                                     | \*/\*                                                        |

## reissueOwnerKey

Mint a fresh owner-bound key for an org whose credential was lost. Cluster-admin only (`write:cluster`). Defaults to the org's oldest human owner and oldest team; `userId` / `teamId` override.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="reissueOwnerKey" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/owner-key" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.reissueOwnerKey({
    id: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterReissueOwnerKey } from "@meetkai/mka1/funcs/authClusterReissueOwnerKey.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterReissueOwnerKey(sdk, {
    id: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterReissueOwnerKey failed:", res.error);
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
  useAuthClusterReissueOwnerKeyMutation
} from "@meetkai/mka1/react-query/authClusterReissueOwnerKey.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ReissueOwnerKeyRequest](../../models/operations/reissueownerkeyrequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ReissueOwnerKeyResponseBody](../../models/operations/reissueownerkeyresponsebody.md)\>**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| errors.ReissueOwnerKeyResponseBody                       | 400                                                      | application/json                                         |
| errors.ReissueOwnerKeyAuthClusterResponseBody            | 401                                                      | application/json                                         |
| errors.ReissueOwnerKeyAuthClusterResponseResponseBody    | 403                                                      | application/json                                         |
| errors.ReissueOwnerKeyAuthClusterResponse404ResponseBody | 404                                                      | application/json                                         |
| errors.ReissueOwnerKeyAuthClusterResponse409ResponseBody | 409                                                      | application/json                                         |
| errors.ReissueOwnerKeyAuthClusterResponse410ResponseBody | 410                                                      | application/json                                         |
| errors.ReissueOwnerKeyAuthClusterResponse429ResponseBody | 429                                                      | application/json                                         |
| errors.APIError                                          | 4XX, 5XX                                                 | \*/\*                                                    |

## inviteInfo

Read cluster-invite info (public)

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getClusterInviteInfo" method="get" path="/api/v1/authentication/cluster-invite/info" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.inviteInfo({
    token: "<value>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterInviteInfo } from "@meetkai/mka1/funcs/authClusterInviteInfo.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterInviteInfo(sdk, {
    token: "<value>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterInviteInfo failed:", res.error);
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
  useAuthClusterInviteInfo,
  useAuthClusterInviteInfoSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthClusterInviteInfo,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthClusterInviteInfo,
  invalidateAllAuthClusterInviteInfo,
} from "@meetkai/mka1/react-query/authClusterInviteInfo.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetClusterInviteInfoRequest](../../models/operations/getclusterinviteinforequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetClusterInviteInfoResponseBody](../../models/operations/getclusterinviteinforesponsebody.md)\>**

### Errors

| Error Type                                                    | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| errors.GetClusterInviteInfoResponseBody                       | 400                                                           | application/json                                              |
| errors.GetClusterInviteInfoAuthClusterResponseBody            | 401                                                           | application/json                                              |
| errors.GetClusterInviteInfoAuthClusterResponseResponseBody    | 403                                                           | application/json                                              |
| errors.GetClusterInviteInfoAuthClusterResponse404ResponseBody | 404                                                           | application/json                                              |
| errors.GetClusterInviteInfoAuthClusterResponse409ResponseBody | 409                                                           | application/json                                              |
| errors.GetClusterInviteInfoAuthClusterResponse410ResponseBody | 410                                                           | application/json                                              |
| errors.GetClusterInviteInfoAuthClusterResponse429ResponseBody | 429                                                           | application/json                                              |
| errors.APIError                                               | 4XX, 5XX                                                      | \*/\*                                                         |

## acceptInvite

Accept an invite and create the org. Existing signed-in user, new email/password owner, or (email-bound) headless machine owner with `passwordless: true, issueApiKey: true`. A reserved slug (`api`, whether supplied as `orgSlug` or derived from `orgName`) is refused with 400 `reserved_org_slug`; a slug another org already holds is refused with 409. Note `POST /organization/check-slug` does not know about reserved slugs and will report `api` as available.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="acceptClusterInvite" method="post" path="/api/v1/authentication/cluster-invite/accept" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.cluster.acceptInvite({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authClusterAcceptInvite } from "@meetkai/mka1/funcs/authClusterAcceptInvite.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authClusterAcceptInvite(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authClusterAcceptInvite failed:", res.error);
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
  useAuthClusterAcceptInviteMutation
} from "@meetkai/mka1/react-query/authClusterAcceptInvite.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.AcceptClusterInviteRequest](../../models/operations/acceptclusterinviterequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.AcceptClusterInviteResponseBody](../../models/operations/acceptclusterinviteresponsebody.md)\>**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| errors.AcceptClusterInviteResponseBody                       | 400                                                          | application/json                                             |
| errors.AcceptClusterInviteAuthClusterResponseBody            | 401                                                          | application/json                                             |
| errors.AcceptClusterInviteAuthClusterResponseResponseBody    | 403                                                          | application/json                                             |
| errors.AcceptClusterInviteAuthClusterResponse404ResponseBody | 404                                                          | application/json                                             |
| errors.AcceptClusterInviteAuthClusterResponse409ResponseBody | 409                                                          | application/json                                             |
| errors.AcceptClusterInviteAuthClusterResponse410ResponseBody | 410                                                          | application/json                                             |
| errors.AcceptClusterInviteAuthClusterResponse429ResponseBody | 429                                                          | application/json                                             |
| errors.AcceptClusterInviteAuthClusterResponse503ResponseBody | 503                                                          | application/json                                             |
| errors.APIError                                              | 4XX, 5XX                                                     | \*/\*                                                        |