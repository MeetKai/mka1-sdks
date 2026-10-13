# ResponseReadFileCallCompletedEvent

## Example Usage

```typescript
import { ResponseReadFileCallCompletedEvent } from "@meetkai/mka1/models/components";

let value: ResponseReadFileCallCompletedEvent = {
  type: "response.read_file_call.completed",
  sequenceNumber: 358438,
  itemId: "<id>",
  outputIndex: 42529,
};
```

## Fields

| Field                                 | Type                                  | Required                              | Description                           |
| ------------------------------------- | ------------------------------------- | ------------------------------------- | ------------------------------------- |
| `type`                                | *"response.read_file_call.completed"* | :heavy_check_mark:                    | N/A                                   |
| `sequenceNumber`                      | *number*                              | :heavy_check_mark:                    | N/A                                   |
| `itemId`                              | *string*                              | :heavy_check_mark:                    | N/A                                   |
| `outputIndex`                         | *number*                              | :heavy_check_mark:                    | N/A                                   |
| `functionCallOutput`                  | *string*                              | :heavy_minus_sign:                    | N/A                                   |