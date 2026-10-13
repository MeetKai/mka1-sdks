# Auth.ApiKeys

## Overview

### Available Operations

* [Create](#create) - Mint a scoped API key
* [List](#list) - List scoped API keys
* [Update](#update) - Update a scoped API key
* [Regenerate](#regenerate) - Rotate a scoped API key's secret
* [ExchangeToken](#exchangetoken) - Exchange API key for a JWT token

## Create

Mint an API key bound to a (principal, team) carrying an explicit scope set. Requires a session, or a bearer key holding `write:apikeys`. The plaintext secret is returned once.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ApiKeys.CreateAsync();

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `Body`                                                                                 | [CreateScopedApiKeyRequestBody](../../Types/Requests/CreateScopedApiKeyRequestBody.md) | :heavy_minus_sign:                                                                     | N/A                                                                                    |

### Response

**[CreateScopedApiKeyResponse](../../Types/Requests/CreateScopedApiKeyResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.CreateScopedApiKeyBadRequestException      | 400                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.CreateScopedApiKeyUnauthorizedException    | 401                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.CreateScopedApiKeyForbiddenException       | 403                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.CreateScopedApiKeyNotFoundException        | 404                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.CreateScopedApiKeyConflictException        | 409                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.CreateScopedApiKeyGoneException            | 410                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.CreateScopedApiKeyTooManyRequestsException | 429                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.APIException                               | 4XX, 5XX                                                             | \*/\*                                                                |

## List

List the caller's scoped API keys (metadata only — never the secret). Optional `?orgId=&teamId=` narrows; a key caller is scoped to its own org.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listScopedApiKeys" method="get" path="/api/v1/authentication/api-key/scoped" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ApiKeys.ListAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `TeamId`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListScopedApiKeysResponse](../../Types/Requests/ListScopedApiKeysResponse.md)**

### Errors

| Error Type                                                          | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ListScopedApiKeysBadRequestException      | 400                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.ListScopedApiKeysUnauthorizedException    | 401                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.ListScopedApiKeysForbiddenException       | 403                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.ListScopedApiKeysNotFoundException        | 404                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.ListScopedApiKeysConflictException        | 409                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.ListScopedApiKeysGoneException            | 410                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.ListScopedApiKeysTooManyRequestsException | 429                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.APIException                              | 4XX, 5XX                                                            | \*/\*                                                               |

## Update

Update a key's scopes (and optionally name / rate limit). Scopes already on the key are retained; newly-added scopes are bounded by the caller's role (and, for a key caller, the calling key's own scopes).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/update" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ApiKeys.UpdateAsync();

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `Body`                                                                                 | [UpdateScopedApiKeyRequestBody](../../Types/Requests/UpdateScopedApiKeyRequestBody.md) | :heavy_minus_sign:                                                                     | N/A                                                                                    |

### Response

**[UpdateScopedApiKeyResponse](../../Types/Requests/UpdateScopedApiKeyResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.UpdateScopedApiKeyBadRequestException      | 400                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateScopedApiKeyUnauthorizedException    | 401                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateScopedApiKeyForbiddenException       | 403                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateScopedApiKeyNotFoundException        | 404                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateScopedApiKeyConflictException        | 409                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateScopedApiKeyGoneException            | 410                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.UpdateScopedApiKeyTooManyRequestsException | 429                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.APIException                               | 4XX, 5XX                                                             | \*/\*                                                                |

## Regenerate

Issue a new plaintext secret for an existing key in place (id / scopes / binding preserved). Returned once.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="regenerateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/regenerate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ApiKeys.RegenerateAsync();

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `XOnBehalfOf`                                                                                  | *string*                                                                                       | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `Body`                                                                                         | [RegenerateScopedApiKeyRequestBody](../../Types/Requests/RegenerateScopedApiKeyRequestBody.md) | :heavy_minus_sign:                                                                             | N/A                                                                                            |

### Response

**[RegenerateScopedApiKeyResponse](../../Types/Requests/RegenerateScopedApiKeyResponse.md)**

### Errors

| Error Type                                                               | Status Code                                                              | Content Type                                                             |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.RegenerateScopedApiKeyBadRequestException      | 400                                                                      | application/json                                                         |
| MeetKai.MKA1.Types.Errors.RegenerateScopedApiKeyUnauthorizedException    | 401                                                                      | application/json                                                         |
| MeetKai.MKA1.Types.Errors.RegenerateScopedApiKeyForbiddenException       | 403                                                                      | application/json                                                         |
| MeetKai.MKA1.Types.Errors.RegenerateScopedApiKeyNotFoundException        | 404                                                                      | application/json                                                         |
| MeetKai.MKA1.Types.Errors.RegenerateScopedApiKeyConflictException        | 409                                                                      | application/json                                                         |
| MeetKai.MKA1.Types.Errors.RegenerateScopedApiKeyGoneException            | 410                                                                      | application/json                                                         |
| MeetKai.MKA1.Types.Errors.RegenerateScopedApiKeyTooManyRequestsException | 429                                                                      | application/json                                                         |
| MeetKai.MKA1.Types.Errors.APIException                                   | 4XX, 5XX                                                                 | \*/\*                                                                    |

## ExchangeToken

Exchange an API key for a short-lived JWT token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="exchangeApiKeyToken" method="post" path="/api/v1/authentication/api-keys/exchange-token" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.ApiKeys.ExchangeTokenAsync(body: new ExchangeApiKeyTokenRequestBody() {
    Audience = "https://medium-haversack.info/",
    ExternalUserId = "<id>",
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Body`                                                                                   | [ExchangeApiKeyTokenRequestBody](../../Types/Requests/ExchangeApiKeyTokenRequestBody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |

### Response

**[ExchangeApiKeyTokenResponse](../../Types/Requests/ExchangeApiKeyTokenResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ExchangeApiKeyTokenBadRequestException      | 400                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ExchangeApiKeyTokenUnauthorizedException    | 401                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ExchangeApiKeyTokenForbiddenException       | 403                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ExchangeApiKeyTokenNotFoundException        | 404                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ExchangeApiKeyTokenConflictException        | 409                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ExchangeApiKeyTokenGoneException            | 410                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ExchangeApiKeyTokenTooManyRequestsException | 429                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.APIException                                | 4XX, 5XX                                                              | \*/\*                                                                 |