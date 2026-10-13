# BatchGetCompletionFeedbackRequest

## Example Usage

```typescript
import { BatchGetCompletionFeedbackRequest } from "@meetkai/mka1/models/operations";

let value: BatchGetCompletionFeedbackRequest = {
  batchGetFeedbackRequest: {
    ids: [
      "chatcmpl-abc123",
      "chatcmpl-def456",
      "resp-xyz789",
    ],
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `batchGetFeedbackRequest`                                                                | [components.BatchGetFeedbackRequest](../../models/components/batchgetfeedbackrequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      | {<br/>"ids": [<br/>"chatcmpl-abc123",<br/>"chatcmpl-def456",<br/>"resp-xyz789"<br/>]<br/>} |