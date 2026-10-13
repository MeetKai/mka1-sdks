# ResponseToolSearchCallCompletedEvent

## Example Usage

```typescript
import { ResponseToolSearchCallCompletedEvent } from "@meetkai/mka1/models/components";

let value: ResponseToolSearchCallCompletedEvent = {
  type: "response.tool_search_call.completed",
  sequenceNumber: 255576,
  itemId: "<id>",
  outputIndex: 215592,
};
```

## Fields

| Field                                   | Type                                    | Required                                | Description                             |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `type`                                  | *"response.tool_search_call.completed"* | :heavy_check_mark:                      | N/A                                     |
| `sequenceNumber`                        | *number*                                | :heavy_check_mark:                      | N/A                                     |
| `itemId`                                | *string*                                | :heavy_check_mark:                      | N/A                                     |
| `outputIndex`                           | *number*                                | :heavy_check_mark:                      | N/A                                     |
| `functionCallOutput`                    | *string*                                | :heavy_minus_sign:                      | N/A                                     |