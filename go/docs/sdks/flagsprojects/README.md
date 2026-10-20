# Flags.Projects

## Overview

### Available Operations

* [List](#list) - List projects
* [Create](#create) - Create a project
* [Delete](#delete) - Delete an empty project
* [Get](#get) - Get a project
* [Update](#update) - Rename a project

## List

List projects

### Example Usage

<!-- UsageSnippet language="go" operationID="listFeatureFlagProjects" method="get" path="/api/v1/flags/-/projects" -->
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

    res, err := s.Flags.Projects.List(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagProjects != nil {
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

**[*operations.ListFeatureFlagProjectsResponse](../../models/operations/listfeatureflagprojectsresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403                   | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Create

Create a project

### Example Usage

<!-- UsageSnippet language="go" operationID="createFeatureFlagProject" method="post" path="/api/v1/flags/-/projects" -->
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

    res, err := s.Flags.Projects.Create(ctx, components.FeatureFlagProjectCreateRequest{
        Key: "<key>",
        Name: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagProject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `body`                                                                                                   | [components.FeatureFlagProjectCreateRequest](../../models/components/featureflagprojectcreaterequest.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.CreateFeatureFlagProjectResponse](../../models/operations/createfeatureflagprojectresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403, 409         | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Delete

Default cannot be deleted. Move or delete every flag before deleting another project.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteFeatureFlagProject" method="delete" path="/api/v1/flags/-/projects/{project}" -->
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

    res, err := s.Flags.Projects.Delete(ctx, "<value>", nil)
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
| `project`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteFeatureFlagProjectResponse](../../models/operations/deletefeatureflagprojectresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404, 409         | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Get

Get a project

### Example Usage

<!-- UsageSnippet language="go" operationID="getFeatureFlagProject" method="get" path="/api/v1/flags/-/projects/{project}" -->
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

    res, err := s.Flags.Projects.Get(ctx, "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagProject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `project`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetFeatureFlagProjectResponse](../../models/operations/getfeatureflagprojectresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 401, 403, 404              | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |

## Update

Rename a project

### Example Usage

<!-- UsageSnippet language="go" operationID="updateFeatureFlagProject" method="patch" path="/api/v1/flags/-/projects/{project}" -->
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

    res, err := s.Flags.Projects.Update(ctx, "<value>", components.FeatureFlagProjectUpdateRequest{
        Name: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FeatureFlagProject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `project`                                                                                                | `string`                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `body`                                                                                                   | [components.FeatureFlagProjectUpdateRequest](../../models/components/featureflagprojectupdaterequest.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.UpdateFeatureFlagProjectResponse](../../models/operations/updatefeatureflagprojectresponse.md), error**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| apierrors.FeatureFlagError | 400, 401, 403, 404         | application/json           |
| apierrors.APIError         | 4XX, 5XX                   | \*/\*                      |