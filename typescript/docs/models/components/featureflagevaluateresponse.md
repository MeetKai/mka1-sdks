# FeatureFlagEvaluateResponse

## Example Usage

```typescript
import { FeatureFlagEvaluateResponse } from "@meetkai/mka1/models/components";

let value: FeatureFlagEvaluateResponse = {
  environment: "<value>",
  flags: {},
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `environment`                                                                                        | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `flags`                                                                                              | Record<string, [components.FeatureFlagEvaluation](../../models/components/featureflagevaluation.md)> | :heavy_check_mark:                                                                                   | N/A                                                                                                  |