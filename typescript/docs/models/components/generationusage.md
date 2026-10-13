# GenerationUsage

api.md §3 `usage`, the shape of the runtime's `llm.Usage`.

## Example Usage

```typescript
import { GenerationUsage } from "@meetkai/mka1/models/components";

let value: GenerationUsage = {};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `calls`                                                                                            | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `inputTokens`                                                                                      | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `outputTokens`                                                                                     | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `byModel`                                                                                          | Record<string, [components.GenerationModelUsage](../../models/components/generationmodelusage.md)> | :heavy_minus_sign:                                                                                 | N/A                                                                                                |