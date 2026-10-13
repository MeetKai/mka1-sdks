# CreateVectorStoreFileBatchRequestChunkingStrategy

Batch-wide default chunking strategy, applied to every file that does not carry its own (a 'files' entry's chunking_strategy overrides this).


## Supported Types

### `components.AutoChunkingStrategy`

```typescript
const value: components.AutoChunkingStrategy = {
  type: "auto",
};
```

### `components.StaticChunkingStrategy`

```typescript
const value: components.StaticChunkingStrategy = {
  type: "static",
  static: {
    chunkOverlapTokens: 840690,
    maxChunkSizeTokens: 269752,
  },
};
```

