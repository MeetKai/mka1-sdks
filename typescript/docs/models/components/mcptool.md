# MCPTool

## Example Usage

```typescript
import { MCPTool } from "@meetkai/mka1/models/components";

let value: MCPTool = {
  name: "<value>",
  inputSchema: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `name`                | *string*              | :heavy_check_mark:    | N/A                   |
| `inputSchema`         | Record<string, *any*> | :heavy_check_mark:    | N/A                   |
| `annotations`         | Record<string, *any*> | :heavy_minus_sign:    | N/A                   |
| `description`         | *string*              | :heavy_minus_sign:    | N/A                   |