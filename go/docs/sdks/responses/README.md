# Llm.Responses

## Overview

### Available Operations

* [Create](#create) - Create an agent-powered response with tool support
* [List](#list) - List all responses with pagination
* [Get](#get) - Retrieve response by ID with status and results
* [Update](#update) - Update a response
* [Delete](#delete) - Permanently delete a response and its data
* [Cancel](#cancel) - Cancel an in-progress background response
* [Wake](#wake) - Wake a sleeping background response
* [ListInputItems](#listinputitems) - List paginated input items for a response
* [Compact](#compact) - Compact a conversation

## Create

Creates a new AI agent response using advanced language models with autonomous tool usage capabilities.

### Example Usage

<!-- UsageSnippet language="go" operationID="createResponse" method="post" path="/api/v1/llm/responses" -->
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

    res, err := s.Llm.Responses.Create(ctx, components.ResponsesCreateRequest{
        Model: "meetkai:functionary-urdu-mini-pak",
        Input: mka1.Pointer(components.CreateResponsesCreateRequestInputStr(
            "What is the capital of France?",
        )),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseObject != nil {
        defer res.Object.Close()

        for res.Object.Next() {
            event := res.Object.Value()
            log.Print(event)
            // Handle the event
	      }
    }
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                                        | :heavy_check_mark:                                                                                           | The context to use for the request.                                                                          |                                                                                                              |
| `body`                                                                                                       | [components.ResponsesCreateRequest](../../models/components/responsescreaterequest.md)                       | :heavy_check_mark:                                                                                           | N/A                                                                                                          | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"input": "What is the capital of France?",<br/>"stream": false<br/>} |
| `xOnBehalfOf`                                                                                                | `*string`                                                                                                    | :heavy_minus_sign:                                                                                           | Optional external end-user identifier forwarded by the API gateway.                                          |                                                                                                              |
| `opts`                                                                                                       | [][operations.Option](../../models/operations/option.md)                                                     | :heavy_minus_sign:                                                                                           | The options for this request.                                                                                |                                                                                                              |

### Response

**[*operations.CreateResponseResponse](../../models/operations/createresponseresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Retrieves a paginated list of all agent responses for the authenticated user.

### Example Usage

<!-- UsageSnippet language="go" operationID="listResponses" method="get" path="/api/v1/llm/responses" -->
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

    res, err := s.Llm.Responses.List(ctx, operations.ListResponsesRequest{
        After: mka1.Pointer("resp_abc123"),
        Before: mka1.Pointer("resp_xyz789"),
        Limit: mka1.Pointer[int64](25),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseListObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `request`                                                                          | [operations.ListResponsesRequest](../../models/operations/listresponsesrequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.ListResponsesResponse](../../models/operations/listresponsesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Retrieves a previously created agent response by its unique ID. When stream=true, returns Server-Sent Events for real-time updates on in-progress background responses.

### Example Usage

<!-- UsageSnippet language="go" operationID="getResponse" method="get" path="/api/v1/llm/responses/{response_id}" -->
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

    res, err := s.Llm.Responses.Get(ctx, operations.GetResponseRequest{
        ResponseID: "resp_get123",
        Include: []operations.GetResponseInclude{
            operations.GetResponseIncludeFileSearchCallResults,
            operations.GetResponseIncludeMessageOutputTextLogprobs,
        },
        IncludeObfuscation: mka1.Pointer(false),
        StartingAfter: mka1.Pointer[int64](42),
        Stream: mka1.Pointer(false),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseObject != nil {
        defer res.Object.Close()

        for res.Object.Next() {
            event := res.Object.Value()
            log.Print(event)
            // Handle the event
	      }
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |
| `request`                                                                      | [operations.GetResponseRequest](../../models/operations/getresponserequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |

### Response

**[*operations.GetResponseResponse](../../models/operations/getresponseresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Update a response's metadata.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateResponse" method="post" path="/api/v1/llm/responses/{response_id}" -->
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

    res, err := s.Llm.Responses.Update(ctx, "resp_abc123", components.UpdateResponseRequest{
        Metadata: map[string]string{
            "status": "reviewed",
            "reviewer": "john_doe",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseObject != nil {
        switch res.ResponseObject.Instructions.Type {
            case components.InstructionsTypeStr:
                // res.ResponseObject.Instructions.Str is populated
            case components.InstructionsTypeArrayOfItem:
                // res.ResponseObject.Instructions.ArrayOfItem is populated
            default:
                // Unknown type - use res.ResponseObject.Instructions.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          | Example                                                                              |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ctx`                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                | :heavy_check_mark:                                                                   | The context to use for the request.                                                  |                                                                                      |
| `responseID`                                                                         | `string`                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  | resp_abc123                                                                          |
| `body`                                                                               | [components.UpdateResponseRequest](../../models/components/updateresponserequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  | {<br/>"metadata": {<br/>"status": "reviewed",<br/>"reviewer": "john_doe"<br/>}<br/>} |
| `xOnBehalfOf`                                                                        | `*string`                                                                            | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |                                                                                      |
| `opts`                                                                               | [][operations.Option](../../models/operations/option.md)                             | :heavy_minus_sign:                                                                   | The options for this request.                                                        |                                                                                      |

### Response

**[*operations.UpdateResponseResponse](../../models/operations/updateresponseresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Permanently deletes an agent response and all associated data.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteResponse" method="delete" path="/api/v1/llm/responses/{response_id}" -->
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

    res, err := s.Llm.Responses.Delete(ctx, "resp_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.DeleteResponseObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `responseID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp_abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteResponseResponse](../../models/operations/deleteresponseresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Cancel

Cancels an agent response that is currently processing in the background.

### Example Usage

<!-- UsageSnippet language="go" operationID="cancelResponse" method="post" path="/api/v1/llm/responses/{response_id}/cancel" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Responses.Cancel(ctx, "resp_cancel123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseObject != nil {
        switch res.ResponseObject.Instructions.Type {
            case components.InstructionsTypeStr:
                // res.ResponseObject.Instructions.Str is populated
            case components.InstructionsTypeArrayOfItem:
                // res.ResponseObject.Instructions.ArrayOfItem is populated
            default:
                // Unknown type - use res.ResponseObject.Instructions.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `responseID`                                                        | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp_cancel123                                                      |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.CancelResponseResponse](../../models/operations/cancelresponseresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Wake

Interrupts a short sleep tool call on an in-progress background response by providing follow-up input. Wake delivery is polled by the sleeping agent and may take up to one second.

### Example Usage

<!-- UsageSnippet language="go" operationID="wakeResponse" method="post" path="/api/v1/llm/responses/{response_id}/wake" -->
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

    res, err := s.Llm.Responses.Wake(ctx, "resp_sleep123", operations.WakeResponseRequestBody{
        Input: "I have more context now; resume immediately.",
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

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |                                                                                          |
| `responseID`                                                                             | `string`                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | resp_sleep123                                                                            |
| `body`                                                                                   | [operations.WakeResponseRequestBody](../../models/operations/wakeresponserequestbody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |                                                                                          |

### Response

**[*operations.WakeResponseResponse](../../models/operations/wakeresponseresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListInputItems

Retrieves a paginated list of all input items provided when creating the specified agent response.

### Example Usage

<!-- UsageSnippet language="go" operationID="listInputItems" method="get" path="/api/v1/llm/responses/{response_id}/input_items" -->
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

    res, err := s.Llm.Responses.ListInputItems(ctx, operations.ListInputItemsRequest{
        ResponseID: "resp_abc123",
        After: mka1.Pointer("item_abc123"),
        Include: []operations.ListInputItemsInclude{
            operations.ListInputItemsIncludeFileSearchCallResults,
        },
        Limit: mka1.Pointer[int64](50),
        Order: operations.ListInputItemsOrderAsc.ToPointer(),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.InputItemListObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ctx`                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                | :heavy_check_mark:                                                                   | The context to use for the request.                                                  |
| `request`                                                                            | [operations.ListInputItemsRequest](../../models/operations/listinputitemsrequest.md) | :heavy_check_mark:                                                                   | The request object to use for the request.                                           |
| `opts`                                                                               | [][operations.Option](../../models/operations/option.md)                             | :heavy_minus_sign:                                                                   | The options for this request.                                                        |

### Response

**[*operations.ListInputItemsResponse](../../models/operations/listinputitemsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Compact

Creates a compacted summary of the conversation history for a response, reducing context size while preserving key information. Returns a compacted response object.

### Example Usage

<!-- UsageSnippet language="go" operationID="compactResponse" method="post" path="/api/v1/llm/responses/compact" -->
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

    res, err := s.Llm.Responses.Compact(ctx, components.CompactResponseRequest{
        Model: "meetkai:functionary-urdu-mini-pak",
        PreviousResponseID: mka1.Pointer("resp_abc123"),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CompactedResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `body`                                                                                 | [components.CompactResponseRequest](../../models/components/compactresponserequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.CompactResponseResponse](../../models/operations/compactresponseresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |