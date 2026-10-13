# InputMessageContent


## Supported Types

### `string`

```typescript
const value: string = "<value>";
```

### `components.InputText`

```typescript
const value: components.InputText = {
  type: "input_text",
  text: "<value>",
};
```

### `components.InputImage`

```typescript
const value: components.InputImage = {
  type: "input_image",
};
```

### `components.InputFile`

```typescript
const value: components.InputFile = {
  type: "input_file",
};
```

### `components.InputAudio`

```typescript
const value: components.InputAudio = {
  type: "input_audio",
  inputAudio: {
    data: "<value>",
    format: "mp3",
  },
};
```

### `components.OutputText`

```typescript
const value: components.OutputText = {
  type: "output_text",
  text: "<value>",
};
```

### `components.Refusal`

```typescript
const value: components.Refusal = {
  type: "refusal",
  refusal: "<value>",
};
```

