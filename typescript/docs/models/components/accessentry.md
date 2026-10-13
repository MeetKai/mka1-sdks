# AccessEntry

## Example Usage

```typescript
import { AccessEntry } from "@meetkai/mka1/models/components";

let value: AccessEntry = {
  orgId: "<id>",
  modelId: "<id>",
  grantedBy: "<value>",
  grantedAt: new Date("2026-04-21T01:38:51.100Z"),
  activationState: "available",
  blockerSource: "serving",
  activatedBy: "<value>",
  activatedAt: null,
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `orgId`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `modelId`                                                                                     | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `grantedBy`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `grantedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activationState`                                                                             | [components.CatalogActivationState](../../models/components/catalogactivationstate.md)        | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `blockerSource`                                                                               | [components.RegistrySource](../../models/components/registrysource.md)                        | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activatedBy`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activatedAt`                                                                                 | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |