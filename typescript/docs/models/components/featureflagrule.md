# FeatureFlagRule

## Example Usage

```typescript
import { FeatureFlagRule } from "@meetkai/mka1/models/components";

let value: FeatureFlagRule = {
  conditions: [],
  enabled: true,
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `conditions`                                                                         | [components.FeatureFlagCondition](../../models/components/featureflagcondition.md)[] | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `description`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `enabled`                                                                            | *boolean*                                                                            | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `rolloutPercentage`                                                                  | *number*                                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `value`                                                                              | *any*                                                                                | :heavy_minus_sign:                                                                   | Any JSON value; its shape is constrained by the flag's value_type.                   |