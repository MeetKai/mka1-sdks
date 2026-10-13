# Repos.Tags

## Overview

### Available Operations

* [list](#list) - List an image repository's tags
* [delete](#delete) - Delete an image tag

## list

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

<!-- UsageSnippet language="python" operationID="listRepoTags" method="get" path="/api/v1/repos/{org}/{name}/tags" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.repos.tags.list(org="<value>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org`                                                               | *str*                                                               | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RepoTagList](../../models/repotaglist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.RepoError       | 401, 403, 404          | application/json       |
| errors.RepoError       | 500                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

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

<!-- UsageSnippet language="python" operationID="deleteRepoTag" method="delete" path="/api/v1/repos/{org}/{name}/tags/{tag}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.repos.tags.delete(org="<value>", name="<value>", tag="<value>")

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org`                                                               | *str*                                                               | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `tag`                                                               | *str*                                                               | :heavy_check_mark:                                                  | The image tag, exactly as pushed (tags are case-sensitive).         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.RepoError       | 401, 403, 404          | application/json       |
| errors.RepoError       | 500                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |