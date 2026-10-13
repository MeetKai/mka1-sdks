# Llm.Evals

## Overview

### Available Operations

* [createSuite](#createsuite) - Create an eval suite
* [listSuites](#listsuites) - List eval suites
* [getSuite](#getsuite) - Get an eval suite
* [deleteSuite](#deletesuite) - Delete an eval suite
* [createSuiteVersion](#createsuiteversion) - Create an eval suite version
* [listSuiteVersions](#listsuiteversions) - List eval suite versions
* [getSuiteVersion](#getsuiteversion) - Get an eval suite version
* [listSuiteLeaderboardRuns](#listsuiteleaderboardruns) - List leaderboard runs for an eval suite
* [getSuiteLeaderboard](#getsuiteleaderboard) - Get the coding-agent leaderboard for an eval suite
* [measureSuiteTokens](#measuresuitetokens) - Count tokens from stored text for a suite's unmeasured samples
* [createRun](#createrun) - Create an eval run
* [listRuns](#listruns) - List eval runs
* [getRun](#getrun) - Get an eval run
* [deleteRun](#deleterun) - Delete an eval run
* [cancelRun](#cancelrun) - Cancel an eval run
* [rerunFailedSamples](#rerunfailedsamples) - Rerun failed eval samples
* [retryFailedRun](#retryfailedrun) - Retry an eval run
* [getRunOverview](#getrunoverview) - Get an eval run overview
* [listSamples](#listsamples) - List eval samples
* [getSampleAudio](#getsampleaudio) - Get eval sample audio
* [getSampleTrajectory](#getsampletrajectory) - Get an eval sample trajectory
* [uploadSampleTrajectory](#uploadsampletrajectory) - Upload an eval sample trajectory
* [getArtifacts](#getartifacts) - Get eval run artifacts
* [importAgentRun](#importagentrun) - Import a finished coding-agent run
* [appendAgentTrials](#appendagenttrials) - Append trials to an open coding-agent run
* [importHistoricalResults](#importhistoricalresults) - Import historical eval results from Hugging Face
* [createSchedule](#createschedule) - Create an eval schedule
* [listSchedules](#listschedules) - List eval schedules
* [getSchedule](#getschedule) - Get an eval schedule
* [updateSchedule](#updateschedule) - Update an eval schedule
* [deleteSchedule](#deleteschedule) - Delete an eval schedule
* [triggerSchedule](#triggerschedule) - Trigger an eval schedule now
* [listScheduleRuns](#listscheduleruns) - List runs created by an eval schedule

## createSuite

Creates a team-scoped declarative eval suite. Dataset and Python grader files must be uploaded separately with purpose 'evals'.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createEvalSuite" method="post" path="/api/v1/llm/evals/suites" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.createSuite({
    createEvalSuiteRequest: {
      name: "Multilingual QA smoke suite",
      description: "Declarative eval tasks backed by uploaded files or Hugging Face datasets and Python graders.",
      manifest: {
        tasks: [
          {
            id: "spanish_qa",
            type: "custom",
            dataset: {
              source: "huggingface",
              path: "IIC/AQuAS",
              split: "test",
            },
            promptTemplate: "Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:",
            targetTemplate: "{{answer}}",
            grader: {
              type: "python",
              contract: "model_backed",
              modelAccess: "mka1",
              fileId: "file_grader123",
            },
            preprocess: {
              type: "python",
              source: "def transform(row):\n    return row\n",
            },
            numFewshot: 1,
          },
        ],
      },
      metadata: {
        "owner": "eval-team",
      },
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsCreateSuite } from "@meetkai/mka1/funcs/llmEvalsCreateSuite.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsCreateSuite(sdk, {
    createEvalSuiteRequest: {
      name: "Multilingual QA smoke suite",
      description: "Declarative eval tasks backed by uploaded files or Hugging Face datasets and Python graders.",
      manifest: {
        tasks: [
          {
            id: "spanish_qa",
            type: "custom",
            dataset: {
              source: "huggingface",
              path: "IIC/AQuAS",
              split: "test",
            },
            promptTemplate: "Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:",
            targetTemplate: "{{answer}}",
            grader: {
              type: "python",
              contract: "model_backed",
              modelAccess: "mka1",
              fileId: "file_grader123",
            },
            preprocess: {
              type: "python",
              source: "def transform(row):\n    return row\n",
            },
            numFewshot: 1,
          },
        ],
      },
      metadata: {
        "owner": "eval-team",
      },
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsCreateSuite failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsCreateSuiteMutation
} from "@meetkai/mka1/react-query/llmEvalsCreateSuite.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateEvalSuiteRequest](../../models/operations/createevalsuiterequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSuiteObject](../../models/components/evalsuiteobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listSuites

Returns eval suites visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listEvalSuites" method="get" path="/api/v1/llm/evals/suites" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.listSuites({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsListSuites } from "@meetkai/mka1/funcs/llmEvalsListSuites.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsListSuites(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsListSuites failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsListSuites,
  useLlmEvalsListSuitesSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsListSuites,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsListSuites,
  invalidateAllLlmEvalsListSuites,
} from "@meetkai/mka1/react-query/llmEvalsListSuites.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListEvalSuitesRequest](../../models/operations/listevalsuitesrequest.md)                                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSuiteList](../../models/components/evalsuitelist.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getSuite

Retrieves an eval suite by ID.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalSuite" method="get" path="/api/v1/llm/evals/suites/{suite_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getSuite({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetSuite } from "@meetkai/mka1/funcs/llmEvalsGetSuite.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetSuite(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetSuite failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetSuite,
  useLlmEvalsGetSuiteSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetSuite,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetSuite,
  invalidateAllLlmEvalsGetSuite,
} from "@meetkai/mka1/react-query/llmEvalsGetSuite.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalSuiteRequest](../../models/operations/getevalsuiterequest.md)                                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSuiteObject](../../models/components/evalsuiteobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## deleteSuite

Soft-deletes an eval suite and all of its eval runs so they no longer appear in user-facing reads.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteEvalSuite" method="delete" path="/api/v1/llm/evals/suites/{suite_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.deleteSuite({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsDeleteSuite } from "@meetkai/mka1/funcs/llmEvalsDeleteSuite.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsDeleteSuite(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsDeleteSuite failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsDeleteSuiteMutation
} from "@meetkai/mka1/react-query/llmEvalsDeleteSuite.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteEvalSuiteRequest](../../models/operations/deleteevalsuiterequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSuiteDeletedObject](../../models/components/evalsuitedeletedobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## createSuiteVersion

Creates an immutable suite version. Use this endpoint for edits to an existing eval suite.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createEvalSuiteVersion" method="post" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.createSuiteVersion({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    createEvalSuiteVersionRequest: {
      manifest: {
        tasks: [
          {
            id: "spanish_qa",
            type: "custom",
            dataset: {
              source: "huggingface",
              path: "IIC/AQuAS",
              split: "test",
            },
            promptTemplate: "Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:",
            targetTemplate: "{{answer}}",
            grader: {
              type: "python",
              contract: "model_backed",
              modelAccess: "mka1",
              fileId: "file_grader123",
            },
            preprocess: {
              type: "python",
              source: "def transform(row):\n    return row\n",
            },
            numFewshot: 1,
          },
        ],
      },
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsCreateSuiteVersion } from "@meetkai/mka1/funcs/llmEvalsCreateSuiteVersion.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsCreateSuiteVersion(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    createEvalSuiteVersionRequest: {
      manifest: {
        tasks: [
          {
            id: "spanish_qa",
            type: "custom",
            dataset: {
              source: "huggingface",
              path: "IIC/AQuAS",
              split: "test",
            },
            promptTemplate: "Responde usando el contexto.\n\nContexto: {{context}}\n\nPregunta: {{question}}\n\nRespuesta:",
            targetTemplate: "{{answer}}",
            grader: {
              type: "python",
              contract: "model_backed",
              modelAccess: "mka1",
              fileId: "file_grader123",
            },
            preprocess: {
              type: "python",
              source: "def transform(row):\n    return row\n",
            },
            numFewshot: 1,
          },
        ],
      },
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsCreateSuiteVersion failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsCreateSuiteVersionMutation
} from "@meetkai/mka1/react-query/llmEvalsCreateSuiteVersion.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateEvalSuiteVersionRequest](../../models/operations/createevalsuiteversionrequest.md)                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateEvalSuiteVersionResponseBody](../../models/operations/createevalsuiteversionresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listSuiteVersions

Returns immutable versions for an eval suite, including each version manifest.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listEvalSuiteVersions" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.listSuiteVersions({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsListSuiteVersions } from "@meetkai/mka1/funcs/llmEvalsListSuiteVersions.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsListSuiteVersions(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsListSuiteVersions failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsListSuiteVersions,
  useLlmEvalsListSuiteVersionsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsListSuiteVersions,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsListSuiteVersions,
  invalidateAllLlmEvalsListSuiteVersions,
} from "@meetkai/mka1/react-query/llmEvalsListSuiteVersions.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListEvalSuiteVersionsRequest](../../models/operations/listevalsuiteversionsrequest.md)                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListEvalSuiteVersionsResponseBody](../../models/operations/listevalsuiteversionsresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getSuiteVersion

Retrieves an immutable eval suite version and its manifest.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalSuiteVersion" method="get" path="/api/v1/llm/evals/suites/{suite_id}/versions/{version}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getSuiteVersion({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    version: 1,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetSuiteVersion } from "@meetkai/mka1/funcs/llmEvalsGetSuiteVersion.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetSuiteVersion(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    version: 1,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetSuiteVersion failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetSuiteVersion,
  useLlmEvalsGetSuiteVersionSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetSuiteVersion,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetSuiteVersion,
  invalidateAllLlmEvalsGetSuiteVersion,
} from "@meetkai/mka1/react-query/llmEvalsGetSuiteVersion.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalSuiteVersionRequest](../../models/operations/getevalsuiteversionrequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetEvalSuiteVersionResponseBody](../../models/operations/getevalsuiteversionresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listSuiteLeaderboardRuns

Returns each ranking group's most recent completed runs for a suite in one request, with the group assignments in `groups`. A group is (model, targeted task) for task_ids-restricted runs and (model) for unrestricted runs (task_id null). Build boards from `groups`, not from run.models/run.task_ids — a returned run may name models or tasks whose groups it did not rank in. `truncated: true` means a server ceiling trimmed the aggregate; whole runs are kept in (best rank, first model, first task, id) order, so every group's newest runs survive before any group's fallbacks and no group is dropped for being old. Resume a truncated board by passing `next_cursor` back as `cursor` and unioning the responses. See the evals docs for grouping rationale and cost characteristics.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listEvalSuiteLeaderboardRuns" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard-runs" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.listSuiteLeaderboardRuns({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
    model: "meetkai:functionary-urdu-mini-pak",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsListSuiteLeaderboardRuns } from "@meetkai/mka1/funcs/llmEvalsListSuiteLeaderboardRuns.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsListSuiteLeaderboardRuns(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
    model: "meetkai:functionary-urdu-mini-pak",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsListSuiteLeaderboardRuns failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsListSuiteLeaderboardRuns,
  useLlmEvalsListSuiteLeaderboardRunsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsListSuiteLeaderboardRuns,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsListSuiteLeaderboardRuns,
  invalidateAllLlmEvalsListSuiteLeaderboardRuns,
} from "@meetkai/mka1/react-query/llmEvalsListSuiteLeaderboardRuns.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListEvalSuiteLeaderboardRunsRequest](../../models/operations/listevalsuiteleaderboardrunsrequest.md)                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListEvalSuiteLeaderboardRunsResponseBody](../../models/operations/listevalsuiteleaderboardrunsresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getSuiteLeaderboard

Ranks the suite's completed coding-agent runs, one row per (agent, model, effort). Only runs that recorded an `agent_name` participate — a QA or transcription run of the same suite has no agent to attribute a score to and is not a board row. `accuracy` is the mean of `metric` (default `reward`) over the row's scored trials, and `accuracy_ci` is the 95% Wald interval around it; both are derived per request rather than stored, so rerunning a failed trial moves them instead of leaving a stale copy behind. `agent_version` is reported but is not part of the row identity, so an agent upgrade does not split a row in two. Rows are ordered by accuracy descending, nulls last. Pass `suite_version` when the suite has more than one, otherwise the board mixes task sets.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalSuiteLeaderboard" method="get" path="/api/v1/llm/evals/suites/{suite_id}/leaderboard" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getSuiteLeaderboard({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetSuiteLeaderboard } from "@meetkai/mka1/funcs/llmEvalsGetSuiteLeaderboard.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetSuiteLeaderboard(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetSuiteLeaderboard failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetSuiteLeaderboard,
  useLlmEvalsGetSuiteLeaderboardSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetSuiteLeaderboard,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetSuiteLeaderboard,
  invalidateAllLlmEvalsGetSuiteLeaderboard,
} from "@meetkai/mka1/react-query/llmEvalsGetSuiteLeaderboard.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalSuiteLeaderboardRequest](../../models/operations/getevalsuiteleaderboardrequest.md)                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSuiteLeaderboard](../../models/components/evalsuiteleaderboard.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## measureSuiteTokens

Backfill for rows written before the gateway recorded usage. For samples of the suite's completed runs that have answer or reasoning text but no token figure, counts prompt, reasoning and answer tokens from the stored text (tiktoken o200k_base, one ruler for every model), marks them `tokens_estimated`, and refreshes each run's per-task `tokens` and run totals so the leaderboard's efficiency figures appear. Processes `limit` runs per call, oldest run id first; call again until `remaining_runs` is 0. Samples the provider or the import already measured are left alone, and a sample with no text stays unmeasured. New rows get the same figures at generation or import time, so this is a no-op on a suite with nothing to measure.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="measureEvalSuiteTokens" method="post" path="/api/v1/llm/evals/suites/{suite_id}/tokens/measure" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.measureSuiteTokens({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    measureEvalSuiteTokensBody: {},
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsMeasureSuiteTokens } from "@meetkai/mka1/funcs/llmEvalsMeasureSuiteTokens.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsMeasureSuiteTokens(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    measureEvalSuiteTokensBody: {},
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsMeasureSuiteTokens failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsMeasureSuiteTokensMutation
} from "@meetkai/mka1/react-query/llmEvalsMeasureSuiteTokens.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.MeasureEvalSuiteTokensRequest](../../models/operations/measureevalsuitetokensrequest.md)                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSuiteTokenMeasurement](../../models/components/evalsuitetokenmeasurement.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## createRun

Starts a durable eval run over the selected suite version, tasks, and models.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createEvalRun" method="post" path="/api/v1/llm/evals/runs" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.createRun({
    createEvalRunRequest: {
      suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
      models: [
        "auto",
      ],
      judgeModel: "auto",
      embeddingModel: "auto",
      generation: {
        temperature: 0,
        maxGenToks: 512,
        until: [
          "<|endoftext|>",
        ],
        doSample: false,
        chatTemplateKwargs: {
          "enable_thinking": false,
        },
        timeoutSeconds: 120,
        maxRetries: 2,
        maxEmptyRetries: 1,
      },
      generationConcurrency: 4,
      graderConcurrency: 2,
      maxWorkflowSampleActivities: 5000,
      metadata: {
        "purpose": "mvp",
      },
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsCreateRun } from "@meetkai/mka1/funcs/llmEvalsCreateRun.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsCreateRun(sdk, {
    createEvalRunRequest: {
      suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
      models: [
        "auto",
      ],
      judgeModel: "auto",
      embeddingModel: "auto",
      generation: {
        temperature: 0,
        maxGenToks: 512,
        until: [
          "<|endoftext|>",
        ],
        doSample: false,
        chatTemplateKwargs: {
          "enable_thinking": false,
        },
        timeoutSeconds: 120,
        maxRetries: 2,
        maxEmptyRetries: 1,
      },
      generationConcurrency: 4,
      graderConcurrency: 2,
      maxWorkflowSampleActivities: 5000,
      metadata: {
        "purpose": "mvp",
      },
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsCreateRun failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsCreateRunMutation
} from "@meetkai/mka1/react-query/llmEvalsCreateRun.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateEvalRunRequest](../../models/operations/createevalrunrequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateEvalRunResponseBody](../../models/operations/createevalrunresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listRuns

Returns eval runs visible to the authenticated team context. suite_version is a per-suite ordinal and must be paired with suite_id; supplying it alone returns 400.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listEvalRuns" method="get" path="/api/v1/llm/evals/runs" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.listRuns({
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsListRuns } from "@meetkai/mka1/funcs/llmEvalsListRuns.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsListRuns(sdk, {
    suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsListRuns failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsListRuns,
  useLlmEvalsListRunsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsListRuns,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsListRuns,
  invalidateAllLlmEvalsListRuns,
} from "@meetkai/mka1/react-query/llmEvalsListRuns.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListEvalRunsRequest](../../models/operations/listevalrunsrequest.md)                                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListEvalRunsResponseBody](../../models/operations/listevalrunsresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getRun

Retrieves an eval run by ID.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalRun" method="get" path="/api/v1/llm/evals/runs/{run_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getRun({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetRun } from "@meetkai/mka1/funcs/llmEvalsGetRun.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetRun(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetRun failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetRun,
  useLlmEvalsGetRunSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetRun,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetRun,
  invalidateAllLlmEvalsGetRun,
} from "@meetkai/mka1/react-query/llmEvalsGetRun.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalRunRequest](../../models/operations/getevalrunrequest.md)                                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetEvalRunResponseBody](../../models/operations/getevalrunresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## deleteRun

Soft-deletes an eval run so it no longer appears in run lists, details, or score leaderboards.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteEvalRun" method="delete" path="/api/v1/llm/evals/runs/{run_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.deleteRun({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsDeleteRun } from "@meetkai/mka1/funcs/llmEvalsDeleteRun.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsDeleteRun(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsDeleteRun failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsDeleteRunMutation
} from "@meetkai/mka1/react-query/llmEvalsDeleteRun.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteEvalRunRequest](../../models/operations/deleteevalrunrequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalRunDeletedObject](../../models/components/evalrundeletedobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## cancelRun

Requests cancellation for a queued or running eval run.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="cancelEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/cancel" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.cancelRun({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsCancelRun } from "@meetkai/mka1/funcs/llmEvalsCancelRun.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsCancelRun(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsCancelRun failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsCancelRunMutation
} from "@meetkai/mka1/react-query/llmEvalsCancelRun.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CancelEvalRunRequest](../../models/operations/cancelevalrunrequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CancelEvalRunResponseBody](../../models/operations/cancelevalrunresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## rerunFailedSamples

Queues a completed eval run to retry only samples with sample status 'failed'. Retried samples keep the same run ID and sample IDs, replacing errored sample results in place.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="rerunFailedEvalSamples" method="post" path="/api/v1/llm/evals/runs/{run_id}/rerun-failed" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.rerunFailedSamples({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsRerunFailedSamples } from "@meetkai/mka1/funcs/llmEvalsRerunFailedSamples.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsRerunFailedSamples(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsRerunFailedSamples failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsRerunFailedSamplesMutation
} from "@meetkai/mka1/react-query/llmEvalsRerunFailedSamples.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.RerunFailedEvalSamplesRequest](../../models/operations/rerunfailedevalsamplesrequest.md)                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.RerunFailedEvalSamplesResponseBody](../../models/operations/rerunfailedevalsamplesresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## retryFailedRun

Queues a failed or cancelled eval run to retry in place. Completed samples keep their results, generated-but-unscored cancelled samples resume at scoring, unfinished samples are requeued, and runs with no persisted samples are prepared from scratch with the same run ID.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="retryFailedEvalRun" method="post" path="/api/v1/llm/evals/runs/{run_id}/retry" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.retryFailedRun({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsRetryFailedRun } from "@meetkai/mka1/funcs/llmEvalsRetryFailedRun.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsRetryFailedRun(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsRetryFailedRun failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsRetryFailedRunMutation
} from "@meetkai/mka1/react-query/llmEvalsRetryFailedRun.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.RetryFailedEvalRunRequest](../../models/operations/retryfailedevalrunrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.RetryFailedEvalRunResponseBody](../../models/operations/retryfailedevalrunresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getRunOverview

Aggregate header for one run's trials view: trial counts, average reward, cost, and the input/output/cached token split. Its own route rather than fields on the run object because it scans the run's samples — folding it into `GET /evals/runs/{run_id}` would charge that scan to every run list and to the status polling that runs for the whole length of an eval. `trials.errored` overlaps `trials.failed` instead of partitioning it: a coding-agent trial can carry an agent timeout in `error` and still be completed and scored. `trials.retried` counts trials rerun through rerun-failed, read from the pre-rerun snapshot, since a rerun overwrites the sample in place.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalRunOverview" method="get" path="/api/v1/llm/evals/runs/{run_id}/overview" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getRunOverview({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetRunOverview } from "@meetkai/mka1/funcs/llmEvalsGetRunOverview.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetRunOverview(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetRunOverview failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetRunOverview,
  useLlmEvalsGetRunOverviewSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetRunOverview,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetRunOverview,
  invalidateAllLlmEvalsGetRunOverview,
} from "@meetkai/mka1/react-query/llmEvalsGetRunOverview.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalRunOverviewRequest](../../models/operations/getevalrunoverviewrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalRunOverview](../../models/components/evalrunoverview.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listSamples

Returns prompt, target, model output, extraction, score, and judge details for an eval run.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listEvalSamples" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.listSamples({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsListSamples } from "@meetkai/mka1/funcs/llmEvalsListSamples.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsListSamples(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsListSamples failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsListSamples,
  useLlmEvalsListSamplesSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsListSamples,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsListSamples,
  invalidateAllLlmEvalsListSamples,
} from "@meetkai/mka1/react-query/llmEvalsListSamples.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListEvalSamplesRequest](../../models/operations/listevalsamplesrequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSampleList](../../models/components/evalsamplelist.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getSampleAudio

Returns `{ object, audio, sample_index, task_id, model }` for a single transcription sample — the clip reference (a base64 `data:` URI or a URL) read from the un-redacted `dataset_row` (list responses redact inline `data:` blobs), plus the resolved task/model. Prefers the task's configured `audio_column`, falling back to a heuristic scan. The clip differs across tasks, so pass `task_id` when a run has more than one transcription task; if the index spans multiple tasks and `task_id` is omitted, returns 400 rather than guessing. `model` is optional (the clip is identical across models) and only extends the index prefix. Returns 404 when the sample or its audio is absent, 413 when the inline clip is too large. Returns 503 when object storage is briefly unreachable, as distinct from 404 for a clip that is genuinely gone.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalSampleAudio" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/audio" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getSampleAudio({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    sampleIndex: 0,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetSampleAudio } from "@meetkai/mka1/funcs/llmEvalsGetSampleAudio.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetSampleAudio(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    sampleIndex: 0,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetSampleAudio failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetSampleAudio,
  useLlmEvalsGetSampleAudioSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetSampleAudio,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetSampleAudio,
  invalidateAllLlmEvalsGetSampleAudio,
} from "@meetkai/mka1/react-query/llmEvalsGetSampleAudio.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalSampleAudioRequest](../../models/operations/getevalsampleaudiorequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSampleAudioObject](../../models/components/evalsampleaudioobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getSampleTrajectory

Returns one coding-agent trial's session — the steps the agent took, verbatim in the harness's interchange format (see `schema_version`, e.g. `ATIF-v1.7`). Deliberately not part of the samples list: a trajectory averages ~92 KB and that list pages up to 500 rows. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one; an index that matches several trials returns 400 rather than guessing, and never falls back to another trial's session. Returns 404 when the sample does not exist or recorded no trajectory.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalSampleTrajectory" method="get" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getSampleTrajectory({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    sampleIndex: 0,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetSampleTrajectory } from "@meetkai/mka1/funcs/llmEvalsGetSampleTrajectory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetSampleTrajectory(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    sampleIndex: 0,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetSampleTrajectory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetSampleTrajectory,
  useLlmEvalsGetSampleTrajectorySuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetSampleTrajectory,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetSampleTrajectory,
  invalidateAllLlmEvalsGetSampleTrajectory,
} from "@meetkai/mka1/react-query/llmEvalsGetSampleTrajectory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalSampleTrajectoryRequest](../../models/operations/getevalsampletrajectoryrequest.md)                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetEvalSampleTrajectoryResponseBody](../../models/operations/getevalsampletrajectoryresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## uploadSampleTrajectory

Stores one coding-agent trial's session, in whatever interchange format the harness produced (record it in `schema_version`, e.g. `ATIF-v1.7`). `steps` is stored verbatim and never validated, so a harness format change needs no gateway release. Separate from the run import because a trajectory averages ~92 KB and a whole run's worth would not fit in one request. Upserts, so re-sending after a timeout replaces the trajectory rather than failing. Sample indices are unique per (task, model), not per run, so pass `task_id` and/or `model` when the run covers more than one — an ambiguous index returns 400 rather than writing to the wrong trial. Rejects a payload whose `steps` and `logs` together exceed 16 MiB with 413.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="uploadEvalSampleTrajectory" method="put" path="/api/v1/llm/evals/runs/{run_id}/samples/{sample_index}/trajectory" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.uploadSampleTrajectory({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    sampleIndex: 0,
    uploadEvalSampleTrajectoryRequest: {
      steps: [
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
      ],
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsUploadSampleTrajectory } from "@meetkai/mka1/funcs/llmEvalsUploadSampleTrajectory.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsUploadSampleTrajectory(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    sampleIndex: 0,
    uploadEvalSampleTrajectoryRequest: {
      steps: [
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
      ],
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsUploadSampleTrajectory failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsUploadSampleTrajectoryMutation
} from "@meetkai/mka1/react-query/llmEvalsUploadSampleTrajectory.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UploadEvalSampleTrajectoryRequest](../../models/operations/uploadevalsampletrajectoryrequest.md)                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalSampleTrajectoryUploadedObject](../../models/components/evalsampletrajectoryuploadedobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getArtifacts

Returns generated result and sample artifact file IDs for a completed eval run.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalArtifacts" method="get" path="/api/v1/llm/evals/runs/{run_id}/artifacts" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getArtifacts({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetArtifacts } from "@meetkai/mka1/funcs/llmEvalsGetArtifacts.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetArtifacts(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetArtifacts failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetArtifacts,
  useLlmEvalsGetArtifactsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetArtifacts,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetArtifacts,
  invalidateAllLlmEvalsGetArtifacts,
} from "@meetkai/mka1/react-query/llmEvalsGetArtifacts.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalArtifactsRequest](../../models/operations/getevalartifactsrequest.md)                                                                                       | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalArtifactsObject](../../models/components/evalartifactsobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## importAgentRun

Uploads one completed harness job — the run and its trials — directly, so results never round-trip through external storage the way the Hugging Face importer does. Every `task_id` must already exist in the target suite version's manifest; unknown ids are rejected rather than invented, because a typo would otherwise import as a task the suite does not have and read as a model that never covered the version. The run is recorded as `completed` and is not executed: this is a write, not a run request, so no workflow is started. Trials that cover every task of the version get `task_ids: null`, which is what lets the run rank as a complete sweep. Trajectories are NOT part of this payload — a full 91-task run measured 8.3 MB of them — so upload each one against `PUT /evals/runs/{run_id}/samples/{sample_index}/trajectory` afterwards. Pass `idempotency_key` and a retried upload returns the first run instead of doubling the trials behind a board row.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="importAgentEvalRun" method="post" path="/api/v1/llm/evals/imports/agent-run" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.importAgentRun({
    importAgentRunRequest: {
      suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
      suiteVersion: 1,
      agentName: "omp",
      agentVersion: "17.3.8",
      agentEffort: "medium",
      model: "meetkai:functionary-urdu-mini-pak",
      costUsd: 3.77,
      createdAt: 1704067200,
      metadata: {
        "harness": "harbor",
        "benchmark": "terminal-bench-2.1",
      },
      idempotencyKey: "harbor-job-2026-08-23-luna-medium",
      trials: [
        {
          taskId: "fix-permissions",
          sampleIndex: 0,
          prompt: "The test suite fails because the fixture directory is not writable. Fix it.",
          target: "all tests pass",
          outputText: "9 passed in 2.25s",
          scores: {
            "reward": 1,
            "resolved": 1,
          },
          costUsd: 0.0279,
          inputTokens: 658456,
          outputTokens: 6489,
          cachedTokens: 658366,
        },
      ],
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsImportAgentRun } from "@meetkai/mka1/funcs/llmEvalsImportAgentRun.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsImportAgentRun(sdk, {
    importAgentRunRequest: {
      suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
      suiteVersion: 1,
      agentName: "omp",
      agentVersion: "17.3.8",
      agentEffort: "medium",
      model: "meetkai:functionary-urdu-mini-pak",
      costUsd: 3.77,
      createdAt: 1704067200,
      metadata: {
        "harness": "harbor",
        "benchmark": "terminal-bench-2.1",
      },
      idempotencyKey: "harbor-job-2026-08-23-luna-medium",
      trials: [
        {
          taskId: "fix-permissions",
          sampleIndex: 0,
          prompt: "The test suite fails because the fixture directory is not writable. Fix it.",
          target: "all tests pass",
          outputText: "9 passed in 2.25s",
          scores: {
            "reward": 1,
            "resolved": 1,
          },
          costUsd: 0.0279,
          inputTokens: 658456,
          outputTokens: 6489,
          cachedTokens: 658366,
        },
      ],
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsImportAgentRun failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsImportAgentRunMutation
} from "@meetkai/mka1/react-query/llmEvalsImportAgentRun.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ImportAgentEvalRunRequest](../../models/operations/importagentevalrunrequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ImportAgentEvalRunResponseBody](../../models/operations/importagentevalrunresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## appendAgentTrials

Adds finished trials to a run opened with `finalize: false`, so a job started from MKA1 can be watched while it runs instead of appearing complete out of nowhere at the end. Each trial pins its own `sample_index` and upserts on (task, model, sample_index): a harness cannot tell a timeout from a lost response, so re-sending a batch is safe and replaces rather than duplicates. The whole batch and its aggregate recompute land in one transaction, serialized per run. Counts, metrics and cost are recomputed from the stored rows on every call, never accumulated from the request, so a replayed batch cannot double them. Send `finalize: true` (usually with an empty `trials`) to close the run — until then it stays `in_progress` and off the leaderboards, which only count completed runs. Appending to an already-completed or cancelled run is rejected: that record is finished, and rewriting it would silently move a number someone may have already read.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="appendAgentEvalTrials" method="post" path="/api/v1/llm/evals/runs/{run_id}/trials" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.appendAgentTrials({
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    appendAgentTrialsRequest: {
      trials: [
        {
          taskId: "fix-permissions",
          sampleIndex: 0,
          prompt: "The test suite fails because the fixture directory is not writable. Fix it.",
          target: "all tests pass",
          outputText: "9 passed in 2.25s",
          scores: {
            "reward": 1,
            "resolved": 1,
          },
          costUsd: 0.0279,
          inputTokens: 658456,
          outputTokens: 6489,
          cachedTokens: 658366,
        },
      ],
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsAppendAgentTrials } from "@meetkai/mka1/funcs/llmEvalsAppendAgentTrials.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsAppendAgentTrials(sdk, {
    runId: "eval_run_aa87e2b1112a455b8deabed784372198",
    appendAgentTrialsRequest: {
      trials: [
        {
          taskId: "fix-permissions",
          sampleIndex: 0,
          prompt: "The test suite fails because the fixture directory is not writable. Fix it.",
          target: "all tests pass",
          outputText: "9 passed in 2.25s",
          scores: {
            "reward": 1,
            "resolved": 1,
          },
          costUsd: 0.0279,
          inputTokens: 658456,
          outputTokens: 6489,
          cachedTokens: 658366,
        },
      ],
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsAppendAgentTrials failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsAppendAgentTrialsMutation
} from "@meetkai/mka1/react-query/llmEvalsAppendAgentTrials.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.AppendAgentEvalTrialsRequest](../../models/operations/appendagentevaltrialsrequest.md)                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.AppendAgentEvalTrialsResponseBody](../../models/operations/appendagentevaltrialsresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## importHistoricalResults

Imports simplified historical samples.jsonl-style eval results from a Hugging Face dataset repository into a completed eval suite run shape. Aggregates are recomputed from samples and include canonical score metrics for leaderboards.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="importHistoricalEvalResults" method="post" path="/api/v1/llm/evals/imports/huggingface-results" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.importHistoricalResults({
    xHuggingFaceToken: "hf_your_read_token",
    importHistoricalEvalResultsRequest: {
      source: {
        pathPrefix: "functionary/ur/",
      },
      suiteName: "MKA1 historical eval results",
      metadata: {
        "owner": "eval-team",
      },
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsImportHistoricalResults } from "@meetkai/mka1/funcs/llmEvalsImportHistoricalResults.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsImportHistoricalResults(sdk, {
    xHuggingFaceToken: "hf_your_read_token",
    importHistoricalEvalResultsRequest: {
      source: {
        pathPrefix: "functionary/ur/",
      },
      suiteName: "MKA1 historical eval results",
      metadata: {
        "owner": "eval-team",
      },
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsImportHistoricalResults failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsImportHistoricalResultsMutation
} from "@meetkai/mka1/react-query/llmEvalsImportHistoricalResults.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ImportHistoricalEvalResultsRequest](../../models/operations/importhistoricalevalresultsrequest.md)                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalHistoricalImportObject](../../models/components/evalhistoricalimportobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## createSchedule

Schedules an eval run to fire on a cron or interval cadence, with optional webhook notifications of run status.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createEvalSchedule" method="post" path="/api/v1/llm/evals/schedules" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.createSchedule({
    createEvalScheduleRequest: {
      name: "Nightly MMLU regression",
      suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
      cron: "0 3 * * *",
      timezone: "US/Pacific",
      overlapPolicy: "skip",
      webhookUrl: "https://example.com/hooks/evals",
      webhookSecret: "whsec_example_signing_secret",
      run: {
        models: [
          "meetkai/model-a",
        ],
      },
      metadata: {
        "team": "eval-ops",
      },
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsCreateSchedule } from "@meetkai/mka1/funcs/llmEvalsCreateSchedule.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsCreateSchedule(sdk, {
    createEvalScheduleRequest: {
      name: "Nightly MMLU regression",
      suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
      cron: "0 3 * * *",
      timezone: "US/Pacific",
      overlapPolicy: "skip",
      webhookUrl: "https://example.com/hooks/evals",
      webhookSecret: "whsec_example_signing_secret",
      run: {
        models: [
          "meetkai/model-a",
        ],
      },
      metadata: {
        "team": "eval-ops",
      },
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsCreateSchedule failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsCreateScheduleMutation
} from "@meetkai/mka1/react-query/llmEvalsCreateSchedule.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateEvalScheduleRequest](../../models/operations/createevalschedulerequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateEvalScheduleResponseBody](../../models/operations/createevalscheduleresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listSchedules

Returns eval schedules visible to the authenticated team context.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listEvalSchedules" method="get" path="/api/v1/llm/evals/schedules" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.listSchedules({});

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsListSchedules } from "@meetkai/mka1/funcs/llmEvalsListSchedules.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsListSchedules(sdk, {});
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsListSchedules failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsListSchedules,
  useLlmEvalsListSchedulesSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsListSchedules,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsListSchedules,
  invalidateAllLlmEvalsListSchedules,
} from "@meetkai/mka1/react-query/llmEvalsListSchedules.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListEvalSchedulesRequest](../../models/operations/listevalschedulesrequest.md)                                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListEvalSchedulesResponseBody](../../models/operations/listevalschedulesresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## getSchedule

Retrieves an eval schedule by ID, including the next scheduled fire time from Temporal when resolvable.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEvalSchedule" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.getSchedule({
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsGetSchedule } from "@meetkai/mka1/funcs/llmEvalsGetSchedule.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsGetSchedule(sdk, {
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsGetSchedule failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsGetSchedule,
  useLlmEvalsGetScheduleSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsGetSchedule,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsGetSchedule,
  invalidateAllLlmEvalsGetSchedule,
} from "@meetkai/mka1/react-query/llmEvalsGetSchedule.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEvalScheduleRequest](../../models/operations/getevalschedulerequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetEvalScheduleResponseBody](../../models/operations/getevalscheduleresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## updateSchedule

Updates an eval schedule's cadence, run config, webhook, overlap policy, or enabled state.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateEvalSchedule" method="patch" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.updateSchedule({
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
    updateEvalScheduleRequest: {
      enabled: false,
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsUpdateSchedule } from "@meetkai/mka1/funcs/llmEvalsUpdateSchedule.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsUpdateSchedule(sdk, {
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
    updateEvalScheduleRequest: {
      enabled: false,
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsUpdateSchedule failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsUpdateScheduleMutation
} from "@meetkai/mka1/react-query/llmEvalsUpdateSchedule.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateEvalScheduleRequest](../../models/operations/updateevalschedulerequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UpdateEvalScheduleResponseBody](../../models/operations/updateevalscheduleresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## deleteSchedule

Soft-deletes an eval schedule and removes its Temporal schedule. Historical runs are preserved.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteEvalSchedule" method="delete" path="/api/v1/llm/evals/schedules/{schedule_id}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.deleteSchedule({
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsDeleteSchedule } from "@meetkai/mka1/funcs/llmEvalsDeleteSchedule.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsDeleteSchedule(sdk, {
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsDeleteSchedule failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsDeleteScheduleMutation
} from "@meetkai/mka1/react-query/llmEvalsDeleteSchedule.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteEvalScheduleRequest](../../models/operations/deleteevalschedulerequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.EvalScheduleDeletedObject](../../models/components/evalscheduledeletedobject.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## triggerSchedule

Fires the schedule immediately, in addition to its normal cadence.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="triggerEvalSchedule" method="post" path="/api/v1/llm/evals/schedules/{schedule_id}/trigger" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.triggerSchedule({
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsTriggerSchedule } from "@meetkai/mka1/funcs/llmEvalsTriggerSchedule.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsTriggerSchedule(sdk, {
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsTriggerSchedule failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useLlmEvalsTriggerScheduleMutation
} from "@meetkai/mka1/react-query/llmEvalsTriggerSchedule.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.TriggerEvalScheduleRequest](../../models/operations/triggerevalschedulerequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.TriggerEvalScheduleResponseBody](../../models/operations/triggerevalscheduleresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## listScheduleRuns

Returns eval runs that were created by the given schedule. suite_version may be used without suite_id here, since the schedule already pins the suite; supplying a suite_id that is not the schedule's returns 400.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listEvalScheduleRuns" method="get" path="/api/v1/llm/evals/schedules/{schedule_id}/runs" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.evals.listScheduleRuns({
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmEvalsListScheduleRuns } from "@meetkai/mka1/funcs/llmEvalsListScheduleRuns.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmEvalsListScheduleRuns(sdk, {
    scheduleId: "eval_sched_aa87e2b1112a455b8deabed784372198",
    suiteVersion: 1,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmEvalsListScheduleRuns failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useLlmEvalsListScheduleRuns,
  useLlmEvalsListScheduleRunsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmEvalsListScheduleRuns,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmEvalsListScheduleRuns,
  invalidateAllLlmEvalsListScheduleRuns,
} from "@meetkai/mka1/react-query/llmEvalsListScheduleRuns.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListEvalScheduleRunsRequest](../../models/operations/listevalschedulerunsrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListEvalScheduleRunsResponseBody](../../models/operations/listevalschedulerunsresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |