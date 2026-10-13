# ~~Llm.FineTuning~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~create~~](#create) - [Deprecated] Create a fine-tuning job :warning: **Deprecated**
* [~~list~~](#list) - [Deprecated] List fine-tuning jobs :warning: **Deprecated**
* [~~retrieve~~](#retrieve) - [Deprecated] Retrieve a fine-tuning job :warning: **Deprecated**
* [~~cancel~~](#cancel) - [Deprecated] Cancel a fine-tuning job :warning: **Deprecated**
* [~~pause~~](#pause) - [Deprecated] Pause a fine-tuning job :warning: **Deprecated**
* [~~resume~~](#resume) - [Deprecated] Resume a fine-tuning job :warning: **Deprecated**
* [~~list_events~~](#list_events) - [Deprecated] List fine-tuning events :warning: **Deprecated**
* [~~list_checkpoints~~](#list_checkpoints) - [Deprecated] List fine-tuning checkpoints :warning: **Deprecated**

## ~~create~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Creates a fine-tuning job which begins the process of training a new model from a given dataset.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="createFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.create(model="meetkai:functionary-medium", training_file="file_abc123", suffix="my-model", method={
        "type": "supervised",
        "supervised": {
            "hyperparameters": {
                "n_epochs": 3,
            },
        },
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                       | Type                                                                                                                            | Required                                                                                                                        | Description                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| `model`                                                                                                                         | *str*                                                                                                                           | :heavy_check_mark:                                                                                                              | The base model to fine-tune                                                                                                     |
| `training_file`                                                                                                                 | *str*                                                                                                                           | :heavy_check_mark:                                                                                                              | File ID of the training data JSONL file                                                                                         |
| `validation_file`                                                                                                               | *OptionalNullable[str]*                                                                                                         | :heavy_minus_sign:                                                                                                              | File ID of the validation data JSONL file                                                                                       |
| `suffix`                                                                                                                        | *OptionalNullable[str]*                                                                                                         | :heavy_minus_sign:                                                                                                              | Suffix appended to the fine-tuned model name                                                                                    |
| `seed`                                                                                                                          | *OptionalNullable[int]*                                                                                                         | :heavy_minus_sign:                                                                                                              | Seed for reproducibility                                                                                                        |
| `hyperparameters`                                                                                                               | [OptionalNullable[models.CreateFineTuningJobRequestHyperparameters]](../../models/createfinetuningjobrequesthyperparameters.md) | :heavy_minus_sign:                                                                                                              | Deprecated: use method instead                                                                                                  |
| `method`                                                                                                                        | [OptionalNullable[models.Method]](../../models/method.md)                                                                       | :heavy_minus_sign:                                                                                                              | Fine-tuning method configuration                                                                                                |
| `integrations`                                                                                                                  | List[[models.IntegrationObject](../../models/integrationobject.md)]                                                             | :heavy_minus_sign:                                                                                                              | External integrations                                                                                                           |
| `metadata`                                                                                                                      | Dict[str, *str*]                                                                                                                | :heavy_minus_sign:                                                                                                              | Up to 16 key-value pairs                                                                                                        |
| `retries`                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                | :heavy_minus_sign:                                                                                                              | Configuration to override the default retry behavior of the client.                                                             |

### Response

**[models.FineTuningJob](../../models/finetuningjob.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## ~~list~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** List your organization's fine-tuning jobs.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="listFineTuningJobs" method="get" path="/api/v1/llm/fine_tuning/jobs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.list(limit=20)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `after`                                                             | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListFineTuningJobsResponse](../../models/listfinetuningjobsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## ~~retrieve~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Get info about a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="retrieveFineTuningJob" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.retrieve(fine_tuning_job_id="ftjob_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `fine_tuning_job_id`                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | ftjob_aa87e2b1112a455b8deabed784372198                              |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.FineTuningJob](../../models/finetuningjob.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## ~~cancel~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Immediately cancel a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="cancelFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/cancel" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.cancel(fine_tuning_job_id="ftjob_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `fine_tuning_job_id`                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | ftjob_aa87e2b1112a455b8deabed784372198                              |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.FineTuningJob](../../models/finetuningjob.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## ~~pause~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Pause a running fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="pauseFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/pause" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.pause(fine_tuning_job_id="ftjob_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `fine_tuning_job_id`                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | ftjob_aa87e2b1112a455b8deabed784372198                              |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.FineTuningJob](../../models/finetuningjob.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## ~~resume~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Resume a paused fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="resumeFineTuningJob" method="post" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/resume" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.resume(fine_tuning_job_id="ftjob_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `fine_tuning_job_id`                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | ftjob_aa87e2b1112a455b8deabed784372198                              |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.FineTuningJob](../../models/finetuningjob.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## ~~list_events~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** Get status updates for a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="listFineTuningEvents" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/events" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.list_events(fine_tuning_job_id="ftjob_aa87e2b1112a455b8deabed784372198", limit=20)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `fine_tuning_job_id`                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | ftjob_aa87e2b1112a455b8deabed784372198                              |
| `after`                                                             | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ListEventsResponse](../../models/listeventsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## ~~list_checkpoints~~

**Deprecated: Use Compute jobs (`/api/v1/compute/jobs`) instead.** List checkpoints for a fine-tuning job.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="python" operationID="listFineTuningCheckpoints" method="get" path="/api/v1/llm/fine_tuning/jobs/{fine_tuning_job_id}/checkpoints" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.fine_tuning.list_checkpoints(fine_tuning_job_id="ftjob_aa87e2b1112a455b8deabed784372198", limit=10)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `fine_tuning_job_id`                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | ftjob_aa87e2b1112a455b8deabed784372198                              |
| `after`                                                             | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ListCheckpointsResponse](../../models/listcheckpointsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |