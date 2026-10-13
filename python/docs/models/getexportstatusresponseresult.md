# GetExportStatusResponseResult

Export result (only present when status is COMPLETED)


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `output_path`                                                         | *str*                                                                 | :heavy_check_mark:                                                    | Directory containing exported parquet files (S3 prefix or local path) |
| `completions_file`                                                    | *str*                                                                 | :heavy_check_mark:                                                    | Path to completions parquet file                                      |
| `responses_file`                                                      | *str*                                                                 | :heavy_check_mark:                                                    | Path to responses parquet file                                        |
| `record_count`                                                        | *int*                                                                 | :heavy_check_mark:                                                    | Total number of feedback records exported                             |
| `completion_feedback_count`                                           | *int*                                                                 | :heavy_check_mark:                                                    | Number of chat completion feedback records exported                   |
| `response_feedback_count`                                             | *int*                                                                 | :heavy_check_mark:                                                    | Number of response feedback records exported                          |
| `exported_at`                                                         | [date](https://docs.python.org/3/library/datetime.html#date-objects)  | :heavy_check_mark:                                                    | ISO 8601 timestamp when the export was created                        |
| `duration_ms`                                                         | *int*                                                                 | :heavy_check_mark:                                                    | Duration of the export in milliseconds                                |