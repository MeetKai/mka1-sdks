# BatchObject

## Example Usage

```typescript
import { BatchObject } from "@meetkai/mka1/models/components";

let value: BatchObject = {
  id: "<id>",
  object: "batch",
  endpoint: "<value>",
  inputFileId: "<id>",
  completionWindow: "<value>",
  status: "cancelled",
  createdAt: 269309,
  requestCounts: {
    total: 284038,
    completed: 113361,
    failed: 969277,
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `object`                                                                     | *"batch"*                                                                    | :heavy_check_mark:                                                           | N/A                                                                          |
| `endpoint`                                                                   | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `errors`                                                                     | [components.BatchErrors](../../models/components/batcherrors.md)             | :heavy_minus_sign:                                                           | N/A                                                                          |
| `inputFileId`                                                                | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `completionWindow`                                                           | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `status`                                                                     | [components.BatchObjectStatus](../../models/components/batchobjectstatus.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `outputFileId`                                                               | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `errorFileId`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `createdAt`                                                                  | *number*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `inProgressAt`                                                               | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `expiresAt`                                                                  | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `finalizingAt`                                                               | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `completedAt`                                                                | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `failedAt`                                                                   | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `expiredAt`                                                                  | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `cancellingAt`                                                               | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `cancelledAt`                                                                | *number*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |
| `requestCounts`                                                              | [components.RequestCounts](../../models/components/requestcounts.md)         | :heavy_check_mark:                                                           | N/A                                                                          |
| `metadata`                                                                   | Record<string, *string*>                                                     | :heavy_minus_sign:                                                           | N/A                                                                          |