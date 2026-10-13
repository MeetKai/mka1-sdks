# FileSearchComparisonFilter

## Example Usage

```typescript
import { FileSearchComparisonFilter } from "@meetkai/mka1/models/components";

let value: FileSearchComparisonFilter = {
  type: "lt",
  key: "<key>",
  value: true,
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                 | [components.FileSearchComparisonFilterType](../../models/components/filesearchcomparisonfiltertype.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `key`                                                                                                  | *string*                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `value`                                                                                                | *components.FileSearchComparisonFilterValue*                                                           | :heavy_check_mark:                                                                                     | N/A                                                                                                    |