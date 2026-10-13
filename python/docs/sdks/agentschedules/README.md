# AgentSchedules

## Overview

Create and manage scheduled or recurring saved agent runs.

### Available Operations

* [list_agent_schedules](#list_agent_schedules) - List schedules for an agent
* [create_agent_schedule](#create_agent_schedule) - Create an agent schedule
* [get_agent_schedule](#get_agent_schedule) - Retrieve an agent schedule
* [update_agent_schedule](#update_agent_schedule) - Update an agent schedule
* [delete_agent_schedule](#delete_agent_schedule) - Delete an agent schedule
* [pause_agent_schedule](#pause_agent_schedule) - Pause an agent schedule
* [resume_agent_schedule](#resume_agent_schedule) - Resume an agent schedule

## list_agent_schedules

List schedules for an agent

### Example Usage

<!-- UsageSnippet language="python" operationID="listAgentSchedules" method="get" path="/api/v1/agents/{agent_id}/schedules" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_schedules.list_agent_schedules(agent_id="<id>", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `agent_id`                                                                          | *str*                                                                               | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `limit`                                                                             | *Optional[int]*                                                                     | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `order`                                                                             | [Optional[models.ListAgentSchedulesOrder]](../../models/listagentschedulesorder.md) | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `x_on_behalf_of`                                                                    | *Optional[str]*                                                                     | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `retries`                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                    | :heavy_minus_sign:                                                                  | Configuration to override the default retry behavior of the client.                 |

### Response

**[models.AgentScheduleList](../../models/agentschedulelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_agent_schedule

Creates a Temporal-backed one-time, interval, or cron schedule that starts normal saved agent runs.

### Example Usage

<!-- UsageSnippet language="python" operationID="createAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_schedules.create_agent_schedule(agent_id="<id>", schedule={
        "type": "interval",
        "interval_seconds": 581769,
        "timezone": "UTC",
    }, input=[])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                 | Type                                                                                                                                                                                      | Required                                                                                                                                                                                  | Description                                                                                                                                                                               |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `agent_id`                                                                                                                                                                                | *str*                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                        | N/A                                                                                                                                                                                       |
| `schedule`                                                                                                                                                                                | [models.AgentScheduleSpec](../../models/agentschedulespec.md)                                                                                                                             | :heavy_check_mark:                                                                                                                                                                        | N/A                                                                                                                                                                                       |
| `input`                                                                                                                                                                                   | [models.CreateAgentScheduleRequestInputUnion](../../models/createagentschedulerequestinputunion.md)                                                                                       | :heavy_check_mark:                                                                                                                                                                        | N/A                                                                                                                                                                                       |
| `x_on_behalf_of`                                                                                                                                                                          | *Optional[str]*                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                        | Optional external end-user identifier forwarded by the API gateway.                                                                                                                       |
| `name`                                                                                                                                                                                    | *Optional[str]*                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                        | N/A                                                                                                                                                                                       |
| `conversation`                                                                                                                                                                            | *Optional[Any]*                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                        | Arbitrary JSON value.                                                                                                                                                                     |
| `previous_response_id`                                                                                                                                                                    | *Optional[str]*                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                        | N/A                                                                                                                                                                                       |
| `context_management`                                                                                                                                                                      | List[[models.AgentCompactionContextManagement](../../models/agentcompactioncontextmanagement.md)]                                                                                         | :heavy_minus_sign:                                                                                                                                                                        | Context management strategies to apply during agent-run response generation. Supports compaction, which summarizes older conversation history when the context exceeds a token threshold. |
| `metadata`                                                                                                                                                                                | Dict[str, *str*]                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                        | N/A                                                                                                                                                                                       |
| `retries`                                                                                                                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                        | Configuration to override the default retry behavior of the client.                                                                                                                       |

### Response

**[models.AgentSchedule](../../models/agentschedule.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401, 404          | application/json       |
| errors.ErrorEnvelope   | 502                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_agent_schedule

Retrieve an agent schedule

### Example Usage

<!-- UsageSnippet language="python" operationID="getAgentSchedule" method="get" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_schedules.get_agent_schedule(agent_id="<id>", schedule_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `schedule_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentSchedule](../../models/agentschedule.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_agent_schedule

Update an agent schedule

### Example Usage

<!-- UsageSnippet language="python" operationID="updateAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_schedules.update_agent_schedule(agent_id="<id>", schedule_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                        | Type                                                                                                                             | Required                                                                                                                         | Description                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- |
| `agent_id`                                                                                                                       | *str*                                                                                                                            | :heavy_check_mark:                                                                                                               | N/A                                                                                                                              |
| `schedule_id`                                                                                                                    | *str*                                                                                                                            | :heavy_check_mark:                                                                                                               | N/A                                                                                                                              |
| `x_on_behalf_of`                                                                                                                 | *Optional[str]*                                                                                                                  | :heavy_minus_sign:                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                              |
| `name`                                                                                                                           | *OptionalNullable[str]*                                                                                                          | :heavy_minus_sign:                                                                                                               | N/A                                                                                                                              |
| `schedule`                                                                                                                       | [Optional[models.AgentScheduleSpec]](../../models/agentschedulespec.md)                                                          | :heavy_minus_sign:                                                                                                               | N/A                                                                                                                              |
| `input`                                                                                                                          | [Optional[models.UpdateAgentScheduleRequestInputUnion]](../../models/updateagentschedulerequestinputunion.md)                    | :heavy_minus_sign:                                                                                                               | N/A                                                                                                                              |
| `conversation`                                                                                                                   | *OptionalNullable[Any]*                                                                                                          | :heavy_minus_sign:                                                                                                               | N/A                                                                                                                              |
| `previous_response_id`                                                                                                           | *OptionalNullable[str]*                                                                                                          | :heavy_minus_sign:                                                                                                               | N/A                                                                                                                              |
| `context_management`                                                                                                             | List[[models.AgentCompactionContextManagement](../../models/agentcompactioncontextmanagement.md)]                                | :heavy_minus_sign:                                                                                                               | Context management strategies to apply during agent-run response generation. Set to null to clear the schedule-level strategies. |
| `metadata`                                                                                                                       | Dict[str, *str*]                                                                                                                 | :heavy_minus_sign:                                                                                                               | N/A                                                                                                                              |
| `retries`                                                                                                                        | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                 | :heavy_minus_sign:                                                                                                               | Configuration to override the default retry behavior of the client.                                                              |

### Response

**[models.AgentSchedule](../../models/agentschedule.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401, 404          | application/json       |
| errors.ErrorEnvelope   | 502                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_agent_schedule

Delete an agent schedule

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteAgentSchedule" method="delete" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_schedules.delete_agent_schedule(agent_id="<id>", schedule_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `schedule_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteAgentScheduleResponse](../../models/deleteagentscheduleresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## pause_agent_schedule

Pause an agent schedule

### Example Usage

<!-- UsageSnippet language="python" operationID="pauseAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}/pause" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_schedules.pause_agent_schedule(agent_id="<id>", schedule_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `schedule_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentSchedule](../../models/agentschedule.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404, 409          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## resume_agent_schedule

Resume an agent schedule

### Example Usage

<!-- UsageSnippet language="python" operationID="resumeAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}/resume" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_schedules.resume_agent_schedule(agent_id="<id>", schedule_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `agent_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `schedule_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentSchedule](../../models/agentschedule.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 404, 409          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |