# AgentRuns

## Overview

Execute saved agents and inspect persisted run results.

### Available Operations

* [ListAgentRuns](#listagentruns) - List runs for an agent
* [CreateAgentRun](#createagentrun) - Start a saved agent run
* [StreamAgentRunEvents](#streamagentrunevents) - Stream agent run events
* [CancelAgentRun](#cancelagentrun) - Cancel a saved-agent run
* [WakeAgentRun](#wakeagentrun) - Wake a sleeping agent run
* [DecideAgentRunMcpApproval](#decideagentrunmcpapproval) - Approve or deny a run's pending tool calls
* [ResumeAgentRunToolApproval](#resumeagentruntoolapproval) - Continue a run after its approvers decided
* [GetAgentRun](#getagentrun) - Retrieve an agent run

## ListAgentRuns

List runs for an agent

### Example Usage

<!-- UsageSnippet language="go" operationID="listAgentRuns" method="get" path="/api/v1/agents/{agent_id}/runs" -->
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

    res, err := s.AgentRuns.ListAgentRuns(ctx, operations.ListAgentRunsRequest{
        AgentID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentRunList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `request`                                                                          | [operations.ListAgentRunsRequest](../../models/operations/listagentrunsrequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.ListAgentRunsResponse](../../models/operations/listagentrunsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## CreateAgentRun

Starts an asynchronous background run for a saved agent and returns the queued run record. Use the run retrieval endpoint to poll status or the events endpoint to stream progress. When the agent is already running max_concurrent_runs runs, concurrency_overflow decides: reject returns 429 with error code agent_concurrency_limit and creates no run; queue returns 202 with a waiting run that starts when a slot frees.

### Example Usage

<!-- UsageSnippet language="go" operationID="createAgentRun" method="post" path="/api/v1/agents/{agent_id}/runs" -->
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

    res, err := s.AgentRuns.CreateAgentRun(ctx, "<id>", components.CreateAgentRunRequest{
        Input: components.CreateCreateAgentRunRequestInputUnionArrayOfCreateAgentRunRequestInput(
            []components.CreateAgentRunRequestInput{
                components.CreateAgentRunRequestInput{},
            },
        ),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentRun != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ctx`                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                | :heavy_check_mark:                                                                   | The context to use for the request.                                                  |
| `agentID`                                                                            | `string`                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `body`                                                                               | [components.CreateAgentRunRequest](../../models/components/createagentrunrequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `xOnBehalfOf`                                                                        | `*string`                                                                            | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `opts`                                                                               | [][operations.Option](../../models/operations/option.md)                             | :heavy_minus_sign:                                                                   | The options for this request.                                                        |

### Response

**[*operations.CreateAgentRunResponse](../../models/operations/createagentrunresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 404, 429      | application/json        |
| apierrors.ErrorEnvelope | 502, 503                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## StreamAgentRunEvents

Streams Server-Sent Events for the gateway response linked to this agent run. Terminal runs emit a single terminal event and close.

### Example Usage

<!-- UsageSnippet language="go" operationID="streamAgentRunEvents" method="get" path="/api/v1/agents/{agent_id}/runs/{run_id}/events" -->
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

    res, err := s.AgentRuns.StreamAgentRunEvents(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.StreamAgentRunEventsResponse](../../models/operations/streamagentruneventsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404, 409           | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## CancelAgentRun

Cancels a waiting or queued run locally before dispatch, or forwards cancellation to its linked gateway response. Locally failed linked runs with an active or missing gateway snapshot are checked upstream before cancellation; genuine terminal work is never relabelled cancelled. Fresh incomplete gateway snapshots are presented as incomplete on subsequent reads while preserving the connector error and completion timestamp, even if cancel returns 409. Repeated cancellation is idempotent. Returns 409 if submission has no linked response yet or a genuine terminal outcome already won. Uses the run's organization, team and delegated-user mutation scope; operator read access does not grant cancellation access. API-key callers also need write:responses for linked cancellation and read:responses to inspect locally failed runs or reconcile a completion race.

### Example Usage

<!-- UsageSnippet language="go" operationID="cancelAgentRun" method="post" path="/api/v1/agents/{agent_id}/runs/{run_id}/cancel" -->
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

    res, err := s.AgentRuns.CancelAgentRun(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentRun != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.CancelAgentRunResponse](../../models/operations/cancelagentrunresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 403, 404, 409      | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## WakeAgentRun

Interrupts a short sleep tool call on a background run by forwarding follow-up input to the gateway response.

### Example Usage

<!-- UsageSnippet language="go" operationID="wakeAgentRun" method="post" path="/api/v1/agents/{agent_id}/runs/{run_id}/wake" -->
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

    res, err := s.AgentRuns.WakeAgentRun(ctx, "<id>", "<id>", components.WakeAgentRunRequest{
        Input: components.CreateWakeAgentRunRequestInputUnionArrayOfWakeAgentRunRequestInput(
            []components.WakeAgentRunRequestInput{
                components.WakeAgentRunRequestInput{},
            },
        ),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentRunWake != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |
| `agentID`                                                                        | `string`                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `runID`                                                                          | `string`                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `body`                                                                           | [components.WakeAgentRunRequest](../../models/components/wakeagentrunrequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |

### Response

**[*operations.WakeAgentRunResponse](../../models/operations/wakeagentrunresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 404, 409      | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## DecideAgentRunMcpApproval

Answers the approval requests a run stopped for and creates the run that continues it. A run that stopped for approval has status completed and lists the held calls in pending_approvals: an mcp_approval_request for an MCP tool call, a tool_approval_request for a built-in tool call the organization's tool policy holds. Send one decision as the body itself, or several under decisions. One request must decide every pending approval of the run, because the calls left out can never be answered afterwards; otherwise the answer is 409 with error code approvals_incomplete. An expired approval needs no decision and is left out of the continuation. The decision is single-use and bound to the original tool and arguments; a denied call never runs. When the tool policy names approvers for a call, only they decide it, in the approval queue: until one has, the answer is 409 with error code tool_approval_pending, and a decision that differs from the approver's is 409 with error code tool_approval_decision_mismatch. Decisions that pass these checks and are still refused show as a failed continuation run whose error.code is one of those two codes. A run whose approvals were already answered returns 409 with error code approvals_already_answered. Only the caller whose run was held can answer it; a teammate who can read the run gets 403 with error code not_run_caller. API-key callers also need read:responses, which reading the approvals requires.

### Example Usage

<!-- UsageSnippet language="go" operationID="decideAgentRunMcpApproval" method="post" path="/api/v1/agents/{agent_id}/runs/{run_id}/mcp-approvals" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.AgentRuns.DecideAgentRunMcpApproval(ctx, "<id>", "<id>", operations.CreateDecideAgentRunMcpApprovalRequestBodyDecideAgentRunMcpApprovalRequest(
        components.DecideAgentRunMcpApprovalRequest{
            ApprovalRequestID: "<id>",
            Approve: false,
        },
    ), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentRunMcpApproval != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                          | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                                              | :heavy_check_mark:                                                                                                 | The context to use for the request.                                                                                |
| `agentID`                                                                                                          | `string`                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `runID`                                                                                                            | `string`                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `body`                                                                                                             | [operations.DecideAgentRunMcpApprovalRequestBody](../../models/operations/decideagentrunmcpapprovalrequestbody.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `xOnBehalfOf`                                                                                                      | `*string`                                                                                                          | :heavy_minus_sign:                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                |
| `opts`                                                                                                             | [][operations.Option](../../models/operations/option.md)                                                           | :heavy_minus_sign:                                                                                                 | The options for this request.                                                                                      |

### Response

**[*operations.DecideAgentRunMcpApprovalResponse](../../models/operations/decideagentrunmcpapprovalresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 403, 404, 409 | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## ResumeAgentRunToolApproval

Continues the agent run a held tool call belongs to, once the approvers the organization's tool policy names have decided every held call of that run in the approval queue. Call it after recording a decision there; this endpoint records none and takes no body. The caller must be able to read the approval: the caller whose run was held, or one of its approvers signed in to the same organization. Otherwise the answer is 404 with error code tool_approval_not_found. A held call that no agent run made returns 404 with error code not_an_agent_run. While any call of the run is undecided, including one without approvers that only the run's caller can decide, the answer has status waiting and creates nothing. Once all are decided, one continuation run is created with the identity of the run's caller and carries out each recorded decision; expired approvals are left out. Repeating the request, or two approvers finishing together, returns the same continuation run. When every approval has expired the answer is 409 with error code tool_approval_expired. The continuation is an ordinary run of the agent: it is not delivered to the connector conversation or web chat session that started the held run.

### Example Usage

<!-- UsageSnippet language="go" operationID="resumeAgentRunToolApproval" method="post" path="/api/v1/agents/tool-approvals/{approval_request_id}/resume" -->
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

    res, err := s.AgentRuns.ResumeAgentRunToolApproval(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentRunApprovalResume != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `approvalRequestID`                                                 | `string`                                                            | :heavy_check_mark:                                                  | ID of a held tool call, as the approval queue lists it.             |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ResumeAgentRunToolApprovalResponse](../../models/operations/resumeagentruntoolapprovalresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 403, 404, 409, 429 | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## GetAgentRun

Retrieve an agent run

### Example Usage

<!-- UsageSnippet language="go" operationID="getAgentRun" method="get" path="/api/v1/agents/{agent_id}/runs/{run_id}" -->
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

    res, err := s.AgentRuns.GetAgentRun(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentRun != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetAgentRunResponse](../../models/operations/getagentrunresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |