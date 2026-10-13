# MCPListTools

MCP list tools item: Result of discovering available tools from an MCP server.


## Fields

| Field                                        | Type                                         | Required                                     | Description                                  |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| `type`                                       | *Literal["mcp_list_tools"]*                  | :heavy_check_mark:                           | N/A                                          |
| `id`                                         | *str*                                        | :heavy_check_mark:                           | N/A                                          |
| `server_label`                               | *str*                                        | :heavy_check_mark:                           | N/A                                          |
| `tools`                                      | List[[models.MCPTool](../models/mcptool.md)] | :heavy_check_mark:                           | N/A                                          |
| `error`                                      | *Optional[str]*                              | :heavy_minus_sign:                           | N/A                                          |