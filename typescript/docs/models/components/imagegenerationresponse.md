# ImageGenerationResponse

Response from the image generation endpoint containing the generated images and metadata.

## Example Usage

```typescript
import { ImageGenerationResponse } from "@meetkai/mka1/models/components";

let value: ImageGenerationResponse = {
  created: 1704067200,
  data: [
    {
      url: "https://example.com/generated-image.png",
      revisedPrompt:
        "A serene mountain landscape at sunset with a calm lake reflection, digital art style",
    },
  ],
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `created`                                                                                          | *number*                                                                                           | :heavy_check_mark:                                                                                 | The Unix timestamp (in seconds) of when the image generation was completed.                        |
| `data`                                                                                             | [components.ImageGenerationResponseData](../../models/components/imagegenerationresponsedata.md)[] | :heavy_check_mark:                                                                                 | A list of image objects containing the generated image data.                                       |