# Auth.ServiceAccounts

## Overview

### Available Operations

* [Create](#create) - Create a service account
* [List](#list) - List service accounts
* [Get](#get) - Get a service account
* [Delete](#delete) - Delete a service account
* [ListAPIKeys](#listapikeys) - List a service account's API keys
* [UpdateAPIKey](#updateapikey) - Update a service-account API key
* [DeleteAPIKey](#deleteapikey) - Delete a service-account API key
* [RegenerateAPIKey](#regenerateapikey) - Rotate a service-account API key's secret

## Create

Mint a non-human principal scoped to this org (org owner/admin only).

### Example Usage

<!-- UsageSnippet language="go" operationID="createServiceAccount" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
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

    res, err := s.Auth.ServiceAccounts.Create(ctx, "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                     | [context.Context](https://pkg.go.dev/context#Context)                                                     | :heavy_check_mark:                                                                                        | The context to use for the request.                                                                       |
| `orgID`                                                                                                   | `string`                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `xOnBehalfOf`                                                                                             | `*string`                                                                                                 | :heavy_minus_sign:                                                                                        | Optional external end-user identifier forwarded by the API gateway.                                       |
| `body`                                                                                                    | [*operations.CreateServiceAccountRequestBody](../../models/operations/createserviceaccountrequestbody.md) | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `opts`                                                                                                    | [][operations.Option](../../models/operations/option.md)                                                  | :heavy_minus_sign:                                                                                        | The options for this request.                                                                             |

### Response

**[*operations.CreateServiceAccountResponse](../../models/operations/createserviceaccountresponse.md), error**

### Errors

| Error Type                                         | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| apierrors.CreateServiceAccountBadRequestError      | 400                                                | application/json                                   |
| apierrors.CreateServiceAccountUnauthorizedError    | 401                                                | application/json                                   |
| apierrors.CreateServiceAccountForbiddenError       | 403                                                | application/json                                   |
| apierrors.CreateServiceAccountNotFoundError        | 404                                                | application/json                                   |
| apierrors.CreateServiceAccountConflictError        | 409                                                | application/json                                   |
| apierrors.CreateServiceAccountGoneError            | 410                                                | application/json                                   |
| apierrors.CreateServiceAccountTooManyRequestsError | 429                                                | application/json                                   |
| apierrors.APIError                                 | 4XX, 5XX                                           | \*/\*                                              |

## List

List service accounts

### Example Usage

<!-- UsageSnippet language="go" operationID="listServiceAccounts" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts" -->
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

    res, err := s.Auth.ServiceAccounts.List(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListServiceAccountsResponse](../../models/operations/listserviceaccountsresponse.md), error**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| apierrors.ListServiceAccountsBadRequestError      | 400                                               | application/json                                  |
| apierrors.ListServiceAccountsUnauthorizedError    | 401                                               | application/json                                  |
| apierrors.ListServiceAccountsForbiddenError       | 403                                               | application/json                                  |
| apierrors.ListServiceAccountsNotFoundError        | 404                                               | application/json                                  |
| apierrors.ListServiceAccountsConflictError        | 409                                               | application/json                                  |
| apierrors.ListServiceAccountsGoneError            | 410                                               | application/json                                  |
| apierrors.ListServiceAccountsTooManyRequestsError | 429                                               | application/json                                  |
| apierrors.APIError                                | 4XX, 5XX                                          | \*/\*                                             |

## Get

Get a service account

### Example Usage

<!-- UsageSnippet language="go" operationID="getServiceAccount" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
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

    res, err := s.Auth.ServiceAccounts.Get(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `saID`                                                              | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetServiceAccountResponse](../../models/operations/getserviceaccountresponse.md), error**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| apierrors.GetServiceAccountBadRequestError      | 400                                             | application/json                                |
| apierrors.GetServiceAccountUnauthorizedError    | 401                                             | application/json                                |
| apierrors.GetServiceAccountForbiddenError       | 403                                             | application/json                                |
| apierrors.GetServiceAccountNotFoundError        | 404                                             | application/json                                |
| apierrors.GetServiceAccountConflictError        | 409                                             | application/json                                |
| apierrors.GetServiceAccountGoneError            | 410                                             | application/json                                |
| apierrors.GetServiceAccountTooManyRequestsError | 429                                             | application/json                                |
| apierrors.APIError                              | 4XX, 5XX                                        | \*/\*                                           |

## Delete

Delete a service account

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteServiceAccount" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}" -->
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

    res, err := s.Auth.ServiceAccounts.Delete(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `saID`                                                              | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteServiceAccountResponse](../../models/operations/deleteserviceaccountresponse.md), error**

### Errors

| Error Type                                         | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| apierrors.DeleteServiceAccountBadRequestError      | 400                                                | application/json                                   |
| apierrors.DeleteServiceAccountUnauthorizedError    | 401                                                | application/json                                   |
| apierrors.DeleteServiceAccountForbiddenError       | 403                                                | application/json                                   |
| apierrors.DeleteServiceAccountNotFoundError        | 404                                                | application/json                                   |
| apierrors.DeleteServiceAccountConflictError        | 409                                                | application/json                                   |
| apierrors.DeleteServiceAccountGoneError            | 410                                                | application/json                                   |
| apierrors.DeleteServiceAccountTooManyRequestsError | 429                                                | application/json                                   |
| apierrors.APIError                                 | 4XX, 5XX                                           | \*/\*                                              |

## ListAPIKeys

List a service account's API keys

### Example Usage

<!-- UsageSnippet language="go" operationID="listServiceAccountApiKeys" method="get" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys" -->
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

    res, err := s.Auth.ServiceAccounts.ListAPIKeys(ctx, "<id>", "<id>", nil)
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
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `saID`                                                              | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListServiceAccountAPIKeysResponse](../../models/operations/listserviceaccountapikeysresponse.md), error**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| apierrors.ListServiceAccountAPIKeysBadRequestError      | 400                                                     | application/json                                        |
| apierrors.ListServiceAccountAPIKeysUnauthorizedError    | 401                                                     | application/json                                        |
| apierrors.ListServiceAccountAPIKeysForbiddenError       | 403                                                     | application/json                                        |
| apierrors.ListServiceAccountAPIKeysNotFoundError        | 404                                                     | application/json                                        |
| apierrors.ListServiceAccountAPIKeysConflictError        | 409                                                     | application/json                                        |
| apierrors.ListServiceAccountAPIKeysGoneError            | 410                                                     | application/json                                        |
| apierrors.ListServiceAccountAPIKeysTooManyRequestsError | 429                                                     | application/json                                        |
| apierrors.APIError                                      | 4XX, 5XX                                                | \*/\*                                                   |

## UpdateAPIKey

Update a service-account API key

### Example Usage

<!-- UsageSnippet language="go" operationID="updateServiceAccountApiKey" method="patch" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
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

    res, err := s.Auth.ServiceAccounts.UpdateAPIKey(ctx, operations.UpdateServiceAccountAPIKeyRequest{
        OrgID: "<id>",
        SaID: "<id>",
        KeyID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                        | :heavy_check_mark:                                                                                           | The context to use for the request.                                                                          |
| `request`                                                                                                    | [operations.UpdateServiceAccountAPIKeyRequest](../../models/operations/updateserviceaccountapikeyrequest.md) | :heavy_check_mark:                                                                                           | The request object to use for the request.                                                                   |
| `opts`                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                     | :heavy_minus_sign:                                                                                           | The options for this request.                                                                                |

### Response

**[*operations.UpdateServiceAccountAPIKeyResponse](../../models/operations/updateserviceaccountapikeyresponse.md), error**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| apierrors.UpdateServiceAccountAPIKeyBadRequestError      | 400                                                      | application/json                                         |
| apierrors.UpdateServiceAccountAPIKeyUnauthorizedError    | 401                                                      | application/json                                         |
| apierrors.UpdateServiceAccountAPIKeyForbiddenError       | 403                                                      | application/json                                         |
| apierrors.UpdateServiceAccountAPIKeyNotFoundError        | 404                                                      | application/json                                         |
| apierrors.UpdateServiceAccountAPIKeyConflictError        | 409                                                      | application/json                                         |
| apierrors.UpdateServiceAccountAPIKeyGoneError            | 410                                                      | application/json                                         |
| apierrors.UpdateServiceAccountAPIKeyTooManyRequestsError | 429                                                      | application/json                                         |
| apierrors.APIError                                       | 4XX, 5XX                                                 | \*/\*                                                    |

## DeleteAPIKey

Delete a service-account API key

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteServiceAccountApiKey" method="delete" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}" -->
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

    res, err := s.Auth.ServiceAccounts.DeleteAPIKey(ctx, "<id>", "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `saID`                                                              | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `keyID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteServiceAccountAPIKeyResponse](../../models/operations/deleteserviceaccountapikeyresponse.md), error**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| apierrors.DeleteServiceAccountAPIKeyBadRequestError      | 400                                                      | application/json                                         |
| apierrors.DeleteServiceAccountAPIKeyUnauthorizedError    | 401                                                      | application/json                                         |
| apierrors.DeleteServiceAccountAPIKeyForbiddenError       | 403                                                      | application/json                                         |
| apierrors.DeleteServiceAccountAPIKeyNotFoundError        | 404                                                      | application/json                                         |
| apierrors.DeleteServiceAccountAPIKeyConflictError        | 409                                                      | application/json                                         |
| apierrors.DeleteServiceAccountAPIKeyGoneError            | 410                                                      | application/json                                         |
| apierrors.DeleteServiceAccountAPIKeyTooManyRequestsError | 429                                                      | application/json                                         |
| apierrors.APIError                                       | 4XX, 5XX                                                 | \*/\*                                                    |

## RegenerateAPIKey

Rotate a service-account API key's secret

### Example Usage

<!-- UsageSnippet language="go" operationID="regenerateServiceAccountApiKey" method="post" path="/api/v1/authentication/orgs/{orgId}/service-accounts/{saId}/api-keys/{keyId}/regenerate" -->
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

    res, err := s.Auth.ServiceAccounts.RegenerateAPIKey(ctx, "<id>", "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `saID`                                                              | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `keyID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.RegenerateServiceAccountAPIKeyResponse](../../models/operations/regenerateserviceaccountapikeyresponse.md), error**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| apierrors.RegenerateServiceAccountAPIKeyBadRequestError      | 400                                                          | application/json                                             |
| apierrors.RegenerateServiceAccountAPIKeyUnauthorizedError    | 401                                                          | application/json                                             |
| apierrors.RegenerateServiceAccountAPIKeyForbiddenError       | 403                                                          | application/json                                             |
| apierrors.RegenerateServiceAccountAPIKeyNotFoundError        | 404                                                          | application/json                                             |
| apierrors.RegenerateServiceAccountAPIKeyConflictError        | 409                                                          | application/json                                             |
| apierrors.RegenerateServiceAccountAPIKeyGoneError            | 410                                                          | application/json                                             |
| apierrors.RegenerateServiceAccountAPIKeyTooManyRequestsError | 429                                                          | application/json                                             |
| apierrors.APIError                                           | 4XX, 5XX                                                     | \*/\*                                                        |