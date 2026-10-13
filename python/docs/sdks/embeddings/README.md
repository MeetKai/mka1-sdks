# Llm.Embeddings

## Overview

### Available Operations

* [list_models](#list_models) - List available embedding models
* [embed](#embed) - Create text embeddings

## list_models

Returns a list of available embedding models with their limits. Use this endpoint to discover which models are available and their constraints (batch size, input length) before making embedding requests.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEmbeddingModels" method="get" path="/api/v1/llm/embeddings/models" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.embeddings.list_models()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EmbeddingModelListResponse](../../models/embeddingmodellistresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## embed

Generates vector embeddings for single or multiple text inputs. Returns floating-point vectors along with token usage statistics.

### Example Usage

<!-- UsageSnippet language="python" operationID="embed" method="post" path="/api/v1/llm/embeddings" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.embeddings.embed(input="The quick brown fox jumps over the lazy dog.", model="auto", encoding_format="float")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                 | Type                                                                                                                                                                                                                      | Required                                                                                                                                                                                                                  | Description                                                                                                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `input`                                                                                                                                                                                                                   | [models.EmbeddingsRequestInput](../../models/embeddingsrequestinput.md)                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                        | The input text or array of texts to generate embeddings for. Can be a single string or an array of strings. Note: batch size and input length limits vary by model. See GET /embeddings/models for model-specific limits. |
| `model`                                                                                                                                                                                                                   | *str*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                        | ID of the model to use for generating embeddings. Use provider:model format. See GET /embeddings/models for available models and their limits.                                                                            |
| `x_on_behalf_of`                                                                                                                                                                                                          | *Optional[str]*                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                        | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                       |
| `dimensions`                                                                                                                                                                                                              | *Optional[int]*                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                        | The number of dimensions the resulting output embeddings should have. Only supported in certain models.                                                                                                                   |
| `encoding_format`                                                                                                                                                                                                         | [Optional[models.EncodingFormat]](../../models/encodingformat.md)                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                        | The format to return the embeddings in. Can be either 'float' (array of numbers) or 'base64' (base64-encoded binary).                                                                                                     |
| `user`                                                                                                                                                                                                                    | *Optional[str]*                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                        | A unique identifier representing your end-user.                                                                                                                                                                           |
| `retries`                                                                                                                                                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                        | Configuration to override the default retry behavior of the client.                                                                                                                                                       |

### Response

**[models.EmbeddingsResponse](../../models/embeddingsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |