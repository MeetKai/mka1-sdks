# ResponseImageGenerationCallPartialImageEvent

## Example Usage

```typescript
import { ResponseImageGenerationCallPartialImageEvent } from "@meetkai/mka1/models/components";

let value: ResponseImageGenerationCallPartialImageEvent = {
  type: "response.image_generation_call.partial_image",
  sequenceNumber: 382563,
  itemId: "<id>",
  outputIndex: 409770,
  partialImageIndex: 529018,
  partialImageB64: "<value>",
};
```

## Fields

| Field                                            | Type                                             | Required                                         | Description                                      |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| `type`                                           | *"response.image_generation_call.partial_image"* | :heavy_check_mark:                               | N/A                                              |
| `sequenceNumber`                                 | *number*                                         | :heavy_check_mark:                               | N/A                                              |
| `itemId`                                         | *string*                                         | :heavy_check_mark:                               | N/A                                              |
| `outputIndex`                                    | *number*                                         | :heavy_check_mark:                               | N/A                                              |
| `partialImageIndex`                              | *number*                                         | :heavy_check_mark:                               | N/A                                              |
| `partialImageB64`                                | *string*                                         | :heavy_check_mark:                               | N/A                                              |