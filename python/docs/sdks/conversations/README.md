# Llm.Conversations

## Overview

### Available Operations

* [create](#create) - Create a conversation
* [list](#list) - List conversations
* [get](#get) - Retrieve a conversation
* [update](#update) - Update a conversation
* [delete](#delete) - Delete a conversation
* [list_items](#list_items) - List conversation items
* [create_items](#create_items) - Create conversation items
* [delete_items](#delete_items) - Delete multiple conversation items
* [get_item](#get_item) - Retrieve a conversation item
* [delete_item](#delete_item) - Delete a conversation item

## create

Create a conversation to store and retrieve conversation state across Response API calls.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.create" method="post" path="/api/v1/llm/conversations" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.create(items=[
        {
            "type": "custom_tool_call_output",
            "call_id": "<id>",
            "output": "<value>",
        },
    ], metadata={
        "session_id": "sess_abc123",
        "user_type": "premium",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `x_on_behalf_of`                                                              | *Optional[str]*                                                               | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |
| `items`                                                                       | List[[models.Item](../../models/item.md)]                                     | :heavy_minus_sign:                                                            | Initial items to include in the conversation context. Max 20 items at a time. |
| `metadata`                                                                    | Dict[str, *str*]                                                              | :heavy_minus_sign:                                                            | Set of 16 key-value pairs for storing additional information.                 |
| `retries`                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)              | :heavy_minus_sign:                                                            | Configuration to override the default retry behavior of the client.           |

### Response

**[models.ConversationObject](../../models/conversationobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list

List all conversations for the authenticated user with pagination support.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.list" method="get" path="/api/v1/llm/conversations" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.list(after="conv_abc123", limit=20, order="desc", metadata={
        "user_type": "premium",
    }, search="weather forecast")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                             | Type                                                                                                                                  | Required                                                                                                                              | Description                                                                                                                           | Example                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| `after`                                                                                                                               | *Optional[str]*                                                                                                                       | :heavy_minus_sign:                                                                                                                    | N/A                                                                                                                                   | conv_abc123                                                                                                                           |
| `limit`                                                                                                                               | *Optional[int]*                                                                                                                       | :heavy_minus_sign:                                                                                                                    | N/A                                                                                                                                   | 20                                                                                                                                    |
| `order`                                                                                                                               | [Optional[models.ConversationsListOrder]](../../models/conversationslistorder.md)                                                     | :heavy_minus_sign:                                                                                                                    | Sort order by last updated timestamp: asc (oldest first) or desc (newest first)                                                       | desc                                                                                                                                  |
| `metadata`                                                                                                                            | [Optional[models.ConversationsListMetadata]](../../models/conversationslistmetadata.md)                                               | :heavy_minus_sign:                                                                                                                    | Filter conversations by metadata key-value pairs (JSON string or object). Only conversations with matching metadata will be returned. | {<br/>"user_type": "premium"<br/>}                                                                                                    |
| `search`                                                                                                                              | *Optional[str]*                                                                                                                       | :heavy_minus_sign:                                                                                                                    | N/A                                                                                                                                   | weather forecast                                                                                                                      |
| `x_on_behalf_of`                                                                                                                      | *Optional[str]*                                                                                                                       | :heavy_minus_sign:                                                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                                                   |                                                                                                                                       |
| `retries`                                                                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                      | :heavy_minus_sign:                                                                                                                    | Configuration to override the default retry behavior of the client.                                                                   |                                                                                                                                       |

### Response

**[models.ConversationListObject](../../models/conversationlistobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Get a conversation by ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.retrieve" method="get" path="/api/v1/llm/conversations/{conversation_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.get(conversation_id="conv_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversation_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ConversationObject](../../models/conversationobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update

Update a conversation's metadata.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.update" method="post" path="/api/v1/llm/conversations/{conversation_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.update(conversation_id="conv_abc123", metadata={
        "session_id": "sess_abc123",
        "user_type": "premium",
        "status": "active",
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversation_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `metadata`                                                          | Dict[str, *str*]                                                    | :heavy_check_mark:                                                  | Set of 16 key-value pairs to update.                                |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ConversationObject](../../models/conversationobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete

Delete a conversation. Items in the conversation will not be deleted.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.delete" method="delete" path="/api/v1/llm/conversations/{conversation_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.delete(conversation_id="conv_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversation_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ConversationDeletedObject](../../models/conversationdeletedobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_items

List all items for a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.items.list" method="get" path="/api/v1/llm/conversations/{conversation_id}/items" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.list_items(conversation_id="conv_abc123", after="item_abc123", include=[
        "content",
        "metadata",
    ], limit=50, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 | Example                                                                                     |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `conversation_id`                                                                           | *str*                                                                                       | :heavy_check_mark:                                                                          | N/A                                                                                         | conv_abc123                                                                                 |
| `after`                                                                                     | *Optional[str]*                                                                             | :heavy_minus_sign:                                                                          | N/A                                                                                         | item_abc123                                                                                 |
| `include`                                                                                   | List[*str*]                                                                                 | :heavy_minus_sign:                                                                          | N/A                                                                                         | [<br/>"content",<br/>"metadata"<br/>]                                                       |
| `limit`                                                                                     | *Optional[int]*                                                                             | :heavy_minus_sign:                                                                          | N/A                                                                                         | 50                                                                                          |
| `order`                                                                                     | [Optional[models.ConversationsItemsListOrder]](../../models/conversationsitemslistorder.md) | :heavy_minus_sign:                                                                          | The order to return the input items in. Default is `asc`.                                   | desc                                                                                        |
| `x_on_behalf_of`                                                                            | *Optional[str]*                                                                             | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |                                                                                             |
| `retries`                                                                                   | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                            | :heavy_minus_sign:                                                                          | Configuration to override the default retry behavior of the client.                         |                                                                                             |

### Response

**[models.ConversationsItemsListResponse](../../models/conversationsitemslistresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_items

Create items in a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.items.create" method="post" path="/api/v1/llm/conversations/{conversation_id}/items" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.create_items(conversation_id="conv_abc123", items=[
        {
            "type": "message",
            "role": "user",
            "content": "What is the weather today?",
        },
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversation_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `items`                                                             | List[[models.Item](../../models/item.md)]                           | :heavy_check_mark:                                                  | Items to add to the conversation. Min 1, max 20 items at a time.    |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `include`                                                           | List[*str*]                                                         | :heavy_minus_sign:                                                  | Additional fields to include (TODO: not implemented yet)            |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ConversationsItemsCreateResponse](../../models/conversationsitemscreateresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_items

Delete multiple items from a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.items.deleteMany" method="delete" path="/api/v1/llm/conversations/{conversation_id}/items" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.delete_items(conversation_id="conv_abc123", item_ids=[
        "item_abc123",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversation_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `item_ids`                                                          | List[*str*]                                                         | :heavy_check_mark:                                                  | Array of item IDs to delete                                         |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ConversationObject](../../models/conversationobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_item

Get a single item from a conversation with the given IDs.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.items.retrieve" method="get" path="/api/v1/llm/conversations/{conversation_id}/items/{item_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.get_item(conversation_id="conv_abc123", item_id="item_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversation_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `item_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | item_abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ConversationsItemsRetrieveResponse](../../models/conversationsitemsretrieveresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_item

Delete an item from a conversation with the given ID.

### Example Usage

<!-- UsageSnippet language="python" operationID="conversations.items.delete" method="delete" path="/api/v1/llm/conversations/{conversation_id}/items/{item_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.conversations.delete_item(conversation_id="conv_abc123", item_id="item_abc123")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversation_id`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `item_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | item_abc123                                                         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ConversationObject](../../models/conversationobject.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |