# LocalShellCallWithId

Local shell call item: A local-shell execution request with command details and execution status.

## Example Usage

```typescript
import { LocalShellCallWithId } from "@meetkai/mka1/models/components";

let value: LocalShellCallWithId = {
  type: "local_shell_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "exec",
    command: [
      "<value 1>",
      "<value 2>",
    ],
    env: {
      "key": "<value>",
      "key1": "<value>",
      "key2": "<value>",
    },
  },
  status: "<value>",
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `type`                                                                     | *"local_shell_call"*                                                       | :heavy_check_mark:                                                         | N/A                                                                        |
| `id`                                                                       | *string*                                                                   | :heavy_check_mark:                                                         | The unique ID of the message.                                              |
| `callId`                                                                   | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `action`                                                                   | [components.LocalShellAction](../../models/components/localshellaction.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `status`                                                                   | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `responseId`                                                               | *string*                                                                   | :heavy_minus_sign:                                                         | The ID of the response that created this item, if any.                     |
| `metadata`                                                                 | Record<string, *string*>                                                   | :heavy_minus_sign:                                                         | Metadata from the response that created this item, if any.                 |