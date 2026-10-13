# Llm.Usage

## Overview

### Available Operations

* [Completions](#completions) - Get completions usage
* [Responses](#responses) - Get responses usage
* [Conversations](#conversations) - Get conversations usage
* [Embeddings](#embeddings) - Get embeddings usage
* [Extract](#extract) - Get extract usage
* [Classify](#classify) - Get classify usage
* [VectorStores](#vectorstores) - Get vector stores usage
* [Files](#files) - Get files usage
* [Costs](#costs) - Get cost by model

## Completions

Retrieve usage metrics for chat completions, aggregated from the ChatCompletion table.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCompletionsUsage" method="get" path="/api/v1/llm/usage/completions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetCompletionsUsageRequest req = new GetCompletionsUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<CompletionsGroupBy>() {
        CompletionsGroupBy.Model,
    },
    Models = new List<string>() {
        "meetkai:functionary-urdu-mini-pak",
    },
};

var res = await sdk.Llm.Usage.CompletionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `request`                                                                        | [GetCompletionsUsageRequest](../../Types/Requests/GetCompletionsUsageRequest.md) | :heavy_check_mark:                                                               | The request object to use for the request.                                       |

### Response

**[GetCompletionsUsageResponse](../../Types/Requests/GetCompletionsUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Responses

Retrieve usage metrics for agent responses, aggregated from the Response table.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getResponsesUsage" method="get" path="/api/v1/llm/usage/responses" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetResponsesUsageRequest req = new GetResponsesUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<ResponsesGroupBy>() {
        ResponsesGroupBy.Model,
        ResponsesGroupBy.Background,
    },
    Models = new List<string>() {
        "meetkai:functionary-urdu-mini-pak",
    },
    Background = false,
};

var res = await sdk.Llm.Usage.ResponsesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [GetResponsesUsageRequest](../../Types/Requests/GetResponsesUsageRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |

### Response

**[GetResponsesUsageResponse](../../Types/Requests/GetResponsesUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Conversations

Retrieve usage metrics for conversation operations.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getConversationsUsage" method="get" path="/api/v1/llm/usage/conversations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetConversationsUsageRequest req = new GetConversationsUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<ConversationsGroupBy>() {
        ConversationsGroupBy.UserId,
    },
};

var res = await sdk.Llm.Usage.ConversationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `request`                                                                            | [GetConversationsUsageRequest](../../Types/Requests/GetConversationsUsageRequest.md) | :heavy_check_mark:                                                                   | The request object to use for the request.                                           |

### Response

**[GetConversationsUsageResponse](../../Types/Requests/GetConversationsUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Embeddings

Retrieve usage metrics for embedding operations.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getEmbeddingsUsage" method="get" path="/api/v1/llm/usage/embeddings" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetEmbeddingsUsageRequest req = new GetEmbeddingsUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<EmbeddingsGroupBy>() {
        EmbeddingsGroupBy.Model,
    },
    Models = new List<string>() {
        "auto",
    },
};

var res = await sdk.Llm.Usage.EmbeddingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `request`                                                                      | [GetEmbeddingsUsageRequest](../../Types/Requests/GetEmbeddingsUsageRequest.md) | :heavy_check_mark:                                                             | The request object to use for the request.                                     |

### Response

**[GetEmbeddingsUsageResponse](../../Types/Requests/GetEmbeddingsUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Extract

Retrieve usage metrics for extract operations.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getExtractUsage" method="get" path="/api/v1/llm/usage/extract" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetExtractUsageRequest req = new GetExtractUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<ExtractGroupBy>() {
        ExtractGroupBy.Model,
    },
    Models = new List<string>() {
        "meetkai:functionary-urdu-mini-pak",
    },
};

var res = await sdk.Llm.Usage.ExtractAsync(req);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `request`                                                                | [GetExtractUsageRequest](../../Types/Requests/GetExtractUsageRequest.md) | :heavy_check_mark:                                                       | The request object to use for the request.                               |

### Response

**[GetExtractUsageResponse](../../Types/Requests/GetExtractUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Classify

Retrieve usage metrics for classify operations.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getClassifyUsage" method="get" path="/api/v1/llm/usage/classify" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetClassifyUsageRequest req = new GetClassifyUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<ClassifyGroupBy>() {
        ClassifyGroupBy.Model,
    },
    Models = new List<string>() {
        "meetkai:functionary-urdu-mini-pak",
    },
};

var res = await sdk.Llm.Usage.ClassifyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [GetClassifyUsageRequest](../../Types/Requests/GetClassifyUsageRequest.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |

### Response

**[GetClassifyUsageResponse](../../Types/Requests/GetClassifyUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## VectorStores

Retrieve usage metrics for vector storage operations.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getVectorStoresUsage" method="get" path="/api/v1/llm/usage/vector_stores" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetVectorStoresUsageRequest req = new GetVectorStoresUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<VectorStoresGroupBy>() {
        VectorStoresGroupBy.UserId,
    },
};

var res = await sdk.Llm.Usage.VectorStoresAsync(req);

// handle response
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `request`                                                                          | [GetVectorStoresUsageRequest](../../Types/Requests/GetVectorStoresUsageRequest.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |

### Response

**[GetVectorStoresUsageResponse](../../Types/Requests/GetVectorStoresUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Files

Retrieve bytes of files created per period from durable file creation events. This does not reflect current retained storage, buckets remain counted after file deletion, and grouped results collapse by requested output dimensions rather than one row per UserContext.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFilesUsage" method="get" path="/api/v1/llm/usage/files" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetFilesUsageRequest req = new GetFilesUsageRequest() {
    StartTime = 1704067200,
    EndTime = 1704153600,
    Limit = 30,
    Page = "cursor_abc123",
    UserIds = new List<string>() {
        "user_123",
        "user_456",
    },
    ExternalUserIds = new List<string>() {
        "sub_123",
    },
    OrgIds = new List<string>() {
        "org_123",
    },
    GroupBy = new List<FilesGroupBy>() {
        FilesGroupBy.UserId,
    },
};

var res = await sdk.Llm.Usage.FilesAsync(req);

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `request`                                                            | [GetFilesUsageRequest](../../Types/Requests/GetFilesUsageRequest.md) | :heavy_check_mark:                                                   | The request object to use for the request.                           |

### Response

**[GetFilesUsageResponse](../../Types/Requests/GetFilesUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Costs

Aggregates spend by model over a time range, priced in the cluster currency from the model price book. Org-scoped: org admins see their org; cluster admins may pass `org_id`. Includes billable work with no usage row of its own (store=false responses, agent tool calls), so totals cover all LLM spend. Platform-wide, cross-service cost reporting lives in the budgeting API (/api/v1/budgeting/usage/costs).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCostsUsage" method="get" path="/api/v1/llm/usage/costs" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetCostsUsageRequest req = new GetCostsUsageRequest() {
    StartTime = 612474,
    EndTime = 211313,
};

var res = await sdk.Llm.Usage.CostsAsync(req);

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `request`                                                            | [GetCostsUsageRequest](../../Types/Requests/GetCostsUsageRequest.md) | :heavy_check_mark:                                                   | The request object to use for the request.                           |

### Response

**[GetCostsUsageResponse](../../Types/Requests/GetCostsUsageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |