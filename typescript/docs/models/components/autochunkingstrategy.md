# AutoChunkingStrategy

The default chunking strategy. This strategy currently uses a max_chunk_size_tokens of 800 and chunk_overlap_tokens of 400.

## Example Usage

```typescript
import { AutoChunkingStrategy } from "@meetkai/mka1/models/components";

let value: AutoChunkingStrategy = {
  type: "auto",
};
```

## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `type`                                        | *"auto"*                                      | :heavy_check_mark:                            | Always 'auto'. The default chunking strategy. |