# RegenerateServiceAccountApiKeyRequest

## Example Usage

```typescript
import { RegenerateServiceAccountApiKeyRequest } from "@meetkai/mka1/models/operations";

let value: RegenerateServiceAccountApiKeyRequest = {
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