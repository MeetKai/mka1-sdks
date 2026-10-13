# AgentSchedules

## Overview

Create and manage scheduled or recurring saved agent runs.

### Available Operations

* [ListAgentSchedules](#listagentschedules) - List schedules for an agent
* [CreateAgentSchedule](#createagentschedule) - Create an agent schedule
* [GetAgentSchedule](#getagentschedule) - Retrieve an agent schedule
* [UpdateAgentSchedule](#updateagentschedule) - Update an agent schedule
* [DeleteAgentSchedule](#deleteagentschedule) - Delete an agent schedule
* [PauseAgentSchedule](#pauseagentschedule) - Pause an agent schedule
* [ResumeAgentSchedule](#resumeagentschedule) - Resume an agent schedule

## ListAgentSchedules

List schedules for an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAgentSchedules" method="get" path="/api/v1/agents/{agent_id}/schedules" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentSchedules.ListAgentSchedulesAsync(
    agentId: "<id>",
    limit: 20,
    order: ListAgentSchedulesOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `AgentId`                                                                  | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `Limit`                                                                    | *long*                                                                     | :heavy_minus_sign:                                                         | N/A                                                                        |
| `Order`                                                                    | [ListAgentSchedulesOrder](../../Types/Requests/ListAgentSchedulesOrder.md) | :heavy_minus_sign:                                                         | N/A                                                                        |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |

### Response

**[ListAgentSchedulesResponse](../../Types/Requests/ListAgentSchedulesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## CreateAgentSchedule

Creates a Temporal-backed one-time, interval, or cron schedule that starts normal saved agent runs.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentSchedules.CreateAgentScheduleAsync(
    agentId: "<id>",
    body: new MeetKai.MKA1.Types.Components.CreateAgentScheduleRequest() {
        Schedule = AgentScheduleSpec.CreateInterval(
            new AgentScheduleSpecInterval() {
                Type = TypeInterval.Interval,
                IntervalSeconds = 581769,
            }
        ),
        Input = CreateAgentScheduleRequestInputUnion.CreateArrayOfCreateAgentScheduleRequestInput(
            new List<CreateAgentScheduleRequestInput>() {}
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `AgentId`                                                                                           | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `Body`                                                                                              | [Types.Components.CreateAgentScheduleRequest](../../Types/Components/CreateAgentScheduleRequest.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `XOnBehalfOf`                                                                                       | *string*                                                                                            | :heavy_minus_sign:                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                 |

### Response

**[CreateAgentScheduleResponse](../../Types/Requests/CreateAgentScheduleResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 404                           | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## GetAgentSchedule

Retrieve an agent schedule

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAgentSchedule" method="get" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentSchedules.GetAgentScheduleAsync(
    agentId: "<id>",
    scheduleId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `ScheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetAgentScheduleResponse](../../Types/Requests/GetAgentScheduleResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## UpdateAgentSchedule

Update an agent schedule

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentSchedules.UpdateAgentScheduleAsync(
    agentId: "<id>",
    scheduleId: "<id>",
    body: new MeetKai.MKA1.Types.Components.UpdateAgentScheduleRequest() {}
);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `AgentId`                                                                                           | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `ScheduleId`                                                                                        | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `Body`                                                                                              | [Types.Components.UpdateAgentScheduleRequest](../../Types/Components/UpdateAgentScheduleRequest.md) | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `XOnBehalfOf`                                                                                       | *string*                                                                                            | :heavy_minus_sign:                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                 |

### Response

**[UpdateAgentScheduleResponse](../../Types/Requests/UpdateAgentScheduleResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 404                           | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## DeleteAgentSchedule

Delete an agent schedule

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteAgentSchedule" method="delete" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentSchedules.DeleteAgentScheduleAsync(
    agentId: "<id>",
    scheduleId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `ScheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteAgentScheduleResponse](../../Types/Requests/DeleteAgentScheduleResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## PauseAgentSchedule

Pause an agent schedule

### Example Usage

<!-- UsageSnippet language="csharp" operationID="pauseAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}/pause" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentSchedules.PauseAgentScheduleAsync(
    agentId: "<id>",
    scheduleId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `ScheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[PauseAgentScheduleResponse](../../Types/Requests/PauseAgentScheduleResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404, 409                           | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## ResumeAgentSchedule

Resume an agent schedule

### Example Usage

<!-- UsageSnippet language="csharp" operationID="resumeAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}/resume" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentSchedules.ResumeAgentScheduleAsync(
    agentId: "<id>",
    scheduleId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AgentId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `ScheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ResumeAgentScheduleResponse](../../Types/Requests/ResumeAgentScheduleResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 404, 409                           | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |