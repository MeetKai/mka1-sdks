# RunInfo


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `run_id`                                                     | *str*                                                        | :heavy_check_mark:                                           | N/A                                                          |
| `run_uuid`                                                   | *Optional[str]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `run_name`                                                   | *Optional[str]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `experiment_id`                                              | *str*                                                        | :heavy_check_mark:                                           | N/A                                                          |
| `user_id`                                                    | *Optional[str]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `status`                                                     | [Optional[models.RunInfoStatus]](../models/runinfostatus.md) | :heavy_minus_sign:                                           | N/A                                                          |
| `start_time`                                                 | *Optional[int]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `end_time`                                                   | *Optional[int]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `artifact_uri`                                               | *Optional[str]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `lifecycle_stage`                                            | *Optional[str]*                                              | :heavy_minus_sign:                                           | N/A                                                          |