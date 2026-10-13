# Result

Export result (only present when status is COMPLETED)

## Example Usage

```typescript
import { Result } from "@meetkai/mka1/models/components";

let value: Result = {
  outputPath: "<value>",
  completionsFile: "<value>",
  responsesFile: "<value>",
  recordCount: 897285,
  completionFeedbackCount: 526220,
  responseFeedbackCount: 790673,
  exportedAt: new Date("2026-10-22T07:38:11.933Z"),
  durationMs: 170920,
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `outputPath`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | Directory containing exported parquet files (S3 prefix or local path)                         |
| `completionsFile`                                                                             | *string*                                                                                      | :heavy_check_mark:                                                                            | Path to completions parquet file                                                              |
| `responsesFile`                                                                               | *string*                                                                                      | :heavy_check_mark:                                                                            | Path to responses parquet file                                                                |
| `recordCount`                                                                                 | *number*                                                                                      | :heavy_check_mark:                                                                            | Total number of feedback records exported                                                     |
| `completionFeedbackCount`                                                                     | *number*                                                                                      | :heavy_check_mark:                                                                            | Number of chat completion feedback records exported                                           |
| `responseFeedbackCount`                                                                       | *number*                                                                                      | :heavy_check_mark:                                                                            | Number of response feedback records exported                                                  |
| `exportedAt`                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | ISO 8601 timestamp when the export was created                                                |
| `durationMs`                                                                                  | *number*                                                                                      | :heavy_check_mark:                                                                            | Duration of the export in milliseconds                                                        |