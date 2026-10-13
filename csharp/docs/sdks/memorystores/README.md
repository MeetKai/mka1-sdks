# Llm.MemoryStores

## Overview

### Available Operations

* [Create](#create) - Create memory store
* [List](#list) - List memory stores
* [Get](#get) - Retrieve memory store
* [Update](#update) - Update memory store
* [Delete](#delete) - Delete memory store
* [CreateEntry](#createentry) - Create memory entry
* [ListEntries](#listentries) - List memory entries
* [GetEntry](#getentry) - Retrieve memory entry
* [UpdateEntry](#updateentry) - Update memory entry
* [DeleteEntry](#deleteentry) - Delete memory entry

## Create

Creates a memory store for persistent agent notes. Stores are private by default and can be shared across the workspace.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMemoryStore" method="post" path="/api/v1/llm/memory_stores" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.CreateAsync(body: new MeetKai.MKA1.Types.Components.CreateMemoryStoreRequest() {
    Name = "Bug Reports",
    Description = "Persistent bug reports seen by the triage agent.",
    Instructions = "Store every confirmed bug report here using one markdown file per product area.",
    Visibility = MemoryStoreVisibility.Workspace,
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `Body`                                                                                          | [Types.Components.CreateMemoryStoreRequest](../../Types/Components/CreateMemoryStoreRequest.md) | :heavy_check_mark:                                                                              | N/A                                                                                             |
| `XOnBehalfOf`                                                                                   | *string*                                                                                        | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |

### Response

**[CreateMemoryStoreResponse](../../Types/Requests/CreateMemoryStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

List memory stores

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMemoryStores" method="get" path="/api/v1/llm/memory_stores" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.ListAsync(
    limit: 20,
    order: ListMemoryStoresOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `Limit`                                                                | *long*                                                                 | :heavy_minus_sign:                                                     | N/A                                                                    |
| `Order`                                                                | [ListMemoryStoresOrder](../../Types/Requests/ListMemoryStoresOrder.md) | :heavy_minus_sign:                                                     | N/A                                                                    |
| `After`                                                                | *string*                                                               | :heavy_minus_sign:                                                     | N/A                                                                    |
| `XOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |

### Response

**[ListMemoryStoresResponse](../../Types/Requests/ListMemoryStoresResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Retrieve memory store

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMemoryStore" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.GetAsync(memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `MemoryStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetMemoryStoreResponse](../../Types/Requests/GetMemoryStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Update

Update memory store

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMemoryStore" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.UpdateAsync(
    memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198",
    body: new MeetKai.MKA1.Types.Components.UpdateMemoryStoreRequest() {
        Description = "Persistent bug reports seen by the triage agent and support team.",
        Visibility = MemoryStoreVisibility.Workspace,
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `MemoryStoreId`                                                                                 | *string*                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | mem_aa87e2b1112a455b8deabed784372198                                                            |
| `Body`                                                                                          | [Types.Components.UpdateMemoryStoreRequest](../../Types/Components/UpdateMemoryStoreRequest.md) | :heavy_check_mark:                                                                              | N/A                                                                                             |                                                                                                 |
| `XOnBehalfOf`                                                                                   | *string*                                                                                        | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |                                                                                                 |

### Response

**[UpdateMemoryStoreResponse](../../Types/Requests/UpdateMemoryStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete memory store

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteMemoryStore" method="delete" path="/api/v1/llm/memory_stores/{memory_store_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.DeleteAsync(memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `MemoryStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteMemoryStoreResponse](../../Types/Requests/DeleteMemoryStoreResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateEntry

Create memory entry

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createMemoryEntry" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}/entries" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.CreateEntryAsync(
    memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198",
    body: new MeetKai.MKA1.Types.Components.CreateMemoryEntryRequest() {
        Path = "reports/login-rate-limit.md",
        Content = @"# Login rate limit

        Reported by Acme on 2026-05-05.",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `MemoryStoreId`                                                                                 | *string*                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | mem_aa87e2b1112a455b8deabed784372198                                                            |
| `Body`                                                                                          | [Types.Components.CreateMemoryEntryRequest](../../Types/Components/CreateMemoryEntryRequest.md) | :heavy_check_mark:                                                                              | N/A                                                                                             |                                                                                                 |
| `XOnBehalfOf`                                                                                   | *string*                                                                                        | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |                                                                                                 |

### Response

**[CreateMemoryEntryResponse](../../Types/Requests/CreateMemoryEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListEntries

List memory entries

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMemoryEntries" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}/entries" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListMemoryEntriesRequest req = new ListMemoryEntriesRequest() {
    MemoryStoreId = "mem_aa87e2b1112a455b8deabed784372198",
};

var res = await sdk.Llm.MemoryStores.ListEntriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [ListMemoryEntriesRequest](../../Types/Requests/ListMemoryEntriesRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |

### Response

**[ListMemoryEntriesResponse](../../Types/Requests/ListMemoryEntriesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetEntry

Retrieve memory entry

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMemoryEntry" method="get" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.GetEntryAsync(
    memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198",
    entryId: "mem_entry_bb98f3c2223b566c9dfbcef895483209"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `MemoryStoreId`                                                     | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_aa87e2b1112a455b8deabed784372198                                |
| `EntryId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mem_entry_bb98f3c2223b566c9dfbcef895483209                          |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetMemoryEntryResponse](../../Types/Requests/GetMemoryEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateEntry

Update memory entry

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateMemoryEntry" method="post" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.MemoryStores.UpdateEntryAsync(
    memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198",
    entryId: "mem_entry_bb98f3c2223b566c9dfbcef895483209",
    body: new MeetKai.MKA1.Types.Components.UpdateMemoryEntryRequest() {
        Content = @"# Login rate limit

        Reported by Acme and Globex.",
        IfMatch = "c378790c771dbb9651bae4c156f88a6b684d5b520a588e5b33d641aa96103680",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `MemoryStoreId`                                                                                 | *string*                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | mem_aa87e2b1112a455b8deabed784372198                                                            |
| `EntryId`                                                                                       | *string*                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | mem_entry_bb98f3c2223b566c9dfbcef895483209                                                      |
| `Body`                                                                                          | [Types.Components.UpdateMemoryEntryRequest](../../Types/Components/UpdateMemoryEntryRequest.md) | :heavy_check_mark:                                                                              | N/A                                                                                             |                                                                                                 |
| `XOnBehalfOf`                                                                                   | *string*                                                                                        | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |                                                                                                 |

### Response

**[UpdateMemoryEntryResponse](../../Types/Requests/UpdateMemoryEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteEntry

Delete memory entry

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteMemoryEntry" method="delete" path="/api/v1/llm/memory_stores/{memory_store_id}/entries/{entry_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

Types.Requests.DeleteMemoryEntryRequest req = new MeetKai.MKA1.Types.Requests.DeleteMemoryEntryRequest() {
    MemoryStoreId = "mem_aa87e2b1112a455b8deabed784372198",
    EntryId = "mem_entry_bb98f3c2223b566c9dfbcef895483209",
    Body = new MeetKai.MKA1.Types.Components.DeleteMemoryEntryRequest() {
        IfMatch = "c378790c771dbb9651bae4c156f88a6b684d5b520a588e5b33d641aa96103680",
    },
};

var res = await sdk.Llm.MemoryStores.DeleteEntryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [Types.Requests.DeleteMemoryEntryRequest](../../Types/Requests/DeleteMemoryEntryRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[DeleteMemoryEntryResponse](../../Types/Requests/DeleteMemoryEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |