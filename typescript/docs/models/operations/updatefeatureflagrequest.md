# UpdateFeatureFlagRequest

## Example Usage

```typescript
import { UpdateFeatureFlagRequest } from "@meetkai/mka1/models/operations";

let value: UpdateFeatureFlagRequest = {
  key: "<key>",
  featureFlagUpdateRequest: {},
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `key`                                                                                      | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `featureFlagUpdateRequest`                                                                 | [components.FeatureFlagUpdateRequest](../../models/components/featureflagupdaterequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |