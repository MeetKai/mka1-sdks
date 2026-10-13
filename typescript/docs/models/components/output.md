# Output

Result of the executed command.

## Example Usage

```typescript
import { Output } from "@meetkai/mka1/models/components";

let value: Output = {
  stdout: "<value>",
  stderr: "<value>",
  outcome: {
    type: "timeout",
    exitCode: 589719,
  },
};
```

## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `stdout`                                                 | *string*                                                 | :heavy_check_mark:                                       | Standard output from the command.                        |
| `stderr`                                                 | *string*                                                 | :heavy_check_mark:                                       | Standard error from the command.                         |
| `outcome`                                                | [components.Outcome](../../models/components/outcome.md) | :heavy_check_mark:                                       | N/A                                                      |