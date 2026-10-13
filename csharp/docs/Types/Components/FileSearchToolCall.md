# FileSearchToolCall

File search call item: A tool-call record for semantic file search, including query terms, status, and optional results.


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Type`                                                                         | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `Id`                                                                           | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `Queries`                                                                      | List<*string*>                                                                 | :heavy_check_mark:                                                             | N/A                                                                            |
| `Status`                                                                       | [FileSearchToolCallStatus](../../Types/Components/FileSearchToolCallStatus.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `Results`                                                                      | List<[FileSearchResult](../../Types/Components/FileSearchResult.md)>           | :heavy_minus_sign:                                                             | N/A                                                                            |