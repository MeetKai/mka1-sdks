# GetExportStatusResponseProgress

Progress information (available when running)


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `stage`                                                                          | [models.GetExportStatusResponseStage](../models/getexportstatusresponsestage.md) | :heavy_check_mark:                                                               | Current stage of the export process                                              |
| `record_count`                                                                   | *Optional[int]*                                                                  | :heavy_minus_sign:                                                               | Number of records fetched (available after fetching stage)                       |
| `completion_count`                                                               | *Optional[int]*                                                                  | :heavy_minus_sign:                                                               | Number of completion feedback records                                            |
| `response_count`                                                                 | *Optional[int]*                                                                  | :heavy_minus_sign:                                                               | Number of response feedback records                                              |
| `parquet_bytes`                                                                  | *Optional[int]*                                                                  | :heavy_minus_sign:                                                               | Size of parquet file in bytes (available after converting stage)                 |
| `message`                                                                        | *str*                                                                            | :heavy_check_mark:                                                               | Human-readable progress message                                                  |