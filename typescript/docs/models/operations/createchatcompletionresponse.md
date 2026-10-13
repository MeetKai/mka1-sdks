# CreateChatCompletionResponse


## Supported Types

### `components.OpenAIChatCompletion`

```typescript
const value: components.OpenAIChatCompletion = {
  id: "chatcmpl-abc123",
  object: "chat.completion",
  created: 1704067200,
  model: "meetkai:functionary-urdu-mini-pak",
  choices: [
    {
      index: 0,
      message: {
        role: "assistant",
        content: "The capital of France is Paris.",
      },
      finishReason: "stop",
    },
  ],
  usage: {
    promptTokens: 15,
    completionTokens: 8,
    totalTokens: 23,
  },
};
```

### `string`

```typescript
const value: string = "<value>";
```

