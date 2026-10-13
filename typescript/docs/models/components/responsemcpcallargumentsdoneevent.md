# ResponseMCPCallArgumentsDoneEvent

## Example Usage

```typescript
import { ResponseMCPCallArgumentsDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseMCPCallArgumentsDoneEvent = {
  type: "response.mcp_call_arguments.done",
  sequenceNumber: 454225,
  itemId: "<id>",
  outputIndex: 172489,
  arguments: "<value>",
};
```

## Fields

| Field                                | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `type`                               | *"response.mcp_call_arguments.done"* | :heavy_check_mark:                   | N/A                                  |
| `sequenceNumber`                     | *number*                             | :heavy_check_mark:                   | N/A                                  |
| `itemId`                             | *string*                             | :heavy_check_mark:                   | N/A                                  |
| `outputIndex`                        | *number*                             | :heavy_check_mark:                   | N/A                                  |
| `arguments`                          | *string*                             | :heavy_check_mark:                   | N/A                                  |