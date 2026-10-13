# CustomToolCallWithId

Custom tool call item: A call record for a custom tool with input payload and tool name.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `CallId`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Input`                                                    | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Name`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `ResponseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | Dictionary<String, *string*>                               | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |