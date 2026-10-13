# ConversationListObject


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Object`                                                                 | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Data`                                                                   | List<[ConversationObject](../../Types/Components/ConversationObject.md)> | :heavy_check_mark:                                                       | Array of conversations                                                   |
| `HasMore`                                                                | *bool*                                                                   | :heavy_check_mark:                                                       | Whether there are more conversations                                     |
| `LastId`                                                                 | *string*                                                                 | :heavy_minus_sign:                                                       | ID of the last conversation in the current page                          |