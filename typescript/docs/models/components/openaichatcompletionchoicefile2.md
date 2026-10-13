# OpenAIChatCompletionChoiceFile2

## Example Usage

```typescript
import { OpenAIChatCompletionChoiceFile2 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoiceFile2 = {
  fileId: "<id>",
};
```

## Fields

| Field                                               | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `fileId`                                            | *string*                                            | :heavy_check_mark:                                  | The unique identifier of a previously uploaded file |
| `filename`                                          | *string*                                            | :heavy_minus_sign:                                  | Optional filename override                          |