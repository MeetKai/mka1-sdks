# FileCounts

File processing status counts.

## Example Usage

```typescript
import { FileCounts } from "@meetkai/mka1/models/components";

let value: FileCounts = {
  inProgress: 531702,
  completed: 842789,
  failed: 206428,
  cancelled: 668784,
  total: 640381,
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `inProgress`                                               | *number*                                                   | :heavy_check_mark:                                         | The number of files that are currently being processed.    |
| `completed`                                                | *number*                                                   | :heavy_check_mark:                                         | The number of files that have been successfully processed. |
| `failed`                                                   | *number*                                                   | :heavy_check_mark:                                         | The number of files that have failed to process.           |
| `cancelled`                                                | *number*                                                   | :heavy_check_mark:                                         | The number of files that were cancelled.                   |
| `total`                                                    | *number*                                                   | :heavy_check_mark:                                         | The total number of files.                                 |