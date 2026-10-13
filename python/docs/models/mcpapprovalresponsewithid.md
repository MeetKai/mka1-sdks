# MCPApprovalResponseWithID

MCP approval response item: The decision payload for a prior MCP approval request.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *Literal["mcp_approval_response"]*                         | :heavy_check_mark:                                         | N/A                                                        |
| `approval_request_id`                                      | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `approve`                                                  | *bool*                                                     | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `reason`                                                   | *Optional[str]*                                            | :heavy_minus_sign:                                         | N/A                                                        |
| `response_id`                                              | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Dict[str, *str*]                                           | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |