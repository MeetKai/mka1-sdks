# CreateServiceResponse


## Supported Types

### `components.ComputeService`

```typescript
const value: components.ComputeService = {
  accruedUsd: 1831.84,
  compute: {
    accelerator: "<value>",
    ephemeralDiskGb: 133945,
    gpuCount: 438176,
  },
  createdAt: new Date("2025-08-23T23:26:49.917Z"),
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
  reason: {
    code: "<value>",
    message: "<value>",
  },
  startedAt: new Date("2025-09-08T20:45:20.609Z"),
  state: "allocating",
  terminalAt: null,
  ready: false,
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

