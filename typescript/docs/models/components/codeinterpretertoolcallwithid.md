# CodeInterpreterToolCallWithId

Code interpreter call item: A tool-call record for code execution, including code, container, outputs, and status.

## Example Usage

```typescript
import { CodeInterpreterToolCallWithId } from "@meetkai/mka1/models/components";

let value: CodeInterpreterToolCallWithId = {
  type: "code_interpreter_call",
  id: "<id>",
  code: "<value>",
  containerId: "<id>",
  outputs: [],
  status: "incomplete",
};
```

## Fields

| Field                                                                                                            | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                           | *"code_interpreter_call"*                                                                                        | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `id`                                                                                                             | *string*                                                                                                         | :heavy_check_mark:                                                                                               | The unique ID of the message.                                                                                    |
| `code`                                                                                                           | *string*                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `containerId`                                                                                                    | *string*                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `outputs`                                                                                                        | *components.CodeInterpreterOutput*[]                                                                             | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `status`                                                                                                         | [components.CodeInterpreterToolCallWithIdStatus](../../models/components/codeinterpretertoolcallwithidstatus.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `responseId`                                                                                                     | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | The ID of the response that created this item, if any.                                                           |
| `metadata`                                                                                                       | Record<string, *string*>                                                                                         | :heavy_minus_sign:                                                                                               | Metadata from the response that created this item, if any.                                                       |