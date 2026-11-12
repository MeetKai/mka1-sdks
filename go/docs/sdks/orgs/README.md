# Auth.Orgs

## Overview

### Available Operations

* [AddMember](#addmember) - Add an organization member directly
* [ListMembers](#listmembers) - List organization members
* [ListInvitationHistory](#listinvitationhistory) - List organization invitation history
* [InviteMember](#invitemember) - Invite an organization member
* [UpdateMember](#updatemember) - Change an organization member's role
* [RemoveMember](#removemember) - Remove an organization member
* [GetSsoPolicy](#getssopolicy) - Read enterprise SSO role mapping policy
* [UpdateSsoPolicy](#updatessopolicy) - Update enterprise SSO role mapping policy
* [GetByID](#getbyid) - Get basic organization details
* [Update](#update) - Patch organization metadata (cluster-admin)
* [GetQuota](#getquota) - Get an org's usage quota
* [UpdateQuota](#updatequota) - Set an org's usage quota (cluster-admin)
* [GetRateLimit](#getratelimit) - Get an org's rate limit
* [UpdateRateLimit](#updateratelimit) - Set an org's rate limit (cluster-admin)
* [GetInboundRules](#getinboundrules) - Get an org's inbound IP rules
* [UpdateInboundRules](#updateinboundrules) - Replace an org's inbound IP rules (org owner/admin, browser session)

## AddMember

Requires a current human organization owner/admin or an administrative service account enabled for this resource, plus write:org for OAuth tokens and API keys. Adds an existing human user or creates an unverified passwordless user when the email has no account, then adds membership to the organization and its oldest team. No invitation, acceptance, email, password, API key or browser session is created. Optional name applies only to new users and defaults to the email local part. Role defaults to member; admin is also supported. Existing members return already_member without role or profile changes. Directory-managed accounts must be managed at their directory. A matching pending invitation is canceled; a different pending role or team causes a conflict. Use the invitation endpoint when recipient acceptance is desired.

### Example Usage

<!-- UsageSnippet language="go" operationID="addOrgMember" method="post" path="/api/v1/authentication/orgs/{orgId}/members" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.AddMember(ctx, operations.AddOrgMemberSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", operations.AddOrgMemberRequestBody{
        Email: "Juwan_Gleichner@gmail.com",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TwoHundredApplicationJSONObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `security`                                                                               | [operations.AddOrgMemberSecurity](../../models/operations/addorgmembersecurity.md)       | :heavy_check_mark:                                                                       | The security requirements to use for the request.                                        |
| `orgID`                                                                                  | `string`                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `body`                                                                                   | [operations.AddOrgMemberRequestBody](../../models/operations/addorgmemberrequestbody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.AddOrgMemberResponse](../../models/operations/addorgmemberresponse.md), error**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| apierrors.AddOrgMemberBadRequestError      | 400                                        | application/json                           |
| apierrors.AddOrgMemberUnauthorizedError    | 401                                        | application/json                           |
| apierrors.AddOrgMemberForbiddenError       | 403                                        | application/json                           |
| apierrors.AddOrgMemberNotFoundError        | 404                                        | application/json                           |
| apierrors.AddOrgMemberConflictError        | 409                                        | application/json                           |
| apierrors.AddOrgMemberGoneError            | 410                                        | application/json                           |
| apierrors.AddOrgMemberTooManyRequestsError | 429                                        | application/json                           |
| apierrors.APIError                         | 4XX, 5XX                                   | \*/\*                                      |

## ListMembers

Requires human organization membership or an admin-enabled service account allowed on this resource, plus read:org for delegated credentials. Returns up to 100 members with directory-management status.

### Example Usage

<!-- UsageSnippet language="go" operationID="listOrgMembers" method="get" path="/api/v1/authentication/orgs/{orgId}/members" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.ListMembers(ctx, operations.ListOrgMembersSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", nil, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `security`                                                                             | [operations.ListOrgMembersSecurity](../../models/operations/listorgmemberssecurity.md) | :heavy_check_mark:                                                                     | The security requirements to use for the request.                                      |
| `orgID`                                                                                | `string`                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `limit`                                                                                | `*string`                                                                              | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `offset`                                                                               | `*string`                                                                              | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.ListOrgMembersResponse](../../models/operations/listorgmembersresponse.md), error**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| apierrors.ListOrgMembersBadRequestError      | 400                                          | application/json                             |
| apierrors.ListOrgMembersUnauthorizedError    | 401                                          | application/json                             |
| apierrors.ListOrgMembersForbiddenError       | 403                                          | application/json                             |
| apierrors.ListOrgMembersNotFoundError        | 404                                          | application/json                             |
| apierrors.ListOrgMembersConflictError        | 409                                          | application/json                             |
| apierrors.ListOrgMembersGoneError            | 410                                          | application/json                             |
| apierrors.ListOrgMembersTooManyRequestsError | 429                                          | application/json                             |
| apierrors.APIError                           | 4XX, 5XX                                     | \*/\*                                        |

## ListInvitationHistory

Requires a live browser session with the target organization active and a current human owner/admin membership. Cluster membership does not grant access to another organization. Returns all invitation lifecycle states, including expired pending records, with stored role and every assigned team ID in the comma-separated teamId field. Ordered by createdAt descending, then id descending. limit defaults to 20 (1–100), offset defaults to 0. status is all, pending (unexpired), expired, accepted, canceled, or rejected. query searches email case-insensitively; invitationId selects an exact record. This read never changes invitation status, expiry, or links. API keys are not supported.

### Example Usage

<!-- UsageSnippet language="go" operationID="listOrganizationInvitationHistory" method="get" path="/api/v1/authentication/orgs/{orgId}/invitations" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.ListInvitationHistory(ctx, operations.ListOrganizationInvitationHistoryRequest{
        OrgID: "<id>",
    }, operations.ListOrganizationInvitationHistorySecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                    | Type                                                                                                                         | Required                                                                                                                     | Description                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                                        | :heavy_check_mark:                                                                                                           | The context to use for the request.                                                                                          |
| `request`                                                                                                                    | [operations.ListOrganizationInvitationHistoryRequest](../../models/operations/listorganizationinvitationhistoryrequest.md)   | :heavy_check_mark:                                                                                                           | The request object to use for the request.                                                                                   |
| `security`                                                                                                                   | [operations.ListOrganizationInvitationHistorySecurity](../../models/operations/listorganizationinvitationhistorysecurity.md) | :heavy_check_mark:                                                                                                           | The security requirements to use for the request.                                                                            |
| `opts`                                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                                     | :heavy_minus_sign:                                                                                                           | The options for this request.                                                                                                |

### Response

**[*operations.ListOrganizationInvitationHistoryResponse](../../models/operations/listorganizationinvitationhistoryresponse.md), error**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| apierrors.ListOrganizationInvitationHistoryBadRequestError      | 400                                                             | application/json                                                |
| apierrors.ListOrganizationInvitationHistoryUnauthorizedError    | 401                                                             | application/json                                                |
| apierrors.ListOrganizationInvitationHistoryForbiddenError       | 403                                                             | application/json                                                |
| apierrors.ListOrganizationInvitationHistoryNotFoundError        | 404                                                             | application/json                                                |
| apierrors.ListOrganizationInvitationHistoryConflictError        | 409                                                             | application/json                                                |
| apierrors.ListOrganizationInvitationHistoryGoneError            | 410                                                             | application/json                                                |
| apierrors.ListOrganizationInvitationHistoryTooManyRequestsError | 429                                                             | application/json                                                |
| apierrors.APIError                                              | 4XX, 5XX                                                        | \*/\*                                                           |

## InviteMember

Requires current organization owner/admin and write:org for API keys. Invites member/admin to the default team. A matching retry preserves the invitation role; resend explicitly retries delivery. Directory-managed users must be managed at their directory. email_failed means the invitation was saved and can be resent.

### Example Usage

<!-- UsageSnippet language="go" operationID="inviteOrgMember" method="post" path="/api/v1/authentication/orgs/{orgId}/invitations" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.InviteMember(ctx, operations.InviteOrgMemberSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", operations.InviteOrgMemberRequestBody{
        Email: "Justen94@gmail.com",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TwoHundredApplicationJSONObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `security`                                                                                     | [operations.InviteOrgMemberSecurity](../../models/operations/inviteorgmembersecurity.md)       | :heavy_check_mark:                                                                             | The security requirements to use for the request.                                              |
| `orgID`                                                                                        | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `body`                                                                                         | [operations.InviteOrgMemberRequestBody](../../models/operations/inviteorgmemberrequestbody.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.InviteOrgMemberResponse](../../models/operations/inviteorgmemberresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.InviteOrgMemberBadRequestError      | 400                                           | application/json                              |
| apierrors.InviteOrgMemberUnauthorizedError    | 401                                           | application/json                              |
| apierrors.InviteOrgMemberForbiddenError       | 403                                           | application/json                              |
| apierrors.InviteOrgMemberNotFoundError        | 404                                           | application/json                              |
| apierrors.InviteOrgMemberConflictError        | 409                                           | application/json                              |
| apierrors.InviteOrgMemberGoneError            | 410                                           | application/json                              |
| apierrors.InviteOrgMemberTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## UpdateMember

Requires a current human owner/admin or an administrative service account enabled for members, plus write:org for delegated credentials. Assigns member/admin to human members. Owners and directory-managed members cannot be changed through this endpoint.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateOrgMember" method="patch" path="/api/v1/authentication/orgs/{orgId}/members/{memberId}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.UpdateMember(ctx, operations.UpdateOrgMemberSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", "<id>", operations.UpdateOrgMemberRequestBody{
        Role: operations.UpdateOrgMemberRoleAdmin,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `security`                                                                                     | [operations.UpdateOrgMemberSecurity](../../models/operations/updateorgmembersecurity.md)       | :heavy_check_mark:                                                                             | The security requirements to use for the request.                                              |
| `orgID`                                                                                        | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `memberID`                                                                                     | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `body`                                                                                         | [operations.UpdateOrgMemberRequestBody](../../models/operations/updateorgmemberrequestbody.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.UpdateOrgMemberResponse](../../models/operations/updateorgmemberresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.UpdateOrgMemberBadRequestError      | 400                                           | application/json                              |
| apierrors.UpdateOrgMemberUnauthorizedError    | 401                                           | application/json                              |
| apierrors.UpdateOrgMemberForbiddenError       | 403                                           | application/json                              |
| apierrors.UpdateOrgMemberNotFoundError        | 404                                           | application/json                              |
| apierrors.UpdateOrgMemberConflictError        | 409                                           | application/json                              |
| apierrors.UpdateOrgMemberGoneError            | 410                                           | application/json                              |
| apierrors.UpdateOrgMemberTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## RemoveMember

Requires a current human owner/admin or an administrative service account enabled for members, plus write:org for delegated credentials. Removes the human member's organization/team memberships and cancels pending invitations in this organization. Owners and directory-managed members are protected; other organizations are unchanged.

### Example Usage

<!-- UsageSnippet language="go" operationID="removeOrgMember" method="delete" path="/api/v1/authentication/orgs/{orgId}/members/{memberId}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.RemoveMember(ctx, operations.RemoveOrgMemberSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `security`                                                                               | [operations.RemoveOrgMemberSecurity](../../models/operations/removeorgmembersecurity.md) | :heavy_check_mark:                                                                       | The security requirements to use for the request.                                        |
| `orgID`                                                                                  | `string`                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `memberID`                                                                               | `string`                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.RemoveOrgMemberResponse](../../models/operations/removeorgmemberresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.RemoveOrgMemberBadRequestError      | 400                                           | application/json                              |
| apierrors.RemoveOrgMemberUnauthorizedError    | 401                                           | application/json                              |
| apierrors.RemoveOrgMemberForbiddenError       | 403                                           | application/json                              |
| apierrors.RemoveOrgMemberNotFoundError        | 404                                           | application/json                              |
| apierrors.RemoveOrgMemberConflictError        | 409                                           | application/json                              |
| apierrors.RemoveOrgMemberGoneError            | 410                                           | application/json                              |
| apierrors.RemoveOrgMemberTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## GetSsoPolicy

Requires a live human browser session and current owner/admin membership in the connection's active customer organization. API keys are not accepted.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSsoPolicy" method="get" path="/api/v1/authentication/sso/policy" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.GetSsoPolicy(ctx, operations.GetSsoPolicySecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
    }, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `security`                                                                         | [operations.GetSsoPolicySecurity](../../models/operations/getssopolicysecurity.md) | :heavy_check_mark:                                                                 | The security requirements to use for the request.                                  |
| `providerID`                                                                       | `string`                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `xOnBehalfOf`                                                                      | `*string`                                                                          | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.GetSsoPolicyResponse](../../models/operations/getssopolicyresponse.md), error**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| apierrors.GetSsoPolicyBadRequestError      | 400                                        | application/json                           |
| apierrors.GetSsoPolicyUnauthorizedError    | 401                                        | application/json                           |
| apierrors.GetSsoPolicyForbiddenError       | 403                                        | application/json                           |
| apierrors.GetSsoPolicyNotFoundError        | 404                                        | application/json                           |
| apierrors.GetSsoPolicyConflictError        | 409                                        | application/json                           |
| apierrors.GetSsoPolicyGoneError            | 410                                        | application/json                           |
| apierrors.GetSsoPolicyTooManyRequestsError | 429                                        | application/json                           |
| apierrors.APIError                         | 4XX, 5XX                                   | \*/\*                                      |

## UpdateSsoPolicy

Requires a live human browser session and current owner/admin membership. Enabling a connection requires verified domain ownership. Exact IdP group mappings grant member or admin on subsequent SSO logins; owners are preserved.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateSsoPolicy" method="post" path="/api/v1/authentication/sso/policy" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.UpdateSsoPolicy(ctx, operations.UpdateSsoPolicySecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
    }, operations.UpdateSsoPolicyRequestBody{
        ProviderID: "<id>",
        Enabled: false,
        GroupsClaim: "<value>",
        Mappings: []operations.MappingRequest{
            operations.MappingRequest{
                GroupValue: "<value>",
                Role: operations.UpdateSsoPolicyRoleRequestMember,
            },
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `security`                                                                                     | [operations.UpdateSsoPolicySecurity](../../models/operations/updatessopolicysecurity.md)       | :heavy_check_mark:                                                                             | The security requirements to use for the request.                                              |
| `body`                                                                                         | [operations.UpdateSsoPolicyRequestBody](../../models/operations/updatessopolicyrequestbody.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.UpdateSsoPolicyResponse](../../models/operations/updatessopolicyresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.UpdateSsoPolicyBadRequestError      | 400                                           | application/json                              |
| apierrors.UpdateSsoPolicyUnauthorizedError    | 401                                           | application/json                              |
| apierrors.UpdateSsoPolicyForbiddenError       | 403                                           | application/json                              |
| apierrors.UpdateSsoPolicyNotFoundError        | 404                                           | application/json                              |
| apierrors.UpdateSsoPolicyConflictError        | 409                                           | application/json                              |
| apierrors.UpdateSsoPolicyGoneError            | 410                                           | application/json                              |
| apierrors.UpdateSsoPolicyTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## GetByID

Returns basic fields and the full metadata object to a member of the organization or a cluster admin. It never includes member identities, invitations, or API-key details.

### Example Usage

<!-- UsageSnippet language="go" operationID="getOrgById" method="get" path="/api/v1/authentication/orgs/{orgId}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.GetByID(ctx, operations.GetOrgByIDSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.BasicOrganization != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `security`                                                                     | [operations.GetOrgByIDSecurity](../../models/operations/getorgbyidsecurity.md) | :heavy_check_mark:                                                             | The security requirements to use for the request.                              |
| `orgID`                                                                        | `string`                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `xOnBehalfOf`                                                                  | `*string`                                                                      | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.GetOrgByIDResponse](../../models/operations/getorgbyidresponse.md), error**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| apierrors.GetOrgByIDBadRequestError      | 400                                      | application/json                         |
| apierrors.GetOrgByIDUnauthorizedError    | 401                                      | application/json                         |
| apierrors.GetOrgByIDForbiddenError       | 403                                      | application/json                         |
| apierrors.GetOrgByIDNotFoundError        | 404                                      | application/json                         |
| apierrors.GetOrgByIDConflictError        | 409                                      | application/json                         |
| apierrors.GetOrgByIDGoneError            | 410                                      | application/json                         |
| apierrors.GetOrgByIDTooManyRequestsError | 429                                      | application/json                         |
| apierrors.GetOrgByIDInternalServerError  | 500                                      | application/json                         |
| apierrors.APIError                       | 4XX, 5XX                                 | \*/\*                                    |

## Update

Merges supplied top-level metadata keys while preserving omitted siblings. metadata.codeConfig accepts one releaseManifestUrl; codeConfig:null removes that override.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateOrganization" method="patch" path="/api/v1/authentication/orgs/{orgId}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.Update(ctx, operations.UpdateOrganizationSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", components.UpdateOrganizationBody{
        Metadata: components.OrganizationMetadata{},
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.BasicOrganization != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `security`                                                                                     | [operations.UpdateOrganizationSecurity](../../models/operations/updateorganizationsecurity.md) | :heavy_check_mark:                                                                             | The security requirements to use for the request.                                              |
| `orgID`                                                                                        | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `body`                                                                                         | [components.UpdateOrganizationBody](../../models/components/updateorganizationbody.md)         | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.UpdateOrganizationResponse](../../models/operations/updateorganizationresponse.md), error**

### Errors

| Error Type                                             | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| apierrors.UpdateOrganizationBadRequestError            | 400                                                    | application/json                                       |
| apierrors.UpdateOrganizationUnauthorizedError          | 401                                                    | application/json                                       |
| apierrors.UpdateOrganizationForbiddenError             | 403                                                    | application/json                                       |
| apierrors.UpdateOrganizationNotFoundError              | 404                                                    | application/json                                       |
| apierrors.UpdateOrganizationConflictError              | 409                                                    | application/json                                       |
| apierrors.UpdateOrganizationGoneError                  | 410                                                    | application/json                                       |
| apierrors.UpdateOrganizationRequestEntityTooLargeError | 413                                                    | application/json                                       |
| apierrors.UpdateOrganizationTooManyRequestsError       | 429                                                    | application/json                                       |
| apierrors.UpdateOrganizationInternalServerError        | 500                                                    | application/json                                       |
| apierrors.APIError                                     | 4XX, 5XX                                               | \*/\*                                                  |

## GetQuota

Get an org's usage quota

### Example Usage

<!-- UsageSnippet language="go" operationID="getOrgQuota" method="get" path="/api/v1/authentication/orgs/{orgId}/quota" -->
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

    res, err := s.Auth.Orgs.GetQuota(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetOrgQuotaResponse](../../models/operations/getorgquotaresponse.md), error**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| apierrors.GetOrgQuotaBadRequestError      | 400                                       | application/json                          |
| apierrors.GetOrgQuotaUnauthorizedError    | 401                                       | application/json                          |
| apierrors.GetOrgQuotaForbiddenError       | 403                                       | application/json                          |
| apierrors.GetOrgQuotaNotFoundError        | 404                                       | application/json                          |
| apierrors.GetOrgQuotaConflictError        | 409                                       | application/json                          |
| apierrors.GetOrgQuotaGoneError            | 410                                       | application/json                          |
| apierrors.GetOrgQuotaTooManyRequestsError | 429                                       | application/json                          |
| apierrors.APIError                        | 4XX, 5XX                                  | \*/\*                                     |

## UpdateQuota

Set an org's usage quota (cluster-admin)

### Example Usage

<!-- UsageSnippet language="go" operationID="updateOrgQuota" method="patch" path="/api/v1/authentication/orgs/{orgId}/quota" -->
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

    res, err := s.Auth.Orgs.UpdateQuota(ctx, "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `ctx`                                                                                         | [context.Context](https://pkg.go.dev/context#Context)                                         | :heavy_check_mark:                                                                            | The context to use for the request.                                                           |
| `orgID`                                                                                       | `string`                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `xOnBehalfOf`                                                                                 | `*string`                                                                                     | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |
| `body`                                                                                        | [*operations.UpdateOrgQuotaRequestBody](../../models/operations/updateorgquotarequestbody.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `opts`                                                                                        | [][operations.Option](../../models/operations/option.md)                                      | :heavy_minus_sign:                                                                            | The options for this request.                                                                 |

### Response

**[*operations.UpdateOrgQuotaResponse](../../models/operations/updateorgquotaresponse.md), error**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| apierrors.UpdateOrgQuotaBadRequestError      | 400                                          | application/json                             |
| apierrors.UpdateOrgQuotaUnauthorizedError    | 401                                          | application/json                             |
| apierrors.UpdateOrgQuotaForbiddenError       | 403                                          | application/json                             |
| apierrors.UpdateOrgQuotaNotFoundError        | 404                                          | application/json                             |
| apierrors.UpdateOrgQuotaConflictError        | 409                                          | application/json                             |
| apierrors.UpdateOrgQuotaGoneError            | 410                                          | application/json                             |
| apierrors.UpdateOrgQuotaTooManyRequestsError | 429                                          | application/json                             |
| apierrors.APIError                           | 4XX, 5XX                                     | \*/\*                                        |

## GetRateLimit

Get an org's rate limit

### Example Usage

<!-- UsageSnippet language="go" operationID="getOrgRateLimit" method="get" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
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

    res, err := s.Auth.Orgs.GetRateLimit(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetOrgRateLimitResponse](../../models/operations/getorgratelimitresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.GetOrgRateLimitBadRequestError      | 400                                           | application/json                              |
| apierrors.GetOrgRateLimitUnauthorizedError    | 401                                           | application/json                              |
| apierrors.GetOrgRateLimitForbiddenError       | 403                                           | application/json                              |
| apierrors.GetOrgRateLimitNotFoundError        | 404                                           | application/json                              |
| apierrors.GetOrgRateLimitConflictError        | 409                                           | application/json                              |
| apierrors.GetOrgRateLimitGoneError            | 410                                           | application/json                              |
| apierrors.GetOrgRateLimitTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## UpdateRateLimit

Set an org's rate limit (cluster-admin)

### Example Usage

<!-- UsageSnippet language="go" operationID="updateOrgRateLimit" method="patch" path="/api/v1/authentication/orgs/{orgId}/rate-limit" -->
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

    res, err := s.Auth.Orgs.UpdateRateLimit(ctx, "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                                 | :heavy_check_mark:                                                                                    | The context to use for the request.                                                                   |
| `orgID`                                                                                               | `string`                                                                                              | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `xOnBehalfOf`                                                                                         | `*string`                                                                                             | :heavy_minus_sign:                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                   |
| `body`                                                                                                | [*operations.UpdateOrgRateLimitRequestBody](../../models/operations/updateorgratelimitrequestbody.md) | :heavy_minus_sign:                                                                                    | N/A                                                                                                   |
| `opts`                                                                                                | [][operations.Option](../../models/operations/option.md)                                              | :heavy_minus_sign:                                                                                    | The options for this request.                                                                         |

### Response

**[*operations.UpdateOrgRateLimitResponse](../../models/operations/updateorgratelimitresponse.md), error**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| apierrors.UpdateOrgRateLimitBadRequestError      | 400                                              | application/json                                 |
| apierrors.UpdateOrgRateLimitUnauthorizedError    | 401                                              | application/json                                 |
| apierrors.UpdateOrgRateLimitForbiddenError       | 403                                              | application/json                                 |
| apierrors.UpdateOrgRateLimitNotFoundError        | 404                                              | application/json                                 |
| apierrors.UpdateOrgRateLimitConflictError        | 409                                              | application/json                                 |
| apierrors.UpdateOrgRateLimitGoneError            | 410                                              | application/json                                 |
| apierrors.UpdateOrgRateLimitTooManyRequestsError | 429                                              | application/json                                 |
| apierrors.APIError                               | 4XX, 5XX                                         | \*/\*                                            |

## GetInboundRules

Source-IP allowlist for the org's API keys. `available` mirrors the cluster's INBOUND_RULES_ENABLED flag. Rules are ordered by createdAt, then id.

### Example Usage

<!-- UsageSnippet language="go" operationID="getOrgInboundRules" method="get" path="/api/v1/authentication/orgs/{orgId}/inbound-rules" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.GetInboundRules(ctx, operations.GetOrgInboundRulesSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `security`                                                                                     | [operations.GetOrgInboundRulesSecurity](../../models/operations/getorginboundrulessecurity.md) | :heavy_check_mark:                                                                             | The security requirements to use for the request.                                              |
| `orgID`                                                                                        | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.GetOrgInboundRulesResponse](../../models/operations/getorginboundrulesresponse.md), error**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| apierrors.GetOrgInboundRulesBadRequestError      | 400                                              | application/json                                 |
| apierrors.GetOrgInboundRulesUnauthorizedError    | 401                                              | application/json                                 |
| apierrors.GetOrgInboundRulesForbiddenError       | 403                                              | application/json                                 |
| apierrors.GetOrgInboundRulesNotFoundError        | 404                                              | application/json                                 |
| apierrors.GetOrgInboundRulesConflictError        | 409                                              | application/json                                 |
| apierrors.GetOrgInboundRulesGoneError            | 410                                              | application/json                                 |
| apierrors.GetOrgInboundRulesTooManyRequestsError | 429                                              | application/json                                 |
| apierrors.APIError                               | 4XX, 5XX                                         | \*/\*                                            |

## UpdateInboundRules

Replaces the whole policy atomically. Each cidr is normalized (bare 0.0.0.0 / :: mean /0, other bare addresses are /32 or /128, host bits are cleared); duplicates after normalization are a 400. A request carrying an Authorization header is refused with 403.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateOrgInboundRules" method="put" path="/api/v1/authentication/orgs/{orgId}/inbound-rules" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New()

    res, err := s.Auth.Orgs.UpdateInboundRules(ctx, operations.UpdateOrgInboundRulesSecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
    }, "<id>", operations.UpdateOrgInboundRulesRequestBody{
        Enabled: false,
        Rules: []operations.RuleRequest{
            operations.RuleRequest{
                Cidr: "<value>",
            },
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                                      | :heavy_check_mark:                                                                                         | The context to use for the request.                                                                        |
| `security`                                                                                                 | [operations.UpdateOrgInboundRulesSecurity](../../models/operations/updateorginboundrulessecurity.md)       | :heavy_check_mark:                                                                                         | The security requirements to use for the request.                                                          |
| `orgID`                                                                                                    | `string`                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `body`                                                                                                     | [operations.UpdateOrgInboundRulesRequestBody](../../models/operations/updateorginboundrulesrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `xOnBehalfOf`                                                                                              | `*string`                                                                                                  | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `opts`                                                                                                     | [][operations.Option](../../models/operations/option.md)                                                   | :heavy_minus_sign:                                                                                         | The options for this request.                                                                              |

### Response

**[*operations.UpdateOrgInboundRulesResponse](../../models/operations/updateorginboundrulesresponse.md), error**

### Errors

| Error Type                                          | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| apierrors.UpdateOrgInboundRulesBadRequestError      | 400                                                 | application/json                                    |
| apierrors.UpdateOrgInboundRulesUnauthorizedError    | 401                                                 | application/json                                    |
| apierrors.UpdateOrgInboundRulesForbiddenError       | 403                                                 | application/json                                    |
| apierrors.UpdateOrgInboundRulesNotFoundError        | 404                                                 | application/json                                    |
| apierrors.UpdateOrgInboundRulesConflictError        | 409                                                 | application/json                                    |
| apierrors.UpdateOrgInboundRulesGoneError            | 410                                                 | application/json                                    |
| apierrors.UpdateOrgInboundRulesTooManyRequestsError | 429                                                 | application/json                                    |
| apierrors.APIError                                  | 4XX, 5XX                                            | \*/\*                                               |