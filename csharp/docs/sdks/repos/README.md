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

<!-- UsageSnippet language="csharp" operationID="listRepos" method="get" path="/api/v1/repos" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Repos.ListAsync();

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Kind`                                                                                | [RepoKind](../../Types/Components/RepoKind.md)                                        | :heavy_minus_sign:                                                                    | Narrow the listing to one kind. Omit it for every repository,<br/>untyped ones included.<br/> |
| `XOnBehalfOf`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |

### Response

**[ListReposResponse](../../Types/Requests/ListReposResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.RepoError    | 400, 401, 403                          | application/json                       |
| MeetKai.MKA1.Types.Errors.RepoError    | 500, 503                               | application/json                       |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Create

Provisions a repository (org owner/admin only); a failed provision is
rolled back best-effort (see the `502`). The repository belongs to the
caller's org. `kind` says what it will hold and defaults to `repo` (a
plain git repository); it decides which protocol planes answer for the
name (see the `Repo` schema).


### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepo" method="post" path="/api/v1/repos" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Repos.CreateAsync(body: new MeetKai.MKA1.Types.Components.CreateRepoRequest() {
    Name = "my-model",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `Body`                                                                            | [Types.Components.CreateRepoRequest](../../Types/Components/CreateRepoRequest.md) | :heavy_check_mark:                                                                | N/A                                                                               |
| `XOnBehalfOf`                                                                     | *string*                                                                          | :heavy_minus_sign:                                                                | Optional external end-user identifier forwarded by the API gateway.               |

### Response

**[CreateRepoResponse](../../Types/Requests/CreateRepoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.RepoError    | 400, 401, 403, 409                     | application/json                       |
| MeetKai.MKA1.Types.Errors.RepoError    | 500, 502, 503                          | application/json                       |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Removes a repository; org owner/admin only. The deletion is
authoritative; the contents are cleaned up best-effort.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteRepo" method="delete" path="/api/v1/repos/{org}/{name}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Repos.DeleteAsync(
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

**[DeleteRepoResponse](../../Types/Requests/DeleteRepoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.RepoError    | 401, 403, 404                          | application/json                       |
| MeetKai.MKA1.Types.Errors.RepoError    | 500                                    | application/json                       |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Reads a single repository after the org+role access check (org
owner/admin of the repository's org only).


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepo" method="get" path="/api/v1/repos/{org}/{name}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Repos.GetAsync(
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

**[GetRepoResponse](../../Types/Requests/GetRepoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.RepoError    | 401, 403, 404                          | application/json                       |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

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

<!-- UsageSnippet language="csharp" operationID="patchRepo" method="patch" path="/api/v1/repos/{org}/{name}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Repos.UpdateAsync(
    org: "<value>",
    name: "<value>",
    body: new MeetKai.MKA1.Types.Components.PatchRepoRequest() {}
);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `Org`                                                                           | *string*                                                                        | :heavy_check_mark:                                                              | The organization URL slug.                                                      |
| `Name`                                                                          | *string*                                                                        | :heavy_check_mark:                                                              | The repository name (URL label).                                                |
| `Body`                                                                          | [Types.Components.PatchRepoRequest](../../Types/Components/PatchRepoRequest.md) | :heavy_check_mark:                                                              | N/A                                                                             |
| `XOnBehalfOf`                                                                   | *string*                                                                        | :heavy_minus_sign:                                                              | Optional external end-user identifier forwarded by the API gateway.             |

### Response

**[PatchRepoResponse](../../Types/Requests/PatchRepoResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.RepoError    | 400, 401, 403, 404, 409                | application/json                       |
| MeetKai.MKA1.Types.Errors.RepoError    | 500                                    | application/json                       |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |