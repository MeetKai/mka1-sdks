# ManagedServiceRecord

## Example Usage

```typescript
import { ManagedServiceRecord } from "@meetkai/mka1/models/components";

let value: ManagedServiceRecord = {
  name: "coding_harness",
  containerPort: 297053,
  assignmentGeneration: 893470,
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `name`                                                                             | [components.ManagedServiceName](../../models/components/managedservicename.md)     | :heavy_check_mark:                                                                 | N/A                                                                                |
| `containerPort`                                                                    | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `assignmentGeneration`                                                             | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `status`                                                                           | [components.ManagedServiceStatus](../../models/components/managedservicestatus.md) | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `failureReason`                                                                    | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |