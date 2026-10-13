# GetExtractUsageData


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `object`                                    | *Literal["bucket"]*                         | :heavy_check_mark:                          | N/A                                         |
| `start_time`                                | *int*                                       | :heavy_check_mark:                          | Unix timestamp of bucket start (inclusive)  |
| `end_time`                                  | *int*                                       | :heavy_check_mark:                          | Unix timestamp of bucket end (exclusive)    |
| `results`                                   | List[*Nullable[Any]*]                       | :heavy_check_mark:                          | Array of usage results for this time bucket |