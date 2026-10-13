# AgentRuns

## Overview

Execute saved agents and inspect persisted run results.

### Available Operations

* [list_agent_runs](#list_agent_runs) - List runs for an agent
* [create_agent_run](#create_agent_run) - Start a saved agent run
* [stream_agent_run_events](#stream_agent_run_events) - Stream agent run events
* [wake_agent_run](#wake_agent_run) - Wake a sleeping agent run
* [decide_agent_run_mcp_approval](#decide_agent_run_mcp_approval) - Approve or deny a pending MCP tool call
* [get_agent_run](#get_agent_run) - Retrieve an agent run

## list_agent_runs

List runs for an agent

### Example Usage

<!-- UsageSnippet language="python" operationID="listAgentRuns" method="get" path="/api/v1/agents/{agent_id}/runs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_runs.list_agent_runs(agent_id="<id>", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `agent_id`                                                                | *str*                                                                     | :heavy_check_mark:                                                        | N/A                                                                       |
| `limit`                                                                   | *Optional[int]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       |
| `order`                                                                   | [Optional[models.ListAgentRunsOrder]](../../models/listagentrunsorder.md) | :heavy_minus_sign:                                                        | N/A                                                                       |
| `x_on_behalf_of`                                                          | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | Optional external end-user identifier forwarded by the API gateway.       |
| `retries`                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)          | :heavy_minus_sign:                                                        | Configuration to override the default retry behavior of the client.       |

### Response

**[models.AgentRunList](../../models/agentrunlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_agent_run

Starts an asynchronous background run for a saved agent and returns the queued run record. Use the run retrieval endpoint to poll status or the events endpoint to stream progress.

### Example Usage

<!-- UsageSnippet language="python" operationID="createAgentRun" method="post" path="/api/v1/agents/{agent_id}/runs" -->
```python
from meetkai_mka1 import SDK, models


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_runs.create_agent_run(agent_id="<id>", input=[
        models.CreateAgentRunRequestInput(
            type="<value>",
        ),
    ], stream=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                              | Type                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `agent_id`                                                                                                                                                                                                                                                             | *str*                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                    |
| `input`                                                                                                                                                                                                                                                                | [models.CreateAgentRunRequestInputUnion](../../models/createagentrunrequestinputunion.md)                                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                    |
| `x_on_behalf_of`                                                                                                                                                                                                                                                       | *Optional[str]*                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                    |
| `conversation`                                                                                                                                                                                                                                                         | *Optional[Any]*                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                     | Arbitrary JSON value.                                                                                                                                                                                                                                                  |
| `previous_response_id`                                                                                                                                                                                                                                                 | *Optional[str]*                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                    |
| `context_management`                                                                                                                                                                                                                                                   | List[[models.AgentCompactionContextManagement](../../models/agentcompactioncontextmanagement.md)]                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                                                     | Context management strategies to apply during agent-run response generation. Supports compaction, which summarizes older conversation history when the context exceeds a token threshold.                                                                              |
| `stream`                                                                                                                                                                                                                                                               | *Optional[bool]*                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                     | When true, the gateway generates per-token delta events for this run, so the events endpoint streams incremental output instead of only item and lifecycle boundaries. The run still executes in the background and this endpoint still returns the queued run record. |
| `metadata`                                                                                                                                                                                                                                                             | Dict[str, *str*]                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                    |
| `retries`                                                                                                                                                                                                                                                              | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                     | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                    |

### Response

**[models.AgentRun](../../models/agentrun.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401, 404          | application/json       |
| errors.ErrorEnvelope   | 502                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## stream_agent_run_events

Streams Server-Sent Events for the gateway response linked to this agent run. Terminal runs emit a single terminal event and close.

### Example Usage

<!-- UsageSnippet language="python" operationID="streamAgentRunEvents" method="get" path="/api/v1/agents/{agent_id}/runs/{run_id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_runs.stream_agent_run_events(agent_id="<id>", run_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[str](../../models/.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404, 409          | application/json       |
| errors.ErrorEnvelope   | 502                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## wake_agent_run

Interrupts a short sleep tool call on a background run by forwarding follow-up input to the gateway response.

### Example Usage

<!-- UsageSnippet language="python" operationID="wakeAgentRun" method="post" path="/api/v1/agents/{agent_id}/runs/{run_id}/wake" -->
```python
from meetkai_mka1 import SDK, models


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_runs.wake_agent_run(agent_id="<id>", run_id="<id>", input=[
        models.WakeAgentRunRequestInput(),
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `agent_id`                                                                            | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `run_id`                                                                              | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `input`                                                                               | [models.WakeAgentRunRequestInputUnion](../../models/wakeagentrunrequestinputunion.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |

### Response

**[models.AgentRunWake](../../models/agentrunwake.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401, 404, 409     | application/json       |
| errors.ErrorEnvelope   | 502                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## decide_agent_run_mcp_approval

Creates a continuation run for an mcp_approval_request emitted by the source run. The gateway binds the single-use decision to the original server, tool, and arguments; denying never invokes the remote MCP tool.

### Example Usage

<!-- UsageSnippet language="python" operationID="decideAgentRunMcpApproval" method="post" path="/api/v1/agents/{agent_id}/runs/{run_id}/mcp-approvals" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_runs.decide_agent_run_mcp_approval(agent_id="<id>", run_id="<id>", approval_request_id="<id>", approve=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `approval_request_id`                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `approve`                                                           | *bool*                                                              | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `reason`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentRunMcpApproval](../../models/agentrunmcpapproval.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401, 404, 409     | application/json       |
| errors.ErrorEnvelope   | 502                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_agent_run

Retrieve an agent run

### Example Usage

<!-- UsageSnippet language="python" operationID="getAgentRun" method="get" path="/api/v1/agents/{agent_id}/runs/{run_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_runs.get_agent_run(agent_id="<id>", run_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentRun](../../models/agentrun.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |