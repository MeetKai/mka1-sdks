# FeatureFlagCondition

## Example Usage

```typescript
import { FeatureFlagCondition } from "@meetkai/mka1/models/components";

let value: FeatureFlagCondition = {
  operator: "eq",
  trait: "<value>",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `operator`                                                                       | [components.FeatureFlagOperator](../../models/components/featureflagoperator.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `trait`                                                                          | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `value`                                                                          | *any*                                                                            | :heavy_minus_sign:                                                               | Any JSON value; its shape is constrained by the flag's value_type.               |