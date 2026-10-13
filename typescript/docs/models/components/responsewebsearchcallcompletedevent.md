# ResponseWebSearchCallCompletedEvent

## Example Usage

```typescript
import { ResponseWebSearchCallCompletedEvent } from "@meetkai/mka1/models/components";

let value: ResponseWebSearchCallCompletedEvent = {
  type: "response.web_search_call.completed",
  sequenceNumber: 529005,
  itemId: "<id>",
  outputIndex: 122460,
};
```

## Fields

| Field                                  | Type                                   | Required                               | Description                            |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `type`                                 | *"response.web_search_call.completed"* | :heavy_check_mark:                     | N/A                                    |
| `sequenceNumber`                       | *number*                               | :heavy_check_mark:                     | N/A                                    |
| `itemId`                               | *string*                               | :heavy_check_mark:                     | N/A                                    |
| `outputIndex`                          | *number*                               | :heavy_check_mark:                     | N/A                                    |
| `functionCallOutput`                   | *string*                               | :heavy_minus_sign:                     | N/A                                    |