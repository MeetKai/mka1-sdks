# CreateFeatureFlagProjectRequest

## Example Usage

```typescript
import { CreateFeatureFlagProjectRequest } from "@meetkai/mka1/models/operations";

let value: CreateFeatureFlagProjectRequest = {
  featureFlagProjectCreateRequest: {
    key: "<key>",
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `featureFlagProjectCreateRequest`                                                                        | [components.FeatureFlagProjectCreateRequest](../../models/components/featureflagprojectcreaterequest.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |