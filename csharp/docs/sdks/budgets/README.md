# Budgets

## Overview

### Available Operations

* [List](#list) - List budgets
* [GetOrg](#getorg) - List org budgets
* [SetOrg](#setorg) - Set an org budget
* [DeleteOrg](#deleteorg) - Delete an org budget
* [OrgEvents](#orgevents) - List org budget events
* [GetApiKey](#getapikey) - List apikey budgets
* [SetApiKey](#setapikey) - Set an apikey budget
* [DeleteApiKey](#deleteapikey) - Delete an apikey budget
* [ApiKeyEvents](#apikeyevents) - List apikey budget events
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

<!-- UsageSnippet language="csharp" operationID="listBudgets" method="get" path="/api/v1/budgeting/budgets" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.ListAsync();

// handle response
```

### Response

**[ListBudgetsResponse](../../Types/Requests/ListBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetOrg

Returns the org's budgets (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrgBudgets" method="get" path="/api/v1/budgeting/budgets/org" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetOrgAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetOrgBudgetsResponse](../../Types/Requests/GetOrgBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetOrg

Creates or updates a budget for the org. One budget per (scope, owner); editing re-evaluates against live spend. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setOrgBudget" method="put" path="/api/v1/budgeting/budgets/org" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetOrgAsync(body: new SetOrgBudgetRequestBody() {
    Period = SetOrgBudgetPeriodRequest.Monthly,
    Limit = 1009.12D,
    Thresholds = new List<SetOrgBudgetThresholdRequest>() {},
});

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Body`                                                                     | [SetOrgBudgetRequestBody](../../Types/Requests/SetOrgBudgetRequestBody.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `OrgId`                                                                    | *string*                                                                   | :heavy_minus_sign:                                                         | N/A                                                                        |

### Response

**[SetOrgBudgetResponse](../../Types/Requests/SetOrgBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteOrg

Removes the org's budget for the given owner; enforcement and alerts stop. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteOrgBudget" method="delete" path="/api/v1/budgeting/budgets/org" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteOrgAsync(owner: DeleteOrgBudgetQueryParamOwner.Cluster);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `Owner`                                                                                  | [DeleteOrgBudgetQueryParamOwner](../../Types/Requests/DeleteOrgBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `OrgId`                                                                                  | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |

### Response

**[DeleteOrgBudgetResponse](../../Types/Requests/DeleteOrgBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## OrgEvents

Returns recent threshold-alert and block events for the org's budgets. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listOrgBudgetEvents" method="get" path="/api/v1/budgeting/budgets/org/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.OrgEventsAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListOrgBudgetEventsResponse](../../Types/Requests/ListOrgBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetApiKey

Returns the apikey's budgets (self-budget and/or ceiling) with each one's live spend gauge. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getApiKeyBudgets" method="get" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetApiKeyAsync(apiKeyId: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ApiKeyId`         | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetApiKeyBudgetsResponse](../../Types/Requests/GetApiKeyBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetApiKey

Creates or updates a budget for the apikey. One budget per (scope, owner); editing re-evaluates against live spend. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setApiKeyBudget" method="put" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetApiKeyAsync(
    apiKeyId: "<id>",
    body: new SetApiKeyBudgetRequestBody() {
        Period = SetApiKeyBudgetPeriodRequest.Weekly,
        Limit = 3281.35D,
        Thresholds = new List<SetApiKeyBudgetThresholdRequest>() {
            new SetApiKeyBudgetThresholdRequest() {
                Pct = 793338,
                Action = SetApiKeyBudgetActionRequest.Alert,
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ApiKeyId`                                                                       | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `Body`                                                                           | [SetApiKeyBudgetRequestBody](../../Types/Requests/SetApiKeyBudgetRequestBody.md) | :heavy_check_mark:                                                               | N/A                                                                              |

### Response

**[SetApiKeyBudgetResponse](../../Types/Requests/SetApiKeyBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteApiKey

Removes the apikey's budget for the given owner; enforcement and alerts stop. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteApiKeyBudget" method="delete" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteApiKeyAsync(
    apiKeyId: "<id>",
    owner: DeleteApiKeyBudgetQueryParamOwner.Org
);

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ApiKeyId`                                                                                     | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `Owner`                                                                                        | [DeleteApiKeyBudgetQueryParamOwner](../../Types/Requests/DeleteApiKeyBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |

### Response

**[DeleteApiKeyBudgetResponse](../../Types/Requests/DeleteApiKeyBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ApiKeyEvents

Returns recent threshold-alert and block events for the apikey's budgets. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listApiKeyBudgetEvents" method="get" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.ApiKeyEventsAsync(apiKeyId: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `ApiKeyId`         | *string*           | :heavy_check_mark: | N/A                |

### Response

**[ListApiKeyBudgetEventsResponse](../../Types/Requests/ListApiKeyBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetUser

Returns the user's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUserBudgets" method="get" path="/api/v1/budgeting/budgets/user/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetUserAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetUserBudgetsResponse](../../Types/Requests/GetUserBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetUser

Creates or updates a budget for the user in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit user budget replaces the org's per-user default budget of the same owner and period for this user (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setUserBudget" method="put" path="/api/v1/budgeting/budgets/user/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetUserAsync(
    id: "<id>",
    body: new SetUserBudgetRequestBody() {
        Period = SetUserBudgetPeriodRequest.Weekly,
        Limit = 6011.89D,
        Thresholds = new List<SetUserBudgetThresholdRequest>() {},
    }
);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `Body`                                                                       | [SetUserBudgetRequestBody](../../Types/Requests/SetUserBudgetRequestBody.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `OrgId`                                                                      | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |

### Response

**[SetUserBudgetResponse](../../Types/Requests/SetUserBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteUser

Removes the user's budget for the given owner; the org's per-user default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteUserBudget" method="delete" path="/api/v1/budgeting/budgets/user/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteUserAsync(
    id: "<id>",
    owner: DeleteUserBudgetQueryParamOwner.Org
);

// handle response
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `Owner`                                                                                    | [DeleteUserBudgetQueryParamOwner](../../Types/Requests/DeleteUserBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `OrgId`                                                                                    | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |

### Response

**[DeleteUserBudgetResponse](../../Types/Requests/DeleteUserBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UserEvents

Returns recent threshold-alert and block events for the user's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUserBudgetEvents" method="get" path="/api/v1/budgeting/budgets/user/{id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.UserEventsAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListUserBudgetEventsResponse](../../Types/Requests/ListUserBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetTeam

Returns the team's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTeamBudgets" method="get" path="/api/v1/budgeting/budgets/team/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetTeamAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetTeamBudgetsResponse](../../Types/Requests/GetTeamBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetTeam

Creates or updates a budget for the team in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit team budget replaces the org's per-team default budget of the same owner and period for this team (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setTeamBudget" method="put" path="/api/v1/budgeting/budgets/team/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetTeamAsync(
    id: "<id>",
    body: new SetTeamBudgetRequestBody() {
        Period = SetTeamBudgetPeriodRequest.Daily,
        Limit = 3256.74D,
        Thresholds = new List<SetTeamBudgetThresholdRequest>() {},
    }
);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `Body`                                                                       | [SetTeamBudgetRequestBody](../../Types/Requests/SetTeamBudgetRequestBody.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `OrgId`                                                                      | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |

### Response

**[SetTeamBudgetResponse](../../Types/Requests/SetTeamBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteTeam

Removes the team's budget for the given owner; the org's per-team default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteTeamBudget" method="delete" path="/api/v1/budgeting/budgets/team/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteTeamAsync(
    id: "<id>",
    owner: DeleteTeamBudgetQueryParamOwner.Cluster
);

// handle response
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `Owner`                                                                                    | [DeleteTeamBudgetQueryParamOwner](../../Types/Requests/DeleteTeamBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `OrgId`                                                                                    | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |

### Response

**[DeleteTeamBudgetResponse](../../Types/Requests/DeleteTeamBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## TeamEvents

Returns recent threshold-alert and block events for the team's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTeamBudgetEvents" method="get" path="/api/v1/budgeting/budgets/team/{id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.TeamEventsAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListTeamBudgetEventsResponse](../../Types/Requests/ListTeamBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetExternalUser

Returns the external user's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getExternalUserBudgets" method="get" path="/api/v1/budgeting/budgets/external-user/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetExternalUserAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetExternalUserBudgetsResponse](../../Types/Requests/GetExternalUserBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetExternalUser

Creates or updates a budget for the external user in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit external user budget replaces the org's per-external user default budget of the same owner and period for this external user (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setExternalUserBudget" method="put" path="/api/v1/budgeting/budgets/external-user/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetExternalUserAsync(
    id: "<id>",
    body: new SetExternalUserBudgetRequestBody() {
        Period = SetExternalUserBudgetPeriodRequest.Monthly,
        Limit = 9414.34D,
        Thresholds = new List<SetExternalUserBudgetThresholdRequest>() {
            new SetExternalUserBudgetThresholdRequest() {
                Pct = 649006,
                Action = SetExternalUserBudgetActionRequest.Block,
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `Id`                                                                                         | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `Body`                                                                                       | [SetExternalUserBudgetRequestBody](../../Types/Requests/SetExternalUserBudgetRequestBody.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `OrgId`                                                                                      | *string*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          |

### Response

**[SetExternalUserBudgetResponse](../../Types/Requests/SetExternalUserBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteExternalUser

Removes the external user's budget for the given owner; the org's per-external user default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteExternalUserBudget" method="delete" path="/api/v1/budgeting/budgets/external-user/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteExternalUserAsync(
    id: "<id>",
    owner: DeleteExternalUserBudgetQueryParamOwner.Cluster
);

// handle response
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `Id`                                                                                                       | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `Owner`                                                                                                    | [DeleteExternalUserBudgetQueryParamOwner](../../Types/Requests/DeleteExternalUserBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `OrgId`                                                                                                    | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |

### Response

**[DeleteExternalUserBudgetResponse](../../Types/Requests/DeleteExternalUserBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ExternalUserEvents

Returns recent threshold-alert and block events for the external user's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listExternalUserBudgetEvents" method="get" path="/api/v1/budgeting/budgets/external-user/{id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.ExternalUserEventsAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListExternalUserBudgetEventsResponse](../../Types/Requests/ListExternalUserBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetUserDefault

Returns the org's per-user default budgets (self-set and/or operator ceiling). A default budget applies to every user in the org against that user's own spend counter, unless an explicit user budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUserDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/user-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetUserDefaultAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetUserDefaultBudgetsResponse](../../Types/Requests/GetUserDefaultBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetUserDefault

Creates or updates the org's per-user default budget: a cap applying to EACH user in the org individually (not in aggregate), unless an explicit user budget of the same owner and period exists for them. Threshold alerts and blocks fire per user. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setUserDefaultBudget" method="put" path="/api/v1/budgeting/budgets/user-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetUserDefaultAsync(body: new SetUserDefaultBudgetRequestBody() {
    Period = SetUserDefaultBudgetPeriodRequest.Weekly,
    Limit = 6669.11D,
    Thresholds = new List<SetUserDefaultBudgetThresholdRequest>() {},
});

// handle response
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Body`                                                                                     | [SetUserDefaultBudgetRequestBody](../../Types/Requests/SetUserDefaultBudgetRequestBody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `OrgId`                                                                                    | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |

### Response

**[SetUserDefaultBudgetResponse](../../Types/Requests/SetUserDefaultBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteUserDefault

Removes the org's per-user default budget for the given owner; only explicit user budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteUserDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/user-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteUserDefaultAsync(owner: DeleteUserDefaultBudgetQueryParamOwner.Cluster);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `Owner`                                                                                                  | [DeleteUserDefaultBudgetQueryParamOwner](../../Types/Requests/DeleteUserDefaultBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `OrgId`                                                                                                  | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |

### Response

**[DeleteUserDefaultBudgetResponse](../../Types/Requests/DeleteUserDefaultBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UserDefaultEvents

Returns recent threshold-alert and block events for the org's per-user default budgets. Each event's target_id names the user it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listUserDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/user-default/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.UserDefaultEventsAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListUserDefaultBudgetEventsResponse](../../Types/Requests/ListUserDefaultBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetTeamDefault

Returns the org's per-team default budgets (self-set and/or operator ceiling). A default budget applies to every team in the org against that team's own spend counter, unless an explicit team budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTeamDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/team-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetTeamDefaultAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetTeamDefaultBudgetsResponse](../../Types/Requests/GetTeamDefaultBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetTeamDefault

Creates or updates the org's per-team default budget: a cap applying to EACH team in the org individually (not in aggregate), unless an explicit team budget of the same owner and period exists for them. Threshold alerts and blocks fire per team. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setTeamDefaultBudget" method="put" path="/api/v1/budgeting/budgets/team-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetTeamDefaultAsync(body: new SetTeamDefaultBudgetRequestBody() {
    Period = SetTeamDefaultBudgetPeriodRequest.Daily,
    Limit = 1351.42D,
    Thresholds = new List<SetTeamDefaultBudgetThresholdRequest>() {},
});

// handle response
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Body`                                                                                     | [SetTeamDefaultBudgetRequestBody](../../Types/Requests/SetTeamDefaultBudgetRequestBody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `OrgId`                                                                                    | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |

### Response

**[SetTeamDefaultBudgetResponse](../../Types/Requests/SetTeamDefaultBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteTeamDefault

Removes the org's per-team default budget for the given owner; only explicit team budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteTeamDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/team-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteTeamDefaultAsync(owner: DeleteTeamDefaultBudgetQueryParamOwner.Org);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `Owner`                                                                                                  | [DeleteTeamDefaultBudgetQueryParamOwner](../../Types/Requests/DeleteTeamDefaultBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `OrgId`                                                                                                  | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |

### Response

**[DeleteTeamDefaultBudgetResponse](../../Types/Requests/DeleteTeamDefaultBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## TeamDefaultEvents

Returns recent threshold-alert and block events for the org's per-team default budgets. Each event's target_id names the team it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listTeamDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/team-default/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.TeamDefaultEventsAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListTeamDefaultBudgetEventsResponse](../../Types/Requests/ListTeamDefaultBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetExternalUserDefault

Returns the org's per-external user default budgets (self-set and/or operator ceiling). A default budget applies to every external user in the org against that external user's own spend counter, unless an explicit external user budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getExternalUserDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/external-user-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetExternalUserDefaultAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[GetExternalUserDefaultBudgetsResponse](../../Types/Requests/GetExternalUserDefaultBudgetsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetExternalUserDefault

Creates or updates the org's per-external user default budget: a cap applying to EACH external user in the org individually (not in aggregate), unless an explicit external user budget of the same owner and period exists for them. Threshold alerts and blocks fire per external user. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setExternalUserDefaultBudget" method="put" path="/api/v1/budgeting/budgets/external-user-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.SetExternalUserDefaultAsync(body: new SetExternalUserDefaultBudgetRequestBody() {
    Period = SetExternalUserDefaultBudgetPeriodRequest.Monthly,
    Limit = 7392.64D,
    Thresholds = new List<SetExternalUserDefaultBudgetThresholdRequest>() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                     | [SetExternalUserDefaultBudgetRequestBody](../../Types/Requests/SetExternalUserDefaultBudgetRequestBody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `OrgId`                                                                                                    | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |

### Response

**[SetExternalUserDefaultBudgetResponse](../../Types/Requests/SetExternalUserDefaultBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteExternalUserDefault

Removes the org's per-external user default budget for the given owner; only explicit external user budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteExternalUserDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/external-user-default" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.DeleteExternalUserDefaultAsync(owner: DeleteExternalUserDefaultBudgetQueryParamOwner.Cluster);

// handle response
```

### Parameters

| Parameter                                                                                                                | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `Owner`                                                                                                                  | [DeleteExternalUserDefaultBudgetQueryParamOwner](../../Types/Requests/DeleteExternalUserDefaultBudgetQueryParamOwner.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `OrgId`                                                                                                                  | *string*                                                                                                                 | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |

### Response

**[DeleteExternalUserDefaultBudgetResponse](../../Types/Requests/DeleteExternalUserDefaultBudgetResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ExternalUserDefaultEvents

Returns recent threshold-alert and block events for the org's per-external user default budgets. Each event's target_id names the external user it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listExternalUserDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/external-user-default/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.ExternalUserDefaultEventsAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListExternalUserDefaultBudgetEventsResponse](../../Types/Requests/ListExternalUserDefaultBudgetEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetCurrency

Get display currency

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCurrency" method="get" path="/api/v1/budgeting/settings/currency" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Budgets.GetCurrencyAsync();

// handle response
```

### Response

**[GetCurrencyResponse](../../Types/Requests/GetCurrencyResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetCurrency

ISO 4217 code used for display on budgets and cost reports. No conversion is performed anywhere.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setCurrency" method="put" path="/api/v1/budgeting/settings/currency" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

SetCurrencyRequest req = new SetCurrencyRequest() {
    Currency = "Kwacha",
};

var res = await sdk.Budgets.SetCurrencyAsync(req);

// handle response
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [SetCurrencyRequest](../../Types/Requests/SetCurrencyRequest.md) | :heavy_check_mark:                                               | The request object to use for the request.                       |

### Response

**[SetCurrencyResponse](../../Types/Requests/SetCurrencyResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |