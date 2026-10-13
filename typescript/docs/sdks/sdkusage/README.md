# Llm.Usage

## Overview

### Available Operations

* [completions](#completions) - Get completions usage
* [responses](#responses) - Get responses usage
* [conversations](#conversations) - Get conversations usage
* [embeddings](#embeddings) - Get embeddings usage
* [extract](#extract) - Get extract usage
* [classify](#classify) - Get classify usage
* [vectorStores](#vectorstores) - Get vector stores usage
* [files](#files) - Get files usage
* [costs](#costs) - Get cost by model

## completions

Retrieve usage metrics for chat completions, aggregated from the ChatCompletion table.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getCompletionsUsage" method="get" path="/api/v1/llm/usage/completions" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.completions({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageCompletions } from "@meetkai/mka1/funcs/llmUsageCompletions.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageCompletions(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageCompletions failed:", res.error);
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
  useLlmUsageCompletions,
  useLlmUsageCompletionsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageCompletions,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageCompletions,
  invalidateAllLlmUsageCompletions,
} from "@meetkai/mka1/react-query/llmUsageCompletions.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetCompletionsUsageRequest](../../models/operations/getcompletionsusagerequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetCompletionsUsageResponseBody](../../models/operations/getcompletionsusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## responses

Retrieve usage metrics for agent responses, aggregated from the Response table.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getResponsesUsage" method="get" path="/api/v1/llm/usage/responses" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.responses({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
      "background",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
    background: false,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageResponses } from "@meetkai/mka1/funcs/llmUsageResponses.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageResponses(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
      "background",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
    background: false,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageResponses failed:", res.error);
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
  useLlmUsageResponses,
  useLlmUsageResponsesSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageResponses,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageResponses,
  invalidateAllLlmUsageResponses,
} from "@meetkai/mka1/react-query/llmUsageResponses.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetResponsesUsageRequest](../../models/operations/getresponsesusagerequest.md)                                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetResponsesUsageResponseBody](../../models/operations/getresponsesusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## conversations

Retrieve usage metrics for conversation operations.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getConversationsUsage" method="get" path="/api/v1/llm/usage/conversations" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.conversations({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "user_id",
    ],
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageConversations } from "@meetkai/mka1/funcs/llmUsageConversations.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageConversations(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "user_id",
    ],
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageConversations failed:", res.error);
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
  useLlmUsageConversations,
  useLlmUsageConversationsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageConversations,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageConversations,
  invalidateAllLlmUsageConversations,
} from "@meetkai/mka1/react-query/llmUsageConversations.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetConversationsUsageRequest](../../models/operations/getconversationsusagerequest.md)                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetConversationsUsageResponseBody](../../models/operations/getconversationsusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## embeddings

Retrieve usage metrics for embedding operations.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getEmbeddingsUsage" method="get" path="/api/v1/llm/usage/embeddings" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.embeddings({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "auto",
    ],
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageEmbeddings } from "@meetkai/mka1/funcs/llmUsageEmbeddings.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageEmbeddings(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "auto",
    ],
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageEmbeddings failed:", res.error);
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
  useLlmUsageEmbeddings,
  useLlmUsageEmbeddingsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageEmbeddings,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageEmbeddings,
  invalidateAllLlmUsageEmbeddings,
} from "@meetkai/mka1/react-query/llmUsageEmbeddings.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetEmbeddingsUsageRequest](../../models/operations/getembeddingsusagerequest.md)                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetEmbeddingsUsageResponseBody](../../models/operations/getembeddingsusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## extract

Retrieve usage metrics for extract operations.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getExtractUsage" method="get" path="/api/v1/llm/usage/extract" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.extract({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageExtract } from "@meetkai/mka1/funcs/llmUsageExtract.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageExtract(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageExtract failed:", res.error);
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
  useLlmUsageExtract,
  useLlmUsageExtractSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageExtract,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageExtract,
  invalidateAllLlmUsageExtract,
} from "@meetkai/mka1/react-query/llmUsageExtract.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetExtractUsageRequest](../../models/operations/getextractusagerequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetExtractUsageResponseBody](../../models/operations/getextractusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## classify

Retrieve usage metrics for classify operations.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getClassifyUsage" method="get" path="/api/v1/llm/usage/classify" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.classify({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageClassify } from "@meetkai/mka1/funcs/llmUsageClassify.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageClassify(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "model",
    ],
    models: [
      "meetkai:functionary-urdu-mini-pak",
    ],
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageClassify failed:", res.error);
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
  useLlmUsageClassify,
  useLlmUsageClassifySuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageClassify,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageClassify,
  invalidateAllLlmUsageClassify,
} from "@meetkai/mka1/react-query/llmUsageClassify.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetClassifyUsageRequest](../../models/operations/getclassifyusagerequest.md)                                                                                       | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetClassifyUsageResponseBody](../../models/operations/getclassifyusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## vectorStores

Retrieve usage metrics for vector storage operations.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getVectorStoresUsage" method="get" path="/api/v1/llm/usage/vector_stores" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.vectorStores({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "user_id",
    ],
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageVectorStores } from "@meetkai/mka1/funcs/llmUsageVectorStores.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageVectorStores(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "user_id",
    ],
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageVectorStores failed:", res.error);
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
  useLlmUsageVectorStores,
  useLlmUsageVectorStoresSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageVectorStores,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageVectorStores,
  invalidateAllLlmUsageVectorStores,
} from "@meetkai/mka1/react-query/llmUsageVectorStores.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetVectorStoresUsageRequest](../../models/operations/getvectorstoresusagerequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetVectorStoresUsageResponseBody](../../models/operations/getvectorstoresusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## files

Retrieve bytes of files created per period from durable file creation events. This does not reflect current retained storage, buckets remain counted after file deletion, and grouped results collapse by requested output dimensions rather than one row per UserContext.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getFilesUsage" method="get" path="/api/v1/llm/usage/files" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.files({
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "user_id",
    ],
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageFiles } from "@meetkai/mka1/funcs/llmUsageFiles.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageFiles(sdk, {
    startTime: 1704067200,
    endTime: 1704153600,
    limit: 30,
    page: "cursor_abc123",
    userIds: [
      "user_123",
      "user_456",
    ],
    externalUserIds: [
      "sub_123",
    ],
    orgIds: [
      "org_123",
    ],
    groupBy: [
      "user_id",
    ],
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageFiles failed:", res.error);
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
  useLlmUsageFiles,
  useLlmUsageFilesSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageFiles,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageFiles,
  invalidateAllLlmUsageFiles,
} from "@meetkai/mka1/react-query/llmUsageFiles.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetFilesUsageRequest](../../models/operations/getfilesusagerequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetFilesUsageResponseBody](../../models/operations/getfilesusageresponsebody.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## costs

Aggregates spend by model over a time range, priced in the cluster currency from the model price book. Org-scoped: org admins see their org; cluster admins may pass `org_id`. Includes billable work with no usage row of its own (store=false responses, agent tool calls), so totals cover all LLM spend. Platform-wide, cross-service cost reporting lives in the budgeting API (/api/v1/budgeting/usage/costs).

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getCostsUsage" method="get" path="/api/v1/llm/usage/costs" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.usage.costs({
    startTime: 612474,
    endTime: 211313,
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmUsageCosts } from "@meetkai/mka1/funcs/llmUsageCosts.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmUsageCosts(sdk, {
    startTime: 612474,
    endTime: 211313,
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmUsageCosts failed:", res.error);
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
  useLlmUsageCosts,
  useLlmUsageCostsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchLlmUsageCosts,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateLlmUsageCosts,
  invalidateAllLlmUsageCosts,
} from "@meetkai/mka1/react-query/llmUsageCosts.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetCostsUsageRequest](../../models/operations/getcostsusagerequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.UsageCostsResponse](../../models/components/usagecostsresponse.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |