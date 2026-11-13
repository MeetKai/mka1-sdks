# Auth.ModelAccess

## Overview

### Available Operations

* [GetMemberModelAccess](#getmembermodelaccess) - Get member model access
* [SetMemberModelAccess](#setmembermodelaccess) - Replace member model access
* [GetTeamModelAccess](#getteammodelaccess) - Get team model access
* [SetTeamModelAccess](#setteammodelaccess) - Replace team model access

## GetMemberModelAccess

Only a current organization owner/admin may manage this policy. null inherits; an empty list denies all. User overrides take precedence over the union of configured teams. The organization active model registry remains the upper bound. Use canonical served model IDs, not auto or benchmark aliases. Changes apply within 30 seconds on the next model dispatch.

### Example Usage

<!-- UsageSnippet language="go" operationID="getMemberModelAccess" method="get" path="/api/v1/authentication/orgs/{orgId}/members/{memberId}/model-access" -->
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

    res, err := s.Auth.ModelAccess.GetMemberModelAccess(ctx, operations.GetMemberModelAccessSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", "<id>")
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `security`                                                                                         | [operations.GetMemberModelAccessSecurity](../../models/operations/getmembermodelaccesssecurity.md) | :heavy_check_mark:                                                                                 | The security requirements to use for the request.                                                  |
| `orgID`                                                                                            | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `memberID`                                                                                         | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.GetMemberModelAccessResponse](../../models/operations/getmembermodelaccessresponse.md), error**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| apierrors.GetMemberModelAccessBadRequestError   | 400                                             | application/json                                |
| apierrors.GetMemberModelAccessUnauthorizedError | 401                                             | application/json                                |
| apierrors.GetMemberModelAccessForbiddenError    | 403                                             | application/json                                |
| apierrors.GetMemberModelAccessNotFoundError     | 404                                             | application/json                                |
| apierrors.APIError                              | 4XX, 5XX                                        | \*/\*                                           |

## SetMemberModelAccess

Only a current organization owner/admin may manage this policy. null inherits; an empty list denies all. User overrides take precedence over the union of configured teams. The organization active model registry remains the upper bound. Use canonical served model IDs, not auto or benchmark aliases. Changes apply within 30 seconds on the next model dispatch.

### Example Usage

<!-- UsageSnippet language="go" operationID="setMemberModelAccess" method="put" path="/api/v1/authentication/orgs/{orgId}/members/{memberId}/model-access" -->
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

    res, err := s.Auth.ModelAccess.SetMemberModelAccess(ctx, operations.SetMemberModelAccessSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", "<id>", operations.SetMemberModelAccessRequestBody{
        ModelIds: []string{},
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

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `security`                                                                                               | [operations.SetMemberModelAccessSecurity](../../models/operations/setmembermodelaccesssecurity.md)       | :heavy_check_mark:                                                                                       | The security requirements to use for the request.                                                        |
| `orgID`                                                                                                  | `string`                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `memberID`                                                                                               | `string`                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `body`                                                                                                   | [operations.SetMemberModelAccessRequestBody](../../models/operations/setmembermodelaccessrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.SetMemberModelAccessResponse](../../models/operations/setmembermodelaccessresponse.md), error**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| apierrors.SetMemberModelAccessBadRequestError   | 400                                             | application/json                                |
| apierrors.SetMemberModelAccessUnauthorizedError | 401                                             | application/json                                |
| apierrors.SetMemberModelAccessForbiddenError    | 403                                             | application/json                                |
| apierrors.SetMemberModelAccessNotFoundError     | 404                                             | application/json                                |
| apierrors.APIError                              | 4XX, 5XX                                        | \*/\*                                           |

## GetTeamModelAccess

Only a current organization owner/admin may manage this policy. null inherits; an empty list denies all. User overrides take precedence over the union of configured teams. The organization active model registry remains the upper bound. Use canonical served model IDs, not auto or benchmark aliases. Changes apply within 30 seconds on the next model dispatch.

### Example Usage

<!-- UsageSnippet language="go" operationID="getTeamModelAccess" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/model-access" -->
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

    res, err := s.Auth.ModelAccess.GetTeamModelAccess(ctx, operations.GetTeamModelAccessSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", "<id>")
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
| `security`                                                                                     | [operations.GetTeamModelAccessSecurity](../../models/operations/getteammodelaccesssecurity.md) | :heavy_check_mark:                                                                             | The security requirements to use for the request.                                              |
| `orgID`                                                                                        | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `teamID`                                                                                       | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.GetTeamModelAccessResponse](../../models/operations/getteammodelaccessresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.GetTeamModelAccessBadRequestError   | 400                                           | application/json                              |
| apierrors.GetTeamModelAccessUnauthorizedError | 401                                           | application/json                              |
| apierrors.GetTeamModelAccessForbiddenError    | 403                                           | application/json                              |
| apierrors.GetTeamModelAccessNotFoundError     | 404                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |

## SetTeamModelAccess

Only a current organization owner/admin may manage this policy. null inherits; an empty list denies all. User overrides take precedence over the union of configured teams. The organization active model registry remains the upper bound. Use canonical served model IDs, not auto or benchmark aliases. Changes apply within 30 seconds on the next model dispatch.

### Example Usage

<!-- UsageSnippet language="go" operationID="setTeamModelAccess" method="put" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/model-access" -->
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

    res, err := s.Auth.ModelAccess.SetTeamModelAccess(ctx, operations.SetTeamModelAccessSecurity{
        BearerAuth: mka1.Pointer("<YOUR_BEARER_TOKEN_HERE>"),
    }, "<id>", "<id>", operations.SetTeamModelAccessRequestBody{
        ModelIds: []string{
            "<value 1>",
            "<value 2>",
            "<value 3>",
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

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `security`                                                                                           | [operations.SetTeamModelAccessSecurity](../../models/operations/setteammodelaccesssecurity.md)       | :heavy_check_mark:                                                                                   | The security requirements to use for the request.                                                    |
| `orgID`                                                                                              | `string`                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `teamID`                                                                                             | `string`                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `body`                                                                                               | [operations.SetTeamModelAccessRequestBody](../../models/operations/setteammodelaccessrequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.SetTeamModelAccessResponse](../../models/operations/setteammodelaccessresponse.md), error**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| apierrors.SetTeamModelAccessBadRequestError   | 400                                           | application/json                              |
| apierrors.SetTeamModelAccessUnauthorizedError | 401                                           | application/json                              |
| apierrors.SetTeamModelAccessForbiddenError    | 403                                           | application/json                              |
| apierrors.SetTeamModelAccessNotFoundError     | 404                                           | application/json                              |
| apierrors.APIError                            | 4XX, 5XX                                      | \*/\*                                         |