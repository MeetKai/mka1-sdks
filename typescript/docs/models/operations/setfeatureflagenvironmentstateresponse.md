# SetFeatureFlagEnvironmentStateResponse

## Example Usage

```typescript
import { SetFeatureFlagEnvironmentStateResponse } from "@meetkai/mka1/models/operations";

let value: SetFeatureFlagEnvironmentStateResponse = {
  headers: {
    "key": [
      "<value 1>",
      "<value 2>",
    ],
    "key1": [
      "<value 1>",
      "<value 2>",
      "<value 3>",
    ],
    "key2": [
      "<value 1>",
      "<value 2>",
    ],
  },
  result: {
    enabled: true,
    overrides: [],
    rolloutPercentage: 471492,
    rules: [],
    value: "<value>",
    updatedAt: new Date("2025-07-24T14:40:09.044Z"),
    version: "<value>",
  },
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `headers`                                                                  | Record<string, *string*[]>                                                 | :heavy_check_mark:                                                         | N/A                                                                        |
| `result`                                                                   | [components.FeatureFlagState](../../models/components/featureflagstate.md) | :heavy_check_mark:                                                         | N/A                                                                        |