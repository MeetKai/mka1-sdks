# Three2

## Example Usage

```typescript
import { Three2 } from "@meetkai/mka1/models/components";

let value: Three2 = {
  type: "mcp",
  mcpServerId: "<id>",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `type`                                                                           | [components.ToolDefinition3Type](../../models/components/tooldefinition3type.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `serverLabel`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `mcpServerId`                                                                    | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `mcpCredentialId`                                                                | *string*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `serverUrl`                                                                      | *string*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `serverDescription`                                                              | *string*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `authorization`                                                                  | *string*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `requireApproval`                                                                | *components.ThreeRequireApproval*                                                | :heavy_minus_sign:                                                               | N/A                                                                              |
| `allowedTools`                                                                   | *components.ToolDefinition3AllowedTools*                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `headers`                                                                        | Record<string, *string*>                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |