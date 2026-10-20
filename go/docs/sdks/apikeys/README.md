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

<!-- UsageSnippet language="go" operationID="createScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Auth.APIKeys.Create(ctx, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                                 | :heavy_check_mark:                                                                                    | The context to use for the request.                                                                   |
| `xOnBehalfOf`                                                                                         | `*string`                                                                                             | :heavy_minus_sign:                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                   |
| `body`                                                                                                | [*operations.CreateScopedAPIKeyRequestBody](../../models/operations/createscopedapikeyrequestbody.md) | :heavy_minus_sign:                                                                                    | N/A                                                                                                   |
| `opts`                                                                                                | [][operations.Option](../../models/operations/option.md)                                              | :heavy_minus_sign:                                                                                    | The options for this request.                                                                         |

### Response

**[*operations.CreateScopedAPIKeyResponse](../../models/operations/createscopedapikeyresponse.md), error**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| apierrors.CreateScopedAPIKeyBadRequestError      | 400                                              | application/json                                 |
| apierrors.CreateScopedAPIKeyUnauthorizedError    | 401                                              | application/json                                 |
| apierrors.CreateScopedAPIKeyForbiddenError       | 403                                              | application/json                                 |
| apierrors.CreateScopedAPIKeyNotFoundError        | 404                                              | application/json                                 |
| apierrors.CreateScopedAPIKeyConflictError        | 409                                              | application/json                                 |
| apierrors.CreateScopedAPIKeyGoneError            | 410                                              | application/json                                 |
| apierrors.CreateScopedAPIKeyTooManyRequestsError | 429                                              | application/json                                 |
| apierrors.APIError                               | 4XX, 5XX                                         | \*/\*                                            |

## List

List the caller's scoped API keys (metadata only — never the secret). Optional `?orgId=&teamId=` narrows; a key caller is scoped to its own org.

### Example Usage

<!-- UsageSnippet language="go" operationID="listScopedApiKeys" method="get" path="/api/v1/authentication/api-key/scoped" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Auth.APIKeys.List(ctx, nil, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseBodies != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `teamID`                                                            | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListScopedAPIKeysResponse](../../models/operations/listscopedapikeysresponse.md), error**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| apierrors.ListScopedAPIKeysBadRequestError      | 400                                             | application/json                                |
| apierrors.ListScopedAPIKeysUnauthorizedError    | 401                                             | application/json                                |
| apierrors.ListScopedAPIKeysForbiddenError       | 403                                             | application/json                                |
| apierrors.ListScopedAPIKeysNotFoundError        | 404                                             | application/json                                |
| apierrors.ListScopedAPIKeysConflictError        | 409                                             | application/json                                |
| apierrors.ListScopedAPIKeysGoneError            | 410                                             | application/json                                |
| apierrors.ListScopedAPIKeysTooManyRequestsError | 429                                             | application/json                                |
| apierrors.APIError                              | 4XX, 5XX                                        | \*/\*                                           |

## Update

Update a key's scopes (and optionally name / rate limit). Scopes already on the key are retained; newly-added scopes are bounded by the caller's role (and, for a key caller, the calling key's own scopes).

### Example Usage

<!-- UsageSnippet language="go" operationID="updateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/update" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Auth.APIKeys.Update(ctx, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                                 | :heavy_check_mark:                                                                                    | The context to use for the request.                                                                   |
| `xOnBehalfOf`                                                                                         | `*string`                                                                                             | :heavy_minus_sign:                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                   |
| `body`                                                                                                | [*operations.UpdateScopedAPIKeyRequestBody](../../models/operations/updatescopedapikeyrequestbody.md) | :heavy_minus_sign:                                                                                    | N/A                                                                                                   |
| `opts`                                                                                                | [][operations.Option](../../models/operations/option.md)                                              | :heavy_minus_sign:                                                                                    | The options for this request.                                                                         |

### Response

**[*operations.UpdateScopedAPIKeyResponse](../../models/operations/updatescopedapikeyresponse.md), error**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| apierrors.UpdateScopedAPIKeyBadRequestError      | 400                                              | application/json                                 |
| apierrors.UpdateScopedAPIKeyUnauthorizedError    | 401                                              | application/json                                 |
| apierrors.UpdateScopedAPIKeyForbiddenError       | 403                                              | application/json                                 |
| apierrors.UpdateScopedAPIKeyNotFoundError        | 404                                              | application/json                                 |
| apierrors.UpdateScopedAPIKeyConflictError        | 409                                              | application/json                                 |
| apierrors.UpdateScopedAPIKeyGoneError            | 410                                              | application/json                                 |
| apierrors.UpdateScopedAPIKeyTooManyRequestsError | 429                                              | application/json                                 |
| apierrors.APIError                               | 4XX, 5XX                                         | \*/\*                                            |

## Regenerate

Issue a new plaintext secret for an existing key in place (id / scopes / binding preserved). Returned once.

### Example Usage

<!-- UsageSnippet language="go" operationID="regenerateScopedApiKey" method="post" path="/api/v1/authentication/api-key/scoped/regenerate" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Auth.APIKeys.Regenerate(ctx, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                         | [context.Context](https://pkg.go.dev/context#Context)                                                         | :heavy_check_mark:                                                                                            | The context to use for the request.                                                                           |
| `xOnBehalfOf`                                                                                                 | `*string`                                                                                                     | :heavy_minus_sign:                                                                                            | Optional external end-user identifier forwarded by the API gateway.                                           |
| `body`                                                                                                        | [*operations.RegenerateScopedAPIKeyRequestBody](../../models/operations/regeneratescopedapikeyrequestbody.md) | :heavy_minus_sign:                                                                                            | N/A                                                                                                           |
| `opts`                                                                                                        | [][operations.Option](../../models/operations/option.md)                                                      | :heavy_minus_sign:                                                                                            | The options for this request.                                                                                 |

### Response

**[*operations.RegenerateScopedAPIKeyResponse](../../models/operations/regeneratescopedapikeyresponse.md), error**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| apierrors.RegenerateScopedAPIKeyBadRequestError      | 400                                                  | application/json                                     |
| apierrors.RegenerateScopedAPIKeyUnauthorizedError    | 401                                                  | application/json                                     |
| apierrors.RegenerateScopedAPIKeyForbiddenError       | 403                                                  | application/json                                     |
| apierrors.RegenerateScopedAPIKeyNotFoundError        | 404                                                  | application/json                                     |
| apierrors.RegenerateScopedAPIKeyConflictError        | 409                                                  | application/json                                     |
| apierrors.RegenerateScopedAPIKeyGoneError            | 410                                                  | application/json                                     |
| apierrors.RegenerateScopedAPIKeyTooManyRequestsError | 429                                                  | application/json                                     |
| apierrors.APIError                                   | 4XX, 5XX                                             | \*/\*                                                |

## ExchangeToken

Exchange an API key for a short-lived JWT token.

### Example Usage

<!-- UsageSnippet language="go" operationID="exchangeApiKeyToken" method="post" path="/api/v1/authentication/api-keys/exchange-token" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Auth.APIKeys.ExchangeToken(ctx, operations.ExchangeAPIKeyTokenRequestBody{
        Audience: "https://medium-haversack.info/",
        ExternalUserID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `body`                                                                                                 | [operations.ExchangeAPIKeyTokenRequestBody](../../models/operations/exchangeapikeytokenrequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `xOnBehalfOf`                                                                                          | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.ExchangeAPIKeyTokenResponse](../../models/operations/exchangeapikeytokenresponse.md), error**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| apierrors.ExchangeAPIKeyTokenBadRequestError      | 400                                               | application/json                                  |
| apierrors.ExchangeAPIKeyTokenUnauthorizedError    | 401                                               | application/json                                  |
| apierrors.ExchangeAPIKeyTokenForbiddenError       | 403                                               | application/json                                  |
| apierrors.ExchangeAPIKeyTokenNotFoundError        | 404                                               | application/json                                  |
| apierrors.ExchangeAPIKeyTokenConflictError        | 409                                               | application/json                                  |
| apierrors.ExchangeAPIKeyTokenGoneError            | 410                                               | application/json                                  |
| apierrors.ExchangeAPIKeyTokenTooManyRequestsError | 429                                               | application/json                                  |
| apierrors.APIError                                | 4XX, 5XX                                          | \*/\*                                             |