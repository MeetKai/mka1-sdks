# GetJwtFromKeyRequest

## Example Usage

```typescript
import { GetJwtFromKeyRequest } from "@meetkai/mka1/models/operations";

let value: GetJwtFromKeyRequest = {
  requestBody: {
    audience: "https://uniform-thongs.com/",
    externalUserId: "<id>",
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `requestBody`                                                                              | [operations.GetJwtFromKeyRequestBody](../../models/operations/getjwtfromkeyrequestbody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |