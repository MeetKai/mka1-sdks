# GenerateFeatureFlagEvaluationKeyResponse

## Example Usage

```typescript
import { GenerateFeatureFlagEvaluationKeyResponse } from "@meetkai/mka1/models/operations";

let value: GenerateFeatureFlagEvaluationKeyResponse = {
  headers: {
    "key": [
      "<value 1>",
    ],
    "key1": [
      "<value 1>",
    ],
    "key2": [
      "<value 1>",
    ],
  },
  result: {
    key: "<key>",
  },
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `headers`                                                                                                  | Record<string, *string*[]>                                                                                 | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `result`                                                                                                   | [components.FeatureFlagEvaluationKeyResponse](../../models/components/featureflagevaluationkeyresponse.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |