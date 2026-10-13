# Agents

## Overview

Create and manage reusable agent definitions.

### Available Operations

* [ListAgents](#listagents) - List agents
* [CreateAgent](#createagent) - Create an agent
* [GetAgent](#getagent) - Retrieve an agent
* [UpdateAgent](#updateagent) - Update an agent
* [DeleteAgent](#deleteagent) - Delete an agent

## ListAgents

List agents

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAgents" method="get" path="/api/v1/agents" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Agents.ListAgentsAsync(
    limit: 20,
    order: ListAgentsOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Order`                                                             | [ListAgentsOrder](../../Types/Requests/ListAgentsOrder.md)          | :heavy_minus_sign:                                                  | N/A                                                                 |

### Response

**[ListAgentsResponse](../../Types/Requests/ListAgentsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## CreateAgent

Create an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAgent" method="post" path="/api/v1/agents" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Agents.CreateAgentAsync(body: new MeetKai.MKA1.Types.Components.CreateAgentRequest() {
    Name = "release-research-agent",
    Description = "Looks up current release information before answering.",
    Model = "functionary-pt",
    Instructions = "Use web search when the question depends on current external information.",
    Tools = new List<ToolDefinitionUnion>() {
        ToolDefinitionUnion.CreateToolDefinition1(
            new ToolDefinition1() {
                Type = ToolDefinitionType1.WebSearch,
                SearchContextSize = ToolDefinitionSearchContextSize.Medium,
            }
        ),
    },
    ToolChoice = "auto",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `Body`                                                                              | [Types.Components.CreateAgentRequest](../../Types/Components/CreateAgentRequest.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `XOnBehalfOf`                                                                       | *string*                                                                            | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |

### Response

**[CreateAgentResponse](../../Types/Requests/CreateAgentResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## GetAgent

Retrieve an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAgent" method="get" path="/api/v1/agents/{agent_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Agents.GetAgentAsync(agentId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetAgentResponse](../../Types/Requests/GetAgentResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## UpdateAgent

Update an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAgent" method="post" path="/api/v1/agents/{agent_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Agents.UpdateAgentAsync(
    agentId: "<id>",
    body: new MeetKai.MKA1.Types.Components.UpdateAgentRequest() {
        Model = "functionary-pt",
    }
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `AgentId`                                                                           | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `Body`                                                                              | [Types.Components.UpdateAgentRequest](../../Types/Components/UpdateAgentRequest.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `XOnBehalfOf`                                                                       | *string*                                                                            | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |

### Response

**[UpdateAgentResponse](../../Types/Requests/UpdateAgentResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 404                           | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## DeleteAgent

Delete an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteAgent" method="delete" path="/api/v1/agents/{agent_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Agents.DeleteAgentAsync(agentId: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteAgentResponse](../../Types/Requests/DeleteAgentResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404, 409                           | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |