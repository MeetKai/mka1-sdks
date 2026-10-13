# Llm.Classify

## Overview

### Available Operations

* [classify](#classify) - Classify text into predefined categories

## classify

Classifies text content into one of the provided predefined labels.

### Example Usage

<!-- UsageSnippet language="python" operationID="classifyText" method="post" path="/api/v1/llm/classify" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.classify.classify(model="meetkai:functionary-urdu-mini-pak", text="I absolutely love this product! Best purchase ever.", labels=[
        "positive",
        "negative",
        "neutral",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                               | Type                                                                                                                                                                    | Required                                                                                                                                                                | Description                                                                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `model`                                                                                                                                                                 | *str*                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                      | ID of the model to use for classification. You can use provider:model format or just the model name with a default provider.                                            |
| `text`                                                                                                                                                                  | *str*                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                      | The text content to classify. Must not be empty.                                                                                                                        |
| `labels`                                                                                                                                                                | List[*str*]                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                      | Array of possible classification labels. Must contain at least 2 labels. The model will choose one of these labels to assign to the text.                               |
| `x_on_behalf_of`                                                                                                                                                        | *Optional[str]*                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                                                                                     |
| `prompt`                                                                                                                                                                | *Optional[str]*                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                      | Optional custom system prompt to guide the classification. Use this to provide additional context or instructions to the model about how to perform the classification. |
| `retries`                                                                                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                        | :heavy_minus_sign:                                                                                                                                                      | Configuration to override the default retry behavior of the client.                                                                                                     |

### Response

**[models.ClassificationResponse](../../models/classificationresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |