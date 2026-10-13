# BatchGetFeedbackRequest

Request parameters for batch retrieving feedback by multiple request IDs.

## Example Usage

```typescript
import { BatchGetFeedbackRequest } from "@meetkai/mka1/models/components";

let value: BatchGetFeedbackRequest = {
  ids: [
    "chatcmpl-abc123",
    "chatcmpl-def456",
    "resp-xyz789",
  ],
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `ids`                                                                    | *string*[]                                                               | :heavy_check_mark:                                                       | Array of request IDs (chatcmpl-xxx or resp-xxx) to retrieve feedback for |