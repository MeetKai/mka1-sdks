# Content

The contents of the message. Can be a string, an array of content parts (for multimodal inputs), or null for assistant messages with tool calls.


## Supported Types

### `string`

```typescript
const value: string = "<value>";
```

### `components.Two[]`

```typescript
const value: components.Two[] = [
  {
    type: "input_audio",
    inputAudio: {
      data: "<value>",
      format: "mp3",
    },
  },
];
```

