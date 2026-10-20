# Analytics.Projects

## Overview

Create, list, rename, and archive analytics projects.

### Available Operations

* [Create](#create) - Create an analytics project
* [List](#list) - List accessible analytics projects
* [Get](#get) - Get an analytics project
* [Update](#update) - Rename an active analytics project
* [Archive](#archive) - Archive an analytics project

## Create

Create a project in the caller's organization. Without team_id the project belongs to the authenticated team. Organization owners and admins can create a project for any team in their organization, including teams they are not a member of, or pass team_id: null for an organization-level project. Service accounts can only create projects for their own team; any other team_id returns 403. team_id is trimmed. Ownership cannot be changed after creation.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_projects_create" method="post" path="/api/v1/analytics/projects" -->
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

    res, err := s.Analytics.Projects.Create(ctx, components.AnalyticsProjectCreate{
        Name: "<value>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsProject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `request`                                                                              | [components.AnalyticsProjectCreate](../../models/components/analyticsprojectcreate.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.AnalyticsProjectsCreateResponse](../../models/operations/analyticsprojectscreateresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |

## List

Organization owners and admins see every project in their organization: all teams' projects and organization-level projects, regardless of their active team. This also applies to an owner's or admin's API keys and exchanged JWTs, whichever team the key was issued for; use a service account for a team-confined credential. Service accounts see only their own team's projects. team_id and ownership narrow that set and never widen it, so filtering by a team the caller cannot access returns an empty list. ownership=organization combined with team_id returns 400. Unknown or repeated query parameters also return 400.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_projects_list" method="get" path="/api/v1/analytics/projects" -->
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

    res, err := s.Analytics.Projects.List(ctx, operations.AnalyticsProjectsListRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsProjectList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `request`                                                                                          | [operations.AnalyticsProjectsListRequest](../../models/operations/analyticsprojectslistrequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.AnalyticsProjectsListResponse](../../models/operations/analyticsprojectslistresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |

## Get

Get an analytics project

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_projects_get" method="get" path="/api/v1/analytics/projects/{id}" -->
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

    res, err := s.Analytics.Projects.Get(ctx, "<id>")
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsProject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | ID of the analytics project.                             |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.AnalyticsProjectsGetResponse](../../models/operations/analyticsprojectsgetresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |

## Update

Rename an active project. Project ownership cannot be changed.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_projects_update" method="patch" path="/api/v1/analytics/projects/{id}" -->
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

    res, err := s.Analytics.Projects.Update(ctx, "<id>", components.AnalyticsProjectUpdate{
        Name: "<value>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsProject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `id`                                                                                   | `string`                                                                               | :heavy_check_mark:                                                                     | ID of the analytics project.                                                           |
| `body`                                                                                 | [components.AnalyticsProjectUpdate](../../models/components/analyticsprojectupdate.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.AnalyticsProjectsUpdateResponse](../../models/operations/analyticsprojectsupdateresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |

## Archive

Stop new captures and queries for this project. Previously accepted events continue processing. Archiving does not delete stored events.

### Example Usage

<!-- UsageSnippet language="go" operationID="analytics_projects_archive" method="delete" path="/api/v1/analytics/projects/{id}" -->
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

    res, err := s.Analytics.Projects.Archive(ctx, "<id>")
    if err != nil {
        log.Fatal(err)
    }
    if res.AnalyticsProject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | ID of the analytics project.                             |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.AnalyticsProjectsArchiveResponse](../../models/operations/analyticsprojectsarchiveresponse.md), error**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| apierrors.AnalyticsError               | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| apierrors.AnalyticsError               | 500, 503                               | application/json                       |
| apierrors.APIError                     | 4XX, 5XX                               | \*/\*                                  |