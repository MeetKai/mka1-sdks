# GetCompletionFeedbackRequest

## Example Usage

```typescript
import { GetCompletionFeedbackRequest } from "@meetkai/mka1/models/operations";

let value: GetCompletionFeedbackRequest = {
  id: "chatcmpl-abc123def456",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | chatcmpl-abc123def456                                               |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |