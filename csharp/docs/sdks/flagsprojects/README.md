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

<!-- UsageSnippet language="csharp" operationID="listFeatureFlagProjects" method="get" path="/api/v1/flags/-/projects" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Projects.ListAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListFeatureFlagProjectsResponse](../../Types/Requests/ListFeatureFlagProjectsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403                                   | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Create

Create a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createFeatureFlagProject" method="post" path="/api/v1/flags/-/projects" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Projects.CreateAsync(body: new FeatureFlagProjectCreateRequest() {
    Key = "<key>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `Body`                                                                                       | [FeatureFlagProjectCreateRequest](../../Types/Components/FeatureFlagProjectCreateRequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `XOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |

### Response

**[CreateFeatureFlagProjectResponse](../../Types/Requests/CreateFeatureFlagProjectResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 409                         | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Delete

Default cannot be deleted. Move or delete every flag before deleting another project.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteFeatureFlagProject" method="delete" path="/api/v1/flags/-/projects/{project}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Projects.DeleteAsync(project: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Project`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteFeatureFlagProjectResponse](../../Types/Requests/DeleteFeatureFlagProjectResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404, 409                         | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Get

Get a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFeatureFlagProject" method="get" path="/api/v1/flags/-/projects/{project}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Projects.GetAsync(project: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Project`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetFeatureFlagProjectResponse](../../Types/Requests/GetFeatureFlagProjectResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 401, 403, 404                              | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |

## Update

Rename a project

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateFeatureFlagProject" method="patch" path="/api/v1/flags/-/projects/{project}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Flags.Projects.UpdateAsync(
    project: "<value>",
    body: new FeatureFlagProjectUpdateRequest() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `Project`                                                                                    | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `Body`                                                                                       | [FeatureFlagProjectUpdateRequest](../../Types/Components/FeatureFlagProjectUpdateRequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `XOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |

### Response

**[UpdateFeatureFlagProjectResponse](../../Types/Requests/UpdateFeatureFlagProjectResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| MeetKai.MKA1.Types.Errors.FeatureFlagError | 400, 401, 403, 404                         | application/json                           |
| MeetKai.MKA1.Types.Errors.APIException     | 4XX, 5XX                                   | \*/\*                                      |