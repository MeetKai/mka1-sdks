# ResponseContentPartAddedEvent

## Example Usage

```typescript
import { ResponseContentPartAddedEvent } from "@meetkai/mka1/models/components";

let value: ResponseContentPartAddedEvent = {
  type: "response.content_part.added",
  sequenceNumber: 45555,
  itemId: "<id>",
  outputIndex: 506959,
  contentIndex: 331465,
  part: {
    type: "reasoning_text",
    text: "<value>",
  },
};
```

## Fields

| Field                           | Type                            | Required                        | Description                     |
| ------------------------------- | ------------------------------- | ------------------------------- | ------------------------------- |
| `type`                          | *"response.content_part.added"* | :heavy_check_mark:              | N/A                             |
| `sequenceNumber`                | *number*                        | :heavy_check_mark:              | N/A                             |
| `itemId`                        | *string*                        | :heavy_check_mark:              | N/A                             |
| `outputIndex`                   | *number*                        | :heavy_check_mark:              | N/A                             |
| `contentIndex`                  | *number*                        | :heavy_check_mark:              | N/A                             |
| `part`                          | *components.Part*               | :heavy_check_mark:              | N/A                             |