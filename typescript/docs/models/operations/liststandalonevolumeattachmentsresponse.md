# ListStandaloneVolumeAttachmentsResponse


## Supported Types

### `components.ComputeStandaloneVolumeAttachmentList`

```typescript
const value: components.ComputeStandaloneVolumeAttachmentList = {
  nextCursor: "<value>",
  total: 692462,
  data: [
    {
      cleanupFailure: {
        code: "<value>",
        message: "<value>",
      },
      createdAt: new Date("2024-10-09T17:24:56.961Z"),
      id: "<id>",
      mountPath: "<value>",
      releasedAt: new Date("2026-12-08T19:07:10.161Z"),
      resourceId: "<id>",
      resourceType: "job",
      status: "attached",
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

