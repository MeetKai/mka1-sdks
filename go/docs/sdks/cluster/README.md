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

<!-- UsageSnippet language="go" operationID="createClusterInvite" method="post" path="/api/v1/authentication/admin/cluster/invitations" -->
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

    res, err := s.Auth.Cluster.CreateInvite(ctx, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                   | [context.Context](https://pkg.go.dev/context#Context)                                                   | :heavy_check_mark:                                                                                      | The context to use for the request.                                                                     |
| `xOnBehalfOf`                                                                                           | `*string`                                                                                               | :heavy_minus_sign:                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                     |
| `body`                                                                                                  | [*operations.CreateClusterInviteRequestBody](../../models/operations/createclusterinviterequestbody.md) | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `opts`                                                                                                  | [][operations.Option](../../models/operations/option.md)                                                | :heavy_minus_sign:                                                                                      | The options for this request.                                                                           |

### Response

**[*operations.CreateClusterInviteResponse](../../models/operations/createclusterinviteresponse.md), error**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| apierrors.CreateClusterInviteBadRequestError      | 400                                               | application/json                                  |
| apierrors.CreateClusterInviteUnauthorizedError    | 401                                               | application/json                                  |
| apierrors.CreateClusterInviteForbiddenError       | 403                                               | application/json                                  |
| apierrors.CreateClusterInviteNotFoundError        | 404                                               | application/json                                  |
| apierrors.CreateClusterInviteConflictError        | 409                                               | application/json                                  |
| apierrors.CreateClusterInviteGoneError            | 410                                               | application/json                                  |
| apierrors.CreateClusterInviteTooManyRequestsError | 429                                               | application/json                                  |
| apierrors.APIError                                | 4XX, 5XX                                          | \*/\*                                             |

## ListInvites

List cluster invitations

### Example Usage

<!-- UsageSnippet language="go" operationID="listClusterInvites" method="get" path="/api/v1/authentication/admin/cluster/invitations" -->
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

    res, err := s.Auth.Cluster.ListInvites(ctx, nil)
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
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListClusterInvitesResponse](../../models/operations/listclusterinvitesresponse.md), error**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| apierrors.ListClusterInvitesBadRequestError      | 400                                              | application/json                                 |
| apierrors.ListClusterInvitesUnauthorizedError    | 401                                              | application/json                                 |
| apierrors.ListClusterInvitesForbiddenError       | 403                                              | application/json                                 |
| apierrors.ListClusterInvitesNotFoundError        | 404                                              | application/json                                 |
| apierrors.ListClusterInvitesConflictError        | 409                                              | application/json                                 |
| apierrors.ListClusterInvitesGoneError            | 410                                              | application/json                                 |
| apierrors.ListClusterInvitesTooManyRequestsError | 429                                              | application/json                                 |
| apierrors.APIError                               | 4XX, 5XX                                         | \*/\*                                            |

## UpdateInvite

Extend the expiry or atomically replace the available-model, API-quota, or compute policy of an unclaimed, unexpired invitation. Omitted top-level fields are preserved.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateClusterInvite" method="patch" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
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

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Auth.Cluster.UpdateInvite(ctx, "<id>", operations.UpdateClusterInviteRequestBody{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `id`                                                                                                   | `string`                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `body`                                                                                                 | [operations.UpdateClusterInviteRequestBody](../../models/operations/updateclusterinviterequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `xOnBehalfOf`                                                                                          | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.UpdateClusterInviteResponse](../../models/operations/updateclusterinviteresponse.md), error**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| apierrors.UpdateClusterInviteBadRequestError      | 400                                               | application/json                                  |
| apierrors.UpdateClusterInviteUnauthorizedError    | 401                                               | application/json                                  |
| apierrors.UpdateClusterInviteForbiddenError       | 403                                               | application/json                                  |
| apierrors.UpdateClusterInviteNotFoundError        | 404                                               | application/json                                  |
| apierrors.UpdateClusterInviteConflictError        | 409                                               | application/json                                  |
| apierrors.UpdateClusterInviteGoneError            | 410                                               | application/json                                  |
| apierrors.UpdateClusterInviteTooManyRequestsError | 429                                               | application/json                                  |
| apierrors.APIError                                | 4XX, 5XX                                          | \*/\*                                             |

## RevokeInvite

Revoke a cluster invitation

### Example Usage

<!-- UsageSnippet language="go" operationID="revokeClusterInvite" method="delete" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
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

    res, err := s.Auth.Cluster.RevokeInvite(ctx, "<id>", nil)
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
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.RevokeClusterInviteResponse](../../models/operations/revokeclusterinviteresponse.md), error**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| apierrors.RevokeClusterInviteBadRequestError      | 400                                               | application/json                                  |
| apierrors.RevokeClusterInviteUnauthorizedError    | 401                                               | application/json                                  |
| apierrors.RevokeClusterInviteForbiddenError       | 403                                               | application/json                                  |
| apierrors.RevokeClusterInviteNotFoundError        | 404                                               | application/json                                  |
| apierrors.RevokeClusterInviteConflictError        | 409                                               | application/json                                  |
| apierrors.RevokeClusterInviteGoneError            | 410                                               | application/json                                  |
| apierrors.RevokeClusterInviteTooManyRequestsError | 429                                               | application/json                                  |
| apierrors.APIError                                | 4XX, 5XX                                          | \*/\*                                             |

## ListOrgs

List all organizations

### Example Usage

<!-- UsageSnippet language="go" operationID="listClusterOrgs" method="get" path="/api/v1/authentication/admin/cluster/orgs" -->
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

    res, err := s.Auth.Cluster.ListOrgs(ctx, nil)
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
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListClusterOrgsResponse](../../models/operations/listclusterorgsresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.ListClusterOrgsBadRequestError      | 400                                           | application/json                              |
| apierrors.ListClusterOrgsUnauthorizedError    | 401                                           | application/json                              |
| apierrors.ListClusterOrgsForbiddenError       | 403                                           | application/json                              |
| apierrors.ListClusterOrgsNotFoundError        | 404                                           | application/json                              |
| apierrors.ListClusterOrgsConflictError        | 409                                           | application/json                              |
| apierrors.ListClusterOrgsGoneError            | 410                                           | application/json                              |
| apierrors.ListClusterOrgsTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## GetOrg

Get an organization

### Example Usage

<!-- UsageSnippet language="go" operationID="getClusterOrg" method="get" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
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

    res, err := s.Auth.Cluster.GetOrg(ctx, "<id>", nil)
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
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetClusterOrgResponse](../../models/operations/getclusterorgresponse.md), error**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| apierrors.GetClusterOrgBadRequestError      | 400                                         | application/json                            |
| apierrors.GetClusterOrgUnauthorizedError    | 401                                         | application/json                            |
| apierrors.GetClusterOrgForbiddenError       | 403                                         | application/json                            |
| apierrors.GetClusterOrgNotFoundError        | 404                                         | application/json                            |
| apierrors.GetClusterOrgConflictError        | 409                                         | application/json                            |
| apierrors.GetClusterOrgGoneError            | 410                                         | application/json                            |
| apierrors.GetClusterOrgTooManyRequestsError | 429                                         | application/json                            |
| apierrors.APIError                          | 4XX, 5XX                                    | \*/\*                                       |

## DeleteOrg

Soft-delete an organization

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteClusterOrg" method="delete" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
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

    res, err := s.Auth.Cluster.DeleteOrg(ctx, "<id>", nil)
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
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteClusterOrgResponse](../../models/operations/deleteclusterorgresponse.md), error**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| apierrors.DeleteClusterOrgBadRequestError      | 400                                            | application/json                               |
| apierrors.DeleteClusterOrgUnauthorizedError    | 401                                            | application/json                               |
| apierrors.DeleteClusterOrgForbiddenError       | 403                                            | application/json                               |
| apierrors.DeleteClusterOrgNotFoundError        | 404                                            | application/json                               |
| apierrors.DeleteClusterOrgConflictError        | 409                                            | application/json                               |
| apierrors.DeleteClusterOrgGoneError            | 410                                            | application/json                               |
| apierrors.DeleteClusterOrgTooManyRequestsError | 429                                            | application/json                               |
| apierrors.APIError                             | 4XX, 5XX                                       | \*/\*                                          |

## InviteOrgMembers

Requires a cluster-admin session with Cluster as its active organization. The target must be active and cannot be Cluster. Sends up to 20 organization invitations without switching the admin's session or joining the target organization. Each row accepts role member or admin, defaulting to member; owner and custom roles are not supported. New invitations include the target's oldest team when one exists. Results follow input order; invalid emails, duplicates, existing members, pending invitations, and delivery failures are reported per row. An existing pending invitation must match the requested role, including when resend is false. An explicit resend reuses a matching pending invitation with no team or the target's oldest team, preserving its inviter, role, and team. Invitation expiry is 48 hours; at most 100 unexpired pending invitations are allowed per organization. API keys are not supported.

### Example Usage

<!-- UsageSnippet language="go" operationID="inviteClusterOrgMembers" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/invitations" -->
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

    res, err := s.Auth.Cluster.InviteOrgMembers(ctx, operations.InviteClusterOrgMembersSecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
    }, "<id>", operations.InviteClusterOrgMembersRequestBody{
        Invitations: []operations.InviteClusterOrgMembersInvitation{
            operations.InviteClusterOrgMembersInvitation{
                Email: "Aurelio1@yahoo.com",
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

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                                          | :heavy_check_mark:                                                                                             | The context to use for the request.                                                                            |
| `security`                                                                                                     | [operations.InviteClusterOrgMembersSecurity](../../models/operations/inviteclusterorgmemberssecurity.md)       | :heavy_check_mark:                                                                                             | The security requirements to use for the request.                                                              |
| `id`                                                                                                           | `string`                                                                                                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            |
| `body`                                                                                                         | [operations.InviteClusterOrgMembersRequestBody](../../models/operations/inviteclusterorgmembersrequestbody.md) | :heavy_check_mark:                                                                                             | N/A                                                                                                            |
| `xOnBehalfOf`                                                                                                  | `*string`                                                                                                      | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |
| `opts`                                                                                                         | [][operations.Option](../../models/operations/option.md)                                                       | :heavy_minus_sign:                                                                                             | The options for this request.                                                                                  |

### Response

**[*operations.InviteClusterOrgMembersResponse](../../models/operations/inviteclusterorgmembersresponse.md), error**

### Errors

| Error Type                                            | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| apierrors.InviteClusterOrgMembersBadRequestError      | 400                                                   | application/json                                      |
| apierrors.InviteClusterOrgMembersUnauthorizedError    | 401                                                   | application/json                                      |
| apierrors.InviteClusterOrgMembersForbiddenError       | 403                                                   | application/json                                      |
| apierrors.InviteClusterOrgMembersNotFoundError        | 404                                                   | application/json                                      |
| apierrors.InviteClusterOrgMembersConflictError        | 409                                                   | application/json                                      |
| apierrors.InviteClusterOrgMembersGoneError            | 410                                                   | application/json                                      |
| apierrors.InviteClusterOrgMembersTooManyRequestsError | 429                                                   | application/json                                      |
| apierrors.APIError                                    | 4XX, 5XX                                              | \*/\*                                                 |

## SuspendOrg

Suspend an organization

### Example Usage

<!-- UsageSnippet language="go" operationID="suspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/suspend" -->
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

    res, err := s.Auth.Cluster.SuspendOrg(ctx, "<id>", nil)
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
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.SuspendClusterOrgResponse](../../models/operations/suspendclusterorgresponse.md), error**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| apierrors.SuspendClusterOrgBadRequestError      | 400                                             | application/json                                |
| apierrors.SuspendClusterOrgUnauthorizedError    | 401                                             | application/json                                |
| apierrors.SuspendClusterOrgForbiddenError       | 403                                             | application/json                                |
| apierrors.SuspendClusterOrgNotFoundError        | 404                                             | application/json                                |
| apierrors.SuspendClusterOrgConflictError        | 409                                             | application/json                                |
| apierrors.SuspendClusterOrgGoneError            | 410                                             | application/json                                |
| apierrors.SuspendClusterOrgTooManyRequestsError | 429                                             | application/json                                |
| apierrors.APIError                              | 4XX, 5XX                                        | \*/\*                                           |

## UnsuspendOrg

Unsuspend an organization

### Example Usage

<!-- UsageSnippet language="go" operationID="unsuspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/unsuspend" -->
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

    res, err := s.Auth.Cluster.UnsuspendOrg(ctx, "<id>", nil)
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
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.UnsuspendClusterOrgResponse](../../models/operations/unsuspendclusterorgresponse.md), error**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| apierrors.UnsuspendClusterOrgBadRequestError      | 400                                               | application/json                                  |
| apierrors.UnsuspendClusterOrgUnauthorizedError    | 401                                               | application/json                                  |
| apierrors.UnsuspendClusterOrgForbiddenError       | 403                                               | application/json                                  |
| apierrors.UnsuspendClusterOrgNotFoundError        | 404                                               | application/json                                  |
| apierrors.UnsuspendClusterOrgConflictError        | 409                                               | application/json                                  |
| apierrors.UnsuspendClusterOrgGoneError            | 410                                               | application/json                                  |
| apierrors.UnsuspendClusterOrgTooManyRequestsError | 429                                               | application/json                                  |
| apierrors.APIError                                | 4XX, 5XX                                          | \*/\*                                             |

## ReissueOwnerKey

Mint a fresh owner-bound key for an org whose credential was lost. Cluster-admin only (`write:cluster`). Defaults to the org's oldest human owner and oldest team; `userId` / `teamId` override.

### Example Usage

<!-- UsageSnippet language="go" operationID="reissueOwnerKey" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/owner-key" -->
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

    res, err := s.Auth.Cluster.ReissueOwnerKey(ctx, "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `ctx`                                                                                           | [context.Context](https://pkg.go.dev/context#Context)                                           | :heavy_check_mark:                                                                              | The context to use for the request.                                                             |
| `id`                                                                                            | `string`                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             |
| `xOnBehalfOf`                                                                                   | `*string`                                                                                       | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |
| `body`                                                                                          | [*operations.ReissueOwnerKeyRequestBody](../../models/operations/reissueownerkeyrequestbody.md) | :heavy_minus_sign:                                                                              | N/A                                                                                             |
| `opts`                                                                                          | [][operations.Option](../../models/operations/option.md)                                        | :heavy_minus_sign:                                                                              | The options for this request.                                                                   |

### Response

**[*operations.ReissueOwnerKeyResponse](../../models/operations/reissueownerkeyresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.ReissueOwnerKeyBadRequestError      | 400                                           | application/json                              |
| apierrors.ReissueOwnerKeyUnauthorizedError    | 401                                           | application/json                              |
| apierrors.ReissueOwnerKeyForbiddenError       | 403                                           | application/json                              |
| apierrors.ReissueOwnerKeyNotFoundError        | 404                                           | application/json                              |
| apierrors.ReissueOwnerKeyConflictError        | 409                                           | application/json                              |
| apierrors.ReissueOwnerKeyGoneError            | 410                                           | application/json                              |
| apierrors.ReissueOwnerKeyTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## InviteInfo

Read cluster-invite info (public)

### Example Usage

<!-- UsageSnippet language="go" operationID="getClusterInviteInfo" method="get" path="/api/v1/authentication/cluster-invite/info" -->
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

    res, err := s.Auth.Cluster.InviteInfo(ctx, "<value>", nil)
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
| `token`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetClusterInviteInfoResponse](../../models/operations/getclusterinviteinforesponse.md), error**

### Errors

| Error Type                                         | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| apierrors.GetClusterInviteInfoBadRequestError      | 400                                                | application/json                                   |
| apierrors.GetClusterInviteInfoUnauthorizedError    | 401                                                | application/json                                   |
| apierrors.GetClusterInviteInfoForbiddenError       | 403                                                | application/json                                   |
| apierrors.GetClusterInviteInfoNotFoundError        | 404                                                | application/json                                   |
| apierrors.GetClusterInviteInfoConflictError        | 409                                                | application/json                                   |
| apierrors.GetClusterInviteInfoGoneError            | 410                                                | application/json                                   |
| apierrors.GetClusterInviteInfoTooManyRequestsError | 429                                                | application/json                                   |
| apierrors.APIError                                 | 4XX, 5XX                                           | \*/\*                                              |

## AcceptInvite

Accept an invite and create the org. Existing signed-in user, new email/password owner, or (email-bound) headless machine owner with `passwordless: true, issueApiKey: true`. A reserved slug (`api`, whether supplied as `orgSlug` or derived from `orgName`) is refused with 400 `reserved_org_slug`; a slug another org already holds is refused with 409. Note `POST /organization/check-slug` does not know about reserved slugs and will report `api` as available.

### Example Usage

<!-- UsageSnippet language="go" operationID="acceptClusterInvite" method="post" path="/api/v1/authentication/cluster-invite/accept" -->
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

    res, err := s.Auth.Cluster.AcceptInvite(ctx, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                   | [context.Context](https://pkg.go.dev/context#Context)                                                   | :heavy_check_mark:                                                                                      | The context to use for the request.                                                                     |
| `xOnBehalfOf`                                                                                           | `*string`                                                                                               | :heavy_minus_sign:                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                     |
| `body`                                                                                                  | [*operations.AcceptClusterInviteRequestBody](../../models/operations/acceptclusterinviterequestbody.md) | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `opts`                                                                                                  | [][operations.Option](../../models/operations/option.md)                                                | :heavy_minus_sign:                                                                                      | The options for this request.                                                                           |

### Response

**[*operations.AcceptClusterInviteResponse](../../models/operations/acceptclusterinviteresponse.md), error**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| apierrors.AcceptClusterInviteBadRequestError      | 400                                               | application/json                                  |
| apierrors.AcceptClusterInviteUnauthorizedError    | 401                                               | application/json                                  |
| apierrors.AcceptClusterInviteForbiddenError       | 403                                               | application/json                                  |
| apierrors.AcceptClusterInviteNotFoundError        | 404                                               | application/json                                  |
| apierrors.AcceptClusterInviteConflictError        | 409                                               | application/json                                  |
| apierrors.AcceptClusterInviteGoneError            | 410                                               | application/json                                  |
| apierrors.AcceptClusterInviteTooManyRequestsError | 429                                               | application/json                                  |
| apierrors.ServiceUnavailableError                 | 503                                               | application/json                                  |
| apierrors.APIError                                | 4XX, 5XX                                          | \*/\*                                             |