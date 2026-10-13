# BatchGetFeedbackResponse

Response containing batch feedback results. Each result is either the feedback data or a not_found error.

## Example Usage

```typescript
import { BatchGetFeedbackResponse } from "@meetkai/mka1/models/components";

let value: BatchGetFeedbackResponse = {
  results: [],
};
```

## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `results`                                                    | *components.Results*[]                                       | :heavy_check_mark:                                           | Array of feedback results in the same order as the input IDs |