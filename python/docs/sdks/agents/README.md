# Agents

## Overview

Create and manage reusable agent definitions.

### Available Operations

* [list_agents](#list_agents) - List agents
* [create_agent](#create_agent) - Create an agent
* [get_agent](#get_agent) - Retrieve an agent
* [update_agent](#update_agent) - Update an agent
* [delete_agent](#delete_agent) - Delete an agent

## list_agents

List agents

### Example Usage

<!-- UsageSnippet language="python" operationID="listAgents" method="get" path="/api/v1/agents" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agents.list_agents(limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `order`                                                             | [Optional[models.ListAgentsOrder]](../../models/listagentsorder.md) | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentList](../../models/agentlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_agent

Create an agent

### Example Usage

<!-- UsageSnippet language="python" operationID="createAgent" method="post" path="/api/v1/agents" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agents.create_agent(name="release-research-agent", model="functionary-pt", description="Looks up current release information before answering.", instructions="Use web search when the question depends on current external information.", tools=[
        {
            "type": "web_search",
            "search_context_size": "medium",
        },
    ], tool_choice="auto", parallel_tool_calls=True)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         | Example                                                                                             |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `name`                                                                                              | *str*                                                                                               | :heavy_check_mark:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `model`                                                                                             | *str*                                                                                               | :heavy_check_mark:                                                                                  | N/A                                                                                                 | functionary-pt                                                                                      |
| `x_on_behalf_of`                                                                                    | *Optional[str]*                                                                                     | :heavy_minus_sign:                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                 |                                                                                                     |
| `description`                                                                                       | *OptionalNullable[str]*                                                                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `instructions`                                                                                      | *OptionalNullable[str]*                                                                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `tools`                                                                                             | List[[models.ToolDefinitionUnion](../../models/tooldefinitionunion.md)]                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `tool_choice`                                                                                       | *Optional[Any]*                                                                                     | :heavy_minus_sign:                                                                                  | Arbitrary JSON value.                                                                               |                                                                                                     |
| `parallel_tool_calls`                                                                               | *Optional[bool]*                                                                                    | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `max_tool_calls`                                                                                    | *OptionalNullable[int]*                                                                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `text`                                                                                              | [OptionalNullable[models.AgentTextConfiguration]](../../models/agenttextconfiguration.md)           | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `reasoning`                                                                                         | [OptionalNullable[models.AgentReasoningConfiguration]](../../models/agentreasoningconfiguration.md) | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `metadata`                                                                                          | Dict[str, *str*]                                                                                    | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `retries`                                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                    | :heavy_minus_sign:                                                                                  | Configuration to override the default retry behavior of the client.                                 |                                                                                                     |

### Response

**[models.Agent](../../models/agent.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_agent

Retrieve an agent

### Example Usage

<!-- UsageSnippet language="python" operationID="getAgent" method="get" path="/api/v1/agents/{agent_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agents.get_agent(agent_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.Agent](../../models/agent.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_agent

Update an agent

### Example Usage

<!-- UsageSnippet language="python" operationID="updateAgent" method="post" path="/api/v1/agents/{agent_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agents.update_agent(agent_id="<id>", model="functionary-pt")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         | Example                                                                                             |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `agent_id`                                                                                          | *str*                                                                                               | :heavy_check_mark:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `x_on_behalf_of`                                                                                    | *Optional[str]*                                                                                     | :heavy_minus_sign:                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                 |                                                                                                     |
| `name`                                                                                              | *Optional[str]*                                                                                     | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `description`                                                                                       | *OptionalNullable[str]*                                                                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `model`                                                                                             | *Optional[str]*                                                                                     | :heavy_minus_sign:                                                                                  | N/A                                                                                                 | functionary-pt                                                                                      |
| `instructions`                                                                                      | *OptionalNullable[str]*                                                                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `tools`                                                                                             | List[[models.ToolDefinitionUnion](../../models/tooldefinitionunion.md)]                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `tool_choice`                                                                                       | *Optional[Any]*                                                                                     | :heavy_minus_sign:                                                                                  | Arbitrary JSON value.                                                                               |                                                                                                     |
| `parallel_tool_calls`                                                                               | *Optional[bool]*                                                                                    | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `max_tool_calls`                                                                                    | *OptionalNullable[int]*                                                                             | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `text`                                                                                              | [OptionalNullable[models.AgentTextConfiguration]](../../models/agenttextconfiguration.md)           | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `reasoning`                                                                                         | [OptionalNullable[models.AgentReasoningConfiguration]](../../models/agentreasoningconfiguration.md) | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `metadata`                                                                                          | Dict[str, *str*]                                                                                    | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |                                                                                                     |
| `retries`                                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                    | :heavy_minus_sign:                                                                                  | Configuration to override the default retry behavior of the client.                                 |                                                                                                     |

### Response

**[models.Agent](../../models/agent.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401, 404          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_agent

Delete an agent

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteAgent" method="delete" path="/api/v1/agents/{agent_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agents.delete_agent(agent_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteAgentResponse](../../models/deleteagentresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404, 409          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |