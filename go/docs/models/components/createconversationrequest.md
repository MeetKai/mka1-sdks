# CreateConversationRequest


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Items`                                                                       | [][components.Item](../../models/components/item.md)                          | :heavy_minus_sign:                                                            | Initial items to include in the conversation context. Max 20 items at a time. |
| `Metadata`                                                                    | map[string]`string`                                                           | :heavy_minus_sign:                                                            | Set of 16 key-value pairs for storing additional information.                 |