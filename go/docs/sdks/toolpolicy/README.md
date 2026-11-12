# ToolPolicy

## Overview

Organization tool policy API. Org admins deny tool types, or require approval before their calls run, for every Responses request in the organization, including saved agent runs. The policy overrides what requests and agents configure.

### Available Operations

* [ListToolApprovals](#listtoolapprovals) - List tool approvals
* [CountToolApprovals](#counttoolapprovals) - Count pending tool approvals
* [GetToolApproval](#gettoolapproval) - Retrieve a tool approval
* [DecideToolApproval](#decidetoolapproval) - Decide a tool approval
* [GetToolPolicy](#gettoolpolicy) - Get the tool policy
* [UpdateToolPolicy](#updatetoolpolicy) - Replace the tool policy
* [DeleteToolPolicy](#deletetoolpolicy) - Delete the tool policy

## ListToolApprovals

List the tool calls waiting for your decision (which=pending, the default) or the ones already decided or expired (which=decided): the calls your organization's tool policy named you an approver of. With response_id, list instead the approvals of that response that you may see; the caller that made the request sees all of them. Results are paged with limit and after.

### Example Usage

<!-- UsageSnippet language="go" operationID="listToolApprovals" method="get" path="/api/v1/llm/tool_approvals" -->
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

    res, err := s.ToolPolicy.ListToolApprovals(ctx, operations.ListToolApprovalsRequest{
        Which: operations.WhichPending.ToPointer(),
        Limit: mka1.Pointer[int64](20),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ToolApprovalList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ListToolApprovalsRequest](../../models/operations/listtoolapprovalsrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ListToolApprovalsResponse](../../models/operations/listtoolapprovalsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CountToolApprovals

The number of tool calls waiting for your decision: what which=pending lists.

### Example Usage

<!-- UsageSnippet language="go" operationID="countToolApprovals" method="get" path="/api/v1/llm/tool_approvals/count" -->
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

    res, err := s.ToolPolicy.CountToolApprovals(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ToolApprovalCount != nil {
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

**[*operations.CountToolApprovalsResponse](../../models/operations/counttoolapprovalsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetToolApproval

Retrieve one held tool call. You can see it when you made the request it belongs to, or when your organization's tool policy named you one of its approvers. Any other approval answers 404.

### Example Usage

<!-- UsageSnippet language="go" operationID="getToolApproval" method="get" path="/api/v1/llm/tool_approvals/{approval_id}" -->
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

    res, err := s.ToolPolicy.GetToolApproval(ctx, "tapr_0f1e2d3c4b5a69788796a5b4c3d2e1f0", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ToolApproval != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `approvalID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | tapr_0f1e2d3c4b5a69788796a5b4c3d2e1f0                               |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetToolApprovalResponse](../../models/operations/gettoolapprovalresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DecideToolApproval

Approve or deny a held tool call as one of its approvers. You must be signed in yourself: API keys and calls on behalf of an end user are refused. The decision does not run the tool. The caller that made the request has 24 hours to continue its response with an approval response carrying the same decision, which runs an approved call once. Repeating your own decision returns the approval unchanged; a decision somebody else made, or one that differs from yours, answers 409 tool_approval_already_decided, and an approval past its deadline answers 409 tool_approval_expired.

### Example Usage

<!-- UsageSnippet language="go" operationID="decideToolApproval" method="post" path="/api/v1/llm/tool_approvals/{approval_id}/decision" -->
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

    res, err := s.ToolPolicy.DecideToolApproval(ctx, "tapr_0f1e2d3c4b5a69788796a5b4c3d2e1f0", components.ToolApprovalDecisionRequest{
        Decision: components.ToolApprovalDecisionRequestDecisionApprove,
        Comment: mka1.Pointer("Read-only, fine to run."),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ToolApproval != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |                                                                                                  |
| `approvalID`                                                                                     | `string`                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              | tapr_0f1e2d3c4b5a69788796a5b4c3d2e1f0                                                            |
| `body`                                                                                           | [components.ToolApprovalDecisionRequest](../../models/components/toolapprovaldecisionrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |                                                                                                  |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |                                                                                                  |

### Response

**[*operations.DecideToolApprovalResponse](../../models/operations/decidetoolapprovalresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

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