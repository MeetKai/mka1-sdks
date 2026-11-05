# Llm.McpVault

## Overview

### Available Operations

* [CreateServer](#createserver) - Create MCP server
* [ListServers](#listservers) - List MCP servers
* [GetServer](#getserver) - Retrieve MCP server
* [UpdateServer](#updateserver) - Update MCP server
* [DeleteServer](#deleteserver) - Delete MCP server
* [CreateCredential](#createcredential) - Create MCP credential
* [ListCredentials](#listcredentials) - List MCP credentials
* [DeleteCredential](#deletecredential) - Delete MCP credential
* [TestServer](#testserver) - Test MCP server
* [AuthorizeServerOAuth](#authorizeserveroauth) - Start MCP server OAuth authorization
* [CompleteOAuth](#completeoauth) - Complete MCP server OAuth authorization

## CreateServer

Creates a user-owned MCP server configuration, optionally shared with the end users the owner calls on behalf of and with the OAuth client they connect through. Secret credentials are stored separately; the OAuth client secret is write-only.

### Example Usage

<!-- UsageSnippet language="go" operationID="createMcpServer" method="post" path="/api/v1/llm/mcp/servers" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.McpVault.CreateServer(ctx, components.CreateMcpServerRequest{
        Name: "Linear",
        ServerLabel: "linear",
        ServerURL: "https://mcp.linear.app/mcp",
        AllowedTools: optionalnullable.From(mka1.Pointer(components.CreateMCPAllowedToolsUnionArrayOfStr(
            []string{
                "issues.list",
            },
        ))),
        RequireApproval: components.MCPRequireApprovalAlways.ToPointer(),
        SharedWithEndUsers: mka1.Pointer(true),
        Oauth: optionalnullable.From(&components.McpServerOAuthConfigRequest{
            AuthorizationURL: "https://linear.app/oauth/authorize",
            TokenURL: "https://api.linear.app/oauth/token",
            ClientID: "linear-oauth-client",
            ClientSecret: optionalnullable.From(mka1.Pointer("lin_oauth_xxx")),
            Scopes: []string{
                "read",
                "write",
            },
            RedirectUris: []string{
                "https://app.example.com/oauth/callback",
            },
        }),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpServer != nil {
        switch res.McpServer.AllowedTools.Type {
            case components.MCPAllowedToolsUnionTypeArrayOfStr:
                // res.McpServer.AllowedTools.ArrayOfStr is populated
            case components.MCPAllowedToolsUnionTypeMCPAllowedTools:
                // res.McpServer.AllowedTools.MCPAllowedTools is populated
            default:
                // Unknown type - use res.McpServer.AllowedTools.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `body`                                                                                 | [components.CreateMcpServerRequest](../../models/components/createmcpserverrequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.CreateMcpServerResponse](../../models/operations/createmcpserverresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListServers

Lists MCP server configurations owned by the authenticated user context.

### Example Usage

<!-- UsageSnippet language="go" operationID="listMcpServers" method="get" path="/api/v1/llm/mcp/servers" -->
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

    res, err := s.Llm.McpVault.ListServers(ctx, mka1.Pointer[int64](20), nil, operations.ListMcpServersOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpServerList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `ctx`                                                                             | [context.Context](https://pkg.go.dev/context#Context)                             | :heavy_check_mark:                                                                | The context to use for the request.                                               |
| `limit`                                                                           | `*int64`                                                                          | :heavy_minus_sign:                                                                | N/A                                                                               |
| `after`                                                                           | `*string`                                                                         | :heavy_minus_sign:                                                                | N/A                                                                               |
| `order`                                                                           | [*operations.ListMcpServersOrder](../../models/operations/listmcpserversorder.md) | :heavy_minus_sign:                                                                | N/A                                                                               |
| `xOnBehalfOf`                                                                     | `*string`                                                                         | :heavy_minus_sign:                                                                | Optional external end-user identifier forwarded by the API gateway.               |
| `opts`                                                                            | [][operations.Option](../../models/operations/option.md)                          | :heavy_minus_sign:                                                                | The options for this request.                                                     |

### Response

**[*operations.ListMcpServersResponse](../../models/operations/listmcpserversresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetServer

Returns a user-owned MCP server configuration.

### Example Usage

<!-- UsageSnippet language="go" operationID="getMcpServer" method="get" path="/api/v1/llm/mcp/servers/{server_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.McpVault.GetServer(ctx, "mcp_srv_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpServer != nil {
        switch res.McpServer.AllowedTools.Type {
            case components.MCPAllowedToolsUnionTypeArrayOfStr:
                // res.McpServer.AllowedTools.ArrayOfStr is populated
            case components.MCPAllowedToolsUnionTypeMCPAllowedTools:
                // res.McpServer.AllowedTools.MCPAllowedTools is populated
            default:
                // Unknown type - use res.McpServer.AllowedTools.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `serverID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetMcpServerResponse](../../models/operations/getmcpserverresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateServer

Partially updates a user-owned MCP server configuration. An oauth object replaces the OAuth client configuration (omit client_secret to keep the stored secret); null removes it. Setting shared_with_end_users to false revokes every end user's credential on the server.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateMcpServer" method="post" path="/api/v1/llm/mcp/servers/{server_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.McpVault.UpdateServer(ctx, "mcp_srv_aa87e2b1112a455b8deabed784372198", components.UpdateMcpServerRequest{
        AllowedTools: optionalnullable.From(mka1.Pointer(components.CreateMCPAllowedToolsUnionArrayOfStr(
            []string{
                "issues.list",
                "issues.create",
            },
        ))),
        Oauth: optionalnullable.From(&components.McpServerOAuthConfigRequest{
            AuthorizationURL: "https://linear.app/oauth/authorize",
            TokenURL: "https://api.linear.app/oauth/token",
            ClientID: "linear-oauth-client",
            Scopes: []string{
                "read",
                "write",
            },
            RedirectUris: []string{
                "https://app.example.com/oauth/callback",
            },
        }),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpServer != nil {
        switch res.McpServer.AllowedTools.Type {
            case components.MCPAllowedToolsUnionTypeArrayOfStr:
                // res.McpServer.AllowedTools.ArrayOfStr is populated
            case components.MCPAllowedToolsUnionTypeMCPAllowedTools:
                // res.McpServer.AllowedTools.MCPAllowedTools is populated
            default:
                // Unknown type - use res.McpServer.AllowedTools.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            | Example                                                                                |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |                                                                                        |
| `serverID`                                                                             | `string`                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    | mcp_srv_aa87e2b1112a455b8deabed784372198                                               |
| `body`                                                                                 | [components.UpdateMcpServerRequest](../../models/components/updatemcpserverrequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |                                                                                        |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |                                                                                        |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |                                                                                        |

### Response

**[*operations.UpdateMcpServerResponse](../../models/operations/updatemcpserverresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteServer

Soft-deletes a user-owned MCP server and revokes every credential stored on it, including its end users' credentials.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteMcpServer" method="delete" path="/api/v1/llm/mcp/servers/{server_id}" -->
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

    res, err := s.Llm.McpVault.DeleteServer(ctx, "mcp_srv_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `serverID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteMcpServerResponse](../../models/operations/deletemcpserverresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateCredential

Stores the caller's own encrypted credentials for an MCP server they own or, for an end user, their developer's server shared with end users. Secret values are never returned.

### Example Usage

<!-- UsageSnippet language="go" operationID="createMcpCredential" method="post" path="/api/v1/llm/mcp/servers/{server_id}/credentials" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.McpVault.CreateCredential(ctx, "mcp_srv_aa87e2b1112a455b8deabed784372198", components.CreateMcpCredentialRequest{
        Name: optionalnullable.From(mka1.Pointer("Personal Linear token")),
        BearerToken: mka1.Pointer("lin_api_xxx"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpCredential != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    | Example                                                                                        |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |                                                                                                |
| `serverID`                                                                                     | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            | mcp_srv_aa87e2b1112a455b8deabed784372198                                                       |
| `body`                                                                                         | [components.CreateMcpCredentialRequest](../../models/components/createmcpcredentialrequest.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |                                                                                                |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |                                                                                                |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |                                                                                                |

### Response

**[*operations.CreateMcpCredentialResponse](../../models/operations/createmcpcredentialresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListCredentials

Lists the caller's own encrypted credential metadata for an MCP server they own or, for an end user, their developer's server shared with end users.

### Example Usage

<!-- UsageSnippet language="go" operationID="listMcpCredentials" method="get" path="/api/v1/llm/mcp/servers/{server_id}/credentials" -->
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

    res, err := s.Llm.McpVault.ListCredentials(ctx, operations.ListMcpCredentialsRequest{
        ServerID: "mcp_srv_aa87e2b1112a455b8deabed784372198",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.McpCredentialList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |
| `request`                                                                                    | [operations.ListMcpCredentialsRequest](../../models/operations/listmcpcredentialsrequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |

### Response

**[*operations.ListMcpCredentialsResponse](../../models/operations/listmcpcredentialsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteCredential

Revokes a user-owned MCP credential.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteMcpCredential" method="delete" path="/api/v1/llm/mcp/credentials/{credential_id}" -->
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

    res, err := s.Llm.McpVault.DeleteCredential(ctx, "mcp_cred_bb98f3c2223b566c9dfbcef895483209", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `credentialID`                                                      | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_cred_bb98f3c2223b566c9dfbcef895483209                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteMcpCredentialResponse](../../models/operations/deletemcpcredentialresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## TestServer

Connects to an MCP server using the authenticated user's stored credential and returns discovered tool names. Failed connections return a 502 error; connection details are retained in redacted server logs.

### Example Usage

<!-- UsageSnippet language="go" operationID="testMcpServer" method="post" path="/api/v1/llm/mcp/servers/{server_id}/test" -->
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

    res, err := s.Llm.McpVault.TestServer(ctx, "mcp_srv_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpServerTest != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `serverID`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.TestMcpServerResponse](../../models/operations/testmcpserverresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## AuthorizeServerOAuth

Starts connecting an MCP server with OAuth as the caller: an end user on their developer's server shared with end users, or the server's owner. Returns the provider authorization URL to open in the end user's browser; its state is single-use and expires after 10 minutes. redirect_uri must equal one of the server's OAuth redirect_uris.

### Example Usage

<!-- UsageSnippet language="go" operationID="authorizeMcpServerOAuth" method="post" path="/api/v1/llm/mcp/servers/{server_id}/oauth/authorize" -->
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

    res, err := s.Llm.McpVault.AuthorizeServerOAuth(ctx, "mcp_srv_aa87e2b1112a455b8deabed784372198", components.McpOAuthAuthorizeRequest{
        RedirectURI: "https://app.example.com/oauth/callback",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpOAuthAuthorization != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |                                                                                            |
| `serverID`                                                                                 | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mcp_srv_aa87e2b1112a455b8deabed784372198                                                   |
| `body`                                                                                     | [components.McpOAuthAuthorizeRequest](../../models/components/mcpoauthauthorizerequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |                                                                                            |

### Response

**[*operations.AuthorizeMcpServerOAuthResponse](../../models/operations/authorizemcpserveroauthresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CompleteOAuth

Completes an OAuth authorization with the state and code the provider sent to redirect_uri. Must be called by the same caller that started it. The gateway exchanges the code and stores the tokens as the caller's oauth credential, replacing their previous oauth credential on the server. Tokens are never returned.

### Example Usage

<!-- UsageSnippet language="go" operationID="completeMcpOAuth" method="post" path="/api/v1/llm/mcp/oauth/complete" -->
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

    res, err := s.Llm.McpVault.CompleteOAuth(ctx, components.McpOAuthCompleteRequest{
        State: "1sXq3n0d8Vb4yZ2kR7pL9tW5mC6hJ3fA0eG8uN1oQ4s",
        Code: "lin_oauth_code_xxx",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.McpCredential != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `body`                                                                                   | [components.McpOAuthCompleteRequest](../../models/components/mcpoauthcompleterequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.CompleteMcpOAuthResponse](../../models/operations/completemcpoauthresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |