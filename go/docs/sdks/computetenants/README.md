# ComputeTenants

## Overview

### Available Operations

* [ListComputeTenants](#listcomputetenants) - List tenants
* [GetComputeTenant](#getcomputetenant) - Get a tenant
* [PutComputeTenant](#putcomputetenant) - Update a tenant

## ListComputeTenants

Cluster-administrator-only.

### Example Usage

<!-- UsageSnippet language="go" operationID="listComputeTenants" method="get" path="/api/v1/compute/tenants" -->
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

    res, err := s.ComputeTenants.ListComputeTenants(ctx, nil, nil, mka1.Pointer[int64](50), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeTenantList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `enabled`                                                           | `*bool`                                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `cursor`                                                            | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListComputeTenantsResponse](../../models/operations/listcomputetenantsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetComputeTenant

Cluster-administrator-only.

### Example Usage

<!-- UsageSnippet language="go" operationID="getComputeTenant" method="get" path="/api/v1/compute/tenants/{org_id}" -->
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

    res, err := s.ComputeTenants.GetComputeTenant(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeTenant != nil {
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

**[*operations.GetComputeTenantResponse](../../models/operations/getcomputetenantresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## PutComputeTenant

Cluster-administrator-only idempotent upsert.

### Example Usage

<!-- UsageSnippet language="go" operationID="putComputeTenant" method="put" path="/api/v1/compute/tenants/{org_id}" -->
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

    res, err := s.ComputeTenants.PutComputeTenant(ctx, "<id>", components.ComputeTenantUpdate{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeTenant != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |
| `orgID`                                                                          | `string`                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `body`                                                                           | [components.ComputeTenantUpdate](../../models/components/computetenantupdate.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |

### Response

**[*operations.PutComputeTenantResponse](../../models/operations/putcomputetenantresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |