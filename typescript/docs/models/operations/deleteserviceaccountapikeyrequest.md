# DeleteServiceAccountApiKeyRequest

## Example Usage

```typescript
import { DeleteServiceAccountApiKeyRequest } from "@meetkai/mka1/models/operations";

let value: DeleteServiceAccountApiKeyRequest = {
  orgId: "<id>",
  saId: "<id>",
  keyId: "<id>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `orgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `saId`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `keyId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |