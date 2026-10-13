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

<!-- UsageSnippet language="csharp" operationID="listRepoTags" method="get" path="/api/v1/repos/{org}/{name}/tags" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Repos.Tags.ListAsync(
    org: "<value>",
    name: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Org`                                                               | *string*                                                            | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `Name`                                                              | *string*                                                            | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListRepoTagsResponse](../../Types/Requests/ListRepoTagsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.RepoError    | 401, 403, 404                          | application/json                       |
| MeetKai.MKA1.Types.Errors.RepoError    | 500                                    | application/json                       |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

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

<!-- UsageSnippet language="csharp" operationID="deleteRepoTag" method="delete" path="/api/v1/repos/{org}/{name}/tags/{tag}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Repos.Tags.DeleteAsync(
    org: "<value>",
    name: "<value>",
    tag: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Org`                                                               | *string*                                                            | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `Name`                                                              | *string*                                                            | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `Tag`                                                               | *string*                                                            | :heavy_check_mark:                                                  | The image tag, exactly as pushed (tags are case-sensitive).         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteRepoTagResponse](../../Types/Requests/DeleteRepoTagResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.RepoError    | 401, 403, 404                          | application/json                       |
| MeetKai.MKA1.Types.Errors.RepoError    | 500                                    | application/json                       |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |