# GetClassifyUsageData

## Example Usage

```typescript
import { GetClassifyUsageData } from "@meetkai/mka1/models/operations";

let value: GetClassifyUsageData = {
  object: "bucket",
  startTime: 993355,
  endTime: 721381,
  results: [],
};
```

## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `object`                                    | *"bucket"*                                  | :heavy_check_mark:                          | N/A                                         |
| `startTime`                                 | *number*                                    | :heavy_check_mark:                          | Unix timestamp of bucket start (inclusive)  |
| `endTime`                                   | *number*                                    | :heavy_check_mark:                          | Unix timestamp of bucket end (exclusive)    |
| `results`                                   | *any*[]                                     | :heavy_check_mark:                          | Array of usage results for this time bucket |