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

<!-- UsageSnippet language="csharp" operationID="analytics_projects_create" method="post" path="/api/v1/analytics/projects" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

AnalyticsProjectCreate req = new AnalyticsProjectCreate() {
    Name = "<value>",
};

var res = await sdk.Analytics.Projects.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [AnalyticsProjectCreate](../../Types/Components/AnalyticsProjectCreate.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |

### Response

**[AnalyticsProjectsCreateResponse](../../Types/Requests/AnalyticsProjectsCreateResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |

## List

Organization owners and admins see every project in their organization: all teams' projects and organization-level projects, regardless of their active team. This also applies to an owner's or admin's API keys and exchanged JWTs, whichever team the key was issued for; use a service account for a team-confined credential. Service accounts see only their own team's projects. team_id and ownership narrow that set and never widen it, so filtering by a team the caller cannot access returns an empty list. ownership=organization combined with team_id returns 400. Unknown or repeated query parameters also return 400.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_projects_list" method="get" path="/api/v1/analytics/projects" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

AnalyticsProjectsListRequest req = new AnalyticsProjectsListRequest() {};

var res = await sdk.Analytics.Projects.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `request`                                                                            | [AnalyticsProjectsListRequest](../../Types/Requests/AnalyticsProjectsListRequest.md) | :heavy_check_mark:                                                                   | The request object to use for the request.                                           |

### Response

**[AnalyticsProjectsListResponse](../../Types/Requests/AnalyticsProjectsListResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |

## Get

Get an analytics project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_projects_get" method="get" path="/api/v1/analytics/projects/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Projects.GetAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `Id`                         | *string*                     | :heavy_check_mark:           | ID of the analytics project. |

### Response

**[AnalyticsProjectsGetResponse](../../Types/Requests/AnalyticsProjectsGetResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |

## Update

Rename an active project. Project ownership cannot be changed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_projects_update" method="patch" path="/api/v1/analytics/projects/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Projects.UpdateAsync(
    id: "<id>",
    body: new AnalyticsProjectUpdate() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Id`                                                                       | *string*                                                                   | :heavy_check_mark:                                                         | ID of the analytics project.                                               |
| `Body`                                                                     | [AnalyticsProjectUpdate](../../Types/Components/AnalyticsProjectUpdate.md) | :heavy_check_mark:                                                         | N/A                                                                        |

### Response

**[AnalyticsProjectsUpdateResponse](../../Types/Requests/AnalyticsProjectsUpdateResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |

## Archive

Stop new captures and queries for this project. Previously accepted events continue processing. Archiving does not delete stored events.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="analytics_projects_archive" method="delete" path="/api/v1/analytics/projects/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Analytics.Projects.ArchiveAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `Id`                         | *string*                     | :heavy_check_mark:           | ID of the analytics project. |

### Response

**[AnalyticsProjectsArchiveResponse](../../Types/Requests/AnalyticsProjectsArchiveResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 400, 401, 403, 404, 409, 413, 415, 429   | application/json                         |
| MeetKai.MKA1.Types.Errors.AnalyticsError | 500, 503                                 | application/json                         |
| MeetKai.MKA1.Types.Errors.APIException   | 4XX, 5XX                                 | \*/\*                                    |