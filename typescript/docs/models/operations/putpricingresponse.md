# PutPricingResponse

## Example Usage

```typescript
import { PutPricingResponse } from "@meetkai/mka1/models/operations";

let value: PutPricingResponse = {
  headers: {
    "key": [
      "<value 1>",
    ],
    "key1": [],
  },
  result: {
    effectiveAt: new Date("2025-08-25T01:03:40.867Z"),
    version: 455484,
    volumeStorageUsdPerGibHour: 7983.91,
  },
};
```

## Fields

| Field                                 | Type                                  | Required                              | Description                           |
| ------------------------------------- | ------------------------------------- | ------------------------------------- | ------------------------------------- |
| `headers`                             | Record<string, *string*[]>            | :heavy_check_mark:                    | N/A                                   |
| `result`                              | *operations.PutPricingResponseResult* | :heavy_check_mark:                    | N/A                                   |