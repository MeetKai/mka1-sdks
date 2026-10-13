# ComputeStandaloneVolumeAttachmentList

## Example Usage

```typescript
import { ComputeStandaloneVolumeAttachmentList } from "@meetkai/mka1/models/components";

let value: ComputeStandaloneVolumeAttachmentList = {
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

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `nextCursor`                                                                                                   | *string*                                                                                                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            |
| `total`                                                                                                        | *number*                                                                                                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            |
| `data`                                                                                                         | [components.ComputeStandaloneVolumeAttachment](../../models/components/computestandalonevolumeattachment.md)[] | :heavy_check_mark:                                                                                             | N/A                                                                                                            |