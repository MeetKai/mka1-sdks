# FileSearchCompoundFilter

## Example Usage

```typescript
import { FileSearchCompoundFilter } from "@meetkai/mka1/models/components";

let value: FileSearchCompoundFilter = {
  type: "and",
  filters: [],
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `type`                                                                                             | [components.FileSearchCompoundFilterType](../../models/components/filesearchcompoundfiltertype.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `filters`                                                                                          | *components.FileSearchCompoundFilterFilters*[]                                                     | :heavy_check_mark:                                                                                 | N/A                                                                                                |