# EvaluateFeatureFlagsWithTraitsRequest

## Example Usage

```typescript
import { EvaluateFeatureFlagsWithTraitsRequest } from "@meetkai/mka1/models/operations";

let value: EvaluateFeatureFlagsWithTraitsRequest = {
  env: "<value>",
  featureFlagEvaluateRequest: {},
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `env`                                                                                          | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | *string*                                                                                       | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `featureFlagEvaluateRequest`                                                                   | [components.FeatureFlagEvaluateRequest](../../models/components/featureflagevaluaterequest.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |