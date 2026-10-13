# Budgets

## Overview

### Available Operations

* [list](#list) - List budgets
* [get_org](#get_org) - List org budgets
* [set_org](#set_org) - Set an org budget
* [delete_org](#delete_org) - Delete an org budget
* [org_events](#org_events) - List org budget events
* [get_api_key](#get_api_key) - List apikey budgets
* [set_api_key](#set_api_key) - Set an apikey budget
* [delete_api_key](#delete_api_key) - Delete an apikey budget
* [api_key_events](#api_key_events) - List apikey budget events
* [get_user](#get_user) - List user budgets
* [set_user](#set_user) - Set a user budget
* [delete_user](#delete_user) - Delete a user budget
* [user_events](#user_events) - List user budget events
* [get_team](#get_team) - List team budgets
* [set_team](#set_team) - Set a team budget
* [delete_team](#delete_team) - Delete a team budget
* [team_events](#team_events) - List team budget events
* [get_external_user](#get_external_user) - List external user budgets
* [set_external_user](#set_external_user) - Set a external user budget
* [delete_external_user](#delete_external_user) - Delete a external user budget
* [external_user_events](#external_user_events) - List external user budget events
* [get_user_default](#get_user_default) - List per-user default budgets
* [set_user_default](#set_user_default) - Set a per-user default budget
* [delete_user_default](#delete_user_default) - Delete a per-user default budget
* [user_default_events](#user_default_events) - List per-user default budget events
* [get_team_default](#get_team_default) - List per-team default budgets
* [set_team_default](#set_team_default) - Set a per-team default budget
* [delete_team_default](#delete_team_default) - Delete a per-team default budget
* [team_default_events](#team_default_events) - List per-team default budget events
* [get_external_user_default](#get_external_user_default) - List per-external user default budgets
* [set_external_user_default](#set_external_user_default) - Set a per-external user default budget
* [delete_external_user_default](#delete_external_user_default) - Delete a per-external user default budget
* [external_user_default_events](#external_user_default_events) - List per-external user default budget events
* [get_currency](#get_currency) - Get display currency
* [set_currency](#set_currency) - Set display currency

## list

Cluster admins see all budgets; org admins see their org's budgets (including member budgets and per-member default budgets) plus budgets on API keys in their org.

### Example Usage

<!-- UsageSnippet language="python" operationID="listBudgets" method="get" path="/api/v1/budgeting/budgets" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.list()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListBudgetsResponse](../../models/listbudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_org

Returns the org's budgets (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="python" operationID="getOrgBudgets" method="get" path="/api/v1/budgeting/budgets/org" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_org()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetOrgBudgetsResponse](../../models/getorgbudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_org

Creates or updates a budget for the org. One budget per (scope, owner); editing re-evaluates against live spend. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="python" operationID="setOrgBudget" method="put" path="/api/v1/budgeting/budgets/org" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_org(period="monthly", limit=1009.12, thresholds=[], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `period`                                                                                  | [models.SetOrgBudgetPeriodRequest](../../models/setorgbudgetperiodrequest.md)             | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `limit`                                                                                   | *float*                                                                                   | :heavy_check_mark:                                                                        | Spend limit in major currency units                                                       |
| `thresholds`                                                                              | List[[models.SetOrgBudgetThresholdRequest](../../models/setorgbudgetthresholdrequest.md)] | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `org_id`                                                                                  | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `owner`                                                                                   | [Optional[models.SetOrgBudgetOwnerRequest]](../../models/setorgbudgetownerrequest.md)     | :heavy_minus_sign:                                                                        | cluster = operator ceiling (org-admin read-only); org = self-budget                       |
| `webhook_url`                                                                             | *OptionalNullable[str]*                                                                   | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `webhook_secret`                                                                          | *OptionalNullable[str]*                                                                   | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `retries`                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                          | :heavy_minus_sign:                                                                        | Configuration to override the default retry behavior of the client.                       |

### Response

**[models.SetOrgBudgetResponse](../../models/setorgbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_org

Removes the org's budget for the given owner; enforcement and alerts stop. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteOrgBudget" method="delete" path="/api/v1/budgeting/budgets/org" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_org(owner="cluster")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `owner`                                                                                 | [models.DeleteOrgBudgetQueryParamOwner](../../models/deleteorgbudgetqueryparamowner.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `org_id`                                                                                | *Optional[str]*                                                                         | :heavy_minus_sign:                                                                      | N/A                                                                                     |
| `retries`                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                        | :heavy_minus_sign:                                                                      | Configuration to override the default retry behavior of the client.                     |

### Response

**[models.DeleteOrgBudgetResponse](../../models/deleteorgbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## org_events

Returns recent threshold-alert and block events for the org's budgets. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only.

### Example Usage

<!-- UsageSnippet language="python" operationID="listOrgBudgetEvents" method="get" path="/api/v1/budgeting/budgets/org/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.org_events()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListOrgBudgetEventsResponse](../../models/listorgbudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_api_key

Returns the apikey's budgets (self-budget and/or ceiling) with each one's live spend gauge. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="python" operationID="getApiKeyBudgets" method="get" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_api_key(api_key_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `api_key_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetAPIKeyBudgetsResponse](../../models/getapikeybudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_api_key

Creates or updates a budget for the apikey. One budget per (scope, owner); editing re-evaluates against live spend. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="python" operationID="setApiKeyBudget" method="put" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_api_key(api_key_id="<id>", period="weekly", limit=3281.35, thresholds=[
        {
            "pct": 793338,
            "action": "alert",
        },
    ], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `api_key_id`                                                                                    | *str*                                                                                           | :heavy_check_mark:                                                                              | N/A                                                                                             |
| `period`                                                                                        | [models.SetAPIKeyBudgetPeriodRequest](../../models/setapikeybudgetperiodrequest.md)             | :heavy_check_mark:                                                                              | N/A                                                                                             |
| `limit`                                                                                         | *float*                                                                                         | :heavy_check_mark:                                                                              | Spend limit in major currency units                                                             |
| `thresholds`                                                                                    | List[[models.SetAPIKeyBudgetThresholdRequest](../../models/setapikeybudgetthresholdrequest.md)] | :heavy_check_mark:                                                                              | N/A                                                                                             |
| `owner`                                                                                         | [Optional[models.SetAPIKeyBudgetOwnerRequest]](../../models/setapikeybudgetownerrequest.md)     | :heavy_minus_sign:                                                                              | cluster = operator ceiling (org-admin read-only); org = self-budget                             |
| `webhook_url`                                                                                   | *OptionalNullable[str]*                                                                         | :heavy_minus_sign:                                                                              | N/A                                                                                             |
| `webhook_secret`                                                                                | *OptionalNullable[str]*                                                                         | :heavy_minus_sign:                                                                              | N/A                                                                                             |
| `retries`                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                | :heavy_minus_sign:                                                                              | Configuration to override the default retry behavior of the client.                             |

### Response

**[models.SetAPIKeyBudgetResponse](../../models/setapikeybudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_api_key

Removes the apikey's budget for the given owner; enforcement and alerts stop. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteApiKeyBudget" method="delete" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_api_key(api_key_id="<id>", owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `api_key_id`                                                                                  | *str*                                                                                         | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `owner`                                                                                       | [models.DeleteAPIKeyBudgetQueryParamOwner](../../models/deleteapikeybudgetqueryparamowner.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `retries`                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                              | :heavy_minus_sign:                                                                            | Configuration to override the default retry behavior of the client.                           |

### Response

**[models.DeleteAPIKeyBudgetResponse](../../models/deleteapikeybudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## api_key_events

Returns recent threshold-alert and block events for the apikey's budgets. Callable by cluster admins, or org admins for API keys in their own organization.

### Example Usage

<!-- UsageSnippet language="python" operationID="listApiKeyBudgetEvents" method="get" path="/api/v1/budgeting/budgets/apikey/{apiKeyId}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.api_key_events(api_key_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `api_key_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListAPIKeyBudgetEventsResponse](../../models/listapikeybudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_user

Returns the user's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="getUserBudgets" method="get" path="/api/v1/budgeting/budgets/user/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_user(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetUserBudgetsResponse](../../models/getuserbudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_user

Creates or updates a budget for the user in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit user budget replaces the org's per-user default budget of the same owner and period for this user (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="setUserBudget" method="put" path="/api/v1/budgeting/budgets/user/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_user(id="<id>", period="weekly", limit=6011.89, thresholds=[], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `id`                                                                                        | *str*                                                                                       | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `period`                                                                                    | [models.SetUserBudgetPeriodRequest](../../models/setuserbudgetperiodrequest.md)             | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `limit`                                                                                     | *float*                                                                                     | :heavy_check_mark:                                                                          | Spend limit in major currency units                                                         |
| `thresholds`                                                                                | List[[models.SetUserBudgetThresholdRequest](../../models/setuserbudgetthresholdrequest.md)] | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `org_id`                                                                                    | *Optional[str]*                                                                             | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `owner`                                                                                     | [Optional[models.SetUserBudgetOwnerRequest]](../../models/setuserbudgetownerrequest.md)     | :heavy_minus_sign:                                                                          | cluster = operator ceiling (org-admin read-only); org = self-budget                         |
| `webhook_url`                                                                               | *OptionalNullable[str]*                                                                     | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `webhook_secret`                                                                            | *OptionalNullable[str]*                                                                     | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `retries`                                                                                   | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                            | :heavy_minus_sign:                                                                          | Configuration to override the default retry behavior of the client.                         |

### Response

**[models.SetUserBudgetResponse](../../models/setuserbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_user

Removes the user's budget for the given owner; the org's per-user default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteUserBudget" method="delete" path="/api/v1/budgeting/budgets/user/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_user(id="<id>", owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `id`                                                                                      | *str*                                                                                     | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `owner`                                                                                   | [models.DeleteUserBudgetQueryParamOwner](../../models/deleteuserbudgetqueryparamowner.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `org_id`                                                                                  | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `retries`                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                          | :heavy_minus_sign:                                                                        | Configuration to override the default retry behavior of the client.                       |

### Response

**[models.DeleteUserBudgetResponse](../../models/deleteuserbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## user_events

Returns recent threshold-alert and block events for the user's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="listUserBudgetEvents" method="get" path="/api/v1/budgeting/budgets/user/{id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.user_events(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListUserBudgetEventsResponse](../../models/listuserbudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_team

Returns the team's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="getTeamBudgets" method="get" path="/api/v1/budgeting/budgets/team/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_team(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetTeamBudgetsResponse](../../models/getteambudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_team

Creates or updates a budget for the team in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit team budget replaces the org's per-team default budget of the same owner and period for this team (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="setTeamBudget" method="put" path="/api/v1/budgeting/budgets/team/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_team(id="<id>", period="daily", limit=3256.74, thresholds=[], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `id`                                                                                        | *str*                                                                                       | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `period`                                                                                    | [models.SetTeamBudgetPeriodRequest](../../models/setteambudgetperiodrequest.md)             | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `limit`                                                                                     | *float*                                                                                     | :heavy_check_mark:                                                                          | Spend limit in major currency units                                                         |
| `thresholds`                                                                                | List[[models.SetTeamBudgetThresholdRequest](../../models/setteambudgetthresholdrequest.md)] | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `org_id`                                                                                    | *Optional[str]*                                                                             | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `owner`                                                                                     | [Optional[models.SetTeamBudgetOwnerRequest]](../../models/setteambudgetownerrequest.md)     | :heavy_minus_sign:                                                                          | cluster = operator ceiling (org-admin read-only); org = self-budget                         |
| `webhook_url`                                                                               | *OptionalNullable[str]*                                                                     | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `webhook_secret`                                                                            | *OptionalNullable[str]*                                                                     | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `retries`                                                                                   | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                            | :heavy_minus_sign:                                                                          | Configuration to override the default retry behavior of the client.                         |

### Response

**[models.SetTeamBudgetResponse](../../models/setteambudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_team

Removes the team's budget for the given owner; the org's per-team default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteTeamBudget" method="delete" path="/api/v1/budgeting/budgets/team/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_team(id="<id>", owner="cluster")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `id`                                                                                      | *str*                                                                                     | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `owner`                                                                                   | [models.DeleteTeamBudgetQueryParamOwner](../../models/deleteteambudgetqueryparamowner.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `org_id`                                                                                  | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `retries`                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                          | :heavy_minus_sign:                                                                        | Configuration to override the default retry behavior of the client.                       |

### Response

**[models.DeleteTeamBudgetResponse](../../models/deleteteambudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## team_events

Returns recent threshold-alert and block events for the team's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for teams in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="listTeamBudgetEvents" method="get" path="/api/v1/budgeting/budgets/team/{id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.team_events(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListTeamBudgetEventsResponse](../../models/listteambudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_external_user

Returns the external user's budgets in the target org (self-budget and/or ceiling) with each one's live spend gauge. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="getExternalUserBudgets" method="get" path="/api/v1/budgeting/budgets/external-user/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_external_user(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetExternalUserBudgetsResponse](../../models/getexternaluserbudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_external_user

Creates or updates a budget for the external user in the target org. One budget per (scope, owner); editing re-evaluates against live spend. An explicit external user budget replaces the org's per-external user default budget of the same owner and period for this external user (exemption-by-override — it may raise or tighten it); different-period defaults, org budgets, and API-key budgets still apply. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="setExternalUserBudget" method="put" path="/api/v1/budgeting/budgets/external-user/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_external_user(id="<id>", period="monthly", limit=9414.34, thresholds=[
        {
            "pct": 649006,
            "action": "block",
        },
    ], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                        | *str*                                                                                                       | :heavy_check_mark:                                                                                          | N/A                                                                                                         |
| `period`                                                                                                    | [models.SetExternalUserBudgetPeriodRequest](../../models/setexternaluserbudgetperiodrequest.md)             | :heavy_check_mark:                                                                                          | N/A                                                                                                         |
| `limit`                                                                                                     | *float*                                                                                                     | :heavy_check_mark:                                                                                          | Spend limit in major currency units                                                                         |
| `thresholds`                                                                                                | List[[models.SetExternalUserBudgetThresholdRequest](../../models/setexternaluserbudgetthresholdrequest.md)] | :heavy_check_mark:                                                                                          | N/A                                                                                                         |
| `org_id`                                                                                                    | *Optional[str]*                                                                                             | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |
| `owner`                                                                                                     | [Optional[models.SetExternalUserBudgetOwnerRequest]](../../models/setexternaluserbudgetownerrequest.md)     | :heavy_minus_sign:                                                                                          | cluster = operator ceiling (org-admin read-only); org = self-budget                                         |
| `webhook_url`                                                                                               | *OptionalNullable[str]*                                                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |
| `webhook_secret`                                                                                            | *OptionalNullable[str]*                                                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |
| `retries`                                                                                                   | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                            | :heavy_minus_sign:                                                                                          | Configuration to override the default retry behavior of the client.                                         |

### Response

**[models.SetExternalUserBudgetResponse](../../models/setexternaluserbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_external_user

Removes the external user's budget for the given owner; the org's per-external user default budget (if any) applies to them again. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteExternalUserBudget" method="delete" path="/api/v1/budgeting/budgets/external-user/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_external_user(id="<id>", owner="cluster")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                      | *str*                                                                                                     | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `owner`                                                                                                   | [models.DeleteExternalUserBudgetQueryParamOwner](../../models/deleteexternaluserbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `org_id`                                                                                                  | *Optional[str]*                                                                                           | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `retries`                                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                          | :heavy_minus_sign:                                                                                        | Configuration to override the default retry behavior of the client.                                       |

### Response

**[models.DeleteExternalUserBudgetResponse](../../models/deleteexternaluserbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## external_user_events

Returns recent threshold-alert and block events for the external user's budgets in the target org. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for external users in their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="listExternalUserBudgetEvents" method="get" path="/api/v1/budgeting/budgets/external-user/{id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.external_user_events(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListExternalUserBudgetEventsResponse](../../models/listexternaluserbudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_user_default

Returns the org's per-user default budgets (self-set and/or operator ceiling). A default budget applies to every user in the org against that user's own spend counter, unless an explicit user budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="getUserDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/user-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_user_default()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetUserDefaultBudgetsResponse](../../models/getuserdefaultbudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_user_default

Creates or updates the org's per-user default budget: a cap applying to EACH user in the org individually (not in aggregate), unless an explicit user budget of the same owner and period exists for them. Threshold alerts and blocks fire per user. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="setUserDefaultBudget" method="put" path="/api/v1/budgeting/budgets/user-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_user_default(period="weekly", limit=6669.11, thresholds=[], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `period`                                                                                                  | [models.SetUserDefaultBudgetPeriodRequest](../../models/setuserdefaultbudgetperiodrequest.md)             | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `limit`                                                                                                   | *float*                                                                                                   | :heavy_check_mark:                                                                                        | Spend limit in major currency units                                                                       |
| `thresholds`                                                                                              | List[[models.SetUserDefaultBudgetThresholdRequest](../../models/setuserdefaultbudgetthresholdrequest.md)] | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `org_id`                                                                                                  | *Optional[str]*                                                                                           | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `owner`                                                                                                   | [Optional[models.SetUserDefaultBudgetOwnerRequest]](../../models/setuserdefaultbudgetownerrequest.md)     | :heavy_minus_sign:                                                                                        | cluster = operator ceiling (org-admin read-only); org = self-budget                                       |
| `webhook_url`                                                                                             | *OptionalNullable[str]*                                                                                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `webhook_secret`                                                                                          | *OptionalNullable[str]*                                                                                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `retries`                                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                          | :heavy_minus_sign:                                                                                        | Configuration to override the default retry behavior of the client.                                       |

### Response

**[models.SetUserDefaultBudgetResponse](../../models/setuserdefaultbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_user_default

Removes the org's per-user default budget for the given owner; only explicit user budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteUserDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/user-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_user_default(owner="cluster")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `owner`                                                                                                 | [models.DeleteUserDefaultBudgetQueryParamOwner](../../models/deleteuserdefaultbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `org_id`                                                                                                | *Optional[str]*                                                                                         | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `retries`                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                        | :heavy_minus_sign:                                                                                      | Configuration to override the default retry behavior of the client.                                     |

### Response

**[models.DeleteUserDefaultBudgetResponse](../../models/deleteuserdefaultbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## user_default_events

Returns recent threshold-alert and block events for the org's per-user default budgets. Each event's target_id names the user it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="listUserDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/user-default/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.user_default_events()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListUserDefaultBudgetEventsResponse](../../models/listuserdefaultbudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_team_default

Returns the org's per-team default budgets (self-set and/or operator ceiling). A default budget applies to every team in the org against that team's own spend counter, unless an explicit team budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="getTeamDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/team-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_team_default()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetTeamDefaultBudgetsResponse](../../models/getteamdefaultbudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_team_default

Creates or updates the org's per-team default budget: a cap applying to EACH team in the org individually (not in aggregate), unless an explicit team budget of the same owner and period exists for them. Threshold alerts and blocks fire per team. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="setTeamDefaultBudget" method="put" path="/api/v1/budgeting/budgets/team-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_team_default(period="daily", limit=1351.42, thresholds=[], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `period`                                                                                                  | [models.SetTeamDefaultBudgetPeriodRequest](../../models/setteamdefaultbudgetperiodrequest.md)             | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `limit`                                                                                                   | *float*                                                                                                   | :heavy_check_mark:                                                                                        | Spend limit in major currency units                                                                       |
| `thresholds`                                                                                              | List[[models.SetTeamDefaultBudgetThresholdRequest](../../models/setteamdefaultbudgetthresholdrequest.md)] | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `org_id`                                                                                                  | *Optional[str]*                                                                                           | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `owner`                                                                                                   | [Optional[models.SetTeamDefaultBudgetOwnerRequest]](../../models/setteamdefaultbudgetownerrequest.md)     | :heavy_minus_sign:                                                                                        | cluster = operator ceiling (org-admin read-only); org = self-budget                                       |
| `webhook_url`                                                                                             | *OptionalNullable[str]*                                                                                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `webhook_secret`                                                                                          | *OptionalNullable[str]*                                                                                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |
| `retries`                                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                          | :heavy_minus_sign:                                                                                        | Configuration to override the default retry behavior of the client.                                       |

### Response

**[models.SetTeamDefaultBudgetResponse](../../models/setteamdefaultbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_team_default

Removes the org's per-team default budget for the given owner; only explicit team budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteTeamDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/team-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_team_default(owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `owner`                                                                                                 | [models.DeleteTeamDefaultBudgetQueryParamOwner](../../models/deleteteamdefaultbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `org_id`                                                                                                | *Optional[str]*                                                                                         | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |
| `retries`                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                        | :heavy_minus_sign:                                                                                      | Configuration to override the default retry behavior of the client.                                     |

### Response

**[models.DeleteTeamDefaultBudgetResponse](../../models/deleteteamdefaultbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## team_default_events

Returns recent threshold-alert and block events for the org's per-team default budgets. Each event's target_id names the team it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="listTeamDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/team-default/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.team_default_events()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListTeamDefaultBudgetEventsResponse](../../models/listteamdefaultbudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_external_user_default

Returns the org's per-external user default budgets (self-set and/or operator ceiling). A default budget applies to every external user in the org against that external user's own spend counter, unless an explicit external user budget of the same owner and period exists for them. It has no spend gauge of its own. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="getExternalUserDefaultBudgets" method="get" path="/api/v1/budgeting/budgets/external-user-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_external_user_default()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetExternalUserDefaultBudgetsResponse](../../models/getexternaluserdefaultbudgetsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_external_user_default

Creates or updates the org's per-external user default budget: a cap applying to EACH external user in the org individually (not in aggregate), unless an explicit external user budget of the same owner and period exists for them. Threshold alerts and blocks fire per external user. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="setExternalUserDefaultBudget" method="put" path="/api/v1/budgeting/budgets/external-user-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_external_user_default(period="monthly", limit=7392.64, thresholds=[], owner="org")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `period`                                                                                                                  | [models.SetExternalUserDefaultBudgetPeriodRequest](../../models/setexternaluserdefaultbudgetperiodrequest.md)             | :heavy_check_mark:                                                                                                        | N/A                                                                                                                       |
| `limit`                                                                                                                   | *float*                                                                                                                   | :heavy_check_mark:                                                                                                        | Spend limit in major currency units                                                                                       |
| `thresholds`                                                                                                              | List[[models.SetExternalUserDefaultBudgetThresholdRequest](../../models/setexternaluserdefaultbudgetthresholdrequest.md)] | :heavy_check_mark:                                                                                                        | N/A                                                                                                                       |
| `org_id`                                                                                                                  | *Optional[str]*                                                                                                           | :heavy_minus_sign:                                                                                                        | N/A                                                                                                                       |
| `owner`                                                                                                                   | [Optional[models.SetExternalUserDefaultBudgetOwnerRequest]](../../models/setexternaluserdefaultbudgetownerrequest.md)     | :heavy_minus_sign:                                                                                                        | cluster = operator ceiling (org-admin read-only); org = self-budget                                                       |
| `webhook_url`                                                                                                             | *OptionalNullable[str]*                                                                                                   | :heavy_minus_sign:                                                                                                        | N/A                                                                                                                       |
| `webhook_secret`                                                                                                          | *OptionalNullable[str]*                                                                                                   | :heavy_minus_sign:                                                                                                        | N/A                                                                                                                       |
| `retries`                                                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                          | :heavy_minus_sign:                                                                                                        | Configuration to override the default retry behavior of the client.                                                       |

### Response

**[models.SetExternalUserDefaultBudgetResponse](../../models/setexternaluserdefaultbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_external_user_default

Removes the org's per-external user default budget for the given owner; only explicit external user budgets remain. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteExternalUserDefaultBudget" method="delete" path="/api/v1/budgeting/budgets/external-user-default" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.delete_external_user_default(owner="cluster")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `owner`                                                                                                                 | [models.DeleteExternalUserDefaultBudgetQueryParamOwner](../../models/deleteexternaluserdefaultbudgetqueryparamowner.md) | :heavy_check_mark:                                                                                                      | N/A                                                                                                                     |
| `org_id`                                                                                                                | *Optional[str]*                                                                                                         | :heavy_minus_sign:                                                                                                      | N/A                                                                                                                     |
| `retries`                                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                        | :heavy_minus_sign:                                                                                                      | Configuration to override the default retry behavior of the client.                                                     |

### Response

**[models.DeleteExternalUserDefaultBudgetResponse](../../models/deleteexternaluserdefaultbudgetresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## external_user_default_events

Returns recent threshold-alert and block events for the org's per-external user default budgets. Each event's target_id names the external user it fired for. Targets the caller's own organization (inferred from the API key or session) unless the optional org_id query parameter names another org — cluster admins only. Callable by cluster admins, or org admins for their own organization (owner=org).

### Example Usage

<!-- UsageSnippet language="python" operationID="listExternalUserDefaultBudgetEvents" method="get" path="/api/v1/budgeting/budgets/external-user-default/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.external_user_default_events()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListExternalUserDefaultBudgetEventsResponse](../../models/listexternaluserdefaultbudgeteventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_currency

Get display currency

### Example Usage

<!-- UsageSnippet language="python" operationID="getCurrency" method="get" path="/api/v1/budgeting/settings/currency" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.get_currency()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetCurrencyResponse](../../models/getcurrencyresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_currency

ISO 4217 code used for display on budgets and cost reports. No conversion is performed anywhere.

### Example Usage

<!-- UsageSnippet language="python" operationID="setCurrency" method="put" path="/api/v1/budgeting/settings/currency" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.budgets.set_currency(currency="Kwacha")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `currency`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.SetCurrencyResponse](../../models/setcurrencyresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |