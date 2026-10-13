# ConversationsItemsCreateResponseBody

OK


## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `Object`                                                                                   | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `Data`                                                                                     | List<[ConversationsItemsCreateData](../../Types/Requests/ConversationsItemsCreateData.md)> | :heavy_check_mark:                                                                         | A list of conversation items.                                                              |
| `HasMore`                                                                                  | *bool*                                                                                     | :heavy_check_mark:                                                                         | Whether there are more items                                                               |
| `LastId`                                                                                   | *string*                                                                                   | :heavy_check_mark:                                                                         | ID of the last item in the current page                                                    |