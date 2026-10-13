# ExchangeApiKeyTokenRequest

## Example Usage

```typescript
import { ExchangeApiKeyTokenRequest } from "@meetkai/mka1/models/operations";

let value: ExchangeApiKeyTokenRequest = {
  requestBody: {
    audience: "https://quarrelsome-embossing.com/",
    externalUserId: "<id>",
  },
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                                          | *string*                                                                                               | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |
| `requestBody`                                                                                          | [operations.ExchangeApiKeyTokenRequestBody](../../models/operations/exchangeapikeytokenrequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |