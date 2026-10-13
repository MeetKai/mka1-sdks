# ReasoningWithID

Reasoning item: Model reasoning metadata, including summary text and optional detailed reasoning content.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *Literal["reasoning"]*                                     | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `summary`                                                  | List[[models.SummaryText](../models/summarytext.md)]       | :heavy_check_mark:                                         | N/A                                                        |
| `content`                                                  | List[[models.ReasoningText](../models/reasoningtext.md)]   | :heavy_minus_sign:                                         | N/A                                                        |
| `encrypted_content`                                        | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | N/A                                                        |
| `status`                                                   | [OptionalNullable[models.Status]](../models/status.md)     | :heavy_minus_sign:                                         | N/A                                                        |
| `response_id`                                              | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Dict[str, *str*]                                           | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |