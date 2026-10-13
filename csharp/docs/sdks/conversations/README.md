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

<!-- UsageSnippet language="csharp" operationID="conversations.create" method="post" path="/api/v1/llm/conversations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.CreateAsync(body: new CreateConversationRequest() {
    Metadata = new Dictionary<string, string>() {
        { "session_id", "sess_abc123" },
        { "user_type", "premium" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      | Example                                                                          |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Body`                                                                           | [CreateConversationRequest](../../Types/Components/CreateConversationRequest.md) | :heavy_check_mark:                                                               | N/A                                                                              | {<br/>"metadata": {<br/>"session_id": "abc123",<br/>"user_type": "premium"<br/>}<br/>} |
| `XOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |                                                                                  |

### Response

**[ConversationsCreateResponse](../../Types/Requests/ConversationsCreateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

List all conversations for the authenticated user with pagination support.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.list" method="get" path="/api/v1/llm/conversations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ConversationsListRequest req = new ConversationsListRequest() {
    After = "conv_abc123",
    Order = ConversationsListOrder.Desc,
    Metadata = MeetKai.MKA1.Types.Requests.Metadata.CreateMapOfStr(
        new Dictionary<string, string>() {
            { "user_type", "premium" },
        }
    ),
    Search = "weather forecast",
};

var res = await sdk.Llm.Conversations.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [ConversationsListRequest](../../Types/Requests/ConversationsListRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |

### Response

**[ConversationsListResponse](../../Types/Requests/ConversationsListResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Get a conversation by ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.retrieve" method="get" path="/api/v1/llm/conversations/{conversation_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.GetAsync(conversationId: "conv_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConversationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[ConversationsRetrieveResponse](../../Types/Requests/ConversationsRetrieveResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Update

Update a conversation's metadata.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.update" method="post" path="/api/v1/llm/conversations/{conversation_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.UpdateAsync(
    conversationId: "conv_abc123",
    body: new Update() {
        Metadata = new Dictionary<string, string>() {
            { "session_id", "sess_abc123" },
            { "user_type", "premium" },
            { "status", "active" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConversationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `Body`                                                              | [Update](../../Types/Components/Update.md)                          | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[ConversationsUpdateResponse](../../Types/Requests/ConversationsUpdateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a conversation. Items in the conversation will not be deleted.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.delete" method="delete" path="/api/v1/llm/conversations/{conversation_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.DeleteAsync(conversationId: "conv_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConversationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[ConversationsDeleteResponse](../../Types/Requests/ConversationsDeleteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListItems

List all items for a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.items.list" method="get" path="/api/v1/llm/conversations/{conversation_id}/items" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ConversationsItemsListRequest req = new ConversationsItemsListRequest() {
    ConversationId = "conv_abc123",
    After = "item_abc123",
    Include = new List<string>() {
        "content",
        "metadata",
    },
    Limit = 50,
    Order = ConversationsItemsListOrder.Desc,
};

var res = await sdk.Llm.Conversations.ListItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `request`                                                                              | [ConversationsItemsListRequest](../../Types/Requests/ConversationsItemsListRequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |

### Response

**[ConversationsItemsListResponse](../../Types/Requests/ConversationsItemsListResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateItems

Create items in a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.items.create" method="post" path="/api/v1/llm/conversations/{conversation_id}/items" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.CreateItemsAsync(
    conversationId: "conv_abc123",
    body: new CreateItemsRequest() {
        Items = new List<Item>() {
            Item.CreateInputMessage(
                new InputMessage() {
                    Role = InputMessageRole.User,
                    Content = InputMessageContent1.CreateStr(
                        "What is the weather today?"
                    ),
                }
            ),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `ConversationId`                                                                                | *string*                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | conv_abc123                                                                                     |
| `Body`                                                                                          | [CreateItemsRequest](../../Types/Components/CreateItemsRequest.md)                              | :heavy_check_mark:                                                                              | N/A                                                                                             | {<br/>"items": [<br/>{<br/>"type": "message",<br/>"role": "user",<br/>"content": "What is the weather today?"<br/>}<br/>]<br/>} |
| `XOnBehalfOf`                                                                                   | *string*                                                                                        | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |                                                                                                 |

### Response

**[ConversationsItemsCreateResponse](../../Types/Requests/ConversationsItemsCreateResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteItems

Delete multiple items from a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.items.deleteMany" method="delete" path="/api/v1/llm/conversations/{conversation_id}/items" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.DeleteItemsAsync(
    conversationId: "conv_abc123",
    body: new ConversationsItemsDeleteManyRequestBody() {
        ItemIds = new List<string>() {
            "item_abc123",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                  | Type                                                                                                       | Required                                                                                                   | Description                                                                                                | Example                                                                                                    |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `ConversationId`                                                                                           | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        | conv_abc123                                                                                                |
| `Body`                                                                                                     | [ConversationsItemsDeleteManyRequestBody](../../Types/Requests/ConversationsItemsDeleteManyRequestBody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |                                                                                                            |
| `XOnBehalfOf`                                                                                              | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |                                                                                                            |

### Response

**[ConversationsItemsDeleteManyResponse](../../Types/Requests/ConversationsItemsDeleteManyResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetItem

Get a single item from a conversation with the given IDs.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.items.retrieve" method="get" path="/api/v1/llm/conversations/{conversation_id}/items/{item_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.GetItemAsync(
    conversationId: "conv_abc123",
    itemId: "item_abc123"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConversationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `ItemId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | item_abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[ConversationsItemsRetrieveResponse](../../Types/Requests/ConversationsItemsRetrieveResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteItem

Delete an item from a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="conversations.items.delete" method="delete" path="/api/v1/llm/conversations/{conversation_id}/items/{item_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Conversations.DeleteItemAsync(
    conversationId: "conv_abc123",
    itemId: "item_abc123"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConversationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `ItemId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | item_abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[ConversationsItemsDeleteResponse](../../Types/Requests/ConversationsItemsDeleteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |