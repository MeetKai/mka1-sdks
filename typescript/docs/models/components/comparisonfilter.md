# ComparisonFilter

## Example Usage

```typescript
import { ComparisonFilter } from "@meetkai/mka1/models/components";

let value: ComparisonFilter = {
  type: "lte",
  key: "<key>",
  value: true,
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `type`                                                                             | [components.ComparisonFilterType](../../models/components/comparisonfiltertype.md) | :heavy_check_mark:                                                                 | N/A                                                                                |
| `key`                                                                              | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `value`                                                                            | *components.Value*                                                                 | :heavy_check_mark:                                                                 | N/A                                                                                |