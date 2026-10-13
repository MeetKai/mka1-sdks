# RerouteRules

## Example Usage

```typescript
import { RerouteRules } from "@meetkai/mka1/models/components";

let value: RerouteRules = {
  trigger: {
    type: "error-fallback",
  },
  targetModelId: "<id>",
};
```

## Fields

| Field                | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `trigger`            | *components.Trigger* | :heavy_check_mark:   | N/A                  |
| `targetModelId`      | *string*             | :heavy_check_mark:   | N/A                  |
| `preserveParams`     | *boolean*            | :heavy_minus_sign:   | N/A                  |
| `log`                | *boolean*            | :heavy_minus_sign:   | N/A                  |