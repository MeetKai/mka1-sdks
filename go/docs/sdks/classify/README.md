# Llm.Classify

## Overview

### Available Operations

* [Classify](#classify) - Classify text into predefined categories

## Classify

Classifies text content into one of the provided predefined labels.

### Example Usage

<!-- UsageSnippet language="go" operationID="classifyText" method="post" path="/api/v1/llm/classify" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Classify.Classify(ctx, components.ClassificationRequest{
        Model: "meetkai:functionary-urdu-mini-pak",
        Text: "I absolutely love this product! Best purchase ever.",
        Labels: []string{
            "positive",
            "negative",
            "neutral",
        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ClassificationResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                                                        | Type                                                                                                                                                             | Required                                                                                                                                                         | Description                                                                                                                                                      | Example                                                                                                                                                          |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                                                                                            | :heavy_check_mark:                                                                                                                                               | The context to use for the request.                                                                                                                              |                                                                                                                                                                  |
| `body`                                                                                                                                                           | [components.ClassificationRequest](../../models/components/classificationrequest.md)                                                                             | :heavy_check_mark:                                                                                                                                               | N/A                                                                                                                                                              | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"text": "I absolutely love this product! Best purchase ever.",<br/>"labels": [<br/>"positive",<br/>"negative",<br/>"neutral"<br/>]<br/>} |
| `xOnBehalfOf`                                                                                                                                                    | `*string`                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                                                              |                                                                                                                                                                  |
| `opts`                                                                                                                                                           | [][operations.Option](../../models/operations/option.md)                                                                                                         | :heavy_minus_sign:                                                                                                                                               | The options for this request.                                                                                                                                    |                                                                                                                                                                  |

### Response

**[*operations.ClassifyTextResponse](../../models/operations/classifytextresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |