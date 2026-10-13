# FeatureFlagOverride

## Example Usage

```typescript
import { FeatureFlagOverride } from "@meetkai/mka1/models/components";

let value: FeatureFlagOverride = {
  enabled: false,
  identity: "<value>",
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `enabled`                                                          | *boolean*                                                          | :heavy_check_mark:                                                 | N/A                                                                |
| `identity`                                                         | *string*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `value`                                                            | *any*                                                              | :heavy_minus_sign:                                                 | Any JSON value; its shape is constrained by the flag's value_type. |