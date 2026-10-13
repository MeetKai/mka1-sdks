# ShellCall

Shell call item: A hosted-container shell execution request with a command and status.

## Example Usage

```typescript
import { ShellCall } from "@meetkai/mka1/models/components";

let value: ShellCall = {
  type: "shell_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "exec",
  },
  status: "completed",
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `type`                                                                   | *"shell_call"*                                                           | :heavy_check_mark:                                                       | N/A                                                                      |
| `id`                                                                     | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `callId`                                                                 | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `action`                                                                 | [components.ShellCallAction](../../models/components/shellcallaction.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `status`                                                                 | [components.ShellCallStatus](../../models/components/shellcallstatus.md) | :heavy_check_mark:                                                       | N/A                                                                      |