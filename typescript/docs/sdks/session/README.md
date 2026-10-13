# Session

## Overview

### Available Operations

* [getPendingInvitation](#getpendinginvitation) - Find an unfinished invitation for the signed-in recipient
* [exchangeSessionToken](#exchangesessiontoken) - Exchange a live session for a delegated access token

## getPendingInvitation

Requires a session with a verified email. Returns a pending, unexpired organization invitation first, otherwise an unclaimed, unexpired cluster invitation bound to that email. Open cluster invitations are never returned. Does not accept or modify the invitation.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getPendingInvitation" method="get" path="/api/v1/authentication/pending-invitation" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.session.getPendingInvitation({
    sessionCookie: "<YOUR_API_KEY_HERE>",
  }, {});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { sessionGetPendingInvitation } from "@meetkai/mka1/funcs/sessionGetPendingInvitation.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore();

async function run() {
  const res = await sessionGetPendingInvitation(sdk, {
    sessionCookie: "<YOUR_API_KEY_HERE>",
  }, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("sessionGetPendingInvitation failed:", res.error);
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
  useSessionGetPendingInvitation,
  useSessionGetPendingInvitationSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchSessionGetPendingInvitation,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateSessionGetPendingInvitation,
  invalidateAllSessionGetPendingInvitation,
} from "@meetkai/mka1/react-query/sessionGetPendingInvitation.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetPendingInvitationRequest](../../models/operations/getpendinginvitationrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `security`                                                                                                                                                                     | [operations.GetPendingInvitationSecurity](../../models/operations/getpendinginvitationsecurity.md)                                                                             | :heavy_check_mark:                                                                                                                                                             | The security requirements to use for the request.                                                                                                                              |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetPendingInvitationResponseBody](../../models/operations/getpendinginvitationresponsebody.md)\>**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.GetPendingInvitationResponseBody        | 401                                            | application/json                               |
| errors.GetPendingInvitationSessionResponseBody | 403                                            | application/json                               |
| errors.APIError                                | 4XX, 5XX                                       | \*/\*                                          |

## exchangeSessionToken

Mints a short-lived, audience-bound token with the same authority as the current live browser or device-login session. Identity, tenancy, permissions, and lifetime cannot be selected by the caller. The JSON body is limited to 4 KiB.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="exchangeSessionToken" method="post" path="/api/v1/authentication/session/exchange-token" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.session.exchangeSessionToken({
    sessionCookie: "<YOUR_API_KEY_HERE>",
  }, {
    requestBody: {
      audience: "https://apigw.mka1.com",
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
import { sessionExchangeSessionToken } from "@meetkai/mka1/funcs/sessionExchangeSessionToken.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore();

async function run() {
  const res = await sessionExchangeSessionToken(sdk, {
    sessionCookie: "<YOUR_API_KEY_HERE>",
  }, {
    requestBody: {
      audience: "https://apigw.mka1.com",
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("sessionExchangeSessionToken failed:", res.error);
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
  useSessionExchangeSessionTokenMutation
} from "@meetkai/mka1/react-query/sessionExchangeSessionToken.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ExchangeSessionTokenRequest](../../models/operations/exchangesessiontokenrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `security`                                                                                                                                                                     | [operations.ExchangeSessionTokenSecurity](../../models/operations/exchangesessiontokensecurity.md)                                                                             | :heavy_check_mark:                                                                                                                                                             | The security requirements to use for the request.                                                                                                                              |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ExchangeSessionTokenResponse](../../models/operations/exchangesessiontokenresponse.md)\>**

### Errors

| Error Type                                                | Status Code                                               | Content Type                                              |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| errors.ExchangeSessionTokenResponseBody                   | 400                                                       | application/json                                          |
| errors.ExchangeSessionTokenSessionResponseBody            | 401                                                       | application/json                                          |
| errors.ExchangeSessionTokenSessionResponseResponseBody    | 403                                                       | application/json                                          |
| errors.ExchangeSessionTokenSessionResponse413ResponseBody | 413                                                       | application/json                                          |
| errors.ExchangeSessionTokenSessionResponse429ResponseBody | 429                                                       | application/json                                          |
| errors.ExchangeSessionTokenSessionResponse500ResponseBody | 500                                                       | application/json                                          |
| errors.APIError                                           | 4XX, 5XX                                                  | \*/\*                                                     |