# CompoundFilter

## Example Usage

```typescript
import { CompoundFilter } from "@meetkai/mka1/models/components";

let value: CompoundFilter = {
  type: "and",
  filters: [],
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | [components.CompoundFilterType](../../models/components/compoundfiltertype.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `filters`                                                                      | *components.Filters*[]                                                         | :heavy_check_mark:                                                             | N/A                                                                            |