# Auth.Teams

## Overview

### Available Operations

* [Create](#create) - Create a team
* [List](#list) - List teams in an org
* [Get](#get) - Get a team
* [Update](#update) - Rename a team
* [Delete](#delete) - Delete a team
* [AddMember](#addmember) - Add a team member
* [ListMembers](#listmembers) - List team members
* [RemoveMember](#removemember) - Remove a team member

## Create

Create a team

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createTeam" method="post" path="/api/v1/authentication/orgs/{orgId}/teams" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.CreateAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `OrgId`                                                                | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `XOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |
| `Body`                                                                 | [CreateTeamRequestBody](../../Types/Requests/CreateTeamRequestBody.md) | :heavy_minus_sign:                                                     | N/A                                                                    |

### Response

**[CreateTeamResponse](../../Types/Requests/CreateTeamResponse.md)**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.CreateTeamBadRequestException      | 400                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.CreateTeamUnauthorizedException    | 401                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.CreateTeamForbiddenException       | 403                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.CreateTeamNotFoundException        | 404                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.CreateTeamConflictException        | 409                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.CreateTeamGoneException            | 410                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.CreateTeamTooManyRequestsException | 429                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.APIException                       | 4XX, 5XX                                                     | \*/\*                                                        |

## List

List teams in an org

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTeams" method="get" path="/api/v1/authentication/orgs/{orgId}/teams" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.ListAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListTeamsResponse](../../Types/Requests/ListTeamsResponse.md)**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ListTeamsBadRequestException      | 400                                                         | application/json                                            |
| MeetKai.MKA1.Types.Errors.ListTeamsUnauthorizedException    | 401                                                         | application/json                                            |
| MeetKai.MKA1.Types.Errors.ListTeamsForbiddenException       | 403                                                         | application/json                                            |
| MeetKai.MKA1.Types.Errors.ListTeamsNotFoundException        | 404                                                         | application/json                                            |
| MeetKai.MKA1.Types.Errors.ListTeamsConflictException        | 409                                                         | application/json                                            |
| MeetKai.MKA1.Types.Errors.ListTeamsGoneException            | 410                                                         | application/json                                            |
| MeetKai.MKA1.Types.Errors.ListTeamsTooManyRequestsException | 429                                                         | application/json                                            |
| MeetKai.MKA1.Types.Errors.APIException                      | 4XX, 5XX                                                    | \*/\*                                                       |

## Get

Get a team

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTeam" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.GetAsync(
    orgId: "<id>",
    teamId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `TeamId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetTeamResponse](../../Types/Requests/GetTeamResponse.md)**

### Errors

| Error Type                                                | Status Code                                               | Content Type                                              |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetTeamBadRequestException      | 400                                                       | application/json                                          |
| MeetKai.MKA1.Types.Errors.GetTeamUnauthorizedException    | 401                                                       | application/json                                          |
| MeetKai.MKA1.Types.Errors.GetTeamForbiddenException       | 403                                                       | application/json                                          |
| MeetKai.MKA1.Types.Errors.GetTeamNotFoundException        | 404                                                       | application/json                                          |
| MeetKai.MKA1.Types.Errors.GetTeamConflictException        | 409                                                       | application/json                                          |
| MeetKai.MKA1.Types.Errors.GetTeamGoneException            | 410                                                       | application/json                                          |
| MeetKai.MKA1.Types.Errors.GetTeamTooManyRequestsException | 429                                                       | application/json                                          |
| MeetKai.MKA1.Types.Errors.APIException                    | 4XX, 5XX                                                  | \*/\*                                                     |

## Update

Rename a team

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateTeam" method="patch" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.UpdateAsync(
    orgId: "<id>",
    teamId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `OrgId`                                                                | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `TeamId`                                                               | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `XOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |
| `Body`                                                                 | [UpdateTeamRequestBody](../../Types/Requests/UpdateTeamRequestBody.md) | :heavy_minus_sign:                                                     | N/A                                                                    |

### Response

**[UpdateTeamResponse](../../Types/Requests/UpdateTeamResponse.md)**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.UpdateTeamBadRequestException      | 400                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.UpdateTeamUnauthorizedException    | 401                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.UpdateTeamForbiddenException       | 403                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.UpdateTeamNotFoundException        | 404                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.UpdateTeamConflictException        | 409                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.UpdateTeamGoneException            | 410                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.UpdateTeamTooManyRequestsException | 429                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.APIException                       | 4XX, 5XX                                                     | \*/\*                                                        |

## Delete

Delete a team

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteTeam" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.DeleteAsync(
    orgId: "<id>",
    teamId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `TeamId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteTeamResponse](../../Types/Requests/DeleteTeamResponse.md)**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.DeleteTeamBadRequestException      | 400                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.DeleteTeamUnauthorizedException    | 401                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.DeleteTeamForbiddenException       | 403                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.DeleteTeamNotFoundException        | 404                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.DeleteTeamConflictException        | 409                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.DeleteTeamGoneException            | 410                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.DeleteTeamTooManyRequestsException | 429                                                          | application/json                                             |
| MeetKai.MKA1.Types.Errors.APIException                       | 4XX, 5XX                                                     | \*/\*                                                        |

## AddMember

Attach a principal (user or service account) to the team by its userId.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addTeamMember" method="post" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.AddMemberAsync(
    orgId: "<id>",
    teamId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `OrgId`                                                                      | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `TeamId`                                                                     | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |
| `Body`                                                                       | [AddTeamMemberRequestBody](../../Types/Requests/AddTeamMemberRequestBody.md) | :heavy_minus_sign:                                                           | N/A                                                                          |

### Response

**[AddTeamMemberResponse](../../Types/Requests/AddTeamMemberResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.AddTeamMemberBadRequestException      | 400                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.AddTeamMemberUnauthorizedException    | 401                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.AddTeamMemberForbiddenException       | 403                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.AddTeamMemberNotFoundException        | 404                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.AddTeamMemberConflictException        | 409                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.AddTeamMemberGoneException            | 410                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.AddTeamMemberTooManyRequestsException | 429                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.APIException                          | 4XX, 5XX                                                        | \*/\*                                                           |

## ListMembers

List team members

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTeamMembers" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.ListMembersAsync(
    orgId: "<id>",
    teamId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `TeamId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListTeamMembersResponse](../../Types/Requests/ListTeamMembersResponse.md)**

### Errors

| Error Type                                                        | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ListTeamMembersBadRequestException      | 400                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListTeamMembersUnauthorizedException    | 401                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListTeamMembersForbiddenException       | 403                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListTeamMembersNotFoundException        | 404                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListTeamMembersConflictException        | 409                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListTeamMembersGoneException            | 410                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListTeamMembersTooManyRequestsException | 429                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.APIException                            | 4XX, 5XX                                                          | \*/\*                                                             |

## RemoveMember

Remove a team member

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeTeamMember" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members/{memberId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Teams.RemoveMemberAsync(
    orgId: "<id>",
    teamId: "<id>",
    memberId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `OrgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `TeamId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `MemberId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[RemoveTeamMemberResponse](../../Types/Requests/RemoveTeamMemberResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.RemoveTeamMemberBadRequestException      | 400                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.RemoveTeamMemberUnauthorizedException    | 401                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.RemoveTeamMemberForbiddenException       | 403                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.RemoveTeamMemberNotFoundException        | 404                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.RemoveTeamMemberConflictException        | 409                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.RemoveTeamMemberGoneException            | 410                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.RemoveTeamMemberTooManyRequestsException | 429                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.APIException                             | 4XX, 5XX                                                           | \*/\*                                                              |