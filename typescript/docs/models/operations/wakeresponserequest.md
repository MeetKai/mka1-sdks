# WakeResponseRequest

## Example Usage

```typescript
import { WakeResponseRequest } from "@meetkai/mka1/models/operations";

let value: WakeResponseRequest = {
  responseId: "resp_sleep123",
  requestBody: {
    input: "<value>",
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `responseId`                                                                             | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | resp_sleep123                                                                            |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `requestBody`                                                                            | [operations.WakeResponseRequestBody](../../models/operations/wakeresponserequestbody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |