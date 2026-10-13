# CreateItemsRequest


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `items`                                                          | List[[models.Item](../models/item.md)]                           | :heavy_check_mark:                                               | Items to add to the conversation. Min 1, max 20 items at a time. |
| `include`                                                        | List[*str*]                                                      | :heavy_minus_sign:                                               | Additional fields to include (TODO: not implemented yet)         |