# CatalogEntry

## Example Usage

```typescript
import { CatalogEntry } from "@meetkai/mka1/models/components";

let value: CatalogEntry = {
  modelId: "<id>",
  source: "byo",
  origin: "yaml",
  activationState: "available_name_blocked",
  blockerSource: "cluster",
  activatedBy: "<value>",
  activatedAt: new Date("2024-11-22T21:34:08.472Z"),
  provider: "<value>",
  providerModelId: "<id>",
  definition: {
    "key": "<value>",
    "key1": "<value>",
  },
  health: {
    isAvailable: false,
    lastHealthCheck: 2087.09,
    error: "<value>",
  },
  createdAt: 5732.9,
  updatedAt: 5333.46,
  effectivePrice: {
    rates: {},
    source: "cluster_default",
  },
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `modelId`                                                                                     | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `source`                                                                                      | [components.RegistrySource](../../models/components/registrysource.md)                        | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `origin`                                                                                      | [components.RegistryModelOrigin](../../models/components/registrymodelorigin.md)              | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activationState`                                                                             | [components.CatalogActivationState](../../models/components/catalogactivationstate.md)        | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `blockerSource`                                                                               | [components.RegistrySource](../../models/components/registrysource.md)                        | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activatedBy`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activatedAt`                                                                                 | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `provider`                                                                                    | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `providerModelId`                                                                             | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `definition`                                                                                  | Record<string, *any*>                                                                         | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `health`                                                                                      | [components.CatalogHealth](../../models/components/cataloghealth.md)                          | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `createdAt`                                                                                   | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `updatedAt`                                                                                   | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `effectivePrice`                                                                              | [components.CatalogPricePreview](../../models/components/catalogpricepreview.md)              | :heavy_check_mark:                                                                            | N/A                                                                                           |