# MCPApprovalRequestWithID

MCP approval request item: A request to approve or deny execution of an MCP tool call.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *Literal["mcp_approval_request"]*                          | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `arguments`                                                | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `name`                                                     | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `server_label`                                             | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `response_id`                                              | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Dict[str, *str*]                                           | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |