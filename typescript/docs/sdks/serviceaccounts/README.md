# Auth.ServiceAccounts

## Overview

### Available Operations

* [create](#create) - Create a service account
* [list](#list) - List service accounts
* [get](#get) - Get a service account
* [delete](#delete) - Delete a service account
* [listApiKeys](#listapikeys) - List a service account's API keys
* [updateApiKey](#updateapikey) - Update a service-account API key
* [deleteApiKey](#deleteapikey) - Delete a service-account API key
* [regenerateApiKey](#regenerateapikey) - Rotate a service-account API key's secret

## create

Mint a non-human principal scoped to this org (org owner/admin only).

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createServiceAccount" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.create({
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
import { authServiceAccountsCreate } from "@meetkai/mka1/funcs/authServiceAccountsCreate.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsCreate(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsCreate failed:", res.error);
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
  useAuthServiceAccountsCreateMutation
} from "@meetkai/mka1/react-query/authServiceAccountsCreate.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateServiceAccountRequest](../../models/operations/createserviceaccountrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateServiceAccountResponseBody](../../models/operations/createserviceaccountresponsebody.md)\>**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| errors.CreateServiceAccountResponseBody                               | 400                                                                   | application/json                                                      |
| errors.CreateServiceAccountAuthServiceAccountsResponseBody            | 401                                                                   | application/json                                                      |
| errors.CreateServiceAccountAuthServiceAccountsResponseResponseBody    | 403                                                                   | application/json                                                      |
| errors.CreateServiceAccountAuthServiceAccountsResponse404ResponseBody | 404                                                                   | application/json                                                      |
| errors.CreateServiceAccountAuthServiceAccountsResponse409ResponseBody | 409                                                                   | application/json                                                      |
| errors.CreateServiceAccountAuthServiceAccountsResponse410ResponseBody | 410                                                                   | application/json                                                      |
| errors.CreateServiceAccountAuthServiceAccountsResponse429ResponseBody | 429                                                                   | application/json                                                      |
| errors.APIError                                                       | 4XX, 5XX                                                              | \*/\*                                                                 |

## list

List service accounts

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listServiceAccounts" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.list({
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
import { authServiceAccountsList } from "@meetkai/mka1/funcs/authServiceAccountsList.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsList(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsList failed:", res.error);
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
  useAuthServiceAccountsList,
  useAuthServiceAccountsListSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthServiceAccountsList,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthServiceAccountsList,
  invalidateAllAuthServiceAccountsList,
} from "@meetkai/mka1/react-query/authServiceAccountsList.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListServiceAccountsRequest](../../models/operations/listserviceaccountsrequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListServiceAccountsResponseBody](../../models/operations/listserviceaccountsresponsebody.md)\>**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| errors.ListServiceAccountsResponseBody                               | 400                                                                  | application/json                                                     |
| errors.ListServiceAccountsAuthServiceAccountsResponseBody            | 401                                                                  | application/json                                                     |
| errors.ListServiceAccountsAuthServiceAccountsResponseResponseBody    | 403                                                                  | application/json                                                     |
| errors.ListServiceAccountsAuthServiceAccountsResponse404ResponseBody | 404                                                                  | application/json                                                     |
| errors.ListServiceAccountsAuthServiceAccountsResponse409ResponseBody | 409                                                                  | application/json                                                     |
| errors.ListServiceAccountsAuthServiceAccountsResponse410ResponseBody | 410                                                                  | application/json                                                     |
| errors.ListServiceAccountsAuthServiceAccountsResponse429ResponseBody | 429                                                                  | application/json                                                     |
| errors.APIError                                                      | 4XX, 5XX                                                             | \*/\*                                                                |

## get

Get a service account

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getServiceAccount" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.get({
    orgId: "<id>",
    saId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authServiceAccountsGet } from "@meetkai/mka1/funcs/authServiceAccountsGet.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsGet(sdk, {
    orgId: "<id>",
    saId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsGet failed:", res.error);
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
  useAuthServiceAccountsGet,
  useAuthServiceAccountsGetSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthServiceAccountsGet,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthServiceAccountsGet,
  invalidateAllAuthServiceAccountsGet,
} from "@meetkai/mka1/react-query/authServiceAccountsGet.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetServiceAccountRequest](../../models/operations/getserviceaccountrequest.md)                                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetServiceAccountResponseBody](../../models/operations/getserviceaccountresponsebody.md)\>**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| errors.GetServiceAccountResponseBody                               | 400                                                                | application/json                                                   |
| errors.GetServiceAccountAuthServiceAccountsResponseBody            | 401                                                                | application/json                                                   |
| errors.GetServiceAccountAuthServiceAccountsResponseResponseBody    | 403                                                                | application/json                                                   |
| errors.GetServiceAccountAuthServiceAccountsResponse404ResponseBody | 404                                                                | application/json                                                   |
| errors.GetServiceAccountAuthServiceAccountsResponse409ResponseBody | 409                                                                | application/json                                                   |
| errors.GetServiceAccountAuthServiceAccountsResponse410ResponseBody | 410                                                                | application/json                                                   |
| errors.GetServiceAccountAuthServiceAccountsResponse429ResponseBody | 429                                                                | application/json                                                   |
| errors.APIError                                                    | 4XX, 5XX                                                           | \*/\*                                                              |

## delete

Delete a service account

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteServiceAccount" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.delete({
    orgId: "<id>",
    saId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authServiceAccountsDelete } from "@meetkai/mka1/funcs/authServiceAccountsDelete.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsDelete(sdk, {
    orgId: "<id>",
    saId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsDelete failed:", res.error);
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
  useAuthServiceAccountsDeleteMutation
} from "@meetkai/mka1/react-query/authServiceAccountsDelete.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteServiceAccountRequest](../../models/operations/deleteserviceaccountrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.DeleteServiceAccountResponseBody](../../models/operations/deleteserviceaccountresponsebody.md)\>**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| errors.DeleteServiceAccountResponseBody                               | 400                                                                   | application/json                                                      |
| errors.DeleteServiceAccountAuthServiceAccountsResponseBody            | 401                                                                   | application/json                                                      |
| errors.DeleteServiceAccountAuthServiceAccountsResponseResponseBody    | 403                                                                   | application/json                                                      |
| errors.DeleteServiceAccountAuthServiceAccountsResponse404ResponseBody | 404                                                                   | application/json                                                      |
| errors.DeleteServiceAccountAuthServiceAccountsResponse409ResponseBody | 409                                                                   | application/json                                                      |
| errors.DeleteServiceAccountAuthServiceAccountsResponse410ResponseBody | 410                                                                   | application/json                                                      |
| errors.DeleteServiceAccountAuthServiceAccountsResponse429ResponseBody | 429                                                                   | application/json                                                      |
| errors.APIError                                                       | 4XX, 5XX                                                              | \*/\*                                                                 |

## listApiKeys

List a service account's API keys

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listServiceAccountApiKeys" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.listApiKeys({
    orgId: "<id>",
    saId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authServiceAccountsListApiKeys } from "@meetkai/mka1/funcs/authServiceAccountsListApiKeys.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsListApiKeys(sdk, {
    orgId: "<id>",
    saId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsListApiKeys failed:", res.error);
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
  useAuthServiceAccountsListApiKeys,
  useAuthServiceAccountsListApiKeysSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthServiceAccountsListApiKeys,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthServiceAccountsListApiKeys,
  invalidateAllAuthServiceAccountsListApiKeys,
} from "@meetkai/mka1/react-query/authServiceAccountsListApiKeys.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListServiceAccountApiKeysRequest](../../models/operations/listserviceaccountapikeysrequest.md)                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListServiceAccountApiKeysResponseBody[]](../../models/.md)\>**

### Errors

| Error Type                                                                 | Status Code                                                                | Content Type                                                               |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| errors.ListServiceAccountApiKeysResponseBody                               | 400                                                                        | application/json                                                           |
| errors.ListServiceAccountApiKeysAuthServiceAccountsResponseBody            | 401                                                                        | application/json                                                           |
| errors.ListServiceAccountApiKeysAuthServiceAccountsResponseResponseBody    | 403                                                                        | application/json                                                           |
| errors.ListServiceAccountApiKeysAuthServiceAccountsResponse404ResponseBody | 404                                                                        | application/json                                                           |
| errors.ListServiceAccountApiKeysAuthServiceAccountsResponse409ResponseBody | 409                                                                        | application/json                                                           |
| errors.ListServiceAccountApiKeysAuthServiceAccountsResponse410ResponseBody | 410                                                                        | application/json                                                           |
| errors.ListServiceAccountApiKeysAuthServiceAccountsResponse429ResponseBody | 429                                                                        | application/json                                                           |
| errors.APIError                                                            | 4XX, 5XX                                                                   | \*/\*                                                                      |

## updateApiKey

Update a service-account API key

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateServiceAccountApiKey" method="patch" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.updateApiKey({
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authServiceAccountsUpdateApiKey } from "@meetkai/mka1/funcs/authServiceAccountsUpdateApiKey.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsUpdateApiKey(sdk, {
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsUpdateApiKey failed:", res.error);
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
  useAuthServiceAccountsUpdateApiKeyMutation
} from "@meetkai/mka1/react-query/authServiceAccountsUpdateApiKey.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateServiceAccountApiKeyRequest](../../models/operations/updateserviceaccountapikeyrequest.md)                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UpdateServiceAccountApiKeyResponseBody](../../models/operations/updateserviceaccountapikeyresponsebody.md)\>**

### Errors

| Error Type                                                                  | Status Code                                                                 | Content Type                                                                |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| errors.UpdateServiceAccountApiKeyResponseBody                               | 400                                                                         | application/json                                                            |
| errors.UpdateServiceAccountApiKeyAuthServiceAccountsResponseBody            | 401                                                                         | application/json                                                            |
| errors.UpdateServiceAccountApiKeyAuthServiceAccountsResponseResponseBody    | 403                                                                         | application/json                                                            |
| errors.UpdateServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody | 404                                                                         | application/json                                                            |
| errors.UpdateServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody | 409                                                                         | application/json                                                            |
| errors.UpdateServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody | 410                                                                         | application/json                                                            |
| errors.UpdateServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody | 429                                                                         | application/json                                                            |
| errors.APIError                                                             | 4XX, 5XX                                                                    | \*/\*                                                                       |

## deleteApiKey

Delete a service-account API key

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteServiceAccountApiKey" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.deleteApiKey({
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authServiceAccountsDeleteApiKey } from "@meetkai/mka1/funcs/authServiceAccountsDeleteApiKey.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsDeleteApiKey(sdk, {
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsDeleteApiKey failed:", res.error);
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
  useAuthServiceAccountsDeleteApiKeyMutation
} from "@meetkai/mka1/react-query/authServiceAccountsDeleteApiKey.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteServiceAccountApiKeyRequest](../../models/operations/deleteserviceaccountapikeyrequest.md)                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.DeleteServiceAccountApiKeyResponseBody](../../models/operations/deleteserviceaccountapikeyresponsebody.md)\>**

### Errors

| Error Type                                                                  | Status Code                                                                 | Content Type                                                                |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| errors.DeleteServiceAccountApiKeyResponseBody                               | 400                                                                         | application/json                                                            |
| errors.DeleteServiceAccountApiKeyAuthServiceAccountsResponseBody            | 401                                                                         | application/json                                                            |
| errors.DeleteServiceAccountApiKeyAuthServiceAccountsResponseResponseBody    | 403                                                                         | application/json                                                            |
| errors.DeleteServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody | 404                                                                         | application/json                                                            |
| errors.DeleteServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody | 409                                                                         | application/json                                                            |
| errors.DeleteServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody | 410                                                                         | application/json                                                            |
| errors.DeleteServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody | 429                                                                         | application/json                                                            |
| errors.APIError                                                             | 4XX, 5XX                                                                    | \*/\*                                                                       |

## regenerateApiKey

Rotate a service-account API key's secret

### Example Usage

<!-- UsageSnippet language="typescript" operationID="regenerateServiceAccountApiKey" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}/regenerate" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.serviceAccounts.regenerateApiKey({
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authServiceAccountsRegenerateApiKey } from "@meetkai/mka1/funcs/authServiceAccountsRegenerateApiKey.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authServiceAccountsRegenerateApiKey(sdk, {
    orgId: "<id>",
    saId: "<id>",
    keyId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authServiceAccountsRegenerateApiKey failed:", res.error);
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
  useAuthServiceAccountsRegenerateApiKeyMutation
} from "@meetkai/mka1/react-query/authServiceAccountsRegenerateApiKey.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.RegenerateServiceAccountApiKeyRequest](../../models/operations/regenerateserviceaccountapikeyrequest.md)                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.RegenerateServiceAccountApiKeyResponseBody](../../models/operations/regenerateserviceaccountapikeyresponsebody.md)\>**

### Errors

| Error Type                                                                      | Status Code                                                                     | Content Type                                                                    |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| errors.RegenerateServiceAccountApiKeyResponseBody                               | 400                                                                             | application/json                                                                |
| errors.RegenerateServiceAccountApiKeyAuthServiceAccountsResponseBody            | 401                                                                             | application/json                                                                |
| errors.RegenerateServiceAccountApiKeyAuthServiceAccountsResponseResponseBody    | 403                                                                             | application/json                                                                |
| errors.RegenerateServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody | 404                                                                             | application/json                                                                |
| errors.RegenerateServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody | 409                                                                             | application/json                                                                |
| errors.RegenerateServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody | 410                                                                             | application/json                                                                |
| errors.RegenerateServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody | 429                                                                             | application/json                                                                |
| errors.APIError                                                                 | 4XX, 5XX                                                                        | \*/\*                                                                           |