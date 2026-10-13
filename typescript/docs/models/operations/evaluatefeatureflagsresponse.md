# EvaluateFeatureFlagsResponse

## Example Usage

```typescript
import { EvaluateFeatureFlagsResponse } from "@meetkai/mka1/models/operations";

let value: EvaluateFeatureFlagsResponse = {
  headers: {
    "key": [
      "<value 1>",
      "<value 2>",
      "<value 3>",
    ],
    "key1": [
      "<value 1>",
    ],
    "key2": [
      "<value 1>",
      "<value 2>",
    ],
  },
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `headers`                                                                                        | Record<string, *string*[]>                                                                       | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `result`                                                                                         | [components.FeatureFlagEvaluateResponse](../../models/components/featureflagevaluateresponse.md) | :heavy_minus_sign:                                                                               | N/A                                                                                              |