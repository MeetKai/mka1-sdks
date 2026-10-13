# SearchVectorStoreRequest

Request body for searching a vector store.

## Example Usage

```typescript
import { SearchVectorStoreRequest } from "@meetkai/mka1/models/components";

let value: SearchVectorStoreRequest = {
  query: "How do I reset my password?",
  maxNumResults: 5,
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `query`                                                                                                                | *components.Query*                                                                                                     | :heavy_check_mark:                                                                                                     | A query string for a search, or an array of query strings.                                                             |
| `filters`                                                                                                              | *components.Filter*                                                                                                    | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |
| `maxNumResults`                                                                                                        | *number*                                                                                                               | :heavy_minus_sign:                                                                                                     | The maximum number of results to return. This number should be between 1 and 50 inclusive.                             |
| `rankingOptions`                                                                                                       | [components.SearchVectorStoreRequestRankingOptions](../../models/components/searchvectorstorerequestrankingoptions.md) | :heavy_minus_sign:                                                                                                     | Ranking options for search.                                                                                            |
| `rewriteQuery`                                                                                                         | *boolean*                                                                                                              | :heavy_minus_sign:                                                                                                     | Whether to rewrite the natural language query for vector search.                                                       |