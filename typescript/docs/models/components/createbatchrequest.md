# CreateBatchRequest

## Example Usage

```typescript
import { CreateBatchRequest } from "@meetkai/mka1/models/components";

let value: CreateBatchRequest = {
  inputFileId: "<id>",
  endpoint: "/v1/images/generations",
  completionWindow: "24h",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `inputFileId`                                                        | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `endpoint`                                                           | [components.BatchEndpoint](../../models/components/batchendpoint.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `completionWindow`                                                   | *"24h"*                                                              | :heavy_check_mark:                                                   | N/A                                                                  |
| `metadata`                                                           | Record<string, *string*>                                             | :heavy_minus_sign:                                                   | N/A                                                                  |