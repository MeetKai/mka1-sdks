# ChunkingStrategy


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

### `components.OtherChunkingStrategy`

```typescript
const value: components.OtherChunkingStrategy = {
  type: "other",
};
```

