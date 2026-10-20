# Sandbox.NetworkPolicies

## Overview

### Available Operations

* [Effective](#effective) - Get Effective Network Policy
* [Get](#get) - Get Tenant Network Policy
* [Set](#set) - Set Tenant Network Policy

## Effective

Intersect the authenticated tenant's organization and team hostname allowlists.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEffectiveNetworkPolicy" method="get" path="/api/v1/sandbox/network-policy" -->
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

    res, err := s.Sandbox.NetworkPolicies.Effective(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EffectiveNetworkPolicy != nil {
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

**[*operations.GetEffectiveNetworkPolicyResponse](../../models/operations/geteffectivenetworkpolicyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Read the authenticated tenant policy; optional expected IDs reject workspace changes, never select tenancy.

### Example Usage

<!-- UsageSnippet language="go" operationID="getTenantNetworkPolicy" method="get" path="/api/v1/sandbox/network-policy/{scope}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.NetworkPolicies.Get(ctx, operations.GetTenantNetworkPolicyScopeOrganization, optionalnullable.From[string](nil), optionalnullable.From[string](nil), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TenantNetworkPolicy != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |                                                                                                  |
| `scope`                                                                                          | [operations.GetTenantNetworkPolicyScope](../../models/operations/gettenantnetworkpolicyscope.md) | :heavy_check_mark:                                                                               | N/A                                                                                              | organization                                                                                     |
| `expectedOrganizationID`                                                                         | optionalnullable.OptionalNullable[`string`]                                                      | :heavy_minus_sign:                                                                               | N/A                                                                                              |                                                                                                  |
| `expectedTeamID`                                                                                 | optionalnullable.OptionalNullable[`string`]                                                      | :heavy_minus_sign:                                                                               | N/A                                                                                              |                                                                                                  |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |                                                                                                  |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |                                                                                                  |

### Response

**[*operations.GetTenantNetworkPolicyResponse](../../models/operations/gettenantnetworkpolicyresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Set

Administrator-only update with optimistic revision checking. An enabled empty list denies all outbound hosts.

### Example Usage

<!-- UsageSnippet language="go" operationID="setTenantNetworkPolicy" method="put" path="/api/v1/sandbox/network-policy/{scope}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.NetworkPolicies.Set(ctx, operations.SetTenantNetworkPolicyScopeOrganization, components.SaveTenantNetworkPolicy{
        Enabled: true,
        AllowedDomains: []string{
            "example.com",
        },
        ExpectedRevision: 0,
    }, optionalnullable.From[string](nil), optionalnullable.From[string](nil))
    if err != nil {
        log.Fatal(err)
    }
    if res.TenantNetworkPolicy != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |                                                                                                  |
| `scope`                                                                                          | [operations.SetTenantNetworkPolicyScope](../../models/operations/settenantnetworkpolicyscope.md) | :heavy_check_mark:                                                                               | N/A                                                                                              | organization                                                                                     |
| `body`                                                                                           | [components.SaveTenantNetworkPolicy](../../models/components/savetenantnetworkpolicy.md)         | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `expectedOrganizationID`                                                                         | optionalnullable.OptionalNullable[`string`]                                                      | :heavy_minus_sign:                                                                               | N/A                                                                                              |                                                                                                  |
| `expectedTeamID`                                                                                 | optionalnullable.OptionalNullable[`string`]                                                      | :heavy_minus_sign:                                                                               | N/A                                                                                              |                                                                                                  |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |                                                                                                  |

### Response

**[*operations.SetTenantNetworkPolicyResponse](../../models/operations/settenantnetworkpolicyresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |