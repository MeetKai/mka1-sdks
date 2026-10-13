# ~~Auth.ApiKey~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~getJwtFromKey~~](#getjwtfromkey) - Exchange API key for a JWT token :warning: **Deprecated** Use [exchangeToken](docs/sdks/apikeys/README.md#exchangetoken) instead.

## ~~getJwtFromKey~~

Exchange an API key for a JWT token

> :warning: **DEPRECATED**: Use auth.apiKeys.exchangeToken() instead. This method will be removed in a future release.. Use `exchangeToken` instead.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getJwtFromKey" method="post" path="/api/v1/authentication/api-key/exchange-token" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.apiKey.getJwtFromKey({
    requestBody: {
      audience: "https://my-awesome-website.com",
      externalUserId: "the-user-id-in-your-system",
      permissions: [
        "agent:create",
        "agent:read",
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
import { authApiKeyGetJwtFromKey } from "@meetkai/mka1/funcs/authApiKeyGetJwtFromKey.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authApiKeyGetJwtFromKey(sdk, {
    requestBody: {
      audience: "https://my-awesome-website.com",
      externalUserId: "the-user-id-in-your-system",
      permissions: [
        "agent:create",
        "agent:read",
      ],
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authApiKeyGetJwtFromKey failed:", res.error);
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
  useAuthApiKeyGetJwtFromKeyMutation
} from "@meetkai/mka1/react-query/authApiKeyGetJwtFromKey.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetJwtFromKeyRequest](../../models/operations/getjwtfromkeyrequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetJwtFromKeyResponseBody](../../models/operations/getjwtfromkeyresponsebody.md)\>**

### Errors

| Error Type                                         | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| errors.GetJwtFromKeyResponseBody                   | 400                                                | application/json                                   |
| errors.GetJwtFromKeyAuthApiKeyResponseBody         | 401                                                | application/json                                   |
| errors.GetJwtFromKeyAuthApiKeyResponseResponseBody | 500                                                | application/json                                   |
| errors.APIError                                    | 4XX, 5XX                                           | \*/\*                                              |