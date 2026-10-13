# ResponseContentPartDoneEvent

## Example Usage

```typescript
import { ResponseContentPartDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseContentPartDoneEvent = {
  type: "response.content_part.done",
  sequenceNumber: 133267,
  itemId: "<id>",
  outputIndex: 683752,
  contentIndex: 61029,
  part: {
    type: "refusal",
    refusal: "<value>",
  },
};
```

## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `type`                                        | *"response.content_part.done"*                | :heavy_check_mark:                            | N/A                                           |
| `sequenceNumber`                              | *number*                                      | :heavy_check_mark:                            | N/A                                           |
| `itemId`                                      | *string*                                      | :heavy_check_mark:                            | N/A                                           |
| `outputIndex`                                 | *number*                                      | :heavy_check_mark:                            | N/A                                           |
| `contentIndex`                                | *number*                                      | :heavy_check_mark:                            | N/A                                           |
| `part`                                        | *components.ResponseContentPartDoneEventPart* | :heavy_check_mark:                            | N/A                                           |