# MCPToolCall

MCP call item: A direct call record for an MCP tool, including request arguments and optional output/error.


## Fields

| Field                   | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `type`                  | *Literal["mcp_call"]*   | :heavy_check_mark:      | N/A                     |
| `id`                    | *str*                   | :heavy_check_mark:      | N/A                     |
| `approval_request_id`   | *OptionalNullable[str]* | :heavy_minus_sign:      | N/A                     |
| `arguments`             | *str*                   | :heavy_check_mark:      | N/A                     |
| `name`                  | *str*                   | :heavy_check_mark:      | N/A                     |
| `server_label`          | *str*                   | :heavy_check_mark:      | N/A                     |
| `error`                 | *Optional[str]*         | :heavy_minus_sign:      | N/A                     |
| `output`                | *Optional[str]*         | :heavy_minus_sign:      | N/A                     |