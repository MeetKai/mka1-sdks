# GetConversationsUsageData


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Object`                                    | `string`                                    | :heavy_check_mark:                          | N/A                                         |
| `StartTime`                                 | `int64`                                     | :heavy_check_mark:                          | Unix timestamp of bucket start (inclusive)  |
| `EndTime`                                   | `int64`                                     | :heavy_check_mark:                          | Unix timestamp of bucket end (exclusive)    |
| `Results`                                   | []`any`                                     | :heavy_check_mark:                          | Array of usage results for this time bucket |