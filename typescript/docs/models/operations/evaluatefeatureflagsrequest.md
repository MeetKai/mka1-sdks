# EvaluateFeatureFlagsRequest

## Example Usage

```typescript
import { EvaluateFeatureFlagsRequest } from "@meetkai/mka1/models/operations";

let value: EvaluateFeatureFlagsRequest = {
  env: "<value>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `env`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `identity`                                                          | *string*                                                            | :heavy_minus_sign:                                                  | Stable identifier of the caller; enables rollouts and overrides.    |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |