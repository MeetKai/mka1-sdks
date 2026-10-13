# ComputeStandaloneVolumeAttachment

## Example Usage

```typescript
import { ComputeStandaloneVolumeAttachment } from "@meetkai/mka1/models/components";

let value: ComputeStandaloneVolumeAttachment = {
  cleanupFailure: null,
  createdAt: new Date("2026-01-01T01:43:51.685Z"),
  id: "<id>",
  mountPath: "<value>",
  releasedAt: null,
  resourceId: "<id>",
  resourceType: "job",
  status: "reserved",
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `cleanupFailure`                                                                                                       | [components.ComputeReason](../../models/components/computereason.md)                                                   | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `createdAt`                                                                                                            | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)                          | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `id`                                                                                                                   | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `mountPath`                                                                                                            | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `releasedAt`                                                                                                           | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)                          | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `resourceId`                                                                                                           | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `resourceType`                                                                                                         | [components.ComputeResourceType](../../models/components/computeresourcetype.md)                                       | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `status`                                                                                                               | [components.ComputeStandaloneVolumeAttachmentState](../../models/components/computestandalonevolumeattachmentstate.md) | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |