# ResponseFunctionCallArgumentsDeltaEvent

## Example Usage

```typescript
import { ResponseFunctionCallArgumentsDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseFunctionCallArgumentsDeltaEvent = {
  type: "response.function_call_arguments.delta",
  sequenceNumber: 112607,
  itemId: "<id>",
  outputIndex: 173885,
  delta: "<value>",
};
```

## Fields

| Field                                      | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `type`                                     | *"response.function_call_arguments.delta"* | :heavy_check_mark:                         | N/A                                        |
| `sequenceNumber`                           | *number*                                   | :heavy_check_mark:                         | N/A                                        |
| `itemId`                                   | *string*                                   | :heavy_check_mark:                         | N/A                                        |
| `outputIndex`                              | *number*                                   | :heavy_check_mark:                         | N/A                                        |
| `delta`                                    | *string*                                   | :heavy_check_mark:                         | N/A                                        |