# SearchVectorStoreRequestRankingOptions

Ranking options for search.

## Example Usage

```typescript
import { SearchVectorStoreRequestRankingOptions } from "@meetkai/mka1/models/components";

let value: SearchVectorStoreRequestRankingOptions = {};
```

## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `ranker`                                                                    | [components.Ranker](../../models/components/ranker.md)                      | :heavy_minus_sign:                                                          | Enable re-ranking; set to 'none' to disable, which can help reduce latency. |
| `scoreThreshold`                                                            | *number*                                                                    | :heavy_minus_sign:                                                          | Minimum score threshold for search results.                                 |