# AgentVersions

## Overview

Inspect an agent's configuration history and roll back to a prior version.

### Available Operations

* [ListAgentVersions](#listagentversions) - List agent versions
* [GetAgentVersion](#getagentversion) - Retrieve an agent version
* [RollbackAgentVersion](#rollbackagentversion) - Roll back an agent to a version

## ListAgentVersions

Lists the configuration history for an agent. Each committed change (create, update, rollback) appends a version.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAgentVersions" method="get" path="/api/v1/agents/{agent_id}/versions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentVersions.ListAgentVersionsAsync(
    agentId: "<id>",
    limit: 20,
    order: ListAgentVersionsOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `AgentId`                                                                | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Limit`                                                                  | *long*                                                                   | :heavy_minus_sign:                                                       | N/A                                                                      |
| `Order`                                                                  | [ListAgentVersionsOrder](../../Types/Requests/ListAgentVersionsOrder.md) | :heavy_minus_sign:                                                       | N/A                                                                      |
| `XOnBehalfOf`                                                            | *string*                                                                 | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |

### Response

**[ListAgentVersionsResponse](../../Types/Requests/ListAgentVersionsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## GetAgentVersion

Retrieve an agent version

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAgentVersion" method="get" path="/api/v1/agents/{agent_id}/versions/{version}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentVersions.GetAgentVersionAsync(
    agentId: "<id>",
    version: 652149
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Version`                                                           | *long*                                                              | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetAgentVersionResponse](../../Types/Requests/GetAgentVersionResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## RollbackAgentVersion

Restores the target version's configuration as a new current version. History is preserved: the restore is appended as a new version rather than deleting later ones.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="rollbackAgentVersion" method="post" path="/api/v1/agents/{agent_id}/versions/{version}/rollback" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentVersions.RollbackAgentVersionAsync(
    agentId: "<id>",
    version: 880902
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Version`                                                           | *long*                                                              | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[RollbackAgentVersionResponse](../../Types/Requests/RollbackAgentVersionResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |