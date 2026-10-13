# TerminateJobResponse


## Supported Types

### `components.ComputeJob`

```typescript
const value: components.ComputeJob = {
  accruedUsd: 6477.52,
  compute: {
    accelerator: "<value>",
    ephemeralDiskGb: 133945,
    gpuCount: 438176,
  },
  createdAt: new Date("2025-06-03T16:36:10.819Z"),
  endpoints: [
    {
      host: "elliptical-humor.biz",
      name: "<value>",
      port: 792702,
      protocol: "<value>",
    },
  ],
  id: "<id>",
  limits: {},
  reason: null,
  startedAt: null,
  state: "succeeded",
  terminalAt: new Date("2025-12-30T07:00:54.473Z"),
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

