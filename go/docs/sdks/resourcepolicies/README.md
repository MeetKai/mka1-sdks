# Sandbox.ResourcePolicies

## Overview

### Available Operations

* [Get](#get) - Get Tenant Resource Policy
* [Set](#set) - Set Tenant Resource Policy

## Get

Read organization or team resource limits for standard sandbox sessions.

### Example Usage

<!-- UsageSnippet language="go" operationID="getTenantResourcePolicy" method="get" path="/api/v1/sandbox/resource-policy/{scope}" -->
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

    res, err := s.Sandbox.ResourcePolicies.Get(ctx, operations.GetTenantResourcePolicyScopeTeam, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TenantResourcePolicy != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `scope`                                                                                            | [operations.GetTenantResourcePolicyScope](../../models/operations/gettenantresourcepolicyscope.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `expectedOrganizationID`                                                                           | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `expectedTeamID`                                                                                   | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.GetTenantResourcePolicyResponse](../../models/operations/gettenantresourcepolicyresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Set

Update organization or team resource limits for standard sandbox sessions. The expected revision rejects stale writes.

### Example Usage

<!-- UsageSnippet language="go" operationID="setTenantResourcePolicy" method="put" path="/api/v1/sandbox/resource-policy/{scope}" -->
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

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.ResourcePolicies.Set(ctx, operations.SetTenantResourcePolicyRequest{
        Scope: operations.SetTenantResourcePolicyScopeOrganization,
        ExpectedOrganizationID: "<id>",
        ExpectedTeamID: "<id>",
        Body: components.SaveTenantResourcePolicy{
            ExpectedRevision: 934537,
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.TenantResourcePolicy != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `request`                                                                                              | [operations.SetTenantResourcePolicyRequest](../../models/operations/settenantresourcepolicyrequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.SetTenantResourcePolicyResponse](../../models/operations/settenantresourcepolicyresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |