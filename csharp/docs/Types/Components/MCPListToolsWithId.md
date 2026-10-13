# MCPListToolsWithId

MCP list tools item: Result of discovering available tools from an MCP server.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `ServerLabel`                                              | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Tools`                                                    | List<[MCPTool](../../Types/Components/MCPTool.md)>         | :heavy_check_mark:                                         | N/A                                                        |
| `Error`                                                    | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `ResponseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | Dictionary<String, *string*>                               | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |