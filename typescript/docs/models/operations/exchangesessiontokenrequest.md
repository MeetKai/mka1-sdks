# ExchangeSessionTokenRequest

## Example Usage

```typescript
import { ExchangeSessionTokenRequest } from "@meetkai/mka1/models/operations";

let value: ExchangeSessionTokenRequest = {
  requestBody: {
    audience: "https://worse-steak.info/",
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `requestBody`                                                                                            | [operations.ExchangeSessionTokenRequestBody](../../models/operations/exchangesessiontokenrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |