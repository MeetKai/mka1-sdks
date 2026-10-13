# ResponseCompactionItem

Compaction item: A condensed summary of prior conversation history to reduce context size.


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `type`                                                   | *Literal["compaction"]*                                  | :heavy_check_mark:                                       | N/A                                                      |
| `id`                                                     | *str*                                                    | :heavy_check_mark:                                       | N/A                                                      |
| `content`                                                | *str*                                                    | :heavy_check_mark:                                       | The compacted/summarized conversation content.           |
| `encrypted_content`                                      | *Optional[str]*                                          | :heavy_minus_sign:                                       | Optional encrypted content for OpenAI API compatibility. |
| `created_by`                                             | *Optional[str]*                                          | :heavy_minus_sign:                                       | The model that created this compaction.                  |