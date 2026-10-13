# ToolDefinition4

## Example Usage

```typescript
import { ToolDefinition4 } from "@meetkai/mka1/models/components";

let value: ToolDefinition4 = {
  type: "file_search",
  vectorStoreIds: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `type`                                                                                             | [components.ToolDefinition4Type](../../models/components/tooldefinition4type.md)                   | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `vectorStoreIds`                                                                                   | *string*[]                                                                                         | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `filters`                                                                                          | *components.ToolDefinition4Filters*                                                                | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `maxNumResults`                                                                                    | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `rankingOptions`                                                                                   | [components.ToolDefinitionRankingOptions](../../models/components/tooldefinitionrankingoptions.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |