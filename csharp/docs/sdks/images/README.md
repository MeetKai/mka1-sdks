# Llm.Images

## Overview

### Available Operations

* [Create](#create) - Generate images from text descriptions

## Create

Creates AI-generated images from text descriptions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createImage" method="post" path="/api/v1/llm/images/generations" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Images.CreateAsync(body: new ImageGenerationRequest() {
    Prompt = "A serene mountain landscape at sunset with a lake reflection",
    Quality = ImageGenerationRequestQuality.Hd,
});

// handle response
```

### Parameters

| Parameter                                                                                                                             | Type                                                                                                                                  | Required                                                                                                                              | Description                                                                                                                           | Example                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| `Body`                                                                                                                                | [ImageGenerationRequest](../../Types/Components/ImageGenerationRequest.md)                                                            | :heavy_check_mark:                                                                                                                    | N/A                                                                                                                                   | {<br/>"model": "auto",<br/>"prompt": "A serene mountain landscape at sunset with a lake reflection",<br/>"size": "1024x1024",<br/>"quality": "high"<br/>} |
| `XOnBehalfOf`                                                                                                                         | *string*                                                                                                                              | :heavy_minus_sign:                                                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                                                   |                                                                                                                                       |

### Response

**[CreateImageResponse](../../Types/Requests/CreateImageResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |