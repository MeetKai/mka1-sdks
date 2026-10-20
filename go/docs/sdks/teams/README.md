# Auth.Teams

## Overview

### Available Operations

* [GetNetworkPolicyAccess](#getnetworkpolicyaccess) - Read current network policy management access
* [Create](#create) - Create a team
* [List](#list) - List teams in an org
* [Get](#get) - Get a team
* [Update](#update) - Rename a team
* [Delete](#delete) - Delete a team
* [AddMember](#addmember) - Add a team member
* [ListMembers](#listmembers) - List team members
* [UpdateMember](#updatemember) - Set a team member role
* [RemoveMember](#removemember) - Remove a team member

## GetNetworkPolicyAccess

Current human membership and administrator permissions, verified with cookie caching disabled. A signed-in session is required; API keys cannot administer network policy. Expected IDs must match the active workspace.

### Example Usage

<!-- UsageSnippet language="go" operationID="getNetworkPolicyAccess" method="get" path="/api/v1/authentication/network-policy/access" -->
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

    res, err := s.Auth.Teams.GetNetworkPolicyAccess(ctx, operations.GetNetworkPolicyAccessSecurity{
        SessionCookie: "<YOUR_API_KEY_HERE>",
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

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `security`                                                                                             | [operations.GetNetworkPolicyAccessSecurity](../../models/operations/getnetworkpolicyaccesssecurity.md) | :heavy_check_mark:                                                                                     | The security requirements to use for the request.                                                      |
| `organizationID`                                                                                       | `string`                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `teamID`                                                                                               | `string`                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `xOnBehalfOf`                                                                                          | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.GetNetworkPolicyAccessResponse](../../models/operations/getnetworkpolicyaccessresponse.md), error**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| apierrors.GetNetworkPolicyAccessBadRequestError      | 400                                                  | application/json                                     |
| apierrors.GetNetworkPolicyAccessUnauthorizedError    | 401                                                  | application/json                                     |
| apierrors.GetNetworkPolicyAccessForbiddenError       | 403                                                  | application/json                                     |
| apierrors.GetNetworkPolicyAccessNotFoundError        | 404                                                  | application/json                                     |
| apierrors.GetNetworkPolicyAccessConflictError        | 409                                                  | application/json                                     |
| apierrors.GetNetworkPolicyAccessGoneError            | 410                                                  | application/json                                     |
| apierrors.GetNetworkPolicyAccessTooManyRequestsError | 429                                                  | application/json                                     |
| apierrors.APIError                                   | 4XX, 5XX                                             | \*/\*                                                |

## Create

Create a team

### Example Usage

<!-- UsageSnippet language="go" operationID="createTeam" method="post" path="/api/v1/authentication/orgs/{orgId}/teams" -->
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

    res, err := s.Auth.Teams.Create(ctx, "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ctx`                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                 | :heavy_check_mark:                                                                    | The context to use for the request.                                                   |
| `orgID`                                                                               | `string`                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `xOnBehalfOf`                                                                         | `*string`                                                                             | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `body`                                                                                | [*operations.CreateTeamRequestBody](../../models/operations/createteamrequestbody.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `opts`                                                                                | [][operations.Option](../../models/operations/option.md)                              | :heavy_minus_sign:                                                                    | The options for this request.                                                         |

### Response

**[*operations.CreateTeamResponse](../../models/operations/createteamresponse.md), error**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| apierrors.CreateTeamBadRequestError      | 400                                      | application/json                         |
| apierrors.CreateTeamUnauthorizedError    | 401                                      | application/json                         |
| apierrors.CreateTeamForbiddenError       | 403                                      | application/json                         |
| apierrors.CreateTeamNotFoundError        | 404                                      | application/json                         |
| apierrors.CreateTeamConflictError        | 409                                      | application/json                         |
| apierrors.CreateTeamGoneError            | 410                                      | application/json                         |
| apierrors.CreateTeamTooManyRequestsError | 429                                      | application/json                         |
| apierrors.APIError                       | 4XX, 5XX                                 | \*/\*                                    |

## List

List teams in an org

### Example Usage

<!-- UsageSnippet language="go" operationID="listTeams" method="get" path="/api/v1/authentication/orgs/{orgId}/teams" -->
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

    res, err := s.Auth.Teams.List(ctx, "<id>", nil)
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

**[*operations.ListTeamsResponse](../../models/operations/listteamsresponse.md), error**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| apierrors.ListTeamsBadRequestError      | 400                                     | application/json                        |
| apierrors.ListTeamsUnauthorizedError    | 401                                     | application/json                        |
| apierrors.ListTeamsForbiddenError       | 403                                     | application/json                        |
| apierrors.ListTeamsNotFoundError        | 404                                     | application/json                        |
| apierrors.ListTeamsConflictError        | 409                                     | application/json                        |
| apierrors.ListTeamsGoneError            | 410                                     | application/json                        |
| apierrors.ListTeamsTooManyRequestsError | 429                                     | application/json                        |
| apierrors.APIError                      | 4XX, 5XX                                | \*/\*                                   |

## Get

Get a team

### Example Usage

<!-- UsageSnippet language="go" operationID="getTeam" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
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

    res, err := s.Auth.Teams.Get(ctx, "<id>", "<id>", nil)
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
| `teamID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetTeamResponse](../../models/operations/getteamresponse.md), error**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| apierrors.GetTeamBadRequestError      | 400                                   | application/json                      |
| apierrors.GetTeamUnauthorizedError    | 401                                   | application/json                      |
| apierrors.GetTeamForbiddenError       | 403                                   | application/json                      |
| apierrors.GetTeamNotFoundError        | 404                                   | application/json                      |
| apierrors.GetTeamConflictError        | 409                                   | application/json                      |
| apierrors.GetTeamGoneError            | 410                                   | application/json                      |
| apierrors.GetTeamTooManyRequestsError | 429                                   | application/json                      |
| apierrors.APIError                    | 4XX, 5XX                              | \*/\*                                 |

## Update

Rename a team

### Example Usage

<!-- UsageSnippet language="go" operationID="updateTeam" method="patch" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
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

    res, err := s.Auth.Teams.Update(ctx, "<id>", "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ctx`                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                 | :heavy_check_mark:                                                                    | The context to use for the request.                                                   |
| `orgID`                                                                               | `string`                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `teamID`                                                                              | `string`                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `xOnBehalfOf`                                                                         | `*string`                                                                             | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `body`                                                                                | [*operations.UpdateTeamRequestBody](../../models/operations/updateteamrequestbody.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `opts`                                                                                | [][operations.Option](../../models/operations/option.md)                              | :heavy_minus_sign:                                                                    | The options for this request.                                                         |

### Response

**[*operations.UpdateTeamResponse](../../models/operations/updateteamresponse.md), error**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| apierrors.UpdateTeamBadRequestError      | 400                                      | application/json                         |
| apierrors.UpdateTeamUnauthorizedError    | 401                                      | application/json                         |
| apierrors.UpdateTeamForbiddenError       | 403                                      | application/json                         |
| apierrors.UpdateTeamNotFoundError        | 404                                      | application/json                         |
| apierrors.UpdateTeamConflictError        | 409                                      | application/json                         |
| apierrors.UpdateTeamGoneError            | 410                                      | application/json                         |
| apierrors.UpdateTeamTooManyRequestsError | 429                                      | application/json                         |
| apierrors.APIError                       | 4XX, 5XX                                 | \*/\*                                    |

## Delete

Delete a team

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteTeam" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
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

    res, err := s.Auth.Teams.Delete(ctx, "<id>", "<id>", nil)
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
| `teamID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteTeamResponse](../../models/operations/deleteteamresponse.md), error**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| apierrors.DeleteTeamBadRequestError      | 400                                      | application/json                         |
| apierrors.DeleteTeamUnauthorizedError    | 401                                      | application/json                         |
| apierrors.DeleteTeamForbiddenError       | 403                                      | application/json                         |
| apierrors.DeleteTeamNotFoundError        | 404                                      | application/json                         |
| apierrors.DeleteTeamConflictError        | 409                                      | application/json                         |
| apierrors.DeleteTeamGoneError            | 410                                      | application/json                         |
| apierrors.DeleteTeamTooManyRequestsError | 429                                      | application/json                         |
| apierrors.APIError                       | 4XX, 5XX                                 | \*/\*                                    |

## AddMember

Attach a principal (user or service account) to the team by its userId.

### Example Usage

<!-- UsageSnippet language="go" operationID="addTeamMember" method="post" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
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

    res, err := s.Auth.Teams.AddMember(ctx, "<id>", "<id>", nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `ctx`                                                                                       | [context.Context](https://pkg.go.dev/context#Context)                                       | :heavy_check_mark:                                                                          | The context to use for the request.                                                         |
| `orgID`                                                                                     | `string`                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `teamID`                                                                                    | `string`                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `xOnBehalfOf`                                                                               | `*string`                                                                                   | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |
| `body`                                                                                      | [*operations.AddTeamMemberRequestBody](../../models/operations/addteammemberrequestbody.md) | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `opts`                                                                                      | [][operations.Option](../../models/operations/option.md)                                    | :heavy_minus_sign:                                                                          | The options for this request.                                                               |

### Response

**[*operations.AddTeamMemberResponse](../../models/operations/addteammemberresponse.md), error**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| apierrors.AddTeamMemberBadRequestError      | 400                                         | application/json                            |
| apierrors.AddTeamMemberUnauthorizedError    | 401                                         | application/json                            |
| apierrors.AddTeamMemberForbiddenError       | 403                                         | application/json                            |
| apierrors.AddTeamMemberNotFoundError        | 404                                         | application/json                            |
| apierrors.AddTeamMemberConflictError        | 409                                         | application/json                            |
| apierrors.AddTeamMemberGoneError            | 410                                         | application/json                            |
| apierrors.AddTeamMemberTooManyRequestsError | 429                                         | application/json                            |
| apierrors.APIError                          | 4XX, 5XX                                    | \*/\*                                       |

## ListMembers

List team members

### Example Usage

<!-- UsageSnippet language="go" operationID="listTeamMembers" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
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

    res, err := s.Auth.Teams.ListMembers(ctx, "<id>", "<id>", nil)
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
| `teamID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListTeamMembersResponse](../../models/operations/listteammembersresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.ListTeamMembersBadRequestError      | 400                                           | application/json                              |
| apierrors.ListTeamMembersUnauthorizedError    | 401                                           | application/json                              |
| apierrors.ListTeamMembersForbiddenError       | 403                                           | application/json                              |
| apierrors.ListTeamMembersNotFoundError        | 404                                           | application/json                              |
| apierrors.ListTeamMembersConflictError        | 409                                           | application/json                              |
| apierrors.ListTeamMembersGoneError            | 410                                           | application/json                              |
| apierrors.ListTeamMembersTooManyRequestsError | 429                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## UpdateMember

Organization owner/admin only. Team admins may manage their own team network policy; other team administration remains org-admin-only.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateTeamMember" method="patch" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members/{memberId}" -->
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

    res, err := s.Auth.Teams.UpdateMember(ctx, operations.UpdateTeamMemberRequest{
        OrgID: "<id>",
        TeamID: "<id>",
        MemberID: "<id>",
        Body: operations.UpdateTeamMemberRequestBody{
            Role: operations.UpdateTeamMemberRoleRequestAdmin,
        },
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

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `request`                                                                                | [operations.UpdateTeamMemberRequest](../../models/operations/updateteammemberrequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.UpdateTeamMemberResponse](../../models/operations/updateteammemberresponse.md), error**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| apierrors.UpdateTeamMemberBadRequestError      | 400                                            | application/json                               |
| apierrors.UpdateTeamMemberUnauthorizedError    | 401                                            | application/json                               |
| apierrors.UpdateTeamMemberForbiddenError       | 403                                            | application/json                               |
| apierrors.UpdateTeamMemberNotFoundError        | 404                                            | application/json                               |
| apierrors.UpdateTeamMemberConflictError        | 409                                            | application/json                               |
| apierrors.UpdateTeamMemberGoneError            | 410                                            | application/json                               |
| apierrors.UpdateTeamMemberTooManyRequestsError | 429                                            | application/json                               |
| apierrors.APIError                             | 4XX, 5XX                                       | \*/\*                                          |

## RemoveMember

Remove a team member

### Example Usage

<!-- UsageSnippet language="go" operationID="removeTeamMember" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members/{memberId}" -->
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

    res, err := s.Auth.Teams.RemoveMember(ctx, "<id>", "<id>", "<id>", nil)
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
| `teamID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `memberID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.RemoveTeamMemberResponse](../../models/operations/removeteammemberresponse.md), error**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| apierrors.RemoveTeamMemberBadRequestError      | 400                                            | application/json                               |
| apierrors.RemoveTeamMemberUnauthorizedError    | 401                                            | application/json                               |
| apierrors.RemoveTeamMemberForbiddenError       | 403                                            | application/json                               |
| apierrors.RemoveTeamMemberNotFoundError        | 404                                            | application/json                               |
| apierrors.RemoveTeamMemberConflictError        | 409                                            | application/json                               |
| apierrors.RemoveTeamMemberGoneError            | 410                                            | application/json                               |
| apierrors.RemoveTeamMemberTooManyRequestsError | 429                                            | application/json                               |
| apierrors.APIError                             | 4XX, 5XX                                       | \*/\*                                          |