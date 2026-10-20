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

<!-- UsageSnippet language="go" operationID="createGitHubAuthorizationIntent" method="post" path="/api/v1/sandbox/github/oauth/intents" -->
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

    res, err := s.Sandbox.Github.CreateAuthorizationIntent(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AuthorizeIntent != nil {
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

**[*operations.CreateGitHubAuthorizationIntentResponse](../../models/operations/creategithubauthorizationintentresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Connect

Finish GitHub authorization by exchanging the `code` and `state` from GitHub's redirect for a stored connection. The sandbox service keeps the access token encrypted and never returns it. The response lists the repositories the connection can reach.

### Example Usage

<!-- UsageSnippet language="go" operationID="connectGitHubAccount" method="post" path="/api/v1/sandbox/github/oauth/connections" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Github.Connect(ctx, components.ConnectRequest{
        Code: "<value>",
        State: "South Carolina",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Connection != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `ctx`                                                                  | [context.Context](https://pkg.go.dev/context#Context)                  | :heavy_check_mark:                                                     | The context to use for the request.                                    |
| `body`                                                                 | [components.ConnectRequest](../../models/components/connectrequest.md) | :heavy_check_mark:                                                     | N/A                                                                    |
| `xOnBehalfOf`                                                          | `*string`                                                              | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |
| `opts`                                                                 | [][operations.Option](../../models/operations/option.md)               | :heavy_minus_sign:                                                     | The options for this request.                                          |

### Response

**[*operations.ConnectGitHubAccountResponse](../../models/operations/connectgithubaccountresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## GetConnection

Return the caller's GitHub connection, or `null` when there is none. `token_invalid_at` is set once GitHub has rejected the stored token; reconnect to fix it. Set `verify` to `true` to check the token with GitHub now instead of at its next use.

### Example Usage

<!-- UsageSnippet language="go" operationID="getGitHubConnection" method="get" path="/api/v1/sandbox/github/oauth/connections" -->
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

    res, err := s.Sandbox.Github.GetConnection(ctx, mka1.Pointer(false), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConnectionEnvelope != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `verify`                                                            | `*bool`                                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetGitHubConnectionResponse](../../models/operations/getgithubconnectionresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Disconnect

Delete the caller's GitHub connection and revoke its token at GitHub. The connection is deleted even if GitHub does not confirm the revocation.

### Example Usage

<!-- UsageSnippet language="go" operationID="disconnectGitHubAccount" method="delete" path="/api/v1/sandbox/github/oauth/connections" -->
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

    res, err := s.Sandbox.Github.Disconnect(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res != nil {
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

**[*operations.DisconnectGitHubAccountResponse](../../models/operations/disconnectgithubaccountresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListRepositories

List the repositories recorded for the caller's GitHub connection, or an empty list when there is no connection. The list is captured when you connect; call `POST /github/repositories/refresh` to update it.

### Example Usage

<!-- UsageSnippet language="go" operationID="listGitHubRepositories" method="get" path="/api/v1/sandbox/github/repositories" -->
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

    res, err := s.Sandbox.Github.ListRepositories(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.RepositoryList != nil {
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

**[*operations.ListGitHubRepositoriesResponse](../../models/operations/listgithubrepositoriesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## RefreshRepositories

Re-read the repositories the caller's GitHub connection can reach, save them as the connection's repository list, and return it.

### Example Usage

<!-- UsageSnippet language="go" operationID="refreshGitHubRepositories" method="post" path="/api/v1/sandbox/github/repositories/refresh" -->
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

    res, err := s.Sandbox.Github.RefreshRepositories(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.RepositoryList != nil {
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

**[*operations.RefreshGitHubRepositoriesResponse](../../models/operations/refreshgithubrepositoriesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ResolveReference

Resolve a Git reference in a connected repository to a commit SHA. Omit `ref` to resolve the repository's default branch.

### Example Usage

<!-- UsageSnippet language="go" operationID="resolveGitHubReference" method="post" path="/api/v1/sandbox/github/repositories/resolve" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Github.ResolveReference(ctx, components.ResolveReferenceRequest{
        RepositoryID: 649579,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResolvedReference != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `body`                                                                                   | [components.ResolveReferenceRequest](../../models/components/resolvereferencerequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.ResolveGitHubReferenceResponse](../../models/operations/resolvegithubreferenceresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## CloneRepository

Clone a connected repository at `base_sha` into the session workspace using the caller's GitHub connection. The sandbox host runs the clone, so the token never enters the session.

### Example Usage

<!-- UsageSnippet language="go" operationID="cloneGitHubRepositoryIntoSession" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/read-clone" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Github.CloneRepository(ctx, "<id>", components.GitHubReadCloneRequest{
        AssignmentGeneration: 817415,
        RepositoryID: 33412,
        Owner: "<value>",
        Repository: "<value>",
        BaseSha: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GitHubReadCloneResult != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `sessionID`                                                                            | `string`                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `body`                                                                                 | [components.GitHubReadCloneRequest](../../models/components/githubreadclonerequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.CloneGitHubRepositoryIntoSessionResponse](../../models/operations/clonegithubrepositoryintosessionresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## ListSessionRepositories

Return the repositories added to the session with each one's ref, checkout path, clone status, last push, and pull request, plus the per-session repository limit.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSessionGitHubRepositories" method="get" path="/api/v1/sandbox/sessions/{session_id}/github/repositories" -->
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

    res, err := s.Sandbox.Github.ListSessionRepositories(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SessionRepositoryManifest != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListSessionGitHubRepositoriesResponse](../../models/operations/listsessiongithubrepositoriesresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## AddSessionRepository

Add a connected repository to the session and clone it at `ref`, or at the default branch when `ref` is omitted. Repeating the same request is safe. After a successful clone the repository's ref cannot change.

### Example Usage

<!-- UsageSnippet language="go" operationID="addSessionGitHubRepository" method="put" path="/api/v1/sandbox/sessions/{session_id}/github/repositories/{repository_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Github.AddSessionRepository(ctx, "<id>", 314094, components.PutSessionRepositoryRequest{
        AssignmentGeneration: 240350,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SessionRepositoryModel != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `sessionID`                                                                                      | `string`                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `repositoryID`                                                                                   | `int64`                                                                                          | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `body`                                                                                           | [components.PutSessionRepositoryRequest](../../models/components/putsessionrepositoryrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.AddSessionGitHubRepositoryResponse](../../models/operations/addsessiongithubrepositoryresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## DismissSessionRepository

Remove a repository whose clone failed from the session. A repository that cloned successfully, or whose clone is still in progress, cannot be removed.

### Example Usage

<!-- UsageSnippet language="go" operationID="dismissSessionGitHubRepository" method="delete" path="/api/v1/sandbox/sessions/{session_id}/github/repositories/{repository_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Github.DismissSessionRepository(ctx, "<id>", 254237, components.DismissSessionRepositoryRequest{
        AssignmentGeneration: 906066,
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                    | :heavy_check_mark:                                                                                       | The context to use for the request.                                                                      |
| `sessionID`                                                                                              | `string`                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `repositoryID`                                                                                           | `int64`                                                                                                  | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `body`                                                                                                   | [components.DismissSessionRepositoryRequest](../../models/components/dismisssessionrepositoryrequest.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | `*string`                                                                                                | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `opts`                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                 | :heavy_minus_sign:                                                                                       | The options for this request.                                                                            |

### Response

**[*operations.DismissSessionGitHubRepositoryResponse](../../models/operations/dismisssessiongithubrepositoryresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Push

Push the session's checkout to `branch` in the repository it was cloned from, using the caller's GitHub connection. The repository always comes from the session, never from the request. Set `checkout_path` when the repository is not at the workspace root.

### Example Usage

<!-- UsageSnippet language="go" operationID="pushSessionToGitHub" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/push" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Github.Push(ctx, "<id>", components.GitHubPushRequest{
        AssignmentGeneration: 295334,
        Branch: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GitHubPushResult != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `ctx`                                                                        | [context.Context](https://pkg.go.dev/context#Context)                        | :heavy_check_mark:                                                           | The context to use for the request.                                          |
| `sessionID`                                                                  | `string`                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `body`                                                                       | [components.GitHubPushRequest](../../models/components/githubpushrequest.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `xOnBehalfOf`                                                                | `*string`                                                                    | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |
| `opts`                                                                       | [][operations.Option](../../models/operations/option.md)                     | :heavy_minus_sign:                                                           | The options for this request.                                                |

### Response

**[*operations.PushSessionToGitHubResponse](../../models/operations/pushsessiontogithubresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## CreateOrUpdatePullRequest

Open a pull request from `branch` in the session's repository, or update the one already recorded for that branch, reopening it if it was closed. The base defaults to the repository's default branch. A merged pull request is never reopened; a later call for the same branch opens a new one. The session does not need to be running.

### Example Usage

<!-- UsageSnippet language="go" operationID="createOrUpdateSessionPullRequest" method="post" path="/api/v1/sandbox/sessions/{session_id}/github/pull-request" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Github.CreateOrUpdatePullRequest(ctx, "<id>", components.GitHubPullRequestRequest{
        Branch: "<value>",
        Title: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.GitHubPullRequestResult != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `sessionID`                                                                                | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `body`                                                                                     | [components.GitHubPullRequestRequest](../../models/components/githubpullrequestrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.CreateOrUpdateSessionPullRequestResponse](../../models/operations/createorupdatesessionpullrequestresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |