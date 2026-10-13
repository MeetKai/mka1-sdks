# ListCheckpointsResponse


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `object`                                                               | *Literal["list"]*                                                      | :heavy_check_mark:                                                     | N/A                                                                    |
| `data`                                                                 | List[[models.FineTuningCheckpoint](../models/finetuningcheckpoint.md)] | :heavy_check_mark:                                                     | N/A                                                                    |
| `has_more`                                                             | *bool*                                                                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `first_id`                                                             | *OptionalNullable[str]*                                                | :heavy_minus_sign:                                                     | N/A                                                                    |
| `last_id`                                                              | *OptionalNullable[str]*                                                | :heavy_minus_sign:                                                     | N/A                                                                    |