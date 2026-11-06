# ToolPolicy

## Overview

Organization tool policy API. Org admins deny tool types, or require approval before their calls run, for every Responses request in the organization, including saved agent runs. The policy overrides what requests and agents configure.

### Available Operations

* [GetToolPolicy](#gettoolpolicy) - Get the tool policy
* [UpdateToolPolicy](#updatetoolpolicy) - Replace the tool policy
* [DeleteToolPolicy](#deletetoolpolicy) - Delete the tool policy

## GetToolPolicy

Retrieve your organization's tool policy: the rules that deny tool types, or hold their calls for approval, on every Responses request in the organization, including saved agent runs. When the organization has no policy, rules is empty and updated_at is null.

### Example Usage

<!-- UsageSnippet language="go" operationID="getToolPolicy" method="get" path="/api/v1/llm/tool_policy" -->
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

    res, err := s.ToolPolicy.GetToolPolicy(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ToolPolicy != nil {
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

**[*operations.GetToolPolicyResponse](../../models/operations/gettoolpolicyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateToolPolicy

Replace your organization's tool policy (org admin only). Each rule names a tool type and an action: deny refuses requests that configure the tool, and require_approval holds each call until it is approved. MCP rules can be limited to servers by hostname and to tool names; a deny rule with tool_names removes those tools instead of refusing the request. The strictest matching rule applies, and nothing in a request or saved agent relaxes it. Changes reach every server within 10 seconds.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateToolPolicy" method="put" path="/api/v1/llm/tool_policy" -->
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

    res, err := s.ToolPolicy.UpdateToolPolicy(ctx, components.UpdateToolPolicyRequest{
        Rules: []components.ToolPolicyRule{
            components.ToolPolicyRule{
                Type: components.PolicyToolTypeCodeInterpreter,
                Action: components.ToolPolicyActionDeny,
            },
            components.ToolPolicyRule{
                Type: components.PolicyToolTypeMcp,
                Action: components.ToolPolicyActionRequireApproval,
            },
            components.ToolPolicyRule{
                Type: components.PolicyToolTypeMcp,
                Action: components.ToolPolicyActionDeny,
                ServerDomains: []string{
                    "mcp.example.com",
                },
                ToolNames: []string{
                    "delete_repository",
                },
            },
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ToolPolicy != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `request`                                                                                | [components.UpdateToolPolicyRequest](../../models/components/updatetoolpolicyrequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.UpdateToolPolicyResponse](../../models/operations/updatetoolpolicyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteToolPolicy

Delete your organization's tool policy (org admin only), removing every restriction it set. Idempotent: deleting when there is no policy returns deleted: false.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteToolPolicy" method="delete" path="/api/v1/llm/tool_policy" -->
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

    res, err := s.ToolPolicy.DeleteToolPolicy(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.DeleteToolPolicyResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.DeleteToolPolicyResponse](../../models/operations/deletetoolpolicyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |