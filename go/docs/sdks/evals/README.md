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
* [ListSuiteShares](#listsuiteshares) - List eval suite shares
* [CreateSuiteShare](#createsuiteshare) - Share an eval suite with an org
* [DeleteSuiteShare](#deletesuiteshare) - Unshare an eval suite from an org
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

<!-- UsageSnippet language="go" operationID="createEvalSuite" method="post" path="/api/v1/llm/evals/suites" -->
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

    res, err := s.Llm.Evals.CreateSuite(ctx, components.CreateEvalSuiteRequest{
        Name: "Multilingual QA smoke suite",
        Description: mka1.Pointer("Declarative eval tasks backed by uploaded files or Hugging Face datasets and Python graders."),
        Manifest: components.EvalSuiteManifest{
            Tasks: []components.EvalTask{
                components.EvalTask{
                    ID: "spanish_qa",
                    Type: components.EvalTaskTypeCustom,
                    Dataset: components.EvalDataset{
                        Source: components.EvalDatasetSourceHuggingface.ToPointer(),
                        Path: mka1.Pointer("IIC/AQuAS"),
                        Split: mka1.Pointer("test"),
                    },
                    PromptTemplate: mka1.Pointer("Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:"),
                    TargetTemplate: mka1.Pointer("{{answer}}"),
                    Grader: &components.EvalPythonGrader{
                        Contract: components.EvalPythonGraderContractModelBacked.ToPointer(),
                        ModelAccess: components.EvalPythonGraderModelAccessMka1.ToPointer(),
                        FileID: mka1.Pointer("file_grader123"),
                    },
                    Preprocess: &components.EvalPythonPreprocessor{
                        Source: mka1.Pointer("def transform(row):\n    return row\n"),
                    },
                    NumFewshot: mka1.Pointer[int64](1),
                },
            },
        },
        Metadata: map[string]string{
            "owner": "eval-team",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `body`                                                                                 | [components.CreateEvalSuiteRequest](../../models/components/createevalsuiterequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.CreateEvalSuiteResponse](../../models/operations/createevalsuiteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListSuites

Returns eval suites visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalSuites" method="get" path="/api/v1/llm/evals/suites" -->
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

    res, err := s.Llm.Evals.ListSuites(ctx, nil, mka1.Pointer[int64](20), mka1.Pointer(false), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `after`                                                             | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `ownedOnly`                                                         | `*bool`                                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListEvalSuitesResponse](../../models/operations/listevalsuitesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetSuite

Retrieves an eval suite by ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalSuite" method="get" path="/api/v1/llm/evals/suites/{suite_id}" -->
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

    res, err := s.Llm.Evals.GetSuite(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `suiteID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetEvalSuiteResponse](../../models/operations/getevalsuiteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteSuite

Soft-deletes an eval suite and all of its eval runs so they no longer appear in user-facing reads.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteEvalSuite" method="delete" path="/api/v1/llm/evals/suites/{suite_id}" -->
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

    res, err := s.Llm.Evals.DeleteSuite(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteDeletedObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `suiteID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteEvalSuiteResponse](../../models/operations/deleteevalsuiteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateSuiteVersion

Creates an immutable suite version. Use this endpoint for edits to an existing eval suite.

### Example Usage

<!-- UsageSnippet language="go" operationID="createEvalSuiteVersion" method="post" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
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

    res, err := s.Llm.Evals.CreateSuiteVersion(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", components.CreateEvalSuiteVersionRequest{
        Manifest: components.EvalSuiteManifest{
            Tasks: []components.EvalTask{
                components.EvalTask{
                    ID: "spanish_qa",
                    Type: components.EvalTaskTypeCustom,
                    Dataset: components.EvalDataset{
                        Source: components.EvalDatasetSourceHuggingface.ToPointer(),
                        Path: mka1.Pointer("IIC/AQuAS"),
                        Split: mka1.Pointer("test"),
                    },
                    PromptTemplate: mka1.Pointer("Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:"),
                    TargetTemplate: mka1.Pointer("{{answer}}"),
                    Grader: &components.EvalPythonGrader{
                        Contract: components.EvalPythonGraderContractModelBacked.ToPointer(),
                        ModelAccess: components.EvalPythonGraderModelAccessMka1.ToPointer(),
                        FileID: mka1.Pointer("file_grader123"),
                    },
                    Preprocess: &components.EvalPythonPreprocessor{
                        Source: mka1.Pointer("def transform(row):\n    return row\n"),
                    },
                    NumFewshot: mka1.Pointer[int64](1),
                },
            },
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          | Example                                                                                              |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |                                                                                                      |
| `suiteID`                                                                                            | `string`                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  | eval_suite_aa87e2b1112a455b8deabed784372198                                                          |
| `body`                                                                                               | [components.CreateEvalSuiteVersionRequest](../../models/components/createevalsuiteversionrequest.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |                                                                                                      |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |                                                                                                      |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |                                                                                                      |

### Response

**[*operations.CreateEvalSuiteVersionResponse](../../models/operations/createevalsuiteversionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListSuiteVersions

Returns immutable versions for an eval suite, including each version manifest.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalSuiteVersions" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
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

    res, err := s.Llm.Evals.ListSuiteVersions(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", nil, mka1.Pointer[int64](20), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `suiteID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `after`                                                             | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ListEvalSuiteVersionsResponse](../../models/operations/listevalsuiteversionsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetSuiteVersion

Retrieves an immutable eval suite version and its manifest.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalSuiteVersion" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions/{version}" -->
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

    res, err := s.Llm.Evals.GetSuiteVersion(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", 1, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `suiteID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `version`                                                           | `int64`                                                             | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetEvalSuiteVersionResponse](../../models/operations/getevalsuiteversionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListSuiteShares

Lists the orgs this eval suite is shared with. Any member of the owning scope who can see the suite can list its shares (no admin role needed); a recipient org gets 404, as for any suite it does not own; a delegated (on-behalf-of) context is refused with 403, as on the share and unshare routes.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalSuiteShares" method="get" path="/api/v1/llm/evals/suites/{suite_id}/shares" -->
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

    res, err := s.Llm.Evals.ListSuiteShares(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteShareList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `suiteID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ListEvalSuiteSharesResponse](../../models/operations/listevalsuitesharesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateSuiteShare

Grants another org on this cluster read-only access to the suite, its versions and every run under it, including runs by other members of the owning team. Org admins only, and never a delegated (on-behalf-of) context (403); the owning org cannot be the recipient. Sharing again with the same org returns the existing grant.

### Example Usage

<!-- UsageSnippet language="go" operationID="createEvalSuiteShare" method="post" path="/api/v1/llm/evals/suites/{suite_id}/shares" -->
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

    res, err := s.Llm.Evals.CreateSuiteShare(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", components.CreateEvalSuiteShareRequest{
        OrgID: "org-partner",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteShareObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |                                                                                                  |
| `suiteID`                                                                                        | `string`                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              | eval_suite_aa87e2b1112a455b8deabed784372198                                                      |
| `body`                                                                                           | [components.CreateEvalSuiteShareRequest](../../models/components/createevalsuitesharerequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |                                                                                                  |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |                                                                                                  |

### Response

**[*operations.CreateEvalSuiteShareResponse](../../models/operations/createevalsuiteshareresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteSuiteShare

Revokes an org's read-only access to the suite. Org admins only, never a delegated (on-behalf-of) context (403).

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteEvalSuiteShare" method="delete" path="/api/v1/llm/evals/suites/{suite_id}/shares/{org_id}" -->
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

    res, err := s.Llm.Evals.DeleteSuiteShare(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", "org-partner", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteShareDeletedObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `suiteID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `orgID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | org-partner                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteEvalSuiteShareResponse](../../models/operations/deleteevalsuiteshareresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListSuiteLeaderboardRuns

Returns each ranking group's most recent completed runs for a suite in one request, with the group assignments in `groups`. A group is (model, targeted task) for task_ids-restricted runs and (model) for unrestricted runs (task_id null). Build boards from `groups`, not from run.models/run.task_ids — a returned run may name models or tasks whose groups it did not rank in. `truncated: true` means a server ceiling trimmed the aggregate; whole runs are kept in (best rank, first model, first task, id) order, so every group's newest runs survive before any group's fallbacks and no group is dropped for being old. Resume a truncated board by passing `next_cursor` back as `cursor` and unioning the responses. See the evals docs for grouping rationale and cost characteristics.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalSuiteLeaderboardRuns" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard-runs" -->
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

    res, err := s.Llm.Evals.ListSuiteLeaderboardRuns(ctx, operations.ListEvalSuiteLeaderboardRunsRequest{
        SuiteID: "eval_suite_aa87e2b1112a455b8deabed784372198",
        SuiteVersion: mka1.Pointer[int64](1),
        Model: mka1.Pointer("meetkai:functionary-urdu-mini-pak"),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                        | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                            | :heavy_check_mark:                                                                                               | The context to use for the request.                                                                              |
| `request`                                                                                                        | [operations.ListEvalSuiteLeaderboardRunsRequest](../../models/operations/listevalsuiteleaderboardrunsrequest.md) | :heavy_check_mark:                                                                                               | The request object to use for the request.                                                                       |
| `opts`                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                         | :heavy_minus_sign:                                                                                               | The options for this request.                                                                                    |

### Response

**[*operations.ListEvalSuiteLeaderboardRunsResponse](../../models/operations/listevalsuiteleaderboardrunsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetSuiteLeaderboard

Ranks the suite's completed coding-agent runs, one row per (agent, model, effort). Only runs that recorded an `agent_name` participate — a QA or transcription run of the same suite has no agent to attribute a score to and is not a board row. `accuracy` is the mean of `metric` (default `reward`) over the row's scored trials, and `accuracy_ci` is the 95% Wald interval around it; both are derived per request rather than stored, so rerunning a failed trial moves them instead of leaving a stale copy behind. `agent_version` is reported but is not part of the row identity, so an agent upgrade does not split a row in two. Rows are ordered by accuracy descending, nulls last. Pass `suite_version` when the suite has more than one, otherwise the board mixes task sets.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalSuiteLeaderboard" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard" -->
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

    res, err := s.Llm.Evals.GetSuiteLeaderboard(ctx, operations.GetEvalSuiteLeaderboardRequest{
        SuiteID: "eval_suite_aa87e2b1112a455b8deabed784372198",
        SuiteVersion: mka1.Pointer[int64](1),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteLeaderboard != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `request`                                                                                              | [operations.GetEvalSuiteLeaderboardRequest](../../models/operations/getevalsuiteleaderboardrequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.GetEvalSuiteLeaderboardResponse](../../models/operations/getevalsuiteleaderboardresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## MeasureSuiteTokens

Backfill for rows written before the gateway recorded usage. For samples of the suite's completed runs that have answer or reasoning text but no token figure, counts prompt, reasoning and answer tokens from the stored text (tiktoken o200k_base, one ruler for every model), marks them `tokens_estimated`, and refreshes each run's per-task `tokens` and run totals so the leaderboard's efficiency figures appear. Processes `limit` runs per call, oldest run id first; call again until `remaining_runs` is 0. Samples the provider or the import already measured are left alone, and a sample with no text stays unmeasured. New rows get the same figures at generation or import time, so this is a no-op on a suite with nothing to measure.

### Example Usage

<!-- UsageSnippet language="go" operationID="measureEvalSuiteTokens" method="post" path="/api/v1/llm/evals/suites/{suite_id}/tokens/measure" -->
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

    res, err := s.Llm.Evals.MeasureSuiteTokens(ctx, "eval_suite_aa87e2b1112a455b8deabed784372198", components.MeasureEvalSuiteTokensBody{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSuiteTokenMeasurement != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    | Example                                                                                        |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |                                                                                                |
| `suiteID`                                                                                      | `string`                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            | eval_suite_aa87e2b1112a455b8deabed784372198                                                    |
| `body`                                                                                         | [components.MeasureEvalSuiteTokensBody](../../models/components/measureevalsuitetokensbody.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |                                                                                                |
| `xOnBehalfOf`                                                                                  | `*string`                                                                                      | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |                                                                                                |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |                                                                                                |

### Response

**[*operations.MeasureEvalSuiteTokensResponse](../../models/operations/measureevalsuitetokensresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateRun

Starts a durable eval run over the selected suite version, tasks, and models.

### Example Usage

<!-- UsageSnippet language="go" operationID="createEvalRun" method="post" path="/api/v1/llm/evals/runs" -->
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

    res, err := s.Llm.Evals.CreateRun(ctx, components.CreateEvalRunRequest{
        SuiteID: "eval_suite_aa87e2b1112a455b8deabed784372198",
        Models: []string{
            "auto",
        },
        JudgeModel: mka1.Pointer("auto"),
        EmbeddingModel: mka1.Pointer("auto"),
        Generation: &components.EvalGenerationRequestConfig{
            Temperature: mka1.Pointer[float64](0.0),
            MaxGenToks: mka1.Pointer[int64](512),
            Until: []string{
                "<|endoftext|>",
            },
            DoSample: mka1.Pointer(false),
            ChatTemplateKwargs: map[string]any{
                "enable_thinking": false,
            },
            TimeoutSeconds: mka1.Pointer[int64](120),
            MaxRetries: mka1.Pointer[int64](2),
            MaxEmptyRetries: mka1.Pointer[int64](1),
        },
        GenerationConcurrency: mka1.Pointer[int64](4),
        GraderConcurrency: mka1.Pointer[int64](2),
        MaxWorkflowSampleActivities: mka1.Pointer[int64](5000),
        Metadata: map[string]string{
            "purpose": "mvp",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `body`                                                                             | [components.CreateEvalRunRequest](../../models/components/createevalrunrequest.md) | :heavy_check_mark:                                                                 | N/A                                                                                |
| `xOnBehalfOf`                                                                      | `*string`                                                                          | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.CreateEvalRunResponse](../../models/operations/createevalrunresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListRuns

Returns eval runs visible to the authenticated team context. suite_version is a per-suite ordinal and must be paired with suite_id; supplying it alone returns 400.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalRuns" method="get" path="/api/v1/llm/evals/runs" -->
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

    res, err := s.Llm.Evals.ListRuns(ctx, operations.ListEvalRunsRequest{
        SuiteID: mka1.Pointer("eval_suite_aa87e2b1112a455b8deabed784372198"),
        SuiteVersion: mka1.Pointer[int64](1),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ctx`                                                                            | [context.Context](https://pkg.go.dev/context#Context)                            | :heavy_check_mark:                                                               | The context to use for the request.                                              |
| `request`                                                                        | [operations.ListEvalRunsRequest](../../models/operations/listevalrunsrequest.md) | :heavy_check_mark:                                                               | The request object to use for the request.                                       |
| `opts`                                                                           | [][operations.Option](../../models/operations/option.md)                         | :heavy_minus_sign:                                                               | The options for this request.                                                    |

### Response

**[*operations.ListEvalRunsResponse](../../models/operations/listevalrunsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetRun

Retrieves an eval run by ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalRun" method="get" path="/api/v1/llm/evals/runs/{run_id}" -->
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

    res, err := s.Llm.Evals.GetRun(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetEvalRunResponse](../../models/operations/getevalrunresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteRun

Soft-deletes an eval run so it no longer appears in run lists, details, or score leaderboards.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteEvalRun" method="delete" path="/api/v1/llm/evals/runs/{run_id}" -->
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

    res, err := s.Llm.Evals.DeleteRun(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalRunDeletedObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteEvalRunResponse](../../models/operations/deleteevalrunresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CancelRun

Requests cancellation for a queued or running eval run.

### Example Usage

<!-- UsageSnippet language="go" operationID="cancelEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/cancel" -->
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

    res, err := s.Llm.Evals.CancelRun(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.CancelEvalRunResponse](../../models/operations/cancelevalrunresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## RerunFailedSamples

Queues a completed eval run to retry only samples with sample status 'failed'. Retried samples keep the same run ID and sample IDs, replacing errored sample results in place.

### Example Usage

<!-- UsageSnippet language="go" operationID="rerunFailedEvalSamples" method="post" path="/api/v1/llm/evals/runs/{run_id}/rerun-failed" -->
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

    res, err := s.Llm.Evals.RerunFailedSamples(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.RerunFailedEvalSamplesResponse](../../models/operations/rerunfailedevalsamplesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## RetryFailedRun

Queues a failed or cancelled eval run to retry in place. Completed samples keep their results, generated-but-unscored cancelled samples resume at scoring, unfinished samples are requeued, and runs with no persisted samples are prepared from scratch with the same run ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="retryFailedEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/retry" -->
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

    res, err := s.Llm.Evals.RetryFailedRun(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.RetryFailedEvalRunResponse](../../models/operations/retryfailedevalrunresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetRunOverview

Aggregate header for one run's trials view: trial counts, average reward, cost, and the input/output/cached token split. Its own route rather than fields on the run object because it scans the run's samples — folding it into `GET /evals/runs/{run_id}` would charge that scan to every run list and to the status polling that runs for the whole length of an eval. `trials.errored` overlaps `trials.failed` instead of partitioning it: a coding-agent trial can carry an agent timeout in `error` and still be completed and scored. `trials.retried` counts trials rerun through rerun-failed, read from the pre-rerun snapshot, since a rerun overwrites the sample in place.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalRunOverview" method="get" path="/api/v1/llm/evals/runs/{run_id}/overview" -->
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

    res, err := s.Llm.Evals.GetRunOverview(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", mka1.Pointer("reward"), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalRunOverview != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `metric`                                                            | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 | reward                                                              |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetEvalRunOverviewResponse](../../models/operations/getevalrunoverviewresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListSamples

Returns prompt, target, model output, extraction, score, and judge details for an eval run.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalSamples" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples" -->
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

    res, err := s.Llm.Evals.ListSamples(ctx, operations.ListEvalSamplesRequest{
        RunID: "eval_run_aa87e2b1112a455b8deabed784372198",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSampleList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `request`                                                                              | [operations.ListEvalSamplesRequest](../../models/operations/listevalsamplesrequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.ListEvalSamplesResponse](../../models/operations/listevalsamplesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetSampleAudio

Returns `{ object, audio, sample_index, task_id, model }` for a single transcription sample — the clip reference (a base64 `data:` URI or a URL) read from the un-redacted `dataset_row` (list responses redact inline `data:` blobs), plus the resolved task/model. Prefers the task's configured `audio_column`, falling back to a heuristic scan. The clip differs across tasks, so pass `task_id` when a run has more than one transcription task; if the index spans multiple tasks and `task_id` is omitted, returns 400 rather than guessing. `model` is optional (the clip is identical across models) and only extends the index prefix. Returns 404 when the sample or its audio is absent, 413 when the inline clip is too large. Returns 503 when object storage is briefly unreachable, as distinct from 404 for a clip that is genuinely gone.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalSampleAudio" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/audio" -->
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

    res, err := s.Llm.Evals.GetSampleAudio(ctx, operations.GetEvalSampleAudioRequest{
        RunID: "eval_run_aa87e2b1112a455b8deabed784372198",
        SampleIndex: 0,
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSampleAudioObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |
| `request`                                                                                    | [operations.GetEvalSampleAudioRequest](../../models/operations/getevalsampleaudiorequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |

### Response

**[*operations.GetEvalSampleAudioResponse](../../models/operations/getevalsampleaudioresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetSampleTrajectory

Returns one coding-agent trial's session — the steps the agent took, verbatim in the harness's interchange format (see `schema_version`, e.g. `ATIF-v1.7`). Deliberately not part of the samples list: a trajectory averages ~92 KB and that list pages up to 500 rows. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one; an index that matches several trials returns 400 rather than guessing, and never falls back to another trial's session. Returns 404 when the sample does not exist or recorded no trajectory.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalSampleTrajectory" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
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

    res, err := s.Llm.Evals.GetSampleTrajectory(ctx, operations.GetEvalSampleTrajectoryRequest{
        RunID: "eval_run_aa87e2b1112a455b8deabed784372198",
        SampleIndex: 0,
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `request`                                                                                              | [operations.GetEvalSampleTrajectoryRequest](../../models/operations/getevalsampletrajectoryrequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.GetEvalSampleTrajectoryResponse](../../models/operations/getevalsampletrajectoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UploadSampleTrajectory

Stores one coding-agent trial's session, in whatever interchange format the harness produced (record it in `schema_version`, e.g. `ATIF-v1.7`). `steps` is stored verbatim and never validated, so a harness format change needs no gateway release. Separate from the run import because a trajectory averages ~92 KB and a whole run's worth would not fit in one request. Upserts, so re-sending after a timeout replaces the trajectory rather than failing. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one — an ambiguous index returns 400 rather than writing to the wrong trial. Rejects a payload whose `steps` and `logs` together exceed 16 MiB with 413.

### Example Usage

<!-- UsageSnippet language="go" operationID="uploadEvalSampleTrajectory" method="put" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Evals.UploadSampleTrajectory(ctx, operations.UploadEvalSampleTrajectoryRequest{
        RunID: "eval_run_aa87e2b1112a455b8deabed784372198",
        SampleIndex: 0,
        Body: components.UploadEvalSampleTrajectoryRequest{
            Steps: []any{
                map[string]any{
                    "step_id": 1,
                    "source": "agent",
                    "reasoning_content": "The test fails because the fixture directory is not writable.",
                    "tool_calls": []any{
                        map[string]any{
                            "function_name": "bash",
                            "arguments": map[string]any{
                                "command": "ls -la /workdir",
                            },
                        },
                    },
                },
            },
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalSampleTrajectoryUploadedObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                        | :heavy_check_mark:                                                                                           | The context to use for the request.                                                                          |
| `request`                                                                                                    | [operations.UploadEvalSampleTrajectoryRequest](../../models/operations/uploadevalsampletrajectoryrequest.md) | :heavy_check_mark:                                                                                           | The request object to use for the request.                                                                   |
| `opts`                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                     | :heavy_minus_sign:                                                                                           | The options for this request.                                                                                |

### Response

**[*operations.UploadEvalSampleTrajectoryResponse](../../models/operations/uploadevalsampletrajectoryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetArtifacts

Returns generated result and sample artifact file IDs for a completed eval run. Only files the caller can download are listed: artifact files stay owner-scoped, so on a run reached through a suite share the lists are empty.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalArtifacts" method="get" path="/api/v1/llm/evals/runs/{run_id}/artifacts" -->
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

    res, err := s.Llm.Evals.GetArtifacts(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalArtifactsObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `runID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetEvalArtifactsResponse](../../models/operations/getevalartifactsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ImportAgentRun

Uploads one completed harness job — the run and its trials — directly, so results never round-trip through external storage the way the Hugging Face importer does. Every `task_id` must already exist in the target suite version's manifest; unknown ids are rejected rather than invented, because a typo would otherwise import as a task the suite does not have and read as a model that never covered the version. The run is recorded as `completed` and is not executed: this is a write, not a run request, so no workflow is started. Trials that cover every task of the version get `task_ids: null`, which is what lets the run rank as a complete sweep. Trajectories are NOT part of this payload — a full 91-task run measured 8.3 MB of them — so upload each one against `PUT /evals/runs/{run_id}/samples/{sample_index}/trajectory` afterwards. Pass `idempotency_key` and a retried upload returns the first run instead of doubling the trials behind a board row.

### Example Usage

<!-- UsageSnippet language="go" operationID="importAgentEvalRun" method="post" path="/api/v1/llm/evals/imports/agent-run" -->
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

    res, err := s.Llm.Evals.ImportAgentRun(ctx, components.ImportAgentRunRequest{
        SuiteID: "eval_suite_aa87e2b1112a455b8deabed784372198",
        SuiteVersion: mka1.Pointer[int64](1),
        AgentName: "omp",
        AgentVersion: optionalnullable.From(mka1.Pointer("17.3.8")),
        AgentEffort: optionalnullable.From(mka1.Pointer("medium")),
        Model: "meetkai:functionary-urdu-mini-pak",
        CostUsd: optionalnullable.From(mka1.Pointer[float64](3.77)),
        CreatedAt: mka1.Pointer[int64](1704067200),
        Metadata: map[string]string{
            "harness": "harbor",
            "benchmark": "terminal-bench-2.1",
        },
        IdempotencyKey: mka1.Pointer("harbor-job-2026-08-23-luna-medium"),
        Trials: []components.ImportAgentRunRequestTrial{
            components.ImportAgentRunRequestTrial{
                TaskID: "fix-permissions",
                SampleIndex: mka1.Pointer[int64](0),
                Prompt: mka1.Pointer("The test suite fails because the fixture directory is not writable. Fix it."),
                Target: optionalnullable.From(mka1.Pointer("all tests pass")),
                OutputText: optionalnullable.From(mka1.Pointer("9 passed in 2.25s")),
                Scores: map[string]float64{
                    "reward": 1.0,
                    "resolved": 1.0,
                },
                CostUsd: optionalnullable.From(mka1.Pointer[float64](0.0279)),
                InputTokens: optionalnullable.From(mka1.Pointer[int64](658456)),
                OutputTokens: optionalnullable.From(mka1.Pointer[int64](6489)),
                CachedTokens: optionalnullable.From(mka1.Pointer[int64](658366)),
            },
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ctx`                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                | :heavy_check_mark:                                                                   | The context to use for the request.                                                  |
| `body`                                                                               | [components.ImportAgentRunRequest](../../models/components/importagentrunrequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `xOnBehalfOf`                                                                        | `*string`                                                                            | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `opts`                                                                               | [][operations.Option](../../models/operations/option.md)                             | :heavy_minus_sign:                                                                   | The options for this request.                                                        |

### Response

**[*operations.ImportAgentEvalRunResponse](../../models/operations/importagentevalrunresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## AppendAgentTrials

Adds finished trials to a run opened with `finalize: false`, so a job started from MKA1 can be watched while it runs instead of appearing complete out of nowhere at the end. Each trial pins its own `sample_index` and upserts on (task, model, sample_index): a harness cannot tell a timeout from a lost response, so re-sending a batch is safe and replaces rather than duplicates. The whole batch and its aggregate recompute land in one transaction, serialized per run. Counts, metrics and cost are recomputed from the stored rows on every call, never accumulated from the request, so a replayed batch cannot double them. Send `finalize: true` (usually with an empty `trials`) to close the run — until then it stays `in_progress` and off the leaderboards, which only count completed runs. Appending to an already-completed or cancelled run is rejected: that record is finished, and rewriting it would silently move a number someone may have already read.

### Example Usage

<!-- UsageSnippet language="go" operationID="appendAgentEvalTrials" method="post" path="/api/v1/llm/evals/runs/{run_id}/trials" -->
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

    res, err := s.Llm.Evals.AppendAgentTrials(ctx, "eval_run_aa87e2b1112a455b8deabed784372198", components.AppendAgentTrialsRequest{
        Trials: []components.AppendAgentTrialsRequestTrial{
            components.AppendAgentTrialsRequestTrial{
                TaskID: "fix-permissions",
                SampleIndex: 0,
                Prompt: mka1.Pointer("The test suite fails because the fixture directory is not writable. Fix it."),
                Target: optionalnullable.From(mka1.Pointer("all tests pass")),
                OutputText: optionalnullable.From(mka1.Pointer("9 passed in 2.25s")),
                Scores: map[string]float64{
                    "reward": 1.0,
                    "resolved": 1.0,
                },
                CostUsd: optionalnullable.From(mka1.Pointer[float64](0.0279)),
                InputTokens: optionalnullable.From(mka1.Pointer[int64](658456)),
                OutputTokens: optionalnullable.From(mka1.Pointer[int64](6489)),
                CachedTokens: optionalnullable.From(mka1.Pointer[int64](658366)),
            },
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |                                                                                            |
| `runID`                                                                                    | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | eval_run_aa87e2b1112a455b8deabed784372198                                                  |
| `body`                                                                                     | [components.AppendAgentTrialsRequest](../../models/components/appendagenttrialsrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |                                                                                            |

### Response

**[*operations.AppendAgentEvalTrialsResponse](../../models/operations/appendagentevaltrialsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ImportHistoricalResults

Imports simplified historical samples.jsonl-style eval results from a Hugging Face dataset repository into a completed eval suite run shape. Aggregates are recomputed from samples and include canonical score metrics for leaderboards.

### Example Usage

<!-- UsageSnippet language="go" operationID="importHistoricalEvalResults" method="post" path="/api/v1/llm/evals/imports/huggingface-results" -->
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

    res, err := s.Llm.Evals.ImportHistoricalResults(ctx, "hf_your_read_token", components.ImportHistoricalEvalResultsRequest{
        Source: &components.ImportHistoricalEvalResultsRequestSource{
            PathPrefix: mka1.Pointer("functionary/ur/"),
        },
        SuiteName: mka1.Pointer("MKA1 historical eval results"),
        Metadata: map[string]string{
            "owner": "eval-team",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalHistoricalImportObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                                                                                              | :heavy_check_mark:                                                                                                                                                 | The context to use for the request.                                                                                                                                |                                                                                                                                                                    |
| `xHuggingFaceToken`                                                                                                                                                | `string`                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Caller-owned Hugging Face token with read access to the source dataset repository. Gateway does not use its server-side Hugging Face token for historical imports. | hf_your_read_token                                                                                                                                                 |
| `body`                                                                                                                                                             | [components.ImportHistoricalEvalResultsRequest](../../models/components/importhistoricalevalresultsrequest.md)                                                     | :heavy_check_mark:                                                                                                                                                 | N/A                                                                                                                                                                |                                                                                                                                                                    |
| `xOnBehalfOf`                                                                                                                                                      | `*string`                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                                                                |                                                                                                                                                                    |
| `opts`                                                                                                                                                             | [][operations.Option](../../models/operations/option.md)                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | The options for this request.                                                                                                                                      |                                                                                                                                                                    |

### Response

**[*operations.ImportHistoricalEvalResultsResponse](../../models/operations/importhistoricalevalresultsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateSchedule

Schedules an eval run to fire on a cron or interval cadence, with optional webhook notifications of run status.

### Example Usage

<!-- UsageSnippet language="go" operationID="createEvalSchedule" method="post" path="/api/v1/llm/evals/schedules" -->
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

    res, err := s.Llm.Evals.CreateSchedule(ctx, components.CreateEvalScheduleRequest{
        Name: "Nightly MMLU regression",
        SuiteID: "eval_suite_aa87e2b1112a455b8deabed784372198",
        Cron: mka1.Pointer("0 3 * * *"),
        Timezone: mka1.Pointer("US/Pacific"),
        OverlapPolicy: components.EvalScheduleOverlapPolicySkip.ToPointer(),
        WebhookURL: mka1.Pointer("https://example.com/hooks/evals"),
        WebhookSecret: mka1.Pointer("whsec_example_signing_secret"),
        Run: components.EvalScheduleRunRequestConfig{
            Models: []string{
                "meetkai/model-a",
            },
        },
        Metadata: map[string]string{
            "team": "eval-ops",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |
| `body`                                                                                       | [components.CreateEvalScheduleRequest](../../models/components/createevalschedulerequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `xOnBehalfOf`                                                                                | `*string`                                                                                    | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |

### Response

**[*operations.CreateEvalScheduleResponse](../../models/operations/createevalscheduleresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListSchedules

Returns eval schedules visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalSchedules" method="get" path="/api/v1/llm/evals/schedules" -->
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

    res, err := s.Llm.Evals.ListSchedules(ctx, operations.ListEvalSchedulesRequest{})
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ListEvalSchedulesRequest](../../models/operations/listevalschedulesrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ListEvalSchedulesResponse](../../models/operations/listevalschedulesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetSchedule

Retrieves an eval schedule by ID, including the next scheduled fire time from Temporal when resolvable.

### Example Usage

<!-- UsageSnippet language="go" operationID="getEvalSchedule" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
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

    res, err := s.Llm.Evals.GetSchedule(ctx, "eval_sched_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `scheduleID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetEvalScheduleResponse](../../models/operations/getevalscheduleresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateSchedule

Updates an eval schedule's cadence, run config, webhook, overlap policy, or enabled state.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateEvalSchedule" method="patch" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
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

    res, err := s.Llm.Evals.UpdateSchedule(ctx, "eval_sched_aa87e2b1112a455b8deabed784372198", components.UpdateEvalScheduleRequest{
        Enabled: mka1.Pointer(false),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  | Example                                                                                      |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |                                                                                              |
| `scheduleID`                                                                                 | `string`                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          | eval_sched_aa87e2b1112a455b8deabed784372198                                                  |
| `body`                                                                                       | [components.UpdateEvalScheduleRequest](../../models/components/updateevalschedulerequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |                                                                                              |
| `xOnBehalfOf`                                                                                | `*string`                                                                                    | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |                                                                                              |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |                                                                                              |

### Response

**[*operations.UpdateEvalScheduleResponse](../../models/operations/updateevalscheduleresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteSchedule

Soft-deletes an eval schedule and removes its Temporal schedule. Historical runs are preserved.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteEvalSchedule" method="delete" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
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

    res, err := s.Llm.Evals.DeleteSchedule(ctx, "eval_sched_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EvalScheduleDeletedObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `scheduleID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteEvalScheduleResponse](../../models/operations/deleteevalscheduleresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## TriggerSchedule

Fires the schedule immediately, in addition to its normal cadence.

### Example Usage

<!-- UsageSnippet language="go" operationID="triggerEvalSchedule" method="post" path="/api/v1/llm/evals/schedules/{schedule_id}/trigger" -->
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

    res, err := s.Llm.Evals.TriggerSchedule(ctx, "eval_sched_aa87e2b1112a455b8deabed784372198", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `scheduleID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_sched_aa87e2b1112a455b8deabed784372198                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.TriggerEvalScheduleResponse](../../models/operations/triggerevalscheduleresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListScheduleRuns

Returns eval runs that were created by the given schedule. suite_version may be used without suite_id here, since the schedule already pins the suite; supplying a suite_id that is not the schedule's returns 400.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEvalScheduleRuns" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}/runs" -->
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

    res, err := s.Llm.Evals.ListScheduleRuns(ctx, operations.ListEvalScheduleRunsRequest{
        ScheduleID: "eval_sched_aa87e2b1112a455b8deabed784372198",
        SuiteVersion: mka1.Pointer[int64](1),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `request`                                                                                        | [operations.ListEvalScheduleRunsRequest](../../models/operations/listevalschedulerunsrequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.ListEvalScheduleRunsResponse](../../models/operations/listevalschedulerunsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |