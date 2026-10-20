# Filter4

Combine multiple filters using 'and' or 'or'.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Type`                                                                        | [components.FilterType5](../../models/components/filtertype5.md)              | :heavy_check_mark:                                                            | Type of operation: 'and' or 'or'.                                             |
| `Filters`                                                                     | [][components.FilterUnion1](../../models/components/filterunion1.md)          | :heavy_check_mark:                                                            | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter. |