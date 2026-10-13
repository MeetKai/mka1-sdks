# Filter4

Combine multiple filters using 'and' or 'or'.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `type`                                                                        | [models.FilterType5](../models/filtertype5.md)                                | :heavy_check_mark:                                                            | Type of operation: 'and' or 'or'.                                             |
| `filters`                                                                     | List[[models.FilterUnion1](../models/filterunion1.md)]                        | :heavy_check_mark:                                                            | Array of filters to combine. Items can be ComparisonFilter or CompoundFilter. |