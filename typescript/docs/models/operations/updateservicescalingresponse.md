# UpdateServiceScalingResponse

## Example Usage

```typescript
import { UpdateServiceScalingResponse } from "@meetkai/mka1/models/operations";

let value: UpdateServiceScalingResponse = {
  headers: {},
  result: {
    accruedUsd: 3535.92,
    compute: {
      accelerator: "<value>",
      ephemeralDiskGb: 133945,
      gpuCount: 438176,
    },
    createdAt: new Date("2026-05-07T10:50:47.023Z"),
    endpoints: [],
    id: "<id>",
    limits: {},
    reason: {
      code: "<value>",
      message: "<value>",
    },
    startedAt: new Date("2026-05-04T14:41:47.310Z"),
    state: "ready",
    terminalAt: new Date("2025-01-13T20:06:13.945Z"),
    ready: true,
  },
};
```

## Fields

| Field                                           | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `headers`                                       | Record<string, *string*[]>                      | :heavy_check_mark:                              | N/A                                             |
| `result`                                        | *operations.UpdateServiceScalingResponseResult* | :heavy_check_mark:                              | N/A                                             |