# Sandbox.Github

## Overview

### Available Operations

* [CreateAuthorizationIntent](#createauthorizationintent) - Start GitHub Authorization
* [Connect](#connect) - Connect GitHub Account
* [GetConnection](#getconnection) - Get GitHub Connection
* [Disconnect](#disconnect) - Disconnect GitHub Account
* [ListRepositories](#listrepositories) - List GitHub Repositories
* [RefreshRepositories](#refreshrepositories) - Refresh GitHub Repositories
* [ResolveReference](#resolvereference) - Resolve GitHub Reference
* [CloneRepository](#clonerepository) - Clone GitHub Repository into Session
* [ListSessionRepositories](#listsessionrepositories) - List Session Repositories
* [AddSessionRepository](#addsessionrepository) - Add Session Repository
* [DismissSessionRepository](#dismisssessionrepository) - Dismiss Failed Session Repository
* [Push](#push) - Push Session to GitHub
* [CreateOrUpdatePullRequest](#createorupdatepullrequest) - Create or Update Pull Request

## CreateAuthorizationIntent

Start connecting the caller's GitHub account. Send the user to the returned `authorize_url`. GitHub redirects back with a `code` and the same `state`; pass both to `POST /github/oauth/connections` before `expires_in_seconds` elapses. Each `state` works once.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGitHubAuthorizationIntent" method="post" path="/api/v1/sandbox/github/oauth/intents" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.CreateAuthorizationIntentAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[CreateGitHubAuthorizationIntentResponse](../../Types/Requests/CreateGitHubAuthorizationIntentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Connect

Finish GitHub authorization by exchanging the `code` and `state` from GitHub's redirect for a stored connection. The sandbox service keeps the access token encrypted and never returns it. The response lists the repositories the connection can reach.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="connectGitHubAccount" method="post" path="/api/v1/sandbox/github/oauth/connections" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.ConnectAsync(body: new ConnectRequest() {
    Code = "<value>",
    State = "South Carolina",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Body`                                                              | [ConnectRequest](../../Types/Components/ConnectRequest.md)          | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ConnectGitHubAccountResponse](../../Types/Requests/ConnectGitHubAccountResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## GetConnection

Return the caller's GitHub connection, or `null` when there is none. `token_invalid_at` is set once GitHub has rejected the stored token; reconnect to fix it. Set `verify` to `true` to check the token with GitHub now instead of at its next use.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGitHubConnection" method="get" path="/api/v1/sandbox/github/oauth/connections" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.GetConnectionAsync(verify: false);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Verify`                                                            | *bool*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetGitHubConnectionResponse](../../Types/Requests/GetGitHubConnectionResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Disconnect

Delete the caller's GitHub connection and revoke its token at GitHub. The connection is deleted even if GitHub does not confirm the revocation.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="disconnectGitHubAccount" method="delete" path="/api/v1/sandbox/github/oauth/connections" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.DisconnectAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DisconnectGitHubAccountResponse](../../Types/Requests/DisconnectGitHubAccountResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListRepositories

List the repositories recorded for the caller's GitHub connection, or an empty list when there is no connection. The list is captured when you connect; call `POST /github/repositories/refresh` to update it.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGitHubRepositories" method="get" path="/api/v1/sandbox/github/repositories" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.ListRepositoriesAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListGitHubRepositoriesResponse](../../Types/Requests/ListGitHubRepositoriesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## RefreshRepositories

Re-read the repositories the caller's GitHub connection can reach, save them as the connection's repository list, and return it.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="refreshGitHubRepositories" method="post" path="/api/v1/sandbox/github/repositories/refresh" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.RefreshRepositoriesAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[RefreshGitHubRepositoriesResponse](../../Types/Requests/RefreshGitHubRepositoriesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ResolveReference

Resolve a Git reference in a connected repository to a commit SHA. Omit `ref` to resolve the repository's default branch.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="resolveGitHubReference" method="post" path="/api/v1/sandbox/github/repositories/resolve" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.ResolveReferenceAsync(body: new ResolveReferenceRequest() {
    RepositoryId = 649579,
});

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Body`                                                                       | [ResolveReferenceRequest](../../Types/Components/ResolveReferenceRequest.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |

### Response

**[ResolveGitHubReferenceResponse](../../Types/Requests/ResolveGitHubReferenceResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## CloneRepository

Clone a connected repository at `base_sha` into the session workspace using the caller's GitHub connection. The sandbox host runs the clone, so the token never enters the session.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cloneGitHubRepositoryIntoSession" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/read-clone" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.CloneRepositoryAsync(
    sessionId: "<id>",
    body: new GitHubReadCloneRequest() {
        AssignmentGeneration = 817415,
        RepositoryId = 33412,
        Owner = "<value>",
        Repository = "<value>",
        BaseSha = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `SessionId`                                                                | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `Body`                                                                     | [GitHubReadCloneRequest](../../Types/Components/GitHubReadCloneRequest.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |

### Response

**[CloneGitHubRepositoryIntoSessionResponse](../../Types/Requests/CloneGitHubRepositoryIntoSessionResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## ListSessionRepositories

Return the repositories added to the session with each one's ref, checkout path, clone status, last push, and pull request, plus the per-session repository limit.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSessionGitHubRepositories" method="get" path="/api/v1/sandbox/sessions/{session_id}/github/repositories" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.ListSessionRepositoriesAsync(sessionId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListSessionGitHubRepositoriesResponse](../../Types/Requests/ListSessionGitHubRepositoriesResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## AddSessionRepository

Add a connected repository to the session and clone it at `ref`, or at the default branch when `ref` is omitted. Repeating the same request is safe. After a successful clone the repository's ref cannot change.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addSessionGitHubRepository" method="put" path="/api/v1/sandbox/sessions/{session_id}/github/repositories/{repository_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.AddSessionRepositoryAsync(
    sessionId: "<id>",
    repositoryId: 314094,
    body: new PutSessionRepositoryRequest() {
        AssignmentGeneration = 240350,
    }
);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `SessionId`                                                                          | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `RepositoryId`                                                                       | *long*                                                                               | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `Body`                                                                               | [PutSessionRepositoryRequest](../../Types/Components/PutSessionRepositoryRequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `XOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |

### Response

**[AddSessionGitHubRepositoryResponse](../../Types/Requests/AddSessionGitHubRepositoryResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## DismissSessionRepository

Remove a repository whose clone failed from the session. A repository that cloned successfully, or whose clone is still in progress, cannot be removed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="dismissSessionGitHubRepository" method="delete" path="/api/v1/sandbox/sessions/{session_id}/github/repositories/{repository_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.DismissSessionRepositoryAsync(
    sessionId: "<id>",
    repositoryId: 254237,
    body: new DismissSessionRepositoryRequest() {
        AssignmentGeneration = 906066,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `SessionId`                                                                                  | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `RepositoryId`                                                                               | *long*                                                                                       | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `Body`                                                                                       | [DismissSessionRepositoryRequest](../../Types/Components/DismissSessionRepositoryRequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `XOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |

### Response

**[DismissSessionGitHubRepositoryResponse](../../Types/Requests/DismissSessionGitHubRepositoryResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Push

Push the session's checkout to `branch` in the repository it was cloned from, using the caller's GitHub connection. The repository always comes from the session, never from the request. Set `checkout_path` when the repository is not at the workspace root.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="pushSessionToGitHub" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/push" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.PushAsync(
    sessionId: "<id>",
    body: new GitHubPushRequest() {
        AssignmentGeneration = 295334,
        Branch = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Body`                                                              | [GitHubPushRequest](../../Types/Components/GitHubPushRequest.md)    | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[PushSessionToGitHubResponse](../../Types/Requests/PushSessionToGitHubResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## CreateOrUpdatePullRequest

Open a pull request from `branch` in the session's repository, or update the one already recorded for that branch, reopening it if it was closed. The base defaults to the repository's default branch. A merged pull request is never reopened; a later call for the same branch opens a new one. The session does not need to be running.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createOrUpdateSessionPullRequest" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/pull-request" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.Github.CreateOrUpdatePullRequestAsync(
    sessionId: "<id>",
    body: new GitHubPullRequestRequest() {
        Branch = "<value>",
        Title = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `SessionId`                                                                    | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `Body`                                                                         | [GitHubPullRequestRequest](../../Types/Components/GitHubPullRequestRequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `XOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |

### Response

**[CreateOrUpdateSessionPullRequestResponse](../../Types/Requests/CreateOrUpdateSessionPullRequestResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |