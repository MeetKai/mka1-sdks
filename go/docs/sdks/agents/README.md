# Agents

## Overview

Create and manage reusable agent definitions.

### Available Operations

* [ListFunctionTools](#listfunctiontools) - List reusable function tools
* [CreateFunctionTool](#createfunctiontool) - Create a reusable function tool
* [GetFunctionTool](#getfunctiontool) - Get a reusable function tool
* [UpdateFunctionTool](#updatefunctiontool) - Replace a reusable function definition
* [DeleteFunctionTool](#deletefunctiontool) - Delete a reusable function tool
* [ListOpenAPIToolSets](#listopenapitoolsets) - List imported OpenAPI tool sets
* [ImportOpenAPIToolSet](#importopenapitoolset) - Import an OpenAPI document as a tool set
* [GetOpenAPIToolSet](#getopenapitoolset) - Get an imported OpenAPI tool set
* [ReimportOpenAPIToolSet](#reimportopenapitoolset) - Replace an OpenAPI tool set with a new import
* [DeleteOpenAPIToolSet](#deleteopenapitoolset) - Delete an OpenAPI tool set
* [ListAgents](#listagents) - List agents
* [CreateAgent](#createagent) - Create an agent
* [GetAgent](#getagent) - Retrieve an agent
* [UpdateAgent](#updateagent) - Update an agent
* [DeleteAgent](#deleteagent) - Soft-delete an agent
* [RestoreAgent](#restoreagent) - Restore a soft-deleted agent

## ListFunctionTools

List reusable function tools

### Example Usage

<!-- UsageSnippet language="go" operationID="listFunctionTools" method="get" path="/api/v1/agents/function-tools" -->
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

    res, err := s.Agents.ListFunctionTools(ctx, nil, mka1.Pointer[int64](20), operations.ListFunctionToolsOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FunctionToolList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `ctx`                                                                                   | [context.Context](https://pkg.go.dev/context#Context)                                   | :heavy_check_mark:                                                                      | The context to use for the request.                                                     |
| `after`                                                                                 | `*string`                                                                               | :heavy_minus_sign:                                                                      | The last_id from the previous page                                                      |
| `limit`                                                                                 | `*int64`                                                                                | :heavy_minus_sign:                                                                      | N/A                                                                                     |
| `order`                                                                                 | [*operations.ListFunctionToolsOrder](../../models/operations/listfunctiontoolsorder.md) | :heavy_minus_sign:                                                                      | N/A                                                                                     |
| `xOnBehalfOf`                                                                           | `*string`                                                                               | :heavy_minus_sign:                                                                      | Optional external end-user identifier forwarded by the API gateway.                     |
| `opts`                                                                                  | [][operations.Option](../../models/operations/option.md)                                | :heavy_minus_sign:                                                                      | The options for this request.                                                           |

### Response

**[*operations.ListFunctionToolsResponse](../../models/operations/listfunctiontoolsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateFunctionTool

Create a reusable function tool

### Example Usage

<!-- UsageSnippet language="go" operationID="createFunctionTool" method="post" path="/api/v1/agents/function-tools" -->
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

    res, err := s.Agents.CreateFunctionTool(ctx, components.AgentsFunctionToolDefinition{
        Type: components.AgentsFunctionToolDefinitionTypeFunction,
        Name: "lookup_order",
        Description: mka1.Pointer("Look up an order"),
        Parameters: map[string]any{
            "type": "object",
            "properties": map[string]any{
                "order_id": map[string]any{
                    "type": "string",
                },
            },
            "required": []any{
                "order_id",
            },
            "additionalProperties": false,
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FunctionTool != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `body`                                                                                             | [components.AgentsFunctionToolDefinition](../../models/components/agentsfunctiontooldefinition.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.CreateFunctionToolResponse](../../models/operations/createfunctiontoolresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetFunctionTool

Get a reusable function tool

### Example Usage

<!-- UsageSnippet language="go" operationID="getFunctionTool" method="get" path="/api/v1/agents/function-tools/{tool_id}" -->
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

    res, err := s.Agents.GetFunctionTool(ctx, "fnt_order_lookup", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FunctionTool != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `toolID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | fnt_order_lookup                                                    |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetFunctionToolResponse](../../models/operations/getfunctiontoolresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateFunctionTool

Updates apply to every attached agent on its next run. Existing run snapshots are immutable.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateFunctionTool" method="post" path="/api/v1/agents/function-tools/{tool_id}" -->
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

    res, err := s.Agents.UpdateFunctionTool(ctx, "fnt_order_lookup", components.AgentsFunctionToolDefinition{
        Type: components.AgentsFunctionToolDefinitionTypeFunction,
        Name: "lookup_order",
        Description: mka1.Pointer("Look up an order"),
        Parameters: map[string]any{
            "type": "object",
            "properties": map[string]any{
                "order_id": map[string]any{
                    "type": "string",
                },
            },
            "required": []any{
                "order_id",
            },
            "additionalProperties": false,
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.FunctionTool != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |                                                                                                    |
| `toolID`                                                                                           | `string`                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                | fnt_order_lookup                                                                                   |
| `body`                                                                                             | [components.AgentsFunctionToolDefinition](../../models/components/agentsfunctiontooldefinition.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |                                                                                                    |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |                                                                                                    |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |                                                                                                    |

### Response

**[*operations.UpdateFunctionToolResponse](../../models/operations/updatefunctiontoolresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteFunctionTool

Attached agents fail until the unavailable reference is removed. Existing run snapshots remain usable.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteFunctionTool" method="delete" path="/api/v1/agents/function-tools/{tool_id}" -->
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

    res, err := s.Agents.DeleteFunctionTool(ctx, "fnt_order_lookup", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `toolID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | fnt_order_lookup                                                    |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteFunctionToolResponse](../../models/operations/deletefunctiontoolresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListOpenAPIToolSets

List imported OpenAPI tool sets

### Example Usage

<!-- UsageSnippet language="go" operationID="listOpenApiToolSets" method="get" path="/api/v1/agents/openapi-tool-sets" -->
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

    res, err := s.Agents.ListOpenAPIToolSets(ctx, nil, mka1.Pointer[int64](20), operations.ListOpenAPIToolSetsOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.OpenAPIToolSetList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `ctx`                                                                                       | [context.Context](https://pkg.go.dev/context#Context)                                       | :heavy_check_mark:                                                                          | The context to use for the request.                                                         |
| `after`                                                                                     | `*string`                                                                                   | :heavy_minus_sign:                                                                          | The last_id from the previous page                                                          |
| `limit`                                                                                     | `*int64`                                                                                    | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `order`                                                                                     | [*operations.ListOpenAPIToolSetsOrder](../../models/operations/listopenapitoolsetsorder.md) | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `xOnBehalfOf`                                                                               | `*string`                                                                                   | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |
| `opts`                                                                                      | [][operations.Option](../../models/operations/option.md)                                    | :heavy_minus_sign:                                                                          | The options for this request.                                                               |

### Response

**[*operations.ListOpenAPIToolSetsResponse](../../models/operations/listopenapitoolsetsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ImportOpenAPIToolSet

Parses an OpenAPI 3.0 or 3.1 document (JSON or YAML, sent in the body; it is never fetched from a URL) and stores its supported operations as tools an agent can call. Operations that cannot be called faithfully are listed in `skipped_operations`; selecting one with `operations` rejects the import instead. Credentials are never part of the document: reference a credential vault server registered for the API's base URL.

### Example Usage

<!-- UsageSnippet language="go" operationID="importOpenApiToolSet" method="post" path="/api/v1/agents/openapi-tool-sets" -->
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

    res, err := s.Agents.ImportOpenAPIToolSet(ctx, components.ImportOpenAPIToolSetRequest{
        Name: mka1.Pointer("petstore"),
        Spec: components.CreateSpecStr(
            "openapi: 3.0.3\ninfo: {title: Pet store, version: '1.0'}\nservers: [{url: 'https://api.petstore.example.com/v1'}]\npaths: {}\n",
        ),
        Operations: []string{
            "getPet",
            "createPet",
        },
        McpServerID: mka1.Pointer("mcp_srv_petstore"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.OpenAPIToolSet != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `body`                                                                                           | [components.ImportOpenAPIToolSetRequest](../../models/components/importopenapitoolsetrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.ImportOpenAPIToolSetResponse](../../models/operations/importopenapitoolsetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetOpenAPIToolSet

Get an imported OpenAPI tool set

### Example Usage

<!-- UsageSnippet language="go" operationID="getOpenApiToolSet" method="get" path="/api/v1/agents/openapi-tool-sets/{tool_set_id}" -->
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

    res, err := s.Agents.GetOpenAPIToolSet(ctx, "ots_petstore", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.OpenAPIToolSet != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `toolSetID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | ots_petstore                                                        |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetOpenAPIToolSetResponse](../../models/operations/getopenapitoolsetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ReimportOpenAPIToolSet

Applies to every attached agent on its next run. Existing run snapshots are immutable.

### Example Usage

<!-- UsageSnippet language="go" operationID="reimportOpenApiToolSet" method="post" path="/api/v1/agents/openapi-tool-sets/{tool_set_id}" -->
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

    res, err := s.Agents.ReimportOpenAPIToolSet(ctx, "ots_petstore", components.ImportOpenAPIToolSetRequest{
        Name: mka1.Pointer("petstore"),
        Spec: components.CreateSpecStr(
            "openapi: 3.0.3\ninfo: {title: Pet store, version: '1.0'}\nservers: [{url: 'https://api.petstore.example.com/v1'}]\npaths: {}\n",
        ),
        Operations: []string{
            "getPet",
            "createPet",
        },
        McpServerID: mka1.Pointer("mcp_srv_petstore"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.OpenAPIToolSet != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |                                                                                                  |
| `toolSetID`                                                                                      | `string`                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              | ots_petstore                                                                                     |
| `body`                                                                                           | [components.ImportOpenAPIToolSetRequest](../../models/components/importopenapitoolsetrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |                                                                                                  |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |                                                                                                  |

### Response

**[*operations.ReimportOpenAPIToolSetResponse](../../models/operations/reimportopenapitoolsetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteOpenAPIToolSet

Attached agents fail until the unavailable reference is removed. Existing run snapshots remain usable.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteOpenApiToolSet" method="delete" path="/api/v1/agents/openapi-tool-sets/{tool_set_id}" -->
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

    res, err := s.Agents.DeleteOpenAPIToolSet(ctx, "ots_petstore", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `toolSetID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | ots_petstore                                                        |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteOpenAPIToolSetResponse](../../models/operations/deleteopenapitoolsetresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListAgents

List agents

### Example Usage

<!-- UsageSnippet language="go" operationID="listAgents" method="get" path="/api/v1/agents" -->
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

    res, err := s.Agents.ListAgents(ctx, operations.ListAgentsRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `ctx`                                                                        | [context.Context](https://pkg.go.dev/context#Context)                        | :heavy_check_mark:                                                           | The context to use for the request.                                          |
| `request`                                                                    | [operations.ListAgentsRequest](../../models/operations/listagentsrequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |
| `opts`                                                                       | [][operations.Option](../../models/operations/option.md)                     | :heavy_minus_sign:                                                           | The options for this request.                                                |

### Response

**[*operations.ListAgentsResponse](../../models/operations/listagentsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## CreateAgent

Create an agent

### Example Usage

<!-- UsageSnippet language="go" operationID="createAgent" method="post" path="/api/v1/agents" -->
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

    res, err := s.Agents.CreateAgent(ctx, components.CreateAgentRequest{
        Name: "release-research-agent",
        Description: optionalnullable.From(mka1.Pointer("Looks up current release information before answering.")),
        Model: "functionary-pt",
        Instructions: optionalnullable.From(mka1.Pointer("Use web search when the question depends on current external information.")),
        Tools: []components.ToolDefinitionUnion{
            components.CreateToolDefinitionUnionToolDefinition1(
                components.ToolDefinition1{
                    Type: components.ToolDefinitionType1WebSearch,
                    SearchContextSize: components.ToolDefinitionSearchContextSizeMedium.ToPointer(),
                },
            ),
        },
        ToolChoice: "auto",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Agent != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `body`                                                                         | [components.CreateAgentRequest](../../models/components/createagentrequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `xOnBehalfOf`                                                                  | `*string`                                                                      | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.CreateAgentResponse](../../models/operations/createagentresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## GetAgent

Retrieve an agent

### Example Usage

<!-- UsageSnippet language="go" operationID="getAgent" method="get" path="/api/v1/agents/{agent_id}" -->
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

    res, err := s.Agents.GetAgent(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Agent != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetAgentResponse](../../models/operations/getagentresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## UpdateAgent

Update an agent

### Example Usage

<!-- UsageSnippet language="go" operationID="updateAgent" method="post" path="/api/v1/agents/{agent_id}" -->
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

    res, err := s.Agents.UpdateAgent(ctx, "<id>", components.UpdateAgentRequest{
        Model: mka1.Pointer("functionary-pt"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Agent != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `agentID`                                                                      | `string`                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `body`                                                                         | [components.UpdateAgentRequest](../../models/components/updateagentrequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `xOnBehalfOf`                                                                  | `*string`                                                                      | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.UpdateAgentResponse](../../models/operations/updateagentresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 404           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## DeleteAgent

Preserves configuration versions and run history for audit. The restore deadline is pinned using AGENT_RETENTION_DAYS at deletion.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteAgent" method="delete" path="/api/v1/agents/{agent_id}" -->
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

    res, err := s.Agents.DeleteAgent(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteAgentResponse](../../models/operations/deleteagentresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404, 409           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## RestoreAgent

Restores the original configuration and history before retention_expires_at. Requires write:agents in the original mutation tenancy. Schedules remain paused.

### Example Usage

<!-- UsageSnippet language="go" operationID="restoreAgent" method="post" path="/api/v1/agents/{agent_id}/restore" -->
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

    res, err := s.Agents.RestoreAgent(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Agent != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.RestoreAgentResponse](../../models/operations/restoreagentresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 403, 404, 409      | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |