# GetVectorStoresUsageData

## Example Usage

```typescript
import { GetVectorStoresUsageData } from "@meetkai/mka1/models/operations";

let value: GetVectorStoresUsageData = {
  object: "bucket",
  startTime: 856632,
  endTime: 509134,
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