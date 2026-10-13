# Auth.ApiKeys

## Overview

### Available Operations

* [create](#create) - Mint a scoped API key
* [list](#list) - List scoped API keys
* [update](#update) - Update a scoped API key
* [regenerate](#regenerate) - Rotate a scoped API key's secret
* [exchangeToken](#exchangetoken) - Exchange API key for a JWT token

## create

Mint an API key bound to a (principal, team) carrying an explicit scope set. Requires a session, or a bearer key holding `write:apikeys`. The plaintext secret is returned once.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.apiKeys.create({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authApiKeysCreate } from "@meetkai/mka1/funcs/authApiKeysCreate.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authApiKeysCreate(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authApiKeysCreate failed:", res.error);
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
  useAuthApiKeysCreateMutation
} from "@meetkai/mka1/react-query/authApiKeysCreate.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateScopedApiKeyRequest](../../models/operations/createscopedapikeyrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateScopedApiKeyResponseBody](../../models/operations/createscopedapikeyresponsebody.md)\>**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| errors.CreateScopedApiKeyResponseBody                       | 400                                                         | application/json                                            |
| errors.CreateScopedApiKeyAuthApiKeysResponseBody            | 401                                                         | application/json                                            |
| errors.CreateScopedApiKeyAuthApiKeysResponseResponseBody    | 403                                                         | application/json                                            |
| errors.CreateScopedApiKeyAuthApiKeysResponse404ResponseBody | 404                                                         | application/json                                            |
| errors.CreateScopedApiKeyAuthApiKeysResponse409ResponseBody | 409                                                         | application/json                                            |
| errors.CreateScopedApiKeyAuthApiKeysResponse410ResponseBody | 410                                                         | application/json                                            |
| errors.CreateScopedApiKeyAuthApiKeysResponse429ResponseBody | 429                                                         | application/json                                            |
| errors.APIError                                             | 4XX, 5XX                                                    | \*/\*                                                       |

## list

List the caller's scoped API keys (metadata only — never the secret). Optional `?orgId=&teamId=` narrows; a key caller is scoped to its own org.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listScopedApiKeys" method="get" path="/api/v1/authentication/api-key/scoped" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.apiKeys.list({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authApiKeysList } from "@meetkai/mka1/funcs/authApiKeysList.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authApiKeysList(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authApiKeysList failed:", res.error);
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
  useAuthApiKeysList,
  useAuthApiKeysListSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthApiKeysList,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthApiKeysList,
  invalidateAllAuthApiKeysList,
} from "@meetkai/mka1/react-query/authApiKeysList.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListScopedApiKeysRequest](../../models/operations/listscopedapikeysrequest.md)                                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ResponseBody[]](../../models/.md)\>**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| errors.ListScopedApiKeysResponseBody                       | 400                                                        | application/json                                           |
| errors.ListScopedApiKeysAuthApiKeysResponseBody            | 401                                                        | application/json                                           |
| errors.ListScopedApiKeysAuthApiKeysResponseResponseBody    | 403                                                        | application/json                                           |
| errors.ListScopedApiKeysAuthApiKeysResponse404ResponseBody | 404                                                        | application/json                                           |
| errors.ListScopedApiKeysAuthApiKeysResponse409ResponseBody | 409                                                        | application/json                                           |
| errors.ListScopedApiKeysAuthApiKeysResponse410ResponseBody | 410                                                        | application/json                                           |
| errors.ListScopedApiKeysAuthApiKeysResponse429ResponseBody | 429                                                        | application/json                                           |
| errors.APIError                                            | 4XX, 5XX                                                   | \*/\*                                                      |

## update

Update a key's scopes (and optionally name / rate limit). Scopes already on the key are retained; newly-added scopes are bounded by the caller's role (and, for a key caller, the calling key's own scopes).

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/update" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.apiKeys.update({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authApiKeysUpdate } from "@meetkai/mka1/funcs/authApiKeysUpdate.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authApiKeysUpdate(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authApiKeysUpdate failed:", res.error);
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
  useAuthApiKeysUpdateMutation
} from "@meetkai/mka1/react-query/authApiKeysUpdate.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateScopedApiKeyRequest](../../models/operations/updatescopedapikeyrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UpdateScopedApiKeyResponseBody](../../models/operations/updatescopedapikeyresponsebody.md)\>**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| errors.UpdateScopedApiKeyResponseBody                       | 400                                                         | application/json                                            |
| errors.UpdateScopedApiKeyAuthApiKeysResponseBody            | 401                                                         | application/json                                            |
| errors.UpdateScopedApiKeyAuthApiKeysResponseResponseBody    | 403                                                         | application/json                                            |
| errors.UpdateScopedApiKeyAuthApiKeysResponse404ResponseBody | 404                                                         | application/json                                            |
| errors.UpdateScopedApiKeyAuthApiKeysResponse409ResponseBody | 409                                                         | application/json                                            |
| errors.UpdateScopedApiKeyAuthApiKeysResponse410ResponseBody | 410                                                         | application/json                                            |
| errors.UpdateScopedApiKeyAuthApiKeysResponse429ResponseBody | 429                                                         | application/json                                            |
| errors.APIError                                             | 4XX, 5XX                                                    | \*/\*                                                       |

## regenerate

Issue a new plaintext secret for an existing key in place (id / scopes / binding preserved). Returned once.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="regenerateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/regenerate" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.apiKeys.regenerate({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authApiKeysRegenerate } from "@meetkai/mka1/funcs/authApiKeysRegenerate.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authApiKeysRegenerate(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authApiKeysRegenerate failed:", res.error);
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
  useAuthApiKeysRegenerateMutation
} from "@meetkai/mka1/react-query/authApiKeysRegenerate.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.RegenerateScopedApiKeyRequest](../../models/operations/regeneratescopedapikeyrequest.md)                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.RegenerateScopedApiKeyResponseBody](../../models/operations/regeneratescopedapikeyresponsebody.md)\>**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| errors.RegenerateScopedApiKeyResponseBody                       | 400                                                             | application/json                                                |
| errors.RegenerateScopedApiKeyAuthApiKeysResponseBody            | 401                                                             | application/json                                                |
| errors.RegenerateScopedApiKeyAuthApiKeysResponseResponseBody    | 403                                                             | application/json                                                |
| errors.RegenerateScopedApiKeyAuthApiKeysResponse404ResponseBody | 404                                                             | application/json                                                |
| errors.RegenerateScopedApiKeyAuthApiKeysResponse409ResponseBody | 409                                                             | application/json                                                |
| errors.RegenerateScopedApiKeyAuthApiKeysResponse410ResponseBody | 410                                                             | application/json                                                |
| errors.RegenerateScopedApiKeyAuthApiKeysResponse429ResponseBody | 429                                                             | application/json                                                |
| errors.APIError                                                 | 4XX, 5XX                                                        | \*/\*                                                           |

## exchangeToken

Exchange an API key for a short-lived JWT token.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="exchangeApiKeyToken" method="post" path="/api/v1/authentication/api-keys/exchange-token" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.apiKeys.exchangeToken({
    requestBody: {
      audience: "https://medium-haversack.info/",
      externalUserId: "<id>",
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
import { authApiKeysExchangeToken } from "@meetkai/mka1/funcs/authApiKeysExchangeToken.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authApiKeysExchangeToken(sdk, {
    requestBody: {
      audience: "https://medium-haversack.info/",
      externalUserId: "<id>",
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authApiKeysExchangeToken failed:", res.error);
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
  useAuthApiKeysExchangeTokenMutation
} from "@meetkai/mka1/react-query/authApiKeysExchangeToken.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ExchangeApiKeyTokenRequest](../../models/operations/exchangeapikeytokenrequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ExchangeApiKeyTokenResponseBody](../../models/operations/exchangeapikeytokenresponsebody.md)\>**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| errors.ExchangeApiKeyTokenResponseBody                       | 400                                                          | application/json                                             |
| errors.ExchangeApiKeyTokenAuthApiKeysResponseBody            | 401                                                          | application/json                                             |
| errors.ExchangeApiKeyTokenAuthApiKeysResponseResponseBody    | 403                                                          | application/json                                             |
| errors.ExchangeApiKeyTokenAuthApiKeysResponse404ResponseBody | 404                                                          | application/json                                             |
| errors.ExchangeApiKeyTokenAuthApiKeysResponse409ResponseBody | 409                                                          | application/json                                             |
| errors.ExchangeApiKeyTokenAuthApiKeysResponse410ResponseBody | 410                                                          | application/json                                             |
| errors.ExchangeApiKeyTokenAuthApiKeysResponse429ResponseBody | 429                                                          | application/json                                             |
| errors.APIError                                              | 4XX, 5XX                                                     | \*/\*                                                        |