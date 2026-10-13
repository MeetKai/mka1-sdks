# UpdateCatalogModelRequestRerouteRules

## Example Usage

```typescript
import { UpdateCatalogModelRequestRerouteRules } from "@meetkai/mka1/models/components";

let value: UpdateCatalogModelRequestRerouteRules = {
  trigger: {
    type: "input-modality",
    modality: "video",
  },
  targetModelId: "<id>",
};
```

## Fields

| Field                            | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `trigger`                        | *components.RerouteRulesTrigger* | :heavy_check_mark:               | N/A                              |
| `targetModelId`                  | *string*                         | :heavy_check_mark:               | N/A                              |
| `preserveParams`                 | *boolean*                        | :heavy_minus_sign:               | N/A                              |
| `log`                            | *boolean*                        | :heavy_minus_sign:               | N/A                              |