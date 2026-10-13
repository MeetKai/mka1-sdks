# Llm.Evals

## Overview

### Available Operations

* [create_suite](#create_suite) - Create an eval suite
* [list_suites](#list_suites) - List eval suites
* [get_suite](#get_suite) - Get an eval suite
* [delete_suite](#delete_suite) - Delete an eval suite
* [create_suite_version](#create_suite_version) - Create an eval suite version
* [list_suite_versions](#list_suite_versions) - List eval suite versions
* [get_suite_version](#get_suite_version) - Get an eval suite version
* [list_suite_leaderboard_runs](#list_suite_leaderboard_runs) - List leaderboard runs for an eval suite
* [get_suite_leaderboard](#get_suite_leaderboard) - Get the coding-agent leaderboard for an eval suite
* [measure_suite_tokens](#measure_suite_tokens) - Count tokens from stored text for a suite's unmeasured samples
* [create_run](#create_run) - Create an eval run
* [list_runs](#list_runs) - List eval runs
* [get_run](#get_run) - Get an eval run
* [delete_run](#delete_run) - Delete an eval run
* [cancel_run](#cancel_run) - Cancel an eval run
* [rerun_failed_samples](#rerun_failed_samples) - Rerun failed eval samples
* [retry_failed_run](#retry_failed_run) - Retry an eval run
* [get_run_overview](#get_run_overview) - Get an eval run overview
* [list_samples](#list_samples) - List eval samples
* [get_sample_audio](#get_sample_audio) - Get eval sample audio
* [get_sample_trajectory](#get_sample_trajectory) - Get an eval sample trajectory
* [upload_sample_trajectory](#upload_sample_trajectory) - Upload an eval sample trajectory
* [get_artifacts](#get_artifacts) - Get eval run artifacts
* [import_agent_run](#import_agent_run) - Import a finished coding-agent run
* [append_agent_trials](#append_agent_trials) - Append trials to an open coding-agent run
* [import_historical_results](#import_historical_results) - Import historical eval results from Hugging Face
* [create_schedule](#create_schedule) - Create an eval schedule
* [list_schedules](#list_schedules) - List eval schedules
* [get_schedule](#get_schedule) - Get an eval schedule
* [update_schedule](#update_schedule) - Update an eval schedule
* [delete_schedule](#delete_schedule) - Delete an eval schedule
* [trigger_schedule](#trigger_schedule) - Trigger an eval schedule now
* [list_schedule_runs](#list_schedule_runs) - List runs created by an eval schedule

## create_suite

Creates a team-scoped declarative eval suite. Dataset and Python grader files must be uploaded separately with purpose 'evals'.

### Example Usage

<!-- UsageSnippet language="python" operationID="createEvalSuite" method="post" path="/api/v1/llm/evals/suites" -->
```python
from meetkai_mka1 import SDK, models


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.create_suite(name="Multilingual QA smoke suite", manifest={
        "tasks": [
            models.EvalTask(
                id="spanish_qa",
                type="custom",
                dataset=models.EvalDataset(
                    source="huggingface",
                    path="IIC/AQuAS",
                    split="test",
                ),
                prompt_template="Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:",
                target_template="{{answer}}",
                grader=models.EvalPythonGrader(
                    contract="model_backed",
                    model_access="mka1",
                    file_id="file_grader123",
                ),
                preprocess=models.EvalPythonPreprocessor(
                    source="def transform(row):\n    return row\n",
                ),
                num_fewshot=1,
            ),
        ],
    }, description="Declarative eval tasks backed by uploaded files or Hugging Face datasets and Python graders.", metadata={
        "owner": "eval-team",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `manifest`                                                          | [models.EvalSuiteManifest](../../models/evalsuitemanifest.md)       | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `description`                                                       | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `metadata`                                                          | Dict[str, *str*]                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EvalSuiteObject](../../models/evalsuiteobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_suites

Returns eval suites visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEvalSuites" method="get" path="/api/v1/llm/evals/suites" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.list_suites(limit=20)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `after`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EvalSuiteList](../../models/evalsuitelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_suite

Retrieves an eval suite by ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalSuite" method="get" path="/api/v1/llm/evals/suites/{suite_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_suite(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suite_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalSuiteObject](../../models/evalsuiteobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_suite

Soft-deletes an eval suite and all of its eval runs so they no longer appear in user-facing reads.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteEvalSuite" method="delete" path="/api/v1/llm/evals/suites/{suite_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.delete_suite(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suite_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalSuiteDeletedObject](../../models/evalsuitedeletedobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_suite_version

Creates an immutable suite version. Use this endpoint for edits to an existing eval suite.

### Example Usage

<!-- UsageSnippet language="python" operationID="createEvalSuiteVersion" method="post" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
```python
from meetkai_mka1 import SDK, models


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.create_suite_version(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", manifest={
        "tasks": [
            models.EvalTask(
                id="spanish_qa",
                type="custom",
                dataset=models.EvalDataset(
                    source="huggingface",
                    path="IIC/AQuAS",
                    split="test",
                ),
                prompt_template="Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:",
                target_template="{{answer}}",
                grader=models.EvalPythonGrader(
                    contract="model_backed",
                    model_access="mka1",
                    file_id="file_grader123",
                ),
                preprocess=models.EvalPythonPreprocessor(
                    source="def transform(row):\n    return row\n",
                ),
                num_fewshot=1,
            ),
        ],
    }, make_active=True)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suite_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `manifest`                                                          | [models.EvalSuiteManifest](../../models/evalsuitemanifest.md)       | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `metadata`                                                          | Dict[str, *str*]                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `make_active`                                                       | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.CreateEvalSuiteVersionResponse](../../models/createevalsuiteversionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_suite_versions

Returns immutable versions for an eval suite, including each version manifest.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEvalSuiteVersions" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.list_suite_versions(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", limit=20)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suite_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `after`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ListEvalSuiteVersionsResponse](../../models/listevalsuiteversionsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_suite_version

Retrieves an immutable eval suite version and its manifest.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalSuiteVersion" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions/{version}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_suite_version(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", version=1)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suite_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `version`                                                           | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetEvalSuiteVersionResponse](../../models/getevalsuiteversionresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_suite_leaderboard_runs

Returns each ranking group's most recent completed runs for a suite in one request, with the group assignments in `groups`. A group is (model, targeted task) for task_ids-restricted runs and (model) for unrestricted runs (task_id null). Build boards from `groups`, not from run.models/run.task_ids — a returned run may name models or tasks whose groups it did not rank in. `truncated: true` means a server ceiling trimmed the aggregate; whole runs are kept in (best rank, first model, first task, id) order, so every group's newest runs survive before any group's fallbacks and no group is dropped for being old. Resume a truncated board by passing `next_cursor` back as `cursor` and unioning the responses. See the evals docs for grouping rationale and cost characteristics.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEvalSuiteLeaderboardRuns" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard-runs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.list_suite_leaderboard_runs(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", suite_version=1, per_group=5, model="meetkai:functionary-urdu-mini-pak")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suite_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `suite_version`                                                     | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 1                                                                   |
| `per_group`                                                         | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 5                                                                   |
| `model`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | meetkai:functionary-urdu-mini-pak                                   |
| `cursor`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ListEvalSuiteLeaderboardRunsResponse](../../models/listevalsuiteleaderboardrunsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_suite_leaderboard

Ranks the suite's completed coding-agent runs, one row per (agent, model, effort). Only runs that recorded an `agent_name` participate — a QA or transcription run of the same suite has no agent to attribute a score to and is not a board row. `accuracy` is the mean of `metric` (default `reward`) over the row's scored trials, and `accuracy_ci` is the 95% Wald interval around it; both are derived per request rather than stored, so rerunning a failed trial moves them instead of leaving a stale copy behind. `agent_version` is reported but is not part of the row identity, so an agent upgrade does not split a row in two. Rows are ordered by accuracy descending, nulls last. Pass `suite_version` when the suite has more than one, otherwise the board mixes task sets.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalSuiteLeaderboard" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_suite_leaderboard(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", suite_version=1, metric="reward", limit=100)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suite_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `suite_version`                                                     | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 1                                                                   |
| `metric`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | reward                                                              |
| `agent`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `model`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | 100                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalSuiteLeaderboard](../../models/evalsuiteleaderboard.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## measure_suite_tokens

Backfill for rows written before the gateway recorded usage. For samples of the suite's completed runs that have answer or reasoning text but no token figure, counts prompt, reasoning and answer tokens from the stored text (tiktoken o200k_base, one ruler for every model), marks them `tokens_estimated`, and refreshes each run's per-task `tokens` and run totals so the leaderboard's efficiency figures appear. Processes `limit` runs per call, oldest run id first; call again until `remaining_runs` is 0. Samples the provider or the import already measured are left alone, and a sample with no text stays unmeasured. New rows get the same figures at generation or import time, so this is a no-op on a suite with nothing to measure.

### Example Usage

<!-- UsageSnippet language="python" operationID="measureEvalSuiteTokens" method="post" path="/api/v1/llm/evals/suites/{suite_id}/tokens/measure" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.measure_suite_tokens(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", limit=5)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    | Example                                                                        |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `suite_id`                                                                     | *str*                                                                          | :heavy_check_mark:                                                             | N/A                                                                            | eval_suite_aa87e2b1112a455b8deabed784372198                                    |
| `x_on_behalf_of`                                                               | *Optional[str]*                                                                | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |                                                                                |
| `limit`                                                                        | *Optional[int]*                                                                | :heavy_minus_sign:                                                             | How many runs to measure in this call. Call again until `remaining_runs` is 0. |                                                                                |
| `retries`                                                                      | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)               | :heavy_minus_sign:                                                             | Configuration to override the default retry behavior of the client.            |                                                                                |

### Response

**[models.EvalSuiteTokenMeasurement](../../models/evalsuitetokenmeasurement.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_run

Starts a durable eval run over the selected suite version, tasks, and models.

### Example Usage

<!-- UsageSnippet language="python" operationID="createEvalRun" method="post" path="/api/v1/llm/evals/runs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.create_run(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", models=[
        "auto",
    ], judge_model="auto", embedding_model="auto", generation={
        "temperature": 0.0,
        "max_gen_toks": 512,
        "until": [
            "<|endoftext|>",
        ],
        "do_sample": False,
        "chat_template_kwargs": {
            "enable_thinking": False,
        },
        "timeout_seconds": 120,
        "max_retries": 2,
        "max_empty_retries": 1,
    }, generation_concurrency=4, grader_concurrency=2, max_workflow_sample_activities=5000, metadata={
        "purpose": "mvp",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `suite_id`                                                                                           | *str*                                                                                                | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `models`                                                                                             | List[*str*]                                                                                          | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `x_on_behalf_of`                                                                                     | *Optional[str]*                                                                                      | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `suite_version`                                                                                      | *Optional[int]*                                                                                      | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `task_ids`                                                                                           | List[*str*]                                                                                          | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `judge_model`                                                                                        | *Optional[str]*                                                                                      | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `embedding_model`                                                                                    | *Optional[str]*                                                                                      | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `generation`                                                                                         | [Optional[models.EvalGenerationRequestConfig]](../../models/evalgenerationrequestconfig.md)          | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `generation_concurrency`                                                                             | *Optional[int]*                                                                                      | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `concurrency`                                                                                        | *Optional[int]*                                                                                      | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `grader_concurrency`                                                                                 | *Optional[int]*                                                                                      | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `max_samples_per_task`                                                                               | *Optional[int]*                                                                                      | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `max_workflow_sample_activities`                                                                     | *Optional[int]*                                                                                      | :heavy_minus_sign:                                                                                   | Maximum sample-stage activity reservations per Temporal workflow execution before continuing as new. |
| `metadata`                                                                                           | Dict[str, *str*]                                                                                     | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `retries`                                                                                            | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                     | :heavy_minus_sign:                                                                                   | Configuration to override the default retry behavior of the client.                                  |

### Response

**[models.CreateEvalRunResponse](../../models/createevalrunresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_runs

Returns eval runs visible to the authenticated team context. suite_version is a per-suite ordinal and must be paired with suite_id; supplying it alone returns 400.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEvalRuns" method="get" path="/api/v1/llm/evals/runs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.list_runs(limit=20, suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", suite_version=1)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `after`                                                                   | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       |                                                                           |
| `limit`                                                                   | *Optional[int]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       |                                                                           |
| `suite_id`                                                                | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       | eval_suite_aa87e2b1112a455b8deabed784372198                               |
| `suite_version`                                                           | *Optional[int]*                                                           | :heavy_minus_sign:                                                        | N/A                                                                       | 1                                                                         |
| `status`                                                                  | [Optional[models.ListEvalRunsStatus]](../../models/listevalrunsstatus.md) | :heavy_minus_sign:                                                        | N/A                                                                       |                                                                           |
| `x_on_behalf_of`                                                          | *Optional[str]*                                                           | :heavy_minus_sign:                                                        | Optional external end-user identifier forwarded by the API gateway.       |                                                                           |
| `retries`                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)          | :heavy_minus_sign:                                                        | Configuration to override the default retry behavior of the client.       |                                                                           |

### Response

**[models.ListEvalRunsResponse](../../models/listevalrunsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_run

Retrieves an eval run by ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalRun" method="get" path="/api/v1/llm/evals/runs/{run_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_run(run_id="eval_run_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetEvalRunResponse](../../models/getevalrunresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_run

Soft-deletes an eval run so it no longer appears in run lists, details, or score leaderboards.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteEvalRun" method="delete" path="/api/v1/llm/evals/runs/{run_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.delete_run(run_id="eval_run_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalRunDeletedObject](../../models/evalrundeletedobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## cancel_run

Requests cancellation for a queued or running eval run.

### Example Usage

<!-- UsageSnippet language="python" operationID="cancelEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/cancel" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.cancel_run(run_id="eval_run_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.CancelEvalRunResponse](../../models/cancelevalrunresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## rerun_failed_samples

Queues a completed eval run to retry only samples with sample status 'failed'. Retried samples keep the same run ID and sample IDs, replacing errored sample results in place.

### Example Usage

<!-- UsageSnippet language="python" operationID="rerunFailedEvalSamples" method="post" path="/api/v1/llm/evals/runs/{run_id}/rerun-failed" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.rerun_failed_samples(run_id="eval_run_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.RerunFailedEvalSamplesResponse](../../models/rerunfailedevalsamplesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## retry_failed_run

Queues a failed or cancelled eval run to retry in place. Completed samples keep their results, generated-but-unscored cancelled samples resume at scoring, unfinished samples are requeued, and runs with no persisted samples are prepared from scratch with the same run ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="retryFailedEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/retry" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.retry_failed_run(run_id="eval_run_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.RetryFailedEvalRunResponse](../../models/retryfailedevalrunresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_run_overview

Aggregate header for one run's trials view: trial counts, average reward, cost, and the input/output/cached token split. Its own route rather than fields on the run object because it scans the run's samples — folding it into `GET /evals/runs/{run_id}` would charge that scan to every run list and to the status polling that runs for the whole length of an eval. `trials.errored` overlaps `trials.failed` instead of partitioning it: a coding-agent trial can carry an agent timeout in `error` and still be completed and scored. `trials.retried` counts trials rerun through rerun-failed, read from the pre-rerun snapshot, since a rerun overwrites the sample in place.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalRunOverview" method="get" path="/api/v1/llm/evals/runs/{run_id}/overview" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_run_overview(run_id="eval_run_aa87e2b1112a455b8deabed784372198", metric="reward")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `metric`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 | reward                                                              |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalRunOverview](../../models/evalrunoverview.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_samples

Returns prompt, target, model output, extraction, score, and judge details for an eval run.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEvalSamples" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.list_samples(run_id="eval_run_aa87e2b1112a455b8deabed784372198", limit=100, include_dataset_row=True, include_reasoning=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     | Example                                                                         |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `run_id`                                                                        | *str*                                                                           | :heavy_check_mark:                                                              | N/A                                                                             | eval_run_aa87e2b1112a455b8deabed784372198                                       |
| `after`                                                                         | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `limit`                                                                         | *Optional[int]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `task_id`                                                                       | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `model`                                                                         | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `status`                                                                        | [Optional[models.ListEvalSamplesStatus]](../../models/listevalsamplesstatus.md) | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `score_metric`                                                                  | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `score_min`                                                                     | *Optional[float]*                                                               | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `score_max`                                                                     | *Optional[float]*                                                               | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `include_dataset_row`                                                           | *Optional[bool]*                                                                | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `include_reasoning`                                                             | *Optional[bool]*                                                                | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `sample_index`                                                                  | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `x_on_behalf_of`                                                                | *Optional[str]*                                                                 | :heavy_minus_sign:                                                              | Optional external end-user identifier forwarded by the API gateway.             |                                                                                 |
| `retries`                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                | :heavy_minus_sign:                                                              | Configuration to override the default retry behavior of the client.             |                                                                                 |

### Response

**[models.EvalSampleList](../../models/evalsamplelist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_sample_audio

Returns `{ object, audio, sample_index, task_id, model }` for a single transcription sample — the clip reference (a base64 `data:` URI or a URL) read from the un-redacted `dataset_row` (list responses redact inline `data:` blobs), plus the resolved task/model. Prefers the task's configured `audio_column`, falling back to a heuristic scan. The clip differs across tasks, so pass `task_id` when a run has more than one transcription task; if the index spans multiple tasks and `task_id` is omitted, returns 400 rather than guessing. `model` is optional (the clip is identical across models) and only extends the index prefix. Returns 404 when the sample or its audio is absent, 413 when the inline clip is too large. Returns 503 when object storage is briefly unreachable, as distinct from 404 for a clip that is genuinely gone.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalSampleAudio" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/audio" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_sample_audio(run_id="eval_run_aa87e2b1112a455b8deabed784372198", sample_index=0)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `sample_index`                                                      | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 0                                                                   |
| `model`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `task_id`                                                           | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalSampleAudioObject](../../models/evalsampleaudioobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_sample_trajectory

Returns one coding-agent trial's session — the steps the agent took, verbatim in the harness's interchange format (see `schema_version`, e.g. `ATIF-v1.7`). Deliberately not part of the samples list: a trajectory averages ~92 KB and that list pages up to 500 rows. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one; an index that matches several trials returns 400 rather than guessing, and never falls back to another trial's session. Returns 404 when the sample does not exist or recorded no trajectory.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalSampleTrajectory" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_sample_trajectory(run_id="eval_run_aa87e2b1112a455b8deabed784372198", sample_index=0)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `sample_index`                                                      | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 0                                                                   |
| `task_id`                                                           | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `model`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetEvalSampleTrajectoryResponse](../../models/getevalsampletrajectoryresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## upload_sample_trajectory

Stores one coding-agent trial's session, in whatever interchange format the harness produced (record it in `schema_version`, e.g. `ATIF-v1.7`). `steps` is stored verbatim and never validated, so a harness format change needs no gateway release. Separate from the run import because a trajectory averages ~92 KB and a whole run's worth would not fit in one request. Upserts, so re-sending after a timeout replaces the trajectory rather than failing. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one — an ambiguous index returns 400 rather than writing to the wrong trial. Rejects a payload whose `steps` and `logs` together exceed 16 MiB with 413.

### Example Usage

<!-- UsageSnippet language="python" operationID="uploadEvalSampleTrajectory" method="put" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.upload_sample_trajectory(run_id="eval_run_aa87e2b1112a455b8deabed784372198", sample_index=0, steps=[
        {
            "step_id": 1,
            "source": "agent",
            "reasoning_content": "The test fails because the fixture directory is not writable.",
            "tool_calls": [
                {
                    "function_name": "bash",
                    "arguments": {
                        "command": "ls -la /workdir",
                    },
                },
            ],
        },
    ], schema_version="ATIF-v1.7")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                           | Type                                                                                                                                                                                                                                                                                                                | Required                                                                                                                                                                                                                                                                                                            | Description                                                                                                                                                                                                                                                                                                         | Example                                                                                                                                                                                                                                                                                                             |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `run_id`                                                                                                                                                                                                                                                                                                            | *str*                                                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                  | N/A                                                                                                                                                                                                                                                                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                                                                                                                                                                                                                                                                           |
| `sample_index`                                                                                                                                                                                                                                                                                                      | *int*                                                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                  | N/A                                                                                                                                                                                                                                                                                                                 | 0                                                                                                                                                                                                                                                                                                                   |
| `steps`                                                                                                                                                                                                                                                                                                             | List[*Any*]                                                                                                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                                                                                                  | Steps exactly as the harness wrote them. Stored verbatim and never validated, so a format change needs no gateway release.                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                                                     |
| `task_id`                                                                                                                                                                                                                                                                                                           | *Optional[str]*                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                  | N/A                                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                     |
| `model`                                                                                                                                                                                                                                                                                                             | *Optional[str]*                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                  | N/A                                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                     |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                                                    | *Optional[str]*                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                  | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                     |
| `schema_version`                                                                                                                                                                                                                                                                                                    | *Optional[str]*                                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                  | Interchange format of `steps`. Stored per row so a harness upgrade leaves older trajectories readable.                                                                                                                                                                                                              |                                                                                                                                                                                                                                                                                                                     |
| `logs`                                                                                                                                                                                                                                                                                                              | Dict[str, *str*]                                                                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                  | Bounded tails of the trial's log files, keyed by their path in the trial dir — `trial.log` (the harness's own account of the trial), `verifier/test-stdout.txt` / `test-stderr.txt`, `exception.txt`. The harness tails each file before sending; the whole payload still counts against the trajectory size limit. |                                                                                                                                                                                                                                                                                                                     |
| `retries`                                                                                                                                                                                                                                                                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                  | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                     |

### Response

**[models.EvalSampleTrajectoryUploadedObject](../../models/evalsampletrajectoryuploadedobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_artifacts

Returns generated result and sample artifact file IDs for a completed eval run.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalArtifacts" method="get" path="/api/v1/llm/evals/runs/{run_id}/artifacts" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_artifacts(run_id="eval_run_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `run_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalArtifactsObject](../../models/evalartifactsobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## import_agent_run

Uploads one completed harness job — the run and its trials — directly, so results never round-trip through external storage the way the Hugging Face importer does. Every `task_id` must already exist in the target suite version's manifest; unknown ids are rejected rather than invented, because a typo would otherwise import as a task the suite does not have and read as a model that never covered the version. The run is recorded as `completed` and is not executed: this is a write, not a run request, so no workflow is started. Trials that cover every task of the version get `task_ids: null`, which is what lets the run rank as a complete sweep. Trajectories are NOT part of this payload — a full 91-task run measured 8.3 MB of them — so upload each one against `PUT /evals/runs/{run_id}/samples/{sample_index}/trajectory` afterwards. Pass `idempotency_key` and a retried upload returns the first run instead of doubling the trials behind a board row.

### Example Usage

<!-- UsageSnippet language="python" operationID="importAgentEvalRun" method="post" path="/api/v1/llm/evals/imports/agent-run" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.import_agent_run(suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", agent_name="omp", model="meetkai:functionary-urdu-mini-pak", suite_version=1, agent_version="17.3.8", agent_effort="medium", cost_usd=3.77, created_at=1704067200, metadata={
        "harness": "harbor",
        "benchmark": "terminal-bench-2.1",
    }, idempotency_key="harbor-job-2026-08-23-luna-medium", trials=[
        {
            "task_id": "fix-permissions",
            "sample_index": 0,
            "prompt": "The test suite fails because the fixture directory is not writable. Fix it.",
            "target": "all tests pass",
            "output_text": "9 passed in 2.25s",
            "scores": {
                "reward": 1.0,
                "resolved": 1.0,
            },
            "cost_usd": 0.0279,
            "input_tokens": 658456,
            "output_tokens": 6489,
            "cached_tokens": 658366,
        },
    ], finalize=True)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                               | Type                                                                                                                                                                                    | Required                                                                                                                                                                                | Description                                                                                                                                                                             |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `suite_id`                                                                                                                                                                              | *str*                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                      | Existing suite to import into. Its manifest defines the task set, so create the suite first.                                                                                            |
| `agent_name`                                                                                                                                                                            | *str*                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                      | The harness agent, e.g. `omp`.                                                                                                                                                          |
| `model`                                                                                                                                                                                 | *str*                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                      | N/A                                                                                                                                                                                     |
| `x_on_behalf_of`                                                                                                                                                                        | *Optional[str]*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                                                                                                     |
| `suite_version`                                                                                                                                                                         | *Optional[int]*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                      | Defaults to the suite's active version.                                                                                                                                                 |
| `agent_version`                                                                                                                                                                         | *OptionalNullable[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                      | N/A                                                                                                                                                                                     |
| `agent_effort`                                                                                                                                                                          | *OptionalNullable[str]*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                      | Reasoning-effort setting, e.g. `medium`. Part of the leaderboard's row identity, so the same agent and model at two efforts stay two rows.                                              |
| `cost_usd`                                                                                                                                                                              | *OptionalNullable[float]*                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                      | Total spend for the job. Falls back to the sum of the trials' own costs when omitted.                                                                                                   |
| `created_at`                                                                                                                                                                            | *Optional[int]*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                      | When the job ran, unix seconds. Defaults to now — set it when backfilling, since the board orders by this.                                                                              |
| `metadata`                                                                                                                                                                              | Dict[str, *str*]                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                      | N/A                                                                                                                                                                                     |
| `idempotency_key`                                                                                                                                                                       | *Optional[str]*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                      | Reusing a key returns the run created the first time instead of importing a second copy. Without one, a retried upload silently doubles the trials behind a board row.                  |
| `trials`                                                                                                                                                                                | List[[models.ImportAgentRunRequestTrial](../../models/importagentrunrequesttrial.md)]                                                                                                   | :heavy_minus_sign:                                                                                                                                                                      | May be empty when opening a run to stream trials into. A one-shot import sends them all here.                                                                                           |
| `expected_trials`                                                                                                                                                                       | *Optional[int]*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                      | How many trials the job will produce. Sets the run's total up front so the console shows real progress (12/89) while it streams, instead of 12/12 that grows.                           |
| `finalize`                                                                                                                                                                              | *Optional[bool]*                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                      | False opens the run `in_progress` for `POST /evals/runs/{run_id}/trials` to fill. Leaderboards only count completed runs, so a streaming run stays off the board until it is finalized. |
| `retries`                                                                                                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                      | Configuration to override the default retry behavior of the client.                                                                                                                     |

### Response

**[models.ImportAgentEvalRunResponse](../../models/importagentevalrunresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## append_agent_trials

Adds finished trials to a run opened with `finalize: false`, so a job started from MKA1 can be watched while it runs instead of appearing complete out of nowhere at the end. Each trial pins its own `sample_index` and upserts on (task, model, sample_index): a harness cannot tell a timeout from a lost response, so re-sending a batch is safe and replaces rather than duplicates. The whole batch and its aggregate recompute land in one transaction, serialized per run. Counts, metrics and cost are recomputed from the stored rows on every call, never accumulated from the request, so a replayed batch cannot double them. Send `finalize: true` (usually with an empty `trials`) to close the run — until then it stays `in_progress` and off the leaderboards, which only count completed runs. Appending to an already-completed or cancelled run is rejected: that record is finished, and rewriting it would silently move a number someone may have already read.

### Example Usage

<!-- UsageSnippet language="python" operationID="appendAgentEvalTrials" method="post" path="/api/v1/llm/evals/runs/{run_id}/trials" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.append_agent_trials(run_id="eval_run_aa87e2b1112a455b8deabed784372198", trials=[
        {
            "task_id": "fix-permissions",
            "sample_index": 0,
            "prompt": "The test suite fails because the fixture directory is not writable. Fix it.",
            "target": "all tests pass",
            "output_text": "9 passed in 2.25s",
            "scores": {
                "reward": 1.0,
                "resolved": 1.0,
            },
            "cost_usd": 0.0279,
            "input_tokens": 658456,
            "output_tokens": 6489,
            "cached_tokens": 658366,
        },
    ], finalize=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                              | Type                                                                                                                                                                   | Required                                                                                                                                                               | Description                                                                                                                                                            | Example                                                                                                                                                                |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `run_id`                                                                                                                                                               | *str*                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                     | N/A                                                                                                                                                                    | eval_run_aa87e2b1112a455b8deabed784372198                                                                                                                              |
| `x_on_behalf_of`                                                                                                                                                       | *Optional[str]*                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                                                                    |                                                                                                                                                                        |
| `trials`                                                                                                                                                               | List[[models.AppendAgentTrialsRequestTrial](../../models/appendagenttrialsrequesttrial.md)]                                                                            | :heavy_minus_sign:                                                                                                                                                     | Each trial pins its own `sample_index` (unique per task and model): re-sending a batch replaces the same rows instead of duplicating them, so a retried batch is safe. |                                                                                                                                                                        |
| `finalize`                                                                                                                                                             | *Optional[bool]*                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                     | Marks the run completed once these trials land — the last call of a streaming job sends this, usually with an empty `trials`.                                          |                                                                                                                                                                        |
| `retries`                                                                                                                                                              | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                       | :heavy_minus_sign:                                                                                                                                                     | Configuration to override the default retry behavior of the client.                                                                                                    |                                                                                                                                                                        |

### Response

**[models.AppendAgentEvalTrialsResponse](../../models/appendagentevaltrialsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## import_historical_results

Imports simplified historical samples.jsonl-style eval results from a Hugging Face dataset repository into a completed eval suite run shape. Aggregates are recomputed from samples and include canonical score metrics for leaderboards.

### Example Usage

<!-- UsageSnippet language="python" operationID="importHistoricalEvalResults" method="post" path="/api/v1/llm/evals/imports/huggingface-results" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.import_historical_results(x_hugging_face_token="hf_your_read_token", source={
        "path_prefix": "functionary/ur/",
    }, suite_name="MKA1 historical eval results", create_missing_tasks=True, dry_run=False, metadata={
        "owner": "eval-team",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                             | Type                                                                                                                                                                                  | Required                                                                                                                                                                              | Description                                                                                                                                                                           | Example                                                                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `x_hugging_face_token`                                                                                                                                                                | *str*                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                    | Caller-owned Hugging Face token with read access to the source dataset repository. Gateway does not use its server-side Hugging Face token for historical imports.                    | hf_your_read_token                                                                                                                                                                    |
| `x_on_behalf_of`                                                                                                                                                                      | *Optional[str]*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                                                                                                   |                                                                                                                                                                                       |
| `source`                                                                                                                                                                              | [Optional[models.ImportHistoricalEvalResultsRequestSource]](../../models/importhistoricalevalresultsrequestsource.md)                                                                 | :heavy_minus_sign:                                                                                                                                                                    | N/A                                                                                                                                                                                   |                                                                                                                                                                                       |
| `suite_id`                                                                                                                                                                            | *Optional[str]*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                    | Existing suite to import into. Missing tasks are appended as a new version by default.                                                                                                |                                                                                                                                                                                       |
| `suite_name`                                                                                                                                                                          | *Optional[str]*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                    | N/A                                                                                                                                                                                   |                                                                                                                                                                                       |
| `suite_description`                                                                                                                                                                   | *Optional[str]*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                    | N/A                                                                                                                                                                                   |                                                                                                                                                                                       |
| `create_missing_tasks`                                                                                                                                                                | *Optional[bool]*                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                    | N/A                                                                                                                                                                                   |                                                                                                                                                                                       |
| `dry_run`                                                                                                                                                                             | *Optional[bool]*                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                    | N/A                                                                                                                                                                                   |                                                                                                                                                                                       |
| `limit_files`                                                                                                                                                                         | *Optional[int]*                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                    | Maximum number of result files to import from Hugging Face, capped at 100. Repository listing imports default to 50; explicit source.files imports are not capped unless this is set. |                                                                                                                                                                                       |
| `metadata`                                                                                                                                                                            | Dict[str, *str*]                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                    | N/A                                                                                                                                                                                   |                                                                                                                                                                                       |
| `retries`                                                                                                                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                    | Configuration to override the default retry behavior of the client.                                                                                                                   |                                                                                                                                                                                       |

### Response

**[models.EvalHistoricalImportObject](../../models/evalhistoricalimportobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_schedule

Schedules an eval run to fire on a cron or interval cadence, with optional webhook notifications of run status.

### Example Usage

<!-- UsageSnippet language="python" operationID="createEvalSchedule" method="post" path="/api/v1/llm/evals/schedules" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.create_schedule(name="Nightly MMLU regression", suite_id="eval_suite_aa87e2b1112a455b8deabed784372198", run={
        "models": [
            "meetkai/model-a",
        ],
    }, cron="0 3 * * *", timezone="US/Pacific", overlap_policy="skip", enabled=True, webhook_url="https://example.com/hooks/evals", webhook_secret="whsec_example_signing_secret", metadata={
        "team": "eval-ops",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `name`                                                                                     | *str*                                                                                      | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `suite_id`                                                                                 | *str*                                                                                      | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `run`                                                                                      | [models.EvalScheduleRunRequestConfig](../../models/evalschedulerunrequestconfig.md)        | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `x_on_behalf_of`                                                                           | *Optional[str]*                                                                            | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `description`                                                                              | *Optional[str]*                                                                            | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `suite_version`                                                                            | *Optional[int]*                                                                            | :heavy_minus_sign:                                                                         | Pin a suite version. Omit to resolve the active version on each fire.                      |
| `cron`                                                                                     | *Optional[str]*                                                                            | :heavy_minus_sign:                                                                         | 5-field cron expression. Provide exactly one of cron or interval_seconds.                  |
| `interval_seconds`                                                                         | *Optional[int]*                                                                            | :heavy_minus_sign:                                                                         | Fixed interval between fires, in seconds. Provide exactly one of cron or interval_seconds. |
| `timezone`                                                                                 | *Optional[str]*                                                                            | :heavy_minus_sign:                                                                         | IANA timezone applied to cron expressions, for example US/Pacific.                         |
| `overlap_policy`                                                                           | [Optional[models.EvalScheduleOverlapPolicy]](../../models/evalscheduleoverlappolicy.md)    | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `enabled`                                                                                  | *Optional[bool]*                                                                           | :heavy_minus_sign:                                                                         | When false, the schedule is created paused.                                                |
| `webhook_url`                                                                              | *Optional[str]*                                                                            | :heavy_minus_sign:                                                                         | HTTPS endpoint notified of run status transitions.                                         |
| `webhook_secret`                                                                           | *Optional[str]*                                                                            | :heavy_minus_sign:                                                                         | Secret used to HMAC-SHA256 sign webhook payloads.                                          |
| `metadata`                                                                                 | Dict[str, *str*]                                                                           | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `retries`                                                                                  | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                           | :heavy_minus_sign:                                                                         | Configuration to override the default retry behavior of the client.                        |

### Response

**[models.CreateEvalScheduleResponse](../../models/createevalscheduleresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_schedules

Returns eval schedules visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEvalSchedules" method="get" path="/api/v1/llm/evals/schedules" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.list_schedules(limit=20)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `after`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `suite_id`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `enabled`                                                           | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListEvalSchedulesResponse](../../models/listevalschedulesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_schedule

Retrieves an eval schedule by ID, including the next scheduled fire time from Temporal when resolvable.

### Example Usage

<!-- UsageSnippet language="python" operationID="getEvalSchedule" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.get_schedule(schedule_id="eval_sched_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `schedule_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetEvalScheduleResponse](../../models/getevalscheduleresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_schedule

Updates an eval schedule's cadence, run config, webhook, overlap policy, or enabled state.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateEvalSchedule" method="patch" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.update_schedule(schedule_id="eval_sched_aa87e2b1112a455b8deabed784372198", enabled=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `schedule_id`                                                                                 | *str*                                                                                         | :heavy_check_mark:                                                                            | N/A                                                                                           | eval_sched_aa87e2b1112a455b8deabed784372198                                                   |
| `x_on_behalf_of`                                                                              | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |                                                                                               |
| `name`                                                                                        | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `description`                                                                                 | *OptionalNullable[str]*                                                                       | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `suite_version`                                                                               | *OptionalNullable[int]*                                                                       | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `cron`                                                                                        | *OptionalNullable[str]*                                                                       | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `interval_seconds`                                                                            | *OptionalNullable[int]*                                                                       | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `timezone`                                                                                    | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `overlap_policy`                                                                              | [Optional[models.EvalScheduleOverlapPolicy]](../../models/evalscheduleoverlappolicy.md)       | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `enabled`                                                                                     | *Optional[bool]*                                                                              | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `webhook_url`                                                                                 | *OptionalNullable[str]*                                                                       | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `webhook_secret`                                                                              | *OptionalNullable[str]*                                                                       | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `run`                                                                                         | [Optional[models.EvalScheduleRunRequestConfig]](../../models/evalschedulerunrequestconfig.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `metadata`                                                                                    | Dict[str, *str*]                                                                              | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `retries`                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                              | :heavy_minus_sign:                                                                            | Configuration to override the default retry behavior of the client.                           |                                                                                               |

### Response

**[models.UpdateEvalScheduleResponse](../../models/updateevalscheduleresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_schedule

Soft-deletes an eval schedule and removes its Temporal schedule. Historical runs are preserved.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteEvalSchedule" method="delete" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.delete_schedule(schedule_id="eval_sched_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `schedule_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.EvalScheduleDeletedObject](../../models/evalscheduledeletedobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## trigger_schedule

Fires the schedule immediately, in addition to its normal cadence.

### Example Usage

<!-- UsageSnippet language="python" operationID="triggerEvalSchedule" method="post" path="/api/v1/llm/evals/schedules/{schedule_id}/trigger" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.trigger_schedule(schedule_id="eval_sched_aa87e2b1112a455b8deabed784372198")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `schedule_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.TriggerEvalScheduleResponse](../../models/triggerevalscheduleresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_schedule_runs

Returns eval runs that were created by the given schedule. suite_version may be used without suite_id here, since the schedule already pins the suite; supplying a suite_id that is not the schedule's returns 400.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEvalScheduleRuns" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}/runs" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.evals.list_schedule_runs(schedule_id="eval_sched_aa87e2b1112a455b8deabed784372198", limit=20, suite_version=1)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `schedule_id`                                                                             | *str*                                                                                     | :heavy_check_mark:                                                                        | N/A                                                                                       | eval_sched_aa87e2b1112a455b8deabed784372198                                               |
| `after`                                                                                   | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |                                                                                           |
| `limit`                                                                                   | *Optional[int]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |                                                                                           |
| `suite_id`                                                                                | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       |                                                                                           |
| `suite_version`                                                                           | *Optional[int]*                                                                           | :heavy_minus_sign:                                                                        | N/A                                                                                       | 1                                                                                         |
| `status`                                                                                  | [Optional[models.ListEvalScheduleRunsStatus]](../../models/listevalschedulerunsstatus.md) | :heavy_minus_sign:                                                                        | N/A                                                                                       |                                                                                           |
| `x_on_behalf_of`                                                                          | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | Optional external end-user identifier forwarded by the API gateway.                       |                                                                                           |
| `retries`                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                          | :heavy_minus_sign:                                                                        | Configuration to override the default retry behavior of the client.                       |                                                                                           |

### Response

**[models.ListEvalScheduleRunsResponse](../../models/listevalschedulerunsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |