# ResponseShellCallCompletedEvent


## Fields

| Field                                      | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `type`                                     | *Literal["response.shell_call.completed"]* | :heavy_check_mark:                         | N/A                                        |
| `sequence_number`                          | *int*                                      | :heavy_check_mark:                         | N/A                                        |
| `item_id`                                  | *str*                                      | :heavy_check_mark:                         | N/A                                        |
| `output_index`                             | *int*                                      | :heavy_check_mark:                         | N/A                                        |
| `function_call_output`                     | *Optional[str]*                            | :heavy_minus_sign:                         | N/A                                        |