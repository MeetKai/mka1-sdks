# ResponsesCreateRequestStreamOptions

## Example Usage

```typescript
import { ResponsesCreateRequestStreamOptions } from "@meetkai/mka1/models/components";

let value: ResponsesCreateRequestStreamOptions = {};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `includeUsage`                                                                                     | *boolean*                                                                                          | :heavy_minus_sign:                                                                                 | Whether to include token usage statistics in the stream. Useful for monitoring costs in real-time. |
| `includeObfuscation`                                                                               | *boolean*                                                                                          | :heavy_minus_sign:                                                                                 | Whether to enable stream obfuscation for privacy and security purposes during streaming.           |