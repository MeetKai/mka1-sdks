# UpdateServiceAccountApiKeyRequest

## Example Usage

```typescript
import { UpdateServiceAccountApiKeyRequest } from "@meetkai/mka1/models/operations";

let value: UpdateServiceAccountApiKeyRequest = {
  orgId: "<id>",
  saId: "<id>",
  keyId: "<id>",
};
```

## Fields

| Field                                                                                                                | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `orgId`                                                                                                              | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `saId`                                                                                                               | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `keyId`                                                                                                              | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `xOnBehalfOf`                                                                                                        | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                                  |
| `requestBody`                                                                                                        | [operations.UpdateServiceAccountApiKeyRequestBody](../../models/operations/updateserviceaccountapikeyrequestbody.md) | :heavy_minus_sign:                                                                                                   | N/A                                                                                                                  |