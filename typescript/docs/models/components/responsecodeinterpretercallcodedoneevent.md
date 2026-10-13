# ResponseCodeInterpreterCallCodeDoneEvent

## Example Usage

```typescript
import { ResponseCodeInterpreterCallCodeDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseCodeInterpreterCallCodeDoneEvent = {
  type: "response.code_interpreter_call_code.done",
  sequenceNumber: 574292,
  itemId: "<id>",
  outputIndex: 366929,
  code: "<value>",
};
```

## Fields

| Field                                        | Type                                         | Required                                     | Description                                  |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| `type`                                       | *"response.code_interpreter_call_code.done"* | :heavy_check_mark:                           | N/A                                          |
| `sequenceNumber`                             | *number*                                     | :heavy_check_mark:                           | N/A                                          |
| `itemId`                                     | *string*                                     | :heavy_check_mark:                           | N/A                                          |
| `outputIndex`                                | *number*                                     | :heavy_check_mark:                           | N/A                                          |
| `code`                                       | *string*                                     | :heavy_check_mark:                           | N/A                                          |