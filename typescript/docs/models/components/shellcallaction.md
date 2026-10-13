# ShellCallAction

## Example Usage

```typescript
import { ShellCallAction } from "@meetkai/mka1/models/components";

let value: ShellCallAction = {
  type: "exec",
};
```

## Fields

| Field                            | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `type`                           | *"exec"*                         | :heavy_check_mark:               | N/A                              |
| `command`                        | *string*                         | :heavy_minus_sign:               | Shell command to execute.        |
| `timeoutMs`                      | *number*                         | :heavy_minus_sign:               | Command timeout in milliseconds. |
| `maxOutputLength`                | *number*                         | :heavy_minus_sign:               | Maximum output characters.       |