# MCPApprovalResponseWithID

MCP approval response item: The decision payload for a prior MCP approval request.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ApprovalRequestID`                                        | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Approve`                                                  | `bool`                                                     | :heavy_check_mark:                                         | N/A                                                        |
| `ID`                                                       | `string`                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `Reason`                                                   | `*string`                                                  | :heavy_minus_sign:                                         | N/A                                                        |
| `ResponseID`                                               | optionalnullable.OptionalNullable[`string`]                | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | optionalnullable.OptionalNullable[map[string]`string`]     | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |