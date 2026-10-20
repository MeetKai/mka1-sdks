# WebSearchToolCallWithID

Web search call item: A web-search tool-call record containing the executed action and status.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Type`                                                                   | `string`                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `ID`                                                                     | `string`                                                                 | :heavy_check_mark:                                                       | The unique ID of the message.                                            |
| `Action`                                                                 | [components.WebSearchAction](../../models/components/websearchaction.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `Status`                                                                 | `string`                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `ResponseID`                                                             | optionalnullable.OptionalNullable[`string`]                              | :heavy_minus_sign:                                                       | The ID of the response that created this item, if any.                   |
| `Metadata`                                                               | optionalnullable.OptionalNullable[map[string]`string`]                   | :heavy_minus_sign:                                                       | Metadata from the response that created this item, if any.               |