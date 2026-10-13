# OpenAIChatCompletionChunkToolCalls

A partial tool call delta in a streaming chunk

## Example Usage

```typescript
import { OpenAIChatCompletionChunkToolCalls } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunkToolCalls = {
  index: 126523,
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                         | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | The ID of the tool call                                                                                      |
| `type`                                                                                                       | *"function"*                                                                                                 | :heavy_minus_sign:                                                                                           | The type of the tool. Currently only 'function' is supported.                                                |
| `function`                                                                                                   | [components.OpenAIChatCompletionChunkFunction](../../models/components/openaichatcompletionchunkfunction.md) | :heavy_minus_sign:                                                                                           | The function that the model called                                                                           |
| `index`                                                                                                      | *number*                                                                                                     | :heavy_check_mark:                                                                                           | The index of the tool call in the list of tool calls                                                         |