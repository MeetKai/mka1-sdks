# UnarchiveFeatureFlagRequest

## Example Usage

```typescript
import { UnarchiveFeatureFlagRequest } from "@meetkai/mka1/models/operations";

let value: UnarchiveFeatureFlagRequest = {
  key: "<key>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `key`                                                               | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |