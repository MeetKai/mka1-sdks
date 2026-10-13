# StaticChunkingStrategy

Customize your own chunking strategy by setting chunk size and chunk overlap.

## Example Usage

```typescript
import { StaticChunkingStrategy } from "@meetkai/mka1/models/components";

let value: StaticChunkingStrategy = {
  type: "static",
  static: {
    chunkOverlapTokens: 840690,
    maxChunkSizeTokens: 269752,
  },
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `type`                                                 | *"static"*                                             | :heavy_check_mark:                                     | Always 'static'.                                       |
| `static`                                               | [components.Static](../../models/components/static.md) | :heavy_check_mark:                                     | N/A                                                    |