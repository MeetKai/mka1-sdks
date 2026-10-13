# Auth.ApiKeys

## Overview

### Available Operations

* [create](#create) - Mint a scoped API key
* [list](#list) - List scoped API keys
* [update](#update) - Update a scoped API key
* [regenerate](#regenerate) - Rotate a scoped API key's secret
* [exchange_token](#exchange_token) - Exchange API key for a JWT token

## create

Mint an API key bound to a (principal, team) carrying an explicit scope set. Requires a session, or a bearer key holding `write:apikeys`. The plaintext secret is returned once.

### Example Usage

<!-- UsageSnippet language="python" operationID="createScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.api_keys.create()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `x_on_behalf_of`                                                                                | *Optional[str]*                                                                                 | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |
| `body`                                                                                          | [Optional[models.CreateScopedAPIKeyRequestBody]](../../models/createscopedapikeyrequestbody.md) | :heavy_minus_sign:                                                                              | N/A                                                                                             |
| `retries`                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                | :heavy_minus_sign:                                                                              | Configuration to override the default retry behavior of the client.                             |

### Response

**[models.CreateScopedAPIKeyResponse](../../models/createscopedapikeyresponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| errors.CreateScopedAPIKeyBadRequestError      | 400                                           | application/json                              |
| errors.CreateScopedAPIKeyUnauthorizedError    | 401                                           | application/json                              |
| errors.CreateScopedAPIKeyForbiddenError       | 403                                           | application/json                              |
| errors.CreateScopedAPIKeyNotFoundError        | 404                                           | application/json                              |
| errors.CreateScopedAPIKeyConflictError        | 409                                           | application/json                              |
| errors.CreateScopedAPIKeyGoneError            | 410                                           | application/json                              |
| errors.CreateScopedAPIKeyTooManyRequestsError | 429                                           | application/json                              |
| errors.SDKDefaultError                        | 4XX, 5XX                                      | \*/\*                                         |

## list

List the caller's scoped API keys (metadata only — never the secret). Optional `?orgId=&teamId=` narrows; a key caller is scoped to its own org.

### Example Usage

<!-- UsageSnippet language="python" operationID="listScopedApiKeys" method="get" path="/api/v1/authentication/api-key/scoped" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.api_keys.list()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `team_id`                                                           | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[List[models.ListScopedAPIKeysResponse]](../../models/.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| errors.ListScopedAPIKeysBadRequestError      | 400                                          | application/json                             |
| errors.ListScopedAPIKeysUnauthorizedError    | 401                                          | application/json                             |
| errors.ListScopedAPIKeysForbiddenError       | 403                                          | application/json                             |
| errors.ListScopedAPIKeysNotFoundError        | 404                                          | application/json                             |
| errors.ListScopedAPIKeysConflictError        | 409                                          | application/json                             |
| errors.ListScopedAPIKeysGoneError            | 410                                          | application/json                             |
| errors.ListScopedAPIKeysTooManyRequestsError | 429                                          | application/json                             |
| errors.SDKDefaultError                       | 4XX, 5XX                                     | \*/\*                                        |

## update

Update a key's scopes (and optionally name / rate limit). Scopes already on the key are retained; newly-added scopes are bounded by the caller's role (and, for a key caller, the calling key's own scopes).

### Example Usage

<!-- UsageSnippet language="python" operationID="updateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/update" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.api_keys.update()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `x_on_behalf_of`                                                                                | *Optional[str]*                                                                                 | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |
| `body`                                                                                          | [Optional[models.UpdateScopedAPIKeyRequestBody]](../../models/updatescopedapikeyrequestbody.md) | :heavy_minus_sign:                                                                              | N/A                                                                                             |
| `retries`                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                | :heavy_minus_sign:                                                                              | Configuration to override the default retry behavior of the client.                             |

### Response

**[models.UpdateScopedAPIKeyResponse](../../models/updatescopedapikeyresponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| errors.UpdateScopedAPIKeyBadRequestError      | 400                                           | application/json                              |
| errors.UpdateScopedAPIKeyUnauthorizedError    | 401                                           | application/json                              |
| errors.UpdateScopedAPIKeyForbiddenError       | 403                                           | application/json                              |
| errors.UpdateScopedAPIKeyNotFoundError        | 404                                           | application/json                              |
| errors.UpdateScopedAPIKeyConflictError        | 409                                           | application/json                              |
| errors.UpdateScopedAPIKeyGoneError            | 410                                           | application/json                              |
| errors.UpdateScopedAPIKeyTooManyRequestsError | 429                                           | application/json                              |
| errors.SDKDefaultError                        | 4XX, 5XX                                      | \*/\*                                         |

## regenerate

Issue a new plaintext secret for an existing key in place (id / scopes / binding preserved). Returned once.

### Example Usage

<!-- UsageSnippet language="python" operationID="regenerateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/regenerate" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.api_keys.regenerate()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `x_on_behalf_of`                                                                                        | *Optional[str]*                                                                                         | :heavy_minus_sign:                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                     |
| `body`                                                                                                  | [Optional[models.RegenerateScopedAPIKeyRequestBody]](../../models/regeneratescopedapikeyrequestbody.md) | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `retries`                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                        | :heavy_minus_sign:                                                                                      | Configuration to override the default retry behavior of the client.                                     |

### Response

**[models.RegenerateScopedAPIKeyResponse](../../models/regeneratescopedapikeyresponse.md)**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| errors.RegenerateScopedAPIKeyBadRequestError      | 400                                               | application/json                                  |
| errors.RegenerateScopedAPIKeyUnauthorizedError    | 401                                               | application/json                                  |
| errors.RegenerateScopedAPIKeyForbiddenError       | 403                                               | application/json                                  |
| errors.RegenerateScopedAPIKeyNotFoundError        | 404                                               | application/json                                  |
| errors.RegenerateScopedAPIKeyConflictError        | 409                                               | application/json                                  |
| errors.RegenerateScopedAPIKeyGoneError            | 410                                               | application/json                                  |
| errors.RegenerateScopedAPIKeyTooManyRequestsError | 429                                               | application/json                                  |
| errors.SDKDefaultError                            | 4XX, 5XX                                          | \*/\*                                             |

## exchange_token

Exchange an API key for a short-lived JWT token.

### Example Usage

<!-- UsageSnippet language="python" operationID="exchangeApiKeyToken" method="post" path="/api/v1/authentication/api-keys/exchange-token" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.api_keys.exchange_token(audience="https://medium-haversack.info/", external_user_id="<id>", expires_in=3600.0)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                       | Type                                                                                                                                                                                                                            | Required                                                                                                                                                                                                                        | Description                                                                                                                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `audience`                                                                                                                                                                                                                      | *str*                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                              | JWT audience (aud) claim for the exchanged token. Set this to the target API/service URL that should accept the token.                                                                                                          |
| `external_user_id`                                                                                                                                                                                                              | *str*                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                              | Your external user identifier to place in the JWT subject (sub) claim. Must be 1–150 printable-ASCII characters and not the wildcard `*`.                                                                                       |
| `x_on_behalf_of`                                                                                                                                                                                                                | *Optional[str]*                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                             |
| `expires_in`                                                                                                                                                                                                                    | *Optional[float]*                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                              | Token lifetime in seconds. Must be between 300 (5 minutes) and 2592000 (30 days). Defaults to 3600 (1 hour).                                                                                                                    |
| `permissions`                                                                                                                                                                                                                   | List[*str*]                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                              | Optional subset of the API key's scopes to embed in the token (e.g. read:responses). The exchanged token is attenuated to this set at the gateway perimeter. If omitted, all of the key's scopes are embedded (no attenuation). |
| `retries`                                                                                                                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                                                                              | Configuration to override the default retry behavior of the client.                                                                                                                                                             |

### Response

**[models.ExchangeAPIKeyTokenResponse](../../models/exchangeapikeytokenresponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.ExchangeAPIKeyTokenBadRequestError      | 400                                            | application/json                               |
| errors.ExchangeAPIKeyTokenUnauthorizedError    | 401                                            | application/json                               |
| errors.ExchangeAPIKeyTokenForbiddenError       | 403                                            | application/json                               |
| errors.ExchangeAPIKeyTokenNotFoundError        | 404                                            | application/json                               |
| errors.ExchangeAPIKeyTokenConflictError        | 409                                            | application/json                               |
| errors.ExchangeAPIKeyTokenGoneError            | 410                                            | application/json                               |
| errors.ExchangeAPIKeyTokenTooManyRequestsError | 429                                            | application/json                               |
| errors.SDKDefaultError                         | 4XX, 5XX                                       | \*/\*                                          |