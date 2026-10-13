# CreateChatCompletionStreamResponseBody

OK


## Supported Types

### `operations.One`

```typescript
const value: operations.One = {
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

### `operations.Two`

```typescript
const value: operations.Two = {
  event: "done",
};
```

### `operations.Three`

```typescript
const value: operations.Three = {
  event: "error",
};
```

