# ReissueOwnerKeyRequest

## Example Usage

```typescript
import { ReissueOwnerKeyRequest } from "@meetkai/mka1/models/operations";

let value: ReissueOwnerKeyRequest = {
  id: "<id>",
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `xOnBehalfOf`                                                                                  | *string*                                                                                       | :heavy_minus_sign:                                                                             | Optional external end-user identifier forwarded by the API gateway.                            |
| `requestBody`                                                                                  | [operations.ReissueOwnerKeyRequestBody](../../models/operations/reissueownerkeyrequestbody.md) | :heavy_minus_sign:                                                                             | N/A                                                                                            |