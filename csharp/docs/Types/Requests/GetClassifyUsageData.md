# GetClassifyUsageData


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Object`                                    | *string*                                    | :heavy_check_mark:                          | N/A                                         |
| `StartTime`                                 | *long*                                      | :heavy_check_mark:                          | Unix timestamp of bucket start (inclusive)  |
| `EndTime`                                   | *long*                                      | :heavy_check_mark:                          | Unix timestamp of bucket end (exclusive)    |
| `Results`                                   | List<*object*>                              | :heavy_check_mark:                          | Array of usage results for this time bucket |