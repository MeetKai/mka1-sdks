# ShellCallWithId

Shell call item: A hosted-container shell execution request with a command and status.

## Example Usage

```typescript
import { ShellCallWithId } from "@meetkai/mka1/models/components";

let value: ShellCallWithId = {
  type: "shell_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "exec",
  },
  status: "incomplete",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `type`                                                                               | *"shell_call"*                                                                       | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | The unique ID of the message.                                                        |
| `callId`                                                                             | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `action`                                                                             | [components.ShellCallAction](../../models/components/shellcallaction.md)             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `status`                                                                             | [components.ShellCallWithIdStatus](../../models/components/shellcallwithidstatus.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `responseId`                                                                         | *string*                                                                             | :heavy_minus_sign:                                                                   | The ID of the response that created this item, if any.                               |
| `metadata`                                                                           | Record<string, *string*>                                                             | :heavy_minus_sign:                                                                   | Metadata from the response that created this item, if any.                           |