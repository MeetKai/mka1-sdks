# ResponseImageGenerationCallInProgressEvent

## Example Usage

```typescript
import { ResponseImageGenerationCallInProgressEvent } from "@meetkai/mka1/models/components";

let value: ResponseImageGenerationCallInProgressEvent = {
  type: "response.image_generation_call.in_progress",
  sequenceNumber: 526513,
  itemId: "<id>",
  outputIndex: 835477,
};
```

## Fields

| Field                                                                                                                                  | Type                                                                                                                                   | Required                                                                                                                               | Description                                                                                                                            |
| -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                                                 | *"response.image_generation_call.in_progress"*                                                                                         | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `sequenceNumber`                                                                                                                       | *number*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `itemId`                                                                                                                               | *string*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `outputIndex`                                                                                                                          | *number*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `args`                                                                                                                                 | [components.ResponseImageGenerationCallInProgressEventArgs](../../models/components/responseimagegenerationcallinprogresseventargs.md) | :heavy_minus_sign:                                                                                                                     | N/A                                                                                                                                    |