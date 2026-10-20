# GetExportStatusResponseResult

Export result (only present when status is COMPLETED)


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `OutputPath`                                                          | `string`                                                              | :heavy_check_mark:                                                    | Directory containing exported parquet files (S3 prefix or local path) |
| `CompletionsFile`                                                     | `string`                                                              | :heavy_check_mark:                                                    | Path to completions parquet file                                      |
| `ResponsesFile`                                                       | `string`                                                              | :heavy_check_mark:                                                    | Path to responses parquet file                                        |
| `RecordCount`                                                         | `int64`                                                               | :heavy_check_mark:                                                    | Total number of feedback records exported                             |
| `CompletionFeedbackCount`                                             | `int64`                                                               | :heavy_check_mark:                                                    | Number of chat completion feedback records exported                   |
| `ResponseFeedbackCount`                                               | `int64`                                                               | :heavy_check_mark:                                                    | Number of response feedback records exported                          |
| `ExportedAt`                                                          | [time.Time](https://pkg.go.dev/time#Time)                             | :heavy_check_mark:                                                    | ISO 8601 timestamp when the export was created                        |
| `DurationMs`                                                          | `int64`                                                               | :heavy_check_mark:                                                    | Duration of the export in milliseconds                                |