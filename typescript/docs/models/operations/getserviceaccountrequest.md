# GetServiceAccountRequest

## Example Usage

```typescript
import { GetServiceAccountRequest } from "@meetkai/mka1/models/operations";

let value: GetServiceAccountRequest = {
  orgId: "<id>",
  saId: "<id>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `orgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `saId`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |