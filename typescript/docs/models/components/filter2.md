# Filter2

Combine multiple filters using 'and' or 'or'.

## Example Usage

```typescript
import { Filter2 } from "@meetkai/mka1/models/components";

let value: Filter2 = {
  type: "and",
  filters: [],
};
```

## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `type`                                                                        | [components.Filter2Type](../../models/components/filter2type.md)              | :heavy_check_mark:                                                            | Type of operation: 'and' or 'or'.                                             |
| `filters`                                                                     | *components.FilterFilters*[]                                                  | :heavy_check_mark:                                                            | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter. |