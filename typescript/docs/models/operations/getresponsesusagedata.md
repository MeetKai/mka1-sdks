# GetResponsesUsageData

## Example Usage

```typescript
import { GetResponsesUsageData } from "@meetkai/mka1/models/operations";

let value: GetResponsesUsageData = {
  object: "bucket",
  startTime: 152698,
  endTime: 314333,
  results: [
    "<value 1>",
    "<value 2>",
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