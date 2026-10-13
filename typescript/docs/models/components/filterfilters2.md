# FilterFilters2

Combine multiple filters using 'and' or 'or'.

## Example Usage

```typescript
import { FilterFilters2 } from "@meetkai/mka1/models/components";

let value: FilterFilters2 = {
  type: "or",
  filters: [
    "<value>",
  ],
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | [components.FilterFilters2Type](../../models/components/filterfilters2type.md) | :heavy_check_mark:                                                             | Type of operation: 'and' or 'or'.                                              |
| `filters`                                                                      | *components.FilterFiltersFilters*[]                                            | :heavy_check_mark:                                                             | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter.  |