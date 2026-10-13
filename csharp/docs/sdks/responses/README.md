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

<!-- UsageSnippet language="csharp" operationID="createResponse" method="post" path="/api/v1/llm/responses" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Responses.CreateAsync(body: new ResponsesCreateRequest() {
    Model = "meetkai:functionary-urdu-mini-pak",
    Input = ResponsesCreateRequestInput.CreateStr(
        "What is the capital of France?"
    ),
});

// Handle event stream response
var eventStream = res.Object;
if (eventStream != null)
{
    await foreach (CreateResponseResponseBody eventData in eventStream)
    {
        // handle eventData
    }
}
// Handle JSON response
else if (res.ResponseObject != null)
{
    // handle JSON response
    var jsonResponse = res.ResponseObject;
}
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `Body`                                                                                                       | [ResponsesCreateRequest](../../Types/Components/ResponsesCreateRequest.md)                                   | :heavy_check_mark:                                                                                           | N/A                                                                                                          | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"input": "What is the capital of France?",<br/>"stream": false<br/>} |
| `XOnBehalfOf`                                                                                                | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | Optional external end-user identifier forwarded by the API gateway.                                          |                                                                                                              |

### Response

**[CreateResponseResponse](../../Types/Requests/CreateResponseResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

Retrieves a paginated list of all agent responses for the authenticated user.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listResponses" method="get" path="/api/v1/llm/responses" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListResponsesRequest req = new ListResponsesRequest() {
    After = "resp_abc123",
    Before = "resp_xyz789",
    Limit = 25,
};

var res = await sdk.Llm.Responses.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `request`                                                            | [ListResponsesRequest](../../Types/Requests/ListResponsesRequest.md) | :heavy_check_mark:                                                   | The request object to use for the request.                           |

### Response

**[ListResponsesResponse](../../Types/Requests/ListResponsesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Retrieves a previously created agent response by its unique ID. When stream=true, returns Server-Sent Events for real-time updates on in-progress background responses.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getResponse" method="get" path="/api/v1/llm/responses/{response_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetResponseRequest req = new GetResponseRequest() {
    ResponseId = "resp_get123",
    Include = new List<GetResponseInclude>() {
        GetResponseInclude.FileSearchCallResults,
        GetResponseInclude.MessageOutputTextLogprobs,
    },
    IncludeObfuscation = false,
    StartingAfter = 42,
    Stream = false,
};

var res = await sdk.Llm.Responses.GetAsync(req);

// Handle event stream response
var eventStream = res.Object;
if (eventStream != null)
{
    await foreach (GetResponseResponseBody eventData in eventStream)
    {
        // handle eventData
    }
}
// Handle JSON response
else if (res.ResponseObject != null)
{
    // handle JSON response
    var jsonResponse = res.ResponseObject;
}
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [GetResponseRequest](../../Types/Requests/GetResponseRequest.md) | :heavy_check_mark:                                               | The request object to use for the request.                       |

### Response

**[GetResponseResponse](../../Types/Requests/GetResponseResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Update

Update a response's metadata.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateResponse" method="post" path="/api/v1/llm/responses/{response_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Responses.UpdateAsync(
    responseId: "resp_abc123",
    body: new MeetKai.MKA1.Types.Components.UpdateResponseRequest() {
        Metadata = new Dictionary<string, string>() {
            { "status", "reviewed" },
            { "reviewer", "john_doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `ResponseId`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       | resp_abc123                                                                               |
| `Body`                                                                                    | [Types.Components.UpdateResponseRequest](../../Types/Components/UpdateResponseRequest.md) | :heavy_check_mark:                                                                        | N/A                                                                                       | {<br/>"metadata": {<br/>"status": "reviewed",<br/>"reviewer": "john_doe"<br/>}<br/>}      |
| `XOnBehalfOf`                                                                             | *string*                                                                                  | :heavy_minus_sign:                                                                        | Optional external end-user identifier forwarded by the API gateway.                       |                                                                                           |

### Response

**[UpdateResponseResponse](../../Types/Requests/UpdateResponseResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Permanently deletes an agent response and all associated data.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteResponse" method="delete" path="/api/v1/llm/responses/{response_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Responses.DeleteAsync(responseId: "resp_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ResponseId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp_abc123                                                         |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteResponseResponse](../../Types/Requests/DeleteResponseResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Cancel

Cancels an agent response that is currently processing in the background.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelResponse" method="post" path="/api/v1/llm/responses/{response_id}/cancel" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Responses.CancelAsync(responseId: "resp_cancel123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ResponseId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp_cancel123                                                      |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[CancelResponseResponse](../../Types/Requests/CancelResponseResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Wake

Interrupts a short sleep tool call on an in-progress background response by providing follow-up input. Wake delivery is polled by the sleeping agent and may take up to one second.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="wakeResponse" method="post" path="/api/v1/llm/responses/{response_id}/wake" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Responses.WakeAsync(
    responseId: "resp_sleep123",
    body: new WakeResponseRequestBody() {
        Input = "I have more context now; resume immediately.",
    }
);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                | Example                                                                    |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `ResponseId`                                                               | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        | resp_sleep123                                                              |
| `Body`                                                                     | [WakeResponseRequestBody](../../Types/Requests/WakeResponseRequestBody.md) | :heavy_check_mark:                                                         | N/A                                                                        |                                                                            |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |                                                                            |

### Response

**[WakeResponseResponse](../../Types/Requests/WakeResponseResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListInputItems

Retrieves a paginated list of all input items provided when creating the specified agent response.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listInputItems" method="get" path="/api/v1/llm/responses/{response_id}/input_items" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListInputItemsRequest req = new ListInputItemsRequest() {
    ResponseId = "resp_abc123",
    After = "item_abc123",
    Include = new List<ListInputItemsInclude>() {
        ListInputItemsInclude.FileSearchCallResults,
    },
    Limit = 50,
    Order = ListInputItemsOrder.Asc,
};

var res = await sdk.Llm.Responses.ListInputItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `request`                                                              | [ListInputItemsRequest](../../Types/Requests/ListInputItemsRequest.md) | :heavy_check_mark:                                                     | The request object to use for the request.                             |

### Response

**[ListInputItemsResponse](../../Types/Requests/ListInputItemsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Compact

Creates a compacted summary of the conversation history for a response, reducing context size while preserving key information. Returns a compacted response object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="compactResponse" method="post" path="/api/v1/llm/responses/compact" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Responses.CompactAsync(body: new MeetKai.MKA1.Types.Components.CompactResponseRequest() {
    Model = "meetkai:functionary-urdu-mini-pak",
    PreviousResponseId = "resp_abc123",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Body`                                                                                      | [Types.Components.CompactResponseRequest](../../Types/Components/CompactResponseRequest.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `XOnBehalfOf`                                                                               | *string*                                                                                    | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |

### Response

**[CompactResponseResponse](../../Types/Requests/CompactResponseResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |