# RegistryEntryResponse

## Example Usage

```typescript
import { RegistryEntryResponse } from "@meetkai/mka1/models/components";

let value: RegistryEntryResponse = {
  modelId: "<id>",
  source: "cluster",
  activatedBy: "<value>",
  activatedAt: new Date("2026-08-01T09:16:50.730Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `modelId`                                                                                     | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `source`                                                                                      | [components.RegistrySource](../../models/components/registrysource.md)                        | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activatedBy`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `activatedAt`                                                                                 | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |