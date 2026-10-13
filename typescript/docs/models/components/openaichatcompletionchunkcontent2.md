# OpenAIChatCompletionChunkContent2

A content part that can be included in a message. Supports text, images, audio, and files.


## Supported Types

### `components.OpenAIChatCompletionChunk21`

```typescript
const value: components.OpenAIChatCompletionChunk21 = {
  type: "text",
  text: "<value>",
};
```

### `components.OpenAIChatCompletionChunk22`

```typescript
const value: components.OpenAIChatCompletionChunk22 = {
  type: "image_url",
  imageUrl: {
    url: "https://colossal-statue.net/",
  },
};
```

### `components.OpenAIChatCompletionChunk23`

```typescript
const value: components.OpenAIChatCompletionChunk23 = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "mp3",
  },
};
```

### `components.OpenAIChatCompletionChunk24`

```typescript
const value: components.OpenAIChatCompletionChunk24 = {
  type: "file",
  file: {
    fileId: "<id>",
  },
};
```

