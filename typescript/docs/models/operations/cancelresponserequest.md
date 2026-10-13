# CancelResponseRequest

## Example Usage

```typescript
import { CancelResponseRequest } from "@meetkai/mka1/models/operations";

let value: CancelResponseRequest = {
  responseId: "resp_cancel123",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `responseId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp_cancel123                                                      |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |