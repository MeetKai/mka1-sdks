# ConversationsItemsListResponse

OK


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `object`                                                                           | *Optional[Literal["list"]]*                                                        | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `data`                                                                             | List[[models.ConversationsItemsListData](../models/conversationsitemslistdata.md)] | :heavy_check_mark:                                                                 | A list of conversation items.                                                      |
| `has_more`                                                                         | *bool*                                                                             | :heavy_check_mark:                                                                 | Whether there are more items                                                       |
| `last_id`                                                                          | *str*                                                                              | :heavy_check_mark:                                                                 | ID of the last item in the current page                                            |