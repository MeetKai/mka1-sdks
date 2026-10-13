# GetComputeUsageResponse


## Supported Types

### `components.ComputeUsage`

```typescript
const value: components.ComputeUsage = {
  data: [],
  granularity: "minute",
  nextCursor: "<value>",
  summary: {
    jobUsd: 4775.35,
    serviceUsd: 6524.37,
    totalUsd: 8878.62,
    volumeUsd: 4404.2,
  },
  total: 155527,
  volumeAllocation: "uniform_proration",
  volumeLedgerGranularity: "hour",
  volumeUsageComplete: true,
  volumeUsageCompleteThrough: new Date("2025-06-09T15:38:45.336Z"),
  window: {
    from: new Date("2024-01-13T06:25:33.267Z"),
    to: new Date("2025-10-05T08:43:59.509Z"),
  },
};
```

### `components.ComputeErrorEnvelope`

```typescript
const value: components.ComputeErrorEnvelope = {
  error: {
    code: "<value>",
    message: "<value>",
    requestId: "<id>",
  },
};
```

