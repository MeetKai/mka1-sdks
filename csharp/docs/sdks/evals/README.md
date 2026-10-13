# Llm.Evals

## Overview

### Available Operations

* [CreateSuite](#createsuite) - Create an eval suite
* [ListSuites](#listsuites) - List eval suites
* [GetSuite](#getsuite) - Get an eval suite
* [DeleteSuite](#deletesuite) - Delete an eval suite
* [CreateSuiteVersion](#createsuiteversion) - Create an eval suite version
* [ListSuiteVersions](#listsuiteversions) - List eval suite versions
* [GetSuiteVersion](#getsuiteversion) - Get an eval suite version
* [ListSuiteLeaderboardRuns](#listsuiteleaderboardruns) - List leaderboard runs for an eval suite
* [GetSuiteLeaderboard](#getsuiteleaderboard) - Get the coding-agent leaderboard for an eval suite
* [MeasureSuiteTokens](#measuresuitetokens) - Count tokens from stored text for a suite's unmeasured samples
* [CreateRun](#createrun) - Create an eval run
* [ListRuns](#listruns) - List eval runs
* [GetRun](#getrun) - Get an eval run
* [DeleteRun](#deleterun) - Delete an eval run
* [CancelRun](#cancelrun) - Cancel an eval run
* [RerunFailedSamples](#rerunfailedsamples) - Rerun failed eval samples
* [RetryFailedRun](#retryfailedrun) - Retry an eval run
* [GetRunOverview](#getrunoverview) - Get an eval run overview
* [ListSamples](#listsamples) - List eval samples
* [GetSampleAudio](#getsampleaudio) - Get eval sample audio
* [GetSampleTrajectory](#getsampletrajectory) - Get an eval sample trajectory
* [UploadSampleTrajectory](#uploadsampletrajectory) - Upload an eval sample trajectory
* [GetArtifacts](#getartifacts) - Get eval run artifacts
* [ImportAgentRun](#importagentrun) - Import a finished coding-agent run
* [AppendAgentTrials](#appendagenttrials) - Append trials to an open coding-agent run
* [ImportHistoricalResults](#importhistoricalresults) - Import historical eval results from Hugging Face
* [CreateSchedule](#createschedule) - Create an eval schedule
* [ListSchedules](#listschedules) - List eval schedules
* [GetSchedule](#getschedule) - Get an eval schedule
* [UpdateSchedule](#updateschedule) - Update an eval schedule
* [DeleteSchedule](#deleteschedule) - Delete an eval schedule
* [TriggerSchedule](#triggerschedule) - Trigger an eval schedule now
* [ListScheduleRuns](#listscheduleruns) - List runs created by an eval schedule

## CreateSuite

Creates a team-scoped declarative eval suite. Dataset and Python grader files must be uploaded separately with purpose 'evals'.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createEvalSuite" method="post" path="/api/v1/llm/evals/suites" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.CreateSuiteAsync(body: new MeetKai.MKA1.Types.Components.CreateEvalSuiteRequest() {
    Name = "Multilingual QA smoke suite",
    Description = "Declarative eval tasks backed by uploaded files or Hugging Face datasets and Python graders.",
    Manifest = new EvalSuiteManifest() {
        Tasks = new List<EvalTask>() {
            new EvalTask() {
                Id = "spanish_qa",
                Type = EvalTaskType.Custom,
                Dataset = new EvalDataset() {
                    Source = EvalDatasetSource.Huggingface,
                    Path = "IIC/AQuAS",
                    Split = "test",
                },
                PromptTemplate = @"Responde usando el contexto.

                Contexto: {{context}}

                Pregunta: {{question}}

                Respuesta:",
                TargetTemplate = "{{answer}}",
                Grader = new EvalPythonGrader() {
                    Contract = EvalPythonGraderContract.ModelBacked,
                    ModelAccess = EvalPythonGraderModelAccess.Mka1,
                    FileId = "file_grader123",
                },
                Preprocess = new EvalPythonPreprocessor() {
                    Source = @"def transform(row):
                        return row
                    ",
                },
                NumFewshot = 1,
            },
        },
    },
    Metadata = new Dictionary<string, string>() {
        { "owner", "eval-team" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Body`                                                                                      | [Types.Components.CreateEvalSuiteRequest](../../Types/Components/CreateEvalSuiteRequest.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `XOnBehalfOf`                                                                               | *string*                                                                                    | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |

### Response

**[CreateEvalSuiteResponse](../../Types/Requests/CreateEvalSuiteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListSuites

Returns eval suites visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvalSuites" method="get" path="/api/v1/llm/evals/suites" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.ListSuitesAsync(limit: 20);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `After`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListEvalSuitesResponse](../../Types/Requests/ListEvalSuitesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetSuite

Retrieves an eval suite by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalSuite" method="get" path="/api/v1/llm/evals/suites/{suite_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.GetSuiteAsync(suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SuiteId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetEvalSuiteResponse](../../Types/Requests/GetEvalSuiteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteSuite

Soft-deletes an eval suite and all of its eval runs so they no longer appear in user-facing reads.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteEvalSuite" method="delete" path="/api/v1/llm/evals/suites/{suite_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.DeleteSuiteAsync(suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SuiteId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteEvalSuiteResponse](../../Types/Requests/DeleteEvalSuiteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateSuiteVersion

Creates an immutable suite version. Use this endpoint for edits to an existing eval suite.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createEvalSuiteVersion" method="post" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.CreateSuiteVersionAsync(
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    body: new MeetKai.MKA1.Types.Components.CreateEvalSuiteVersionRequest() {
        Manifest = new EvalSuiteManifest() {
            Tasks = new List<EvalTask>() {
                new EvalTask() {
                    Id = "spanish_qa",
                    Type = EvalTaskType.Custom,
                    Dataset = new EvalDataset() {
                        Source = EvalDatasetSource.Huggingface,
                        Path = "IIC/AQuAS",
                        Split = "test",
                    },
                    PromptTemplate = @"Responde usando el contexto.

                    Contexto: {{context}}

                    Pregunta: {{question}}

                    Respuesta:",
                    TargetTemplate = "{{answer}}",
                    Grader = new EvalPythonGrader() {
                        Contract = EvalPythonGraderContract.ModelBacked,
                        ModelAccess = EvalPythonGraderModelAccess.Mka1,
                        FileId = "file_grader123",
                    },
                    Preprocess = new EvalPythonPreprocessor() {
                        Source = @"def transform(row):
                            return row
                        ",
                    },
                    NumFewshot = 1,
                },
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               | Example                                                                                                   |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `SuiteId`                                                                                                 | *string*                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       | eval_suite_aa87e2b1112a455b8deabed784372198                                                               |
| `Body`                                                                                                    | [Types.Components.CreateEvalSuiteVersionRequest](../../Types/Components/CreateEvalSuiteVersionRequest.md) | :heavy_check_mark:                                                                                        | N/A                                                                                                       |                                                                                                           |
| `XOnBehalfOf`                                                                                             | *string*                                                                                                  | :heavy_minus_sign:                                                                                        | Optional external end-user identifier forwarded by the API gateway.                                       |                                                                                                           |

### Response

**[CreateEvalSuiteVersionResponse](../../Types/Requests/CreateEvalSuiteVersionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListSuiteVersions

Returns immutable versions for an eval suite, including each version manifest.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvalSuiteVersions" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.ListSuiteVersionsAsync(
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    limit: 20
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SuiteId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `After`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[ListEvalSuiteVersionsResponse](../../Types/Requests/ListEvalSuiteVersionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetSuiteVersion

Retrieves an immutable eval suite version and its manifest.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalSuiteVersion" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions/{version}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.GetSuiteVersionAsync(
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    version: 1
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SuiteId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `Version`                                                           | *long*                                                              | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetEvalSuiteVersionResponse](../../Types/Requests/GetEvalSuiteVersionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListSuiteLeaderboardRuns

Returns each ranking group's most recent completed runs for a suite in one request, with the group assignments in `groups`. A group is (model, targeted task) for task_ids-restricted runs and (model) for unrestricted runs (task_id null). Build boards from `groups`, not from run.models/run.task_ids — a returned run may name models or tasks whose groups it did not rank in. `truncated: true` means a server ceiling trimmed the aggregate; whole runs are kept in (best rank, first model, first task, id) order, so every group's newest runs survive before any group's fallbacks and no group is dropped for being old. Resume a truncated board by passing `next_cursor` back as `cursor` and unioning the responses. See the evals docs for grouping rationale and cost characteristics.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvalSuiteLeaderboardRuns" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard-runs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListEvalSuiteLeaderboardRunsRequest req = new ListEvalSuiteLeaderboardRunsRequest() {
    SuiteId = "eval_suite_aa87e2b1112a455b8deabed784372198",
    SuiteVersion = 1,
    Model = "meetkai:functionary-urdu-mini-pak",
};

var res = await sdk.Llm.Evals.ListSuiteLeaderboardRunsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `request`                                                                                          | [ListEvalSuiteLeaderboardRunsRequest](../../Types/Requests/ListEvalSuiteLeaderboardRunsRequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |

### Response

**[ListEvalSuiteLeaderboardRunsResponse](../../Types/Requests/ListEvalSuiteLeaderboardRunsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetSuiteLeaderboard

Ranks the suite's completed coding-agent runs, one row per (agent, model, effort). Only runs that recorded an `agent_name` participate — a QA or transcription run of the same suite has no agent to attribute a score to and is not a board row. `accuracy` is the mean of `metric` (default `reward`) over the row's scored trials, and `accuracy_ci` is the 95% Wald interval around it; both are derived per request rather than stored, so rerunning a failed trial moves them instead of leaving a stale copy behind. `agent_version` is reported but is not part of the row identity, so an agent upgrade does not split a row in two. Rows are ordered by accuracy descending, nulls last. Pass `suite_version` when the suite has more than one, otherwise the board mixes task sets.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalSuiteLeaderboard" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetEvalSuiteLeaderboardRequest req = new GetEvalSuiteLeaderboardRequest() {
    SuiteId = "eval_suite_aa87e2b1112a455b8deabed784372198",
    SuiteVersion = 1,
};

var res = await sdk.Llm.Evals.GetSuiteLeaderboardAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `request`                                                                                | [GetEvalSuiteLeaderboardRequest](../../Types/Requests/GetEvalSuiteLeaderboardRequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |

### Response

**[GetEvalSuiteLeaderboardResponse](../../Types/Requests/GetEvalSuiteLeaderboardResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## MeasureSuiteTokens

Backfill for rows written before the gateway recorded usage. For samples of the suite's completed runs that have answer or reasoning text but no token figure, counts prompt, reasoning and answer tokens from the stored text (tiktoken o200k_base, one ruler for every model), marks them `tokens_estimated`, and refreshes each run's per-task `tokens` and run totals so the leaderboard's efficiency figures appear. Processes `limit` runs per call, oldest run id first; call again until `remaining_runs` is 0. Samples the provider or the import already measured are left alone, and a sample with no text stays unmeasured. New rows get the same figures at generation or import time, so this is a no-op on a suite with nothing to measure.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="measureEvalSuiteTokens" method="post" path="/api/v1/llm/evals/suites/{suite_id}/tokens/measure" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.MeasureSuiteTokensAsync(
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    body: new MeasureEvalSuiteTokensBody() {}
);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        | Example                                                                            |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `SuiteId`                                                                          | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                | eval_suite_aa87e2b1112a455b8deabed784372198                                        |
| `Body`                                                                             | [MeasureEvalSuiteTokensBody](../../Types/Components/MeasureEvalSuiteTokensBody.md) | :heavy_check_mark:                                                                 | N/A                                                                                |                                                                                    |
| `XOnBehalfOf`                                                                      | *string*                                                                           | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |                                                                                    |

### Response

**[MeasureEvalSuiteTokensResponse](../../Types/Requests/MeasureEvalSuiteTokensResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateRun

Starts a durable eval run over the selected suite version, tasks, and models.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createEvalRun" method="post" path="/api/v1/llm/evals/runs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.CreateRunAsync(body: new MeetKai.MKA1.Types.Components.CreateEvalRunRequest() {
    SuiteId = "eval_suite_aa87e2b1112a455b8deabed784372198",
    Models = new List<string>() {
        "auto",
    },
    JudgeModel = "auto",
    EmbeddingModel = "auto",
    Generation = new EvalGenerationRequestConfig() {
        Temperature = 0D,
        MaxGenToks = 512,
        Until = new List<string>() {
            "<|endoftext|>",
        },
        DoSample = false,
        ChatTemplateKwargs = new Dictionary<string, object>() {
            { "enable_thinking", false },
        },
        TimeoutSeconds = 120,
        MaxRetries = 2,
        MaxEmptyRetries = 1,
    },
    GenerationConcurrency = 4,
    GraderConcurrency = 2,
    MaxWorkflowSampleActivities = 5000,
    Metadata = new Dictionary<string, string>() {
        { "purpose", "mvp" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `Body`                                                                                  | [Types.Components.CreateEvalRunRequest](../../Types/Components/CreateEvalRunRequest.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `XOnBehalfOf`                                                                           | *string*                                                                                | :heavy_minus_sign:                                                                      | Optional external end-user identifier forwarded by the API gateway.                     |

### Response

**[CreateEvalRunResponse](../../Types/Requests/CreateEvalRunResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListRuns

Returns eval runs visible to the authenticated team context. suite_version is a per-suite ordinal and must be paired with suite_id; supplying it alone returns 400.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvalRuns" method="get" path="/api/v1/llm/evals/runs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListEvalRunsRequest req = new ListEvalRunsRequest() {
    SuiteId = "eval_suite_aa87e2b1112a455b8deabed784372198",
    SuiteVersion = 1,
};

var res = await sdk.Llm.Evals.ListRunsAsync(req);

// handle response
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `request`                                                          | [ListEvalRunsRequest](../../Types/Requests/ListEvalRunsRequest.md) | :heavy_check_mark:                                                 | The request object to use for the request.                         |

### Response

**[ListEvalRunsResponse](../../Types/Requests/ListEvalRunsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetRun

Retrieves an eval run by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalRun" method="get" path="/api/v1/llm/evals/runs/{run_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.GetRunAsync(runId: "eval_run_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetEvalRunResponse](../../Types/Requests/GetEvalRunResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteRun

Soft-deletes an eval run so it no longer appears in run lists, details, or score leaderboards.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteEvalRun" method="delete" path="/api/v1/llm/evals/runs/{run_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.DeleteRunAsync(runId: "eval_run_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteEvalRunResponse](../../Types/Requests/DeleteEvalRunResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CancelRun

Requests cancellation for a queued or running eval run.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/cancel" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.CancelRunAsync(runId: "eval_run_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[CancelEvalRunResponse](../../Types/Requests/CancelEvalRunResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## RerunFailedSamples

Queues a completed eval run to retry only samples with sample status 'failed'. Retried samples keep the same run ID and sample IDs, replacing errored sample results in place.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="rerunFailedEvalSamples" method="post" path="/api/v1/llm/evals/runs/{run_id}/rerun-failed" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.RerunFailedSamplesAsync(runId: "eval_run_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[RerunFailedEvalSamplesResponse](../../Types/Requests/RerunFailedEvalSamplesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## RetryFailedRun

Queues a failed or cancelled eval run to retry in place. Completed samples keep their results, generated-but-unscored cancelled samples resume at scoring, unfinished samples are requeued, and runs with no persisted samples are prepared from scratch with the same run ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="retryFailedEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/retry" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.RetryFailedRunAsync(runId: "eval_run_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[RetryFailedEvalRunResponse](../../Types/Requests/RetryFailedEvalRunResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetRunOverview

Aggregate header for one run's trials view: trial counts, average reward, cost, and the input/output/cached token split. Its own route rather than fields on the run object because it scans the run's samples — folding it into `GET /evals/runs/{run_id}` would charge that scan to every run list and to the status polling that runs for the whole length of an eval. `trials.errored` overlaps `trials.failed` instead of partitioning it: a coding-agent trial can carry an agent timeout in `error` and still be completed and scored. `trials.retried` counts trials rerun through rerun-failed, read from the pre-rerun snapshot, since a rerun overwrites the sample in place.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalRunOverview" method="get" path="/api/v1/llm/evals/runs/{run_id}/overview" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.GetRunOverviewAsync(
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    metric: "reward"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `Metric`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | reward                                                              |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetEvalRunOverviewResponse](../../Types/Requests/GetEvalRunOverviewResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListSamples

Returns prompt, target, model output, extraction, score, and judge details for an eval run.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvalSamples" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListEvalSamplesRequest req = new ListEvalSamplesRequest() {
    RunId = "eval_run_aa87e2b1112a455b8deabed784372198",
};

var res = await sdk.Llm.Evals.ListSamplesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `request`                                                                | [ListEvalSamplesRequest](../../Types/Requests/ListEvalSamplesRequest.md) | :heavy_check_mark:                                                       | The request object to use for the request.                               |

### Response

**[ListEvalSamplesResponse](../../Types/Requests/ListEvalSamplesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetSampleAudio

Returns `{ object, audio, sample_index, task_id, model }` for a single transcription sample — the clip reference (a base64 `data:` URI or a URL) read from the un-redacted `dataset_row` (list responses redact inline `data:` blobs), plus the resolved task/model. Prefers the task's configured `audio_column`, falling back to a heuristic scan. The clip differs across tasks, so pass `task_id` when a run has more than one transcription task; if the index spans multiple tasks and `task_id` is omitted, returns 400 rather than guessing. `model` is optional (the clip is identical across models) and only extends the index prefix. Returns 404 when the sample or its audio is absent, 413 when the inline clip is too large. Returns 503 when object storage is briefly unreachable, as distinct from 404 for a clip that is genuinely gone.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalSampleAudio" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/audio" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetEvalSampleAudioRequest req = new GetEvalSampleAudioRequest() {
    RunId = "eval_run_aa87e2b1112a455b8deabed784372198",
    SampleIndex = 0,
};

var res = await sdk.Llm.Evals.GetSampleAudioAsync(req);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `request`                                                                      | [GetEvalSampleAudioRequest](../../Types/Requests/GetEvalSampleAudioRequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |

### Response

**[GetEvalSampleAudioResponse](../../Types/Requests/GetEvalSampleAudioResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetSampleTrajectory

Returns one coding-agent trial's session — the steps the agent took, verbatim in the harness's interchange format (see `schema_version`, e.g. `ATIF-v1.7`). Deliberately not part of the samples list: a trajectory averages ~92 KB and that list pages up to 500 rows. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one; an index that matches several trials returns 400 rather than guessing, and never falls back to another trial's session. Returns 404 when the sample does not exist or recorded no trajectory.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalSampleTrajectory" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetEvalSampleTrajectoryRequest req = new GetEvalSampleTrajectoryRequest() {
    RunId = "eval_run_aa87e2b1112a455b8deabed784372198",
    SampleIndex = 0,
};

var res = await sdk.Llm.Evals.GetSampleTrajectoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `request`                                                                                | [GetEvalSampleTrajectoryRequest](../../Types/Requests/GetEvalSampleTrajectoryRequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |

### Response

**[GetEvalSampleTrajectoryResponse](../../Types/Requests/GetEvalSampleTrajectoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UploadSampleTrajectory

Stores one coding-agent trial's session, in whatever interchange format the harness produced (record it in `schema_version`, e.g. `ATIF-v1.7`). `steps` is stored verbatim and never validated, so a harness format change needs no gateway release. Separate from the run import because a trajectory averages ~92 KB and a whole run's worth would not fit in one request. Upserts, so re-sending after a timeout replaces the trajectory rather than failing. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one — an ambiguous index returns 400 rather than writing to the wrong trial. Rejects a payload whose `steps` and `logs` together exceed 16 MiB with 413.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadEvalSampleTrajectory" method="put" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

Types.Requests.UploadEvalSampleTrajectoryRequest req = new MeetKai.MKA1.Types.Requests.UploadEvalSampleTrajectoryRequest() {
    RunId = "eval_run_aa87e2b1112a455b8deabed784372198",
    SampleIndex = 0,
    Body = new MeetKai.MKA1.Types.Components.UploadEvalSampleTrajectoryRequest() {
        Steps = new List<object>() {
            new Dictionary<string, object>() {
                { "step_id", 1 },
                { "source", "agent" },
                { "reasoning_content", "The test fails because the fixture directory is not writable." },
                { "tool_calls", new List<object>() {
                    new Dictionary<string, object>() {
                        { "function_name", "bash" },
                        { "arguments", new Dictionary<string, object>() {
                            { "command", "ls -la /workdir" },
                        } },
                    },
                } },
            },
        },
    },
};

var res = await sdk.Llm.Evals.UploadSampleTrajectoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [Types.Requests.UploadEvalSampleTrajectoryRequest](../../Types/Requests/UploadEvalSampleTrajectoryRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[UploadEvalSampleTrajectoryResponse](../../Types/Requests/UploadEvalSampleTrajectoryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetArtifacts

Returns generated result and sample artifact file IDs for a completed eval run.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalArtifacts" method="get" path="/api/v1/llm/evals/runs/{run_id}/artifacts" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.GetArtifactsAsync(runId: "eval_run_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetEvalArtifactsResponse](../../Types/Requests/GetEvalArtifactsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ImportAgentRun

Uploads one completed harness job — the run and its trials — directly, so results never round-trip through external storage the way the Hugging Face importer does. Every `task_id` must already exist in the target suite version's manifest; unknown ids are rejected rather than invented, because a typo would otherwise import as a task the suite does not have and read as a model that never covered the version. The run is recorded as `completed` and is not executed: this is a write, not a run request, so no workflow is started. Trials that cover every task of the version get `task_ids: null`, which is what lets the run rank as a complete sweep. Trajectories are NOT part of this payload — a full 91-task run measured 8.3 MB of them — so upload each one against `PUT /evals/runs/{run_id}/samples/{sample_index}/trajectory` afterwards. Pass `idempotency_key` and a retried upload returns the first run instead of doubling the trials behind a board row.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="importAgentEvalRun" method="post" path="/api/v1/llm/evals/imports/agent-run" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.ImportAgentRunAsync(body: new ImportAgentRunRequest() {
    SuiteId = "eval_suite_aa87e2b1112a455b8deabed784372198",
    SuiteVersion = 1,
    AgentName = "omp",
    AgentVersion = "17.3.8",
    AgentEffort = "medium",
    Model = "meetkai:functionary-urdu-mini-pak",
    CostUsd = 3.77D,
    CreatedAt = 1704067200,
    Metadata = new Dictionary<string, string>() {
        { "harness", "harbor" },
        { "benchmark", "terminal-bench-2.1" },
    },
    IdempotencyKey = "harbor-job-2026-08-23-luna-medium",
    Trials = new List<ImportAgentRunRequestTrial>() {
        new ImportAgentRunRequestTrial() {
            TaskId = "fix-permissions",
            SampleIndex = 0,
            Prompt = "The test suite fails because the fixture directory is not writable. Fix it.",
            Target = "all tests pass",
            OutputText = "9 passed in 2.25s",
            Scores = new Dictionary<string, double>() {
                { "reward", 1D },
                { "resolved", 1D },
            },
            CostUsd = 0.0279D,
            InputTokens = 658456,
            OutputTokens = 6489,
            CachedTokens = 658366,
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Body`                                                                   | [ImportAgentRunRequest](../../Types/Components/ImportAgentRunRequest.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `XOnBehalfOf`                                                            | *string*                                                                 | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |

### Response

**[ImportAgentEvalRunResponse](../../Types/Requests/ImportAgentEvalRunResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## AppendAgentTrials

Adds finished trials to a run opened with `finalize: false`, so a job started from MKA1 can be watched while it runs instead of appearing complete out of nowhere at the end. Each trial pins its own `sample_index` and upserts on (task, model, sample_index): a harness cannot tell a timeout from a lost response, so re-sending a batch is safe and replaces rather than duplicates. The whole batch and its aggregate recompute land in one transaction, serialized per run. Counts, metrics and cost are recomputed from the stored rows on every call, never accumulated from the request, so a replayed batch cannot double them. Send `finalize: true` (usually with an empty `trials`) to close the run — until then it stays `in_progress` and off the leaderboards, which only count completed runs. Appending to an already-completed or cancelled run is rejected: that record is finished, and rewriting it would silently move a number someone may have already read.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="appendAgentEvalTrials" method="post" path="/api/v1/llm/evals/runs/{run_id}/trials" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.AppendAgentTrialsAsync(
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    body: new AppendAgentTrialsRequest() {
        Trials = new List<AppendAgentTrialsRequestTrial>() {
            new AppendAgentTrialsRequestTrial() {
                TaskId = "fix-permissions",
                SampleIndex = 0,
                Prompt = "The test suite fails because the fixture directory is not writable. Fix it.",
                Target = "all tests pass",
                OutputText = "9 passed in 2.25s",
                Scores = new Dictionary<string, double>() {
                    { "reward", 1D },
                    { "resolved", 1D },
                },
                CostUsd = 0.0279D,
                InputTokens = 658456,
                OutputTokens = 6489,
                CachedTokens = 658366,
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    | Example                                                                        |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `RunId`                                                                        | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            | eval_run_aa87e2b1112a455b8deabed784372198                                      |
| `Body`                                                                         | [AppendAgentTrialsRequest](../../Types/Components/AppendAgentTrialsRequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |                                                                                |
| `XOnBehalfOf`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |                                                                                |

### Response

**[AppendAgentEvalTrialsResponse](../../Types/Requests/AppendAgentEvalTrialsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ImportHistoricalResults

Imports simplified historical samples.jsonl-style eval results from a Hugging Face dataset repository into a completed eval suite run shape. Aggregates are recomputed from samples and include canonical score metrics for leaderboards.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="importHistoricalEvalResults" method="post" path="/api/v1/llm/evals/imports/huggingface-results" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.ImportHistoricalResultsAsync(
    xHuggingFaceToken: "hf_your_read_token",
    body: new MeetKai.MKA1.Types.Components.ImportHistoricalEvalResultsRequest() {
        Source = new ImportHistoricalEvalResultsRequestSource() {
            PathPrefix = "functionary/ur/",
        },
        SuiteName = "MKA1 historical eval results",
        Metadata = new Dictionary<string, string>() {
            { "owner", "eval-team" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `XHuggingFaceToken`                                                                                                                                                | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Caller-owned Hugging Face token with read access to the source dataset repository. Gateway does not use its server-side Hugging Face token for historical imports. | hf_your_read_token                                                                                                                                                 |
| `Body`                                                                                                                                                             | [Types.Components.ImportHistoricalEvalResultsRequest](../../Types/Components/ImportHistoricalEvalResultsRequest.md)                                                | :heavy_check_mark:                                                                                                                                                 | N/A                                                                                                                                                                |                                                                                                                                                                    |
| `XOnBehalfOf`                                                                                                                                                      | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                                                                |                                                                                                                                                                    |

### Response

**[ImportHistoricalEvalResultsResponse](../../Types/Requests/ImportHistoricalEvalResultsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateSchedule

Schedules an eval run to fire on a cron or interval cadence, with optional webhook notifications of run status.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createEvalSchedule" method="post" path="/api/v1/llm/evals/schedules" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.CreateScheduleAsync(body: new MeetKai.MKA1.Types.Components.CreateEvalScheduleRequest() {
    Name = "Nightly MMLU regression",
    SuiteId = "eval_suite_aa87e2b1112a455b8deabed784372198",
    Cron = "0 3 * * *",
    Timezone = "US/Pacific",
    OverlapPolicy = EvalScheduleOverlapPolicy.Skip,
    WebhookUrl = "https://example.com/hooks/evals",
    WebhookSecret = "whsec_example_signing_secret",
    Run = new EvalScheduleRunRequestConfig() {
        Models = new List<string>() {
            "meetkai/model-a",
        },
    },
    Metadata = new Dictionary<string, string>() {
        { "team", "eval-ops" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `Body`                                                                                            | [Types.Components.CreateEvalScheduleRequest](../../Types/Components/CreateEvalScheduleRequest.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `XOnBehalfOf`                                                                                     | *string*                                                                                          | :heavy_minus_sign:                                                                                | Optional external end-user identifier forwarded by the API gateway.                               |

### Response

**[CreateEvalScheduleResponse](../../Types/Requests/CreateEvalScheduleResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListSchedules

Returns eval schedules visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvalSchedules" method="get" path="/api/v1/llm/evals/schedules" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListEvalSchedulesRequest req = new ListEvalSchedulesRequest() {};

var res = await sdk.Llm.Evals.ListSchedulesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [ListEvalSchedulesRequest](../../Types/Requests/ListEvalSchedulesRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |

### Response

**[ListEvalSchedulesResponse](../../Types/Requests/ListEvalSchedulesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetSchedule

Retrieves an eval schedule by ID, including the next scheduled fire time from Temporal when resolvable.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEvalSchedule" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.GetScheduleAsync(scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ScheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetEvalScheduleResponse](../../Types/Requests/GetEvalScheduleResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateSchedule

Updates an eval schedule's cadence, run config, webhook, overlap policy, or enabled state.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateEvalSchedule" method="patch" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.UpdateScheduleAsync(
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
    body: new MeetKai.MKA1.Types.Components.UpdateEvalScheduleRequest() {
        Enabled = false,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       | Example                                                                                           |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `ScheduleId`                                                                                      | *string*                                                                                          | :heavy_check_mark:                                                                                | N/A                                                                                               | eval_sched_aa87e2b1112a455b8deabed784372198                                                       |
| `Body`                                                                                            | [Types.Components.UpdateEvalScheduleRequest](../../Types/Components/UpdateEvalScheduleRequest.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |                                                                                                   |
| `XOnBehalfOf`                                                                                     | *string*                                                                                          | :heavy_minus_sign:                                                                                | Optional external end-user identifier forwarded by the API gateway.                               |                                                                                                   |

### Response

**[UpdateEvalScheduleResponse](../../Types/Requests/UpdateEvalScheduleResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteSchedule

Soft-deletes an eval schedule and removes its Temporal schedule. Historical runs are preserved.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteEvalSchedule" method="delete" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.DeleteScheduleAsync(scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ScheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteEvalScheduleResponse](../../Types/Requests/DeleteEvalScheduleResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## TriggerSchedule

Fires the schedule immediately, in addition to its normal cadence.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="triggerEvalSchedule" method="post" path="/api/v1/llm/evals/schedules/{schedule_id}/trigger" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Evals.TriggerScheduleAsync(scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ScheduleId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[TriggerEvalScheduleResponse](../../Types/Requests/TriggerEvalScheduleResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListScheduleRuns

Returns eval runs that were created by the given schedule. suite_version may be used without suite_id here, since the schedule already pins the suite; supplying a suite_id that is not the schedule's returns 400.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEvalScheduleRuns" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}/runs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListEvalScheduleRunsRequest req = new ListEvalScheduleRunsRequest() {
    ScheduleId = "eval_sched_aa87e2b1112a455b8deabed784372198",
    SuiteVersion = 1,
};

var res = await sdk.Llm.Evals.ListScheduleRunsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `request`                                                                          | [ListEvalScheduleRunsRequest](../../Types/Requests/ListEvalScheduleRunsRequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |

### Response

**[ListEvalScheduleRunsResponse](../../Types/Requests/ListEvalScheduleRunsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |