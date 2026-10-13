# WebSearchToolCallWithID

Web search call item: A web-search tool-call record containing the executed action and status.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *Literal["web_search_call"]*                               | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `action`                                                   | [models.WebSearchAction](../models/websearchaction.md)     | :heavy_check_mark:                                         | N/A                                                        |
| `status`                                                   | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `response_id`                                              | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Dict[str, *str*]                                           | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |