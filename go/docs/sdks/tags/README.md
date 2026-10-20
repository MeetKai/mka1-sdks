# Repos.Tags

## Overview

### Available Operations

* [List](#list) - List an image repository's tags
* [Delete](#delete) - Delete an image tag

## List

Lists the container-image tags a repository holds, newest-moved first,
each with the manifest it points at, the manifest's media type, the
image's declared size and when the tag last moved. The same access
check as reading the repository (org owner/admin; `read:repos` for a
key).

It is a fact about what the repository HOLDS, not about its `kind`:
a `model` lists `[]`, and a legacy `kind: null` repository that still
holds images lists them — those are the tags a `409 kind_has_content`
on PATCH is about, and deleting them through this API is what makes
that PATCH go through.

One page, of at most 1000 tags; `truncated` says whether the
repository holds more. The registry's own `GET /v2/{org}/{name}/tags/list`
is the paginated, names-only listing every OCI client speaks.


### Example Usage

<!-- UsageSnippet language="go" operationID="listRepoTags" method="get" path="/api/v1/repos/{org}/{name}/tags" -->
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

    res, err := s.Repos.Tags.List(ctx, "<value>", "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.RepoTagList != nil {
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

**[*operations.ListRepoTagsResponse](../../models/operations/listrepotagsresponse.md), error**

### Errors

| Error Type          | Status Code         | Content Type        |
| ------------------- | ------------------- | ------------------- |
| apierrors.RepoError | 401, 403, 404       | application/json    |
| apierrors.RepoError | 500                 | application/json    |
| apierrors.APIError  | 4XX, 5XX            | \*/\*               |

## Delete

Removes one tag; org owner/admin only (`write:repos` for a key). The
same untag as the registry's `DELETE /v2/{org}/{name}/manifests/{tag}`:
the name goes and the image stays, reachable by digest and by any
other tag that names it.

What makes a repository convertible afterwards is the kind switch
itself: `PATCH` to another `kind` first collects every image no tag
reaches (a multi-arch index's per-platform images included) and is
refused with `409 kind_has_content` only for images a tag still
names. So delete the tags the listing shows, then switch.


### Example Usage

<!-- UsageSnippet language="go" operationID="deleteRepoTag" method="delete" path="/api/v1/repos/{org}/{name}/tags/{tag}" -->
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

    res, err := s.Repos.Tags.Delete(ctx, "<value>", "<value>", "<value>", nil)
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
| `tag`                                                               | `string`                                                            | :heavy_check_mark:                                                  | The image tag, exactly as pushed (tags are case-sensitive).         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteRepoTagResponse](../../models/operations/deleterepotagresponse.md), error**

### Errors

| Error Type          | Status Code         | Content Type        |
| ------------------- | ------------------- | ------------------- |
| apierrors.RepoError | 401, 403, 404       | application/json    |
| apierrors.RepoError | 500                 | application/json    |
| apierrors.APIError  | 4XX, 5XX            | \*/\*               |