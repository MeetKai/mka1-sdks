# AgentRuns

## Overview

Execute saved agents and inspect persisted run results.

### Available Operations

* [ListAgentRuns](#listagentruns) - List runs for an agent
* [CreateAgentRun](#createagentrun) - Start a saved agent run
* [StreamAgentRunEvents](#streamagentrunevents) - Stream agent run events
* [WakeAgentRun](#wakeagentrun) - Wake a sleeping agent run
* [DecideAgentRunMcpApproval](#decideagentrunmcpapproval) - Approve or deny a pending MCP tool call
* [GetAgentRun](#getagentrun) - Retrieve an agent run

## ListAgentRuns

List runs for an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAgentRuns" method="get" path="/api/v1/agents/{agent_id}/runs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentRuns.ListAgentRunsAsync(
    agentId: "<id>",
    limit: 20,
    order: ListAgentRunsOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Order`                                                             | [ListAgentRunsOrder](../../Types/Requests/ListAgentRunsOrder.md)    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListAgentRunsResponse](../../Types/Requests/ListAgentRunsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## CreateAgentRun

Starts an asynchronous background run for a saved agent and returns the queued run record. Use the run retrieval endpoint to poll status or the events endpoint to stream progress.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAgentRun" method="post" path="/api/v1/agents/{agent_id}/runs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentRuns.CreateAgentRunAsync(
    agentId: "<id>",
    body: new MeetKai.MKA1.Types.Components.CreateAgentRunRequest() {
        Input = CreateAgentRunRequestInputUnion.CreateArrayOfCreateAgentRunRequestInput(
            new List<CreateAgentRunRequestInput>() {
                new CreateAgentRunRequestInput() {
                    Type = "<value>",
                },
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `AgentId`                                                                                 | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `Body`                                                                                    | [Types.Components.CreateAgentRunRequest](../../Types/Components/CreateAgentRunRequest.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `XOnBehalfOf`                                                                             | *string*                                                                                  | :heavy_minus_sign:                                                                        | Optional external end-user identifier forwarded by the API gateway.                       |

### Response

**[CreateAgentRunResponse](../../Types/Requests/CreateAgentRunResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 404                           | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## StreamAgentRunEvents

Streams Server-Sent Events for the gateway response linked to this agent run. Terminal runs emit a single terminal event and close.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="streamAgentRunEvents" method="get" path="/api/v1/agents/{agent_id}/runs/{run_id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentRuns.StreamAgentRunEventsAsync(
    agentId: "<id>",
    runId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[StreamAgentRunEventsResponse](../../Types/Requests/StreamAgentRunEventsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404, 409                           | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## WakeAgentRun

Interrupts a short sleep tool call on a background run by forwarding follow-up input to the gateway response.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="wakeAgentRun" method="post" path="/api/v1/agents/{agent_id}/runs/{run_id}/wake" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentRuns.WakeAgentRunAsync(
    agentId: "<id>",
    runId: "<id>",
    body: new MeetKai.MKA1.Types.Components.WakeAgentRunRequest() {
        Input = WakeAgentRunRequestInputUnion.CreateArrayOfWakeAgentRunRequestInput(
            new List<WakeAgentRunRequestInput>() {
                new WakeAgentRunRequestInput() {},
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `AgentId`                                                                             | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `RunId`                                                                               | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Body`                                                                                | [Types.Components.WakeAgentRunRequest](../../Types/Components/WakeAgentRunRequest.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `XOnBehalfOf`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |

### Response

**[WakeAgentRunResponse](../../Types/Requests/WakeAgentRunResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 404, 409                      | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## DecideAgentRunMcpApproval

Creates a continuation run for an mcp_approval_request emitted by the source run. The gateway binds the single-use decision to the original server, tool, and arguments; denying never invokes the remote MCP tool.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="decideAgentRunMcpApproval" method="post" path="/api/v1/agents/{agent_id}/runs/{run_id}/mcp-approvals" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentRuns.DecideAgentRunMcpApprovalAsync(
    agentId: "<id>",
    runId: "<id>",
    body: new MeetKai.MKA1.Types.Components.DecideAgentRunMcpApprovalRequest() {
        ApprovalRequestId = "<id>",
        Approve = false,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `AgentId`                                                                                                       | *string*                                                                                                        | :heavy_check_mark:                                                                                              | N/A                                                                                                             |
| `RunId`                                                                                                         | *string*                                                                                                        | :heavy_check_mark:                                                                                              | N/A                                                                                                             |
| `Body`                                                                                                          | [Types.Components.DecideAgentRunMcpApprovalRequest](../../Types/Components/DecideAgentRunMcpApprovalRequest.md) | :heavy_check_mark:                                                                                              | N/A                                                                                                             |
| `XOnBehalfOf`                                                                                                   | *string*                                                                                                        | :heavy_minus_sign:                                                                                              | Optional external end-user identifier forwarded by the API gateway.                                             |

### Response

**[DecideAgentRunMcpApprovalResponse](../../Types/Requests/DecideAgentRunMcpApprovalResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 404, 409                      | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## GetAgentRun

Retrieve an agent run

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAgentRun" method="get" path="/api/v1/agents/{agent_id}/runs/{run_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentRuns.GetAgentRunAsync(
    agentId: "<id>",
    runId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetAgentRunResponse](../../Types/Requests/GetAgentRunResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |