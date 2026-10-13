# ResponseCodeInterpreterCallCodeDeltaEvent

## Example Usage

```typescript
import { ResponseCodeInterpreterCallCodeDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseCodeInterpreterCallCodeDeltaEvent = {
  type: "response.code_interpreter_call_code.delta",
  sequenceNumber: 420654,
  itemId: "<id>",
  outputIndex: 975612,
  delta: "<value>",
};
```

## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `type`                                        | *"response.code_interpreter_call_code.delta"* | :heavy_check_mark:                            | N/A                                           |
| `sequenceNumber`                              | *number*                                      | :heavy_check_mark:                            | N/A                                           |
| `itemId`                                      | *string*                                      | :heavy_check_mark:                            | N/A                                           |
| `outputIndex`                                 | *number*                                      | :heavy_check_mark:                            | N/A                                           |
| `delta`                                       | *string*                                      | :heavy_check_mark:                            | N/A                                           |