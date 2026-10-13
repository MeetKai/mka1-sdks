# CodeResult

## Example Usage

```typescript
import { CodeResult } from "@meetkai/mka1/models/components";

let value: CodeResult = {
  sessionId: "<id>",
  runtime: "python3",
  cwd: "<value>",
  exitCode: 834333,
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `sessionId`                                                                        | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `runtime`                                                                          | [components.CodeRuntime](../../models/components/coderuntime.md)                   | :heavy_check_mark:                                                                 | N/A                                                                                |
| `cwd`                                                                              | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `stdout`                                                                           | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `stderr`                                                                           | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `exitCode`                                                                         | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `filesChanged`                                                                     | *string*[]                                                                         | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `resourceUsage`                                                                    | [components.RuntimeResourceUsage](../../models/components/runtimeresourceusage.md) | :heavy_minus_sign:                                                                 | N/A                                                                                |