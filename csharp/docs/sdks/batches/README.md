# Llm.Batches

## Overview

### Available Operations

* [Create](#create) - Create a batch
* [List](#list) - List batches
* [Get](#get) - Get a batch
* [Cancel](#cancel) - Cancel a batch

## Create

Creates and executes a batch from an uploaded JSONL file of requests. Each line must have custom_id, method, url, and body fields. Text batches also require write:responses.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createBatch" method="post" path="/api/v1/llm/batches" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Batches.CreateAsync(body: new MeetKai.MKA1.Types.Components.CreateBatchRequest() {
    InputFileId = "file_abc123",
    Endpoint = BatchEndpoint.RootV1ChatCompletions,
    Metadata = new Dictionary<string, string>() {
        { "description", "evaluation job" },
    },
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `Body`                                                                              | [Types.Components.CreateBatchRequest](../../Types/Components/CreateBatchRequest.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `XOnBehalfOf`                                                                       | *string*                                                                            | :heavy_minus_sign:                                                                  | Optional external end-user identifier forwarded by the API gateway.                 |

### Response

**[CreateBatchResponse](../../Types/Requests/CreateBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

Returns a paginated list of batches owned by the authenticated user.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listBatches" method="get" path="/api/v1/llm/batches" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Batches.ListAsync(limit: 20);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `After`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[Types.Requests.ListBatchesResponse](../../Types/Requests/ListBatchesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Retrieves a batch by its ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getBatch" method="get" path="/api/v1/llm/batches/{batch_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Batches.GetAsync(batchId: "batch_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `BatchId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | batch_aa87e2b1112a455b8deabed784372198                              |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetBatchResponse](../../Types/Requests/GetBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Cancel

Cancels an in-progress batch. The batch status changes to cancelling, and remaining requests will not be processed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelBatch" method="post" path="/api/v1/llm/batches/{batch_id}/cancel" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Batches.CancelAsync(batchId: "batch_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `BatchId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | batch_aa87e2b1112a455b8deabed784372198                              |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[CancelBatchResponse](../../Types/Requests/CancelBatchResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |