# Auth.Teams

## Overview

### Available Operations

* [create](#create) - Create a team
* [list](#list) - List teams in an org
* [get](#get) - Get a team
* [update](#update) - Rename a team
* [delete](#delete) - Delete a team
* [add_member](#add_member) - Add a team member
* [list_members](#list_members) - List team members
* [remove_member](#remove_member) - Remove a team member

## create

Create a team

### Example Usage

<!-- UsageSnippet language="python" operationID="createTeam" method="post" path="/api/v1/authentication/orgs/{orgId}/teams" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.create(org_id="<id>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.CreateTeamResponse](../../models/createteamresponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| errors.CreateTeamBadRequestError      | 400                                   | application/json                      |
| errors.CreateTeamUnauthorizedError    | 401                                   | application/json                      |
| errors.CreateTeamForbiddenError       | 403                                   | application/json                      |
| errors.CreateTeamNotFoundError        | 404                                   | application/json                      |
| errors.CreateTeamConflictError        | 409                                   | application/json                      |
| errors.CreateTeamGoneError            | 410                                   | application/json                      |
| errors.CreateTeamTooManyRequestsError | 429                                   | application/json                      |
| errors.SDKDefaultError                | 4XX, 5XX                              | \*/\*                                 |

## list

List teams in an org

### Example Usage

<!-- UsageSnippet language="python" operationID="listTeams" method="get" path="/api/v1/authentication/orgs/{orgId}/teams" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.list(org_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListTeamsResponse](../../models/listteamsresponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| errors.ListTeamsBadRequestError      | 400                                  | application/json                     |
| errors.ListTeamsUnauthorizedError    | 401                                  | application/json                     |
| errors.ListTeamsForbiddenError       | 403                                  | application/json                     |
| errors.ListTeamsNotFoundError        | 404                                  | application/json                     |
| errors.ListTeamsConflictError        | 409                                  | application/json                     |
| errors.ListTeamsGoneError            | 410                                  | application/json                     |
| errors.ListTeamsTooManyRequestsError | 429                                  | application/json                     |
| errors.SDKDefaultError               | 4XX, 5XX                             | \*/\*                                |

## get

Get a team

### Example Usage

<!-- UsageSnippet language="python" operationID="getTeam" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.get(org_id="<id>", team_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `team_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetTeamResponse](../../models/getteamresponse.md)**

### Errors

| Error Type                         | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| errors.GetTeamBadRequestError      | 400                                | application/json                   |
| errors.GetTeamUnauthorizedError    | 401                                | application/json                   |
| errors.GetTeamForbiddenError       | 403                                | application/json                   |
| errors.GetTeamNotFoundError        | 404                                | application/json                   |
| errors.GetTeamConflictError        | 409                                | application/json                   |
| errors.GetTeamGoneError            | 410                                | application/json                   |
| errors.GetTeamTooManyRequestsError | 429                                | application/json                   |
| errors.SDKDefaultError             | 4XX, 5XX                           | \*/\*                              |

## update

Rename a team

### Example Usage

<!-- UsageSnippet language="python" operationID="updateTeam" method="patch" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.update(org_id="<id>", team_id="<id>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `team_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.UpdateTeamResponse](../../models/updateteamresponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| errors.UpdateTeamBadRequestError      | 400                                   | application/json                      |
| errors.UpdateTeamUnauthorizedError    | 401                                   | application/json                      |
| errors.UpdateTeamForbiddenError       | 403                                   | application/json                      |
| errors.UpdateTeamNotFoundError        | 404                                   | application/json                      |
| errors.UpdateTeamConflictError        | 409                                   | application/json                      |
| errors.UpdateTeamGoneError            | 410                                   | application/json                      |
| errors.UpdateTeamTooManyRequestsError | 429                                   | application/json                      |
| errors.SDKDefaultError                | 4XX, 5XX                              | \*/\*                                 |

## delete

Delete a team

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteTeam" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.delete(org_id="<id>", team_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `team_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteTeamResponse](../../models/deleteteamresponse.md)**

### Errors

| Error Type                            | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| errors.DeleteTeamBadRequestError      | 400                                   | application/json                      |
| errors.DeleteTeamUnauthorizedError    | 401                                   | application/json                      |
| errors.DeleteTeamForbiddenError       | 403                                   | application/json                      |
| errors.DeleteTeamNotFoundError        | 404                                   | application/json                      |
| errors.DeleteTeamConflictError        | 409                                   | application/json                      |
| errors.DeleteTeamGoneError            | 410                                   | application/json                      |
| errors.DeleteTeamTooManyRequestsError | 429                                   | application/json                      |
| errors.SDKDefaultError                | 4XX, 5XX                              | \*/\*                                 |

## add_member

Attach a principal (user or service account) to the team by its userId.

### Example Usage

<!-- UsageSnippet language="python" operationID="addTeamMember" method="post" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.add_member(org_id="<id>", team_id="<id>", user_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `team_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `user_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AddTeamMemberResponse](../../models/addteammemberresponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| errors.AddTeamMemberBadRequestError      | 400                                      | application/json                         |
| errors.AddTeamMemberUnauthorizedError    | 401                                      | application/json                         |
| errors.AddTeamMemberForbiddenError       | 403                                      | application/json                         |
| errors.AddTeamMemberNotFoundError        | 404                                      | application/json                         |
| errors.AddTeamMemberConflictError        | 409                                      | application/json                         |
| errors.AddTeamMemberGoneError            | 410                                      | application/json                         |
| errors.AddTeamMemberTooManyRequestsError | 429                                      | application/json                         |
| errors.SDKDefaultError                   | 4XX, 5XX                                 | \*/\*                                    |

## list_members

List team members

### Example Usage

<!-- UsageSnippet language="python" operationID="listTeamMembers" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.list_members(org_id="<id>", team_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `team_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListTeamMembersResponse](../../models/listteammembersresponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| errors.ListTeamMembersBadRequestError      | 400                                        | application/json                           |
| errors.ListTeamMembersUnauthorizedError    | 401                                        | application/json                           |
| errors.ListTeamMembersForbiddenError       | 403                                        | application/json                           |
| errors.ListTeamMembersNotFoundError        | 404                                        | application/json                           |
| errors.ListTeamMembersConflictError        | 409                                        | application/json                           |
| errors.ListTeamMembersGoneError            | 410                                        | application/json                           |
| errors.ListTeamMembersTooManyRequestsError | 429                                        | application/json                           |
| errors.SDKDefaultError                     | 4XX, 5XX                                   | \*/\*                                      |

## remove_member

Remove a team member

### Example Usage

<!-- UsageSnippet language="python" operationID="removeTeamMember" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members/{memberId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.teams.remove_member(org_id="<id>", team_id="<id>", member_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `team_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `member_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RemoveTeamMemberResponse](../../models/removeteammemberresponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| errors.RemoveTeamMemberBadRequestError      | 400                                         | application/json                            |
| errors.RemoveTeamMemberUnauthorizedError    | 401                                         | application/json                            |
| errors.RemoveTeamMemberForbiddenError       | 403                                         | application/json                            |
| errors.RemoveTeamMemberNotFoundError        | 404                                         | application/json                            |
| errors.RemoveTeamMemberConflictError        | 409                                         | application/json                            |
| errors.RemoveTeamMemberGoneError            | 410                                         | application/json                            |
| errors.RemoveTeamMemberTooManyRequestsError | 429                                         | application/json                            |
| errors.SDKDefaultError                      | 4XX, 5XX                                    | \*/\*                                       |