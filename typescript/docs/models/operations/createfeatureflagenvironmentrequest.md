# CreateFeatureFlagEnvironmentRequest

## Example Usage

```typescript
import { CreateFeatureFlagEnvironmentRequest } from "@meetkai/mka1/models/operations";

let value: CreateFeatureFlagEnvironmentRequest = {
  featureFlagEnvironmentCreateRequest: {
    key: "<key>",
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                                            | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                                    | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |
| `featureFlagEnvironmentCreateRequest`                                                                            | [components.FeatureFlagEnvironmentCreateRequest](../../models/components/featureflagenvironmentcreaterequest.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |