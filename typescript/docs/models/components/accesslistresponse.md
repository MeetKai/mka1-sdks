# AccessListResponse

## Example Usage

```typescript
import { AccessListResponse } from "@meetkai/mka1/models/components";

let value: AccessListResponse = {
  object: "list",
  data: [
    {
      orgId: "<id>",
      modelId: "<id>",
      grantedBy: "<value>",
      grantedAt: new Date("2024-01-20T15:25:24.930Z"),
      activationState: "active",
      blockerSource: "serving",
      activatedBy: "<value>",
      activatedAt: new Date("2026-02-19T00:15:47.870Z"),
    },
  ],
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `object`                                                           | *"list"*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `data`                                                             | [components.AccessEntry](../../models/components/accessentry.md)[] | :heavy_check_mark:                                                 | N/A                                                                |