# Flags.Environments

## Overview

### Available Operations

* [List](#list) - List environments
* [Create](#create) - Create an environment
* [Delete](#delete) - Delete an environment and every flag setting in it
* [Update](#update) - Rename an environment
* [Evaluate](#evaluate) - Evaluate every flag for an identity
* [EvaluateWithTraits](#evaluatewithtraits) - Evaluate every flag for an identity with traits
* [RevokeEvaluationKey](#revokeevaluationkey) - Revoke an environment evaluation key
* [GenerateEvaluationKey](#generateevaluationkey) - Generate or replace an environment evaluation key

## List

List environments

### Example Usage

<!-- UsageSnippet language="go" operationID="listFeatureFlagEnvironments" method="get" path="/api/v1/flags/environments" -->
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

    res, err := s.Flags.Environments.List(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagEnvironments != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListFeatureFlagEnvironmentsResponse](../../models/operations/listfeatureflagenvironmentsresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403                   | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Create

Every existing flag gets a disabled state in the new environment.

### Example Usage

<!-- UsageSnippet language="go" operationID="createFeatureFlagEnvironment" method="post" path="/api/v1/flags/environments" -->
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

    res, err := s.Flags.Environments.Create(ctx, components.FeatureFlagEnvironmentCreateRequest{
        Key: "<key>",
        Name: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagEnvironment != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |
| `body`                                                                                                           | [components.FeatureFlagEnvironmentCreateRequest](../../models/components/featureflagenvironmentcreaterequest.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `xOnBehalfOf`                                                                                                    | `*string`                                                                                                        | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |

### Response

**[*operations.CreateFeatureFlagEnvironmentResponse](../../models/operations/createfeatureflagenvironmentresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403, 409         | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Delete

Delete an environment and every flag setting in it

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteFeatureFlagEnvironment" method="delete" path="/api/v1/flags/environments/{env}" -->
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

    res, err := s.Flags.Environments.Delete(ctx, "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `env`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteFeatureFlagEnvironmentResponse](../../models/operations/deletefeatureflagenvironmentresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Update

Rename an environment

### Example Usage

<!-- UsageSnippet language="go" operationID="updateFeatureFlagEnvironment" method="patch" path="/api/v1/flags/environments/{env}" -->
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

    res, err := s.Flags.Environments.Update(ctx, "<value>", components.FeatureFlagEnvironmentUpdateRequest{
        Name: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagEnvironment != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |
| `env`                                                                                                            | `string`                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `body`                                                                                                           | [components.FeatureFlagEnvironmentUpdateRequest](../../models/components/featureflagenvironmentupdaterequest.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `xOnBehalfOf`                                                                                                    | `*string`                                                                                                        | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |

### Response

**[*operations.UpdateFeatureFlagEnvironmentResponse](../../models/operations/updatefeatureflagenvironmentresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403, 404         | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Evaluate

Resolves every non-archived flag of the environment for an anonymous caller, or for the identity given in the query. Sends an ETag and answers 304 to a matching If-None-Match after authenticating the environment evaluation key.

### Example Usage

<!-- UsageSnippet language="go" operationID="evaluateFeatureFlags" method="get" path="/api/v1/flags/environments/{env}/evaluate" -->
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

    s := mka1.New()

    res, err := s.Flags.Environments.Evaluate(ctx, operations.EvaluateFeatureFlagsSecurity{
        EvaluationKeyAuth: "<YOUR_BEARER_TOKEN_HERE>",
    }, "<value>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagEvaluateResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `security`                                                                                         | [operations.EvaluateFeatureFlagsSecurity](../../models/operations/evaluatefeatureflagssecurity.md) | :heavy_check_mark:                                                                                 | The security requirements to use for the request.                                                  |
| `env`                                                                                              | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `identity`                                                                                         | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Stable identifier of the caller; enables rollouts and overrides.                                   |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.EvaluateFeatureFlagsResponse](../../models/operations/evaluatefeatureflagsresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401                        | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## EvaluateWithTraits

Evaluate every flag for an identity with traits

### Example Usage

<!-- UsageSnippet language="go" operationID="evaluateFeatureFlagsWithTraits" method="post" path="/api/v1/flags/environments/{env}/evaluate" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Flags.Environments.EvaluateWithTraits(ctx, operations.EvaluateFeatureFlagsWithTraitsSecurity{
        EvaluationKeyAuth: "<YOUR_BEARER_TOKEN_HERE>",
    }, "<value>", components.FeatureFlagEvaluateRequest{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagEvaluateResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                  | :heavy_check_mark:                                                                                                     | The context to use for the request.                                                                                    |
| `security`                                                                                                             | [operations.EvaluateFeatureFlagsWithTraitsSecurity](../../models/operations/evaluatefeatureflagswithtraitssecurity.md) | :heavy_check_mark:                                                                                                     | The security requirements to use for the request.                                                                      |
| `env`                                                                                                                  | `string`                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `body`                                                                                                                 | [components.FeatureFlagEvaluateRequest](../../models/components/featureflagevaluaterequest.md)                         | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `xOnBehalfOf`                                                                                                          | `*string`                                                                                                              | :heavy_minus_sign:                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                    |
| `opts`                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                               | :heavy_minus_sign:                                                                                                     | The options for this request.                                                                                          |

### Response

**[*operations.EvaluateFeatureFlagsWithTraitsResponse](../../models/operations/evaluatefeatureflagswithtraitsresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401                   | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## RevokeEvaluationKey

Revocation is idempotent while the environment exists.

### Example Usage

<!-- UsageSnippet language="go" operationID="revokeFeatureFlagEvaluationKey" method="delete" path="/api/v1/flags/environments/{env}/evaluation-key" -->
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

    res, err := s.Flags.Environments.RevokeEvaluationKey(ctx, "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `env`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.RevokeFeatureFlagEvaluationKeyResponse](../../models/operations/revokefeatureflagevaluationkeyresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## GenerateEvaluationKey

Returns the new plaintext key once. Only its SHA-256 digest and a display hint are stored; generating another key immediately replaces the previous credential on this replica.

### Example Usage

<!-- UsageSnippet language="go" operationID="generateFeatureFlagEvaluationKey" method="post" path="/api/v1/flags/environments/{env}/evaluation-key" -->
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

    res, err := s.Flags.Environments.GenerateEvaluationKey(ctx, "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagEvaluationKeyResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `env`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GenerateFeatureFlagEvaluationKeyResponse](../../models/operations/generatefeatureflagevaluationkeyresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |