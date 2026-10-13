# ResponseImageGenerationCallCompletedEvent

## Example Usage

```typescript
import { ResponseImageGenerationCallCompletedEvent } from "@meetkai/mka1/models/components";

let value: ResponseImageGenerationCallCompletedEvent = {
  type: "response.image_generation_call.completed",
  sequenceNumber: 269803,
  itemId: "<id>",
  outputIndex: 259758,
};
```

## Fields

| Field                                        | Type                                         | Required                                     | Description                                  |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| `type`                                       | *"response.image_generation_call.completed"* | :heavy_check_mark:                           | N/A                                          |
| `sequenceNumber`                             | *number*                                     | :heavy_check_mark:                           | N/A                                          |
| `itemId`                                     | *string*                                     | :heavy_check_mark:                           | N/A                                          |
| `outputIndex`                                | *number*                                     | :heavy_check_mark:                           | N/A                                          |
| `functionCallOutput`                         | *string*                                     | :heavy_minus_sign:                           | N/A                                          |