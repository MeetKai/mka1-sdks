# Llm.Embeddings

## Overview

### Available Operations

* [ListModels](#listmodels) - List available embedding models
* [Embed](#embed) - Create text embeddings

## ListModels

Returns a list of available embedding models with their limits. Use this endpoint to discover which models are available and their constraints (batch size, input length) before making embedding requests.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEmbeddingModels" method="get" path="/api/v1/llm/embeddings/models" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Embeddings.ListModelsAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListEmbeddingModelsResponse](../../Types/Requests/ListEmbeddingModelsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Embed

Generates vector embeddings for single or multiple text inputs. Returns floating-point vectors along with token usage statistics.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="embed" method="post" path="/api/v1/llm/embeddings" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Embeddings.EmbedAsync(body: new EmbeddingsRequest() {
    Input = EmbeddingsRequestInput.CreateStr(
        "The quick brown fox jumps over the lazy dog."
    ),
    Model = "auto",
});

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Body`                                                                       | [EmbeddingsRequest](../../Types/Components/EmbeddingsRequest.md)             | :heavy_check_mark:                                                           | N/A                                                                          | {<br/>"model": "auto",<br/>"input": "The quick brown fox jumps over the lazy dog."<br/>} |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |                                                                              |

### Response

**[EmbedResponse](../../Types/Requests/EmbedResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |