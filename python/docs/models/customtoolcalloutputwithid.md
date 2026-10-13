# CustomToolCallOutputWithID

Custom tool call output item: The output payload returned by a custom tool call.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *Literal["custom_tool_call_output"]*                       | :heavy_check_mark:                                         | N/A                                                        |
| `call_id`                                                  | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `output`                                                   | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `response_id`                                              | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Dict[str, *str*]                                           | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |