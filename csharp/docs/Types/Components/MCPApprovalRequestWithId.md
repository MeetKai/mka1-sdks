# MCPApprovalRequestWithId

MCP approval request item: A request to approve or deny execution of an MCP tool call.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `Arguments`                                                | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Name`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ServerLabel`                                              | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ResponseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | Dictionary<String, *string*>                               | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |