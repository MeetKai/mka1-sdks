# ImageGenerationCall

Image generation call item: A tool-call record for image generation, including status and result URL.

## Example Usage

```typescript
import { ImageGenerationCall } from "@meetkai/mka1/models/components";

let value: ImageGenerationCall = {
  type: "image_generation_call",
  id: "<id>",
  status: "<value>",
  result: "<value>",
};
```

## Fields

| Field                     | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `type`                    | *"image_generation_call"* | :heavy_check_mark:        | N/A                       |
| `id`                      | *string*                  | :heavy_check_mark:        | N/A                       |
| `status`                  | *string*                  | :heavy_check_mark:        | N/A                       |
| `result`                  | *string*                  | :heavy_check_mark:        | N/A                       |
| `background`              | *string*                  | :heavy_minus_sign:        | N/A                       |
| `outputFormat`            | *string*                  | :heavy_minus_sign:        | N/A                       |
| `quality`                 | *string*                  | :heavy_minus_sign:        | N/A                       |
| `size`                    | *string*                  | :heavy_minus_sign:        | N/A                       |
| `revisedPrompt`           | *string*                  | :heavy_minus_sign:        | N/A                       |