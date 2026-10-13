# Analytics.Projects

## Overview

Create, list, rename, and archive analytics projects.

### Available Operations

* [create](#create) - Create an analytics project
* [list](#list) - List accessible analytics projects
* [get](#get) - Get an analytics project
* [update](#update) - Rename an active analytics project
* [archive](#archive) - Archive an analytics project

## create

Create a project in the caller's organization. Without team_id the project belongs to the authenticated team. Organization owners and admins can create a project for any team in their organization, including teams they are not a member of, or pass team_id: null for an organization-level project. Service accounts can only create projects for their own team; any other team_id returns 403. team_id is trimmed. Ownership cannot be changed after creation.

### Example Usage

<!-- UsageSnippet language="python" operationID="analytics_projects_create" method="post" path="/api/v1/analytics/projects" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.analytics.projects.create(name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                             | Type                                                                                                                                                                                                                                  | Required                                                                                                                                                                                                                              | Description                                                                                                                                                                                                                           |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `name`                                                                                                                                                                                                                                | *str*                                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                                    | N/A                                                                                                                                                                                                                                   |
| `team_id`                                                                                                                                                                                                                             | *OptionalNullable[str]*                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                    | Team that owns the project. Defaults to the authenticated team. Organization owners and admins can name any team in their organization, or pass null for an organization-level project. Service accounts can only use their own team. |
| `retries`                                                                                                                                                                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                    | Configuration to override the default retry behavior of the client.                                                                                                                                                                   |

### Response

**[models.AnalyticsProject](../../models/analyticsproject.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.SDKDefaultError                 | 4XX, 5XX                               | \*/\*                                  |

## list

Organization owners and admins see every project in their organization: all teams' projects and organization-level projects, regardless of their active team. This also applies to an owner's or admin's API keys and exchanged JWTs, whichever team the key was issued for; use a service account for a team-confined credential. Service accounts see only their own team's projects. team_id and ownership narrow that set and never widen it, so filtering by a team the caller cannot access returns an empty list. ownership=organization combined with team_id returns 400. Unknown or repeated query parameters also return 400.

### Example Usage

<!-- UsageSnippet language="python" operationID="analytics_projects_list" method="get" path="/api/v1/analytics/projects" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.analytics.projects.list(limit=50, include_archived="false")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                  | Type                                                                                                                                                       | Required                                                                                                                                                   | Description                                                                                                                                                |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `limit`                                                                                                                                                    | *Optional[int]*                                                                                                                                            | :heavy_minus_sign:                                                                                                                                         | N/A                                                                                                                                                        |
| `after`                                                                                                                                                    | *Optional[str]*                                                                                                                                            | :heavy_minus_sign:                                                                                                                                         | N/A                                                                                                                                                        |
| `include_archived`                                                                                                                                         | [Optional[models.IncludeArchived]](../../models/includearchived.md)                                                                                        | :heavy_minus_sign:                                                                                                                                         | N/A                                                                                                                                                        |
| `team_id`                                                                                                                                                  | *Optional[str]*                                                                                                                                            | :heavy_minus_sign:                                                                                                                                         | Return only projects owned by this team. Filters narrow the projects the caller can already access; a team the caller cannot access returns an empty list. |
| `ownership`                                                                                                                                                | [Optional[models.Ownership]](../../models/ownership.md)                                                                                                    | :heavy_minus_sign:                                                                                                                                         | Return only team-owned projects (team) or organization-level projects with a null team_id (organization). organization cannot be combined with team_id.    |
| `retries`                                                                                                                                                  | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                           | :heavy_minus_sign:                                                                                                                                         | Configuration to override the default retry behavior of the client.                                                                                        |

### Response

**[models.AnalyticsProjectList](../../models/analyticsprojectlist.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.SDKDefaultError                 | 4XX, 5XX                               | \*/\*                                  |

## get

Get an analytics project

### Example Usage

<!-- UsageSnippet language="python" operationID="analytics_projects_get" method="get" path="/api/v1/analytics/projects/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.analytics.projects.get(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | ID of the analytics project.                                        |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AnalyticsProject](../../models/analyticsproject.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.SDKDefaultError                 | 4XX, 5XX                               | \*/\*                                  |

## update

Rename an active project. Project ownership cannot be changed.

### Example Usage

<!-- UsageSnippet language="python" operationID="analytics_projects_update" method="patch" path="/api/v1/analytics/projects/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.analytics.projects.update(id="<id>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | ID of the analytics project.                                        |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AnalyticsProject](../../models/analyticsproject.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.SDKDefaultError                 | 4XX, 5XX                               | \*/\*                                  |

## archive

Stop new captures and queries for this project. Previously accepted events continue processing. Archiving does not delete stored events.

### Example Usage

<!-- UsageSnippet language="python" operationID="analytics_projects_archive" method="delete" path="/api/v1/analytics/projects/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.analytics.projects.archive(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | ID of the analytics project.                                        |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AnalyticsProject](../../models/analyticsproject.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| errors.AnalyticsError                  | 400, 401, 403, 404, 409, 413, 415, 429 | application/json                       |
| errors.AnalyticsError                  | 500, 503                               | application/json                       |
| errors.SDKDefaultError                 | 4XX, 5XX                               | \*/\*                                  |