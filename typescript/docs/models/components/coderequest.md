# CodeRequest

## Example Usage

```typescript
import { CodeRequest } from "@meetkai/mka1/models/components";

let value: CodeRequest = {
  sessionId: "<id>",
  code: "<value>",
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `sessionId`                                                      | *string*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `sessionToken`                                                   | *string*                                                         | :heavy_minus_sign:                                               | N/A                                                              |
| `runtime`                                                        | [components.CodeRuntime](../../models/components/coderuntime.md) | :heavy_minus_sign:                                               | N/A                                                              |
| `code`                                                           | *string*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `cwd`                                                            | *string*                                                         | :heavy_minus_sign:                                               | N/A                                                              |
| `env`                                                            | Record<string, *string*>                                         | :heavy_minus_sign:                                               | N/A                                                              |
| `timeoutSeconds`                                                 | *number*                                                         | :heavy_minus_sign:                                               | N/A                                                              |