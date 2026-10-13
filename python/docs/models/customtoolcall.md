# CustomToolCall

Custom tool call item: A call record for a custom tool with input payload and tool name.


## Fields

| Field                         | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `type`                        | *Literal["custom_tool_call"]* | :heavy_check_mark:            | N/A                           |
| `call_id`                     | *str*                         | :heavy_check_mark:            | N/A                           |
| `input`                       | *str*                         | :heavy_check_mark:            | N/A                           |
| `name`                        | *str*                         | :heavy_check_mark:            | N/A                           |
| `id`                          | *Optional[str]*               | :heavy_minus_sign:            | N/A                           |