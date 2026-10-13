# CreateVectorStoreFileRequestChunkingStrategy

The chunking strategy used to chunk the file(s). If not set, will use the auto strategy.


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

