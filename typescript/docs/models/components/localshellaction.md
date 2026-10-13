# LocalShellAction

## Example Usage

```typescript
import { LocalShellAction } from "@meetkai/mka1/models/components";

let value: LocalShellAction = {
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
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `type`                   | *"exec"*                 | :heavy_check_mark:       | N/A                      |
| `command`                | *string*[]               | :heavy_check_mark:       | N/A                      |
| `env`                    | Record<string, *string*> | :heavy_check_mark:       | N/A                      |
| `timeoutMs`              | *number*                 | :heavy_minus_sign:       | N/A                      |
| `user`                   | *string*                 | :heavy_minus_sign:       | N/A                      |
| `workingDirectory`       | *string*                 | :heavy_minus_sign:       | N/A                      |