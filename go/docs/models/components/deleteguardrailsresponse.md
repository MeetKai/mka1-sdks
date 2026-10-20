# DeleteGuardrailsResponse


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `Object`                                                       | `string`                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `Deleted`                                                      | `bool`                                                         | :heavy_check_mark:                                             | Whether a policy row was deleted                               |
| `TeamID`                                                       | `*string`                                                      | :heavy_check_mark:                                             | Team the deleted policy targeted; null for the org-wide policy |