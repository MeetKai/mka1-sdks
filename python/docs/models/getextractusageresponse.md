# GetExtractUsageResponse

OK


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `object`                                                             | *Literal["page"]*                                                    | :heavy_check_mark:                                                   | N/A                                                                  |
| `data`                                                               | List[[models.GetExtractUsageData](../models/getextractusagedata.md)] | :heavy_check_mark:                                                   | N/A                                                                  |
| `has_more`                                                           | *bool*                                                               | :heavy_check_mark:                                                   | Whether there are more pages                                         |
| `next_page`                                                          | *Nullable[str]*                                                      | :heavy_check_mark:                                                   | Cursor for next page, null if no more pages                          |