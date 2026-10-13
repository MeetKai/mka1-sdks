# Auth.Cluster

## Overview

### Available Operations

* [create_invite](#create_invite) - Create a cluster invitation
* [list_invites](#list_invites) - List cluster invitations
* [update_invite](#update_invite) - Update a pending cluster invitation
* [revoke_invite](#revoke_invite) - Revoke a cluster invitation
* [list_orgs](#list_orgs) - List all organizations
* [get_org](#get_org) - Get an organization
* [delete_org](#delete_org) - Soft-delete an organization
* [invite_org_members](#invite_org_members) - Invite members on behalf of an organization
* [suspend_org](#suspend_org) - Suspend an organization
* [unsuspend_org](#unsuspend_org) - Unsuspend an organization
* [reissue_owner_key](#reissue_owner_key) - Re-issue an org owner key (recovery)
* [invite_info](#invite_info) - Read cluster-invite info (public)
* [accept_invite](#accept_invite) - Accept a cluster invitation (public)

## create_invite

Issue a one-shot invite that provisions a new org on acceptance. Email-bound invites can be accepted headless (passwordless + issueApiKey).

### Example Usage

<!-- UsageSnippet language="python" operationID="createClusterInvite" method="post" path="/api/v1/authentication/admin/cluster/invitations" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.create_invite()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `x_on_behalf_of`                                                                                  | *Optional[str]*                                                                                   | :heavy_minus_sign:                                                                                | Optional external end-user identifier forwarded by the API gateway.                               |
| `body`                                                                                            | [Optional[models.CreateClusterInviteRequestBody]](../../models/createclusterinviterequestbody.md) | :heavy_minus_sign:                                                                                | N/A                                                                                               |
| `retries`                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                  | :heavy_minus_sign:                                                                                | Configuration to override the default retry behavior of the client.                               |

### Response

**[models.CreateClusterInviteResponse](../../models/createclusterinviteresponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.CreateClusterInviteBadRequestError      | 400                                            | application/json                               |
| errors.CreateClusterInviteUnauthorizedError    | 401                                            | application/json                               |
| errors.CreateClusterInviteForbiddenError       | 403                                            | application/json                               |
| errors.CreateClusterInviteNotFoundError        | 404                                            | application/json                               |
| errors.CreateClusterInviteConflictError        | 409                                            | application/json                               |
| errors.CreateClusterInviteGoneError            | 410                                            | application/json                               |
| errors.CreateClusterInviteTooManyRequestsError | 429                                            | application/json                               |
| errors.SDKDefaultError                         | 4XX, 5XX                                       | \*/\*                                          |

## list_invites

List cluster invitations

### Example Usage

<!-- UsageSnippet language="python" operationID="listClusterInvites" method="get" path="/api/v1/authentication/admin/cluster/invitations" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.list_invites()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListClusterInvitesResponse](../../models/listclusterinvitesresponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| errors.ListClusterInvitesBadRequestError      | 400                                           | application/json                              |
| errors.ListClusterInvitesUnauthorizedError    | 401                                           | application/json                              |
| errors.ListClusterInvitesForbiddenError       | 403                                           | application/json                              |
| errors.ListClusterInvitesNotFoundError        | 404                                           | application/json                              |
| errors.ListClusterInvitesConflictError        | 409                                           | application/json                              |
| errors.ListClusterInvitesGoneError            | 410                                           | application/json                              |
| errors.ListClusterInvitesTooManyRequestsError | 429                                           | application/json                              |
| errors.SDKDefaultError                        | 4XX, 5XX                                      | \*/\*                                         |

## update_invite

Extend the expiry or atomically replace the available-model, API-quota, or compute policy of an unclaimed, unexpired invitation. Omitted top-level fields are preserved.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateClusterInvite" method="patch" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.update_invite(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                              | Type                                                                                                                                                                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                                                                                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                                                                                                                                                                                                                                                                                                   | *str*                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                                                                                                                                                       | *Optional[str]*                                                                                                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                                                                                                                    |
| `expires_at`                                                                                                                                                                                                                                                                                                                                                                                                           | [date](https://docs.python.org/3/library/datetime.html#date-objects)                                                                                                                                                                                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                                                                                                                                                                    |
| `model_ids`                                                                                                                                                                                                                                                                                                                                                                                                            | List[*str*]                                                                                                                                                                                                                                                                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                     | Model IDs are trimmed and deduplicated before validation; at most 500 unique IDs are allowed.                                                                                                                                                                                                                                                                                                                          |
| `seed_quota`                                                                                                                                                                                                                                                                                                                                                                                                           | [Optional[models.ClusterInviteSeedQuota]](../../models/clusterinviteseedquota.md)                                                                                                                                                                                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                     | API request quota to apply when the invitation is accepted. All fields are required when seedQuota is supplied. Enabling requires non-null period and max; when disabled, period and max must either both be null or both be valid.                                                                                                                                                                                    |
| `seed_compute`                                                                                                                                                                                                                                                                                                                                                                                                         | [Optional[models.ClusterInviteSeedCompute]](../../models/clusterinviteseedcompute.md)                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                     | Compute policy to apply when the invitation is accepted. All fields are required when seedCompute is supplied. A null limit is unlimited and zero blocks new resources.                                                                                                                                                                                                                                                |
| `seed_budget`                                                                                                                                                                                                                                                                                                                                                                                                          | [Optional[models.ClusterInviteSeedBudget]](../../models/clusterinviteseedbudget.md)                                                                                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                     | Cluster-owned organization spend limit applied before invitation acceptance commits. Uses the cluster pricing currency and blocks new requests at 100% of the limit. All fields are required when supplied. Enabling requires a positive finite limit and non-null period; when disabled, period and limit must both be null or both be valid. Existing budgeting outage and in-flight-request behavior still applies. |
| `retries`                                                                                                                                                                                                                                                                                                                                                                                                              | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                     | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                                                                                                                                                    |

### Response

**[models.UpdateClusterInviteResponse](../../models/updateclusterinviteresponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.UpdateClusterInviteBadRequestError      | 400                                            | application/json                               |
| errors.UpdateClusterInviteUnauthorizedError    | 401                                            | application/json                               |
| errors.UpdateClusterInviteForbiddenError       | 403                                            | application/json                               |
| errors.UpdateClusterInviteNotFoundError        | 404                                            | application/json                               |
| errors.UpdateClusterInviteConflictError        | 409                                            | application/json                               |
| errors.UpdateClusterInviteGoneError            | 410                                            | application/json                               |
| errors.UpdateClusterInviteTooManyRequestsError | 429                                            | application/json                               |
| errors.SDKDefaultError                         | 4XX, 5XX                                       | \*/\*                                          |

## revoke_invite

Revoke a cluster invitation

### Example Usage

<!-- UsageSnippet language="python" operationID="revokeClusterInvite" method="delete" path="/api/v1/authentication/admin/cluster/invitations/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.revoke_invite(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RevokeClusterInviteResponse](../../models/revokeclusterinviteresponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.RevokeClusterInviteBadRequestError      | 400                                            | application/json                               |
| errors.RevokeClusterInviteUnauthorizedError    | 401                                            | application/json                               |
| errors.RevokeClusterInviteForbiddenError       | 403                                            | application/json                               |
| errors.RevokeClusterInviteNotFoundError        | 404                                            | application/json                               |
| errors.RevokeClusterInviteConflictError        | 409                                            | application/json                               |
| errors.RevokeClusterInviteGoneError            | 410                                            | application/json                               |
| errors.RevokeClusterInviteTooManyRequestsError | 429                                            | application/json                               |
| errors.SDKDefaultError                         | 4XX, 5XX                                       | \*/\*                                          |

## list_orgs

List all organizations

### Example Usage

<!-- UsageSnippet language="python" operationID="listClusterOrgs" method="get" path="/api/v1/authentication/admin/cluster/orgs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.list_orgs()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListClusterOrgsResponse](../../models/listclusterorgsresponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| errors.ListClusterOrgsBadRequestError      | 400                                        | application/json                           |
| errors.ListClusterOrgsUnauthorizedError    | 401                                        | application/json                           |
| errors.ListClusterOrgsForbiddenError       | 403                                        | application/json                           |
| errors.ListClusterOrgsNotFoundError        | 404                                        | application/json                           |
| errors.ListClusterOrgsConflictError        | 409                                        | application/json                           |
| errors.ListClusterOrgsGoneError            | 410                                        | application/json                           |
| errors.ListClusterOrgsTooManyRequestsError | 429                                        | application/json                           |
| errors.SDKDefaultError                     | 4XX, 5XX                                   | \*/\*                                      |

## get_org

Get an organization

### Example Usage

<!-- UsageSnippet language="python" operationID="getClusterOrg" method="get" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.get_org(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetClusterOrgResponse](../../models/getclusterorgresponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| errors.GetClusterOrgBadRequestError      | 400                                      | application/json                         |
| errors.GetClusterOrgUnauthorizedError    | 401                                      | application/json                         |
| errors.GetClusterOrgForbiddenError       | 403                                      | application/json                         |
| errors.GetClusterOrgNotFoundError        | 404                                      | application/json                         |
| errors.GetClusterOrgConflictError        | 409                                      | application/json                         |
| errors.GetClusterOrgGoneError            | 410                                      | application/json                         |
| errors.GetClusterOrgTooManyRequestsError | 429                                      | application/json                         |
| errors.SDKDefaultError                   | 4XX, 5XX                                 | \*/\*                                    |

## delete_org

Soft-delete an organization

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteClusterOrg" method="delete" path="/api/v1/authentication/admin/cluster/orgs/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.delete_org(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteClusterOrgResponse](../../models/deleteclusterorgresponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| errors.DeleteClusterOrgBadRequestError      | 400                                         | application/json                            |
| errors.DeleteClusterOrgUnauthorizedError    | 401                                         | application/json                            |
| errors.DeleteClusterOrgForbiddenError       | 403                                         | application/json                            |
| errors.DeleteClusterOrgNotFoundError        | 404                                         | application/json                            |
| errors.DeleteClusterOrgConflictError        | 409                                         | application/json                            |
| errors.DeleteClusterOrgGoneError            | 410                                         | application/json                            |
| errors.DeleteClusterOrgTooManyRequestsError | 429                                         | application/json                            |
| errors.SDKDefaultError                      | 4XX, 5XX                                    | \*/\*                                       |

## invite_org_members

Requires a cluster-admin session with Cluster as its active organization. The target must be active and cannot be Cluster. Sends up to 20 organization invitations without switching the admin's session or joining the target organization. Each row accepts role member or admin, defaulting to member; owner and custom roles are not supported. New invitations include the target's oldest team when one exists. Results follow input order; invalid emails, duplicates, existing members, pending invitations, and delivery failures are reported per row. An existing pending invitation must match the requested role, including when resend is false. An explicit resend reuses a matching pending invitation with no team or the target's oldest team, preserving its inviter, role, and team. Invitation expiry is 48 hours; at most 100 unexpired pending invitations are allowed per organization. API keys are not supported.

### Example Usage

<!-- UsageSnippet language="python" operationID="inviteClusterOrgMembers" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/invitations" -->
```python
from meetkai_mka1 import SDK, models


with SDK() as sdk:

    res = sdk.auth.cluster.invite_org_members(security=models.InviteClusterOrgMembersSecurity(
        session_cookie="<YOUR_API_KEY_HERE>",
    ), id="<id>", invitations=[
        {
            "email": "Aurelio1@yahoo.com",
        },
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [models.InviteClusterOrgMembersSecurity](../../models/inviteclusterorgmemberssecurity.md)           | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `id`                                                                                                | *str*                                                                                               | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `invitations`                                                                                       | List[[models.InviteClusterOrgMembersInvitation](../../models/inviteclusterorgmembersinvitation.md)] | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `x_on_behalf_of`                                                                                    | *Optional[str]*                                                                                     | :heavy_minus_sign:                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                 |
| `retries`                                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                    | :heavy_minus_sign:                                                                                  | Configuration to override the default retry behavior of the client.                                 |

### Response

**[models.InviteClusterOrgMembersResponse](../../models/inviteclusterorgmembersresponse.md)**

### Errors

| Error Type                                         | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| errors.InviteClusterOrgMembersBadRequestError      | 400                                                | application/json                                   |
| errors.InviteClusterOrgMembersUnauthorizedError    | 401                                                | application/json                                   |
| errors.InviteClusterOrgMembersForbiddenError       | 403                                                | application/json                                   |
| errors.InviteClusterOrgMembersNotFoundError        | 404                                                | application/json                                   |
| errors.InviteClusterOrgMembersConflictError        | 409                                                | application/json                                   |
| errors.InviteClusterOrgMembersGoneError            | 410                                                | application/json                                   |
| errors.InviteClusterOrgMembersTooManyRequestsError | 429                                                | application/json                                   |
| errors.SDKDefaultError                             | 4XX, 5XX                                           | \*/\*                                              |

## suspend_org

Suspend an organization

### Example Usage

<!-- UsageSnippet language="python" operationID="suspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/suspend" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.suspend_org(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.SuspendClusterOrgResponse](../../models/suspendclusterorgresponse.md)**

### Errors

| Error Type                                   | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| errors.SuspendClusterOrgBadRequestError      | 400                                          | application/json                             |
| errors.SuspendClusterOrgUnauthorizedError    | 401                                          | application/json                             |
| errors.SuspendClusterOrgForbiddenError       | 403                                          | application/json                             |
| errors.SuspendClusterOrgNotFoundError        | 404                                          | application/json                             |
| errors.SuspendClusterOrgConflictError        | 409                                          | application/json                             |
| errors.SuspendClusterOrgGoneError            | 410                                          | application/json                             |
| errors.SuspendClusterOrgTooManyRequestsError | 429                                          | application/json                             |
| errors.SDKDefaultError                       | 4XX, 5XX                                     | \*/\*                                        |

## unsuspend_org

Unsuspend an organization

### Example Usage

<!-- UsageSnippet language="python" operationID="unsuspendClusterOrg" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/unsuspend" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.unsuspend_org(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.UnsuspendClusterOrgResponse](../../models/unsuspendclusterorgresponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.UnsuspendClusterOrgBadRequestError      | 400                                            | application/json                               |
| errors.UnsuspendClusterOrgUnauthorizedError    | 401                                            | application/json                               |
| errors.UnsuspendClusterOrgForbiddenError       | 403                                            | application/json                               |
| errors.UnsuspendClusterOrgNotFoundError        | 404                                            | application/json                               |
| errors.UnsuspendClusterOrgConflictError        | 409                                            | application/json                               |
| errors.UnsuspendClusterOrgGoneError            | 410                                            | application/json                               |
| errors.UnsuspendClusterOrgTooManyRequestsError | 429                                            | application/json                               |
| errors.SDKDefaultError                         | 4XX, 5XX                                       | \*/\*                                          |

## reissue_owner_key

Mint a fresh owner-bound key for an org whose credential was lost. Cluster-admin only (`write:cluster`). Defaults to the org's oldest human owner and oldest team; `userId` / `teamId` override.

### Example Usage

<!-- UsageSnippet language="python" operationID="reissueOwnerKey" method="post" path="/api/v1/authentication/admin/cluster/orgs/{id}/owner-key" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.reissue_owner_key(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `user_id`                                                           | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `team_id`                                                           | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ReissueOwnerKeyResponse](../../models/reissueownerkeyresponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| errors.ReissueOwnerKeyBadRequestError      | 400                                        | application/json                           |
| errors.ReissueOwnerKeyUnauthorizedError    | 401                                        | application/json                           |
| errors.ReissueOwnerKeyForbiddenError       | 403                                        | application/json                           |
| errors.ReissueOwnerKeyNotFoundError        | 404                                        | application/json                           |
| errors.ReissueOwnerKeyConflictError        | 409                                        | application/json                           |
| errors.ReissueOwnerKeyGoneError            | 410                                        | application/json                           |
| errors.ReissueOwnerKeyTooManyRequestsError | 429                                        | application/json                           |
| errors.SDKDefaultError                     | 4XX, 5XX                                   | \*/\*                                      |

## invite_info

Read cluster-invite info (public)

### Example Usage

<!-- UsageSnippet language="python" operationID="getClusterInviteInfo" method="get" path="/api/v1/authentication/cluster-invite/info" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.invite_info(token="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `token`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetClusterInviteInfoResponse](../../models/getclusterinviteinforesponse.md)**

### Errors

| Error Type                                      | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| errors.GetClusterInviteInfoBadRequestError      | 400                                             | application/json                                |
| errors.GetClusterInviteInfoUnauthorizedError    | 401                                             | application/json                                |
| errors.GetClusterInviteInfoForbiddenError       | 403                                             | application/json                                |
| errors.GetClusterInviteInfoNotFoundError        | 404                                             | application/json                                |
| errors.GetClusterInviteInfoConflictError        | 409                                             | application/json                                |
| errors.GetClusterInviteInfoGoneError            | 410                                             | application/json                                |
| errors.GetClusterInviteInfoTooManyRequestsError | 429                                             | application/json                                |
| errors.SDKDefaultError                          | 4XX, 5XX                                        | \*/\*                                           |

## accept_invite

Accept an invite and create the org. Existing signed-in user, new email/password owner, or (email-bound) headless machine owner with `passwordless: true, issueApiKey: true`. A reserved slug (`api`, whether supplied as `orgSlug` or derived from `orgName`) is refused with 400 `reserved_org_slug`; a slug another org already holds is refused with 409. Note `POST /organization/check-slug` does not know about reserved slugs and will report `api` as available.

### Example Usage

<!-- UsageSnippet language="python" operationID="acceptClusterInvite" method="post" path="/api/v1/authentication/cluster-invite/accept" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.auth.cluster.accept_invite()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `x_on_behalf_of`                                                                                  | *Optional[str]*                                                                                   | :heavy_minus_sign:                                                                                | Optional external end-user identifier forwarded by the API gateway.                               |
| `body`                                                                                            | [Optional[models.AcceptClusterInviteRequestBody]](../../models/acceptclusterinviterequestbody.md) | :heavy_minus_sign:                                                                                | N/A                                                                                               |
| `retries`                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                  | :heavy_minus_sign:                                                                                | Configuration to override the default retry behavior of the client.                               |

### Response

**[models.AcceptClusterInviteResponse](../../models/acceptclusterinviteresponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.AcceptClusterInviteBadRequestError      | 400                                            | application/json                               |
| errors.AcceptClusterInviteUnauthorizedError    | 401                                            | application/json                               |
| errors.AcceptClusterInviteForbiddenError       | 403                                            | application/json                               |
| errors.AcceptClusterInviteNotFoundError        | 404                                            | application/json                               |
| errors.AcceptClusterInviteConflictError        | 409                                            | application/json                               |
| errors.AcceptClusterInviteGoneError            | 410                                            | application/json                               |
| errors.AcceptClusterInviteTooManyRequestsError | 429                                            | application/json                               |
| errors.ServiceUnavailableError                 | 503                                            | application/json                               |
| errors.SDKDefaultError                         | 4XX, 5XX                                       | \*/\*                                          |