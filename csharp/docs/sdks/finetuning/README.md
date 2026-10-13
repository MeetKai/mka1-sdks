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

<!-- UsageSnippet language="csharp" operationID="createFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

CreateFineTuningJobRequest req = new CreateFineTuningJobRequest() {
    Model = "meetkai:functionary-medium",
    TrainingFile = "file_abc123",
    Suffix = "my-model",
    Method = new Method() {
        Type = MethodType.Supervised,
        Supervised = new Supervised() {
            Hyperparameters = new SupervisedHyperparameters() {
                NEpochs = SupervisedHyperparametersNEpochs.CreateInteger(
                    3
                ),
            },
        },
    },
};

var res = await sdk.Llm.FineTuning.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `request`                                                                          | [CreateFineTuningJobRequest](../../Types/Components/CreateFineTuningJobRequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |

### Response

**[CreateFineTuningJobResponse](../../Types/Requests/CreateFineTuningJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~List~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** List your organization's fine-tuning jobs.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFineTuningJobs" method="get" path="/api/v1/llm/fine_tuning/jobs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.FineTuning.ListAsync(limit: 20);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `After`            | *string*           | :heavy_minus_sign: | N/A                |
| `Limit`            | *long*             | :heavy_minus_sign: | N/A                |

### Response

**[Types.Requests.ListFineTuningJobsResponse](../../Types/Requests/ListFineTuningJobsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~Retrieve~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Get info about a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="retrieveFineTuningJob" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.FineTuning.RetrieveAsync(fineTuningJobId: "ftjob_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                              | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `FineTuningJobId`                      | *string*                               | :heavy_check_mark:                     | N/A                                    | ftjob_aa87e2b1112a455b8deabed784372198 |

### Response

**[RetrieveFineTuningJobResponse](../../Types/Requests/RetrieveFineTuningJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~Cancel~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Immediately cancel a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/cancel" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.FineTuning.CancelAsync(fineTuningJobId: "ftjob_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                              | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `FineTuningJobId`                      | *string*                               | :heavy_check_mark:                     | N/A                                    | ftjob_aa87e2b1112a455b8deabed784372198 |

### Response

**[CancelFineTuningJobResponse](../../Types/Requests/CancelFineTuningJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~Pause~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Pause a running fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="pauseFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/pause" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.FineTuning.PauseAsync(fineTuningJobId: "ftjob_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                              | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `FineTuningJobId`                      | *string*                               | :heavy_check_mark:                     | N/A                                    | ftjob_aa87e2b1112a455b8deabed784372198 |

### Response

**[PauseFineTuningJobResponse](../../Types/Requests/PauseFineTuningJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~Resume~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Resume a paused fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="resumeFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/resume" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.FineTuning.ResumeAsync(fineTuningJobId: "ftjob_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                              | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `FineTuningJobId`                      | *string*                               | :heavy_check_mark:                     | N/A                                    | ftjob_aa87e2b1112a455b8deabed784372198 |

### Response

**[ResumeFineTuningJobResponse](../../Types/Requests/ResumeFineTuningJobResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~ListEvents~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Get status updates for a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFineTuningEvents" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/events" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.FineTuning.ListEventsAsync(
    fineTuningJobId: "ftjob_aa87e2b1112a455b8deabed784372198",
    limit: 20
);

// handle response
```

### Parameters

| Parameter                              | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `FineTuningJobId`                      | *string*                               | :heavy_check_mark:                     | N/A                                    | ftjob_aa87e2b1112a455b8deabed784372198 |
| `After`                                | *string*                               | :heavy_minus_sign:                     | N/A                                    |                                        |
| `Limit`                                | *long*                                 | :heavy_minus_sign:                     | N/A                                    |                                        |

### Response

**[ListFineTuningEventsResponse](../../Types/Requests/ListFineTuningEventsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~ListCheckpoints~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** List checkpoints for a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFineTuningCheckpoints" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/checkpoints" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.FineTuning.ListCheckpointsAsync(
    fineTuningJobId: "ftjob_aa87e2b1112a455b8deabed784372198",
    limit: 10
);

// handle response
```

### Parameters

| Parameter                              | Type                                   | Required                               | Description                            | Example                                |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `FineTuningJobId`                      | *string*                               | :heavy_check_mark:                     | N/A                                    | ftjob_aa87e2b1112a455b8deabed784372198 |
| `After`                                | *string*                               | :heavy_minus_sign:                     | N/A                                    |                                        |
| `Limit`                                | *long*                                 | :heavy_minus_sign:                     | N/A                                    |                                        |

### Response

**[ListFineTuningCheckpointsResponse](../../Types/Requests/ListFineTuningCheckpointsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |