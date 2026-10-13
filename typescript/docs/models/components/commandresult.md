# CommandResult

## Example Usage

```typescript
import { CommandResult } from "@meetkai/mka1/models/components";

let value: CommandResult = {
  sessionId: "<id>",
  command: "<value>",
  cwd: "<value>",
  exitCode: 789739,
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `sessionId`                                                                        | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `command`                                                                          | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `args`                                                                             | *string*[]                                                                         | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `cwd`                                                                              | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `stdout`                                                                           | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `stderr`                                                                           | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `exitCode`                                                                         | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `filesChanged`                                                                     | *string*[]                                                                         | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `resourceUsage`                                                                    | [components.RuntimeResourceUsage](../../models/components/runtimeresourceusage.md) | :heavy_minus_sign:                                                                 | N/A                                                                                |