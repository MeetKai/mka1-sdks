# ListJobsResponse


## Supported Types

### `components.ComputeJobList`

```typescript
const value: components.ComputeJobList = {
  nextCursor: null,
  total: 786157,
  data: [
    {
      accruedUsd: 7949.01,
      compute: {
        accelerator: "<value>",
        ephemeralDiskGb: 133945,
        gpuCount: 438176,
      },
      createdAt: new Date("2024-09-03T06:53:08.892Z"),
      endpoints: [],
      id: "<id>",
      limits: {},
      reason: {
        code: "<value>",
        message: "<value>",
      },
      startedAt: null,
      state: "failed",
      terminalAt: new Date("2025-04-26T06:24:30.909Z"),
    },
  ],
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

