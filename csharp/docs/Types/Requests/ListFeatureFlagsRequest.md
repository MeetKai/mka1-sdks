# ListFeatureFlagsRequest


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `IncludeArchived`                                                             | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           |
| `ProjectId`                                                                   | *string*                                                                      | :heavy_minus_sign:                                                            | Return only flags assigned to this project. Flag keys remain globally unique. |
| `XOnBehalfOf`                                                                 | *string*                                                                      | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |