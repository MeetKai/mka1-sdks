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

## CreateServer

Creates a user-owned MCP server configuration. Secret credentials are stored separately.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMcpServer" method="post" path="/api/v1/llm/mcp/servers" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.CreateServerAsync(body: new MeetKai.MKA1.Types.Components.CreateMcpServerRequest() {
    Name = "Linear",
    ServerLabel = "linear",
    ServerUrl = "https://mcp.linear.app/mcp",
    AllowedTools = MCPAllowedToolsUnion.CreateArrayOfStr(
        new List<string>() {
            "issues.list",
        }
    ),
    RequireApproval = MCPRequireApproval.Always,
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Body`                                                                                      | [Types.Components.CreateMcpServerRequest](../../Types/Components/CreateMcpServerRequest.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `XOnBehalfOf`                                                                               | *string*                                                                                    | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |

### Response

**[CreateMcpServerResponse](../../Types/Requests/CreateMcpServerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListServers

Lists MCP server configurations owned by the authenticated user context.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMcpServers" method="get" path="/api/v1/llm/mcp/servers" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.ListServersAsync(
    limit: 20,
    order: ListMcpServersOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `After`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Order`                                                             | [ListMcpServersOrder](../../Types/Requests/ListMcpServersOrder.md)  | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListMcpServersResponse](../../Types/Requests/ListMcpServersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetServer

Returns a user-owned MCP server configuration.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMcpServer" method="get" path="/api/v1/llm/mcp/servers/{server_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.GetServerAsync(serverId: "mcp_srv_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ServerId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetMcpServerResponse](../../Types/Requests/GetMcpServerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateServer

Partially updates a user-owned MCP server configuration.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMcpServer" method="post" path="/api/v1/llm/mcp/servers/{server_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.UpdateServerAsync(
    serverId: "mcp_srv_aa87e2b1112a455b8deabed784372198",
    body: new MeetKai.MKA1.Types.Components.UpdateMcpServerRequest() {
        AllowedTools = MCPAllowedToolsUnion.CreateArrayOfStr(
            new List<string>() {
                "issues.list",
                "issues.create",
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 | Example                                                                                     |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `ServerId`                                                                                  | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         | mcp_srv_aa87e2b1112a455b8deabed784372198                                                    |
| `Body`                                                                                      | [Types.Components.UpdateMcpServerRequest](../../Types/Components/UpdateMcpServerRequest.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |                                                                                             |
| `XOnBehalfOf`                                                                               | *string*                                                                                    | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |                                                                                             |

### Response

**[UpdateMcpServerResponse](../../Types/Requests/UpdateMcpServerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteServer

Soft-deletes a user-owned MCP server and revokes its credentials.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteMcpServer" method="delete" path="/api/v1/llm/mcp/servers/{server_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.DeleteServerAsync(serverId: "mcp_srv_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ServerId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteMcpServerResponse](../../Types/Requests/DeleteMcpServerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateCredential

Stores encrypted credentials for a user-owned MCP server. Secret values are never returned.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMcpCredential" method="post" path="/api/v1/llm/mcp/servers/{server_id}/credentials" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.CreateCredentialAsync(
    serverId: "mcp_srv_aa87e2b1112a455b8deabed784372198",
    body: new MeetKai.MKA1.Types.Components.CreateMcpCredentialRequest() {
        Name = "Personal Linear token",
        BearerToken = "lin_api_xxx",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         | Example                                                                                             |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `ServerId`                                                                                          | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                                                            |
| `Body`                                                                                              | [Types.Components.CreateMcpCredentialRequest](../../Types/Components/CreateMcpCredentialRequest.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `XOnBehalfOf`                                                                                       | *string*                                                                                            | :heavy_minus_sign:                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                 |                                                                                                     |

### Response

**[CreateMcpCredentialResponse](../../Types/Requests/CreateMcpCredentialResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListCredentials

Lists encrypted credential metadata for a user-owned MCP server.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMcpCredentials" method="get" path="/api/v1/llm/mcp/servers/{server_id}/credentials" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListMcpCredentialsRequest req = new ListMcpCredentialsRequest() {
    ServerId = "mcp_srv_aa87e2b1112a455b8deabed784372198",
};

var res = await sdk.Llm.McpVault.ListCredentialsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `request`                                                                      | [ListMcpCredentialsRequest](../../Types/Requests/ListMcpCredentialsRequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |

### Response

**[ListMcpCredentialsResponse](../../Types/Requests/ListMcpCredentialsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteCredential

Revokes a user-owned MCP credential.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteMcpCredential" method="delete" path="/api/v1/llm/mcp/credentials/{credential_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.DeleteCredentialAsync(credentialId: "mcp_cred_bb98f3c2223b566c9dfbcef895483209");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `CredentialId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_cred_bb98f3c2223b566c9dfbcef895483209                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteMcpCredentialResponse](../../Types/Requests/DeleteMcpCredentialResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## TestServer

Connects to an MCP server using the authenticated user's stored credential and returns discovered tool names. Failed connections return a 502 error; connection details are retained in redacted server logs.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="testMcpServer" method="post" path="/api/v1/llm/mcp/servers/{server_id}/test" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.McpVault.TestServerAsync(serverId: "mcp_srv_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ServerId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[TestMcpServerResponse](../../Types/Requests/TestMcpServerResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |