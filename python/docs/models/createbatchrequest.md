# CreateBatchRequest


## Fields

| Field                                              | Type                                               | Required                                           | Description                                        |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| `input_file_id`                                    | *str*                                              | :heavy_check_mark:                                 | N/A                                                |
| `endpoint`                                         | [models.BatchEndpoint](../models/batchendpoint.md) | :heavy_check_mark:                                 | N/A                                                |
| `completion_window`                                | *Literal["24h"]*                                   | :heavy_check_mark:                                 | N/A                                                |
| `metadata`                                         | Dict[str, *str*]                                   | :heavy_minus_sign:                                 | N/A                                                |