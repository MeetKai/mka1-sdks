# Auth.Cluster

## Overview

### Available Operations

* [CreateInvite](#createinvite) - Create a cluster invitation
* [ListInvites](#listinvites) - List cluster invitations
* [UpdateInvite](#updateinvite) - Update a pending cluster invitation
* [RevokeInvite](#revokeinvite) - Revoke a cluster invitation
* [ListOrgs](#listorgs) - List all organizations
* [GetOrg](#getorg) - Get an organization
* [DeleteOrg](#deleteorg) - Soft-delete an organization
* [InviteOrgMembers](#inviteorgmembers) - Invite members on behalf of an organization
* [SuspendOrg](#suspendorg) - Suspend an organization
* [UnsuspendOrg](#unsuspendorg) - Unsuspend an organization
* [ReissueOwnerKey](#reissueownerkey) - Re-issue an org owner key (recovery)
* [InviteInfo](#inviteinfo) - Read cluster-invite info (public)
* [AcceptInvite](#acceptinvite) - Accept a cluster invitation (public)

## CreateInvite

Issue a one-shot invite that provisions a new org on acceptance. Email-bound invites can be accepted headless (passwordless + issueApiKey).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createClusterInvite" method="post" path="/api/v1/authentication/admin/cluster/invitations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.CreateInviteAsync();

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `Body`                                                                                   | [CreateClusterInviteRequestBody](../../Types/Requests/CreateClusterInviteRequestBody.md) | :heavy_minus_sign:                                                                       | N/A                                                                                      |

### Response

**[CreateClusterInviteResponse](../../Types/Requests/CreateClusterInviteResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.CreateClusterInviteBadRequestException      | 400                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.CreateClusterInviteUnauthorizedException    | 401                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.CreateClusterInviteForbiddenException       | 403                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.CreateClusterInviteNotFoundException        | 404                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.CreateClusterInviteConflictException        | 409                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.CreateClusterInviteGoneException            | 410                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.CreateClusterInviteTooManyRequestsException | 429                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.APIException                                | 4XX, 5XX                                                              | \*/\*                                                                 |

## ListInvites

List cluster invitations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listClusterInvites" method="get" path="/api/v1/authentication/admin/cluster/invitations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.ListInvitesAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListClusterInvitesResponse](../../Types/Requests/ListClusterInvitesResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ListClusterInvitesBadRequestException      | 400                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.ListClusterInvitesUnauthorizedException    | 401                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.ListClusterInvitesForbiddenException       | 403                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.ListClusterInvitesNotFoundException        | 404                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.ListClusterInvitesConflictException        | 409                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.ListClusterInvitesGoneException            | 410                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.ListClusterInvitesTooManyRequestsException | 429                                                                  | application/json                                                     |
| MeetKai.MKA1.Types.Errors.APIException                               | 4XX, 5XX                                                             | \*/\*                                                                |

## UpdateInvite

Extend the expiry or atomically replace the available-model, API-quota, or compute policy of an unclaimed, unexpired invitation. Omitted top-level fields are preserved.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateClusterInvite" method="patch" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.UpdateInviteAsync(
    id: "<id>",
    body: new UpdateClusterInviteRequestBody() {}
);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `Body`                                                                                   | [UpdateClusterInviteRequestBody](../../Types/Requests/UpdateClusterInviteRequestBody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |

### Response

**[UpdateClusterInviteResponse](../../Types/Requests/UpdateClusterInviteResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.UpdateClusterInviteBadRequestException      | 400                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UpdateClusterInviteUnauthorizedException    | 401                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UpdateClusterInviteForbiddenException       | 403                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UpdateClusterInviteNotFoundException        | 404                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UpdateClusterInviteConflictException        | 409                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UpdateClusterInviteGoneException            | 410                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UpdateClusterInviteTooManyRequestsException | 429                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.APIException                                | 4XX, 5XX                                                              | \*/\*                                                                 |

## RevokeInvite

Revoke a cluster invitation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="revokeClusterInvite" method="delete" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.RevokeInviteAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[RevokeClusterInviteResponse](../../Types/Requests/RevokeClusterInviteResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.RevokeClusterInviteBadRequestException      | 400                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.RevokeClusterInviteUnauthorizedException    | 401                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.RevokeClusterInviteForbiddenException       | 403                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.RevokeClusterInviteNotFoundException        | 404                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.RevokeClusterInviteConflictException        | 409                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.RevokeClusterInviteGoneException            | 410                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.RevokeClusterInviteTooManyRequestsException | 429                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.APIException                                | 4XX, 5XX                                                              | \*/\*                                                                 |

## ListOrgs

List all organizations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listClusterOrgs" method="get" path="/api/v1/authentication/admin/cluster/orgs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.ListOrgsAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListClusterOrgsResponse](../../Types/Requests/ListClusterOrgsResponse.md)**

### Errors

| Error Type                                                        | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ListClusterOrgsBadRequestException      | 400                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListClusterOrgsUnauthorizedException    | 401                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListClusterOrgsForbiddenException       | 403                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListClusterOrgsNotFoundException        | 404                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListClusterOrgsConflictException        | 409                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListClusterOrgsGoneException            | 410                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ListClusterOrgsTooManyRequestsException | 429                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.APIException                            | 4XX, 5XX                                                          | \*/\*                                                             |

## GetOrg

Get an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getClusterOrg" method="get" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.GetOrgAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetClusterOrgResponse](../../Types/Requests/GetClusterOrgResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetClusterOrgBadRequestException      | 400                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.GetClusterOrgUnauthorizedException    | 401                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.GetClusterOrgForbiddenException       | 403                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.GetClusterOrgNotFoundException        | 404                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.GetClusterOrgConflictException        | 409                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.GetClusterOrgGoneException            | 410                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.GetClusterOrgTooManyRequestsException | 429                                                             | application/json                                                |
| MeetKai.MKA1.Types.Errors.APIException                          | 4XX, 5XX                                                        | \*/\*                                                           |

## DeleteOrg

Soft-delete an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteClusterOrg" method="delete" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.DeleteOrgAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteClusterOrgResponse](../../Types/Requests/DeleteClusterOrgResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| MeetKai.MKA1.Types.Errors.DeleteClusterOrgBadRequestException      | 400                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.DeleteClusterOrgUnauthorizedException    | 401                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.DeleteClusterOrgForbiddenException       | 403                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.DeleteClusterOrgNotFoundException        | 404                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.DeleteClusterOrgConflictException        | 409                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.DeleteClusterOrgGoneException            | 410                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.DeleteClusterOrgTooManyRequestsException | 429                                                                | application/json                                                   |
| MeetKai.MKA1.Types.Errors.APIException                             | 4XX, 5XX                                                           | \*/\*                                                              |

## InviteOrgMembers

Requires a cluster-admin session with Cluster as its active organization. The target must be active and cannot be Cluster. Sends up to 20 organization invitations without switching the admin's session or joining the target organization. Each row accepts role member or admin, defaulting to member; owner and custom roles are not supported. New invitations include the target's oldest team when one exists. Results follow input order; invalid emails, duplicates, existing members, pending invitations, and delivery failures are reported per row. An existing pending invitation must match the requested role, including when resend is false. An explicit resend reuses a matching pending invitation with no team or the target's oldest team, preserving its inviter, role, and team. Invitation expiry is 48 hours; at most 100 unexpired pending invitations are allowed per organization. API keys are not supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="inviteClusterOrgMembers" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/invitations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK();

var res = await sdk.Auth.Cluster.InviteOrgMembersAsync(
    security: new InviteClusterOrgMembersSecurity() {
        SessionCookie = "<YOUR_API_KEY_HERE>",
    },
    id: "<id>",
    body: new InviteClusterOrgMembersRequestBody() {
        Invitations = new List<InviteClusterOrgMembersInvitation>() {
            new InviteClusterOrgMembersInvitation() {
                Email = "Aurelio1@yahoo.com",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `security`                                                                                       | [InviteClusterOrgMembersSecurity](../../Types/Requests/InviteClusterOrgMembersSecurity.md)       | :heavy_check_mark:                                                                               | The security requirements to use for the request.                                                |
| `Id`                                                                                             | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `Body`                                                                                           | [InviteClusterOrgMembersRequestBody](../../Types/Requests/InviteClusterOrgMembersRequestBody.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `XOnBehalfOf`                                                                                    | *string*                                                                                         | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |

### Response

**[InviteClusterOrgMembersResponse](../../Types/Requests/InviteClusterOrgMembersResponse.md)**

### Errors

| Error Type                                                                | Status Code                                                               | Content Type                                                              |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.InviteClusterOrgMembersBadRequestException      | 400                                                                       | application/json                                                          |
| MeetKai.MKA1.Types.Errors.InviteClusterOrgMembersUnauthorizedException    | 401                                                                       | application/json                                                          |
| MeetKai.MKA1.Types.Errors.InviteClusterOrgMembersForbiddenException       | 403                                                                       | application/json                                                          |
| MeetKai.MKA1.Types.Errors.InviteClusterOrgMembersNotFoundException        | 404                                                                       | application/json                                                          |
| MeetKai.MKA1.Types.Errors.InviteClusterOrgMembersConflictException        | 409                                                                       | application/json                                                          |
| MeetKai.MKA1.Types.Errors.InviteClusterOrgMembersGoneException            | 410                                                                       | application/json                                                          |
| MeetKai.MKA1.Types.Errors.InviteClusterOrgMembersTooManyRequestsException | 429                                                                       | application/json                                                          |
| MeetKai.MKA1.Types.Errors.APIException                                    | 4XX, 5XX                                                                  | \*/\*                                                                     |

## SuspendOrg

Suspend an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="suspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/suspend" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.SuspendOrgAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[SuspendClusterOrgResponse](../../Types/Requests/SuspendClusterOrgResponse.md)**

### Errors

| Error Type                                                          | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.SuspendClusterOrgBadRequestException      | 400                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.SuspendClusterOrgUnauthorizedException    | 401                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.SuspendClusterOrgForbiddenException       | 403                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.SuspendClusterOrgNotFoundException        | 404                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.SuspendClusterOrgConflictException        | 409                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.SuspendClusterOrgGoneException            | 410                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.SuspendClusterOrgTooManyRequestsException | 429                                                                 | application/json                                                    |
| MeetKai.MKA1.Types.Errors.APIException                              | 4XX, 5XX                                                            | \*/\*                                                               |

## UnsuspendOrg

Unsuspend an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="unsuspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/unsuspend" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.UnsuspendOrgAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[UnsuspendClusterOrgResponse](../../Types/Requests/UnsuspendClusterOrgResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.UnsuspendClusterOrgBadRequestException      | 400                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UnsuspendClusterOrgUnauthorizedException    | 401                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UnsuspendClusterOrgForbiddenException       | 403                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UnsuspendClusterOrgNotFoundException        | 404                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UnsuspendClusterOrgConflictException        | 409                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UnsuspendClusterOrgGoneException            | 410                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.UnsuspendClusterOrgTooManyRequestsException | 429                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.APIException                                | 4XX, 5XX                                                              | \*/\*                                                                 |

## ReissueOwnerKey

Mint a fresh owner-bound key for an org whose credential was lost. Cluster-admin only (`write:cluster`). Defaults to the org's oldest human owner and oldest team; `userId` / `teamId` override.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="reissueOwnerKey" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/owner-key" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.ReissueOwnerKeyAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Id`                                                                             | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `XOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `Body`                                                                           | [ReissueOwnerKeyRequestBody](../../Types/Requests/ReissueOwnerKeyRequestBody.md) | :heavy_minus_sign:                                                               | N/A                                                                              |

### Response

**[ReissueOwnerKeyResponse](../../Types/Requests/ReissueOwnerKeyResponse.md)**

### Errors

| Error Type                                                        | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.ReissueOwnerKeyBadRequestException      | 400                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ReissueOwnerKeyUnauthorizedException    | 401                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ReissueOwnerKeyForbiddenException       | 403                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ReissueOwnerKeyNotFoundException        | 404                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ReissueOwnerKeyConflictException        | 409                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ReissueOwnerKeyGoneException            | 410                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.ReissueOwnerKeyTooManyRequestsException | 429                                                               | application/json                                                  |
| MeetKai.MKA1.Types.Errors.APIException                            | 4XX, 5XX                                                          | \*/\*                                                             |

## InviteInfo

Read cluster-invite info (public)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getClusterInviteInfo" method="get" path="/api/v1/authentication/cluster-invite/info" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.InviteInfoAsync(token: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Token`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetClusterInviteInfoResponse](../../Types/Requests/GetClusterInviteInfoResponse.md)**

### Errors

| Error Type                                                             | Status Code                                                            | Content Type                                                           |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.GetClusterInviteInfoBadRequestException      | 400                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.GetClusterInviteInfoUnauthorizedException    | 401                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.GetClusterInviteInfoForbiddenException       | 403                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.GetClusterInviteInfoNotFoundException        | 404                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.GetClusterInviteInfoConflictException        | 409                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.GetClusterInviteInfoGoneException            | 410                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.GetClusterInviteInfoTooManyRequestsException | 429                                                                    | application/json                                                       |
| MeetKai.MKA1.Types.Errors.APIException                                 | 4XX, 5XX                                                               | \*/\*                                                                  |

## AcceptInvite

Accept an invite and create the org. Existing signed-in user, new email/password owner, or (email-bound) headless machine owner with `passwordless: true, issueApiKey: true`. A reserved slug (`api`, whether supplied as `orgSlug` or derived from `orgName`) is refused with 400 `reserved_org_slug`; a slug another org already holds is refused with 409. Note `POST /organization/check-slug` does not know about reserved slugs and will report `api` as available.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="acceptClusterInvite" method="post" path="/api/v1/authentication/cluster-invite/accept" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Auth.Cluster.AcceptInviteAsync();

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `Body`                                                                                   | [AcceptClusterInviteRequestBody](../../Types/Requests/AcceptClusterInviteRequestBody.md) | :heavy_minus_sign:                                                                       | N/A                                                                                      |

### Response

**[AcceptClusterInviteResponse](../../Types/Requests/AcceptClusterInviteResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| MeetKai.MKA1.Types.Errors.AcceptClusterInviteBadRequestException      | 400                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.AcceptClusterInviteUnauthorizedException    | 401                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.AcceptClusterInviteForbiddenException       | 403                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.AcceptClusterInviteNotFoundException        | 404                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.AcceptClusterInviteConflictException        | 409                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.AcceptClusterInviteGoneException            | 410                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.AcceptClusterInviteTooManyRequestsException | 429                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.ServiceUnavailableException                 | 503                                                                   | application/json                                                      |
| MeetKai.MKA1.Types.Errors.APIException                                | 4XX, 5XX                                                              | \*/\*                                                                 |