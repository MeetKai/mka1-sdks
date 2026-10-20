# ~~Llm.FineTuning~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~Create~~](#create) - [Deprecated] Create a fine-tuning job :warning: **Deprecated**
* [~~List~~](#list) - [Deprecated] List fine-tuning jobs :warning: **Deprecated**
* [~~Retrieve~~](#retrieve) - [Deprecated] Retrieve a fine-tuning job :warning: **Deprecated**
* [~~Cancel~~](#cancel) - [Deprecated] Cancel a fine-tuning job :warning: **Deprecated**
* [~~Pause~~](#pause) - [Deprecated] Pause a fine-tuning job :warning: **Deprecated**
* [~~Resume~~](#resume) - [Deprecated] Resume a fine-tuning job :warning: **Deprecated**
* [~~ListEvents~~](#listevents) - [Deprecated] List fine-tuning events :warning: **Deprecated**
* [~~ListCheckpoints~~](#listcheckpoints) - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**

## ~~Create~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Creates a fine-tuning job which begins the process of training a new model from a given dataset.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="createFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.FineTuning.Create(ctx, components.CreateFineTuningJobRequest{
        Model: "meetkai:functionary-medium",
        TrainingFile: "file_abc123",
        Suffix: optionalnullable.From(mka1.Pointer("my-model")),
        Method: optionalnullable.From(&components.Method{
            Type: components.MethodTypeSupervised,
            Supervised: optionalnullable.From(&components.Supervised{
                Hyperparameters: optionalnullable.From(&components.SupervisedHyperparameters{
                    NEpochs: optionalnullable.From(mka1.Pointer(components.CreateSupervisedHyperparametersNEpochsInteger(
                        3,
                    ))),
                }),
            }),
        }),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.FineTuningJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `request`                                                                                      | [components.CreateFineTuningJobRequest](../../models/components/createfinetuningjobrequest.md) | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.CreateFineTuningJobResponse](../../models/operations/createfinetuningjobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~List~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** List your organization's fine-tuning jobs.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="listFineTuningJobs" method="get" path="/api/v1/llm/fine_tuning/jobs" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.FineTuning.List(ctx, optionalnullable.From[string](nil), mka1.Pointer[int64](20))
    if err != nil {
        log.Fatal(err)
    }
    if res.ListFineTuningJobsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `after`                                                  | optionalnullable.OptionalNullable[`string`]              | :heavy_minus_sign:                                       | N/A                                                      |
| `limit`                                                  | `*int64`                                                 | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListFineTuningJobsResponse](../../models/operations/listfinetuningjobsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~Retrieve~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Get info about a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="retrieveFineTuningJob" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}" -->
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

    res, err := s.Llm.FineTuning.Retrieve(ctx, "ftjob_aa87e2b1112a455b8deabed784372198")
    if err != nil {
        log.Fatal(err)
    }
    if res.FineTuningJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `fineTuningJobID`                                        | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | ftjob_aa87e2b1112a455b8deabed784372198                   |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.RetrieveFineTuningJobResponse](../../models/operations/retrievefinetuningjobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~Cancel~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Immediately cancel a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="cancelFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/cancel" -->
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

    res, err := s.Llm.FineTuning.Cancel(ctx, "ftjob_aa87e2b1112a455b8deabed784372198")
    if err != nil {
        log.Fatal(err)
    }
    if res.FineTuningJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `fineTuningJobID`                                        | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | ftjob_aa87e2b1112a455b8deabed784372198                   |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.CancelFineTuningJobResponse](../../models/operations/cancelfinetuningjobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~Pause~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Pause a running fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="pauseFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/pause" -->
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

    res, err := s.Llm.FineTuning.Pause(ctx, "ftjob_aa87e2b1112a455b8deabed784372198")
    if err != nil {
        log.Fatal(err)
    }
    if res.FineTuningJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `fineTuningJobID`                                        | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | ftjob_aa87e2b1112a455b8deabed784372198                   |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.PauseFineTuningJobResponse](../../models/operations/pausefinetuningjobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~Resume~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Resume a paused fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="resumeFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/resume" -->
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

    res, err := s.Llm.FineTuning.Resume(ctx, "ftjob_aa87e2b1112a455b8deabed784372198")
    if err != nil {
        log.Fatal(err)
    }
    if res.FineTuningJob != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `fineTuningJobID`                                        | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | ftjob_aa87e2b1112a455b8deabed784372198                   |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.ResumeFineTuningJobResponse](../../models/operations/resumefinetuningjobresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~ListEvents~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Get status updates for a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="listFineTuningEvents" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/events" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.FineTuning.ListEvents(ctx, "ftjob_aa87e2b1112a455b8deabed784372198", optionalnullable.From[string](nil), mka1.Pointer[int64](20))
    if err != nil {
        log.Fatal(err)
    }
    if res.ListEventsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `fineTuningJobID`                                        | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | ftjob_aa87e2b1112a455b8deabed784372198                   |
| `after`                                                  | optionalnullable.OptionalNullable[`string`]              | :heavy_minus_sign:                                       | N/A                                                      |                                                          |
| `limit`                                                  | `*int64`                                                 | :heavy_minus_sign:                                       | N/A                                                      |                                                          |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.ListFineTuningEventsResponse](../../models/operations/listfinetuningeventsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~ListCheckpoints~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** List checkpoints for a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="listFineTuningCheckpoints" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/checkpoints" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.FineTuning.ListCheckpoints(ctx, "ftjob_aa87e2b1112a455b8deabed784372198", optionalnullable.From[string](nil), mka1.Pointer[int64](10))
    if err != nil {
        log.Fatal(err)
    }
    if res.ListCheckpointsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `fineTuningJobID`                                        | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | ftjob_aa87e2b1112a455b8deabed784372198                   |
| `after`                                                  | optionalnullable.OptionalNullable[`string`]              | :heavy_minus_sign:                                       | N/A                                                      |                                                          |
| `limit`                                                  | `*int64`                                                 | :heavy_minus_sign:                                       | N/A                                                      |                                                          |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.ListFineTuningCheckpointsResponse](../../models/operations/listfinetuningcheckpointsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |