# ResponseCompactionItem

Compaction item: A condensed summary of prior conversation history to reduce context size.


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `Type`                                                   | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `ID`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `Content`                                                | `string`                                                 | :heavy_check_mark:                                       | The compacted/summarized conversation content.           |
| `EncryptedContent`                                       | `*string`                                                | :heavy_minus_sign:                                       | Optional encrypted content for OpenAI API compatibility. |
| `CreatedBy`                                              | `*string`                                                | :heavy_minus_sign:                                       | The model that created this compaction.                  |