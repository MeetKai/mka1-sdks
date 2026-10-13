# ListBatchesResponse

## Example Usage

```typescript
import { ListBatchesResponse } from "@meetkai/mka1/models/components";

let value: ListBatchesResponse = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "batch",
      endpoint: "<value>",
      inputFileId: "<id>",
      completionWindow: "<value>",
      status: "completed",
      createdAt: 908265,
      requestCounts: {
        total: 284038,
        completed: 113361,
        failed: 969277,
      },
    },
  ],
  hasMore: false,
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `object`                                                           | *"list"*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `data`                                                             | [components.BatchObject](../../models/components/batchobject.md)[] | :heavy_check_mark:                                                 | N/A                                                                |
| `firstId`                                                          | *string*                                                           | :heavy_minus_sign:                                                 | N/A                                                                |
| `lastId`                                                           | *string*                                                           | :heavy_minus_sign:                                                 | N/A                                                                |
| `hasMore`                                                          | *boolean*                                                          | :heavy_check_mark:                                                 | N/A                                                                |