# Progress

Progress information (available when running)

## Example Usage

```typescript
import { Progress } from "@meetkai/mka1/models/components";

let value: Progress = {
  stage: "uploading",
  message: "<value>",
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `stage`                                                          | [components.Stage](../../models/components/stage.md)             | :heavy_check_mark:                                               | Current stage of the export process                              |
| `recordCount`                                                    | *number*                                                         | :heavy_minus_sign:                                               | Number of records fetched (available after fetching stage)       |
| `completionCount`                                                | *number*                                                         | :heavy_minus_sign:                                               | Number of completion feedback records                            |
| `responseCount`                                                  | *number*                                                         | :heavy_minus_sign:                                               | Number of response feedback records                              |
| `parquetBytes`                                                   | *number*                                                         | :heavy_minus_sign:                                               | Size of parquet file in bytes (available after converting stage) |
| `message`                                                        | *string*                                                         | :heavy_check_mark:                                               | Human-readable progress message                                  |