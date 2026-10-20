# MCPListTools

MCP list tools item: Result of discovering available tools from an MCP server.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ID`                                                       | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ServerLabel`                                              | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Tools`                                                    | [][components.MCPTool](../../models/components/mcptool.md) | :heavy_check_mark:                                         | N/A                                                        |
| `Error`                                                    | `*string`                                                  | :heavy_minus_sign:                                         | N/A                                                        |