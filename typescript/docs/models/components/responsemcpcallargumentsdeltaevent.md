# ResponseMCPCallArgumentsDeltaEvent

## Example Usage

```typescript
import { ResponseMCPCallArgumentsDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseMCPCallArgumentsDeltaEvent = {
  type: "response.mcp_call_arguments.delta",
  sequenceNumber: 75488,
  itemId: "<id>",
  outputIndex: 90432,
  delta: "<value>",
};
```

## Fields

| Field                                 | Type                                  | Required                              | Description                           |
| ------------------------------------- | ------------------------------------- | ------------------------------------- | ------------------------------------- |
| `type`                                | *"response.mcp_call_arguments.delta"* | :heavy_check_mark:                    | N/A                                   |
| `sequenceNumber`                      | *number*                              | :heavy_check_mark:                    | N/A                                   |
| `itemId`                              | *string*                              | :heavy_check_mark:                    | N/A                                   |
| `outputIndex`                         | *number*                              | :heavy_check_mark:                    | N/A                                   |
| `delta`                               | *string*                              | :heavy_check_mark:                    | N/A                                   |