# ~~Llm.Chat~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~createChat~~](#createchat) - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
* [~~stream~~](#stream) - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**

## ~~createChat~~

**Deprecated: Use the Responses API (`/api/v1/llm/responses`) instead.** OpenAI-compatible chat completion endpoint designed for use with the official OpenAI client libraries (Python, Node.js, etc.). Supports both streaming and non-streaming requests by setting the `stream` parameter. This endpoint handles the request/response directly and returns standard OpenAI-formatted responses. Use this when integrating with existing OpenAI client code. Note: The actual handler is registered at the Bun server level for optimal performance with the OpenAI SDK streaming format.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createChatCompletion" method="post" path="/api/v1/llm/chat/completions" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.chat.createChat({
    openAIChatCompletionRequestParams: {
      model: "meetkai:functionary-urdu-mini-pak",
      messages: [
        {
          role: "user",
          content: "What is the capital of France?",
        },
      ],
      maxTokens: 100,
      temperature: 0.7,
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
import { llmChatCreateChat } from "@meetkai/mka1/funcs/llmChatCreateChat.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmChatCreateChat(sdk, {
    openAIChatCompletionRequestParams: {
      model: "meetkai:functionary-urdu-mini-pak",
      messages: [
        {
          role: "user",
          content: "What is the capital of France?",
        },
      ],
      maxTokens: 100,
      temperature: 0.7,
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("llmChatCreateChat failed:", res.error);
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
  useLlmChatCreateChatMutation
} from "@meetkai/mka1/react-query/llmChatCreateChat.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateChatCompletionRequest](../../models/operations/createchatcompletionrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateChatCompletionResponse](../../models/operations/createchatcompletionresponse.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |

## ~~stream~~

**Deprecated: Use the Responses API (`/api/v1/llm/responses`) instead.** Streaming chat completion endpoint designed for use with the generated TypeScript/JavaScript SDK from the OpenAPI specification. This endpoint uses ORPC's native streaming via async generators and returns Server-Sent Events (SSE) formatted as structured JSON chunks. Unlike the OpenAI client endpoint, this provides better type safety and integration with the generated SDK. Use this endpoint when working with the auto-generated API client for type-safe streaming responses. The endpoint supports response caching, request resumption via `x-last-chunk-index` header, and automatic usage tracking.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createChatCompletionStream" method="post" path="/api/v1/llm/chat/completions/stream" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.chat.stream({
    openAIChatCompletionRequestParams: {
      model: "meetkai:functionary-urdu-mini-pak",
      messages: [
        {
          role: "user",
          content: "What is the capital of France?",
        },
      ],
      maxTokens: 100,
      temperature: 0.7,
    },
  });

  for await (const event of result) {
    console.log(event);
  }
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { llmChatStream } from "@meetkai/mka1/funcs/llmChatStream.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await llmChatStream(sdk, {
    openAIChatCompletionRequestParams: {
      model: "meetkai:functionary-urdu-mini-pak",
      messages: [
        {
          role: "user",
          content: "What is the capital of France?",
        },
      ],
      maxTokens: 100,
      temperature: 0.7,
    },
  });
  if (res.ok) {
    const { value: result } = res;
    for await (const event of result) {
    console.log(event);
  }
  } else {
    console.log("llmChatStream failed:", res.error);
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
  useLlmChatStreamMutation
} from "@meetkai/mka1/react-query/llmChatStream.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateChatCompletionStreamRequest](../../models/operations/createchatcompletionstreamrequest.md)                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[EventStream<operations.CreateChatCompletionStreamResponseBody>](../../models/.md)\>**

### Errors

| Error Type      | Status Code     | Content Type    |
| --------------- | --------------- | --------------- |
| errors.APIError | 4XX, 5XX        | \*/\*           |