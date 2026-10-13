# Three1

## Example Usage

```typescript
import { Three1 } from "@meetkai/mka1/models/components";

let value: Three1 = {
  type: "mcp",
  serverLabel: "<value>",
};
```

## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `type`                                                       | [components.ThreeType](../../models/components/threetype.md) | :heavy_check_mark:                                           | N/A                                                          |
| `serverLabel`                                                | *string*                                                     | :heavy_check_mark:                                           | N/A                                                          |
| `mcpServerId`                                                | *string*                                                     | :heavy_minus_sign:                                           | N/A                                                          |
| `mcpCredentialId`                                            | *string*                                                     | :heavy_minus_sign:                                           | N/A                                                          |
| `serverUrl`                                                  | *string*                                                     | :heavy_minus_sign:                                           | N/A                                                          |
| `serverDescription`                                          | *string*                                                     | :heavy_minus_sign:                                           | N/A                                                          |
| `authorization`                                              | *string*                                                     | :heavy_minus_sign:                                           | N/A                                                          |
| `requireApproval`                                            | *components.RequireApproval*                                 | :heavy_minus_sign:                                           | N/A                                                          |
| `allowedTools`                                               | *components.ThreeAllowedTools*                               | :heavy_minus_sign:                                           | N/A                                                          |
| `headers`                                                    | Record<string, *string*>                                     | :heavy_minus_sign:                                           | N/A                                                          |