# GetResponseFeedbackRequest

## Example Usage

```typescript
import { GetResponseFeedbackRequest } from "@meetkai/mka1/models/operations";

let value: GetResponseFeedbackRequest = {
  id: "resp-xyz789",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | resp-xyz789                                                         |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |