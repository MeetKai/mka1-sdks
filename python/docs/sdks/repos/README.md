# Repos

## Overview

### Available Operations

* [list](#list) - List the caller's org's repositories
* [create](#create) - Create a repository
* [delete](#delete) - Delete a repository
* [get](#get) - Get a repository
* [update](#update) - Update a repository's labels

## list

Returns every repository in the caller's org (org owner/admin only).
Read-only. With `kind`, only repositories of that kind; an untyped
(legacy, `kind: null`) repository appears in the unfiltered listing
only.


### Example Usage

<!-- UsageSnippet language="python" operationID="listRepos" method="get" path="/api/v1/repos" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.repos.list()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `kind`                                                                                | [Optional[models.RepoKind]](../../models/repokind.md)                                 | :heavy_minus_sign:                                                                    | Narrow the listing to one kind. Omit it for every repository,<br/>untyped ones included.<br/> |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |

### Response

**[models.ListReposResponse](../../models/listreposresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.RepoError       | 400, 401, 403          | application/json       |
| errors.RepoError       | 500, 503               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create

Provisions a repository (org owner/admin only); a failed provision is
rolled back best-effort (see the `502`). The repository belongs to the
caller's org. `kind` says what it will hold and defaults to `repo` (a
plain git repository); it decides which protocol planes answer for the
name (see the `Repo` schema).


### Example Usage

<!-- UsageSnippet language="python" operationID="createRepo" method="post" path="/api/v1/repos" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.repos.create(name="my-model", kind="repo")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 | Example                                                                                                     |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `name`                                                                                                      | *str*                                                                                                       | :heavy_check_mark:                                                                                          | The repository name. Must start with an alphanumeric character and<br/>be ≤100 characters of `[A-Za-z0-9._-]`.<br/> | my-model                                                                                                    |
| `x_on_behalf_of`                                                                                            | *Optional[str]*                                                                                             | :heavy_minus_sign:                                                                                          | Optional external end-user identifier forwarded by the API gateway.                                         |                                                                                                             |
| `description`                                                                                               | *Optional[str]*                                                                                             | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |                                                                                                             |
| `kind`                                                                                                      | [Optional[models.CreateRepoRequestKind]](../../models/createreporequestkind.md)                             | :heavy_minus_sign:                                                                                          | What the repository will hold. Defaults to `repo`.                                                          |                                                                                                             |
| `retries`                                                                                                   | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                            | :heavy_minus_sign:                                                                                          | Configuration to override the default retry behavior of the client.                                         |                                                                                                             |

### Response

**[models.Repo](../../models/repo.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.RepoError       | 400, 401, 403, 409     | application/json       |
| errors.RepoError       | 500, 502, 503          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

Removes a repository; org owner/admin only. The deletion is
authoritative; the contents are cleaned up best-effort.


### Example Usage

<!-- UsageSnippet language="python" operationID="deleteRepo" method="delete" path="/api/v1/repos/{org}/{name}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.repos.delete(org="<value>", name="<value>")

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org`                                                               | *str*                                                               | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.RepoError       | 401, 403, 404          | application/json       |
| errors.RepoError       | 500                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Reads a single repository after the org+role access check (org
owner/admin of the repository's org only).


### Example Usage

<!-- UsageSnippet language="python" operationID="getRepo" method="get" path="/api/v1/repos/{org}/{name}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.repos.get(org="<value>", name="<value>")

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

**[models.Repo](../../models/repo.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.RepoError       | 401, 403, 404          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update

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

<!-- UsageSnippet language="python" operationID="patchRepo" method="patch" path="/api/v1/repos/{org}/{name}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.repos.update(org="<value>", name_param="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `org`                                                                                                                  | *str*                                                                                                                  | :heavy_check_mark:                                                                                                     | The organization URL slug.                                                                                             |
| `name_param`                                                                                                           | *str*                                                                                                                  | :heavy_check_mark:                                                                                                     | The repository name (URL label).                                                                                       |
| `x_on_behalf_of`                                                                                                       | *Optional[str]*                                                                                                        | :heavy_minus_sign:                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                    |
| `description`                                                                                                          | *Optional[str]*                                                                                                        | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `kind`                                                                                                                 | [Optional[models.RepoKind]](../../models/repokind.md)                                                                  | :heavy_minus_sign:                                                                                                     | Switch the repository's kind (see the operation description for<br/>the rules). Cannot be `null`: a kind is never un-set.<br/> |
| `name`                                                                                                                 | *Optional[str]*                                                                                                        | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `retries`                                                                                                              | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                       | :heavy_minus_sign:                                                                                                     | Configuration to override the default retry behavior of the client.                                                    |

### Response

**[models.Repo](../../models/repo.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.RepoError        | 400, 401, 403, 404, 409 | application/json        |
| errors.RepoError        | 500                     | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |