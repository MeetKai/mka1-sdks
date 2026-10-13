# ListStandaloneVolumeAttachmentsRequest

## Example Usage

```typescript
import { ListStandaloneVolumeAttachmentsRequest } from "@meetkai/mka1/models/operations";

let value: ListStandaloneVolumeAttachmentsRequest = {
  id: "<id>",
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                   | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `status`                                                                                                               | [components.ComputeStandaloneVolumeAttachmentState](../../models/components/computestandalonevolumeattachmentstate.md) | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `cursor`                                                                                                               | *string*                                                                                                               | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `limit`                                                                                                                | *number*                                                                                                               | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `xOnBehalfOf`                                                                                                          | *string*                                                                                                               | :heavy_minus_sign:                                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                                    |