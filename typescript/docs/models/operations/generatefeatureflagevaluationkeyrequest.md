# GenerateFeatureFlagEvaluationKeyRequest

## Example Usage

```typescript
import { GenerateFeatureFlagEvaluationKeyRequest } from "@meetkai/mka1/models/operations";

let value: GenerateFeatureFlagEvaluationKeyRequest = {
  env: "<value>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `env`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |