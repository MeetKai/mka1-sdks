# Filter4

Combine multiple filters using 'and' or 'or'.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Type`                                                                        | [FilterType5](../../Types/Components/FilterType5.md)                          | :heavy_check_mark:                                                            | Type of operation: 'and' or 'or'.                                             |
| `Filters`                                                                     | List<[FilterUnion1](../../Types/Components/FilterUnion1.md)>                  | :heavy_check_mark:                                                            | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter. |