# UpdateFeatureFlagEnvironmentRequest

## Example Usage

```typescript
import { UpdateFeatureFlagEnvironmentRequest } from "@meetkai/mka1/models/operations";

let value: UpdateFeatureFlagEnvironmentRequest = {
  env: "<value>",
  featureFlagEnvironmentUpdateRequest: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                                            | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `env`                                                                                                            | *string*                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `xOnBehalfOf`                                                                                                    | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |
| `featureFlagEnvironmentUpdateRequest`                                                                            | [components.FeatureFlagEnvironmentUpdateRequest](../../models/components/featureflagenvironmentupdaterequest.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |