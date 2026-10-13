# Llm.McpVault

## Overview

### Available Operations

* [create_server](#create_server) - Create MCP server
* [list_servers](#list_servers) - List MCP servers
* [get_server](#get_server) - Retrieve MCP server
* [update_server](#update_server) - Update MCP server
* [delete_server](#delete_server) - Delete MCP server
* [create_credential](#create_credential) - Create MCP credential
* [list_credentials](#list_credentials) - List MCP credentials
* [delete_credential](#delete_credential) - Delete MCP credential
* [test_server](#test_server) - Test MCP server

## create_server

Creates a user-owned MCP server configuration. Secret credentials are stored separately.

### Example Usage

<!-- UsageSnippet language="python" operationID="createMcpServer" method="post" path="/api/v1/llm/mcp/servers" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.create_server(name="Linear", server_label="linear", server_url_="https://mcp.linear.app/mcp", allowed_tools=[
        "issues.list",
    ], require_approval="always")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `name`                                                                                | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `server_label`                                                                        | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `server_url`                                                                          | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `server_description`                                                                  | *OptionalNullable[str]*                                                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `allowed_tools`                                                                       | [OptionalNullable[models.MCPAllowedToolsUnion]](../../models/mcpallowedtoolsunion.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `require_approval`                                                                    | [Optional[models.MCPRequireApproval]](../../models/mcprequireapproval.md)             | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `metadata`                                                                            | Dict[str, *Any*]                                                                      | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |

### Response

**[models.McpServer](../../models/mcpserver.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_servers

Lists MCP server configurations owned by the authenticated user context.

### Example Usage

<!-- UsageSnippet language="python" operationID="listMcpServers" method="get" path="/api/v1/llm/mcp/servers" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.list_servers(limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `limit`                                                                     | *Optional[int]*                                                             | :heavy_minus_sign:                                                          | N/A                                                                         |
| `after`                                                                     | *Optional[str]*                                                             | :heavy_minus_sign:                                                          | N/A                                                                         |
| `order`                                                                     | [Optional[models.ListMcpServersOrder]](../../models/listmcpserversorder.md) | :heavy_minus_sign:                                                          | N/A                                                                         |
| `x_on_behalf_of`                                                            | *Optional[str]*                                                             | :heavy_minus_sign:                                                          | Optional external end-user identifier forwarded by the API gateway.         |
| `retries`                                                                   | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)            | :heavy_minus_sign:                                                          | Configuration to override the default retry behavior of the client.         |

### Response

**[models.McpServerList](../../models/mcpserverlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_server

Returns a user-owned MCP server configuration.

### Example Usage

<!-- UsageSnippet language="python" operationID="getMcpServer" method="get" path="/api/v1/llm/mcp/servers/{server_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.get_server(server_id="mcp_srv_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `server_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.McpServer](../../models/mcpserver.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_server

Partially updates a user-owned MCP server configuration.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateMcpServer" method="post" path="/api/v1/llm/mcp/servers/{server_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.update_server(server_id="mcp_srv_aa87e2b1112a455b8deabed784372198", allowed_tools=[
        "issues.list",
        "issues.create",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `server_id`                                                                           | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   | mcp_srv_aa87e2b1112a455b8deabed784372198                                              |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |                                                                                       |
| `name`                                                                                | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `server_label`                                                                        | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `server_url`                                                                          | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `server_description`                                                                  | *OptionalNullable[str]*                                                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `allowed_tools`                                                                       | [OptionalNullable[models.MCPAllowedToolsUnion]](../../models/mcpallowedtoolsunion.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `require_approval`                                                                    | [Optional[models.MCPRequireApproval]](../../models/mcprequireapproval.md)             | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `metadata`                                                                            | Dict[str, *Any*]                                                                      | :heavy_minus_sign:                                                                    | N/A                                                                                   |                                                                                       |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |                                                                                       |

### Response

**[models.McpServer](../../models/mcpserver.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_server

Soft-deletes a user-owned MCP server and revokes its credentials.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteMcpServer" method="delete" path="/api/v1/llm/mcp/servers/{server_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.delete_server(server_id="mcp_srv_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `server_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.McpDeleted](../../models/mcpdeleted.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_credential

Stores encrypted credentials for a user-owned MCP server. Secret values are never returned.

### Example Usage

<!-- UsageSnippet language="python" operationID="createMcpCredential" method="post" path="/api/v1/llm/mcp/servers/{server_id}/credentials" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.create_credential(server_id="mcp_srv_aa87e2b1112a455b8deabed784372198", name="Personal Linear token", bearer_token="lin_api_xxx")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          | Example                                                              |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `server_id`                                                          | *str*                                                                | :heavy_check_mark:                                                   | N/A                                                                  | mcp_srv_aa87e2b1112a455b8deabed784372198                             |
| `x_on_behalf_of`                                                     | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | Optional external end-user identifier forwarded by the API gateway.  |                                                                      |
| `name`                                                               | *OptionalNullable[str]*                                              | :heavy_minus_sign:                                                   | N/A                                                                  |                                                                      |
| `auth_type`                                                          | [Optional[models.MCPAuthType]](../../models/mcpauthtype.md)          | :heavy_minus_sign:                                                   | N/A                                                                  |                                                                      |
| `bearer_token`                                                       | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | N/A                                                                  |                                                                      |
| `authorization`                                                      | *Optional[str]*                                                      | :heavy_minus_sign:                                                   | N/A                                                                  |                                                                      |
| `headers`                                                            | Dict[str, *str*]                                                     | :heavy_minus_sign:                                                   | N/A                                                                  |                                                                      |
| `expires_at`                                                         | [date](https://docs.python.org/3/library/datetime.html#date-objects) | :heavy_minus_sign:                                                   | N/A                                                                  |                                                                      |
| `retries`                                                            | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)     | :heavy_minus_sign:                                                   | Configuration to override the default retry behavior of the client.  |                                                                      |

### Response

**[models.McpCredential](../../models/mcpcredential.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_credentials

Lists encrypted credential metadata for a user-owned MCP server.

### Example Usage

<!-- UsageSnippet language="python" operationID="listMcpCredentials" method="get" path="/api/v1/llm/mcp/servers/{server_id}/credentials" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.list_credentials(server_id="mcp_srv_aa87e2b1112a455b8deabed784372198", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         | Example                                                                             |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `server_id`                                                                         | *str*                                                                               | :heavy_check_mark:                                                                  | N/A                                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                                            |
| `limit`                                                                             | *Optional[int]*                                                                     | :heavy_minus_sign:                                                                  | N/A                                                                                 |                                                                                     |
| `after`                                                                             | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | N/A                                                                                 |                                                                                     |
| `order`                                                                             | [Optional[models.ListMcpCredentialsOrder]](../../models/listmcpcredentialsorder.md) | :heavy_minus_sign:                                                                  | N/A                                                                                 |                                                                                     |
| `include_revoked`                                                                   | [Optional[models.IncludeRevoked]](../../models/includerevoked.md)                   | :heavy_minus_sign:                                                                  | N/A                                                                                 |                                                                                     |
| `x_on_behalf_of`                                                                    | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |                                                                                     |
| `retries`                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                    | :heavy_minus_sign:                                                                  | Configuration to override the default retry behavior of the client.                 |                                                                                     |

### Response

**[models.McpCredentialList](../../models/mcpcredentiallist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_credential

Revokes a user-owned MCP credential.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteMcpCredential" method="delete" path="/api/v1/llm/mcp/credentials/{credential_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.delete_credential(credential_id="mcp_cred_bb98f3c2223b566c9dfbcef895483209")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `credential_id`                                                     | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mcp_cred_bb98f3c2223b566c9dfbcef895483209                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.McpDeleted](../../models/mcpdeleted.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## test_server

Connects to an MCP server using the authenticated user's stored credential and returns discovered tool names. Failed connections return a 502 error; connection details are retained in redacted server logs.

### Example Usage

<!-- UsageSnippet language="python" operationID="testMcpServer" method="post" path="/api/v1/llm/mcp/servers/{server_id}/test" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.mcp_vault.test_server(server_id="mcp_srv_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `server_id`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.McpServerTest](../../models/mcpservertest.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |