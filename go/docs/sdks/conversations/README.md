# Llm.Conversations

## Overview

### Available Operations

* [Create](#create) - Create a conversation
* [List](#list) - List conversations
* [Get](#get) - Retrieve a conversation
* [Update](#update) - Update a conversation
* [Delete](#delete) - Delete a conversation
* [ListItems](#listitems) - List conversation items
* [CreateItems](#createitems) - Create conversation items
* [DeleteItems](#deleteitems) - Delete multiple conversation items
* [GetItem](#getitem) - Retrieve a conversation item
* [DeleteItem](#deleteitem) - Delete a conversation item

## Create

Create a conversation to store and retrieve conversation state across Response API calls.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.create" method="post" path="/api/v1/llm/conversations" -->
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

    res, err := s.Llm.Conversations.Create(ctx, components.CreateConversationRequest{
        Metadata: map[string]string{
            "session_id": "sess_abc123",
            "user_type": "premium",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConversationObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  | Example                                                                                      |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |                                                                                              |
| `body`                                                                                       | [components.CreateConversationRequest](../../models/components/createconversationrequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          | {<br/>"metadata": {<br/>"session_id": "abc123",<br/>"user_type": "premium"<br/>}<br/>}       |
| `xOnBehalfOf`                                                                                | `*string`                                                                                    | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |                                                                                              |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |                                                                                              |

### Response

**[*operations.ConversationsCreateResponse](../../models/operations/conversationscreateresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

List all conversations for the authenticated user with pagination support.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.list" method="get" path="/api/v1/llm/conversations" -->
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

    res, err := s.Llm.Conversations.List(ctx, operations.ConversationsListRequest{
        After: mka1.Pointer("conv_abc123"),
        Order: operations.ConversationsListOrderDesc.ToPointer(),
        Metadata: mka1.Pointer(operations.CreateMetadataMapOfStr(
            map[string]string{
                "user_type": "premium",
            },
        )),
        Search: mka1.Pointer("weather forecast"),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ConversationListObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ConversationsListRequest](../../models/operations/conversationslistrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ConversationsListResponse](../../models/operations/conversationslistresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Get a conversation by ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.retrieve" method="get" path="/api/v1/llm/conversations/{conversation_id}" -->
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

    res, err := s.Llm.Conversations.Get(ctx, "conv_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConversationObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `conversationID`                                                    | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ConversationsRetrieveResponse](../../models/operations/conversationsretrieveresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Update a conversation's metadata.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.update" method="post" path="/api/v1/llm/conversations/{conversation_id}" -->
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

    res, err := s.Llm.Conversations.Update(ctx, "conv_abc123", components.Update{
        Metadata: map[string]string{
            "session_id": "sess_abc123",
            "user_type": "premium",
            "status": "active",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConversationObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `conversationID`                                                    | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `body`                                                              | [components.Update](../../models/components/update.md)              | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ConversationsUpdateResponse](../../models/operations/conversationsupdateresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Delete a conversation. Items in the conversation will not be deleted.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.delete" method="delete" path="/api/v1/llm/conversations/{conversation_id}" -->
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

    res, err := s.Llm.Conversations.Delete(ctx, "conv_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConversationDeletedObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `conversationID`                                                    | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ConversationsDeleteResponse](../../models/operations/conversationsdeleteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListItems

List all items for a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.items.list" method="get" path="/api/v1/llm/conversations/{conversation_id}/items" -->
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

    res, err := s.Llm.Conversations.ListItems(ctx, operations.ConversationsItemsListRequest{
        ConversationID: "conv_abc123",
        After: mka1.Pointer("item_abc123"),
        Include: []string{
            "content",
            "metadata",
        },
        Limit: mka1.Pointer[int64](50),
        Order: operations.ConversationsItemsListOrderDesc.ToPointer(),
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

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |
| `request`                                                                                            | [operations.ConversationsItemsListRequest](../../models/operations/conversationsitemslistrequest.md) | :heavy_check_mark:                                                                                   | The request object to use for the request.                                                           |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |

### Response

**[*operations.ConversationsItemsListResponse](../../models/operations/conversationsitemslistresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateItems

Create items in a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.items.create" method="post" path="/api/v1/llm/conversations/{conversation_id}/items" -->
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

    res, err := s.Llm.Conversations.CreateItems(ctx, "conv_abc123", components.CreateItemsRequest{
        Items: []components.Item{
            components.CreateItemInputMessage(
                components.InputMessage{
                    Role: components.InputMessageRoleUser,
                    Content: components.CreateInputMessageContent1Str(
                        "What is the weather today?",
                    ),
                },
            ),
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

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `ctx`                                                                                           | [context.Context](https://pkg.go.dev/context#Context)                                           | :heavy_check_mark:                                                                              | The context to use for the request.                                                             |                                                                                                 |
| `conversationID`                                                                                | `string`                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | conv_abc123                                                                                     |
| `body`                                                                                          | [components.CreateItemsRequest](../../models/components/createitemsrequest.md)                  | :heavy_check_mark:                                                                              | N/A                                                                                             | {<br/>"items": [<br/>{<br/>"type": "message",<br/>"role": "user",<br/>"content": "What is the weather today?"<br/>}<br/>]<br/>} |
| `xOnBehalfOf`                                                                                   | `*string`                                                                                       | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |                                                                                                 |
| `opts`                                                                                          | [][operations.Option](../../models/operations/option.md)                                        | :heavy_minus_sign:                                                                              | The options for this request.                                                                   |                                                                                                 |

### Response

**[*operations.ConversationsItemsCreateResponse](../../models/operations/conversationsitemscreateresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteItems

Delete multiple items from a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.items.deleteMany" method="delete" path="/api/v1/llm/conversations/{conversation_id}/items" -->
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

    res, err := s.Llm.Conversations.DeleteItems(ctx, "conv_abc123", operations.ConversationsItemsDeleteManyRequestBody{
        ItemIds: []string{
            "item_abc123",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConversationObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              | Example                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                                                    | :heavy_check_mark:                                                                                                       | The context to use for the request.                                                                                      |                                                                                                                          |
| `conversationID`                                                                                                         | `string`                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      | conv_abc123                                                                                                              |
| `body`                                                                                                                   | [operations.ConversationsItemsDeleteManyRequestBody](../../models/operations/conversationsitemsdeletemanyrequestbody.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |                                                                                                                          |
| `xOnBehalfOf`                                                                                                            | `*string`                                                                                                                | :heavy_minus_sign:                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                      |                                                                                                                          |
| `opts`                                                                                                                   | [][operations.Option](../../models/operations/option.md)                                                                 | :heavy_minus_sign:                                                                                                       | The options for this request.                                                                                            |                                                                                                                          |

### Response

**[*operations.ConversationsItemsDeleteManyResponse](../../models/operations/conversationsitemsdeletemanyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetItem

Get a single item from a conversation with the given IDs.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.items.retrieve" method="get" path="/api/v1/llm/conversations/{conversation_id}/items/{item_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Conversations.GetItem(ctx, "conv_abc123", "item_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.OneOf != nil {
        switch res.OneOf.Type {
            case operations.ConversationsItemsRetrieveResponseBodyTypeConversationsItemsRetrieveInputMessageItem:
                // res.OneOf.ConversationsItemsRetrieveInputMessageItem is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeOutputMessageWithID:
                // res.OneOf.OutputMessageWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeOutputAudioItemWithID:
                // res.OneOf.OutputAudioItemWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeFileSearchToolCallWithID:
                // res.OneOf.FileSearchToolCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeComputerToolCallWithID:
                // res.OneOf.ComputerToolCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeComputerToolCallOutputWithID:
                // res.OneOf.ComputerToolCallOutputWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeWebSearchToolCallWithID:
                // res.OneOf.WebSearchToolCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeFunctionToolCallWithID:
                // res.OneOf.FunctionToolCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeFunctionToolCallOutputWithID:
                // res.OneOf.FunctionToolCallOutputWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeReasoningWithID:
                // res.OneOf.ReasoningWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeImageGenerationCallWithID:
                // res.OneOf.ImageGenerationCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeCodeInterpreterToolCallWithID:
                // res.OneOf.CodeInterpreterToolCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeLocalShellCallWithID:
                // res.OneOf.LocalShellCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeLocalShellCallOutputWithID:
                // res.OneOf.LocalShellCallOutputWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeShellCallWithID:
                // res.OneOf.ShellCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeShellCallOutputWithID:
                // res.OneOf.ShellCallOutputWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeMCPListToolsWithID:
                // res.OneOf.MCPListToolsWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeMCPApprovalRequestWithID:
                // res.OneOf.MCPApprovalRequestWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeMCPApprovalResponseWithID:
                // res.OneOf.MCPApprovalResponseWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeMCPToolCallWithID:
                // res.OneOf.MCPToolCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeCustomToolCallWithID:
                // res.OneOf.CustomToolCallWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeCustomToolCallOutputWithID:
                // res.OneOf.CustomToolCallOutputWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeItemReferenceWithID:
                // res.OneOf.ItemReferenceWithID is populated
            case operations.ConversationsItemsRetrieveResponseBodyTypeResponseCompactionItemWithID:
                // res.OneOf.ResponseCompactionItemWithID is populated
            default:
                // Unknown type - use res.OneOf.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `conversationID`                                                    | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `itemID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | item_abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ConversationsItemsRetrieveResponse](../../models/operations/conversationsitemsretrieveresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteItem

Delete an item from a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="go" operationID="conversations.items.delete" method="delete" path="/api/v1/llm/conversations/{conversation_id}/items/{item_id}" -->
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

    res, err := s.Llm.Conversations.DeleteItem(ctx, "conv_abc123", "item_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConversationObject != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `conversationID`                                                    | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `itemID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | item_abc123                                                         |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ConversationsItemsDeleteResponse](../../models/operations/conversationsitemsdeleteresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |