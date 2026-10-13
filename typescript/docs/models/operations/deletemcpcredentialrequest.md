# DeleteMcpCredentialRequest

## Example Usage

```typescript
import { DeleteMcpCredentialRequest } from "@meetkai/mka1/models/operations";

let value: DeleteMcpCredentialRequest = {
  credentialId: "mcp_cred_bb98f3c2223b566c9dfbcef895483209",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `credentialId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_cred_bb98f3c2223b566c9dfbcef895483209                           |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |