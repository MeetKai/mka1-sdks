# UpdateFeatureFlagProjectRequest

## Example Usage

```typescript
import { UpdateFeatureFlagProjectRequest } from "@meetkai/mka1/models/operations";

let value: UpdateFeatureFlagProjectRequest = {
  project: "<value>",
  featureFlagProjectUpdateRequest: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `project`                                                                                                | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `featureFlagProjectUpdateRequest`                                                                        | [components.FeatureFlagProjectUpdateRequest](../../models/components/featureflagprojectupdaterequest.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |