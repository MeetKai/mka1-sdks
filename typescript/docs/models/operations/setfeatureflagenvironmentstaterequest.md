# SetFeatureFlagEnvironmentStateRequest

## Example Usage

```typescript
import { SetFeatureFlagEnvironmentStateRequest } from "@meetkai/mka1/models/operations";

let value: SetFeatureFlagEnvironmentStateRequest = {
  key: "<key>",
  env: "<value>",
  featureFlagStateInput: {
    enabled: true,
    overrides: [
      {
        enabled: false,
        identity: "<value>",
      },
    ],
    rolloutPercentage: 176595,
    rules: [
      {
        conditions: [],
        enabled: true,
      },
    ],
    value: "<value>",
  },
};
```

## Fields

| Field                                                                                                                                                                                                                            | Type                                                                                                                                                                                                                             | Required                                                                                                                                                                                                                         | Description                                                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `key`                                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `env`                                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |
| `ifMatch`                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                               | The `version` of the state you read and edited. When supplied, the write is refused with `412` if anyone changed the state in the meantime, instead of silently overwriting them. `*` matches the current state unconditionally. |
| `xOnBehalfOf`                                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                              |
| `featureFlagStateInput`                                                                                                                                                                                                          | [components.FeatureFlagStateInput](../../models/components/featureflagstateinput.md)                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                               | N/A                                                                                                                                                                                                                              |