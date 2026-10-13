# CreateFeatureFlagRequest

## Example Usage

```typescript
import { CreateFeatureFlagRequest } from "@meetkai/mka1/models/operations";

let value: CreateFeatureFlagRequest = {
  featureFlagCreateRequest: {
    defaultValue: "<value>",
    key: "<key>",
    name: "<value>",
    valueType: "json",
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `featureFlagCreateRequest`                                                                 | [components.FeatureFlagCreateRequest](../../models/components/featureflagcreaterequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |