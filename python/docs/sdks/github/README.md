# Sandbox.Github

## Overview

### Available Operations

* [create_authorization_intent](#create_authorization_intent) - Start GitHub Authorization
* [connect](#connect) - Connect GitHub Account
* [get_connection](#get_connection) - Get GitHub Connection
* [disconnect](#disconnect) - Disconnect GitHub Account
* [list_repositories](#list_repositories) - List GitHub Repositories
* [refresh_repositories](#refresh_repositories) - Refresh GitHub Repositories
* [resolve_reference](#resolve_reference) - Resolve GitHub Reference
* [clone_repository](#clone_repository) - Clone GitHub Repository into Session
* [list_session_repositories](#list_session_repositories) - List Session Repositories
* [add_session_repository](#add_session_repository) - Add Session Repository
* [dismiss_session_repository](#dismiss_session_repository) - Dismiss Failed Session Repository
* [push](#push) - Push Session to GitHub
* [create_or_update_pull_request](#create_or_update_pull_request) - Create or Update Pull Request

## create_authorization_intent

Start connecting the caller's GitHub account. Send the user to the returned `authorize_url`. GitHub redirects back with a `code` and the same `state`; pass both to `POST /github/oauth/connections` before `expires_in_seconds` elapses. Each `state` works once.

### Example Usage

<!-- UsageSnippet language="python" operationID="createGitHubAuthorizationIntent" method="post" path="/api/v1/sandbox/github/oauth/intents" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.create_authorization_intent()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AuthorizeIntent](../../models/authorizeintent.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## connect

Finish GitHub authorization by exchanging the `code` and `state` from GitHub's redirect for a stored connection. The sandbox service keeps the access token encrypted and never returns it. The response lists the repositories the connection can reach.

### Example Usage

<!-- UsageSnippet language="python" operationID="connectGitHubAccount" method="post" path="/api/v1/sandbox/github/oauth/connections" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.connect(code="<value>", state="South Carolina")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `code`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `state`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.Connection](../../models/connection.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get_connection

Return the caller's GitHub connection, or `null` when there is none. `token_invalid_at` is set once GitHub has rejected the stored token; reconnect to fix it. Set `verify` to `true` to check the token with GitHub now instead of at its next use.

### Example Usage

<!-- UsageSnippet language="python" operationID="getGitHubConnection" method="get" path="/api/v1/sandbox/github/oauth/connections" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.get_connection(verify=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `verify`                                                            | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ConnectionEnvelope](../../models/connectionenvelope.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## disconnect

Delete the caller's GitHub connection and revoke its token at GitHub. The connection is deleted even if GitHub does not confirm the revocation.

### Example Usage

<!-- UsageSnippet language="python" operationID="disconnectGitHubAccount" method="delete" path="/api/v1/sandbox/github/oauth/connections" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.sandbox.github.disconnect()

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_repositories

List the repositories recorded for the caller's GitHub connection, or an empty list when there is no connection. The list is captured when you connect; call `POST /github/repositories/refresh` to update it.

### Example Usage

<!-- UsageSnippet language="python" operationID="listGitHubRepositories" method="get" path="/api/v1/sandbox/github/repositories" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.list_repositories()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RepositoryList](../../models/repositorylist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## refresh_repositories

Re-read the repositories the caller's GitHub connection can reach, save them as the connection's repository list, and return it.

### Example Usage

<!-- UsageSnippet language="python" operationID="refreshGitHubRepositories" method="post" path="/api/v1/sandbox/github/repositories/refresh" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.refresh_repositories()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RepositoryList](../../models/repositorylist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## resolve_reference

Resolve a Git reference in a connected repository to a commit SHA. Omit `ref` to resolve the repository's default branch.

### Example Usage

<!-- UsageSnippet language="python" operationID="resolveGitHubReference" method="post" path="/api/v1/sandbox/github/repositories/resolve" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.resolve_reference(repository_id=649579)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `repository_id`                                                     | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `ref`                                                               | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ResolvedReference](../../models/resolvedreference.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## clone_repository

Clone a connected repository at `base_sha` into the session workspace using the caller's GitHub connection. The sandbox host runs the clone, so the token never enters the session.

### Example Usage

<!-- UsageSnippet language="python" operationID="cloneGitHubRepositoryIntoSession" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/read-clone" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.clone_repository(session_id="<id>", assignment_generation=817415, repository_id=33412, owner="<value>", repository="<value>", base_sha="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `assignment_generation`                                             | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `repository_id`                                                     | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `owner`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `repository`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `base_sha`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GitHubReadCloneResult](../../models/githubreadcloneresult.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## list_session_repositories

Return the repositories added to the session with each one's ref, checkout path, clone status, last push, and pull request, plus the per-session repository limit.

### Example Usage

<!-- UsageSnippet language="python" operationID="listSessionGitHubRepositories" method="get" path="/api/v1/sandbox/sessions/{session_id}/github/repositories" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.list_session_repositories(session_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.SessionRepositoryManifest](../../models/sessionrepositorymanifest.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## add_session_repository

Add a connected repository to the session and clone it at `ref`, or at the default branch when `ref` is omitted. Repeating the same request is safe. After a successful clone the repository's ref cannot change.

### Example Usage

<!-- UsageSnippet language="python" operationID="addSessionGitHubRepository" method="put" path="/api/v1/sandbox/sessions/{session_id}/github/repositories/{repository_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.add_session_repository(session_id="<id>", repository_id=314094, assignment_generation=240350)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `repository_id`                                                     | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `assignment_generation`                                             | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `ref`                                                               | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.SessionRepositoryModel](../../models/sessionrepositorymodel.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## dismiss_session_repository

Remove a repository whose clone failed from the session. A repository that cloned successfully, or whose clone is still in progress, cannot be removed.

### Example Usage

<!-- UsageSnippet language="python" operationID="dismissSessionGitHubRepository" method="delete" path="/api/v1/sandbox/sessions/{session_id}/github/repositories/{repository_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    sdk.sandbox.github.dismiss_session_repository(session_id="<id>", repository_id=254237, assignment_generation=906066)

    # Use the SDK ...

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `repository_id`                                                     | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `assignment_generation`                                             | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## push

Push the session's checkout to `branch` in the repository it was cloned from, using the caller's GitHub connection. The repository always comes from the session, never from the request. Set `checkout_path` when the repository is not at the workspace root.

### Example Usage

<!-- UsageSnippet language="python" operationID="pushSessionToGitHub" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/push" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.push(session_id="<id>", assignment_generation=295334, branch="<value>", checkout_path="", force=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `assignment_generation`                                             | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `branch`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `checkout_path`                                                     | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `force`                                                             | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GitHubPushResult](../../models/githubpushresult.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## create_or_update_pull_request

Open a pull request from `branch` in the session's repository, or update the one already recorded for that branch, reopening it if it was closed. The base defaults to the repository's default branch. A merged pull request is never reopened; a later call for the same branch opens a new one. The session does not need to be running.

### Example Usage

<!-- UsageSnippet language="python" operationID="createOrUpdateSessionPullRequest" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/pull-request" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.github.create_or_update_pull_request(session_id="<id>", branch="<value>", title="<value>", body="", draft=False, checkout_path="")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `branch`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `title`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `body`                                                              | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `base`                                                              | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `draft`                                                             | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `checkout_path`                                                     | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GitHubPullRequestResult](../../models/githubpullrequestresult.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |