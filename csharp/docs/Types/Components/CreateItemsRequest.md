# CreateItemsRequest


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `Items`                                                          | List<[Item](../../Types/Components/Item.md)>                     | :heavy_check_mark:                                               | Items to add to the conversation. Min 1, max 20 items at a time. |
| `Include`                                                        | List<*string*>                                                   | :heavy_minus_sign:                                               | Additional fields to include (TODO: not implemented yet)         |