# Llm.Secrets

## Overview

### Available Operations

* [Create](#create) - Create secret
* [List](#list) - List secrets
* [Get](#get) - Retrieve secret
* [Update](#update) - Update or rotate secret
* [Delete](#delete) - Delete secret

## Create

Stores an encrypted, user-owned secret bound to an exact DNS hostname for HTTPS egress-proxy injection in Shell and tool runs. The secret value is write-only and never returned after creation.

### Example Usage

<!-- UsageSnippet language="go" operationID="createSecret" method="post" path="/api/v1/llm/secrets" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Secrets.Create(ctx, components.CreateSecretRequest{
        Name: "Audit log export key",
        Domain: "apigw.mka1.com",
        Value: "mk-example-secret-token",
        Description: optionalnullable.From(mka1.Pointer("Read-only key for audit feed queries")),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Secret != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |
| `body`                                                                           | [components.CreateSecretRequest](../../models/components/createsecretrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |

### Response

**[*operations.CreateSecretResponse](../../models/operations/createsecretresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Lists domain-scoped secrets owned by the authenticated user context, returning masked previews only.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSecrets" method="get" path="/api/v1/llm/secrets" -->
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

    res, err := s.Llm.Secrets.List(ctx, operations.ListSecretsRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.SecretList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `request`                                                                      | [operations.ListSecretsRequest](../../models/operations/listsecretsrequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.ListSecretsResponse](../../models/operations/listsecretsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Returns metadata and a masked preview for a user-owned secret.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSecret" method="get" path="/api/v1/llm/secrets/{secret_id}" -->
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

    res, err := s.Llm.Secrets.Get(ctx, "sec_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Secret != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `secretID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | sec_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSecretResponse](../../models/operations/getsecretresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Partially updates a user-owned secret's metadata, bound domain, expiration, or rotates its encrypted value. Omit value to keep the existing secret value.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateSecret" method="post" path="/api/v1/llm/secrets/{secret_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Secrets.Update(ctx, "sec_aa87e2b1112a455b8deabed784372198", components.UpdateSecretRequest{
        Name: mka1.Pointer("Audit log export key"),
        Value: mka1.Pointer("mk-rotated-secret-token"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Secret != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      | Example                                                                          |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |                                                                                  |
| `secretID`                                                                       | `string`                                                                         | :heavy_check_mark:                                                               | N/A                                                                              | sec_aa87e2b1112a455b8deabed784372198                                             |
| `body`                                                                           | [components.UpdateSecretRequest](../../models/components/updatesecretrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |                                                                                  |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |                                                                                  |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |                                                                                  |

### Response

**[*operations.UpdateSecretResponse](../../models/operations/updatesecretresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Permanently deletes a user-owned secret and its encrypted value.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteSecret" method="delete" path="/api/v1/llm/secrets/{secret_id}" -->
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

    res, err := s.Llm.Secrets.Delete(ctx, "sec_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SecretDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `secretID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | sec_aa87e2b1112a455b8deabed784372198                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteSecretResponse](../../models/operations/deletesecretresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |