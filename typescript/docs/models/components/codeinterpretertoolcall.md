# CodeInterpreterToolCall

Code interpreter call item: A tool-call record for code execution, including code, container, outputs, and status.

## Example Usage

```typescript
import { CodeInterpreterToolCall } from "@meetkai/mka1/models/components";

let value: CodeInterpreterToolCall = {
  type: "code_interpreter_call",
  id: "<id>",
  code: "<value>",
  containerId: "<id>",
  outputs: [],
  status: "in_progress",
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `type`                                                                                               | *"code_interpreter_call"*                                                                            | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `id`                                                                                                 | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `code`                                                                                               | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `containerId`                                                                                        | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `outputs`                                                                                            | *components.CodeInterpreterOutput*[]                                                                 | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `status`                                                                                             | [components.CodeInterpreterToolCallStatus](../../models/components/codeinterpretertoolcallstatus.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |