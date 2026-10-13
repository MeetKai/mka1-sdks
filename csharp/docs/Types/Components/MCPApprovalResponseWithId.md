# MCPApprovalResponseWithId

MCP approval response item: The decision payload for a prior MCP approval request.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ApprovalRequestId`                                        | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Approve`                                                  | *bool*                                                     | :heavy_check_mark:                                         | N/A                                                        |
| `Id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `Reason`                                                   | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `ResponseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | Dictionary<String, *string*>                               | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |