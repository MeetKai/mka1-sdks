# Repos

## Overview

### Available Operations

* [List](#list) - List the caller's org's repositories
* [Create](#create) - Create a repository
* [Delete](#delete) - Delete a repository
* [Get](#get) - Get a repository
* [Update](#update) - Update a repository's labels

## List

Returns every repository in the caller's org (org owner/admin only).
Read-only. With `kind`, only repositories of that kind; an untyped
(legacy, `kind: null`) repository appears in the unfiltered listing
only.


### Example Usage

<!-- UsageSnippet language="go" operationID="listRepos" method="get" path="/api/v1/repos" -->
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

    res, err := s.Repos.List(ctx, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ctx`                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                 | :heavy_check_mark:                                                                    | The context to use for the request.                                                   |
| `kind`                                                                                | [*components.RepoKind](../../models/components/repokind.md)                           | :heavy_minus_sign:                                                                    | Narrow the listing to one kind. Omit it for every repository,<br/>untyped ones included.<br/> |
| `xOnBehalfOf`                                                                         | `*string`                                                                             | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `opts`                                                                                | [][operations.Option](../../models/operations/option.md)                              | :heavy_minus_sign:                                                                    | The options for this request.                                                         |

### Response

**[*operations.ListReposResponse](../../models/operations/listreposresponse.md), error**

### Errors

| Error Type          | Status Code         | Content Type        |
| ------------------- | ------------------- | ------------------- |
| apierrors.RepoError | 400, 401, 403       | application/json    |
| apierrors.RepoError | 500, 503            | application/json    |
| apierrors.APIError  | 4XX, 5XX            | \*/\*               |

## Create

Provisions a repository (org owner/admin only); a failed provision is
rolled back best-effort (see the `502`). The repository belongs to the
caller's org. `kind` says what it will hold and defaults to `repo` (a
plain git repository); it decides which protocol planes answer for the
name (see the `Repo` schema).


### Example Usage

<!-- UsageSnippet language="go" operationID="createRepo" method="post" path="/api/v1/repos" -->
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

    res, err := s.Repos.Create(ctx, components.CreateRepoRequest{
        Name: "my-model",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Repo != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `ctx`                                                                        | [context.Context](https://pkg.go.dev/context#Context)                        | :heavy_check_mark:                                                           | The context to use for the request.                                          |
| `body`                                                                       | [components.CreateRepoRequest](../../models/components/createreporequest.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `xOnBehalfOf`                                                                | `*string`                                                                    | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |
| `opts`                                                                       | [][operations.Option](../../models/operations/option.md)                     | :heavy_minus_sign:                                                           | The options for this request.                                                |

### Response

**[*operations.CreateRepoResponse](../../models/operations/createreporesponse.md), error**

### Errors

| Error Type          | Status Code         | Content Type        |
| ------------------- | ------------------- | ------------------- |
| apierrors.RepoError | 400, 401, 403, 409  | application/json    |
| apierrors.RepoError | 500, 502, 503       | application/json    |
| apierrors.APIError  | 4XX, 5XX            | \*/\*               |

## Delete

Removes a repository; org owner/admin only. The deletion is
authoritative; the contents are cleaned up best-effort.


### Example Usage

<!-- UsageSnippet language="go" operationID="deleteRepo" method="delete" path="/api/v1/repos/{org}/{name}" -->
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

    res, err := s.Repos.Delete(ctx, "<value>", "<value>", nil)
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
| `org`                                                               | `string`                                                            | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | `string`                                                            | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteRepoResponse](../../models/operations/deletereporesponse.md), error**

### Errors

| Error Type          | Status Code         | Content Type        |
| ------------------- | ------------------- | ------------------- |
| apierrors.RepoError | 401, 403, 404       | application/json    |
| apierrors.RepoError | 500                 | application/json    |
| apierrors.APIError  | 4XX, 5XX            | \*/\*               |

## Get

Reads a single repository after the org+role access check (org
owner/admin of the repository's org only).


### Example Usage

<!-- UsageSnippet language="go" operationID="getRepo" method="get" path="/api/v1/repos/{org}/{name}" -->
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

    res, err := s.Repos.Get(ctx, "<value>", "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Repo != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `org`                                                               | `string`                                                            | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | `string`                                                            | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetRepoResponse](../../models/operations/getreporesponse.md), error**

### Errors

| Error Type          | Status Code         | Content Type        |
| ------------------- | ------------------- | ------------------- |
| apierrors.RepoError | 401, 403, 404       | application/json    |
| apierrors.APIError  | 4XX, 5XX            | \*/\*               |

## Update

Applies a label-only update (name/description/kind); org owner/admin
only. The repository id is stable, so a rename touches no contents.
Omitted fields are left unchanged.

`kind` is the ONE way a repository's kind changes after creation (the
protocol planes never change it): it types a legacy `kind: null`
repository and corrects a wrong kind. `repo`, `model` and `dataset`
convert freely and any repository may become `image`; a repository
whose container images are still named by a tag can be given no
other kind — leaving `image`, or typing a legacy `null` repository as
anything else, is refused with `409 kind_has_content` (list and
delete the tags through this API first). A switch away from `image`
collects every image no tag reaches before it is judged, so an image
only ever pushed by digest, or untagged through the registry, never
blocks it. A kind is never un-set.


### Example Usage

<!-- UsageSnippet language="go" operationID="patchRepo" method="patch" path="/api/v1/repos/{org}/{name}" -->
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

    res, err := s.Repos.Update(ctx, "<value>", "<value>", components.PatchRepoRequest{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Repo != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `ctx`                                                                      | [context.Context](https://pkg.go.dev/context#Context)                      | :heavy_check_mark:                                                         | The context to use for the request.                                        |
| `org`                                                                      | `string`                                                                   | :heavy_check_mark:                                                         | The organization URL slug.                                                 |
| `name`                                                                     | `string`                                                                   | :heavy_check_mark:                                                         | The repository name (URL label).                                           |
| `body`                                                                     | [components.PatchRepoRequest](../../models/components/patchreporequest.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `xOnBehalfOf`                                                              | `*string`                                                                  | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |
| `opts`                                                                     | [][operations.Option](../../models/operations/option.md)                   | :heavy_minus_sign:                                                         | The options for this request.                                              |

### Response

**[*operations.PatchRepoResponse](../../models/operations/patchreporesponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.RepoError     | 400, 401, 403, 404, 409 | application/json        |
| apierrors.RepoError     | 500                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |