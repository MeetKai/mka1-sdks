# Llm.Classify

## Overview

### Available Operations

* [Classify](#classify) - Classify text into predefined categories

## Classify

Classifies text content into one of the provided predefined labels.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="classifyText" method="post" path="/api/v1/llm/classify" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Classify.ClassifyAsync(body: new ClassificationRequest() {
    Model = "meetkai:functionary-urdu-mini-pak",
    Text = "I absolutely love this product! Best purchase ever.",
    Labels = new List<string>() {
        "positive",
        "negative",
        "neutral",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                        | Type                                                                                                                                                             | Required                                                                                                                                                         | Description                                                                                                                                                      | Example                                                                                                                                                          |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                                                                           | [ClassificationRequest](../../Types/Components/ClassificationRequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                               | N/A                                                                                                                                                              | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"text": "I absolutely love this product! Best purchase ever.",<br/>"labels": [<br/>"positive",<br/>"negative",<br/>"neutral"<br/>]<br/>} |
| `XOnBehalfOf`                                                                                                                                                    | *string*                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                                                              |                                                                                                                                                                  |

### Response

**[ClassifyTextResponse](../../Types/Requests/ClassifyTextResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |