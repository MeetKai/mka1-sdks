# One

## Example Usage

```typescript
import { One } from "@meetkai/mka1/models/operations";

let value: One = {
  event: "message",
  data: {
    id: "<id>",
    object: "chat.completion.chunk",
    created: 495950,
    model: "2",
    choices: [],
  },
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `event`                                                                                      | *"message"*                                                                                  | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `data`                                                                                       | [components.OpenAIChatCompletionChunk](../../models/components/openaichatcompletionchunk.md) | :heavy_check_mark:                                                                           | Represents a streamed chunk of a chat completion response                                    |
| `id`                                                                                         | *string*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          |
| `retry`                                                                                      | *number*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          |