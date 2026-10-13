# CommandRequest

## Example Usage

```typescript
import { CommandRequest } from "@meetkai/mka1/models/components";

let value: CommandRequest = {
  sessionId: "<id>",
  command: "<value>",
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `sessionId`              | *string*                 | :heavy_check_mark:       | N/A                      |
| `sessionToken`           | *string*                 | :heavy_minus_sign:       | N/A                      |
| `commandRequestId`       | *string*                 | :heavy_minus_sign:       | N/A                      |
| `command`                | *string*                 | :heavy_check_mark:       | N/A                      |
| `args`                   | *string*[]               | :heavy_minus_sign:       | N/A                      |
| `cwd`                    | *string*                 | :heavy_minus_sign:       | N/A                      |
| `env`                    | Record<string, *string*> | :heavy_minus_sign:       | N/A                      |
| `timeoutSeconds`         | *number*                 | :heavy_minus_sign:       | N/A                      |