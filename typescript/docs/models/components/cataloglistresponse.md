# CatalogListResponse

## Example Usage

```typescript
import { CatalogListResponse } from "@meetkai/mka1/models/components";

let value: CatalogListResponse = {
  object: "list",
  currency: "North Korean Won",
  data: [
    {
      modelId: "<id>",
      source: "cluster",
      origin: "yaml",
      activationState: "active",
      blockerSource: "cluster",
      activatedBy: "<value>",
      activatedAt: new Date("2025-07-01T18:44:58.023Z"),
      provider: "<value>",
      providerModelId: "<id>",
      definition: {},
      health: {
        isAvailable: false,
        lastHealthCheck: 2087.09,
        error: "<value>",
      },
      createdAt: 743.34,
      updatedAt: 4928.45,
      effectivePrice: {
        rates: {},
        source: "cluster_default",
      },
    },
  ],
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `object`                                                             | *"list"*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `currency`                                                           | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `data`                                                               | [components.CatalogEntry](../../models/components/catalogentry.md)[] | :heavy_check_mark:                                                   | N/A                                                                  |