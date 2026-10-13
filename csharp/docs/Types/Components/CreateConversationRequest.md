# CreateConversationRequest


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Items`                                                                       | List<[Item](../../Types/Components/Item.md)>                                  | :heavy_minus_sign:                                                            | Initial items to include in the conversation context. Max 20 items at a time. |
| `Metadata`                                                                    | Dictionary<String, *string*>                                                  | :heavy_minus_sign:                                                            | Set of 16 key-value pairs for storing additional information.                 |