# FeatureFlagEvaluation

## Example Usage

```typescript
import { FeatureFlagEvaluation } from "@meetkai/mka1/models/components";

let value: FeatureFlagEvaluation = {
  enabled: false,
  reason: "<value>",
  value: "<value>",
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `enabled`                                                          | *boolean*                                                          | :heavy_check_mark:                                                 | N/A                                                                |
| `reason`                                                           | *string*                                                           | :heavy_check_mark:                                                 | disabled, override, rule:<index>, rollout, or default              |
| `value`                                                            | *any*                                                              | :heavy_check_mark:                                                 | Any JSON value; its shape is constrained by the flag's value_type. |