# DeleteResponseRequest

## Example Usage

```typescript
import { DeleteResponseRequest } from "@meetkai/mka1/models/operations";

let value: DeleteResponseRequest = {
  responseId: "resp_abc123",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `responseId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp_abc123                                                         |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |