# CreateServiceAccountRequest

## Example Usage

```typescript
import { CreateServiceAccountRequest } from "@meetkai/mka1/models/operations";

let value: CreateServiceAccountRequest = {
  orgId: "<id>",
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `orgId`                                                                                                  | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `requestBody`                                                                                            | [operations.CreateServiceAccountRequestBody](../../models/operations/createserviceaccountrequestbody.md) | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |