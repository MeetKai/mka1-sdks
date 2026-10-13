# ListComputeTenantsResponse


## Supported Types

### `components.ComputeTenantList`

```typescript
const value: components.ComputeTenantList = {
  nextCursor: "<value>",
  total: 233955,
  data: [
    {
      createdAt: new Date("2024-07-14T21:19:06.231Z"),
      enabled: true,
      maxLiveJobs: 44980,
      maxLiveServiceReplicas: 13421,
      maxLiveServices: null,
      maxLiveVolumes: 459254,
      orgId: "<id>",
      updatedAt: new Date("2024-05-07T09:00:57.533Z"),
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

