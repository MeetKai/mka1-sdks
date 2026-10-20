# Budgets

## Overview

### Available Operations

* [List](#list) - List budgets
* [GetOrg](#getorg) - List org budgets
* [SetOrg](#setorg) - Set an org budget
* [DeleteOrg](#deleteorg) - Delete an org budget
* [OrgEvents](#orgevents) - List org budget events
* [GetAPIKey](#getapikey) - List apikey budgets
* [SetAPIKey](#setapikey) - Set an apikey budget
* [DeleteAPIKey](#deleteapikey) - Delete an apikey budget
* [APIKeyEvents](#apikeyevents) - List apikey budget events
* [GetUser](#getuser) - List user budgets
* [SetUser](#setuser) - Set a user budget
* [DeleteUser](#deleteuser) - Delete a user budget
* [UserEvents](#userevents) - List user budget events
* [GetTeam](#getteam) - List team budgets
* [SetTeam](#setteam) - Set a team budget
* [DeleteTeam](#deleteteam) - Delete a team budget
* [TeamEvents](#teamevents) - List team budget events
* [GetExternalUser](#getexternaluser) - List external user budgets
* [SetExternalUser](#setexternaluser) - Set a external user budget
* [DeleteExternalUser](#deleteexternaluser) - Delete a external user budget
* [ExternalUserEvents](#externaluserevents) - List external user budget events
* [GetUserDefault](#getuserdefault) - List per-user default budgets
* [SetUserDefault](#setuserdefault) - Set a per-user default budget
* [DeleteUserDefault](#deleteuserdefault) - Delete a per-user default budget
* [UserDefaultEvents](#userdefaultevents) - List per-user default budget events
* [GetTeamDefault](#getteamdefault) - List per-team default budgets
* [SetTeamDefault](#setteamdefault) - Set a per-team default budget
* [DeleteTeamDefault](#deleteteamdefault) - Delete a per-team default budget
* [TeamDefaultEvents](#teamdefaultevents) - List per-team default budget events
* [GetExternalUserDefault](#getexternaluserdefault) - List per-external user default budgets
* [SetExternalUserDefault](#setexternaluserdefault) - Set a per-external user default budget
* [DeleteExternalUserDefault](#deleteexternaluserdefault) - Delete a per-external user default budget
* [ExternalUserDefaultEvents](#externaluserdefaultevents) - List per-external user default budget events
* [GetCurrency](#getcurrency) - Get display currency
* [SetCurrency](#setcurrency) - Set display currency

## List

Cluster admins see all budgets; org admins see their org's budgets (including member budgets and per-member default budgets) plus budgets on API keys in their org.

### Example Usage

<!-- UsageSnippet language="go" operationID="listBudgets" method="get" path="/api/v1/budgeting/budgets" -->
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

    res, err := s.Budgets.List(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListBudgetsResponse](../../models/operations/listbudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetOrg

Returns the org's budgets (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="go" operationID="getOrgBudgets" method="get" path="/api/v1/budgeting/budgets/org" -->
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

    res, err := s.Budgets.GetOrg(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetOrgBudgetsResponse](../../models/operations/getorgbudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetOrg

Creates or updates a budget for the org. One budget per (scope, owner); editing re-evaluates against live spend. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="go" operationID="setOrgBudget" method="put" path="/api/v1/budgeting/budgets/org" -->
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

    res, err := s.Budgets.SetOrg(ctx, operations.SetOrgBudgetRequestBody{
        Period: operations.SetOrgBudgetPeriodRequestMonthly,
        Limit: 8365.1,
        Thresholds: []operations.SetOrgBudgetThresholdRequest{},
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

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `body`                                                                                   | [operations.SetOrgBudgetRequestBody](../../models/operations/setorgbudgetrequestbody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `orgID`                                                                                  | `*string`                                                                                | :heavy_minus_sign:                                                                       | N/A                                                                                      |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.SetOrgBudgetResponse](../../models/operations/setorgbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteOrg

Removes the org's budget for the given owner; enforcement and alerts stop. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteOrgBudget" method="delete" path="/api/v1/budgeting/budgets/org" -->
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

    res, err := s.Budgets.DeleteOrg(ctx, operations.DeleteOrgBudgetQueryParamOwnerCluster, nil)
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
| `owner`                                                                                                | [operations.DeleteOrgBudgetQueryParamOwner](../../models/operations/deleteorgbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `orgID`                                                                                                | `*string`                                                                                              | :heavy_minus_sign:                                                                                     | N/A                                                                                                    |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.DeleteOrgBudgetResponse](../../models/operations/deleteorgbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## OrgEvents

Returns recent threshold-alert and block events for the org's budgets. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="go" operationID="listOrgBudgetEvents" method="get" path="/api/v1/budgeting/budgets/org/events" -->
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

    res, err := s.Budgets.OrgEvents(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListOrgBudgetEventsResponse](../../models/operations/listorgbudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetAPIKey

Returns the apikey's budgets (self-budget and/or ceiling) with each one's live spend gauge. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="go" operationID="getApiKeyBudgets" method="get" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
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

    res, err := s.Budgets.GetAPIKey(ctx, "<id>")
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `apiKeyID`                                               | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetAPIKeyBudgetsResponse](../../models/operations/getapikeybudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetAPIKey

Creates or updates a budget for the apikey. One budget per (scope, owner); editing re-evaluates against live spend. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="go" operationID="setApiKeyBudget" method="put" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
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

    res, err := s.Budgets.SetAPIKey(ctx, "<id>", operations.SetAPIKeyBudgetRequestBody{
        Period: operations.SetAPIKeyBudgetPeriodRequestWeekly,
        Limit: 7295.26,
        Thresholds: []operations.SetAPIKeyBudgetThresholdRequest{},
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

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `apiKeyID`                                                                                     | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `body`                                                                                         | [operations.SetAPIKeyBudgetRequestBody](../../models/operations/setapikeybudgetrequestbody.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.SetAPIKeyBudgetResponse](../../models/operations/setapikeybudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteAPIKey

Removes the apikey's budget for the given owner; enforcement and alerts stop. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteApiKeyBudget" method="delete" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
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

    res, err := s.Budgets.DeleteAPIKey(ctx, "<id>", operations.DeleteAPIKeyBudgetQueryParamOwnerOrg)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                        | :heavy_check_mark:                                                                                           | The context to use for the request.                                                                          |
| `apiKeyID`                                                                                                   | `string`                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `owner`                                                                                                      | [operations.DeleteAPIKeyBudgetQueryParamOwner](../../models/operations/deleteapikeybudgetqueryparamowner.md) | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `opts`                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                     | :heavy_minus_sign:                                                                                           | The options for this request.                                                                                |

### Response

**[*operations.DeleteAPIKeyBudgetResponse](../../models/operations/deleteapikeybudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## APIKeyEvents

Returns recent threshold-alert and block events for the apikey's budgets. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="go" operationID="listApiKeyBudgetEvents" method="get" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}/events" -->
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

    res, err := s.Budgets.APIKeyEvents(ctx, "<id>")
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `apiKeyID`                                               | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListAPIKeyBudgetEventsResponse](../../models/operations/listapikeybudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetUser

Returns the user's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="getUserBudgets" method="get" path="/api/v1/budgeting/budgets/user/{id}" -->
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

    res, err := s.Budgets.GetUser(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetUserBudgetsResponse](../../models/operations/getuserbudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetUser

Creates or updates a budget for the user in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit user budget replaces the org's per-user default budget of the same owner and period for this user (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="setUserBudget" method="put" path="/api/v1/budgeting/budgets/user/{id}" -->
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

    res, err := s.Budgets.SetUser(ctx, "<id>", operations.SetUserBudgetRequestBody{
        Period: operations.SetUserBudgetPeriodRequestWeekly,
        Limit: 6011.89,
        Thresholds: []operations.SetUserBudgetThresholdRequest{},
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

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `id`                                                                                       | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `body`                                                                                     | [operations.SetUserBudgetRequestBody](../../models/operations/setuserbudgetrequestbody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `orgID`                                                                                    | `*string`                                                                                  | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.SetUserBudgetResponse](../../models/operations/setuserbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteUser

Removes the user's budget for the given owner; the org's per-user default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteUserBudget" method="delete" path="/api/v1/budgeting/budgets/user/{id}" -->
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

    res, err := s.Budgets.DeleteUser(ctx, "<id>", operations.DeleteUserBudgetQueryParamOwnerOrg, nil)
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
| `id`                                                                                                     | `string`                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `owner`                                                                                                  | [operations.DeleteUserBudgetQueryParamOwner](../../models/operations/deleteuserbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `orgID`                                                                                                  | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.DeleteUserBudgetResponse](../../models/operations/deleteuserbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UserEvents

Returns recent threshold-alert and block events for the user's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="listUserBudgetEvents" method="get" path="/api/v1/budgeting/budgets/user/{id}/events" -->
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

    res, err := s.Budgets.UserEvents(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListUserBudgetEventsResponse](../../models/operations/listuserbudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetTeam

Returns the team's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="getTeamBudgets" method="get" path="/api/v1/budgeting/budgets/team/{id}" -->
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

    res, err := s.Budgets.GetTeam(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetTeamBudgetsResponse](../../models/operations/getteambudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetTeam

Creates or updates a budget for the team in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit team budget replaces the org's per-team default budget of the same owner and period for this team (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="setTeamBudget" method="put" path="/api/v1/budgeting/budgets/team/{id}" -->
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

    res, err := s.Budgets.SetTeam(ctx, "<id>", operations.SetTeamBudgetRequestBody{
        Period: operations.SetTeamBudgetPeriodRequestDaily,
        Limit: 3256.74,
        Thresholds: []operations.SetTeamBudgetThresholdRequest{},
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

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `id`                                                                                       | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `body`                                                                                     | [operations.SetTeamBudgetRequestBody](../../models/operations/setteambudgetrequestbody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `orgID`                                                                                    | `*string`                                                                                  | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.SetTeamBudgetResponse](../../models/operations/setteambudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteTeam

Removes the team's budget for the given owner; the org's per-team default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteTeamBudget" method="delete" path="/api/v1/budgeting/budgets/team/{id}" -->
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

    res, err := s.Budgets.DeleteTeam(ctx, "<id>", operations.DeleteTeamBudgetQueryParamOwnerCluster, nil)
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
| `id`                                                                                                     | `string`                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `owner`                                                                                                  | [operations.DeleteTeamBudgetQueryParamOwner](../../models/operations/deleteteambudgetqueryparamowner.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `orgID`                                                                                                  | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.DeleteTeamBudgetResponse](../../models/operations/deleteteambudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## TeamEvents

Returns recent threshold-alert and block events for the team's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="listTeamBudgetEvents" method="get" path="/api/v1/budgeting/budgets/team/{id}/events" -->
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

    res, err := s.Budgets.TeamEvents(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListTeamBudgetEventsResponse](../../models/operations/listteambudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetExternalUser

Returns the external user's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="getExternalUserBudgets" method="get" path="/api/v1/budgeting/budgets/external-user/{id}" -->
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

    res, err := s.Budgets.GetExternalUser(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetExternalUserBudgetsResponse](../../models/operations/getexternaluserbudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetExternalUser

Creates or updates a budget for the external user in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit external user budget replaces the org's per-external user default budget of the same owner and period for this external user (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="setExternalUserBudget" method="put" path="/api/v1/budgeting/budgets/external-user/{id}" -->
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

    res, err := s.Budgets.SetExternalUser(ctx, "<id>", operations.SetExternalUserBudgetRequestBody{
        Period: operations.SetExternalUserBudgetPeriodRequestMonthly,
        Limit: 9414.34,
        Thresholds: []operations.SetExternalUserBudgetThresholdRequest{
            operations.SetExternalUserBudgetThresholdRequest{
                Pct: 649006,
                Action: operations.SetExternalUserBudgetActionRequestBlock,
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
| `id`                                                                                                       | `string`                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `body`                                                                                                     | [operations.SetExternalUserBudgetRequestBody](../../models/operations/setexternaluserbudgetrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `orgID`                                                                                                    | `*string`                                                                                                  | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `opts`                                                                                                     | [][operations.Option](../../models/operations/option.md)                                                   | :heavy_minus_sign:                                                                                         | The options for this request.                                                                              |

### Response

**[*operations.SetExternalUserBudgetResponse](../../models/operations/setexternaluserbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteExternalUser

Removes the external user's budget for the given owner; the org's per-external user default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteExternalUserBudget" method="delete" path="/api/v1/budgeting/budgets/external-user/{id}" -->
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

    res, err := s.Budgets.DeleteExternalUser(ctx, "<id>", operations.DeleteExternalUserBudgetQueryParamOwnerCluster, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                                    | :heavy_check_mark:                                                                                                       | The context to use for the request.                                                                                      |
| `id`                                                                                                                     | `string`                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `owner`                                                                                                                  | [operations.DeleteExternalUserBudgetQueryParamOwner](../../models/operations/deleteexternaluserbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `orgID`                                                                                                                  | `*string`                                                                                                                | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |
| `opts`                                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                                 | :heavy_minus_sign:                                                                                                       | The options for this request.                                                                                            |

### Response

**[*operations.DeleteExternalUserBudgetResponse](../../models/operations/deleteexternaluserbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ExternalUserEvents

Returns recent threshold-alert and block events for the external user's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="listExternalUserBudgetEvents" method="get" path="/api/v1/budgeting/budgets/external-user/{id}/events" -->
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

    res, err := s.Budgets.ExternalUserEvents(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListExternalUserBudgetEventsResponse](../../models/operations/listexternaluserbudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetUserDefault

Returns the org's per-user default budgets (self-set and/or operator ceiling). A default budget applies to every user in the org against that user's own spend counter, unless an explicit user budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="getUserDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/user-default" -->
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

    res, err := s.Budgets.GetUserDefault(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetUserDefaultBudgetsResponse](../../models/operations/getuserdefaultbudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetUserDefault

Creates or updates the org's per-user default budget: a cap applying to EACH user in the org individually (not in aggregate), unless an explicit user budget of the same owner and period exists for them. Threshold alerts and blocks fire per user. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="setUserDefaultBudget" method="put" path="/api/v1/budgeting/budgets/user-default" -->
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

    res, err := s.Budgets.SetUserDefault(ctx, operations.SetUserDefaultBudgetRequestBody{
        Period: operations.SetUserDefaultBudgetPeriodRequestWeekly,
        Limit: 6669.11,
        Thresholds: []operations.SetUserDefaultBudgetThresholdRequest{},
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

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `body`                                                                                                   | [operations.SetUserDefaultBudgetRequestBody](../../models/operations/setuserdefaultbudgetrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `orgID`                                                                                                  | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.SetUserDefaultBudgetResponse](../../models/operations/setuserdefaultbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteUserDefault

Removes the org's per-user default budget for the given owner; only explicit user budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteUserDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/user-default" -->
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

    res, err := s.Budgets.DeleteUserDefault(ctx, operations.DeleteUserDefaultBudgetQueryParamOwnerCluster, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                  | :heavy_check_mark:                                                                                                     | The context to use for the request.                                                                                    |
| `owner`                                                                                                                | [operations.DeleteUserDefaultBudgetQueryParamOwner](../../models/operations/deleteuserdefaultbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `orgID`                                                                                                                | `*string`                                                                                                              | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `opts`                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                               | :heavy_minus_sign:                                                                                                     | The options for this request.                                                                                          |

### Response

**[*operations.DeleteUserDefaultBudgetResponse](../../models/operations/deleteuserdefaultbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UserDefaultEvents

Returns recent threshold-alert and block events for the org's per-user default budgets. Each event's target_id names the user it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="listUserDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/user-default/events" -->
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

    res, err := s.Budgets.UserDefaultEvents(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListUserDefaultBudgetEventsResponse](../../models/operations/listuserdefaultbudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetTeamDefault

Returns the org's per-team default budgets (self-set and/or operator ceiling). A default budget applies to every team in the org against that team's own spend counter, unless an explicit team budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="getTeamDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/team-default" -->
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

    res, err := s.Budgets.GetTeamDefault(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetTeamDefaultBudgetsResponse](../../models/operations/getteamdefaultbudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetTeamDefault

Creates or updates the org's per-team default budget: a cap applying to EACH team in the org individually (not in aggregate), unless an explicit team budget of the same owner and period exists for them. Threshold alerts and blocks fire per team. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="setTeamDefaultBudget" method="put" path="/api/v1/budgeting/budgets/team-default" -->
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

    res, err := s.Budgets.SetTeamDefault(ctx, operations.SetTeamDefaultBudgetRequestBody{
        Period: operations.SetTeamDefaultBudgetPeriodRequestDaily,
        Limit: 1351.42,
        Thresholds: []operations.SetTeamDefaultBudgetThresholdRequest{},
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

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `body`                                                                                                   | [operations.SetTeamDefaultBudgetRequestBody](../../models/operations/setteamdefaultbudgetrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `orgID`                                                                                                  | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.SetTeamDefaultBudgetResponse](../../models/operations/setteamdefaultbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteTeamDefault

Removes the org's per-team default budget for the given owner; only explicit team budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteTeamDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/team-default" -->
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

    res, err := s.Budgets.DeleteTeamDefault(ctx, operations.DeleteTeamDefaultBudgetQueryParamOwnerOrg, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                              | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                  | :heavy_check_mark:                                                                                                     | The context to use for the request.                                                                                    |
| `owner`                                                                                                                | [operations.DeleteTeamDefaultBudgetQueryParamOwner](../../models/operations/deleteteamdefaultbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `orgID`                                                                                                                | `*string`                                                                                                              | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `opts`                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                               | :heavy_minus_sign:                                                                                                     | The options for this request.                                                                                          |

### Response

**[*operations.DeleteTeamDefaultBudgetResponse](../../models/operations/deleteteamdefaultbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## TeamDefaultEvents

Returns recent threshold-alert and block events for the org's per-team default budgets. Each event's target_id names the team it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="listTeamDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/team-default/events" -->
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

    res, err := s.Budgets.TeamDefaultEvents(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListTeamDefaultBudgetEventsResponse](../../models/operations/listteamdefaultbudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetExternalUserDefault

Returns the org's per-external user default budgets (self-set and/or operator ceiling). A default budget applies to every external user in the org against that external user's own spend counter, unless an explicit external user budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="getExternalUserDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/external-user-default" -->
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

    res, err := s.Budgets.GetExternalUserDefault(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetExternalUserDefaultBudgetsResponse](../../models/operations/getexternaluserdefaultbudgetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetExternalUserDefault

Creates or updates the org's per-external user default budget: a cap applying to EACH external user in the org individually (not in aggregate), unless an explicit external user budget of the same owner and period exists for them. Threshold alerts and blocks fire per external user. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="setExternalUserDefaultBudget" method="put" path="/api/v1/budgeting/budgets/external-user-default" -->
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

    res, err := s.Budgets.SetExternalUserDefault(ctx, operations.SetExternalUserDefaultBudgetRequestBody{
        Period: operations.SetExternalUserDefaultBudgetPeriodRequestMonthly,
        Limit: 7392.64,
        Thresholds: []operations.SetExternalUserDefaultBudgetThresholdRequest{},
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

| Parameter                                                                                                                | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                                    | :heavy_check_mark:                                                                                                       | The context to use for the request.                                                                                      |
| `body`                                                                                                                   | [operations.SetExternalUserDefaultBudgetRequestBody](../../models/operations/setexternaluserdefaultbudgetrequestbody.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `orgID`                                                                                                                  | `*string`                                                                                                                | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |
| `opts`                                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                                 | :heavy_minus_sign:                                                                                                       | The options for this request.                                                                                            |

### Response

**[*operations.SetExternalUserDefaultBudgetResponse](../../models/operations/setexternaluserdefaultbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteExternalUserDefault

Removes the org's per-external user default budget for the given owner; only explicit external user budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteExternalUserDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/external-user-default" -->
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

    res, err := s.Budgets.DeleteExternalUserDefault(ctx, operations.DeleteExternalUserDefaultBudgetQueryParamOwnerCluster, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                              | Type                                                                                                                                   | Required                                                                                                                               | Description                                                                                                                            |
| -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                                                  | :heavy_check_mark:                                                                                                                     | The context to use for the request.                                                                                                    |
| `owner`                                                                                                                                | [operations.DeleteExternalUserDefaultBudgetQueryParamOwner](../../models/operations/deleteexternaluserdefaultbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `orgID`                                                                                                                                | `*string`                                                                                                                              | :heavy_minus_sign:                                                                                                                     | N/A                                                                                                                                    |
| `opts`                                                                                                                                 | [][operations.Option](../../models/operations/option.md)                                                                               | :heavy_minus_sign:                                                                                                                     | The options for this request.                                                                                                          |

### Response

**[*operations.DeleteExternalUserDefaultBudgetResponse](../../models/operations/deleteexternaluserdefaultbudgetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ExternalUserDefaultEvents

Returns recent threshold-alert and block events for the org's per-external user default budgets. Each event's target_id names the external user it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="go" operationID="listExternalUserDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/external-user-default/events" -->
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

    res, err := s.Budgets.ExternalUserDefaultEvents(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListExternalUserDefaultBudgetEventsResponse](../../models/operations/listexternaluserdefaultbudgeteventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetCurrency

Get display currency

### Example Usage

<!-- UsageSnippet language="go" operationID="getCurrency" method="get" path="/api/v1/budgeting/settings/currency" -->
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

    res, err := s.Budgets.GetCurrency(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetCurrencyResponse](../../models/operations/getcurrencyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetCurrency

ISO 4217 code used for display on budgets and cost reports. No conversion is performed anywhere.

### Example Usage

<!-- UsageSnippet language="go" operationID="setCurrency" method="put" path="/api/v1/budgeting/settings/currency" -->
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

    res, err := s.Budgets.SetCurrency(ctx, operations.SetCurrencyRequest{
        Currency: "Kwacha",
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

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `request`                                                                      | [operations.SetCurrencyRequest](../../models/operations/setcurrencyrequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.SetCurrencyResponse](../../models/operations/setcurrencyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |