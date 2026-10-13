# ListServicesResponse


## Supported Types

### `components.ComputeServiceList`

```typescript
const value: components.ComputeServiceList = {
  nextCursor: "<value>",
  total: 82181,
  data: [
    {
      accruedUsd: 5750.79,
      compute: {
        accelerator: "<value>",
        ephemeralDiskGb: 133945,
        gpuCount: 438176,
      },
      createdAt: new Date("2025-12-02T05:58:38.352Z"),
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
      startedAt: new Date("2026-10-16T10:43:28.676Z"),
      state: "terminated",
      terminalAt: new Date("2024-07-05T12:20:34.063Z"),
      ready: true,
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

