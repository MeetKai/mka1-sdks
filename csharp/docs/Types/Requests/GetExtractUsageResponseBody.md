# GetExtractUsageResponseBody

OK


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Object`                                                                 | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Data`                                                                   | List<[GetExtractUsageData](../../Types/Requests/GetExtractUsageData.md)> | :heavy_check_mark:                                                       | N/A                                                                      |
| `HasMore`                                                                | *bool*                                                                   | :heavy_check_mark:                                                       | Whether there are more pages                                             |
| `NextPage`                                                               | *string*                                                                 | :heavy_check_mark:                                                       | Cursor for next page, null if no more pages                              |