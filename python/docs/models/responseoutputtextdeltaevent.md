# ResponseOutputTextDeltaEvent


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `type`                                                 | *Literal["response.output_text.delta"]*                | :heavy_check_mark:                                     | N/A                                                    |
| `sequence_number`                                      | *int*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `item_id`                                              | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `output_index`                                         | *int*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `content_index`                                        | *int*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `delta`                                                | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `logprobs`                                             | List[[models.LogProbToken](../models/logprobtoken.md)] | :heavy_minus_sign:                                     | N/A                                                    |