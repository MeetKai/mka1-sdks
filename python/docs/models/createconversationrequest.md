# CreateConversationRequest


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `items`                                                                       | List[[models.Item](../models/item.md)]                                        | :heavy_minus_sign:                                                            | Initial items to include in the conversation context. Max 20 items at a time. |
| `metadata`                                                                    | Dict[str, *str*]                                                              | :heavy_minus_sign:                                                            | Set of 16 key-value pairs for storing additional information.                 |