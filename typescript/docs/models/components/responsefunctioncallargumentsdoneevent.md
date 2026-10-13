# ResponseFunctionCallArgumentsDoneEvent

## Example Usage

```typescript
import { ResponseFunctionCallArgumentsDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseFunctionCallArgumentsDoneEvent = {
  type: "response.function_call_arguments.done",
  sequenceNumber: 740062,
  itemId: "<id>",
  outputIndex: 582151,
  name: "<value>",
  arguments: "<value>",
};
```

## Fields

| Field                                     | Type                                      | Required                                  | Description                               |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `type`                                    | *"response.function_call_arguments.done"* | :heavy_check_mark:                        | N/A                                       |
| `sequenceNumber`                          | *number*                                  | :heavy_check_mark:                        | N/A                                       |
| `itemId`                                  | *string*                                  | :heavy_check_mark:                        | N/A                                       |
| `outputIndex`                             | *number*                                  | :heavy_check_mark:                        | N/A                                       |
| `name`                                    | *string*                                  | :heavy_check_mark:                        | N/A                                       |
| `arguments`                               | *string*                                  | :heavy_check_mark:                        | N/A                                       |