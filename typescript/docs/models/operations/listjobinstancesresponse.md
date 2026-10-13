# ListJobInstancesResponse


## Supported Types

### `components.ComputeInstanceList`

```typescript
const value: components.ComputeInstanceList = {
  nextCursor: "<value>",
  total: 790212,
  data: [
    {
      endpoints: [],
      hardware: {
        accelerator: "<value>",
        gpuCount: 664993,
        gpuMemoryGb: 985896,
      },
      id: "<id>",
      providerId: "<id>",
      providerResourceType: "<value>",
      state: "starting",
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

