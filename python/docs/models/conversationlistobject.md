# ConversationListObject


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `object`                                                           | *Literal["list"]*                                                  | :heavy_check_mark:                                                 | N/A                                                                |
| `data`                                                             | List[[models.ConversationObject](../models/conversationobject.md)] | :heavy_check_mark:                                                 | Array of conversations                                             |
| `has_more`                                                         | *bool*                                                             | :heavy_check_mark:                                                 | Whether there are more conversations                               |
| `last_id`                                                          | *Optional[str]*                                                    | :heavy_minus_sign:                                                 | ID of the last conversation in the current page                    |