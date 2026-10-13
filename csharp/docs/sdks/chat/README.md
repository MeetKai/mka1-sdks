# ~~Llm.Chat~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~CreateChat~~](#createchat) - [Deprecated] Chat completions for OpenAI SDK/client usage :warning: **Deprecated**
* [~~Stream~~](#stream) - [Deprecated] Streaming chat completions for generated SDK usage :warning: **Deprecated**

## ~~CreateChat~~

**Deprecated: Use the Responses API (`/api/v1/llm/responses`) instead.** OpenAI-compatible chat completion endpoint designed for use with the official OpenAI client libraries (Python, Node.js, etc.). Supports both streaming and non-streaming requests by setting the `stream` parameter. This endpoint handles the request/response directly and returns standard OpenAI-formatted responses. Use this when integrating with existing OpenAI client code. Note: The actual handler is registered at the Bun server level for optimal performance with the OpenAI SDK streaming format.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createChatCompletion" method="post" path="/api/v1/llm/chat/completions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Chat.CreateChatAsync(body: new OpenAIChatCompletionRequestParams() {
    Model = "meetkai:functionary-urdu-mini-pak",
    Messages = new List<OpenAIRequestMessage>() {
        new OpenAIRequestMessage() {
            Role = OpenAIRequestMessageRole.User,
            Content = OpenAIRequestMessageContentUnion2.CreateStr(
                "What is the capital of France?"
            ),
        },
    },
    MaxTokens = 100,
    Temperature = 0.7D,
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                                | Type                                                                                                                                                                     | Required                                                                                                                                                                 | Description                                                                                                                                                              | Example                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Body`                                                                                                                                                                   | [OpenAIChatCompletionRequestParams](../../Types/Components/OpenAIChatCompletionRequestParams.md)                                                                         | :heavy_check_mark:                                                                                                                                                       | N/A                                                                                                                                                                      | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"messages": [<br/>{<br/>"role": "user",<br/>"content": "What is the capital of France?"<br/>}<br/>],<br/>"temperature": 0.7,<br/>"max_tokens": 100<br/>} |
| `XOnBehalfOf`                                                                                                                                                            | *string*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                                                      |                                                                                                                                                                          |

### Response

**[CreateChatCompletionResponse](../../Types/Requests/CreateChatCompletionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ~~Stream~~

**Deprecated: Use the Responses API (`/api/v1/llm/responses`) instead.** Streaming chat completion endpoint designed for use with the generated TypeScript/JavaScript SDK from the OpenAPI specification. This endpoint uses ORPC's native streaming via async generators and returns Server-Sent Events (SSE) formatted as structured JSON chunks. Unlike the OpenAI client endpoint, this provides better type safety and integration with the generated SDK. Use this endpoint when working with the auto-generated API client for type-safe streaming responses. The endpoint supports response caching, request resumption via `x-last-chunk-index` header, and automatic usage tracking.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createChatCompletionStream" method="post" path="/api/v1/llm/chat/completions/stream" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Chat.StreamAsync(body: new OpenAIChatCompletionRequestParams() {
    Model = "meetkai:functionary-urdu-mini-pak",
    Messages = new List<OpenAIRequestMessage>() {
        new OpenAIRequestMessage() {
            Role = OpenAIRequestMessageRole.User,
            Content = OpenAIRequestMessageContentUnion2.CreateStr(
                "What is the capital of France?"
            ),
        },
    },
    MaxTokens = 100,
    Temperature = 0.7D,
});

await foreach (CreateChatCompletionStreamResponseBody eventData in res.OneOf!)
{
    // handle eventData
}
```

### Parameters

| Parameter                                                                                                                                                                | Type                                                                                                                                                                     | Required                                                                                                                                                                 | Description                                                                                                                                                              | Example                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Body`                                                                                                                                                                   | [OpenAIChatCompletionRequestParams](../../Types/Components/OpenAIChatCompletionRequestParams.md)                                                                         | :heavy_check_mark:                                                                                                                                                       | N/A                                                                                                                                                                      | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"messages": [<br/>{<br/>"role": "user",<br/>"content": "What is the capital of France?"<br/>}<br/>],<br/>"temperature": 0.7,<br/>"max_tokens": 100<br/>} |
| `XOnBehalfOf`                                                                                                                                                            | *string*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                                                      |                                                                                                                                                                          |

### Response

**[CreateChatCompletionStreamResponse](../../Types/Requests/CreateChatCompletionStreamResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |