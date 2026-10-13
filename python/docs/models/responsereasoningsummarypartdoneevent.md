# ResponseReasoningSummaryPartDoneEvent


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `type`                                            | *Literal["response.reasoning_summary_part.done"]* | :heavy_check_mark:                                | N/A                                               |
| `sequence_number`                                 | *int*                                             | :heavy_check_mark:                                | N/A                                               |
| `item_id`                                         | *str*                                             | :heavy_check_mark:                                | N/A                                               |
| `output_index`                                    | *int*                                             | :heavy_check_mark:                                | N/A                                               |
| `summary_index`                                   | *int*                                             | :heavy_check_mark:                                | N/A                                               |
| `part`                                            | [models.SummaryText](../models/summarytext.md)    | :heavy_check_mark:                                | N/A                                               |