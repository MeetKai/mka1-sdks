# Flags

## Overview

### Available Operations

* [List](#list) - List flags
* [Create](#create) - Create a flag
* [Delete](#delete) - Delete a flag and its settings in every environment
* [Get](#get) - Get a flag
* [Update](#update) - Update a flag's name, description, default value, or project
* [Archive](#archive) - Archive a flag
* [SetEnvironmentState](#setenvironmentstate) - Replace a flag's settings in one environment
* [Unarchive](#unarchive) - Restore an archived flag

## List

Every flag with a per-environment digest of its state.

### Example Usage

<!-- UsageSnippet language="go" operationID="listFeatureFlags" method="get" path="/api/v1/flags" -->
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

    res, err := s.Flags.List(ctx, mka1.Pointer(false), nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagListItems != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `ctx`                                                                         | [context.Context](https://pkg.go.dev/context#Context)                         | :heavy_check_mark:                                                            | The context to use for the request.                                           |
| `includeArchived`                                                             | `*bool`                                                                       | :heavy_minus_sign:                                                            | N/A                                                                           |
| `projectID`                                                                   | `*string`                                                                     | :heavy_minus_sign:                                                            | Return only flags assigned to this project. Flag keys remain globally unique. |
| `xOnBehalfOf`                                                                 | `*string`                                                                     | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |
| `opts`                                                                        | [][operations.Option](../../models/operations/option.md)                      | :heavy_minus_sign:                                                            | The options for this request.                                                 |

### Response

**[*operations.ListFeatureFlagsResponse](../../models/operations/listfeatureflagsresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403, 404         | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Create

The flag starts disabled in every environment and belongs to Default when project_id is omitted.

### Example Usage

<!-- UsageSnippet language="go" operationID="createFeatureFlag" method="post" path="/api/v1/flags" -->
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

    res, err := s.Flags.Create(ctx, components.FeatureFlagCreateRequest{
        DefaultValue: "<value>",
        Key: "<key>",
        Name: "<value>",
        ValueType: components.FeatureFlagValueTypeBoolean,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagDetail != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `body`                                                                                     | [components.FeatureFlagCreateRequest](../../models/components/featureflagcreaterequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.CreateFeatureFlagResponse](../../models/operations/createfeatureflagresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403, 404, 409    | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Delete

Delete a flag and its settings in every environment

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteFeatureFlag" method="delete" path="/api/v1/flags/{key}" -->
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

    res, err := s.Flags.Delete(ctx, "<key>", nil)
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
| `key`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteFeatureFlagResponse](../../models/operations/deletefeatureflagresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Get

Get a flag

### Example Usage

<!-- UsageSnippet language="go" operationID="getFeatureFlag" method="get" path="/api/v1/flags/{key}" -->
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

    res, err := s.Flags.Get(ctx, "<key>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagDetail != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `key`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetFeatureFlagResponse](../../models/operations/getfeatureflagresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Update

Update a flag's name, description, default value, or project

### Example Usage

<!-- UsageSnippet language="go" operationID="updateFeatureFlag" method="patch" path="/api/v1/flags/{key}" -->
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

    res, err := s.Flags.Update(ctx, "<key>", components.FeatureFlagUpdateRequest{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagDetail != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `key`                                                                                      | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `body`                                                                                     | [components.FeatureFlagUpdateRequest](../../models/components/featureflagupdaterequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.UpdateFeatureFlagResponse](../../models/operations/updatefeatureflagresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403, 404         | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Archive

Archived flags are excluded from evaluation in every environment; their settings are kept.

### Example Usage

<!-- UsageSnippet language="go" operationID="archiveFeatureFlag" method="post" path="/api/v1/flags/{key}/archive" -->
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

    res, err := s.Flags.Archive(ctx, "<key>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagDetail != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `key`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ArchiveFeatureFlagResponse](../../models/operations/archivefeatureflagresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## SetEnvironmentState

Replace a flag's settings in one environment

### Example Usage

<!-- UsageSnippet language="go" operationID="setFeatureFlagEnvironmentState" method="put" path="/api/v1/flags/{key}/environments/{env}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Flags.SetEnvironmentState(ctx, operations.SetFeatureFlagEnvironmentStateRequest{
        Key: "<key>",
        Env: "<value>",
        Body: components.FeatureFlagStateInput{
            Enabled: true,
            Overrides: []components.FeatureFlagOverride{
                components.FeatureFlagOverride{
                    Enabled: true,
                    Identity: "<value>",
                },
            },
            RolloutPercentage: 29814,
            Rules: []components.FeatureFlagRule{
                components.FeatureFlagRule{
                    Conditions: []components.FeatureFlagCondition{},
                    Enabled: false,
                },
            },
            Value: "<value>",
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagState != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                            | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                                | :heavy_check_mark:                                                                                                   | The context to use for the request.                                                                                  |
| `request`                                                                                                            | [operations.SetFeatureFlagEnvironmentStateRequest](../../models/operations/setfeatureflagenvironmentstaterequest.md) | :heavy_check_mark:                                                                                                   | The request object to use for the request.                                                                           |
| `opts`                                                                                                               | [][operations.Option](../../models/operations/option.md)                                                             | :heavy_minus_sign:                                                                                                   | The options for this request.                                                                                        |

### Response

**[*operations.SetFeatureFlagEnvironmentStateResponse](../../models/operations/setfeatureflagenvironmentstateresponse.md), error**

### Errors

| Error Type                   | Status Code                  | Content Type                 |
| ---------------------------- | ---------------------------- | ---------------------------- |
| apierrors.FeatureFlagError   | 400, 401, 403, 404, 409, 412 | application/json             |
| apierrors.APIError           | 4XX, 5XX                     | \*/\*                        |

## Unarchive

Restore an archived flag

### Example Usage

<!-- UsageSnippet language="go" operationID="unarchiveFeatureFlag" method="post" path="/api/v1/flags/{key}/unarchive" -->
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

    res, err := s.Flags.Unarchive(ctx, "<key>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagDetail != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `key`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.UnarchiveFeatureFlagResponse](../../models/operations/unarchivefeatureflagresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |