# GetFilesUsageData

## Example Usage

```typescript
import { GetFilesUsageData } from "@meetkai/mka1/models/operations";

let value: GetFilesUsageData = {
  object: "bucket",
  startTime: 585936,
  endTime: 69048,
  results: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `object`                                    | *"bucket"*                                  | :heavy_check_mark:                          | N/A                                         |
| `startTime`                                 | *number*                                    | :heavy_check_mark:                          | Unix timestamp of bucket start (inclusive)  |
| `endTime`                                   | *number*                                    | :heavy_check_mark:                          | Unix timestamp of bucket end (exclusive)    |
| `results`                                   | *any*[]                                     | :heavy_check_mark:                          | Array of usage results for this time bucket |