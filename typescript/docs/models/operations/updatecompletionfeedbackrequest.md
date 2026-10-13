# UpdateCompletionFeedbackRequest

## Example Usage

```typescript
import { UpdateCompletionFeedbackRequest } from "@meetkai/mka1/models/operations";

let value: UpdateCompletionFeedbackRequest = {
  id: "chatcmpl-abc123def456",
  requestBody: {},
};
```

## Fields

| Field                                                                                                            | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      | Example                                                                                                          |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                             | *string*                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              | chatcmpl-abc123def456                                                                                            |
| `xOnBehalfOf`                                                                                                    | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |                                                                                                                  |
| `requestBody`                                                                                                    | [operations.UpdateCompletionFeedbackRequestBody](../../models/operations/updatecompletionfeedbackrequestbody.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |                                                                                                                  |