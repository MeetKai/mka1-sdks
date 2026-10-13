# StreamOptions

Options for streaming response. Only set this when you set stream: true.

## Example Usage

```typescript
import { StreamOptions } from "@meetkai/mka1/models/components";

let value: StreamOptions = {};
```

## Fields

| Field                                                                                                                                                                     | Type                                                                                                                                                                      | Required                                                                                                                                                                  | Description                                                                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `includeUsage`                                                                                                                                                            | *boolean*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                        | If set, an additional chunk with token usage statistics will be streamed before the data: [DONE] message. The usage field shows total token usage for the entire request. |