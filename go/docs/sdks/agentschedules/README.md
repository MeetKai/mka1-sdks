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

<!-- UsageSnippet language="go" operationID="listAgentSchedules" method="get" path="/api/v1/agents/{agent_id}/schedules" -->
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

    res, err := s.AgentSchedules.ListAgentSchedules(ctx, "<id>", mka1.Pointer[int64](20), operations.ListAgentSchedulesOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentScheduleList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `ctx`                                                                                     | [context.Context](https://pkg.go.dev/context#Context)                                     | :heavy_check_mark:                                                                        | The context to use for the request.                                                       |
| `agentID`                                                                                 | `string`                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `limit`                                                                                   | `*int64`                                                                                  | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `order`                                                                                   | [*operations.ListAgentSchedulesOrder](../../models/operations/listagentschedulesorder.md) | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `xOnBehalfOf`                                                                             | `*string`                                                                                 | :heavy_minus_sign:                                                                        | Optional external end-user identifier forwarded by the API gateway.                       |
| `opts`                                                                                    | [][operations.Option](../../models/operations/option.md)                                  | :heavy_minus_sign:                                                                        | The options for this request.                                                             |

### Response

**[*operations.ListAgentSchedulesResponse](../../models/operations/listagentschedulesresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## CreateAgentSchedule

Creates a Temporal-backed one-time, interval, or cron schedule that starts normal saved agent runs.

### Example Usage

<!-- UsageSnippet language="go" operationID="createAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules" -->
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

    res, err := s.AgentSchedules.CreateAgentSchedule(ctx, "<id>", components.CreateAgentScheduleRequest{
        Schedule: components.CreateAgentScheduleSpecInterval(
            components.AgentScheduleSpecInterval{
                Type: components.TypeIntervalInterval,
                IntervalSeconds: 581769,
            },
        ),
        Input: components.CreateCreateAgentScheduleRequestInputUnionArrayOfCreateAgentScheduleRequestInput(
            []components.CreateAgentScheduleRequestInput{},
        ),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentSchedule != nil {
        switch res.AgentSchedule.Schedule.Type {
            case components.AgentScheduleSpecTypeOnce:
                // res.AgentSchedule.Schedule.AgentScheduleSpecOnce is populated
            case components.AgentScheduleSpecTypeInterval:
                // res.AgentSchedule.Schedule.AgentScheduleSpecInterval is populated
            case components.AgentScheduleSpecTypeCron:
                // res.AgentSchedule.Schedule.AgentScheduleSpecCron is populated
            default:
                // Unknown type - use res.AgentSchedule.Schedule.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `agentID`                                                                                      | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `body`                                                                                         | [components.CreateAgentScheduleRequest](../../models/components/createagentschedulerequest.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.CreateAgentScheduleResponse](../../models/operations/createagentscheduleresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 404           | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## GetAgentSchedule

Retrieve an agent schedule

### Example Usage

<!-- UsageSnippet language="go" operationID="getAgentSchedule" method="get" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.AgentSchedules.GetAgentSchedule(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentSchedule != nil {
        switch res.AgentSchedule.Schedule.Type {
            case components.AgentScheduleSpecTypeOnce:
                // res.AgentSchedule.Schedule.AgentScheduleSpecOnce is populated
            case components.AgentScheduleSpecTypeInterval:
                // res.AgentSchedule.Schedule.AgentScheduleSpecInterval is populated
            case components.AgentScheduleSpecTypeCron:
                // res.AgentSchedule.Schedule.AgentScheduleSpecCron is populated
            default:
                // Unknown type - use res.AgentSchedule.Schedule.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `scheduleID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetAgentScheduleResponse](../../models/operations/getagentscheduleresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## UpdateAgentSchedule

Update an agent schedule

### Example Usage

<!-- UsageSnippet language="go" operationID="updateAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
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

    res, err := s.AgentSchedules.UpdateAgentSchedule(ctx, "<id>", "<id>", components.UpdateAgentScheduleRequest{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentSchedule != nil {
        switch res.AgentSchedule.Schedule.Type {
            case components.AgentScheduleSpecTypeOnce:
                // res.AgentSchedule.Schedule.AgentScheduleSpecOnce is populated
            case components.AgentScheduleSpecTypeInterval:
                // res.AgentSchedule.Schedule.AgentScheduleSpecInterval is populated
            case components.AgentScheduleSpecTypeCron:
                // res.AgentSchedule.Schedule.AgentScheduleSpecCron is populated
            default:
                // Unknown type - use res.AgentSchedule.Schedule.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `agentID`                                                                                      | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `scheduleID`                                                                                   | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `body`                                                                                         | [components.UpdateAgentScheduleRequest](../../models/components/updateagentschedulerequest.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.UpdateAgentScheduleResponse](../../models/operations/updateagentscheduleresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 404           | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## DeleteAgentSchedule

Delete an agent schedule

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteAgentSchedule" method="delete" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}" -->
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

    res, err := s.AgentSchedules.DeleteAgentSchedule(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `scheduleID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteAgentScheduleResponse](../../models/operations/deleteagentscheduleresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## PauseAgentSchedule

Pause an agent schedule

### Example Usage

<!-- UsageSnippet language="go" operationID="pauseAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}/pause" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.AgentSchedules.PauseAgentSchedule(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentSchedule != nil {
        switch res.AgentSchedule.Schedule.Type {
            case components.AgentScheduleSpecTypeOnce:
                // res.AgentSchedule.Schedule.AgentScheduleSpecOnce is populated
            case components.AgentScheduleSpecTypeInterval:
                // res.AgentSchedule.Schedule.AgentScheduleSpecInterval is populated
            case components.AgentScheduleSpecTypeCron:
                // res.AgentSchedule.Schedule.AgentScheduleSpecCron is populated
            default:
                // Unknown type - use res.AgentSchedule.Schedule.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `scheduleID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.PauseAgentScheduleResponse](../../models/operations/pauseagentscheduleresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404, 409           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## ResumeAgentSchedule

Resume an agent schedule

### Example Usage

<!-- UsageSnippet language="go" operationID="resumeAgentSchedule" method="post" path="/api/v1/agents/{agent_id}/schedules/{schedule_id}/resume" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.AgentSchedules.ResumeAgentSchedule(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentSchedule != nil {
        switch res.AgentSchedule.Schedule.Type {
            case components.AgentScheduleSpecTypeOnce:
                // res.AgentSchedule.Schedule.AgentScheduleSpecOnce is populated
            case components.AgentScheduleSpecTypeInterval:
                // res.AgentSchedule.Schedule.AgentScheduleSpecInterval is populated
            case components.AgentScheduleSpecTypeCron:
                // res.AgentSchedule.Schedule.AgentScheduleSpecCron is populated
            default:
                // Unknown type - use res.AgentSchedule.Schedule.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `agentID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `scheduleID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ResumeAgentScheduleResponse](../../models/operations/resumeagentscheduleresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 404, 409           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |