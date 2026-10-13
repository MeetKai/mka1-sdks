# FeatureFlagStateInput

## Example Usage

```typescript
import { FeatureFlagStateInput } from "@meetkai/mka1/models/components";

let value: FeatureFlagStateInput = {
  enabled: true,
  overrides: [],
  rolloutPercentage: 224433,
  rules: [
    {
      conditions: [],
      enabled: true,
    },
  ],
  value: "<value>",
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `enabled`                                                                          | *boolean*                                                                          | :heavy_check_mark:                                                                 | N/A                                                                                |
| `overrides`                                                                        | [components.FeatureFlagOverride](../../models/components/featureflagoverride.md)[] | :heavy_check_mark:                                                                 | N/A                                                                                |
| `rolloutPercentage`                                                                | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `rules`                                                                            | [components.FeatureFlagRule](../../models/components/featureflagrule.md)[]         | :heavy_check_mark:                                                                 | N/A                                                                                |
| `value`                                                                            | *any*                                                                              | :heavy_check_mark:                                                                 | Any JSON value; its shape is constrained by the flag's value_type.                 |