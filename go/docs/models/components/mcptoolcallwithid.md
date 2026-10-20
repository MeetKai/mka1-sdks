# MCPToolCallWithID

MCP call item: A direct call record for an MCP tool, including request arguments and optional output/error.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `Type`                                                     | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ID`                                                       | `string`                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `ApprovalRequestID`                                        | optionalnullable.OptionalNullable[`string`]                | :heavy_minus_sign:                                         | N/A                                                        |
| `Arguments`                                                | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Name`                                                     | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `ServerLabel`                                              | `string`                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Error`                                                    | `*string`                                                  | :heavy_minus_sign:                                         | N/A                                                        |
| `Output`                                                   | `*string`                                                  | :heavy_minus_sign:                                         | N/A                                                        |
| `ResponseID`                                               | optionalnullable.OptionalNullable[`string`]                | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `Metadata`                                                 | optionalnullable.OptionalNullable[map[string]`string`]     | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |