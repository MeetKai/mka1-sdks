# ImageGenerationCallWithId

Image generation call item: A tool-call record for image generation, including status and result URL.

## Example Usage

```typescript
import { ImageGenerationCallWithId } from "@meetkai/mka1/models/components";

let value: ImageGenerationCallWithId = {
  type: "image_generation_call",
  id: "<id>",
  status: "<value>",
  result: "<value>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"image_generation_call"*                                  | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `status`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `result`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `background`                                               | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `outputFormat`                                             | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `quality`                                                  | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `size`                                                     | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `revisedPrompt`                                            | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |