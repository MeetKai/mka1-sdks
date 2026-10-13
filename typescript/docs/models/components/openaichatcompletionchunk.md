# OpenAIChatCompletionChunk

Represents a streamed chunk of a chat completion response

## Example Usage

```typescript
import { OpenAIChatCompletionChunk } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunk = {
  id: "<id>",
  object: "chat.completion.chunk",
  created: 959213,
  model: "Element",
  choices: [],
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `id`                                                                                         | *string*                                                                                     | :heavy_check_mark:                                                                           | A unique identifier for the chat completion                                                  |
| `object`                                                                                     | *"chat.completion.chunk"*                                                                    | :heavy_check_mark:                                                                           | The object type, always 'chat.completion.chunk'                                              |
| `created`                                                                                    | *number*                                                                                     | :heavy_check_mark:                                                                           | The Unix timestamp (in seconds) of when the chat completion was created                      |
| `model`                                                                                      | *string*                                                                                     | :heavy_check_mark:                                                                           | The model used for the chat completion                                                       |
| `choices`                                                                                    | [components.Choices](../../models/components/choices.md)[]                                   | :heavy_check_mark:                                                                           | A list of chat completion choices in this chunk                                              |
| `usage`                                                                                      | [components.OpenAIChatCompletionUsage](../../models/components/openaichatcompletionusage.md) | :heavy_minus_sign:                                                                           | Usage statistics for the completion request                                                  |
| `systemFingerprint`                                                                          | *string*                                                                                     | :heavy_minus_sign:                                                                           | This fingerprint represents the backend configuration that the model runs with               |