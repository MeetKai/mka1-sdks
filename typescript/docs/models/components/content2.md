# Content2

A content part that can be included in a message. Supports text, images, audio, and files.


## Supported Types

### `components.OpenAIChatCompletionChoice21`

```typescript
const value: components.OpenAIChatCompletionChoice21 = {
  type: "text",
  text: "<value>",
};
```

### `components.OpenAIChatCompletionChoice22`

```typescript
const value: components.OpenAIChatCompletionChoice22 = {
  type: "image_url",
  imageUrl: {
    url: "https://bruised-brace.info/",
  },
};
```

### `components.OpenAIChatCompletionChoice23`

```typescript
const value: components.OpenAIChatCompletionChoice23 = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "wav",
  },
};
```

### `components.OpenAIChatCompletionChoice24`

```typescript
const value: components.OpenAIChatCompletionChoice24 = {
  type: "file",
  file: {
    fileId: "<id>",
  },
};
```

