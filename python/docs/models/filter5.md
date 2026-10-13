# Filter5

Combine multiple filters using 'and' or 'or'.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `type`                                                                        | [models.FilterType3](../models/filtertype3.md)                                | :heavy_check_mark:                                                            | Type of operation: 'and' or 'or'.                                             |
| `filters`                                                                     | List[[models.FilterUnion2](../models/filterunion2.md)]                        | :heavy_check_mark:                                                            | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter. |