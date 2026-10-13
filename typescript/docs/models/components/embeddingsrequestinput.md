# EmbeddingsRequestInput

The input text or array of texts to generate embeddings for. Can be a single string or an array of strings. Note: batch size and input length limits vary by model. See GET /embeddings/models for model-specific limits.


## Supported Types

### `string`

```typescript
const value: string = "<value>";
```

### `string[]`

```typescript
const value: string[] = [
  "<value 1>",
  "<value 2>",
];
```

