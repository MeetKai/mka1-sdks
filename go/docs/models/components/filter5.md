# Filter5

Combine multiple filters using 'and' or 'or'.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Type`                                                                        | [components.FilterType3](../../models/components/filtertype3.md)              | :heavy_check_mark:                                                            | Type of operation: 'and' or 'or'.                                             |
| `Filters`                                                                     | [][components.FilterUnion2](../../models/components/filterunion2.md)          | :heavy_check_mark:                                                            | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter. |