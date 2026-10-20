# Llm.Images

## Overview

### Available Operations

* [Create](#create) - Generate images from text descriptions

## Create

Creates AI-generated images from text descriptions.

### Example Usage

<!-- UsageSnippet language="go" operationID="createImage" method="post" path="/api/v1/llm/images/generations" -->
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

    res, err := s.Llm.Images.Create(ctx, components.ImageGenerationRequest{
        Prompt: "A serene mountain landscape at sunset with a lake reflection",
        Quality: components.ImageGenerationRequestQualityHd.ToPointer(),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ImageGenerationResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                                             | Type                                                                                                                                  | Required                                                                                                                              | Description                                                                                                                           | Example                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                                                 | [context.Context](https://pkg.go.dev/context#Context)                                                                                 | :heavy_check_mark:                                                                                                                    | The context to use for the request.                                                                                                   |                                                                                                                                       |
| `body`                                                                                                                                | [components.ImageGenerationRequest](../../models/components/imagegenerationrequest.md)                                                | :heavy_check_mark:                                                                                                                    | N/A                                                                                                                                   | {<br/>"model": "auto",<br/>"prompt": "A serene mountain landscape at sunset with a lake reflection",<br/>"size": "1024x1024",<br/>"quality": "high"<br/>} |
| `xOnBehalfOf`                                                                                                                         | `*string`                                                                                                                             | :heavy_minus_sign:                                                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                                                   |                                                                                                                                       |
| `opts`                                                                                                                                | [][operations.Option](../../models/operations/option.md)                                                                              | :heavy_minus_sign:                                                                                                                    | The options for this request.                                                                                                         |                                                                                                                                       |

### Response

**[*operations.CreateImageResponse](../../models/operations/createimageresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |