# MCPApprovalResponse

MCP approval response item: The decision payload for a prior MCP approval request.


## Fields

| Field                              | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `type`                             | *Literal["mcp_approval_response"]* | :heavy_check_mark:                 | N/A                                |
| `approval_request_id`              | *str*                              | :heavy_check_mark:                 | N/A                                |
| `approve`                          | *bool*                             | :heavy_check_mark:                 | N/A                                |
| `id`                               | *Optional[str]*                    | :heavy_minus_sign:                 | N/A                                |
| `reason`                           | *Optional[str]*                    | :heavy_minus_sign:                 | N/A                                |