# ComputeJobs

## Overview

### Available Operations

* [ListJobs](#listjobs) - List jobs
* [CreateJob](#createjob) - Create a job
* [GetJob](#getjob) - Get a job
* [ListJobEvents](#listjobevents) - List job events
* [ListJobInstances](#listjobinstances) - List observed job instances
* [ListJobLogs](#listjoblogs) - List job logs
* [TerminateJob](#terminatejob) - Terminate a job

## ListJobs

List jobs

### Example Usage

<!-- UsageSnippet language="go" operationID="listJobs" method="get" path="/api/v1/compute/jobs" -->
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

    res, err := s.ComputeJobs.ListJobs(ctx, nil, nil, mka1.Pointer[int64](50), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeJobList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `ctx`                                                                               | [context.Context](https://pkg.go.dev/context#Context)                               | :heavy_check_mark:                                                                  | The context to use for the request.                                                 |
| `state`                                                                             | [*components.ComputeResourceState](../../models/components/computeresourcestate.md) | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `cursor`                                                                            | `*string`                                                                           | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `limit`                                                                             | `*int64`                                                                            | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `xOnBehalfOf`                                                                       | `*string`                                                                           | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |
| `opts`                                                                              | [][operations.Option](../../models/operations/option.md)                            | :heavy_minus_sign:                                                                  | The options for this request.                                                       |

### Response

**[*operations.ListJobsResponse](../../models/operations/listjobsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateJob

Create a job

### Example Usage

<!-- UsageSnippet language="go" operationID="createJob" method="post" path="/api/v1/compute/jobs" -->
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

    res, err := s.ComputeJobs.CreateJob(ctx, "<value>", components.ComputeJobCreate{
        Compute: components.ComputeRequest{
            Accelerator: "<value>",
            EphemeralDiskGb: 166801,
            GpuCount: 580753,
        },
        Container: components.CreateComputeContainerCreateUnionComputeContainerCreate2(
            components.ComputeContainerCreate2{
                Image: "https://picsum.photos/seed/vABc84qaab/2231/967",
                ScriptB64: "<value>",
            },
        ),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `ctx`                                                                      | [context.Context](https://pkg.go.dev/context#Context)                      | :heavy_check_mark:                                                         | The context to use for the request.                                        |
| `idempotencyKey`                                                           | `string`                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `body`                                                                     | [components.ComputeJobCreate](../../models/components/computejobcreate.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `xOnBehalfOf`                                                              | `*string`                                                                  | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |
| `opts`                                                                     | [][operations.Option](../../models/operations/option.md)                   | :heavy_minus_sign:                                                         | The options for this request.                                              |

### Response

**[*operations.CreateJobResponse](../../models/operations/createjobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetJob

Get a job

### Example Usage

<!-- UsageSnippet language="go" operationID="getJob" method="get" path="/api/v1/compute/jobs/{id}" -->
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

    res, err := s.ComputeJobs.GetJob(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetJobResponse](../../models/operations/getjobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListJobEvents

List job events

### Example Usage

<!-- UsageSnippet language="go" operationID="listJobEvents" method="get" path="/api/v1/compute/jobs/{id}/events" -->
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

    res, err := s.ComputeJobs.ListJobEvents(ctx, operations.ListJobEventsRequest{
        ID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeEventList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `request`                                                                          | [operations.ListJobEventsRequest](../../models/operations/listjobeventsrequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.ListJobEventsResponse](../../models/operations/listjobeventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListJobInstances

List observed job instances

### Example Usage

<!-- UsageSnippet language="go" operationID="listJobInstances" method="get" path="/api/v1/compute/jobs/{id}/instances" -->
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

    res, err := s.ComputeJobs.ListJobInstances(ctx, operations.ListJobInstancesRequest{
        ID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeInstanceList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `request`                                                                                | [operations.ListJobInstancesRequest](../../models/operations/listjobinstancesrequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.ListJobInstancesResponse](../../models/operations/listjobinstancesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListJobLogs

List job logs

### Example Usage

<!-- UsageSnippet language="go" operationID="listJobLogs" method="get" path="/api/v1/compute/jobs/{id}/logs" -->
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

    res, err := s.ComputeJobs.ListJobLogs(ctx, operations.ListJobLogsRequest{
        ID: "<id>",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeLogList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `request`                                                                      | [operations.ListJobLogsRequest](../../models/operations/listjoblogsrequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.ListJobLogsResponse](../../models/operations/listjoblogsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## TerminateJob

Terminate a job

### Example Usage

<!-- UsageSnippet language="go" operationID="terminateJob" method="post" path="/api/v1/compute/jobs/{id}/terminate" -->
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

    res, err := s.ComputeJobs.TerminateJob(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ComputeJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.TerminateJobResponse](../../models/operations/terminatejobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |