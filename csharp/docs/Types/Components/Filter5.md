# Filter5

Combine multiple filters using 'and' or 'or'.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Type`                                                                        | [FilterType3](../../Types/Components/FilterType3.md)                          | :heavy_check_mark:                                                            | Type of operation: 'and' or 'or'.                                             |
| `Filters`                                                                     | List<[FilterUnion2](../../Types/Components/FilterUnion2.md)>                  | :heavy_check_mark:                                                            | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter. |