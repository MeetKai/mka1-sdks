# FineTuningCheckpoint


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `object`                                                   | *Literal["fine_tuning.job.checkpoint"]*                    | :heavy_check_mark:                                         | N/A                                                        |
| `created_at`                                               | *int*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `fine_tuned_model_checkpoint`                              | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `fine_tuning_job_id`                                       | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `step_number`                                              | *int*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `metrics`                                                  | [models.CheckpointMetrics](../models/checkpointmetrics.md) | :heavy_check_mark:                                         | N/A                                                        |