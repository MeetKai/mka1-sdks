# Two

A content part that can be included in a message. Supports text, images, audio, and files.


## Supported Types

### `components.Two1`

```typescript
const value: components.Two1 = {
  type: "text",
  text: "<value>",
};
```

### `components.Two2`

```typescript
const value: components.Two2 = {
  type: "image_url",
  imageUrl: {
    url: "https://frequent-passport.com",
  },
};
```

### `components.Two3`

```typescript
const value: components.Two3 = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "mp3",
  },
};
```

### `components.Two4`

```typescript
const value: components.Two4 = {
  type: "file",
  file: {
    filename: "example.file",
    fileData: "<value>",
  },
};
```

