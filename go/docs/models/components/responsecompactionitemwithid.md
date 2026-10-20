# ResponseCompactionItemWithID

Compaction item: A condensed summary of prior conversation history to reduce context size.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ID`                                                       | `string`                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `Content`                                                  | `string`                                                   | :heavy_check_mark:                                         | The compacted/summarized conversation content.             |
| `EncryptedContent`                                         | `*string`                                                  | :heavy_minus_sign:                                         | Optional encrypted content for OpenAI API compatibility.   |
| `CreatedBy`                                                | `*string`                                                  | :heavy_minus_sign:                                         | The model that created this compaction.                    |
| `ResponseID`                                               | optionalnullable.OptionalNullable[`string`]                | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | optionalnullable.OptionalNullable[map[string]`string`]     | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |