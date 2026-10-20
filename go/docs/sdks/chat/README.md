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

<!-- UsageSnippet language="go" operationID="createChatCompletion" method="post" path="/api/v1/llm/chat/completions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Chat.CreateChat(ctx, components.OpenAIChatCompletionRequestParams{
        Model: "meetkai:functionary-urdu-mini-pak",
        Messages: []components.OpenAIRequestMessage{
            components.OpenAIRequestMessage{
                Role: components.OpenAIRequestMessageRoleUser,
                Content: mka1.Pointer(components.CreateOpenAIRequestMessageContentUnion2Str(
                    "What is the capital of France?",
                )),
            },
        },
        MaxTokens: optionalnullable.From(mka1.Pointer[int64](100)),
        Temperature: mka1.Pointer[float64](0.7),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.OpenAIChatCompletion != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                                | Type                                                                                                                                                                     | Required                                                                                                                                                                 | Description                                                                                                                                                              | Example                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                                                                                    | :heavy_check_mark:                                                                                                                                                       | The context to use for the request.                                                                                                                                      |                                                                                                                                                                          |
| `body`                                                                                                                                                                   | [components.OpenAIChatCompletionRequestParams](../../models/components/openaichatcompletionrequestparams.md)                                                             | :heavy_check_mark:                                                                                                                                                       | N/A                                                                                                                                                                      | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"messages": [<br/>{<br/>"role": "user",<br/>"content": "What is the capital of France?"<br/>}<br/>],<br/>"temperature": 0.7,<br/>"max_tokens": 100<br/>} |
| `xOnBehalfOf`                                                                                                                                                            | `*string`                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                                                      |                                                                                                                                                                          |
| `opts`                                                                                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                                                                                 | :heavy_minus_sign:                                                                                                                                                       | The options for this request.                                                                                                                                            |                                                                                                                                                                          |

### Response

**[*operations.CreateChatCompletionResponse](../../models/operations/createchatcompletionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ~~Stream~~

**Deprecated: Use the Responses API (`/api/v1/llm/responses`) instead.** Streaming chat completion endpoint designed for use with the generated TypeScript/JavaScript SDK from the OpenAPI specification. This endpoint uses ORPC's native streaming via async generators and returns Server-Sent Events (SSE) formatted as structured JSON chunks. Unlike the OpenAI client endpoint, this provides better type safety and integration with the generated SDK. Use this endpoint when working with the auto-generated API client for type-safe streaming responses. The endpoint supports response caching, request resumption via `x-last-chunk-index` header, and automatic usage tracking.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="go" operationID="createChatCompletionStream" method="post" path="/api/v1/llm/chat/completions/stream" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Chat.Stream(ctx, components.OpenAIChatCompletionRequestParams{
        Model: "meetkai:functionary-urdu-mini-pak",
        Messages: []components.OpenAIRequestMessage{
            components.OpenAIRequestMessage{
                Role: components.OpenAIRequestMessageRoleUser,
                Content: mka1.Pointer(components.CreateOpenAIRequestMessageContentUnion2Str(
                    "What is the capital of France?",
                )),
            },
        },
        MaxTokens: optionalnullable.From(mka1.Pointer[int64](100)),
        Temperature: mka1.Pointer[float64](0.7),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.OneOf != nil {
        defer res.OneOf.Close()

        for res.OneOf.Next() {
            event := res.OneOf.Value()
            log.Print(event)
            // Handle the event
	      }
    }
}
```

### Parameters

| Parameter                                                                                                                                                                | Type                                                                                                                                                                     | Required                                                                                                                                                                 | Description                                                                                                                                                              | Example                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                                                                                    | :heavy_check_mark:                                                                                                                                                       | The context to use for the request.                                                                                                                                      |                                                                                                                                                                          |
| `body`                                                                                                                                                                   | [components.OpenAIChatCompletionRequestParams](../../models/components/openaichatcompletionrequestparams.md)                                                             | :heavy_check_mark:                                                                                                                                                       | N/A                                                                                                                                                                      | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"messages": [<br/>{<br/>"role": "user",<br/>"content": "What is the capital of France?"<br/>}<br/>],<br/>"temperature": 0.7,<br/>"max_tokens": 100<br/>} |
| `xOnBehalfOf`                                                                                                                                                            | `*string`                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                                                      |                                                                                                                                                                          |
| `opts`                                                                                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                                                                                 | :heavy_minus_sign:                                                                                                                                                       | The options for this request.                                                                                                                                            |                                                                                                                                                                          |

### Response

**[*operations.CreateChatCompletionStreamResponse](../../models/operations/createchatcompletionstreamresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |