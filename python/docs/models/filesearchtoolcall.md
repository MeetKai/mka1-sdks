# FileSearchToolCall

File search call item: A tool-call record for semantic file search, including query terms, status, and optional results.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `type`                                                                   | *Literal["file_search_call"]*                                            | :heavy_check_mark:                                                       | N/A                                                                      |
| `id`                                                                     | *str*                                                                    | :heavy_check_mark:                                                       | N/A                                                                      |
| `queries`                                                                | List[*str*]                                                              | :heavy_check_mark:                                                       | N/A                                                                      |
| `status`                                                                 | [models.FileSearchToolCallStatus](../models/filesearchtoolcallstatus.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `results`                                                                | List[[models.FileSearchResult](../models/filesearchresult.md)]           | :heavy_minus_sign:                                                       | N/A                                                                      |