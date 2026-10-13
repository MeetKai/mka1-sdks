# ToolDefinition2

## Example Usage

```typescript
import { ToolDefinition2 } from "@meetkai/mka1/models/components";

let value: ToolDefinition2 = {
  type: "function",
  name: "<value>",
  parameters: {
    "key": "<value>",
    "key1": "<value>",
  },
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `type`                                                                           | [components.ToolDefinition2Type](../../models/components/tooldefinition2type.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `name`                                                                           | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `description`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | N/A                                                                              |
| `strict`                                                                         | *boolean*                                                                        | :heavy_minus_sign:                                                               | N/A                                                                              |
| `deferLoading`                                                                   | *boolean*                                                                        | :heavy_minus_sign:                                                               | N/A                                                                              |
| `parameters`                                                                     | Record<string, *any*>                                                            | :heavy_check_mark:                                                               | N/A                                                                              |